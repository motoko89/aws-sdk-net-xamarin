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
 * Do not modify this file. This file is generated from the cloudfront-2019-03-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFront.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Xml;

namespace Amazon.CloudFront.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateFieldLevelEncryptionConfig Request Marshaller
    /// </summary>       
    public class CreateFieldLevelEncryptionConfigRequestMarshaller : IMarshaller<IRequest, CreateFieldLevelEncryptionConfigRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateFieldLevelEncryptionConfigRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateFieldLevelEncryptionConfigRequest publicRequest)
        {
            var request = new DefaultRequest(publicRequest, "Amazon.CloudFront");
            request.HttpMethod = "POST";
            request.ResourcePath = "/2019-03-26/field-level-encryption";
            request.MarshallerVersion = 2;

            var stringWriter = new StringWriter(CultureInfo.InvariantCulture);
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings() { Encoding = System.Text.Encoding.UTF8, OmitXmlDeclaration = true }))
            {   
                if (publicRequest.IsSetFieldLevelEncryptionConfig())
                {
                    xmlWriter.WriteStartElement("FieldLevelEncryptionConfig", "http://cloudfront.amazonaws.com/doc/2019-03-26/");
                    if(publicRequest.FieldLevelEncryptionConfig.IsSetCallerReference())
                        xmlWriter.WriteElementString("CallerReference", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequest.FieldLevelEncryptionConfig.CallerReference));                    
    
                    if(publicRequest.FieldLevelEncryptionConfig.IsSetComment())
                        xmlWriter.WriteElementString("Comment", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequest.FieldLevelEncryptionConfig.Comment));                    
    
                    
                    if (publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig != null) 
                    {
                        xmlWriter.WriteStartElement("ContentTypeProfileConfig", "http://cloudfront.amazonaws.com/doc/2019-03-26/");            
                        
                        if (publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles != null) 
                        {
                            xmlWriter.WriteStartElement("ContentTypeProfiles", "http://cloudfront.amazonaws.com/doc/2019-03-26/");            
                            var publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems = publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles.Items;
                            if (publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems != null && publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2019-03-26/");
                                foreach (var publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue in publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems) 
                                {
                                
                                if (publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("ContentTypeProfile", "http://cloudfront.amazonaws.com/doc/2019-03-26/");            
                                    if(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.IsSetContentType())
                                        xmlWriter.WriteElementString("ContentType", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.ContentType));                 
                    
                                    if(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.IsSetFormat())
                                        xmlWriter.WriteElementString("Format", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.Format));                 
                    
                                    if(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.IsSetProfileId())
                                        xmlWriter.WriteElementString("ProfileId", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItemsValue.ProfileId));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromInt(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ContentTypeProfiles.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        if(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.IsSetForwardWhenContentTypeIsUnknown())
                            xmlWriter.WriteElementString("ForwardWhenContentTypeIsUnknown", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromBool(publicRequest.FieldLevelEncryptionConfig.ContentTypeProfileConfig.ForwardWhenContentTypeIsUnknown));                 
        
                        xmlWriter.WriteEndElement();
                    }
                    
                    if (publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig != null) 
                    {
                        xmlWriter.WriteStartElement("QueryArgProfileConfig", "http://cloudfront.amazonaws.com/doc/2019-03-26/");            
                        if(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.IsSetForwardWhenQueryArgProfileIsUnknown())
                            xmlWriter.WriteElementString("ForwardWhenQueryArgProfileIsUnknown", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromBool(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.ForwardWhenQueryArgProfileIsUnknown));                 
        
                        
                        if (publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles != null) 
                        {
                            xmlWriter.WriteStartElement("QueryArgProfiles", "http://cloudfront.amazonaws.com/doc/2019-03-26/");            
                            var publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems = publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles.Items;
                            if (publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems != null && publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems.Count > 0) 
                            {                        
                                xmlWriter.WriteStartElement("Items", "http://cloudfront.amazonaws.com/doc/2019-03-26/");
                                foreach (var publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue in publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems) 
                                {
                                
                                if (publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue != null) 
                                {
                                    xmlWriter.WriteStartElement("QueryArgProfile", "http://cloudfront.amazonaws.com/doc/2019-03-26/");            
                                    if(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.IsSetProfileId())
                                        xmlWriter.WriteElementString("ProfileId", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.ProfileId));                 
                    
                                    if(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.IsSetQueryArg())
                                        xmlWriter.WriteElementString("QueryArg", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromString(publicRequestFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItemsValue.QueryArg));                 
                    
                                    xmlWriter.WriteEndElement();
                                }
                                }            
                                xmlWriter.WriteEndElement();            
                            }
                            if(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles.IsSetQuantity())
                                xmlWriter.WriteElementString("Quantity", "http://cloudfront.amazonaws.com/doc/2019-03-26/", StringUtils.FromInt(publicRequest.FieldLevelEncryptionConfig.QueryArgProfileConfig.QueryArgProfiles.Quantity));                 
            
                            xmlWriter.WriteEndElement();
                        }
                        xmlWriter.WriteEndElement();
                    }
    
                    xmlWriter.WriteEndElement();
                }
            }
            try 
            {
                string content = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(content);
                request.Headers["Content-Type"] = "application/xml";
                request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2019-03-26";            
            } 
            catch (EncoderFallbackException e) 
            {
                throw new AmazonServiceException("Unable to marshall request to XML", e);
            }

            return request;
        }
        private static CreateFieldLevelEncryptionConfigRequestMarshaller _instance = new CreateFieldLevelEncryptionConfigRequestMarshaller();        

        internal static CreateFieldLevelEncryptionConfigRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateFieldLevelEncryptionConfigRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }    
}