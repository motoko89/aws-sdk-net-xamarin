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
 * Do not modify this file. This file is generated from the iotsecuretunneling-2018-10-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSecureTunneling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoTSecureTunneling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OpenTunnel operation
    /// </summary>  
    public class OpenTunnelResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            OpenTunnelResponse response = new OpenTunnelResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("destinationAccessToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.DestinationAccessToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceAccessToken", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SourceAccessToken = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tunnelArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TunnelArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tunnelId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.TunnelId = unmarshaller.Unmarshall(context);
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
            if (errorResponse.Code != null && errorResponse.Code.Equals("LimitExceededException"))
            {
                return new LimitExceededException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonIoTSecureTunnelingException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static OpenTunnelResponseUnmarshaller _instance = new OpenTunnelResponseUnmarshaller();        

        internal static OpenTunnelResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static OpenTunnelResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}