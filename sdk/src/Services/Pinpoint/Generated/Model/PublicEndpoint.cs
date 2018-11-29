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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Public endpoint attributes.
    /// </summary>
    public partial class PublicEndpoint
    {
        private string _address;
        private Dictionary<string, List<string>> _attributes = new Dictionary<string, List<string>>();
        private ChannelType _channelType;
        private EndpointDemographic _demographic;
        private string _effectiveDate;
        private string _endpointStatus;
        private EndpointLocation _location;
        private Dictionary<string, double> _metrics = new Dictionary<string, double>();
        private string _optOut;
        private string _requestId;
        private EndpointUser _user;

        /// <summary>
        /// Gets and sets the property Address. The unique identifier for the recipient. For example,
        /// an address could be a device token, email address, or mobile phone number.
        /// </summary>
        public string Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        // Check to see if Address property is set
        internal bool IsSetAddress()
        {
            return this._address != null;
        }

        /// <summary>
        /// Gets and sets the property Attributes. Custom attributes that your app reports to
        /// Amazon Pinpoint. You can use these attributes as selection criteria when you create
        /// a segment.
        /// </summary>
        public Dictionary<string, List<string>> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ChannelType. The channel type.Valid values: APNS, GCM
        /// </summary>
        public ChannelType ChannelType
        {
            get { return this._channelType; }
            set { this._channelType = value; }
        }

        // Check to see if ChannelType property is set
        internal bool IsSetChannelType()
        {
            return this._channelType != null;
        }

        /// <summary>
        /// Gets and sets the property Demographic. The endpoint demographic attributes.
        /// </summary>
        public EndpointDemographic Demographic
        {
            get { return this._demographic; }
            set { this._demographic = value; }
        }

        // Check to see if Demographic property is set
        internal bool IsSetDemographic()
        {
            return this._demographic != null;
        }

        /// <summary>
        /// Gets and sets the property EffectiveDate. The date and time when the endpoint was
        /// last updated, in  ISO 8601 format.
        /// </summary>
        public string EffectiveDate
        {
            get { return this._effectiveDate; }
            set { this._effectiveDate = value; }
        }

        // Check to see if EffectiveDate property is set
        internal bool IsSetEffectiveDate()
        {
            return this._effectiveDate != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointStatus. The status of the endpoint. If the update
        /// fails, the value is INACTIVE. If the endpoint is updated successfully, the value is
        /// ACTIVE.
        /// </summary>
        public string EndpointStatus
        {
            get { return this._endpointStatus; }
            set { this._endpointStatus = value; }
        }

        // Check to see if EndpointStatus property is set
        internal bool IsSetEndpointStatus()
        {
            return this._endpointStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Location. The endpoint location attributes.
        /// </summary>
        public EndpointLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Metrics. Custom metrics that your app reports to Amazon
        /// Pinpoint.
        /// </summary>
        public Dictionary<string, double> Metrics
        {
            get { return this._metrics; }
            set { this._metrics = value; }
        }

        // Check to see if Metrics property is set
        internal bool IsSetMetrics()
        {
            return this._metrics != null && this._metrics.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OptOut. Indicates whether a user has opted out of receiving
        /// messages with one of the following values:ALL - User has opted out of all messages.NONE
        /// - Users has not opted out and receives all messages.
        /// </summary>
        public string OptOut
        {
            get { return this._optOut; }
            set { this._optOut = value; }
        }

        // Check to see if OptOut property is set
        internal bool IsSetOptOut()
        {
            return this._optOut != null;
        }

        /// <summary>
        /// Gets and sets the property RequestId. A unique identifier that is generated each time
        /// the endpoint is updated.
        /// </summary>
        public string RequestId
        {
            get { return this._requestId; }
            set { this._requestId = value; }
        }

        // Check to see if RequestId property is set
        internal bool IsSetRequestId()
        {
            return this._requestId != null;
        }

        /// <summary>
        /// Gets and sets the property User. Custom user-specific attributes that your app reports
        /// to Amazon Pinpoint.
        /// </summary>
        public EndpointUser User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        // Check to see if User property is set
        internal bool IsSetUser()
        {
            return this._user != null;
        }

    }
}