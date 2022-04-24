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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// This is the response object from the GetAppMonitor operation.
    /// </summary>
    public partial class GetAppMonitorResponse : AmazonWebServiceResponse
    {
        private AppMonitor _appMonitor;

        /// <summary>
        /// Gets and sets the property AppMonitor. 
        /// <para>
        /// A structure containing all the configuration information for the app monitor.
        /// </para>
        /// </summary>
        public AppMonitor AppMonitor
        {
            get { return this._appMonitor; }
            set { this._appMonitor = value; }
        }

        // Check to see if AppMonitor property is set
        internal bool IsSetAppMonitor()
        {
            return this._appMonitor != null;
        }

    }
}