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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Backup.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Backup.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutBackupVaultNotifications Request Marshaller
    /// </summary>       
    public class PutBackupVaultNotificationsRequestMarshaller : IMarshaller<IRequest, PutBackupVaultNotificationsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutBackupVaultNotificationsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutBackupVaultNotificationsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Backup");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-15";            
            request.HttpMethod = "PUT";

            string uriResourcePath = "/backup-vaults/{backupVaultName}/notification-configuration";
            if (!publicRequest.IsSetBackupVaultName())
                throw new AmazonBackupException("Request object does not have required field BackupVaultName set");
            uriResourcePath = uriResourcePath.Replace("{backupVaultName}", StringUtils.FromStringWithSlashEncoding(publicRequest.BackupVaultName));
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetBackupVaultEvents())
                {
                    context.Writer.WritePropertyName("BackupVaultEvents");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestBackupVaultEventsListValue in publicRequest.BackupVaultEvents)
                    {
                            context.Writer.Write(publicRequestBackupVaultEventsListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetSNSTopicArn())
                {
                    context.Writer.WritePropertyName("SNSTopicArn");
                    context.Writer.Write(publicRequest.SNSTopicArn);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static PutBackupVaultNotificationsRequestMarshaller _instance = new PutBackupVaultNotificationsRequestMarshaller();        

        internal static PutBackupVaultNotificationsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutBackupVaultNotificationsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}