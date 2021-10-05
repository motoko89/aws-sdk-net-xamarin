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
    /// This is the response object from the CreateFleetMetric operation.
    /// </summary>
    public partial class CreateFleetMetricResponse : AmazonWebServiceResponse
    {
        private string _metricArn;
        private string _metricName;

        /// <summary>
        /// Gets and sets the property MetricArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new fleet metric.
        /// </para>
        /// </summary>
        public string MetricArn
        {
            get { return this._metricArn; }
            set { this._metricArn = value; }
        }

        // Check to see if MetricArn property is set
        internal bool IsSetMetricArn()
        {
            return this._metricArn != null;
        }

        /// <summary>
        /// Gets and sets the property MetricName. 
        /// <para>
        /// The name of the fleet metric to create.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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

    }
}