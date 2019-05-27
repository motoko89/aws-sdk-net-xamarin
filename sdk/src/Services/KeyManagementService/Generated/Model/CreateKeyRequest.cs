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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKey operation.
    /// Creates a customer managed <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#master_keys">customer
    /// master key</a> (CMK) in your AWS account.
    /// 
    ///  
    /// <para>
    /// You can use a CMK to encrypt small amounts of data (up to 4096 bytes) directly. But
    /// CMKs are more commonly used to encrypt the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data
    /// keys</a> that are used to encrypt data.
    /// </para>
    ///  
    /// <para>
    /// To create a CMK for imported key material, use the <code>Origin</code> parameter with
    /// a value of <code>EXTERNAL</code>.
    /// </para>
    ///  
    /// <para>
    /// To create a CMK in a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
    /// key store</a>, use the <code>CustomKeyStoreId</code> parameter to specify the custom
    /// key store. You must also use the <code>Origin</code> parameter with a value of <code>AWS_CLOUDHSM</code>.
    /// The AWS CloudHSM cluster that is associated with the custom key store must have at
    /// least two active HSMs in different Availability Zones in the AWS Region.
    /// </para>
    ///  
    /// <para>
    /// You cannot use this operation to create a CMK in a different AWS account.
    /// </para>
    /// </summary>
    public partial class CreateKeyRequest : AmazonKeyManagementServiceRequest
    {
        private bool? _bypassPolicyLockoutSafetyCheck;
        private string _customKeyStoreId;
        private string _description;
        private KeyUsageType _keyUsage;
        private OriginType _origin;
        private string _policy;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property BypassPolicyLockoutSafetyCheck. 
        /// <para>
        /// A flag to indicate whether to bypass the key policy lockout safety check.
        /// </para>
        ///  <important> 
        /// <para>
        /// Setting this value to true increases the risk that the CMK becomes unmanageable. Do
        /// not set this value to true indiscriminately.
        /// </para>
        ///  
        /// <para>
        /// For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section in the <i> <i>AWS Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Use this parameter only when you include a policy in the request and you intend to
        /// prevent the principal that is making the request from making a subsequent <a>PutKeyPolicy</a>
        /// request on the CMK.
        /// </para>
        ///  
        /// <para>
        /// The default value is false.
        /// </para>
        /// </summary>
        public bool BypassPolicyLockoutSafetyCheck
        {
            get { return this._bypassPolicyLockoutSafetyCheck.GetValueOrDefault(); }
            set { this._bypassPolicyLockoutSafetyCheck = value; }
        }

        // Check to see if BypassPolicyLockoutSafetyCheck property is set
        internal bool IsSetBypassPolicyLockoutSafetyCheck()
        {
            return this._bypassPolicyLockoutSafetyCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomKeyStoreId. 
        /// <para>
        /// Creates the CMK in the specified <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> and the key material in its associated AWS CloudHSM cluster. To create
        /// a CMK in a custom key store, you must also specify the <code>Origin</code> parameter
        /// with a value of <code>AWS_CLOUDHSM</code>. The AWS CloudHSM cluster that is associated
        /// with the custom key store must have at least two active HSMs, each in a different
        /// Availability Zone in the Region.
        /// </para>
        ///  
        /// <para>
        /// To find the ID of a custom key store, use the <a>DescribeCustomKeyStores</a> operation.
        /// </para>
        ///  
        /// <para>
        /// The response includes the custom key store ID and the ID of the AWS CloudHSM cluster.
        /// </para>
        ///  
        /// <para>
        /// This operation is part of the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">Custom
        /// Key Store feature</a> feature in AWS KMS, which combines the convenience and extensive
        /// integration of AWS KMS with the isolation and control of a single-tenant key store.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string CustomKeyStoreId
        {
            get { return this._customKeyStoreId; }
            set { this._customKeyStoreId = value; }
        }

        // Check to see if CustomKeyStoreId property is set
        internal bool IsSetCustomKeyStoreId()
        {
            return this._customKeyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the CMK.
        /// </para>
        ///  
        /// <para>
        /// Use a description that helps you decide whether the CMK is appropriate for a task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The cryptographic operations for which you can use the CMK. The only valid value is
        /// <code>ENCRYPT_DECRYPT</code>, which means you can use the CMK to encrypt and decrypt
        /// data.
        /// </para>
        /// </summary>
        public KeyUsageType KeyUsage
        {
            get { return this._keyUsage; }
            set { this._keyUsage = value; }
        }

        // Check to see if KeyUsage property is set
        internal bool IsSetKeyUsage()
        {
            return this._keyUsage != null;
        }

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// The source of the key material for the CMK. You cannot change the origin after you
        /// create the CMK.
        /// </para>
        ///  
        /// <para>
        /// The default is <code>AWS_KMS</code>, which means AWS KMS creates the key material
        /// in its own key store.
        /// </para>
        ///  
        /// <para>
        /// When the parameter value is <code>EXTERNAL</code>, AWS KMS creates a CMK without key
        /// material so that you can import key material from your existing key management infrastructure.
        /// For more information about importing key material into AWS KMS, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/importing-keys.html">Importing
        /// Key Material</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When the parameter value is <code>AWS_CLOUDHSM</code>, AWS KMS creates the CMK in
        /// an AWS KMS <a href="https://docs.aws.amazon.com/kms/latest/developerguide/custom-key-store-overview.html">custom
        /// key store</a> and creates its key material in the associated AWS CloudHSM cluster.
        /// You must also use the <code>CustomKeyStoreId</code> parameter to identify the custom
        /// key store.
        /// </para>
        /// </summary>
        public OriginType Origin
        {
            get { return this._origin; }
            set { this._origin = value; }
        }

        // Check to see if Origin property is set
        internal bool IsSetOrigin()
        {
            return this._origin != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The key policy to attach to the CMK.
        /// </para>
        ///  
        /// <para>
        /// If you provide a key policy, it must meet the following criteria:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't set <code>BypassPolicyLockoutSafetyCheck</code> to true, the key policy
        /// must allow the principal that is making the <code>CreateKey</code> request to make
        /// a subsequent <a>PutKeyPolicy</a> request on the CMK. This reduces the risk that the
        /// CMK becomes unmanageable. For more information, refer to the scenario in the <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default-allow-root-enable-iam">Default
        /// Key Policy</a> section of the <i> <i>AWS Key Management Service Developer Guide</i>
        /// </i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each statement in the key policy must contain one or more principals. The principals
        /// in the key policy must exist and be visible to AWS KMS. When you create a new AWS
        /// principal (for example, an IAM user or role), you might need to enforce a delay before
        /// including the new principal in a key policy because the new principal might not be
        /// immediately visible to AWS KMS. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/troubleshoot_general.html#troubleshoot_general_eventual-consistency">Changes
        /// that I make are not always immediately visible</a> in the <i>AWS Identity and Access
        /// Management User Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you do not provide a key policy, AWS KMS attaches a default key policy to the CMK.
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-policies.html#key-policy-default">Default
        /// Key Policy</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The key policy size limit is 32 kilobytes (32768 bytes).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=131072)]
        public string Policy
        {
            get { return this._policy; }
            set { this._policy = value; }
        }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this._policy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags. Each tag consists of a tag key and a tag value. Tag keys and tag
        /// values are both required, but tag values can be empty (null) strings.
        /// </para>
        ///  
        /// <para>
        /// Use this parameter to tag the CMK when it is created. Alternately, you can omit this
        /// parameter and instead tag the CMK after it is created using <a>TagResource</a>.
        /// </para>
        /// </summary>
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

    }
}