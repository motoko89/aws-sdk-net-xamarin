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
    /// This is the response object from the GetMetricStream operation.
    /// </summary>
    public partial class GetMetricStreamResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationDate;
        private List<MetricStreamFilter> _excludeFilters = new List<MetricStreamFilter>();
        private string _firehoseArn;
        private List<MetricStreamFilter> _includeFilters = new List<MetricStreamFilter>();
        private DateTime? _lastUpdateDate;
        private string _name;
        private MetricStreamOutputFormat _outputFormat;
        private string _roleArn;
        private string _state;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of the metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date that the metric stream was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExcludeFilters. 
        /// <para>
        /// If this array of metric namespaces is present, then these namespaces are the only
        /// metric namespaces that are not streamed by this metric stream. In this case, all other
        /// metric namespaces in the account are streamed by this metric stream.
        /// </para>
        /// </summary>
        public List<MetricStreamFilter> ExcludeFilters
        {
            get { return this._excludeFilters; }
            set { this._excludeFilters = value; }
        }

        // Check to see if ExcludeFilters property is set
        internal bool IsSetExcludeFilters()
        {
            return this._excludeFilters != null && this._excludeFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FirehoseArn. 
        /// <para>
        /// The ARN of the Amazon Kinesis Firehose delivery stream that is used by this metric
        /// stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirehoseArn
        {
            get { return this._firehoseArn; }
            set { this._firehoseArn = value; }
        }

        // Check to see if FirehoseArn property is set
        internal bool IsSetFirehoseArn()
        {
            return this._firehoseArn != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeFilters. 
        /// <para>
        /// If this array of metric namespaces is present, then these namespaces are the only
        /// metric namespaces that are streamed by this metric stream.
        /// </para>
        /// </summary>
        public List<MetricStreamFilter> IncludeFilters
        {
            get { return this._includeFilters; }
            set { this._includeFilters = value; }
        }

        // Check to see if IncludeFilters property is set
        internal bool IsSetIncludeFilters()
        {
            return this._includeFilters != null && this._includeFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateDate. 
        /// <para>
        /// The date of the most recent update to the metric stream's configuration.
        /// </para>
        /// </summary>
        public DateTime LastUpdateDate
        {
            get { return this._lastUpdateDate.GetValueOrDefault(); }
            set { this._lastUpdateDate = value; }
        }

        // Check to see if LastUpdateDate property is set
        internal bool IsSetLastUpdateDate()
        {
            return this._lastUpdateDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the metric stream.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property OutputFormat.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public MetricStreamOutputFormat OutputFormat
        {
            get { return this._outputFormat; }
            set { this._outputFormat = value; }
        }

        // Check to see if OutputFormat property is set
        internal bool IsSetOutputFormat()
        {
            return this._outputFormat != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the IAM role that is used by this metric stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the metric stream. The possible values are <code>running</code> and <code>stopped</code>.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}