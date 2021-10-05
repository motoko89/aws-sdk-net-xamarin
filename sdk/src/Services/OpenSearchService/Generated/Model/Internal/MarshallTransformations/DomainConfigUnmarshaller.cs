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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.OpenSearchService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.OpenSearchService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DomainConfig Object
    /// </summary>  
    public class DomainConfigUnmarshaller : IUnmarshaller<DomainConfig, XmlUnmarshallerContext>, IUnmarshaller<DomainConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DomainConfig IUnmarshaller<DomainConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DomainConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DomainConfig unmarshalledObject = new DomainConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("AccessPolicies", targetDepth))
                {
                    var unmarshaller = AccessPoliciesStatusUnmarshaller.Instance;
                    unmarshalledObject.AccessPolicies = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdvancedOptions", targetDepth))
                {
                    var unmarshaller = AdvancedOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.AdvancedOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AdvancedSecurityOptions", targetDepth))
                {
                    var unmarshaller = AdvancedSecurityOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.AdvancedSecurityOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("AutoTuneOptions", targetDepth))
                {
                    var unmarshaller = AutoTuneOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.AutoTuneOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ClusterConfig", targetDepth))
                {
                    var unmarshaller = ClusterConfigStatusUnmarshaller.Instance;
                    unmarshalledObject.ClusterConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CognitoOptions", targetDepth))
                {
                    var unmarshaller = CognitoOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.CognitoOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DomainEndpointOptions", targetDepth))
                {
                    var unmarshaller = DomainEndpointOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.DomainEndpointOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EBSOptions", targetDepth))
                {
                    var unmarshaller = EBSOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.EBSOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EncryptionAtRestOptions", targetDepth))
                {
                    var unmarshaller = EncryptionAtRestOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.EncryptionAtRestOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("EngineVersion", targetDepth))
                {
                    var unmarshaller = VersionStatusUnmarshaller.Instance;
                    unmarshalledObject.EngineVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LogPublishingOptions", targetDepth))
                {
                    var unmarshaller = LogPublishingOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.LogPublishingOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NodeToNodeEncryptionOptions", targetDepth))
                {
                    var unmarshaller = NodeToNodeEncryptionOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.NodeToNodeEncryptionOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("SnapshotOptions", targetDepth))
                {
                    var unmarshaller = SnapshotOptionsStatusUnmarshaller.Instance;
                    unmarshalledObject.SnapshotOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("VPCOptions", targetDepth))
                {
                    var unmarshaller = VPCDerivedInfoStatusUnmarshaller.Instance;
                    unmarshalledObject.VPCOptions = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static DomainConfigUnmarshaller _instance = new DomainConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DomainConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}