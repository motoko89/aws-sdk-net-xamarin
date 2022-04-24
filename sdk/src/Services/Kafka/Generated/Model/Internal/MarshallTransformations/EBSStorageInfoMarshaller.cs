/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EBSStorageInfo Marshaller
    /// </summary>
    public class EBSStorageInfoMarshaller : IRequestMarshaller<EBSStorageInfo, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EBSStorageInfo requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetProvisionedThroughput())
            {
                context.Writer.WritePropertyName("provisionedThroughput");
                context.Writer.WriteObjectStart();

                var marshaller = ProvisionedThroughputMarshaller.Instance;
                marshaller.Marshall(requestObject.ProvisionedThroughput, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetVolumeSize())
            {
                context.Writer.WritePropertyName("volumeSize");
                context.Writer.Write(requestObject.VolumeSize);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EBSStorageInfoMarshaller Instance = new EBSStorageInfoMarshaller();

    }
}