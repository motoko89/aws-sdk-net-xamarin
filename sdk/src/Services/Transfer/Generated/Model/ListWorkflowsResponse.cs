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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// This is the response object from the ListWorkflows operation.
    /// </summary>
    public partial class ListWorkflowsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ListedWorkflow> _workflows = new List<ListedWorkflow>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  <code>ListWorkflows</code> returns the <code>NextToken</code> parameter in the output.
        /// You can then pass the <code>NextToken</code> parameter in a subsequent command to
        /// continue listing additional workflows.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=6144)]
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
        /// Gets and sets the property Workflows. 
        /// <para>
        /// Returns the <code>Arn</code>, <code>WorkflowId</code>, and <code>Description</code>
        /// for each workflow.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ListedWorkflow> Workflows
        {
            get { return this._workflows; }
            set { this._workflows = value; }
        }

        // Check to see if Workflows property is set
        internal bool IsSetWorkflows()
        {
            return this._workflows != null && this._workflows.Count > 0; 
        }

    }
}