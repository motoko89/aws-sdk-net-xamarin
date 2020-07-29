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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a block device for an EBS volume.
    /// </summary>
    public partial class EbsBlockDevice
    {
        private bool? _deleteOnTermination;
        private bool? _encrypted;
        private int? _iops;
        private string _kmsKeyId;
        private string _snapshotId;
        private int? _volumeSize;
        private VolumeType _volumeType;

        /// <summary>
        /// Gets and sets the property DeleteOnTermination. 
        /// <para>
        /// Indicates whether the EBS volume is deleted on instance termination. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/terminating-instances.html#preserving-volumes-on-termination">Preserving
        /// Amazon EBS volumes on instance termination</a> in the Amazon Elastic Compute Cloud
        /// User Guide.
        /// </para>
        /// </summary>
        public bool DeleteOnTermination
        {
            get { return this._deleteOnTermination.GetValueOrDefault(); }
            set { this._deleteOnTermination = value; }
        }

        // Check to see if DeleteOnTermination property is set
        internal bool IsSetDeleteOnTermination()
        {
            return this._deleteOnTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the encryption state of an EBS volume is changed while being restored
        /// from a backing snapshot. The effect of setting the encryption state to <code>true</code>
        /// depends on the volume origin (new or from a snapshot), starting encryption state,
        /// ownership, and whether encryption by default is enabled. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#encryption-parameters">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// In no case can you remove encryption from an encrypted volume.
        /// </para>
        ///  
        /// <para>
        /// Encrypted volumes can only be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html#EBSEncryption_supported_instances">Supported
        /// instance types</a>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is not returned by .
        /// </para>
        /// </summary>
        public bool Encrypted
        {
            get { return this._encrypted.GetValueOrDefault(); }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The number of I/O operations per second (IOPS) that the volume supports. For <code>io1</code>
        /// volumes, this represents the number of IOPS that are provisioned for the volume. For
        /// <code>gp2</code> volumes, this represents the baseline performance of the volume and
        /// the rate at which the volume accumulates I/O credits for bursting. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS volume types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Range is 100-16,000 IOPS for <code>gp2</code> volumes and 100 to 64,000IOPS
        /// for <code>io1</code> volumes in most Regions. Maximum <code>io1</code> IOPS of 64,000
        /// is guaranteed only on <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#ec2-nitro-instances">Nitro-based
        /// instances</a>. Other instance families guarantee performance up to 32,000 IOPS. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumeTypes.html">Amazon
        /// EBS Volume Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Condition: This parameter is required for requests to create <code>io1</code> volumes;
        /// it is not used in requests to create <code>gp2</code>, <code>st1</code>, <code>sc1</code>,
        /// or <code>standard</code> volumes.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// Identifier (key ID, key alias, ID ARN, or alias ARN) for a customer managed CMK under
        /// which the EBS volume is encrypted.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only supported on <code>BlockDeviceMapping</code> objects called
        /// by <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>,
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotFleet.html">RequestSpotFleet</a>,
        /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RequestSpotInstances.html">RequestSpotInstances</a>.
        /// </para>
        /// </summary>
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        ///  
        /// <para>
        /// Default: If you're creating the volume from a snapshot and don't specify a volume
        /// size, the default is the snapshot size.
        /// </para>
        ///  
        /// <para>
        /// Constraints: 1-16384 for General Purpose SSD (<code>gp2</code>), 4-16384 for Provisioned
        /// IOPS SSD (<code>io1</code>), 500-16384 for Throughput Optimized HDD (<code>st1</code>),
        /// 500-16384 for Cold HDD (<code>sc1</code>), and 1-1024 for Magnetic (<code>standard</code>)
        /// volumes. If you specify a snapshot, the volume size must be equal to or larger than
        /// the snapshot size.
        /// </para>
        /// </summary>
        public int VolumeSize
        {
            get { return this._volumeSize.GetValueOrDefault(); }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeType. 
        /// <para>
        /// The volume type. If you set the type to <code>io1</code>, you must also specify the
        /// <b>Iops</b> parameter. If you set the type to <code>gp2</code>, <code>st1</code>,
        /// <code>sc1</code>, or <code>standard</code>, you must omit the <b>Iops</b> parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>gp2</code> 
        /// </para>
        /// </summary>
        public VolumeType VolumeType
        {
            get { return this._volumeType; }
            set { this._volumeType = value; }
        }

        // Check to see if VolumeType property is set
        internal bool IsSetVolumeType()
        {
            return this._volumeType != null;
        }

    }
}