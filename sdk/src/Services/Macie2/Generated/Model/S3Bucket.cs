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
    /// Provides information about an S3 bucket that a finding applies to.
    /// </summary>
    public partial class S3Bucket
    {
        private AllowsUnencryptedObjectUploads _allowsUnencryptedObjectUploads;
        private string _arn;
        private DateTime? _createdAt;
        private ServerSideEncryption _defaultServerSideEncryption;
        private string _name;
        private S3BucketOwner _owner;
        private BucketPublicAccess _publicAccess;
        private List<KeyValuePair> _tags = new List<KeyValuePair>();

        /// <summary>
        /// Gets and sets the property AllowsUnencryptedObjectUploads. 
        /// <para>
        /// Specifies whether the bucket policy for the bucket requires server-side encryption
        /// of objects when objects are uploaded to the bucket. Possible values are:
        /// </para>
        ///  <ul><li>
        /// <para>
        /// FALSE - The bucket policy requires server-side encryption of new objects. PutObject
        /// requests must include the x-amz-server-side-encryption header and the value for that
        /// header must be AES256 or aws:kms.
        /// </para>
        /// </li> <li>
        /// <para>
        /// TRUE - The bucket doesn't have a bucket policy or it has a bucket policy that doesn't
        /// require server-side encryption of new objects. If a bucket policy exists, it doesn't
        /// require PutObject requests to include the x-amz-server-side-encryption header and
        /// it doesn't require the value for that header to be AES256 or aws:kms.
        /// </para>
        /// </li> <li>
        /// <para>
        /// UNKNOWN - Amazon Macie can't determine whether the bucket policy requires server-side
        /// encryption of objects.
        /// </para>
        /// </li></ul>
        /// </summary>
        public AllowsUnencryptedObjectUploads AllowsUnencryptedObjectUploads
        {
            get { return this._allowsUnencryptedObjectUploads; }
            set { this._allowsUnencryptedObjectUploads = value; }
        }

        // Check to see if AllowsUnencryptedObjectUploads property is set
        internal bool IsSetAllowsUnencryptedObjectUploads()
        {
            return this._allowsUnencryptedObjectUploads != null;
        }

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the bucket.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when the bucket was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultServerSideEncryption. 
        /// <para>
        /// The type of server-side encryption that's used by default to encrypt objects in the
        /// bucket.
        /// </para>
        /// </summary>
        public ServerSideEncryption DefaultServerSideEncryption
        {
            get { return this._defaultServerSideEncryption; }
            set { this._defaultServerSideEncryption = value; }
        }

        // Check to see if DefaultServerSideEncryption property is set
        internal bool IsSetDefaultServerSideEncryption()
        {
            return this._defaultServerSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The display name and AWS account ID for the user who owns the bucket.
        /// </para>
        /// </summary>
        public S3BucketOwner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAccess. 
        /// <para>
        /// The permissions settings that determine whether the bucket is publicly accessible.
        /// </para>
        /// </summary>
        public BucketPublicAccess PublicAccess
        {
            get { return this._publicAccess; }
            set { this._publicAccess = value; }
        }

        // Check to see if PublicAccess property is set
        internal bool IsSetPublicAccess()
        {
            return this._publicAccess != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are associated with the bucket.
        /// </para>
        /// </summary>
        public List<KeyValuePair> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}