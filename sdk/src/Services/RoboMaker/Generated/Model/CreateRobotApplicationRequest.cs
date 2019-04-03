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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateRobotApplication operation.
    /// Creates a robot application.
    /// </summary>
    public partial class CreateRobotApplicationRequest : AmazonRoboMakerRequest
    {
        private string _name;
        private RobotSoftwareSuite _robotSoftwareSuite;
        private List<SourceConfig> _sources = new List<SourceConfig>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property RobotSoftwareSuite. 
        /// <para>
        /// The robot software suite used by the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RobotSoftwareSuite RobotSoftwareSuite
        {
            get { return this._robotSoftwareSuite; }
            set { this._robotSoftwareSuite = value; }
        }

        // Check to see if RobotSoftwareSuite property is set
        internal bool IsSetRobotSoftwareSuite()
        {
            return this._robotSoftwareSuite != null;
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The sources of the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SourceConfig> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the robot application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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