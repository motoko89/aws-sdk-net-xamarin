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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LicenseManager.Model
{
    /// <summary>
    /// This is the response object from the GetLicenseConversionTask operation.
    /// </summary>
    public partial class GetLicenseConversionTaskResponse : AmazonWebServiceResponse
    {
        private LicenseConversionContext _destinationLicenseContext;
        private DateTime? _endTime;
        private string _licenseConversionTaskId;
        private DateTime? _licenseConversionTime;
        private string _resourceArn;
        private LicenseConversionContext _sourceLicenseContext;
        private DateTime? _startTime;
        private LicenseConversionTaskStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property DestinationLicenseContext. 
        /// <para>
        /// Information about the license type converted to.
        /// </para>
        /// </summary>
        public LicenseConversionContext DestinationLicenseContext
        {
            get { return this._destinationLicenseContext; }
            set { this._destinationLicenseContext = value; }
        }

        // Check to see if DestinationLicenseContext property is set
        internal bool IsSetDestinationLicenseContext()
        {
            return this._destinationLicenseContext != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time at which the license type conversion task was completed.
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
        /// Gets and sets the property LicenseConversionTaskId. 
        /// <para>
        /// ID of the license type conversion task.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public string LicenseConversionTaskId
        {
            get { return this._licenseConversionTaskId; }
            set { this._licenseConversionTaskId = value; }
        }

        // Check to see if LicenseConversionTaskId property is set
        internal bool IsSetLicenseConversionTaskId()
        {
            return this._licenseConversionTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseConversionTime. 
        /// <para>
        /// Amount of time to complete the license type conversion.
        /// </para>
        /// </summary>
        public DateTime LicenseConversionTime
        {
            get { return this._licenseConversionTime.GetValueOrDefault(); }
            set { this._licenseConversionTime = value; }
        }

        // Check to see if LicenseConversionTime property is set
        internal bool IsSetLicenseConversionTime()
        {
            return this._licenseConversionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// Amazon Resource Names (ARN) of the resources the license conversion task is associated
        /// with.
        /// </para>
        /// </summary>
        public string ResourceArn
        {
            get { return this._resourceArn; }
            set { this._resourceArn = value; }
        }

        // Check to see if ResourceArn property is set
        internal bool IsSetResourceArn()
        {
            return this._resourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceLicenseContext. 
        /// <para>
        /// Information about the license type converted from.
        /// </para>
        /// </summary>
        public LicenseConversionContext SourceLicenseContext
        {
            get { return this._sourceLicenseContext; }
            set { this._sourceLicenseContext = value; }
        }

        // Check to see if SourceLicenseContext property is set
        internal bool IsSetSourceLicenseContext()
        {
            return this._sourceLicenseContext != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// Time at which the license type conversion task was started .
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the license type conversion task.
        /// </para>
        /// </summary>
        public LicenseConversionTaskStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The status message for the conversion task.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

    }
}