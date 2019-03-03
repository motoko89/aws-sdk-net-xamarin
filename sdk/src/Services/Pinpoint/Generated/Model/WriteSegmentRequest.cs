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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Segment definition.
    /// </summary>
    public partial class WriteSegmentRequest
    {
        private SegmentDimensions _dimensions;
        private string _name;
        private SegmentGroupList _segmentGroups;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Dimensions. The segment dimensions attributes.
        /// </summary>
        public SegmentDimensions Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null;
        }

        /// <summary>
        /// Gets and sets the property Name. The name of segment
        /// </summary>
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
        /// Gets and sets the property SegmentGroups. A segment group, which consists of zero
        /// or more source segments, plus dimensions that are applied to those source segments.
        /// Your request can only include one segment group. Your request can include either a
        /// SegmentGroups object or a Dimensions object, but not both.
        /// </summary>
        public SegmentGroupList SegmentGroups
        {
            get { return this._segmentGroups; }
            set { this._segmentGroups = value; }
        }

        // Check to see if SegmentGroups property is set
        internal bool IsSetSegmentGroups()
        {
            return this._segmentGroups != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. The Tags for the segments.
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