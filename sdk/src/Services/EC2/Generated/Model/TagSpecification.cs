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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The tags to apply to a resource when the resource is being created.
    /// </summary>
    public partial class TagSpecification
    {
        private ResourceType _resourceType;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource to tag. Currently, the resource types that support tagging on
        /// creation are: <code>capacity-reservation</code> | <code>client-vpn-endpoint</code>
        /// | <code>dedicated-host</code> | <code>fleet</code> | <code>fpga-image</code> | <code>instance</code>
        /// | <code>key-pair</code> | <code>launch-template</code> | | <code>natgateway</code>
        /// | <code>spot-fleet-request</code> | <code>placement-group</code> | <code>snapshot</code>
        /// | <code>traffic-mirror-filter</code> | <code>traffic-mirror-session</code> | <code>traffic-mirror-target</code>
        /// | <code>transit-gateway</code> | <code>transit-gateway-attachment</code> | <code>transit-gateway-route-table</code>
        /// | <code>vpc-endpoint</code> (for interface VPC endpoints)| <code>vpc-endpoint-service</code>
        /// (for gateway VPC endpoints) | <code>volume</code> | <code>vpc-flow-log</code>.
        /// </para>
        ///  
        /// <para>
        /// To tag a resource after it has been created, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to apply to the resource.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}