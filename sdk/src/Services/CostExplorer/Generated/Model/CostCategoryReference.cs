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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// <important> 
    /// <para>
    ///  <i> <b>Cost Category is in preview release for AWS Billing and Cost Management and
    /// is subject to change. Your use of Cost Categories is subject to the Beta Service Participation
    /// terms of the <a href="https://aws.amazon.com/service-terms/">AWS Service Terms</a>
    /// (Section 1.10).</b> </i> 
    /// </para>
    ///  </important> 
    /// <para>
    /// A reference to a Cost Category containing only enough information to identify the
    /// Cost Category.
    /// </para>
    ///  
    /// <para>
    /// You can use this information to retrieve the full Cost Category information using
    /// <code>DescribeCostCategory</code>.
    /// </para>
    /// </summary>
    public partial class CostCategoryReference
    {
        private string _costCategoryArn;
        private string _effectiveEnd;
        private string _effectiveStart;
        private string _name;

        /// <summary>
        /// Gets and sets the property CostCategoryArn. 
        /// <para>
        ///  The unique identifier for your Cost Category Reference. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CostCategoryArn
        {
            get { return this._costCategoryArn; }
            set { this._costCategoryArn = value; }
        }

        // Check to see if CostCategoryArn property is set
        internal bool IsSetCostCategoryArn()
        {
            return this._costCategoryArn != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveEnd. 
        /// <para>
        ///  The Cost Category's effective end date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveEnd
        {
            get { return this._effectiveEnd; }
            set { this._effectiveEnd = value; }
        }

        // Check to see if EffectiveEnd property is set
        internal bool IsSetEffectiveEnd()
        {
            return this._effectiveEnd != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveStart. 
        /// <para>
        ///  The Cost Category's effective start date.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=25)]
        public string EffectiveStart
        {
            get { return this._effectiveStart; }
            set { this._effectiveStart = value; }
        }

        // Check to see if EffectiveStart property is set
        internal bool IsSetEffectiveStart()
        {
            return this._effectiveStart != null;
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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