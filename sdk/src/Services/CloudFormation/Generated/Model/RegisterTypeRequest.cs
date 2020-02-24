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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterType operation.
    /// Registers a type with the CloudFormation service. Registering a type makes it available
    /// for use in CloudFormation templates in your AWS account, and includes:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Validating the resource schema
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Determining which handlers have been specified for the resource
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Making the resource type available for use in your account
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information on how to develop types and ready them for registeration, see
    /// <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-types.html">Creating
    /// Resource Providers</a> in the <i>CloudFormation CLI User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// Once you have initiated a registration request using <code> <a>RegisterType</a> </code>,
    /// you can use <code> <a>DescribeTypeRegistration</a> </code> to monitor the progress
    /// of the registration request.
    /// </para>
    /// </summary>
    public partial class RegisterTypeRequest : AmazonCloudFormationRequest
    {
        private string _clientRequestToken;
        private string _executionRoleArn;
        private LoggingConfig _loggingConfig;
        private string _schemaHandlerPackage;
        private RegistryType _type;
        private string _typeName;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique identifier that acts as an idempotency key for this registration request.
        /// Specifying a client request token prevents CloudFormation from generating more than
        /// one version of a type from the same registeration request, even if the request is
        /// submitted multiple times. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM execution role to use to register the type.
        /// If your resource type calls AWS APIs in any of its handlers, you must create an <i>
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles.html">IAM execution
        /// role</a> </i> that includes the necessary permissions to call those AWS APIs, and
        /// provision that execution role in your account. CloudFormation then assumes that execution
        /// role to provide your resource type with the appropriate credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// Specifies logging configuration information for a type.
        /// </para>
        /// </summary>
        public LoggingConfig LoggingConfig
        {
            get { return this._loggingConfig; }
            set { this._loggingConfig = value; }
        }

        // Check to see if LoggingConfig property is set
        internal bool IsSetLoggingConfig()
        {
            return this._loggingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SchemaHandlerPackage. 
        /// <para>
        /// A url to the S3 bucket containing the schema handler package that contains the schema,
        /// event handlers, and associated files for the type you want to register.
        /// </para>
        ///  
        /// <para>
        /// For information on generating a schema handler package for the type you want to register,
        /// see <a href="https://docs.aws.amazon.com/cloudformation-cli/latest/userguide/resource-type-cli-submit.html">submit</a>
        /// in the <i>CloudFormation CLI User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// As part of registering a resource provider type, CloudFormation must be able to access
        /// the S3 bucket which contains the schema handler package for that resource provider.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/registry.html#registry-register-permissions">IAM
        /// Permissions for Registering a Resource Provider</a> in the <i>AWS CloudFormation User
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string SchemaHandlerPackage
        {
            get { return this._schemaHandlerPackage; }
            set { this._schemaHandlerPackage = value; }
        }

        // Check to see if SchemaHandlerPackage property is set
        internal bool IsSetSchemaHandlerPackage()
        {
            return this._schemaHandlerPackage != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The kind of type.
        /// </para>
        ///  
        /// <para>
        /// Currently, the only valid value is <code>RESOURCE</code>.
        /// </para>
        /// </summary>
        public RegistryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property TypeName. 
        /// <para>
        /// The name of the type being registered.
        /// </para>
        ///  
        /// <para>
        /// We recommend that type names adhere to the following pattern: <i>company_or_organization</i>::<i>service</i>::<i>type</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The following organization namespaces are reserved and cannot be used in your resource
        /// type names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>Alexa</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AMZN</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Amazon</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AWS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Custom</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Dev</code> 
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=196)]
        public string TypeName
        {
            get { return this._typeName; }
            set { this._typeName = value; }
        }

        // Check to see if TypeName property is set
        internal bool IsSetTypeName()
        {
            return this._typeName != null;
        }

    }
}