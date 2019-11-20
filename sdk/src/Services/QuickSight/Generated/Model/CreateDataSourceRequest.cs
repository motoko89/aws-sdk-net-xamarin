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
    /// Container for the parameters to the CreateDataSource operation.
    /// Creates a data source.
    /// 
    ///  
    /// <para>
    /// The permissions resource is <code>arn:aws:quicksight:region:aws-account-id:datasource/data-source-id</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// CLI syntax:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws quicksight create-data-source \</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--aws-account-id=111122223333 \</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--data-source-id=unique-data-source-id \</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--name='My Data Source' \</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--type=POSTGRESQL \</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--data-source-parameters='{ "PostgreSqlParameters": {</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Host": "my-db-host.example.com",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Port": 1234,</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Database": "my-db" } }' \</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code>--credentials='{ "CredentialPair": {</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Username": "username",</code> 
    /// </para>
    ///  
    /// <para>
    ///  <code> "Password": "password" } }'</code> 
    /// </para>
    /// </summary>
    public partial class CreateDataSourceRequest : AmazonQuickSightRequest
    {
        private string _awsAccountId;
        private DataSourceCredentials _credentials;
        private string _dataSourceId;
        private DataSourceParameters _dataSourceParameters;
        private string _name;
        private List<ResourcePermission> _permissions = new List<ResourcePermission>();
        private SslProperties _sslProperties;
        private List<Tag> _tags = new List<Tag>();
        private DataSourceType _type;
        private VpcConnectionProperties _vpcConnectionProperties;

        /// <summary>
        /// Gets and sets the property AwsAccountId. 
        /// <para>
        /// The AWS account ID.
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
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials QuickSight uses to connect to your underlying source. Currently only
        /// username/password based credentials are supported.
        /// </para>
        /// </summary>
        public DataSourceCredentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceId. 
        /// <para>
        /// An ID for the data source. This is unique per AWS Region per AWS account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataSourceId
        {
            get { return this._dataSourceId; }
            set { this._dataSourceId = value; }
        }

        // Check to see if DataSourceId property is set
        internal bool IsSetDataSourceId()
        {
            return this._dataSourceId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSourceParameters. 
        /// <para>
        /// The parameters QuickSight uses to connect to your underlying source.
        /// </para>
        /// </summary>
        public DataSourceParameters DataSourceParameters
        {
            get { return this._dataSourceParameters; }
            set { this._dataSourceParameters = value; }
        }

        // Check to see if DataSourceParameters property is set
        internal bool IsSetDataSourceParameters()
        {
            return this._dataSourceParameters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A display name for the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property Permissions. 
        /// <para>
        /// A list of resource permissions on the data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public List<ResourcePermission> Permissions
        {
            get { return this._permissions; }
            set { this._permissions = value; }
        }

        // Check to see if Permissions property is set
        internal bool IsSetPermissions()
        {
            return this._permissions != null && this._permissions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SslProperties. 
        /// <para>
        /// SSL properties that apply when QuickSight connects to your underlying source.
        /// </para>
        /// </summary>
        public SslProperties SslProperties
        {
            get { return this._sslProperties; }
            set { this._sslProperties = value; }
        }

        // Check to see if SslProperties property is set
        internal bool IsSetSslProperties()
        {
            return this._sslProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Contains a map of the key-value pairs for the resource tag or tags assigned to the
        /// data source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the data source. Currently the supported types for this operation are:
        /// <code>ATHENA, AURORA, AURORA_POSTGRESQL, MARIADB, MYSQL, POSTGRESQL, PRESTO, REDSHIFT,
        /// S3, SNOWFLAKE, SPARK, SQLSERVER, TERADATA</code>. Use <code>ListDataSources</code>
        /// to return a list of all data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceType Type
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
        /// Gets and sets the property VpcConnectionProperties. 
        /// <para>
        /// You need to use this parameter only when you want QuickSight to use a VPC connection
        /// when connecting to your underlying source.
        /// </para>
        /// </summary>
        public VpcConnectionProperties VpcConnectionProperties
        {
            get { return this._vpcConnectionProperties; }
            set { this._vpcConnectionProperties = value; }
        }

        // Check to see if VpcConnectionProperties property is set
        internal bool IsSetVpcConnectionProperties()
        {
            return this._vpcConnectionProperties != null;
        }

    }
}