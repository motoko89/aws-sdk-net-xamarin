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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class InstanceTypeDetails
    {
        private bool? _advancedSecurityEnabled;
        private bool? _appLogsEnabled;
        private bool? _cognitoEnabled;
        private bool? _encryptionEnabled;
        private List<string> _instanceRole = new List<string>();
        private OpenSearchPartitionInstanceType _instanceType;
        private bool? _warmEnabled;

        /// <summary>
        /// Gets and sets the property AdvancedSecurityEnabled.
        /// </summary>
        public bool AdvancedSecurityEnabled
        {
            get { return this._advancedSecurityEnabled.GetValueOrDefault(); }
            set { this._advancedSecurityEnabled = value; }
        }

        // Check to see if AdvancedSecurityEnabled property is set
        internal bool IsSetAdvancedSecurityEnabled()
        {
            return this._advancedSecurityEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AppLogsEnabled.
        /// </summary>
        public bool AppLogsEnabled
        {
            get { return this._appLogsEnabled.GetValueOrDefault(); }
            set { this._appLogsEnabled = value; }
        }

        // Check to see if AppLogsEnabled property is set
        internal bool IsSetAppLogsEnabled()
        {
            return this._appLogsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CognitoEnabled.
        /// </summary>
        public bool CognitoEnabled
        {
            get { return this._cognitoEnabled.GetValueOrDefault(); }
            set { this._cognitoEnabled = value; }
        }

        // Check to see if CognitoEnabled property is set
        internal bool IsSetCognitoEnabled()
        {
            return this._cognitoEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionEnabled.
        /// </summary>
        public bool EncryptionEnabled
        {
            get { return this._encryptionEnabled.GetValueOrDefault(); }
            set { this._encryptionEnabled = value; }
        }

        // Check to see if EncryptionEnabled property is set
        internal bool IsSetEncryptionEnabled()
        {
            return this._encryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceRole.
        /// </summary>
        public List<string> InstanceRole
        {
            get { return this._instanceRole; }
            set { this._instanceRole = value; }
        }

        // Check to see if InstanceRole property is set
        internal bool IsSetInstanceRole()
        {
            return this._instanceRole != null && this._instanceRole.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InstanceType.
        /// </summary>
        public OpenSearchPartitionInstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property WarmEnabled.
        /// </summary>
        public bool WarmEnabled
        {
            get { return this._warmEnabled.GetValueOrDefault(); }
            set { this._warmEnabled = value; }
        }

        // Check to see if WarmEnabled property is set
        internal bool IsSetWarmEnabled()
        {
            return this._warmEnabled.HasValue; 
        }

    }
}