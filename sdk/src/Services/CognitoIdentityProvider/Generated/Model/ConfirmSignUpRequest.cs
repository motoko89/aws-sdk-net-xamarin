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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the ConfirmSignUp operation.
    /// Confirms registration of a user and handles the existing alias from a previous user.
    /// </summary>
    public partial class ConfirmSignUpRequest : AmazonCognitoIdentityProviderRequest
    {
        private AnalyticsMetadataType _analyticsMetadata;
        private string _clientId;
        private string _confirmationCode;
        private bool? _forceAliasCreation;
        private string _secretHash;
        private UserContextDataType _userContextData;
        private string _username;

        /// <summary>
        /// Gets and sets the property AnalyticsMetadata. 
        /// <para>
        /// The Amazon Pinpoint analytics metadata for collecting metrics for <code>ConfirmSignUp</code>
        /// calls.
        /// </para>
        /// </summary>
        public AnalyticsMetadataType AnalyticsMetadata
        {
            get { return this._analyticsMetadata; }
            set { this._analyticsMetadata = value; }
        }

        // Check to see if AnalyticsMetadata property is set
        internal bool IsSetAnalyticsMetadata()
        {
            return this._analyticsMetadata != null;
        }

        /// <summary>
        /// Gets and sets the property ClientId. 
        /// <para>
        /// The ID of the app client associated with the user pool.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ClientId
        {
            get { return this._clientId; }
            set { this._clientId = value; }
        }

        // Check to see if ClientId property is set
        internal bool IsSetClientId()
        {
            return this._clientId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmationCode. 
        /// <para>
        /// The confirmation code sent by a user's request to confirm registration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string ConfirmationCode
        {
            get { return this._confirmationCode; }
            set { this._confirmationCode = value; }
        }

        // Check to see if ConfirmationCode property is set
        internal bool IsSetConfirmationCode()
        {
            return this._confirmationCode != null;
        }

        /// <summary>
        /// Gets and sets the property ForceAliasCreation. 
        /// <para>
        /// Boolean to be specified to force user confirmation irrespective of existing alias.
        /// By default set to <code>False</code>. If this parameter is set to <code>True</code>
        /// and the phone number/email used for sign up confirmation already exists as an alias
        /// with a different user, the API call will migrate the alias from the previous user
        /// to the newly created user being confirmed. If set to <code>False</code>, the API will
        /// throw an <b>AliasExistsException</b> error.
        /// </para>
        /// </summary>
        public bool ForceAliasCreation
        {
            get { return this._forceAliasCreation.GetValueOrDefault(); }
            set { this._forceAliasCreation = value; }
        }

        // Check to see if ForceAliasCreation property is set
        internal bool IsSetForceAliasCreation()
        {
            return this._forceAliasCreation.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SecretHash. 
        /// <para>
        /// A keyed-hash message authentication code (HMAC) calculated using the secret key of
        /// a user pool client and username plus the client ID in the message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string SecretHash
        {
            get { return this._secretHash; }
            set { this._secretHash = value; }
        }

        // Check to see if SecretHash property is set
        internal bool IsSetSecretHash()
        {
            return this._secretHash != null;
        }

        /// <summary>
        /// Gets and sets the property UserContextData. 
        /// <para>
        /// Contextual data such as the user's device fingerprint, IP address, or location used
        /// for evaluating the risk of an unexpected event by Amazon Cognito advanced security.
        /// </para>
        /// </summary>
        public UserContextDataType UserContextData
        {
            get { return this._userContextData; }
            set { this._userContextData = value; }
        }

        // Check to see if UserContextData property is set
        internal bool IsSetUserContextData()
        {
            return this._userContextData != null;
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// The user name of the user whose registration you wish to confirm.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}