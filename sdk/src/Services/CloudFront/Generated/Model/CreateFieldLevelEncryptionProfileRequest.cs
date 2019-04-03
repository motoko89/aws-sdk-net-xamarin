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
 * Do not modify this file. This file is generated from the cloudfront-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// Container for the parameters to the CreateFieldLevelEncryptionProfile operation.
    /// Create a field-level encryption profile.
    /// </summary>
    public partial class CreateFieldLevelEncryptionProfileRequest : AmazonCloudFrontRequest
    {
        private FieldLevelEncryptionProfileConfig _fieldLevelEncryptionProfileConfig;

        /// <summary>
        /// Gets and sets the property FieldLevelEncryptionProfileConfig. 
        /// <para>
        /// The request to create a field-level encryption profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FieldLevelEncryptionProfileConfig FieldLevelEncryptionProfileConfig
        {
            get { return this._fieldLevelEncryptionProfileConfig; }
            set { this._fieldLevelEncryptionProfileConfig = value; }
        }

        // Check to see if FieldLevelEncryptionProfileConfig property is set
        internal bool IsSetFieldLevelEncryptionProfileConfig()
        {
            return this._fieldLevelEncryptionProfileConfig != null;
        }

    }
}