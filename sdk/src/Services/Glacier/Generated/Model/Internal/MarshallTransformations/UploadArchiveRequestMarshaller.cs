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
    /// UploadArchive Request Marshaller
    /// </summary>       
    public class UploadArchiveRequestMarshaller : IMarshaller<IRequest, UploadArchiveRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UploadArchiveRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UploadArchiveRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Glacier");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2012-06-01";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/{accountId}/vaults/{vaultName}/archives";
            uriResourcePath = uriResourcePath.Replace("{accountId}", publicRequest.IsSetAccountId() ? StringUtils.FromStringWithSlashEncoding(publicRequest.AccountId) : string.Empty);
            if (!publicRequest.IsSetVaultName())
                throw new AmazonGlacierException("Request object does not have required field VaultName set");
            uriResourcePath = uriResourcePath.Replace("{vaultName}", StringUtils.FromStringWithSlashEncoding(publicRequest.VaultName));
            request.ResourcePath = uriResourcePath;
            request.ContentStream =  publicRequest.Body ?? new MemoryStream();
            request.Headers[Amazon.Util.HeaderKeys.ContentLengthHeader] =  
                request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream";
        
            if(publicRequest.IsSetArchiveDescription())
                request.Headers["x-amz-archive-description"] = publicRequest.ArchiveDescription;
        
            if(publicRequest.IsSetChecksum())
                request.Headers["x-amz-sha256-tree-hash"] = publicRequest.Checksum;

            return request;
        }
        private static UploadArchiveRequestMarshaller _instance = new UploadArchiveRequestMarshaller();        

        internal static UploadArchiveRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UploadArchiveRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}