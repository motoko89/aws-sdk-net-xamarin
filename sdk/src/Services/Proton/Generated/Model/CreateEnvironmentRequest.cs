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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Proton.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEnvironment operation.
    /// Deploy a new environment. An Proton environment is created from an environment template
    /// that defines infrastructure and resources that can be shared across services.
    /// 
    ///  <p class="title"> <b>You can provision environments using the following methods:</b>
    /// 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Amazon Web Services-managed provisioning: Proton makes direct calls to provision your
    /// resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Self-managed provisioning: Proton makes pull requests on your repository to provide
    /// compiled infrastructure as code (IaC) files that your IaC engine uses to provision
    /// resources.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-environments.html">Environments</a>
    /// and <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-works-prov-methods.html">Provisioning
    /// methods</a> in the <i>Proton Administrator Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateEnvironmentRequest : AmazonProtonRequest
    {
        private string _description;
        private string _environmentAccountConnectionId;
        private string _name;
        private string _protonServiceRoleArn;
        private RepositoryBranchInput _provisioningRepository;
        private string _spec;
        private List<Tag> _tags = new List<Tag>();
        private string _templateMajorVersion;
        private string _templateMinorVersion;
        private string _templateName;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the environment that's being created and deployed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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
        /// Gets and sets the property EnvironmentAccountConnectionId. 
        /// <para>
        /// The ID of the environment account connection that you provide if you're provisioning
        /// your environment infrastructure resources to an environment account. For more information,
        /// see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton Administrator guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To use Amazon Web Services-managed provisioning for the environment, specify either
        /// the <code>environmentAccountConnectionId</code> or <code>protonServiceRoleArn</code>
        /// parameter and omit the <code>provisioningRepository</code> parameter.
        /// </para>
        /// </summary>
        public string EnvironmentAccountConnectionId
        {
            get { return this._environmentAccountConnectionId; }
            set { this._environmentAccountConnectionId = value; }
        }

        // Check to see if EnvironmentAccountConnectionId property is set
        internal bool IsSetEnvironmentAccountConnectionId()
        {
            return this._environmentAccountConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property ProtonServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Proton service role that allows Proton to make
        /// calls to other services on your behalf.
        /// </para>
        ///  
        /// <para>
        /// To use Amazon Web Services-managed provisioning for the environment, specify either
        /// the <code>environmentAccountConnectionId</code> or <code>protonServiceRoleArn</code>
        /// parameter and omit the <code>provisioningRepository</code> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string ProtonServiceRoleArn
        {
            get { return this._protonServiceRoleArn; }
            set { this._protonServiceRoleArn = value; }
        }

        // Check to see if ProtonServiceRoleArn property is set
        internal bool IsSetProtonServiceRoleArn()
        {
            return this._protonServiceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisioningRepository. 
        /// <para>
        /// The infrastructure repository that you use to host your rendered infrastructure templates
        /// for self-managed provisioning.
        /// </para>
        ///  
        /// <para>
        /// To use self-managed provisioning for the environment, specify this parameter and omit
        /// the <code>environmentAccountConnectionId</code> and <code>protonServiceRoleArn</code>
        /// parameters.
        /// </para>
        /// </summary>
        public RepositoryBranchInput ProvisioningRepository
        {
            get { return this._provisioningRepository; }
            set { this._provisioningRepository = value; }
        }

        // Check to see if ProvisioningRepository property is set
        internal bool IsSetProvisioningRepository()
        {
            return this._provisioningRepository != null;
        }

        /// <summary>
        /// Gets and sets the property Spec. 
        /// <para>
        /// A YAML formatted string that provides inputs as defined in the environment template
        /// bundle schema file. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-environments.html">Environments</a>
        /// in the <i>Proton Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=51200)]
        public string Spec
        {
            get { return this._spec; }
            set { this._spec = value; }
        }

        // Check to see if Spec property is set
        internal bool IsSetSpec()
        {
            return this._spec != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// An optional list of metadata items that you can associate with the Proton environment.
        /// A tag is a key-value pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <i>Proton resources and tagging</i> in the <a href="https://docs.aws.amazon.com/proton/latest/adminguide/resources.html">Proton
        /// Administrator Guide</a> or <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// User Guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
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
        /// Gets and sets the property TemplateMajorVersion. 
        /// <para>
        /// The major version of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public string TemplateMajorVersion
        {
            get { return this._templateMajorVersion; }
            set { this._templateMajorVersion = value; }
        }

        // Check to see if TemplateMajorVersion property is set
        internal bool IsSetTemplateMajorVersion()
        {
            return this._templateMajorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateMinorVersion. 
        /// <para>
        /// The minor version of the environment template.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public string TemplateMinorVersion
        {
            get { return this._templateMinorVersion; }
            set { this._templateMinorVersion = value; }
        }

        // Check to see if TemplateMinorVersion property is set
        internal bool IsSetTemplateMinorVersion()
        {
            return this._templateMinorVersion != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateName. 
        /// <para>
        /// The name of the environment template. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/adminguide/ag-templates.html">Environment
        /// Templates</a> in the <i>Proton Administrator Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string TemplateName
        {
            get { return this._templateName; }
            set { this._templateName = value; }
        }

        // Check to see if TemplateName property is set
        internal bool IsSetTemplateName()
        {
            return this._templateName != null;
        }

    }
}