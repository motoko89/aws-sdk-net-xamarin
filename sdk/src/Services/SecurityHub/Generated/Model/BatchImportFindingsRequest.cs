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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the BatchImportFindings operation.
    /// Imports security findings that are generated by the integrated third-party products
    /// into Security Hub.
    /// </summary>
    public partial class BatchImportFindingsRequest : AmazonSecurityHubRequest
    {
        private List<AwsSecurityFinding> _findings = new List<AwsSecurityFinding>();

        /// <summary>
        /// Gets and sets the property Findings. 
        /// <para>
        /// A list of findings that you want to import. Must be submitted in the AWSSecurityFinding
        /// format.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AwsSecurityFinding> Findings
        {
            get { return this._findings; }
            set { this._findings = value; }
        }

        // Check to see if Findings property is set
        internal bool IsSetFindings()
        {
            return this._findings != null && this._findings.Count > 0; 
        }

    }
}