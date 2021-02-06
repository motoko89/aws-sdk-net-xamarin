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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateQueueOutboundCallerConfig operation.
    /// This API is in preview release for Amazon Connect and is subject to change.
    /// 
    ///  
    /// <para>
    /// Updates the outbound caller ID name, number, and outbound whisper flow for a specified
    /// queue.
    /// </para>
    /// </summary>
    public partial class UpdateQueueOutboundCallerConfigRequest : AmazonConnectRequest
    {
        private string _instanceId;
        private OutboundCallerConfig _outboundCallerConfig;
        private string _queueId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Amazon Connect instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property OutboundCallerConfig. 
        /// <para>
        /// The outbound caller ID name, number, and outbound whisper flow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutboundCallerConfig OutboundCallerConfig
        {
            get { return this._outboundCallerConfig; }
            set { this._outboundCallerConfig = value; }
        }

        // Check to see if OutboundCallerConfig property is set
        internal bool IsSetOutboundCallerConfig()
        {
            return this._outboundCallerConfig != null;
        }

        /// <summary>
        /// Gets and sets the property QueueId. 
        /// <para>
        /// The identifier for the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueId
        {
            get { return this._queueId; }
            set { this._queueId = value; }
        }

        // Check to see if QueueId property is set
        internal bool IsSetQueueId()
        {
            return this._queueId != null;
        }

    }
}