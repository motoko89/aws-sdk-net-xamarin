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
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// Container for the parameters to the SetVisibleToAllUsers operation.
    /// <i>This member will be deprecated.</i> 
    /// 
    ///  
    /// <para>
    /// Sets whether all AWS Identity and Access Management (IAM) users under your account
    /// can access the specified clusters (job flows). This action works on running clusters.
    /// You can also set the visibility of a cluster when you launch it using the <code>VisibleToAllUsers</code>
    /// parameter of <a>RunJobFlow</a>. The SetVisibleToAllUsers action can be called only
    /// by an IAM user who created the cluster or the AWS account that owns the cluster.
    /// </para>
    /// </summary>
    public partial class SetVisibleToAllUsersRequest : AmazonElasticMapReduceRequest
    {
        private List<string> _jobFlowIds = new List<string>();
        private bool? _visibleToAllUsers;

        /// <summary>
        /// Gets and sets the property JobFlowIds. 
        /// <para>
        /// Identifiers of the job flows to receive the new visibility setting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> JobFlowIds
        {
            get { return this._jobFlowIds; }
            set { this._jobFlowIds = value; }
        }

        // Check to see if JobFlowIds property is set
        internal bool IsSetJobFlowIds()
        {
            return this._jobFlowIds != null && this._jobFlowIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VisibleToAllUsers. 
        /// <para>
        ///  <i>This member will be deprecated.</i> 
        /// </para>
        ///  
        /// <para>
        /// Whether the specified clusters are visible to all IAM users of the AWS account associated
        /// with the cluster. If this value is set to True, all IAM users of that AWS account
        /// can view and, if they have the proper IAM policy permissions set, manage the clusters.
        /// If it is set to False, only the IAM user that created a cluster can view and manage
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool VisibleToAllUsers
        {
            get { return this._visibleToAllUsers.GetValueOrDefault(); }
            set { this._visibleToAllUsers = value; }
        }

        // Check to see if VisibleToAllUsers property is set
        internal bool IsSetVisibleToAllUsers()
        {
            return this._visibleToAllUsers.HasValue; 
        }

    }
}