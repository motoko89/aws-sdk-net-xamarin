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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// Object that captures the Amazon IVS configuration that the customer provisioned, the
    /// ingest configurations that the broadcaster used, and the most recent Amazon IVS stream
    /// events it encountered.
    /// </summary>
    public partial class StreamSession
    {
        private Channel _channel;
        private DateTime? _endTime;
        private IngestConfiguration _ingestConfiguration;
        private RecordingConfiguration _recordingConfiguration;
        private DateTime? _startTime;
        private string _streamId;
        private List<StreamEvent> _truncatedEvents = new List<StreamEvent>();

        /// <summary>
        /// Gets and sets the property Channel. 
        /// <para>
        /// The properties of the channel at the time of going live.
        /// </para>
        /// </summary>
        public Channel Channel
        {
            get { return this._channel; }
            set { this._channel = value; }
        }

        // Check to see if Channel property is set
        internal bool IsSetChannel()
        {
            return this._channel != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// UTC ISO-8601 formatted timestamp of when the channel went offline. For live streams,
        /// this is <code>NULL</code>.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IngestConfiguration. 
        /// <para>
        /// The properties of the incoming RTMP stream for the stream.
        /// </para>
        /// </summary>
        public IngestConfiguration IngestConfiguration
        {
            get { return this._ingestConfiguration; }
            set { this._ingestConfiguration = value; }
        }

        // Check to see if IngestConfiguration property is set
        internal bool IsSetIngestConfiguration()
        {
            return this._ingestConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RecordingConfiguration. 
        /// <para>
        /// The properties of recording the live stream.
        /// </para>
        /// </summary>
        public RecordingConfiguration RecordingConfiguration
        {
            get { return this._recordingConfiguration; }
            set { this._recordingConfiguration = value; }
        }

        // Check to see if RecordingConfiguration property is set
        internal bool IsSetRecordingConfiguration()
        {
            return this._recordingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// UTC ISO-8601 formatted timestamp of when the channel went live.
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamId. 
        /// <para>
        /// Unique identifier for a live or previously live stream in the specified channel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=26, Max=26)]
        public string StreamId
        {
            get { return this._streamId; }
            set { this._streamId = value; }
        }

        // Check to see if StreamId property is set
        internal bool IsSetStreamId()
        {
            return this._streamId != null;
        }

        /// <summary>
        /// Gets and sets the property TruncatedEvents. 
        /// <para>
        /// List of Amazon IVS events that the stream encountered. The list is sorted by most
        /// recent events and contains up to 500 events. For Amazon IVS events, see <a href="https://docs.aws.amazon.com/ivs/latest/userguide/eventbridge.html">Using
        /// Amazon EventBridge with Amazon IVS</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<StreamEvent> TruncatedEvents
        {
            get { return this._truncatedEvents; }
            set { this._truncatedEvents = value; }
        }

        // Check to see if TruncatedEvents property is set
        internal bool IsSetTruncatedEvents()
        {
            return this._truncatedEvents != null && this._truncatedEvents.Count > 0; 
        }

    }
}