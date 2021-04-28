/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the default server-side encryption settings for an S3 bucket.
    /// For detailed information about these settings, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucket-encryption.html">Setting
    /// default server-side encryption behavior for Amazon S3 buckets</a> in the <i>Amazon
    /// Simple Storage Service User Guide</i>.
    /// </summary>
    public partial class BucketServerSideEncryption
    {
        private string _kmsMasterKeyId;
        private Type _type;

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) or unique identifier (key ID) for the AWS Key Management
        /// Service (AWS KMS) customer master key (CMK) that's used by default to encrypt objects
        /// that are added to the bucket. This value is null if the bucket uses an Amazon S3 managed
        /// key to encrypt new objects or the bucket doesn't encrypt new objects by default.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId
        {
            get { return this._kmsMasterKeyId; }
            set { this._kmsMasterKeyId = value; }
        }

        // Check to see if KmsMasterKeyId property is set
        internal bool IsSetKmsMasterKeyId()
        {
            return this._kmsMasterKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of server-side encryption that's used by default when storing new objects
        /// in the bucket. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// AES256 - New objects are encrypted with an Amazon S3 managed key and use Amazon S3
        /// managed encryption (SSE-S3).
        /// </para>
        /// </li> <li>
        /// <para>
        /// aws:kms - New objects are encrypted with an AWS KMS CMK, specified by the kmsMasterKeyId
        /// property, and use AWS managed AWS KMS encryption (AWS-KMS) or customer managed AWS
        /// KMS encryption (SSE-KMS).
        /// </para>
        /// </li> <li>
        /// <para>
        /// NONE - New objects aren't encrypted by default. Default encryption is disabled for
        /// the bucket.
        /// </para>
        /// </li></ul>
        /// </summary>
        public Type Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}