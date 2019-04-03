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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// Object containing configuration information for AWS Organizations.
    /// </summary>
    public partial class OrganizationConfiguration
    {
        private bool? _enableIntegration;

        /// <summary>
        /// Gets and sets the property EnableIntegration. 
        /// <para>
        /// Flag to activate AWS Organization integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableIntegration
        {
            get { return this._enableIntegration.GetValueOrDefault(); }
            set { this._enableIntegration = value; }
        }

        // Check to see if EnableIntegration property is set
        internal bool IsSetEnableIntegration()
        {
            return this._enableIntegration.HasValue; 
        }

    }
}