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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the ConfigureAgent operation.
    /// 
    /// </summary>
    public partial class ConfigureAgentRequest : AmazonCodeGuruProfilerRequest
    {
        private string _fleetInstanceId;
        private string _profilingGroupName;

        /// <summary>
        /// Gets and sets the property FleetInstanceId.
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string FleetInstanceId
        {
            get { return this._fleetInstanceId; }
            set { this._fleetInstanceId = value; }
        }

        // Check to see if FleetInstanceId property is set
        internal bool IsSetFleetInstanceId()
        {
            return this._fleetInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

    }
}