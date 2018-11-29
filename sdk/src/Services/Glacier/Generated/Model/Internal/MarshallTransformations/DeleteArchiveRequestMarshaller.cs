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
 * Do not modify this file. This file is generated from the glacier-2012-06-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glacier.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glacier.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DeleteArchive Request Marshaller
    /// </summary>       
    public class DeleteArchiveRequestMarshaller : IMarshaller<IRequest, DeleteArchiveRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DeleteArchiveRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DeleteArchiveRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.HttpMethod = "DELETE";

            string uriResourcePath = "/{accountId}/vaults/{vaultName}/archives/{archiveId}";
            uriResourcePath = uriResourcePath.Replace("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromStringWithSlashEncoding(publicRequest.AccountId) : string.Empty);
            if (!publicRequest.IsSetArchiveId())
                throw new AmazonGlacierException("Request object does not have required field ArchiveId set");
            uriResourcePath = uriResourcePath.Replace("{archiveId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ArchiveId));
            if (!publicRequest.IsSetVaultName())
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromStringWithSlashEncoding(publicRequest.VaultName));
            request.ResourcePath = uriResourcePath;

            return request;
        }
        private static DeleteArchiveRequestMarshaller _instance = new DeleteArchiveRequestMarshaller();        

        internal static DeleteArchiveRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeleteArchiveRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}