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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LexModelBuildingService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LexModelBuildingService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteIntentVersion Request Marshaller
    /// </summary>       
    public class DeleteIntentVersionRequestMarshaller : IMarshaller<IRequest, DeleteIntentVersionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteIntentVersionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteIntentVersionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LexModelBuildingService");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/intents/{name}/versions/{version}";
            if (!publicRequest.IsSetName())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Name set");
            uriResourcePath = uriResourcePath.Replace("{name}", StringUtils.FromStringWithSlashEncoding(publicRequest.Name));
            if (!publicRequest.IsSetVersion())
                throw new AmazonLexModelBuildingServiceException("Request object does not have required field Version set");
            uriResourcePath = uriResourcePath.Replace("{version}", StringUtils.FromStringWithSlashEncoding(publicRequest.Version));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DeleteIntentVersionRequestMarshaller _instance = new DeleteIntentVersionRequestMarshaller();        

        internal static DeleteIntentVersionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteIntentVersionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}