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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// The type of bucketed aggregation performed.
    /// </summary>
    public partial class BucketsAggregationType
    {
        private TermsAggregation _termsAggregation;

        /// <summary>
        /// Gets and sets the property TermsAggregation. 
        /// <para>
        /// Performs an aggregation that will return a list of buckets. The list of buckets is
        /// a ranked list of the number of occurrences of an aggregation field value.
        /// </para>
        /// </summary>
        public TermsAggregation TermsAggregation
        {
            get { return this._termsAggregation; }
            set { this._termsAggregation = value; }
        }

        // Check to see if TermsAggregation property is set
        internal bool IsSetTermsAggregation()
        {
            return this._termsAggregation != null;
        }

    }
}