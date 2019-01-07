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
 * Do not modify this file. This file is generated from the budgets-2016-10-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Budgets.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Budgets.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateNotification Request Marshaller
    /// </summary>       
    public class CreateNotificationRequestMarshaller : IMarshaller<IRequest, CreateNotificationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateNotificationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateNotificationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Budgets");
            string target = "AWSBudgetServiceGateway.CreateNotification";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2016-10-20";            
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAccountId())
                {
                    context.Writer.WritePropertyName("AccountId");
                    context.Writer.Write(publicRequest.AccountId);
                }

                if(publicRequest.IsSetBudgetName())
                {
                    context.Writer.WritePropertyName("BudgetName");
                    context.Writer.Write(publicRequest.BudgetName);
                }

                if(publicRequest.IsSetNotification())
                {
                    context.Writer.WritePropertyName("Notification");
                    context.Writer.WriteObjectStart();

                    var marshaller = NotificationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Notification, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSubscribers())
                {
                    context.Writer.WritePropertyName("Subscribers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSubscribersListValue in publicRequest.Subscribers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = SubscriberMarshaller.Instance;
                        marshaller.Marshall(publicRequestSubscribersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateNotificationRequestMarshaller _instance = new CreateNotificationRequestMarshaller();        

        internal static CreateNotificationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateNotificationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}