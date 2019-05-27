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
    /// Container for the parameters to the CreateAlias operation.
    /// Creates a display name for a customer managed customer master key (CMK). You can use
    /// an alias to identify a CMK in selected operations, such as <a>Encrypt</a> and <a>GenerateDataKey</a>.
    /// 
    /// 
    ///  
    /// <para>
    /// Each CMK can have multiple aliases, but each alias points to only one CMK. The alias
    /// name must be unique in the AWS account and region. To simplify code that runs in multiple
    /// regions, use the same alias name, but point it to a different CMK in each region.
    /// 
    /// </para>
    ///  
    /// <para>
    /// Because an alias is not a property of a CMK, you can delete and change the aliases
    /// of a CMK without affecting the CMK. Also, aliases do not appear in the response from
    /// the <a>DescribeKey</a> operation. To get the aliases of all CMKs, use the <a>ListAliases</a>
    /// operation.
    /// </para>
    ///  
    /// <para>
    /// The alias name must begin with <code>alias/</code> followed by a name, such as <code>alias/ExampleAlias</code>.
    /// It can contain only alphanumeric characters, forward slashes (/), underscores (_),
    /// and dashes (-). The alias name cannot begin with <code>alias/aws/</code>. The <code>alias/aws/</code>
    /// prefix is reserved for <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">AWS
    /// managed CMKs</a>. 
    /// </para>
    ///  
    /// <para>
    /// The alias and the CMK it is mapped to must be in the same AWS account and the same
    /// region. You cannot perform this operation on an alias in a different AWS account.
    /// </para>
    ///  
    /// <para>
    /// To map an existing alias to a different CMK, call <a>UpdateAlias</a>.
    /// </para>
    ///  
    /// <para>
    /// The result of this operation varies with the key state of the CMK. For details, see
    /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
    /// Key State Affects Use of a Customer Master Key</a> in the <i>AWS Key Management Service
    /// Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateAliasRequest : AmazonKeyManagementServiceRequest
    {
        private string _aliasName;
        private string _targetKeyId;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// Specifies the alias name. This value must begin with <code>alias/</code> followed
        /// by a name, such as <code>alias/ExampleAlias</code>. The alias name cannot begin with
        /// <code>alias/aws/</code>. The <code>alias/aws/</code> prefix is reserved for AWS managed
        /// CMKs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AliasName
        {
            get { return this._aliasName; }
            set { this._aliasName = value; }
        }

        // Check to see if AliasName property is set
        internal bool IsSetAliasName()
        {
            return this._aliasName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetKeyId. 
        /// <para>
        /// Identifies the CMK to which the alias refers. Specify the key ID or the Amazon Resource
        /// Name (ARN) of the CMK. You cannot specify another alias. For help finding the key
        /// ID and ARN, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/viewing-keys.html#find-cmk-id-arn">Finding
        /// the Key ID and ARN</a> in the <i>AWS Key Management Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TargetKeyId
        {
            get { return this._targetKeyId; }
            set { this._targetKeyId = value; }
        }

        // Check to see if TargetKeyId property is set
        internal bool IsSetTargetKeyId()
        {
            return this._targetKeyId != null;
        }

    }
}