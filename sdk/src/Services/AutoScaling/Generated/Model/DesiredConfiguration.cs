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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes the desired configuration for an instance refresh. 
    /// 
    ///  
    /// <para>
    /// If you specify a desired configuration, you must specify either a <code>LaunchTemplate</code>
    /// or a <code>MixedInstancesPolicy</code>. 
    /// </para>
    /// </summary>
    public partial class DesiredConfiguration
    {
        private LaunchTemplateSpecification _launchTemplate;
        private MixedInstancesPolicy _mixedInstancesPolicy;

        /// <summary>
        /// Gets and sets the property LaunchTemplate.
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property MixedInstancesPolicy.
        /// </summary>
        public MixedInstancesPolicy MixedInstancesPolicy
        {
            get { return this._mixedInstancesPolicy; }
            set { this._mixedInstancesPolicy = value; }
        }

        // Check to see if MixedInstancesPolicy property is set
        internal bool IsSetMixedInstancesPolicy()
        {
            return this._mixedInstancesPolicy != null;
        }

    }
}