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
 * Do not modify this file. This file is generated from the devops-guru-2020-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DevOpsGuru.Model
{
    /// <summary>
    /// A single query to be processed. Use these parameters to query the Performance Insights
    /// <code>GetResourceMetrics</code> API to retrieve the metrics for an anomaly. For more
    /// information, see <code> <a href="https://docs.aws.amazon.com/performance-insights/latest/APIReference/API_GetResourceMetrics.html">GetResourceMetrics</a>
    /// </code> in the <i>Amazon RDS Performance Insights API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Amazon RDS Performance Insights enables you to monitor and explore different dimensions
    /// of database load based on data captured from a running DB instance. DB load is measured
    /// as average active sessions. Performance Insights provides the data to API consumers
    /// as a two-dimensional time-series dataset. The time dimension provides DB load data
    /// for each time point in the queried time range. Each time point decomposes overall
    /// load in relation to the requested dimensions, measured at that time point. Examples
    /// include SQL, Wait event, User, and Host. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon Aurora DB instances, go to the
    /// <a href="https://docs.aws.amazon.com/AmazonRDS/latest/AuroraUserGuide/USER_PerfInsights.html">
    /// Amazon Aurora User Guide</a>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To learn more about Performance Insights and Amazon RDS DB instances, go to the <a
    /// href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/USER_PerfInsights.html">
    /// Amazon RDS User Guide</a>. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PerformanceInsightsMetricQuery
    {
        private Dictionary<string, string> _filter = new Dictionary<string, string>();
        private PerformanceInsightsMetricDimensionGroup _groupBy;
        private string _metric;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// One or more filters to apply to a Performance Insights <code>GetResourceMetrics</code>
        /// API query. Restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any number of filters by the same dimension, as specified in the <code>GroupBy</code>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A single filter for any other dimension in this dimension group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public Dictionary<string, string> Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null && this._filter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GroupBy. 
        /// <para>
        /// The specification for how to aggregate the data points from a Performance Insights
        /// <code>GetResourceMetrics</code> API query. The Performance Insights query returns
        /// all of the dimensions within that group, unless you provide the names of specific
        /// dimensions within that group. You can also request that Performance Insights return
        /// a limited number of values for a dimension.
        /// </para>
        /// </summary>
        public PerformanceInsightsMetricDimensionGroup GroupBy
        {
            get { return this._groupBy; }
            set { this._groupBy = value; }
        }

        // Check to see if GroupBy property is set
        internal bool IsSetGroupBy()
        {
            return this._groupBy != null;
        }

        /// <summary>
        /// Gets and sets the property Metric. 
        /// <para>
        /// The name of the meteric used used when querying an Performance Insights <code>GetResourceMetrics</code>
        /// API for anomaly metrics.
        /// </para>
        ///  
        /// <para>
        /// Valid values for <code>Metric</code> are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>db.load.avg</code> - a scaled representation of the number of active sessions
        /// for the database engine.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>db.sampledload.avg</code> - the raw number of active sessions for the database
        /// engine.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the number of active sessions is less than an internal Performance Insights threshold,
        /// <code>db.load.avg</code> and <code>db.sampledload.avg</code> are the same value. If
        /// the number of active sessions is greater than the internal threshold, Performance
        /// Insights samples the active sessions, with <code>db.load.avg</code> showing the scaled
        /// values, <code>db.sampledload.avg</code> showing the raw values, and <code>db.sampledload.avg</code>
        /// less than <code>db.load.avg</code>. For most use cases, you can query <code>db.load.avg</code>
        /// only. 
        /// </para>
        /// </summary>
        public string Metric
        {
            get { return this._metric; }
            set { this._metric = value; }
        }

        // Check to see if Metric property is set
        internal bool IsSetMetric()
        {
            return this._metric != null;
        }

    }
}