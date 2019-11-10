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
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Signer.Model
{
    /// <summary>
    /// Any overrides that are applied to the signing configuration of a code signing platform.
    /// </summary>
    public partial class SigningPlatformOverrides
    {
        private SigningConfigurationOverrides _signingConfiguration;

        /// <summary>
        /// Gets and sets the property SigningConfiguration. 
        /// <para>
        /// A signing configuration that overrides the default encryption or hash algorithm of
        /// a signing job.
        /// </para>
        /// </summary>
        public SigningConfigurationOverrides SigningConfiguration
        {
            get { return this._signingConfiguration; }
            set { this._signingConfiguration = value; }
        }

        // Check to see if SigningConfiguration property is set
        internal bool IsSetSigningConfiguration()
        {
            return this._signingConfiguration != null;
        }

    }
}