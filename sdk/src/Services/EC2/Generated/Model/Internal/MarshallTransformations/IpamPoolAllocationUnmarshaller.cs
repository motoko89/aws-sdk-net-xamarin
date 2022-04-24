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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for IpamPoolAllocation Object
    /// </summary>  
    public class IpamPoolAllocationUnmarshaller : IUnmarshaller<IpamPoolAllocation, XmlUnmarshallerContext>, IUnmarshaller<IpamPoolAllocation, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IpamPoolAllocation Unmarshall(XmlUnmarshallerContext context)
        {
            IpamPoolAllocation unmarshalledObject = new IpamPoolAllocation();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("cidr", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Cidr = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ipamPoolAllocationId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.IpamPoolAllocationId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceOwner", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceOwner = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceRegion", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceRegion = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public IpamPoolAllocation Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static IpamPoolAllocationUnmarshaller _instance = new IpamPoolAllocationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IpamPoolAllocationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}