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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCoreNetworkPolicyVersion operation.
    /// Deletes a policy version from a core network. You can't delete the current LIVE policy.
    /// </summary>
    public partial class DeleteCoreNetworkPolicyVersionRequest : AmazonNetworkManagerRequest
    {
        private string _coreNetworkId;
        private int? _policyVersionId;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of a core network for the deleted policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyVersionId. 
        /// <para>
        /// The version ID of the deleted policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int PolicyVersionId
        {
            get { return this._policyVersionId.GetValueOrDefault(); }
            set { this._policyVersionId = value; }
        }

        // Check to see if PolicyVersionId property is set
        internal bool IsSetPolicyVersionId()
        {
            return this._policyVersionId.HasValue; 
        }

    }
}