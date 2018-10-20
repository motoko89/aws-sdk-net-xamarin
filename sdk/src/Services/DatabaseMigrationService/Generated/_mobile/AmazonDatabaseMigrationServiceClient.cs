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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.DatabaseMigrationService.Model;
using Amazon.DatabaseMigrationService.Model.Internal.MarshallTransformations;
using Amazon.DatabaseMigrationService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DatabaseMigrationService
{
    /// <summary>
    /// Implementation for accessing DatabaseMigrationService
    ///
    /// AWS Database Migration Service 
    /// <para>
    /// AWS Database Migration Service (AWS DMS) can migrate your data to and from the most
    /// widely used commercial and open-source databases such as Oracle, PostgreSQL, Microsoft
    /// SQL Server, Amazon Redshift, MariaDB, Amazon Aurora, MySQL, and SAP Adaptive Server
    /// Enterprise (ASE). The service supports homogeneous migrations such as Oracle to Oracle,
    /// as well as heterogeneous migrations between different database platforms, such as
    /// Oracle to MySQL or SQL Server to PostgreSQL.
    /// </para>
    ///  
    /// <para>
    /// For more information about AWS DMS, see the AWS DMS user guide at <a href="http://docs.aws.amazon.com/dms/latest/userguide/Welcome.html">
    /// What Is AWS Database Migration Service? </a> 
    /// </para>
    /// </summary>
    public partial class AmazonDatabaseMigrationServiceClient : AmazonServiceClient, IAmazonDatabaseMigrationService
    {
        private static IServiceMetadata serviceMetadata = new AmazonDatabaseMigrationServiceMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDatabaseMigrationServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDatabaseMigrationServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(AmazonDatabaseMigrationServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Credentials and an
        /// AmazonDatabaseMigrationServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(AWSCredentials credentials, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDatabaseMigrationServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDatabaseMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDatabaseMigrationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDatabaseMigrationServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDatabaseMigrationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDatabaseMigrationServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDatabaseMigrationServiceClient Configuration Object</param>
        public AmazonDatabaseMigrationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDatabaseMigrationServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  AddTagsToResource

        internal virtual AddTagsToResourceResponse AddTagsToResource(AddTagsToResourceRequest request)
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return Invoke<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AddTagsToResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTagsToResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/AddTagsToResource">REST API Reference for AddTagsToResource Operation</seealso>
        public virtual Task<AddTagsToResourceResponse> AddTagsToResourceAsync(AddTagsToResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsToResourceRequestMarshaller.Instance;
            var unmarshaller = AddTagsToResourceResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsToResourceRequest,AddTagsToResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEndpoint

        internal virtual CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request)
        {
            var marshaller = CreateEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateEndpointRequest,CreateEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        public virtual Task<CreateEndpointResponse> CreateEndpointAsync(CreateEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateEndpointRequestMarshaller.Instance;
            var unmarshaller = CreateEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEndpointRequest,CreateEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateEventSubscription

        internal virtual CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request)
        {
            var marshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        public virtual Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = CreateEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventSubscriptionRequest,CreateEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationInstance

        internal virtual CreateReplicationInstanceResponse CreateReplicationInstance(CreateReplicationInstanceRequest request)
        {
            var marshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationInstanceRequest,CreateReplicationInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationInstance">REST API Reference for CreateReplicationInstance Operation</seealso>
        public virtual Task<CreateReplicationInstanceResponse> CreateReplicationInstanceAsync(CreateReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationInstanceRequest,CreateReplicationInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationSubnetGroup

        internal virtual CreateReplicationSubnetGroupResponse CreateReplicationSubnetGroup(CreateReplicationSubnetGroupRequest request)
        {
            var marshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationSubnetGroupRequest,CreateReplicationSubnetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationSubnetGroup">REST API Reference for CreateReplicationSubnetGroup Operation</seealso>
        public virtual Task<CreateReplicationSubnetGroupResponse> CreateReplicationSubnetGroupAsync(CreateReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReplicationSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationSubnetGroupRequest,CreateReplicationSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReplicationTask

        internal virtual CreateReplicationTaskResponse CreateReplicationTask(CreateReplicationTaskRequest request)
        {
            var marshaller = CreateReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<CreateReplicationTaskRequest,CreateReplicationTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/CreateReplicationTask">REST API Reference for CreateReplicationTask Operation</seealso>
        public virtual Task<CreateReplicationTaskResponse> CreateReplicationTaskAsync(CreateReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = CreateReplicationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReplicationTaskRequest,CreateReplicationTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCertificate

        internal virtual DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var marshaller = DeleteCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateRequest,DeleteCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteCertificate">REST API Reference for DeleteCertificate Operation</seealso>
        public virtual Task<DeleteCertificateResponse> DeleteCertificateAsync(DeleteCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCertificateRequest,DeleteCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEndpoint

        internal virtual DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            var marshaller = DeleteEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        public virtual Task<DeleteEndpointResponse> DeleteEndpointAsync(DeleteEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEndpointRequestMarshaller.Instance;
            var unmarshaller = DeleteEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEndpointRequest,DeleteEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteEventSubscription

        internal virtual DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request)
        {
            var marshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        public virtual Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = DeleteEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventSubscriptionRequest,DeleteEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationInstance

        internal virtual DeleteReplicationInstanceResponse DeleteReplicationInstance(DeleteReplicationInstanceRequest request)
        {
            var marshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationInstanceRequest,DeleteReplicationInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationInstance">REST API Reference for DeleteReplicationInstance Operation</seealso>
        public virtual Task<DeleteReplicationInstanceResponse> DeleteReplicationInstanceAsync(DeleteReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationInstanceRequest,DeleteReplicationInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationSubnetGroup

        internal virtual DeleteReplicationSubnetGroupResponse DeleteReplicationSubnetGroup(DeleteReplicationSubnetGroupRequest request)
        {
            var marshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationSubnetGroupRequest,DeleteReplicationSubnetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationSubnetGroup">REST API Reference for DeleteReplicationSubnetGroup Operation</seealso>
        public virtual Task<DeleteReplicationSubnetGroupResponse> DeleteReplicationSubnetGroupAsync(DeleteReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReplicationSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationSubnetGroupRequest,DeleteReplicationSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteReplicationTask

        internal virtual DeleteReplicationTaskResponse DeleteReplicationTask(DeleteReplicationTaskRequest request)
        {
            var marshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<DeleteReplicationTaskRequest,DeleteReplicationTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DeleteReplicationTask">REST API Reference for DeleteReplicationTask Operation</seealso>
        public virtual Task<DeleteReplicationTaskResponse> DeleteReplicationTaskAsync(DeleteReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = DeleteReplicationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteReplicationTaskRequest,DeleteReplicationTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCertificates

        internal virtual DescribeCertificatesResponse DescribeCertificates(DescribeCertificatesRequest request)
        {
            var marshaller = DescribeCertificatesRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificatesRequest,DescribeCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeCertificates">REST API Reference for DescribeCertificates Operation</seealso>
        public virtual Task<DescribeCertificatesResponse> DescribeCertificatesAsync(DescribeCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeCertificatesRequestMarshaller.Instance;
            var unmarshaller = DescribeCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCertificatesRequest,DescribeCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnections

        internal virtual DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request)
        {
            var marshaller = DescribeConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsRequest,DescribeConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeConnectionsRequestMarshaller.Instance;
            var unmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionsRequest,DescribeConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpoints

        internal virtual DescribeEndpointsResponse DescribeEndpoints(DescribeEndpointsRequest request)
        {
            var marshaller = DescribeEndpointsRequestMarshaller.Instance;
            var unmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointsRequest,DescribeEndpointsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpoints">REST API Reference for DescribeEndpoints Operation</seealso>
        public virtual Task<DescribeEndpointsResponse> DescribeEndpointsAsync(DescribeEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEndpointsRequestMarshaller.Instance;
            var unmarshaller = DescribeEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointsRequest,DescribeEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEndpointTypes

        internal virtual DescribeEndpointTypesResponse DescribeEndpointTypes(DescribeEndpointTypesRequest request)
        {
            var marshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            var unmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeEndpointTypesRequest,DescribeEndpointTypesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEndpointTypes">REST API Reference for DescribeEndpointTypes Operation</seealso>
        public virtual Task<DescribeEndpointTypesResponse> DescribeEndpointTypesAsync(DescribeEndpointTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEndpointTypesRequestMarshaller.Instance;
            var unmarshaller = DescribeEndpointTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEndpointTypesRequest,DescribeEndpointTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventCategories

        internal virtual DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request)
        {
            var marshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventCategories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        public virtual Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventCategoriesRequestMarshaller.Instance;
            var unmarshaller = DescribeEventCategoriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventCategoriesRequest,DescribeEventCategoriesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsRequest,DescribeEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeEventSubscriptions

        internal virtual DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request)
        {
            var marshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEventSubscriptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        public virtual Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeEventSubscriptionsRequestMarshaller.Instance;
            var unmarshaller = DescribeEventSubscriptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventSubscriptionsRequest,DescribeEventSubscriptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeOrderableReplicationInstances

        internal virtual DescribeOrderableReplicationInstancesResponse DescribeOrderableReplicationInstances(DescribeOrderableReplicationInstancesRequest request)
        {
            var marshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeOrderableReplicationInstancesRequest,DescribeOrderableReplicationInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrderableReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeOrderableReplicationInstances">REST API Reference for DescribeOrderableReplicationInstances Operation</seealso>
        public virtual Task<DescribeOrderableReplicationInstancesResponse> DescribeOrderableReplicationInstancesAsync(DescribeOrderableReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeOrderableReplicationInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeOrderableReplicationInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOrderableReplicationInstancesRequest,DescribeOrderableReplicationInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRefreshSchemasStatus

        internal virtual DescribeRefreshSchemasStatusResponse DescribeRefreshSchemasStatus(DescribeRefreshSchemasStatusRequest request)
        {
            var marshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeRefreshSchemasStatusRequest,DescribeRefreshSchemasStatusResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRefreshSchemasStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRefreshSchemasStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeRefreshSchemasStatus">REST API Reference for DescribeRefreshSchemasStatus Operation</seealso>
        public virtual Task<DescribeRefreshSchemasStatusResponse> DescribeRefreshSchemasStatusAsync(DescribeRefreshSchemasStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRefreshSchemasStatusRequestMarshaller.Instance;
            var unmarshaller = DescribeRefreshSchemasStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRefreshSchemasStatusRequest,DescribeRefreshSchemasStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationInstances

        internal virtual DescribeReplicationInstancesResponse DescribeReplicationInstances(DescribeReplicationInstancesRequest request)
        {
            var marshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstancesRequest,DescribeReplicationInstancesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstances">REST API Reference for DescribeReplicationInstances Operation</seealso>
        public virtual Task<DescribeReplicationInstancesResponse> DescribeReplicationInstancesAsync(DescribeReplicationInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReplicationInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationInstancesRequest,DescribeReplicationInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationInstanceTaskLogs

        internal virtual DescribeReplicationInstanceTaskLogsResponse DescribeReplicationInstanceTaskLogs(DescribeReplicationInstanceTaskLogsRequest request)
        {
            var marshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationInstanceTaskLogsRequest,DescribeReplicationInstanceTaskLogsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationInstanceTaskLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationInstanceTaskLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationInstanceTaskLogs">REST API Reference for DescribeReplicationInstanceTaskLogs Operation</seealso>
        public virtual Task<DescribeReplicationInstanceTaskLogsResponse> DescribeReplicationInstanceTaskLogsAsync(DescribeReplicationInstanceTaskLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReplicationInstanceTaskLogsRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationInstanceTaskLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationInstanceTaskLogsRequest,DescribeReplicationInstanceTaskLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationSubnetGroups

        internal virtual DescribeReplicationSubnetGroupsResponse DescribeReplicationSubnetGroups(DescribeReplicationSubnetGroupsRequest request)
        {
            var marshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationSubnetGroupsRequest,DescribeReplicationSubnetGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationSubnetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationSubnetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationSubnetGroups">REST API Reference for DescribeReplicationSubnetGroups Operation</seealso>
        public virtual Task<DescribeReplicationSubnetGroupsResponse> DescribeReplicationSubnetGroupsAsync(DescribeReplicationSubnetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReplicationSubnetGroupsRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationSubnetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationSubnetGroupsRequest,DescribeReplicationSubnetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationTaskAssessmentResults

        internal virtual DescribeReplicationTaskAssessmentResultsResponse DescribeReplicationTaskAssessmentResults(DescribeReplicationTaskAssessmentResultsRequest request)
        {
            var marshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTaskAssessmentResultsRequest,DescribeReplicationTaskAssessmentResultsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTaskAssessmentResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTaskAssessmentResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTaskAssessmentResults">REST API Reference for DescribeReplicationTaskAssessmentResults Operation</seealso>
        public virtual Task<DescribeReplicationTaskAssessmentResultsResponse> DescribeReplicationTaskAssessmentResultsAsync(DescribeReplicationTaskAssessmentResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReplicationTaskAssessmentResultsRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationTaskAssessmentResultsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationTaskAssessmentResultsRequest,DescribeReplicationTaskAssessmentResultsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReplicationTasks

        internal virtual DescribeReplicationTasksResponse DescribeReplicationTasks(DescribeReplicationTasksRequest request)
        {
            var marshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeReplicationTasksRequest,DescribeReplicationTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReplicationTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReplicationTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeReplicationTasks">REST API Reference for DescribeReplicationTasks Operation</seealso>
        public virtual Task<DescribeReplicationTasksResponse> DescribeReplicationTasksAsync(DescribeReplicationTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeReplicationTasksRequestMarshaller.Instance;
            var unmarshaller = DescribeReplicationTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReplicationTasksRequest,DescribeReplicationTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSchemas

        internal virtual DescribeSchemasResponse DescribeSchemas(DescribeSchemasRequest request)
        {
            var marshaller = DescribeSchemasRequestMarshaller.Instance;
            var unmarshaller = DescribeSchemasResponseUnmarshaller.Instance;

            return Invoke<DescribeSchemasRequest,DescribeSchemasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeSchemas">REST API Reference for DescribeSchemas Operation</seealso>
        public virtual Task<DescribeSchemasResponse> DescribeSchemasAsync(DescribeSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeSchemasRequestMarshaller.Instance;
            var unmarshaller = DescribeSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSchemasRequest,DescribeSchemasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTableStatistics

        internal virtual DescribeTableStatisticsResponse DescribeTableStatistics(DescribeTableStatisticsRequest request)
        {
            var marshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            var unmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;

            return Invoke<DescribeTableStatisticsRequest,DescribeTableStatisticsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTableStatistics operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableStatistics operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/DescribeTableStatistics">REST API Reference for DescribeTableStatistics Operation</seealso>
        public virtual Task<DescribeTableStatisticsResponse> DescribeTableStatisticsAsync(DescribeTableStatisticsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTableStatisticsRequestMarshaller.Instance;
            var unmarshaller = DescribeTableStatisticsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTableStatisticsRequest,DescribeTableStatisticsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportCertificate

        internal virtual ImportCertificateResponse ImportCertificate(ImportCertificateRequest request)
        {
            var marshaller = ImportCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return Invoke<ImportCertificateRequest,ImportCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ImportCertificate">REST API Reference for ImportCertificate Operation</seealso>
        public virtual Task<ImportCertificateResponse> ImportCertificateAsync(ImportCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportCertificateRequestMarshaller.Instance;
            var unmarshaller = ImportCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCertificateRequest,ImportCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListTagsForResourceRequestMarshaller.Instance;
            var unmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceRequest,ListTagsForResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEndpoint

        internal virtual ModifyEndpointResponse ModifyEndpoint(ModifyEndpointRequest request)
        {
            var marshaller = ModifyEndpointRequestMarshaller.Instance;
            var unmarshaller = ModifyEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyEndpointRequest,ModifyEndpointResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEndpoint">REST API Reference for ModifyEndpoint Operation</seealso>
        public virtual Task<ModifyEndpointResponse> ModifyEndpointAsync(ModifyEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyEndpointRequestMarshaller.Instance;
            var unmarshaller = ModifyEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEndpointRequest,ModifyEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyEventSubscription

        internal virtual ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request)
        {
            var marshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return Invoke<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyEventSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        public virtual Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyEventSubscriptionRequestMarshaller.Instance;
            var unmarshaller = ModifyEventSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyEventSubscriptionRequest,ModifyEventSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationInstance

        internal virtual ModifyReplicationInstanceResponse ModifyReplicationInstance(ModifyReplicationInstanceRequest request)
        {
            var marshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationInstanceRequest,ModifyReplicationInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationInstance">REST API Reference for ModifyReplicationInstance Operation</seealso>
        public virtual Task<ModifyReplicationInstanceResponse> ModifyReplicationInstanceAsync(ModifyReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = ModifyReplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationInstanceRequest,ModifyReplicationInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationSubnetGroup

        internal virtual ModifyReplicationSubnetGroupResponse ModifyReplicationSubnetGroup(ModifyReplicationSubnetGroupRequest request)
        {
            var marshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationSubnetGroupRequest,ModifyReplicationSubnetGroupResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationSubnetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationSubnetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationSubnetGroup">REST API Reference for ModifyReplicationSubnetGroup Operation</seealso>
        public virtual Task<ModifyReplicationSubnetGroupResponse> ModifyReplicationSubnetGroupAsync(ModifyReplicationSubnetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyReplicationSubnetGroupRequestMarshaller.Instance;
            var unmarshaller = ModifyReplicationSubnetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationSubnetGroupRequest,ModifyReplicationSubnetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyReplicationTask

        internal virtual ModifyReplicationTaskResponse ModifyReplicationTask(ModifyReplicationTaskRequest request)
        {
            var marshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<ModifyReplicationTaskRequest,ModifyReplicationTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ModifyReplicationTask">REST API Reference for ModifyReplicationTask Operation</seealso>
        public virtual Task<ModifyReplicationTaskResponse> ModifyReplicationTaskAsync(ModifyReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = ModifyReplicationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReplicationTaskRequest,ModifyReplicationTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootReplicationInstance

        internal virtual RebootReplicationInstanceResponse RebootReplicationInstance(RebootReplicationInstanceRequest request)
        {
            var marshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;

            return Invoke<RebootReplicationInstanceRequest,RebootReplicationInstanceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootReplicationInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootReplicationInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RebootReplicationInstance">REST API Reference for RebootReplicationInstance Operation</seealso>
        public virtual Task<RebootReplicationInstanceResponse> RebootReplicationInstanceAsync(RebootReplicationInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RebootReplicationInstanceRequestMarshaller.Instance;
            var unmarshaller = RebootReplicationInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<RebootReplicationInstanceRequest,RebootReplicationInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RefreshSchemas

        internal virtual RefreshSchemasResponse RefreshSchemas(RefreshSchemasRequest request)
        {
            var marshaller = RefreshSchemasRequestMarshaller.Instance;
            var unmarshaller = RefreshSchemasResponseUnmarshaller.Instance;

            return Invoke<RefreshSchemasRequest,RefreshSchemasResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RefreshSchemas operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RefreshSchemas operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RefreshSchemas">REST API Reference for RefreshSchemas Operation</seealso>
        public virtual Task<RefreshSchemasResponse> RefreshSchemasAsync(RefreshSchemasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RefreshSchemasRequestMarshaller.Instance;
            var unmarshaller = RefreshSchemasResponseUnmarshaller.Instance;

            return InvokeAsync<RefreshSchemasRequest,RefreshSchemasResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReloadTables

        internal virtual ReloadTablesResponse ReloadTables(ReloadTablesRequest request)
        {
            var marshaller = ReloadTablesRequestMarshaller.Instance;
            var unmarshaller = ReloadTablesResponseUnmarshaller.Instance;

            return Invoke<ReloadTablesRequest,ReloadTablesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReloadTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReloadTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/ReloadTables">REST API Reference for ReloadTables Operation</seealso>
        public virtual Task<ReloadTablesResponse> ReloadTablesAsync(ReloadTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ReloadTablesRequestMarshaller.Instance;
            var unmarshaller = ReloadTablesResponseUnmarshaller.Instance;

            return InvokeAsync<ReloadTablesRequest,ReloadTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTagsFromResource

        internal virtual RemoveTagsFromResourceResponse RemoveTagsFromResource(RemoveTagsFromResourceRequest request)
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTagsFromResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTagsFromResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/RemoveTagsFromResource">REST API Reference for RemoveTagsFromResource Operation</seealso>
        public virtual Task<RemoveTagsFromResourceResponse> RemoveTagsFromResourceAsync(RemoveTagsFromResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTagsFromResourceRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsFromResourceResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsFromResourceRequest,RemoveTagsFromResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartReplicationTask

        internal virtual StartReplicationTaskResponse StartReplicationTask(StartReplicationTaskRequest request)
        {
            var marshaller = StartReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskRequest,StartReplicationTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTask">REST API Reference for StartReplicationTask Operation</seealso>
        public virtual Task<StartReplicationTaskResponse> StartReplicationTaskAsync(StartReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = StartReplicationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartReplicationTaskRequest,StartReplicationTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartReplicationTaskAssessment

        internal virtual StartReplicationTaskAssessmentResponse StartReplicationTaskAssessment(StartReplicationTaskAssessmentRequest request)
        {
            var marshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            var unmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartReplicationTaskAssessmentRequest,StartReplicationTaskAssessmentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartReplicationTaskAssessment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartReplicationTaskAssessment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StartReplicationTaskAssessment">REST API Reference for StartReplicationTaskAssessment Operation</seealso>
        public virtual Task<StartReplicationTaskAssessmentResponse> StartReplicationTaskAssessmentAsync(StartReplicationTaskAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StartReplicationTaskAssessmentRequestMarshaller.Instance;
            var unmarshaller = StartReplicationTaskAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<StartReplicationTaskAssessmentRequest,StartReplicationTaskAssessmentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopReplicationTask

        internal virtual StopReplicationTaskResponse StopReplicationTask(StopReplicationTaskRequest request)
        {
            var marshaller = StopReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;

            return Invoke<StopReplicationTaskRequest,StopReplicationTaskResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopReplicationTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopReplicationTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/StopReplicationTask">REST API Reference for StopReplicationTask Operation</seealso>
        public virtual Task<StopReplicationTaskResponse> StopReplicationTaskAsync(StopReplicationTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = StopReplicationTaskRequestMarshaller.Instance;
            var unmarshaller = StopReplicationTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StopReplicationTaskRequest,StopReplicationTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestConnection

        internal virtual TestConnectionResponse TestConnection(TestConnectionRequest request)
        {
            var marshaller = TestConnectionRequestMarshaller.Instance;
            var unmarshaller = TestConnectionResponseUnmarshaller.Instance;

            return Invoke<TestConnectionRequest,TestConnectionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/dms-2016-01-01/TestConnection">REST API Reference for TestConnection Operation</seealso>
        public virtual Task<TestConnectionResponse> TestConnectionAsync(TestConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TestConnectionRequestMarshaller.Instance;
            var unmarshaller = TestConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<TestConnectionRequest,TestConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}