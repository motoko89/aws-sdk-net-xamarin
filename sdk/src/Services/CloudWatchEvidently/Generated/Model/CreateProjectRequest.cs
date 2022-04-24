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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// Container for the parameters to the CreateProject operation.
    /// Creates a project, which is the logical object in Evidently that can contain features,
    /// launches, and experiments. Use projects to group similar features together.
    /// 
    ///  
    /// <para>
    /// To update an existing project, use <a href="https://docs.aws.amazon.com/cloudwatchevidently/latest/APIReference/API_UpdateProject.html">UpdateProject</a>.
    /// </para>
    /// </summary>
    public partial class CreateProjectRequest : AmazonCloudWatchEvidentlyRequest
    {
        private ProjectDataDeliveryConfig _dataDelivery;
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property DataDelivery. 
        /// <para>
        /// A structure that contains information about where Evidently is to store evaluation
        /// events for longer term storage, if you choose to do so. If you choose not to store
        /// these events, Evidently deletes them after using them to produce metrics and other
        /// experiment results that you can view.
        /// </para>
        /// </summary>
        public ProjectDataDeliveryConfig DataDelivery
        {
            get { return this._dataDelivery; }
            set { this._dataDelivery = value; }
        }

        // Check to see if DataDelivery property is set
        internal bool IsSetDataDelivery()
        {
            return this._dataDelivery != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description of the project.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=160)]
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
        /// The name for the project.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the project.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  <pre><code> &lt;p&gt;You can associate as many as 50 tags with a project.&lt;/p&gt;
        /// &lt;p&gt;For more information, see &lt;a href=&quot;https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html&quot;&gt;Tagging
        /// Amazon Web Services resources&lt;/a&gt;.&lt;/p&gt; </code></pre>
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