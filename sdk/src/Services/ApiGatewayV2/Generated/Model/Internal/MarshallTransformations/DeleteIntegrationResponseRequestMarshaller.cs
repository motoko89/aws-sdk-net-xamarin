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
 * Do not modify this file. This file is generated from the apigatewayv2-2018-11-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApiGatewayV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ApiGatewayV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteIntegrationResponse Request Marshaller
    /// </summary>       
    public class DeleteIntegrationResponseRequestMarshaller : IMarshaller<IRequest, DeleteIntegrationResponseRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteIntegrationResponseRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteIntegrationResponseRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ApiGatewayV2");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/v2/apis/{apiId}/integrations/{integrationId}/integrationresponses/{integrationResponseId}";
            if (!publicRequest.IsSetApiId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiId));
            if (!publicRequest.IsSetIntegrationId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationId set");
            uriResourcePath = uriResourcePath.Replace("{integrationId}", StringUtils.FromStringWithSlashEncoding(publicRequest.IntegrationId));
            if (!publicRequest.IsSetIntegrationResponseId())
                throw new AmazonApiGatewayV2Exception("Request object does not have required field IntegrationResponseId set");
            uriResourcePath = uriResourcePath.Replace("{integrationResponseId}", StringUtils.FromStringWithSlashEncoding(publicRequest.IntegrationResponseId));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DeleteIntegrationResponseRequestMarshaller _instance = new DeleteIntegrationResponseRequestMarshaller();        

        internal static DeleteIntegrationResponseRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteIntegrationResponseRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}