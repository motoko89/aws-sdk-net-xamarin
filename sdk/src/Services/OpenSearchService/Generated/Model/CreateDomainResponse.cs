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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// The result of a <code>CreateDomain</code> operation. Contains the status of the newly
    /// created Amazon OpenSearch Service domain.
    /// </summary>
    public partial class CreateDomainResponse : AmazonWebServiceResponse
    {
        private DomainStatus _domainStatus;

        /// <summary>
        /// Gets and sets the property DomainStatus. 
        /// <para>
        /// The status of the newly created domain.
        /// </para>
        /// </summary>
        public DomainStatus DomainStatus
        {
            get { return this._domainStatus; }
            set { this._domainStatus = value; }
        }

        // Check to see if DomainStatus property is set
        internal bool IsSetDomainStatus()
        {
            return this._domainStatus != null;
        }

    }
}