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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the ListMetrics operation.
    /// List the specified metrics. You can use the returned metrics with <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>
    /// to obtain statistical data.
    /// 
    ///  
    /// <para>
    /// Up to 500 results are returned for any one call. To retrieve additional results, use
    /// the returned token with subsequent calls.
    /// </para>
    ///  
    /// <para>
    /// After you create a metric, allow up to fifteen minutes before the metric appears.
    /// Statistics about the metric, however, are available sooner using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricData.html">GetMetricData</a>
    /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_GetMetricStatistics.html">GetMetricStatistics</a>.
    /// </para>
    /// </summary>
    public partial class ListMetricsRequest : AmazonCloudWatchRequest
    {
        private List<DimensionFilter> _dimensions = new List<DimensionFilter>();
        private string _metricName;
        private string _awsNamespace;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Dimensions. 
        /// <para>
        /// The dimensions to filter against.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<DimensionFilter> Dimensions
        {
            get { return this._dimensions; }
            set { this._dimensions = value; }
        }

        // Check to see if Dimensions property is set
        internal bool IsSetDimensions()
        {
            return this._dimensions != null && this._dimensions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the metric to filter against.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string MetricName
        {
            get { return this._metricName; }
            set { this._metricName = value; }
        }

        // Check to see if MetricName property is set
        internal bool IsSetMetricName()
        {
            return this._metricName != null;
        }

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace to filter against.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Namespace
        {
            get { return this._awsNamespace; }
            set { this._awsNamespace = value; }
        }

        // Check to see if Namespace property is set
        internal bool IsSetNamespace()
        {
            return this._awsNamespace != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to indicate that there is more data available.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}