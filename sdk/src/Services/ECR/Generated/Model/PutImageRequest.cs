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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECR.Model
{
    /// <summary>
    /// Container for the parameters to the PutImage operation.
    /// Creates or updates the image manifest and tags associated with an image.
    /// 
    ///  
    /// <para>
    /// When an image is pushed and all new image layers have been uploaded, the PutImage
    /// API is called once to create or update the image manifest and tags associated with
    /// the image.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation is used by the Amazon ECR proxy, and it is not intended for general
    /// use by customers for pulling and pushing images. In most cases, you should use the
    /// <code>docker</code> CLI to pull, tag, and push images.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutImageRequest : AmazonECRRequest
    {
        private string _imageManifest;
        private string _imageTag;
        private string _registryId;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ImageManifest. 
        /// <para>
        /// The image manifest corresponding to the image to be uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4194304)]
        public string ImageManifest
        {
            get { return this._imageManifest; }
            set { this._imageManifest = value; }
        }

        // Check to see if ImageManifest property is set
        internal bool IsSetImageManifest()
        {
            return this._imageManifest != null;
        }

        /// <summary>
        /// Gets and sets the property ImageTag. 
        /// <para>
        /// The tag to associate with the image. This parameter is required for images that use
        /// the Docker Image Manifest V2 Schema 2 or OCI formats.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=300)]
        public string ImageTag
        {
            get { return this._imageTag; }
            set { this._imageTag = value; }
        }

        // Check to see if ImageTag property is set
        internal bool IsSetImageTag()
        {
            return this._imageTag != null;
        }

        /// <summary>
        /// Gets and sets the property RegistryId. 
        /// <para>
        /// The AWS account ID associated with the registry that contains the repository in which
        /// to put the image. If you do not specify a registry, the default registry is assumed.
        /// </para>
        /// </summary>
        public string RegistryId
        {
            get { return this._registryId; }
            set { this._registryId = value; }
        }

        // Check to see if RegistryId property is set
        internal bool IsSetRegistryId()
        {
            return this._registryId != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository in which to put the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=256)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}