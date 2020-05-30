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
 * Do not modify this file. This file is generated from the codeguru-reviewer-2019-09-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruReviewer.Model
{
    /// <summary>
    /// Information about a repository.
    /// </summary>
    public partial class Repository
    {
        private ThirdPartySourceRepository _bitbucket;
        private CodeCommitRepository _codeCommit;

        /// <summary>
        /// Gets and sets the property Bitbucket. 
        /// <para>
        ///  Information about a Bitbucket Cloud repository. 
        /// </para>
        /// </summary>
        public ThirdPartySourceRepository Bitbucket
        {
            get { return this._bitbucket; }
            set { this._bitbucket = value; }
        }

        // Check to see if Bitbucket property is set
        internal bool IsSetBitbucket()
        {
            return this._bitbucket != null;
        }

        /// <summary>
        /// Gets and sets the property CodeCommit. 
        /// <para>
        /// Information about an AWS CodeCommit repository.
        /// </para>
        /// </summary>
        public CodeCommitRepository CodeCommit
        {
            get { return this._codeCommit; }
            set { this._codeCommit = value; }
        }

        // Check to see if CodeCommit property is set
        internal bool IsSetCodeCommit()
        {
            return this._codeCommit != null;
        }

    }
}