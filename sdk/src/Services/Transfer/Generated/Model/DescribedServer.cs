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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Transfer.Model
{
    /// <summary>
    /// Describes the properties of the server that was specified. Information returned includes
    /// the following: the server Amazon Resource Name (ARN), the authentication configuration
    /// and type, the logging role, the server ID and state, and assigned tags or metadata.
    /// </summary>
    public partial class DescribedServer
    {
        private string _arn;
        private EndpointDetails _endpointDetails;
        private EndpointType _endpointType;
        private string _hostKeyFingerprint;
        private IdentityProviderDetails _identityProviderDetails;
        private IdentityProviderType _identityProviderType;
        private string _loggingRole;
        private string _serverId;
        private State _state;
        private List<Tag> _tags = new List<Tag>();
        private int? _userCount;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// Specifies the unique Amazon Resource Name (ARN) for the server to be described.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1600)]
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
        /// Gets and sets the property EndpointDetails. 
        /// <para>
        /// The virtual private cloud (VPC) endpoint settings that you configured for your SFTP
        /// server.
        /// </para>
        /// </summary>
        public EndpointDetails EndpointDetails
        {
            get { return this._endpointDetails; }
            set { this._endpointDetails = value; }
        }

        // Check to see if EndpointDetails property is set
        internal bool IsSetEndpointDetails()
        {
            return this._endpointDetails != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointType. 
        /// <para>
        /// The type of endpoint that your SFTP server is connected to. If your SFTP server is
        /// connected to a VPC endpoint, your server isn't accessible over the public internet.
        /// </para>
        /// </summary>
        public EndpointType EndpointType
        {
            get { return this._endpointType; }
            set { this._endpointType = value; }
        }

        // Check to see if EndpointType property is set
        internal bool IsSetEndpointType()
        {
            return this._endpointType != null;
        }

        /// <summary>
        /// Gets and sets the property HostKeyFingerprint. 
        /// <para>
        /// This value contains the message-digest algorithm (MD5) hash of the server's host key.
        /// This value is equivalent to the output of the <code>ssh-keygen -l -E md5 -f my-new-server-key</code>
        /// command.
        /// </para>
        /// </summary>
        public string HostKeyFingerprint
        {
            get { return this._hostKeyFingerprint; }
            set { this._hostKeyFingerprint = value; }
        }

        // Check to see if HostKeyFingerprint property is set
        internal bool IsSetHostKeyFingerprint()
        {
            return this._hostKeyFingerprint != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderDetails. 
        /// <para>
        /// Specifies information to call a customer-supplied authentication API. This field is
        /// not populated when the <code>IdentityProviderType</code> of the server is <code>SERVICE_MANAGED</code>&gt;.
        /// </para>
        /// </summary>
        public IdentityProviderDetails IdentityProviderDetails
        {
            get { return this._identityProviderDetails; }
            set { this._identityProviderDetails = value; }
        }

        // Check to see if IdentityProviderDetails property is set
        internal bool IsSetIdentityProviderDetails()
        {
            return this._identityProviderDetails != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderType. 
        /// <para>
        /// This property defines the mode of authentication method enabled for this service.
        /// A value of <code>SERVICE_MANAGED</code> means that you are using this server to store
        /// and access SFTP user credentials within the service. A value of <code>API_GATEWAY</code>
        /// indicates that you have integrated an API Gateway endpoint that will be invoked for
        /// authenticating your user into the service.
        /// </para>
        /// </summary>
        public IdentityProviderType IdentityProviderType
        {
            get { return this._identityProviderType; }
            set { this._identityProviderType = value; }
        }

        // Check to see if IdentityProviderType property is set
        internal bool IsSetIdentityProviderType()
        {
            return this._identityProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingRole. 
        /// <para>
        /// This property is an AWS Identity and Access Management (IAM) entity that allows the
        /// server to turn on Amazon CloudWatch logging for Amazon S3 events. When set, user activity
        /// can be viewed in your CloudWatch logs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string LoggingRole
        {
            get { return this._loggingRole; }
            set { this._loggingRole = value; }
        }

        // Check to see if LoggingRole property is set
        internal bool IsSetLoggingRole()
        {
            return this._loggingRole != null;
        }

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        /// This property is a unique system-assigned identifier for the SFTP server that you
        /// instantiate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=19, Max=19)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The condition of the SFTP server for the server that was described. A value of <code>ONLINE</code>
        /// indicates that the server can accept jobs and transfer files. A <code>State</code>
        /// value of <code>OFFLINE</code> means that the server cannot perform file transfer operations.
        /// </para>
        ///  
        /// <para>
        /// The states of <code>STARTING</code> and <code>STOPPING</code> indicate that the server
        /// is in an intermediate state, either not fully able to respond, or not fully offline.
        /// The values of <code>START_FAILED</code> or <code>STOP_FAILED</code> can indicate an
        /// error condition.
        /// </para>
        /// </summary>
        public State State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// This property contains the key-value pairs that you can use to search for and group
        /// servers that were assigned to the server that was described.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserCount. 
        /// <para>
        /// The number of users that are assigned to the SFTP server you specified with the <code>ServerId</code>.
        /// </para>
        /// </summary>
        public int UserCount
        {
            get { return this._userCount.GetValueOrDefault(); }
            set { this._userCount = value; }
        }

        // Check to see if UserCount property is set
        internal bool IsSetUserCount()
        {
            return this._userCount.HasValue; 
        }

    }
}