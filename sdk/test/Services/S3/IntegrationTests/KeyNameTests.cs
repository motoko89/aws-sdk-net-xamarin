﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Net;


namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Just a class to ensure customers who try the most awkward names for S3 objects
    /// will be fully satisifed and leave us alone :-)
    /// </summary>
    [TestClass]
    public class KeyNameTests
    {
        private static readonly string[] AwkwardKeyNameBases =
        {
            @"ObjectWith!and?\+forgood:measureThis=And&InKeynÄme",
            @"ObjectWith\InKeyname",
            @"ObjectWith/InKeyname",
            @"ObjectWith\InKeynÄme",
            @"ObjectWith/InKeynÄme",
            @"ObjectWith$InKeynÄme",
            @"ObjectWith%2FInKeyname.Ext"
        };

        static string bucketName;

        [ClassInitialize]
        public static void Initialize(TestContext a)
        {
            IAmazonS3 s3Client = new AmazonS3Client();
            bucketName = S3TestUtils.CreateBucketWithWait(s3Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            IAmazonS3 s3Client = new AmazonS3Client();
            AmazonS3Util.DeleteS3BucketWithObjects(s3Client, bucketName);
        }

        [TestCategory("S3")]
        [TestMethod]
        public void TestKeyNameWithAwkwardChars_AWS2Signing()
        {
            var original = AWSConfigsS3.UseSignatureVersion4;
            AWSConfigsS3.UseSignatureVersion4 = false;
            try
            {
                IAmazonS3 s3Client = new AmazonS3Client();

                foreach (var k in AwkwardKeyNameBases)
                {
                    var keyName = k + ".SigV2.AWS2.CLRv" + Environment.Version;
                    PutAndGetObjectWithQuestionableKey(s3Client, bucketName, keyName);
                }
            }
            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = original;
            }
        }

        [TestCategory("S3")]
        [TestMethod]
        public void TestKeyNameWithAwkwardChars_AWS4Signing()
        {
            var original = AWSConfigsS3.UseSignatureVersion4;
            AWSConfigsS3.UseSignatureVersion4 = true;
            try
            {
                IAmazonS3 s3Client = new AmazonS3Client();

                foreach (var k in AwkwardKeyNameBases)
                {
                    var keyName = k + ".SigV4.AWS2.CLRv" + Environment.Version;
                    PutAndGetObjectWithQuestionableKey(s3Client, bucketName, keyName);
                }
            }
            finally
            {
                AWSConfigsS3.UseSignatureVersion4 = original;
            }
        }

        static void PutAndGetObjectWithQuestionableKey(IAmazonS3 s3Client, string bucketName, string keyName)
        {
            const string testContent = "Some stuff to write as content";

            s3Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = testContent
            });

            var response = s3Client.GetObject(new GetObjectRequest
            {
                BucketName = bucketName,
                Key = keyName
            });

            using (var s = new StreamReader(response.ResponseStream))
            {
                var responseContent = s.ReadToEnd();
                Assert.AreEqual(testContent, responseContent);
            }

            var presignedUrl = s3Client.GetPreSignedURL(new GetPreSignedUrlRequest
            {
                BucketName = bucketName,
                Key = keyName,
                Verb = HttpVerb.GET,
                Expires = DateTime.Now + TimeSpan.FromDays(5)
            });

            var httpRequest = HttpWebRequest.Create(presignedUrl);
            using(var httpResponse = httpRequest.GetResponse())
            using(var reader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var content = reader.ReadToEnd();
                Assert.AreEqual(testContent, content);
            }
        }
    }
}
