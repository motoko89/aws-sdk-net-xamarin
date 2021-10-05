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
    /// This is the response object from the DescribeStorageVirtualMachines operation.
    /// </summary>
    public partial class DescribeStorageVirtualMachinesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<StorageVirtualMachine> _storageVirtualMachines = new List<StorageVirtualMachine>();

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
        /// Gets and sets the property StorageVirtualMachines. 
        /// <para>
        /// Returned after a successful <code>DescribeStorageVirtualMachines</code> operation,
        /// describing each SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<StorageVirtualMachine> StorageVirtualMachines
        {
            get { return this._storageVirtualMachines; }
            set { this._storageVirtualMachines = value; }
        }

        // Check to see if StorageVirtualMachines property is set
        internal bool IsSetStorageVirtualMachines()
        {
            return this._storageVirtualMachines != null && this._storageVirtualMachines.Count > 0; 
        }

    }
}