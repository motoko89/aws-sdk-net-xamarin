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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Elasticsearch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Elasticsearch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// DescribeElasticsearchInstanceTypeLimits Request Marshaller
    /// </summary>       
    public class DescribeElasticsearchInstanceTypeLimitsRequestMarshaller : IMarshaller<IRequest, DescribeElasticsearchInstanceTypeLimitsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DescribeElasticsearchInstanceTypeLimitsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DescribeElasticsearchInstanceTypeLimitsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Elasticsearch");
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-01-01";            
            request.HttpMethod = "GET";

            if (!publicRequest.IsSetElasticsearchVersion())
                throw new AmazonElasticsearchException("Request object does not have required field ElasticsearchVersion set");
            request.AddPathResource("{ElasticsearchVersion}", StringUtils.FromString(publicRequest.ElasticsearchVersion));
            if (!publicRequest.IsSetInstanceType())
                throw new AmazonElasticsearchException("Request object does not have required field InstanceType set");
            request.AddPathResource("{InstanceType}", StringUtils.FromString(publicRequest.InstanceType));
            
            if (publicRequest.IsSetDomainName())
                request.Parameters.Add("domainName", StringUtils.FromString(publicRequest.DomainName));
            request.ResourcePath = "/2015-01-01/es/instanceTypeLimits/{ElasticsearchVersion}/{InstanceType}";
            request.MarshallerVersion = 2;
            request.UseQueryString = true;

            return request;
        }
        private static DescribeElasticsearchInstanceTypeLimitsRequestMarshaller _instance = new DescribeElasticsearchInstanceTypeLimitsRequestMarshaller();        

        internal static DescribeElasticsearchInstanceTypeLimitsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeElasticsearchInstanceTypeLimitsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}