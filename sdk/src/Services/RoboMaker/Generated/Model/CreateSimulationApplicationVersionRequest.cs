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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSimulationApplicationVersion operation.
    /// Creates a simulation application with a specific revision id.
    /// </summary>
    public partial class CreateSimulationApplicationVersionRequest : AmazonRoboMakerRequest
    {
        private string _application;
        private string _currentRevisionId;
        private string _imageDigest;
        private List<string> _s3Etags = new List<string>();

        /// <summary>
        /// Gets and sets the property Application. 
        /// <para>
        /// The application information for the simulation application.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1224)]
        public string Application
        {
            get { return this._application; }
            set { this._application = value; }
        }

        // Check to see if Application property is set
        internal bool IsSetApplication()
        {
            return this._application != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentRevisionId. 
        /// <para>
        /// The current revision id for the simulation application. If you provide a value and
        /// it matches the latest revision ID, a new version will be created.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string CurrentRevisionId
        {
            get { return this._currentRevisionId; }
            set { this._currentRevisionId = value; }
        }

        // Check to see if CurrentRevisionId property is set
        internal bool IsSetCurrentRevisionId()
        {
            return this._currentRevisionId != null;
        }

        /// <summary>
        /// Gets and sets the property ImageDigest. 
        /// <para>
        /// The SHA256 digest used to identify the Docker image URI used to created the simulation
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=72)]
        public string ImageDigest
        {
            get { return this._imageDigest; }
            set { this._imageDigest = value; }
        }

        // Check to see if ImageDigest property is set
        internal bool IsSetImageDigest()
        {
            return this._imageDigest != null;
        }

        /// <summary>
        /// Gets and sets the property S3Etags. 
        /// <para>
        /// The Amazon S3 eTag identifier for the zip file bundle that you use to create the simulation
        /// application.
        /// </para>
        /// </summary>
        public List<string> S3Etags
        {
            get { return this._s3Etags; }
            set { this._s3Etags = value; }
        }

        // Check to see if S3Etags property is set
        internal bool IsSetS3Etags()
        {
            return this._s3Etags != null && this._s3Etags.Count > 0; 
        }

    }
}