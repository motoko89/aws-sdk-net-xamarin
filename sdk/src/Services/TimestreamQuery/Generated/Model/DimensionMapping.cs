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
 * Do not modify this file. This file is generated from the timestream-query-2018-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.TimestreamQuery.Model
{
    /// <summary>
    /// This type is used to map column(s) from the query result to a dimension in the destination
    /// table.
    /// </summary>
    public partial class DimensionMapping
    {
        private DimensionValueType _dimensionValueType;
        private string _name;

        /// <summary>
        /// Gets and sets the property DimensionValueType. 
        /// <para>
        /// Type for the dimension. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DimensionValueType DimensionValueType
        {
            get { return this._dimensionValueType; }
            set { this._dimensionValueType = value; }
        }

        // Check to see if DimensionValueType property is set
        internal bool IsSetDimensionValueType()
        {
            return this._dimensionValueType != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Column name from query result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

    }
}