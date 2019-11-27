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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the GetPercentiles operation.
    /// Groups the aggregated values that match the query into percentile groupings. The default
    /// percentile groupings are: 1,5,25,50,75,95,99, although you can specify your own when
    /// you call <code>GetPercentiles</code>. This function returns a value for each percentile
    /// group specified (or the default percentile groupings). The percentile group "1" contains
    /// the aggregated field value that occurs in approximately one percent of the values
    /// that match the query. The percentile group "5" contains the aggregated field value
    /// that occurs in approximately five percent of the values that match the query, and
    /// so on. The result is an approximation, the more values that match the query, the more
    /// accurate the percentile values.
    /// </summary>
    public partial class GetPercentilesRequest : AmazonIoTRequest
    {
        private string _aggregationField;
        private string _indexName;
        private List<double> _percents = new List<double>();
        private string _queryString;
        private string _queryVersion;

        /// <summary>
        /// Gets and sets the property AggregationField. 
        /// <para>
        /// The field to aggregate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string AggregationField
        {
            get { return this._aggregationField; }
            set { this._aggregationField = value; }
        }

        // Check to see if AggregationField property is set
        internal bool IsSetAggregationField()
        {
            return this._aggregationField != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index to search.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property Percents. 
        /// <para>
        /// The percentile groups returned.
        /// </para>
        /// </summary>
        public List<double> Percents
        {
            get { return this._percents; }
            set { this._percents = value; }
        }

        // Check to see if Percents property is set
        internal bool IsSetPercents()
        {
            return this._percents != null && this._percents.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property QueryString. 
        /// <para>
        /// The query string.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string QueryString
        {
            get { return this._queryString; }
            set { this._queryString = value; }
        }

        // Check to see if QueryString property is set
        internal bool IsSetQueryString()
        {
            return this._queryString != null;
        }

        /// <summary>
        /// Gets and sets the property QueryVersion. 
        /// <para>
        /// The query version.
        /// </para>
        /// </summary>
        public string QueryVersion
        {
            get { return this._queryVersion; }
            set { this._queryVersion = value; }
        }

        // Check to see if QueryVersion property is set
        internal bool IsSetQueryVersion()
        {
            return this._queryVersion != null;
        }

    }
}