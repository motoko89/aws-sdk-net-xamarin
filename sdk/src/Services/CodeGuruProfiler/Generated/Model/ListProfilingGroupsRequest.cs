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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the ListProfilingGroups operation.
    /// List profiling groups in the account.
    /// </summary>
    public partial class ListProfilingGroupsRequest : AmazonCodeGuruProfilerRequest
    {
        private bool? _includeDescription;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property IncludeDescription. 
        /// <para>
        /// If set to true, returns the full description of the profiling groups instead of the
        /// names. Defaults to false.
        /// </para>
        /// </summary>
        public bool IncludeDescription
        {
            get { return this._includeDescription.GetValueOrDefault(); }
            set { this._includeDescription = value; }
        }

        // Check to see if IncludeDescription property is set
        internal bool IsSetIncludeDescription()
        {
            return this._includeDescription.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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

    }
}