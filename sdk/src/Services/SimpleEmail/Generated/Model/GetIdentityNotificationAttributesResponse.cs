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
 * Do not modify this file. This file is generated from the email-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// Represents the notification attributes for a list of identities.
    /// </summary>
    public partial class GetIdentityNotificationAttributesResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, IdentityNotificationAttributes> _notificationAttributes = new Dictionary<string, IdentityNotificationAttributes>();

        /// <summary>
        /// Gets and sets the property NotificationAttributes. 
        /// <para>
        /// A map of Identity to IdentityNotificationAttributes.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, IdentityNotificationAttributes> NotificationAttributes
        {
            get { return this._notificationAttributes; }
            set { this._notificationAttributes = value; }
        }

        // Check to see if NotificationAttributes property is set
        internal bool IsSetNotificationAttributes()
        {
            return this._notificationAttributes != null && this._notificationAttributes.Count > 0; 
        }

    }
}