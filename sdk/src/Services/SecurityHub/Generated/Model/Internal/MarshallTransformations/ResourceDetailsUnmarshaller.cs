/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceDetails Object
    /// </summary>  
    public class ResourceDetailsUnmarshaller : IUnmarshaller<ResourceDetails, XmlUnmarshallerContext>, IUnmarshaller<ResourceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceDetails IUnmarshaller<ResourceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ResourceDetails unmarshalledObject = new ResourceDetails();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AwsCloudFrontDistribution", targetDepth))
                {
                    var unmarshaller = AwsCloudFrontDistributionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCloudFrontDistribution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsCodeBuildProject", targetDepth))
                {
                    var unmarshaller = AwsCodeBuildProjectDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsCodeBuildProject = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2Instance", targetDepth))
                {
                    var unmarshaller = AwsEc2InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2Instance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2NetworkInterface", targetDepth))
                {
                    var unmarshaller = AwsEc2NetworkInterfaceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2NetworkInterface = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsEc2SecurityGroup", targetDepth))
                {
                    var unmarshaller = AwsEc2SecurityGroupDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsEc2SecurityGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsElasticsearchDomain", targetDepth))
                {
                    var unmarshaller = AwsElasticsearchDomainDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElasticsearchDomain = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsElbv2LoadBalancer", targetDepth))
                {
                    var unmarshaller = AwsElbv2LoadBalancerDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsElbv2LoadBalancer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamAccessKey", targetDepth))
                {
                    var unmarshaller = AwsIamAccessKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamAccessKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsIamRole", targetDepth))
                {
                    var unmarshaller = AwsIamRoleDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsIamRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsKmsKey", targetDepth))
                {
                    var unmarshaller = AwsKmsKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsKmsKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsLambdaFunction", targetDepth))
                {
                    var unmarshaller = AwsLambdaFunctionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsLambdaFunction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsLambdaLayerVersion", targetDepth))
                {
                    var unmarshaller = AwsLambdaLayerVersionDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsLambdaLayerVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsRdsDbInstance", targetDepth))
                {
                    var unmarshaller = AwsRdsDbInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsRdsDbInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsS3Bucket", targetDepth))
                {
                    var unmarshaller = AwsS3BucketDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsS3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSnsTopic", targetDepth))
                {
                    var unmarshaller = AwsSnsTopicDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSnsTopic = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsSqsQueue", targetDepth))
                {
                    var unmarshaller = AwsSqsQueueDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsSqsQueue = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AwsWafWebAcl", targetDepth))
                {
                    var unmarshaller = AwsWafWebAclDetailsUnmarshaller.Instance;
                    unmarshalledObject.AwsWafWebAcl = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Container", targetDepth))
                {
                    var unmarshaller = ContainerDetailsUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Other", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Other = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ResourceDetailsUnmarshaller _instance = new ResourceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}