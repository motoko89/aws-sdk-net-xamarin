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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Lightsail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Lightsail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Container Marshaller
    /// </summary>
    public class ContainerMarshaller : IRequestMarshaller<Container, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(Container requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetCommand())
            {
                context.Writer.WritePropertyName("command");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCommandListValue in requestObject.Command)
                {
                        context.Writer.Write(requestObjectCommandListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetEnvironment())
            {
                context.Writer.WritePropertyName("environment");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectEnvironmentKvp in requestObject.Environment)
                {
                    context.Writer.WritePropertyName(requestObjectEnvironmentKvp.Key);
                    var requestObjectEnvironmentValue = requestObjectEnvironmentKvp.Value;

                        context.Writer.Write(requestObjectEnvironmentValue);
                }
                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetImage())
            {
                context.Writer.WritePropertyName("image");
                context.Writer.Write(requestObject.Image);
            }

            if(requestObject.IsSetPorts())
            {
                context.Writer.WritePropertyName("ports");
                context.Writer.WriteObjectStart();
                foreach (var requestObjectPortsKvp in requestObject.Ports)
                {
                    context.Writer.WritePropertyName(requestObjectPortsKvp.Key);
                    var requestObjectPortsValue = requestObjectPortsKvp.Value;

                        context.Writer.Write(requestObjectPortsValue);
                }
                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContainerMarshaller Instance = new ContainerMarshaller();

    }
}