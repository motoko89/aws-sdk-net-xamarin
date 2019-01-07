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
 * Do not modify this file. This file is generated from the appsync-2017-07-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateResolver Request Marshaller
    /// </summary>       
    public class UpdateResolverRequestMarshaller : IMarshaller<IRequest, UpdateResolverRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateResolverRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateResolverRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppSync");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-07-25";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/v1/apis/{apiId}/types/{typeName}/resolvers/{fieldName}";
            if (!publicRequest.IsSetApiId())
                throw new AmazonAppSyncException("Request object does not have required field ApiId set");
            uriResourcePath = uriResourcePath.Replace("{apiId}", StringUtils.FromStringWithSlashEncoding(publicRequest.ApiId));
            if (!publicRequest.IsSetFieldName())
                throw new AmazonAppSyncException("Request object does not have required field FieldName set");
            uriResourcePath = uriResourcePath.Replace("{fieldName}", StringUtils.FromStringWithSlashEncoding(publicRequest.FieldName));
            if (!publicRequest.IsSetTypeName())
                throw new AmazonAppSyncException("Request object does not have required field TypeName set");
            uriResourcePath = uriResourcePath.Replace("{typeName}", StringUtils.FromStringWithSlashEncoding(publicRequest.TypeName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetDataSourceName())
                {
                    context.Writer.WritePropertyName("dataSourceName");
                    context.Writer.Write(publicRequest.DataSourceName);
                }

                if(publicRequest.IsSetKind())
                {
                    context.Writer.WritePropertyName("kind");
                    context.Writer.Write(publicRequest.Kind);
                }

                if(publicRequest.IsSetPipelineConfig())
                {
                    context.Writer.WritePropertyName("pipelineConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = PipelineConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.PipelineConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRequestMappingTemplate())
                {
                    context.Writer.WritePropertyName("requestMappingTemplate");
                    context.Writer.Write(publicRequest.RequestMappingTemplate);
                }

                if(publicRequest.IsSetResponseMappingTemplate())
                {
                    context.Writer.WritePropertyName("responseMappingTemplate");
                    context.Writer.Write(publicRequest.ResponseMappingTemplate);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateResolverRequestMarshaller _instance = new UpdateResolverRequestMarshaller();        

        internal static UpdateResolverRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateResolverRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}