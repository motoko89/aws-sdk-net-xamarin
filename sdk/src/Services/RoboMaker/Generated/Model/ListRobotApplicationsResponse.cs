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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the ListRobotApplications operation.
    /// </summary>
    public partial class ListRobotApplicationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<RobotApplicationSummary> _robotApplicationSummaries = new List<RobotApplicationSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListRobotApplications</code>
        /// request. When the results of a <code>ListRobotApplications</code> request exceed <code>maxResults</code>,
        /// this value can be used to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property RobotApplicationSummaries. 
        /// <para>
        /// A list of robot application summaries that meet the criteria of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<RobotApplicationSummary> RobotApplicationSummaries
        {
            get { return this._robotApplicationSummaries; }
            set { this._robotApplicationSummaries = value; }
        }

        // Check to see if RobotApplicationSummaries property is set
        internal bool IsSetRobotApplicationSummaries()
        {
            return this._robotApplicationSummaries != null && this._robotApplicationSummaries.Count > 0; 
        }

    }
}