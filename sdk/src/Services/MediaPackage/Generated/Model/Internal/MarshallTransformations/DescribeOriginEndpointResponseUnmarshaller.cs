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
 * Do not modify this file. This file is generated from the mediapackage-2017-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MediaPackage.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MediaPackage.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DescribeOriginEndpoint operation
    /// </summary>  
    public class DescribeOriginEndpointResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            DescribeOriginEndpointResponse response = new DescribeOriginEndpointResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Arn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("channelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ChannelId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cmafPackage", targetDepth))
                {
                    var unmarshaller = CmafPackageUnmarshaller.Instance;
                    response.CmafPackage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dashPackage", targetDepth))
                {
                    var unmarshaller = DashPackageUnmarshaller.Instance;
                    response.DashPackage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("description", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Description = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("hlsPackage", targetDepth))
                {
                    var unmarshaller = HlsPackageUnmarshaller.Instance;
                    response.HlsPackage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Id = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("manifestName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.ManifestName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("mssPackage", targetDepth))
                {
                    var unmarshaller = MssPackageUnmarshaller.Instance;
                    response.MssPackage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("origination", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Origination = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startoverWindowSeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.StartoverWindowSeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("timeDelaySeconds", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.TimeDelaySeconds = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("url", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.Url = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("whitelist", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    response.Whitelist = unmarshaller.Unmarshall(context);
                    continue;
                }
            }

            return response;
        }

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="innerException"></param>
        /// <param name="statusCode"></param>
        /// <returns></returns>
        public override AmazonServiceException UnmarshallException(JsonUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = JsonErrorResponseUnmarshaller.GetInstance().Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals("ForbiddenException"))
            {
                return new ForbiddenException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InternalServerErrorException"))
            {
                return new InternalServerErrorException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("NotFoundException"))
            {
                return new NotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ServiceUnavailableException"))
            {
                return new ServiceUnavailableException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("TooManyRequestsException"))
            {
                return new TooManyRequestsException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("UnprocessableEntityException"))
            {
                return new UnprocessableEntityException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonMediaPackageException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static DescribeOriginEndpointResponseUnmarshaller _instance = new DescribeOriginEndpointResponseUnmarshaller();        

        internal static DescribeOriginEndpointResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DescribeOriginEndpointResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}