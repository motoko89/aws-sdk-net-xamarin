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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KeyManagementService.Model
{
    /// <summary>
    /// Container for the parameters to the Verify operation.
    /// Verifies a digital signature that was generated by the <a>Sign</a> operation. 
    /// 
    ///   
    /// <para>
    /// Verification confirms that an authorized user signed the message with the specified
    /// KMS key and signing algorithm, and the message hasn't changed since it was signed.
    /// If the signature is verified, the value of the <code>SignatureValid</code> field in
    /// the response is <code>True</code>. If the signature verification fails, the <code>Verify</code>
    /// operation fails with an <code>KMSInvalidSignatureException</code> exception.
    /// </para>
    ///  
    /// <para>
    /// A digital signature is generated by using the private key in an asymmetric KMS key.
    /// The signature is verified by using the public key in the same asymmetric KMS key.
    /// For information about symmetric and asymmetric KMS keys, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
    /// Symmetric and Asymmetric KMS keys</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To verify a digital signature, you can use the <code>Verify</code> operation. Specify
    /// the same asymmetric KMS key, message, and signing algorithm that were used to produce
    /// the signature.
    /// </para>
    ///  
    /// <para>
    /// You can also verify the digital signature by using the public key of the KMS key outside
    /// of KMS. Use the <a>GetPublicKey</a> operation to download the public key in the asymmetric
    /// KMS key and then use the public key to verify the signature outside of KMS. The advantage
    /// of using the <code>Verify</code> operation is that it is performed within KMS. As
    /// a result, it's easy to call, the operation is performed within the FIPS boundary,
    /// it is logged in CloudTrail, and you can use key policy and IAM policy to determine
    /// who is authorized to use the KMS key to verify signatures.
    /// </para>
    ///  
    /// <para>
    /// The KMS key that you use for this operation must be in a compatible key state. For
    /// details, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">Key
    /// state: Effect on your KMS key</a> in the <i>Key Management Service Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Cross-account use</b>: Yes. To perform this operation with a KMS key in a different
    /// Amazon Web Services account, specify the key ARN or alias ARN in the value of the
    /// <code>KeyId</code> parameter. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Required permissions</b>: <a href="https://docs.aws.amazon.com/kms/latest/developerguide/kms-api-permissions-reference.html">kms:Verify</a>
    /// (key policy)
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b>: <a>Sign</a> 
    /// </para>
    /// </summary>
    public partial class VerifyRequest : AmazonKeyManagementServiceRequest
    {
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MemoryStream _message;
        private MessageType _messageType;
        private MemoryStream _signature;
        private SigningAlgorithmSpec _signingAlgorithm;

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// Use a grant token when your permission to call this operation comes from a new grant
        /// that has not yet achieved <i>eventual consistency</i>. For more information, see <a
        /// href="https://docs.aws.amazon.com/kms/latest/developerguide/grants.html#grant_token">Grant
        /// token</a> and <a href="https://docs.aws.amazon.com/kms/latest/developerguide/grant-manage.html#using-grant-token">Using
        /// a grant token</a> in the <i>Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> GrantTokens
        {
            get { return this._grantTokens; }
            set { this._grantTokens = value; }
        }

        // Check to see if GrantTokens property is set
        internal bool IsSetGrantTokens()
        {
            return this._grantTokens != null && this._grantTokens.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KeyId. 
        /// <para>
        /// Identifies the asymmetric KMS key that will be used to verify the signature. This
        /// must be the same KMS key that was used to generate the signature. If you specify a
        /// different KMS key, the signature verification fails.
        /// </para>
        ///  
        /// <para>
        /// To specify a KMS key, use its key ID, key ARN, alias name, or alias ARN. When using
        /// an alias name, prefix it with <code>"alias/"</code>. To specify a KMS key in a different
        /// Amazon Web Services account, you must use the key ARN or alias ARN.
        /// </para>
        ///  
        /// <para>
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Key ID: <code>1234abcd-12ab-34cd-56ef-1234567890ab</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Key ARN: <code>arn:aws:kms:us-east-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <code>alias/ExampleAlias</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias ARN: <code>arn:aws:kms:us-east-2:111122223333:alias/ExampleAlias</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To get the key ID and key ARN for a KMS key, use <a>ListKeys</a> or <a>DescribeKey</a>.
        /// To get the alias name and alias ARN, use <a>ListAliases</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string KeyId
        {
            get { return this._keyId; }
            set { this._keyId = value; }
        }

        // Check to see if KeyId property is set
        internal bool IsSetKeyId()
        {
            return this._keyId != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Specifies the message that was signed. You can submit a raw message of up to 4096
        /// bytes, or a hash digest of the message. If you submit a digest, use the <code>MessageType</code>
        /// parameter with a value of <code>DIGEST</code>.
        /// </para>
        ///  
        /// <para>
        /// If the message specified here is different from the message that was signed, the signature
        /// verification fails. A message and its hash digest are considered to be the same message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public MemoryStream Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property MessageType. 
        /// <para>
        /// Tells KMS whether the value of the <code>Message</code> parameter is a message or
        /// message digest. The default value, RAW, indicates a message. To indicate a message
        /// digest, enter <code>DIGEST</code>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Use the <code>DIGEST</code> value only when the value of the <code>Message</code>
        /// parameter is a message digest. If you use the <code>DIGEST</code> value with a raw
        /// message, the security of the verification operation can be compromised.
        /// </para>
        ///  </important>
        /// </summary>
        public MessageType MessageType
        {
            get { return this._messageType; }
            set { this._messageType = value; }
        }

        // Check to see if MessageType property is set
        internal bool IsSetMessageType()
        {
            return this._messageType != null;
        }

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// The signature that the <code>Sign</code> operation generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=6144)]
        public MemoryStream Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm that was used to sign the message. If you submit a different
        /// algorithm, the signature verification fails.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SigningAlgorithmSpec SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

    }
}