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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateThing Request Marshaller
    /// </summary>       
    public class UpdateThingRequestMarshaller : IMarshaller<IRequest, UpdateThingRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateThingRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateThingRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";            
            request.HttpMethod = "PATCH";

            string uriResourcePath = "/things/{thingName}";
            if (!publicRequest.IsSetThingName())
                throw new AmazonIoTException("Request object does not have required field ThingName set");
            uriResourcePath = uriResourcePath.Replace("{thingName}", StringUtils.FromStringWithSlashEncoding(publicRequest.ThingName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAttributePayload())
                {
                    context.Writer.WritePropertyName("attributePayload");
                    context.Writer.WriteObjectStart();

                    var marshaller = AttributePayloadMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AttributePayload, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetExpectedVersion())
                {
                    context.Writer.WritePropertyName("expectedVersion");
                    context.Writer.Write(publicRequest.ExpectedVersion);
                }

                if(publicRequest.IsSetRemoveThingType())
                {
                    context.Writer.WritePropertyName("removeThingType");
                    context.Writer.Write(publicRequest.RemoveThingType);
                }

                if(publicRequest.IsSetThingTypeName())
                {
                    context.Writer.WritePropertyName("thingTypeName");
                    context.Writer.Write(publicRequest.ThingTypeName);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateThingRequestMarshaller _instance = new UpdateThingRequestMarshaller();        

        internal static UpdateThingRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateThingRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}