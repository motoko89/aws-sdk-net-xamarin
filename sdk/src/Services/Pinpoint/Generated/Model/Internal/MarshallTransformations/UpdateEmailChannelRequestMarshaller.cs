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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateEmailChannel Request Marshaller
    /// </summary>       
    public class UpdateEmailChannelRequestMarshaller : IMarshaller<IRequest, UpdateEmailChannelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateEmailChannelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateEmailChannelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Pinpoint");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-12-01";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/v1/apps/{application-id}/channels/email";
            if (!publicRequest.IsSetApplicationId())
                throw new AmazonPinpointException("Request object does not have required field ApplicationId set");
            uriResourcePath = uriResourcePath.Replace("{application-id}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApplicationId));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);

                var marshaller = EmailChannelRequestMarshaller.Instance;
                marshaller.Marshall(publicRequest.EmailChannelRequest, context);
        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateEmailChannelRequestMarshaller _instance = new UpdateEmailChannelRequestMarshaller();        

        internal static UpdateEmailChannelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateEmailChannelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}