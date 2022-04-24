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
 * Do not modify this file. This file is generated from the mturk-requester-2017-01-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.MTurk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.MTurk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateHITType Request Marshaller
    /// </summary>       
    public class CreateHITTypeRequestMarshaller : IMarshaller<IRequest, CreateHITTypeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateHITTypeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateHITTypeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.MTurk");
            string target = "MTurkRequesterServiceV20170117.CreateHITType";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-01-17";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAssignmentDurationInSeconds())
                {
                    context.Writer.WritePropertyName("AssignmentDurationInSeconds");
                    context.Writer.Write(publicRequest.AssignmentDurationInSeconds);
                }

                if(publicRequest.IsSetAutoApprovalDelayInSeconds())
                {
                    context.Writer.WritePropertyName("AutoApprovalDelayInSeconds");
                    context.Writer.Write(publicRequest.AutoApprovalDelayInSeconds);
                }

                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("Description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetKeywords())
                {
                    context.Writer.WritePropertyName("Keywords");
                    context.Writer.Write(publicRequest.Keywords);
                }

                if(publicRequest.IsSetQualificationRequirements())
                {
                    context.Writer.WritePropertyName("QualificationRequirements");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestQualificationRequirementsListValue in publicRequest.QualificationRequirements)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = QualificationRequirementMarshaller.Instance;
                        marshaller.Marshall(publicRequestQualificationRequirementsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetReward())
                {
                    context.Writer.WritePropertyName("Reward");
                    context.Writer.Write(publicRequest.Reward);
                }

                if(publicRequest.IsSetTitle())
                {
                    context.Writer.WritePropertyName("Title");
                    context.Writer.Write(publicRequest.Title);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateHITTypeRequestMarshaller _instance = new CreateHITTypeRequestMarshaller();        

        internal static CreateHITTypeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateHITTypeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}