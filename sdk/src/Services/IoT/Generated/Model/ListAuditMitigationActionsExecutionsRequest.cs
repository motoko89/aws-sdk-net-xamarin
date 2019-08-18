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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListAuditMitigationActionsExecutions operation.
    /// Gets the status of audit mitigation action tasks that were executed.
    /// </summary>
    public partial class ListAuditMitigationActionsExecutionsRequest : AmazonIoTRequest
    {
        private AuditMitigationActionsExecutionStatus _actionStatus;
        private string _findingId;
        private int? _maxResults;
        private string _nextToken;
        private string _taskId;

        /// <summary>
        /// Gets and sets the property ActionStatus. 
        /// <para>
        /// Specify this filter to limit results to those with a specific status.
        /// </para>
        /// </summary>
        public AuditMitigationActionsExecutionStatus ActionStatus
        {
            get { return this._actionStatus; }
            set { this._actionStatus = value; }
        }

        // Check to see if ActionStatus property is set
        internal bool IsSetActionStatus()
        {
            return this._actionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// Specify this filter to limit results to those that were applied to a specific audit
        /// finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string FindingId
        {
            get { return this._findingId; }
            set { this._findingId = value; }
        }

        // Check to see if FindingId property is set
        internal bool IsSetFindingId()
        {
            return this._findingId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time. The default is 25.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=250)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of results.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TaskId. 
        /// <para>
        /// Specify this filter to limit results to actions for a specific audit mitigation actions
        /// task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string TaskId
        {
            get { return this._taskId; }
            set { this._taskId = value; }
        }

        // Check to see if TaskId property is set
        internal bool IsSetTaskId()
        {
            return this._taskId != null;
        }

    }
}