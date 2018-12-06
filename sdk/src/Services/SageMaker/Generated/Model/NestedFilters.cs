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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// A <code>NestedFilter</code> is defined by using a resource name under <code>NestedPropertyName</code>,
    /// which entries in a list that properties must match to be included in the results.
    /// To satisfy the conditions specified in the <code>NestedFilters</code> call, each object
    /// in the list must satisfy the conditions of all of the filters.
    /// 
    ///  
    /// <para>
    /// For example, a <code>NestedFilters</code> could be defined using the training job's
    /// <code>InputDataConfig</code> property, this would be defined as a list of <code>Channel</code>
    /// objects. 
    /// </para>
    ///  
    /// <para>
    /// A <code>NestedFilters</code> object contains multiple filters. For example, to find
    /// all training jobs that have <code>train</code> in their name, and have <code>cat/data</code>
    /// in their<code/> <code>S3Uri</code> (under <code>InputDataConfig</code>), you need
    /// to create a <code>NestedFilters</code> object that specfies the <code>InputDataConfig</code>
    /// property with the following <code>Filter</code> objects:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>'{Name:"InputDataConfig.ChannelName", "Operator":"EQUALS", "Value":"train"}',</code>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>'{Name:"InputDataConfig.DataSource.S3DataSource.S3Uri", "Operator":"CONTAINS",
    /// "Value":"cat/data"}'</code> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class NestedFilters
    {
        private List<Filter> _filters = new List<Filter>();
        private string _nestedPropertyName;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of filters. Each filter acts on a property. For example, a <code>NestedFilters</code>
        /// call might include a filter on the <code>PropertyName</code> parameter fof the <code>InputDataConfig</code>
        /// property: <code>InputDataConfig.DataSource.S3DataSource.S3Uri</code>.
        /// </para>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NestedPropertyName. 
        /// <para>
        /// .The name of the property used in the nested filters.
        /// </para>
        /// </summary>
        public string NestedPropertyName
        {
            get { return this._nestedPropertyName; }
            set { this._nestedPropertyName = value; }
        }

        // Check to see if NestedPropertyName property is set
        internal bool IsSetNestedPropertyName()
        {
            return this._nestedPropertyName != null;
        }

    }
}