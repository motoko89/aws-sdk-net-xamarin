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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EKS.Model
{
    /// <summary>
    /// This is the response object from the ListNodegroups operation.
    /// </summary>
    public partial class ListNodegroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _nodegroups = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> value to include in a future <code>ListNodegroups</code>
        /// request. When the results of a <code>ListNodegroups</code> request exceed <code>maxResults</code>,
        /// you can use this value to retrieve the next page of results. This value is <code>null</code>
        /// when there are no more results to return.
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
        /// Gets and sets the property Nodegroups. 
        /// <para>
        /// A list of all of the node groups associated with the specified cluster.
        /// </para>
        /// </summary>
        public List<string> Nodegroups
        {
            get { return this._nodegroups; }
            set { this._nodegroups = value; }
        }

        // Check to see if Nodegroups property is set
        internal bool IsSetNodegroups()
        {
            return this._nodegroups != null && this._nodegroups.Count > 0; 
        }

    }
}