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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides statistical data and other information about an AWS resource that Amazon
    /// Macie monitors and analyzes.
    /// </summary>
    public partial class MatchingResource
    {
        private MatchingBucket _matchingBucket;

        /// <summary>
        /// Gets and sets the property MatchingBucket. 
        /// <para>
        /// The details of an S3 bucket that Amazon Macie monitors and analyzes.
        /// </para>
        /// </summary>
        public MatchingBucket MatchingBucket
        {
            get { return this._matchingBucket; }
            set { this._matchingBucket = value; }
        }

        // Check to see if MatchingBucket property is set
        internal bool IsSetMatchingBucket()
        {
            return this._matchingBucket != null;
        }

    }
}