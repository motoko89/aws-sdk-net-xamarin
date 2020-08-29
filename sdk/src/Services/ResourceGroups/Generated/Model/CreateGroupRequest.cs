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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGroup operation.
    /// Creates a resource group with the specified name and description. You can optionally
    /// include a resource query, or a service configuration.
    /// </summary>
    public partial class CreateGroupRequest : AmazonResourceGroupsRequest
    {
        private List<GroupConfigurationItem> _configuration = new List<GroupConfigurationItem>();
        private string _description;
        private string _name;
        private ResourceQuery _resourceQuery;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Configuration. 
        /// <para>
        /// A configuration associates the resource group with an AWS service and specifies how
        /// the service can interact with the resources in the group. A configuration is an array
        /// of <a>GroupConfigurationItem</a> elements.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify either a <code>Configuration</code> or a <code>ResourceQuery</code>
        /// in a group, but not both.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=2)]
        public List<GroupConfigurationItem> Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }

        // Check to see if Configuration property is set
        internal bool IsSetConfiguration()
        {
            return this._configuration != null && this._configuration.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the resource group. Descriptions can consist of letters, numbers,
        /// hyphens, underscores, periods, and spaces.
        /// </para>
        /// </summary>
        [AWSProperty(Max=512)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the group, which is the identifier of the group in other operations. You
        /// can't change the name of a resource group after you create it. A resource group name
        /// can consist of letters, numbers, hyphens, periods, and underscores. The name cannot
        /// start with <code>AWS</code> or <code>aws</code>; these are reserved. A resource group
        /// name must be unique within each AWS Region in your AWS account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceQuery. 
        /// <para>
        /// The resource query that determines which AWS resources are members of this group.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can specify either a <code>ResourceQuery</code> or a <code>Configuration</code>,
        /// but not both.
        /// </para>
        ///  </note>
        /// </summary>
        public ResourceQuery ResourceQuery
        {
            get { return this._resourceQuery; }
            set { this._resourceQuery = value; }
        }

        // Check to see if ResourceQuery property is set
        internal bool IsSetResourceQuery()
        {
            return this._resourceQuery != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the group. A tag is key-value pair string.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
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