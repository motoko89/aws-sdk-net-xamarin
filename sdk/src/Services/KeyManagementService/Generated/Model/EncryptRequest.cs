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
    /// Container for the parameters to the Encrypt operation.
    /// Encrypts plaintext into ciphertext by using a customer master key (CMK). The <code>Encrypt</code>
    /// operation has two primary use cases:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// You can encrypt up to 4 kilobytes (4096 bytes) of arbitrary data such as an RSA key,
    /// a database password, or other sensitive information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can use the <code>Encrypt</code> operation to move encrypted data from one AWS
    /// region to another. In the first region, generate a data key and use the plaintext
    /// key to encrypt the data. Then, in the new region, call the <code>Encrypt</code> method
    /// on same plaintext data key. Now, you can safely move the encrypted data and encrypted
    /// data key to the new region, and decrypt in the new region when necessary.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You don't need use this operation to encrypt a data key within a region. The <a>GenerateDataKey</a>
    /// and <a>GenerateDataKeyWithoutPlaintext</a> operations return an encrypted data key.
    /// </para>
    ///  
    /// <para>
    /// Also, you don't need to use this operation to encrypt data in your application. You
    /// can use the plaintext and encrypted data keys that the <code>GenerateDataKey</code>
    /// operation returns.
    /// </para>
    ///  
    /// <para>
    /// The result of this operation varies with the key state of the CMK. For details, see
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To perform this operation on a CMK in a different AWS account, specify the key ARN
    /// or alias ARN in the value of the KeyId parameter.
    /// </para>
    /// </summary>
    public partial class EncryptRequest : AmazonKeyManagementServiceRequest
    {
        private Dictionary<string, string> _encryptionContext = new Dictionary<string, string>();
        private List<string> _grantTokens = new List<string>();
        private string _keyId;
        private MemoryStream _plaintext;

        /// <summary>
        /// Gets and sets the property EncryptionContext. 
        /// <para>
        /// Name-value pair that specifies the encryption context to be used for authenticated
        /// encryption. If used here, the same value must be supplied to the <code>Decrypt</code>
        /// API or decryption will fail. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#encrypt_context">Encryption
        /// Context</a>.
        /// </para>
        /// </summary>
        public Dictionary<string, string> EncryptionContext
        {
            get { return this._encryptionContext; }
            set { this._encryptionContext = value; }
        }

        // Check to see if EncryptionContext property is set
        internal bool IsSetEncryptionContext()
        {
            return this._encryptionContext != null && this._encryptionContext.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GrantTokens. 
        /// <para>
        /// A list of grant tokens.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#grant_token">Grant
        /// Tokens</a> in the <i>AWS Key Management Service Developer Guide</i>.
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
        /// A unique identifier for the customer master key (CMK).
        /// </para>
        ///  
        /// <para>
        /// To specify a CMK, use its key ID, Amazon Resource Name (ARN), alias name, or alias
        /// ARN. When using an alias name, prefix it with <code>"alias/"</code>. To specify a
        /// CMK in a different AWS account, you must use the key ARN or alias ARN.
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
        /// To get the key ID and key ARN for a CMK, use <a>ListKeys</a> or <a>DescribeKey</a>.
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
        /// Gets and sets the property Plaintext. 
        /// <para>
        /// Data to be encrypted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public MemoryStream Plaintext
        {
            get { return this._plaintext; }
            set { this._plaintext = value; }
        }

        // Check to see if Plaintext property is set
        internal bool IsSetPlaintext()
        {
            return this._plaintext != null;
        }

    }
}