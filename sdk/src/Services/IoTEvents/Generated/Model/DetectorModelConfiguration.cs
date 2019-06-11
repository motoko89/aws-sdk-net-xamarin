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
 * Do not modify this file. This file is generated from the iotevents-2018-07-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoTEvents.Model
{
    /// <summary>
    /// Information about how the detector model is configured.
    /// </summary>
    public partial class DetectorModelConfiguration
    {
        private DateTime? _creationTime;
        private string _detectorModelArn;
        private string _detectorModelDescription;
        private string _detectorModelName;
        private string _detectorModelVersion;
        private string _key;
        private DateTime? _lastUpdateTime;
        private string _roleArn;
        private DetectorModelVersionStatus _status;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time the detector model was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DetectorModelArn. 
        /// <para>
        /// The ARN of the detector model.
        /// </para>
        /// </summary>
        public string DetectorModelArn
        {
            get { return this._detectorModelArn; }
            set { this._detectorModelArn = value; }
        }

        // Check to see if DetectorModelArn property is set
        internal bool IsSetDetectorModelArn()
        {
            return this._detectorModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelDescription. 
        /// <para>
        /// A brief description of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string DetectorModelDescription
        {
            get { return this._detectorModelDescription; }
            set { this._detectorModelDescription = value; }
        }

        // Check to see if DetectorModelDescription property is set
        internal bool IsSetDetectorModelDescription()
        {
            return this._detectorModelDescription != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelName. 
        /// <para>
        /// The name of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DetectorModelName
        {
            get { return this._detectorModelName; }
            set { this._detectorModelName = value; }
        }

        // Check to see if DetectorModelName property is set
        internal bool IsSetDetectorModelName()
        {
            return this._detectorModelName != null;
        }

        /// <summary>
        /// Gets and sets the property DetectorModelVersion. 
        /// <para>
        /// The version of the detector model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string DetectorModelVersion
        {
            get { return this._detectorModelVersion; }
            set { this._detectorModelVersion = value; }
        }

        // Check to see if DetectorModelVersion property is set
        internal bool IsSetDetectorModelVersion()
        {
            return this._detectorModelVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The input attribute key used to identify a device or system in order to create a detector
        /// (an instance of the detector model) and then to route each input received to the appropriate
        /// detector (instance). This parameter uses a JSON-path expression to specify the attribute-value
        /// pair in the message payload of each input that is used to identify the device associated
        /// with the input.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The time the detector model was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the role that grants permission to AWS IoT Events to perform its operations.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the detector model.
        /// </para>
        /// </summary>
        public DetectorModelVersionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}