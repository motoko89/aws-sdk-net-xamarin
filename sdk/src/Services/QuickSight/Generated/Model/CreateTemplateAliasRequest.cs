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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Container for the parameters to the CreateTemplateAlias operation.
    /// Creates a template alias for a template.
    /// 
    ///  
    /// <para>
    /// CLI syntax:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight create-template-alias --aws-account-id 111122223333 --template-id
    /// 'reports_test_template' --alias-name PROD —version-number 1</code> 
    /// </para>
    /// </summary>
    public partial class CreateTemplateAliasRequest : AmazonQuickSightRequest
    {
        private string _aliasName;
        private string _awsAccountId;
        private string _templateId;
        private long? _templateVersionNumber;

        /// <summary>
        /// Gets and sets the property AliasName. 
        /// <para>
        /// The name you want to give the template's alias. Alias names can't begin with a <code>$</code>,
        /// which is reserved by QuickSight. Alias names that start with ‘$’ sign are QuickSight
        /// reserved naming and can't be deleted. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// AWS account ID that contains the template you are aliasing.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AwsAccountId
        {
            get { return this._awsAccountId; }
            set { this._awsAccountId = value; }
        }

        // Check to see if AwsAccountId property is set
        internal bool IsSetAwsAccountId()
        {
            return this._awsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateId. 
        /// <para>
        /// An ID for the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TemplateId
        {
            get { return this._templateId; }
            set { this._templateId = value; }
        }

        // Check to see if TemplateId property is set
        internal bool IsSetTemplateId()
        {
            return this._templateId != null;
        }

        /// <summary>
        /// Gets and sets the property TemplateVersionNumber. 
        /// <para>
        /// The version number of the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public long TemplateVersionNumber
        {
            get { return this._templateVersionNumber.GetValueOrDefault(); }
            set { this._templateVersionNumber = value; }
        }

        // Check to see if TemplateVersionNumber property is set
        internal bool IsSetTemplateVersionNumber()
        {
            return this._templateVersionNumber.HasValue; 
        }

    }
}