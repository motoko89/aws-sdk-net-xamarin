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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The sharing settings.
    /// </summary>
    public partial class SharingSettings
    {
        private NotebookOutputOption _notebookOutputOption;
        private string _s3KmsKeyId;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property NotebookOutputOption. 
        /// <para>
        /// The notebook output option.
        /// </para>
        /// </summary>
        public NotebookOutputOption NotebookOutputOption
        {
            get { return this._notebookOutputOption; }
            set { this._notebookOutputOption = value; }
        }

        // Check to see if NotebookOutputOption property is set
        internal bool IsSetNotebookOutputOption()
        {
            return this._notebookOutputOption != null;
        }

        /// <summary>
        /// Gets and sets the property S3KmsKeyId. 
        /// <para>
        /// The AWS Key Management Service encryption key ID.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string S3KmsKeyId
        {
            get { return this._s3KmsKeyId; }
            set { this._s3KmsKeyId = value; }
        }

        // Check to see if S3KmsKeyId property is set
        internal bool IsSetS3KmsKeyId()
        {
            return this._s3KmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// The Amazon S3 output path.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}