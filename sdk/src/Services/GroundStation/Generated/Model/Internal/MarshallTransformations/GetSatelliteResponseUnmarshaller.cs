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
 * Do not modify this file. This file is generated from the groundstation-2019-05-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GroundStation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.GroundStation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for GetSatellite operation
    /// </summary>  
    public class GetSatelliteResponseUnmarshaller : JsonResponseUnmarshaller
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public override AmazonWebServiceResponse Unmarshall(JsonUnmarshallerContext context)
        {
            GetSatelliteResponse response = new GetSatelliteResponse();

            context.Read();
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("dateCreated", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.DateCreated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastUpdated", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    response.LastUpdated = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("noradSatelliteID", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    response.NoradSatelliteID = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("satelliteArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SatelliteArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("satelliteId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    response.SatelliteId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new DictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    response.Tags = unmarshaller.Unmarshall(context);
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
            if (errorResponse.Code != null && errorResponse.Code.Equals("DependencyException"))
            {
                return new DependencyException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("InvalidParameterException"))
            {
                return new InvalidParameterException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals("ResourceNotFoundException"))
            {
                return new ResourceNotFoundException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
            }
            return new AmazonGroundStationException(errorResponse.Message, innerException, errorResponse.Type, errorResponse.Code, errorResponse.RequestId, statusCode);
        }

        private static GetSatelliteResponseUnmarshaller _instance = new GetSatelliteResponseUnmarshaller();        

        internal static GetSatelliteResponseUnmarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GetSatelliteResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}