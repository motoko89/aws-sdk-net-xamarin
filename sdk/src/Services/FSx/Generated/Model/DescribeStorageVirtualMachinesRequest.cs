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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeStorageVirtualMachines operation.
    /// Describes one or more Amazon FSx for NetApp ONTAP storage virtual machines (SVMs).
    /// </summary>
    public partial class DescribeStorageVirtualMachinesRequest : AmazonFSxRequest
    {
        private List<StorageVirtualMachineFilter> _filters = new List<StorageVirtualMachineFilter>();
        private int? _maxResults;
        private string _nextToken;
        private List<string> _storageVirtualMachineIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Enter a filter name:value pair to view a select set of SVMs.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1)]
        public List<StorageVirtualMachineFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
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
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property StorageVirtualMachineIds. 
        /// <para>
        /// Enter the ID of one or more SVMs that you want to view.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<string> StorageVirtualMachineIds
        {
            get { return this._storageVirtualMachineIds; }
            set { this._storageVirtualMachineIds = value; }
        }

        // Check to see if StorageVirtualMachineIds property is set
        internal bool IsSetStorageVirtualMachineIds()
        {
            return this._storageVirtualMachineIds != null && this._storageVirtualMachineIds.Count > 0; 
        }

    }
}