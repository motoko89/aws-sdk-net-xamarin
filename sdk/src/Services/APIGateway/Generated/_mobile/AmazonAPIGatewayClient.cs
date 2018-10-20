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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.APIGateway.Model;
using Amazon.APIGateway.Model.Internal.MarshallTransformations;
using Amazon.APIGateway.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.APIGateway
{
    /// <summary>
    /// Implementation for accessing APIGateway
    ///
    /// Amazon API Gateway 
    /// <para>
    /// Amazon API Gateway helps developers deliver robust, secure, and scalable mobile and
    /// web application back ends. API Gateway allows developers to securely connect mobile
    /// and web applications to APIs that run on AWS Lambda, Amazon EC2, or other publicly
    /// addressable web services that are hosted outside of AWS.
    /// </para>
    /// </summary>
    public partial class AmazonAPIGatewayClient : AmazonServiceClient, IAmazonAPIGateway
    {
        private static IServiceMetadata serviceMetadata = new AmazonAPIGatewayMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonAPIGatewayClient with the credentials loaded from the application's
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
        public AmazonAPIGatewayClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAPIGatewayConfig()) { }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with the credentials loaded from the application's
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
        public AmazonAPIGatewayClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAPIGatewayConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(AmazonAPIGatewayConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAPIGatewayClient(AWSCredentials credentials)
            : this(credentials, new AmazonAPIGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIGatewayClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAPIGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Credentials and an
        /// AmazonAPIGatewayClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(AWSCredentials credentials, AmazonAPIGatewayConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAPIGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAPIGatewayConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAPIGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAPIGatewayConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAPIGatewayConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAPIGatewayConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAPIGatewayClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAPIGatewayClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAPIGatewayClient Configuration Object</param>
        public AmazonAPIGatewayClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAPIGatewayConfig clientConfig)
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
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.APIGateway.Internal.AmazonAPIGatewayPostMarshallHandler());
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

        
        #region  CreateApiKey

        internal virtual CreateApiKeyResponse CreateApiKey(CreateApiKeyRequest request)
        {
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return Invoke<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateApiKeyResponse> CreateApiKeyAsync(CreateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateApiKeyRequestMarshaller.Instance;
            var unmarshaller = CreateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApiKeyRequest,CreateApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAuthorizer

        internal virtual CreateAuthorizerResponse CreateAuthorizer(CreateAuthorizerRequest request)
        {
            var marshaller = CreateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<CreateAuthorizerRequest,CreateAuthorizerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateAuthorizerResponse> CreateAuthorizerAsync(CreateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = CreateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAuthorizerRequest,CreateAuthorizerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateBasePathMapping

        internal virtual CreateBasePathMappingResponse CreateBasePathMapping(CreateBasePathMappingRequest request)
        {
            var marshaller = CreateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<CreateBasePathMappingRequest,CreateBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateBasePathMappingResponse> CreateBasePathMappingAsync(CreateBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = CreateBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBasePathMappingRequest,CreateBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDeployment

        internal virtual CreateDeploymentResponse CreateDeployment(CreateDeploymentRequest request)
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return Invoke<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDeploymentResponse> CreateDeploymentAsync(CreateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDeploymentRequestMarshaller.Instance;
            var unmarshaller = CreateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeploymentRequest,CreateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDocumentationPart

        internal virtual CreateDocumentationPartResponse CreateDocumentationPart(CreateDocumentationPartRequest request)
        {
            var marshaller = CreateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentationPartRequest,CreateDocumentationPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDocumentationPartResponse> CreateDocumentationPartAsync(CreateDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationPartResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentationPartRequest,CreateDocumentationPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDocumentationVersion

        internal virtual CreateDocumentationVersionResponse CreateDocumentationVersion(CreateDocumentationVersionRequest request)
        {
            var marshaller = CreateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateDocumentationVersionRequest,CreateDocumentationVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDocumentationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDocumentationVersionResponse> CreateDocumentationVersionAsync(CreateDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = CreateDocumentationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDocumentationVersionRequest,CreateDocumentationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDomainName

        internal virtual CreateDomainNameResponse CreateDomainName(CreateDomainNameRequest request)
        {
            var marshaller = CreateDomainNameRequestMarshaller.Instance;
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return Invoke<CreateDomainNameRequest,CreateDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateDomainNameResponse> CreateDomainNameAsync(CreateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateDomainNameRequestMarshaller.Instance;
            var unmarshaller = CreateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDomainNameRequest,CreateDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateModel

        internal virtual CreateModelResponse CreateModel(CreateModelRequest request)
        {
            var marshaller = CreateModelRequestMarshaller.Instance;
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return Invoke<CreateModelRequest,CreateModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateModelResponse> CreateModelAsync(CreateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateModelRequestMarshaller.Instance;
            var unmarshaller = CreateModelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateModelRequest,CreateModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRequestValidator

        internal virtual CreateRequestValidatorResponse CreateRequestValidator(CreateRequestValidatorRequest request)
        {
            var marshaller = CreateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = CreateRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<CreateRequestValidatorRequest,CreateRequestValidatorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRequestValidator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateRequestValidatorResponse> CreateRequestValidatorAsync(CreateRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = CreateRequestValidatorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRequestValidatorRequest,CreateRequestValidatorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateResource

        internal virtual CreateResourceResponse CreateResource(CreateResourceRequest request)
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return Invoke<CreateResourceRequest,CreateResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateResourceResponse> CreateResourceAsync(CreateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateResourceRequestMarshaller.Instance;
            var unmarshaller = CreateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResourceRequest,CreateResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRestApi

        internal virtual CreateRestApiResponse CreateRestApi(CreateRestApiRequest request)
        {
            var marshaller = CreateRestApiRequestMarshaller.Instance;
            var unmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return Invoke<CreateRestApiRequest,CreateRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateRestApiResponse> CreateRestApiAsync(CreateRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRestApiRequestMarshaller.Instance;
            var unmarshaller = CreateRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRestApiRequest,CreateRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateStage

        internal virtual CreateStageResponse CreateStage(CreateStageRequest request)
        {
            var marshaller = CreateStageRequestMarshaller.Instance;
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return Invoke<CreateStageRequest,CreateStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateStageResponse> CreateStageAsync(CreateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateStageRequestMarshaller.Instance;
            var unmarshaller = CreateStageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStageRequest,CreateStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUsagePlan

        internal virtual CreateUsagePlanResponse CreateUsagePlan(CreateUsagePlanRequest request)
        {
            var marshaller = CreateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanResponseUnmarshaller.Instance;

            return Invoke<CreateUsagePlanRequest,CreateUsagePlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateUsagePlanResponse> CreateUsagePlanAsync(CreateUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUsagePlanRequest,CreateUsagePlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateUsagePlanKey

        internal virtual CreateUsagePlanKeyResponse CreateUsagePlanKey(CreateUsagePlanKeyRequest request)
        {
            var marshaller = CreateUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<CreateUsagePlanKeyRequest,CreateUsagePlanKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUsagePlanKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateUsagePlanKeyResponse> CreateUsagePlanKeyAsync(CreateUsagePlanKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = CreateUsagePlanKeyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateUsagePlanKeyRequest,CreateUsagePlanKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcLink

        internal virtual CreateVpcLinkResponse CreateVpcLink(CreateVpcLinkRequest request)
        {
            var marshaller = CreateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<CreateVpcLinkRequest,CreateVpcLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CreateVpcLinkResponse> CreateVpcLinkAsync(CreateVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = CreateVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcLinkRequest,CreateVpcLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteApiKey

        internal virtual DeleteApiKeyResponse DeleteApiKey(DeleteApiKeyRequest request)
        {
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteApiKeyResponse> DeleteApiKeyAsync(DeleteApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteApiKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApiKeyRequest,DeleteApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteAuthorizer

        internal virtual DeleteAuthorizerResponse DeleteAuthorizer(DeleteAuthorizerRequest request)
        {
            var marshaller = DeleteAuthorizerRequestMarshaller.Instance;
            var unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return Invoke<DeleteAuthorizerRequest,DeleteAuthorizerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteAuthorizerResponse> DeleteAuthorizerAsync(DeleteAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteAuthorizerRequestMarshaller.Instance;
            var unmarshaller = DeleteAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAuthorizerRequest,DeleteAuthorizerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteBasePathMapping

        internal virtual DeleteBasePathMappingResponse DeleteBasePathMapping(DeleteBasePathMappingRequest request)
        {
            var marshaller = DeleteBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteBasePathMappingRequest,DeleteBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBasePathMappingResponse> DeleteBasePathMappingAsync(DeleteBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = DeleteBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBasePathMappingRequest,DeleteBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteClientCertificate

        internal virtual DeleteClientCertificateResponse DeleteClientCertificate(DeleteClientCertificateRequest request)
        {
            var marshaller = DeleteClientCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteClientCertificateRequest,DeleteClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteClientCertificateResponse> DeleteClientCertificateAsync(DeleteClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteClientCertificateRequestMarshaller.Instance;
            var unmarshaller = DeleteClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClientCertificateRequest,DeleteClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDeployment

        internal virtual DeleteDeploymentResponse DeleteDeployment(DeleteDeploymentRequest request)
        {
            var marshaller = DeleteDeploymentRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return Invoke<DeleteDeploymentRequest,DeleteDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDeploymentResponse> DeleteDeploymentAsync(DeleteDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDeploymentRequestMarshaller.Instance;
            var unmarshaller = DeleteDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeploymentRequest,DeleteDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocumentationPart

        internal virtual DeleteDocumentationPartResponse DeleteDocumentationPart(DeleteDocumentationPartRequest request)
        {
            var marshaller = DeleteDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentationPartRequest,DeleteDocumentationPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDocumentationPartResponse> DeleteDocumentationPartAsync(DeleteDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationPartResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentationPartRequest,DeleteDocumentationPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDocumentationVersion

        internal virtual DeleteDocumentationVersionResponse DeleteDocumentationVersion(DeleteDocumentationVersionRequest request)
        {
            var marshaller = DeleteDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteDocumentationVersionRequest,DeleteDocumentationVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDocumentationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDocumentationVersionResponse> DeleteDocumentationVersionAsync(DeleteDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = DeleteDocumentationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDocumentationVersionRequest,DeleteDocumentationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDomainName

        internal virtual DeleteDomainNameResponse DeleteDomainName(DeleteDomainNameRequest request)
        {
            var marshaller = DeleteDomainNameRequestMarshaller.Instance;
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return Invoke<DeleteDomainNameRequest,DeleteDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteDomainNameResponse> DeleteDomainNameAsync(DeleteDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteDomainNameRequestMarshaller.Instance;
            var unmarshaller = DeleteDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDomainNameRequest,DeleteDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteGatewayResponse

        internal virtual DeleteGatewayResponseResponse DeleteGatewayResponse(DeleteGatewayResponseRequest request)
        {
            var marshaller = DeleteGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteGatewayResponseRequest,DeleteGatewayResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGatewayResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteGatewayResponseResponse> DeleteGatewayResponseAsync(DeleteGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteGatewayResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGatewayResponseRequest,DeleteGatewayResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegration

        internal virtual DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request)
        {
            var marshaller = DeleteIntegrationRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationRequest,DeleteIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIntegrationRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationRequest,DeleteIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteIntegrationResponse

        internal virtual DeleteIntegrationResponseResponse DeleteIntegrationResponse(DeleteIntegrationResponseRequest request)
        {
            var marshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteIntegrationResponseRequest,DeleteIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteIntegrationResponseResponse> DeleteIntegrationResponseAsync(DeleteIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIntegrationResponseRequest,DeleteIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMethod

        internal virtual DeleteMethodResponse DeleteMethod(DeleteMethodRequest request)
        {
            var marshaller = DeleteMethodRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodRequest,DeleteMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteMethodResponse> DeleteMethodAsync(DeleteMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMethodRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMethodRequest,DeleteMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMethodResponse

        internal virtual DeleteMethodResponseResponse DeleteMethodResponse(DeleteMethodResponseRequest request)
        {
            var marshaller = DeleteMethodResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return Invoke<DeleteMethodResponseRequest,DeleteMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteMethodResponseResponse> DeleteMethodResponseAsync(DeleteMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMethodResponseRequestMarshaller.Instance;
            var unmarshaller = DeleteMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMethodResponseRequest,DeleteMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteModel

        internal virtual DeleteModelResponse DeleteModel(DeleteModelRequest request)
        {
            var marshaller = DeleteModelRequestMarshaller.Instance;
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return Invoke<DeleteModelRequest,DeleteModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteModelResponse> DeleteModelAsync(DeleteModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteModelRequestMarshaller.Instance;
            var unmarshaller = DeleteModelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteModelRequest,DeleteModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRequestValidator

        internal virtual DeleteRequestValidatorResponse DeleteRequestValidator(DeleteRequestValidatorRequest request)
        {
            var marshaller = DeleteRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = DeleteRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<DeleteRequestValidatorRequest,DeleteRequestValidatorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRequestValidator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteRequestValidatorResponse> DeleteRequestValidatorAsync(DeleteRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = DeleteRequestValidatorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRequestValidatorRequest,DeleteRequestValidatorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteResource

        internal virtual DeleteResourceResponse DeleteResource(DeleteResourceRequest request)
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return Invoke<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteResourceResponse> DeleteResourceAsync(DeleteResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteResourceRequestMarshaller.Instance;
            var unmarshaller = DeleteResourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourceRequest,DeleteResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRestApi

        internal virtual DeleteRestApiResponse DeleteRestApi(DeleteRestApiRequest request)
        {
            var marshaller = DeleteRestApiRequestMarshaller.Instance;
            var unmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return Invoke<DeleteRestApiRequest,DeleteRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteRestApiResponse> DeleteRestApiAsync(DeleteRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRestApiRequestMarshaller.Instance;
            var unmarshaller = DeleteRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRestApiRequest,DeleteRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteStage

        internal virtual DeleteStageResponse DeleteStage(DeleteStageRequest request)
        {
            var marshaller = DeleteStageRequestMarshaller.Instance;
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return Invoke<DeleteStageRequest,DeleteStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteStageResponse> DeleteStageAsync(DeleteStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteStageRequestMarshaller.Instance;
            var unmarshaller = DeleteStageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteStageRequest,DeleteStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUsagePlan

        internal virtual DeleteUsagePlanResponse DeleteUsagePlan(DeleteUsagePlanRequest request)
        {
            var marshaller = DeleteUsagePlanRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanResponseUnmarshaller.Instance;

            return Invoke<DeleteUsagePlanRequest,DeleteUsagePlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteUsagePlanResponse> DeleteUsagePlanAsync(DeleteUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUsagePlanRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUsagePlanRequest,DeleteUsagePlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteUsagePlanKey

        internal virtual DeleteUsagePlanKeyResponse DeleteUsagePlanKey(DeleteUsagePlanKeyRequest request)
        {
            var marshaller = DeleteUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<DeleteUsagePlanKeyRequest,DeleteUsagePlanKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUsagePlanKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteUsagePlanKeyResponse> DeleteUsagePlanKeyAsync(DeleteUsagePlanKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = DeleteUsagePlanKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteUsagePlanKeyRequest,DeleteUsagePlanKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcLink

        internal virtual DeleteVpcLinkResponse DeleteVpcLink(DeleteVpcLinkRequest request)
        {
            var marshaller = DeleteVpcLinkRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcLinkRequest,DeleteVpcLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteVpcLinkResponse> DeleteVpcLinkAsync(DeleteVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVpcLinkRequestMarshaller.Instance;
            var unmarshaller = DeleteVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcLinkRequest,DeleteVpcLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  FlushStageAuthorizersCache

        internal virtual FlushStageAuthorizersCacheResponse FlushStageAuthorizersCache(FlushStageAuthorizersCacheRequest request)
        {
            var marshaller = FlushStageAuthorizersCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageAuthorizersCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageAuthorizersCacheRequest,FlushStageAuthorizersCacheResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageAuthorizersCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageAuthorizersCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<FlushStageAuthorizersCacheResponse> FlushStageAuthorizersCacheAsync(FlushStageAuthorizersCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = FlushStageAuthorizersCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageAuthorizersCacheResponseUnmarshaller.Instance;

            return InvokeAsync<FlushStageAuthorizersCacheRequest,FlushStageAuthorizersCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  FlushStageCache

        internal virtual FlushStageCacheResponse FlushStageCache(FlushStageCacheRequest request)
        {
            var marshaller = FlushStageCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return Invoke<FlushStageCacheRequest,FlushStageCacheResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the FlushStageCache operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FlushStageCache operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<FlushStageCacheResponse> FlushStageCacheAsync(FlushStageCacheRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = FlushStageCacheRequestMarshaller.Instance;
            var unmarshaller = FlushStageCacheResponseUnmarshaller.Instance;

            return InvokeAsync<FlushStageCacheRequest,FlushStageCacheResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GenerateClientCertificate

        internal virtual GenerateClientCertificateResponse GenerateClientCertificate(GenerateClientCertificateRequest request)
        {
            var marshaller = GenerateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GenerateClientCertificateRequest,GenerateClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GenerateClientCertificateResponse> GenerateClientCertificateAsync(GenerateClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GenerateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GenerateClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GenerateClientCertificateRequest,GenerateClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAccount

        internal virtual GetAccountResponse GetAccount(GetAccountRequest request)
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return Invoke<GetAccountRequest,GetAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAccountResponse> GetAccountAsync(GetAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAccountRequestMarshaller.Instance;
            var unmarshaller = GetAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountRequest,GetAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApiKey

        internal virtual GetApiKeyResponse GetApiKey(GetApiKeyRequest request)
        {
            var marshaller = GetApiKeyRequestMarshaller.Instance;
            var unmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return Invoke<GetApiKeyRequest,GetApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApiKeyResponse> GetApiKeyAsync(GetApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApiKeyRequestMarshaller.Instance;
            var unmarshaller = GetApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiKeyRequest,GetApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetApiKeys

        internal virtual GetApiKeysResponse GetApiKeys(GetApiKeysRequest request)
        {
            var marshaller = GetApiKeysRequestMarshaller.Instance;
            var unmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return Invoke<GetApiKeysRequest,GetApiKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApiKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetApiKeysResponse> GetApiKeysAsync(GetApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetApiKeysRequestMarshaller.Instance;
            var unmarshaller = GetApiKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetApiKeysRequest,GetApiKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizer

        internal virtual GetAuthorizerResponse GetAuthorizer(GetAuthorizerRequest request)
        {
            var marshaller = GetAuthorizerRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizerRequest,GetAuthorizerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAuthorizerResponse> GetAuthorizerAsync(GetAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAuthorizerRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizerRequest,GetAuthorizerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetAuthorizers

        internal virtual GetAuthorizersResponse GetAuthorizers(GetAuthorizersRequest request)
        {
            var marshaller = GetAuthorizersRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return Invoke<GetAuthorizersRequest,GetAuthorizersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAuthorizers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAuthorizers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetAuthorizersResponse> GetAuthorizersAsync(GetAuthorizersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetAuthorizersRequestMarshaller.Instance;
            var unmarshaller = GetAuthorizersResponseUnmarshaller.Instance;

            return InvokeAsync<GetAuthorizersRequest,GetAuthorizersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBasePathMapping

        internal virtual GetBasePathMappingResponse GetBasePathMapping(GetBasePathMappingRequest request)
        {
            var marshaller = GetBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingRequest,GetBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBasePathMappingResponse> GetBasePathMappingAsync(GetBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBasePathMappingRequest,GetBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetBasePathMappings

        internal virtual GetBasePathMappingsResponse GetBasePathMappings(GetBasePathMappingsRequest request)
        {
            var marshaller = GetBasePathMappingsRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return Invoke<GetBasePathMappingsRequest,GetBasePathMappingsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBasePathMappings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBasePathMappings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBasePathMappingsResponse> GetBasePathMappingsAsync(GetBasePathMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetBasePathMappingsRequestMarshaller.Instance;
            var unmarshaller = GetBasePathMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetBasePathMappingsRequest,GetBasePathMappingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClientCertificate

        internal virtual GetClientCertificateResponse GetClientCertificate(GetClientCertificateRequest request)
        {
            var marshaller = GetClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificateRequest,GetClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetClientCertificateResponse> GetClientCertificateAsync(GetClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetClientCertificateRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<GetClientCertificateRequest,GetClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetClientCertificates

        internal virtual GetClientCertificatesResponse GetClientCertificates(GetClientCertificatesRequest request)
        {
            var marshaller = GetClientCertificatesRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return Invoke<GetClientCertificatesRequest,GetClientCertificatesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetClientCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetClientCertificates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetClientCertificatesResponse> GetClientCertificatesAsync(GetClientCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetClientCertificatesRequestMarshaller.Instance;
            var unmarshaller = GetClientCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<GetClientCertificatesRequest,GetClientCertificatesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeployment

        internal virtual GetDeploymentResponse GetDeployment(GetDeploymentRequest request)
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDeploymentResponse> GetDeploymentAsync(GetDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentRequest,GetDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeployments

        internal virtual GetDeploymentsResponse GetDeployments(GetDeploymentsRequest request)
        {
            var marshaller = GetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return Invoke<GetDeploymentsRequest,GetDeploymentsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDeployments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeployments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDeploymentsResponse> GetDeploymentsAsync(GetDeploymentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeploymentsRequestMarshaller.Instance;
            var unmarshaller = GetDeploymentsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeploymentsRequest,GetDeploymentsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentationPart

        internal virtual GetDocumentationPartResponse GetDocumentationPart(GetDocumentationPartRequest request)
        {
            var marshaller = GetDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationPartRequest,GetDocumentationPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDocumentationPartResponse> GetDocumentationPartAsync(GetDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentationPartRequest,GetDocumentationPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentationParts

        internal virtual GetDocumentationPartsResponse GetDocumentationParts(GetDocumentationPartsRequest request)
        {
            var marshaller = GetDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartsResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationPartsRequest,GetDocumentationPartsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDocumentationPartsResponse> GetDocumentationPartsAsync(GetDocumentationPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationPartsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentationPartsRequest,GetDocumentationPartsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentationVersion

        internal virtual GetDocumentationVersionResponse GetDocumentationVersion(GetDocumentationVersionRequest request)
        {
            var marshaller = GetDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationVersionRequest,GetDocumentationVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDocumentationVersionResponse> GetDocumentationVersionAsync(GetDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentationVersionRequest,GetDocumentationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDocumentationVersions

        internal virtual GetDocumentationVersionsResponse GetDocumentationVersions(GetDocumentationVersionsRequest request)
        {
            var marshaller = GetDocumentationVersionsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionsResponseUnmarshaller.Instance;

            return Invoke<GetDocumentationVersionsRequest,GetDocumentationVersionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDocumentationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDocumentationVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDocumentationVersionsResponse> GetDocumentationVersionsAsync(GetDocumentationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDocumentationVersionsRequestMarshaller.Instance;
            var unmarshaller = GetDocumentationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDocumentationVersionsRequest,GetDocumentationVersionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainName

        internal virtual GetDomainNameResponse GetDomainName(GetDomainNameRequest request)
        {
            var marshaller = GetDomainNameRequestMarshaller.Instance;
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return Invoke<GetDomainNameRequest,GetDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDomainNameResponse> GetDomainNameAsync(GetDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDomainNameRequestMarshaller.Instance;
            var unmarshaller = GetDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNameRequest,GetDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDomainNames

        internal virtual GetDomainNamesResponse GetDomainNames(GetDomainNamesRequest request)
        {
            var marshaller = GetDomainNamesRequestMarshaller.Instance;
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return Invoke<GetDomainNamesRequest,GetDomainNamesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDomainNames operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetDomainNamesResponse> GetDomainNamesAsync(GetDomainNamesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDomainNamesRequestMarshaller.Instance;
            var unmarshaller = GetDomainNamesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDomainNamesRequest,GetDomainNamesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetExport

        internal virtual GetExportResponse GetExport(GetExportRequest request)
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return Invoke<GetExportRequest,GetExportResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetExport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetExportResponse> GetExportAsync(GetExportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetExportRequestMarshaller.Instance;
            var unmarshaller = GetExportResponseUnmarshaller.Instance;

            return InvokeAsync<GetExportRequest,GetExportResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGatewayResponse

        internal virtual GetGatewayResponseResponse GetGatewayResponse(GetGatewayResponseRequest request)
        {
            var marshaller = GetGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponseRequest,GetGatewayResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetGatewayResponseResponse> GetGatewayResponseAsync(GetGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetGatewayResponseRequest,GetGatewayResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetGatewayResponses

        internal virtual GetGatewayResponsesResponse GetGatewayResponses(GetGatewayResponsesRequest request)
        {
            var marshaller = GetGatewayResponsesRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponsesResponseUnmarshaller.Instance;

            return Invoke<GetGatewayResponsesRequest,GetGatewayResponsesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGatewayResponses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGatewayResponses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetGatewayResponsesResponse> GetGatewayResponsesAsync(GetGatewayResponsesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetGatewayResponsesRequestMarshaller.Instance;
            var unmarshaller = GetGatewayResponsesResponseUnmarshaller.Instance;

            return InvokeAsync<GetGatewayResponsesRequest,GetGatewayResponsesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntegration

        internal virtual GetIntegrationResponse GetIntegration(GetIntegrationRequest request)
        {
            var marshaller = GetIntegrationRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationRequest,GetIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIntegrationRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationRequest,GetIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetIntegrationResponse

        internal virtual GetIntegrationResponseResponse GetIntegrationResponse(GetIntegrationResponseRequest request)
        {
            var marshaller = GetIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<GetIntegrationResponseRequest,GetIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetIntegrationResponseResponse> GetIntegrationResponseAsync(GetIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = GetIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetIntegrationResponseRequest,GetIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMethod

        internal virtual GetMethodResponse GetMethod(GetMethodRequest request)
        {
            var marshaller = GetMethodRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseUnmarshaller.Instance;

            return Invoke<GetMethodRequest,GetMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetMethodResponse> GetMethodAsync(GetMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMethodRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseUnmarshaller.Instance;

            return InvokeAsync<GetMethodRequest,GetMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetMethodResponse

        internal virtual GetMethodResponseResponse GetMethodResponse(GetMethodResponseRequest request)
        {
            var marshaller = GetMethodResponseRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return Invoke<GetMethodResponseRequest,GetMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetMethodResponseResponse> GetMethodResponseAsync(GetMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetMethodResponseRequestMarshaller.Instance;
            var unmarshaller = GetMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<GetMethodResponseRequest,GetMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetModel

        internal virtual GetModelResponse GetModel(GetModelRequest request)
        {
            var marshaller = GetModelRequestMarshaller.Instance;
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return Invoke<GetModelRequest,GetModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetModelResponse> GetModelAsync(GetModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetModelRequestMarshaller.Instance;
            var unmarshaller = GetModelResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelRequest,GetModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetModels

        internal virtual GetModelsResponse GetModels(GetModelsRequest request)
        {
            var marshaller = GetModelsRequestMarshaller.Instance;
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return Invoke<GetModelsRequest,GetModelsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModels operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetModelsResponse> GetModelsAsync(GetModelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetModelsRequestMarshaller.Instance;
            var unmarshaller = GetModelsResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelsRequest,GetModelsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetModelTemplate

        internal virtual GetModelTemplateResponse GetModelTemplate(GetModelTemplateRequest request)
        {
            var marshaller = GetModelTemplateRequestMarshaller.Instance;
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return Invoke<GetModelTemplateRequest,GetModelTemplateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetModelTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetModelTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetModelTemplateResponse> GetModelTemplateAsync(GetModelTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetModelTemplateRequestMarshaller.Instance;
            var unmarshaller = GetModelTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetModelTemplateRequest,GetModelTemplateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRequestValidator

        internal virtual GetRequestValidatorResponse GetRequestValidator(GetRequestValidatorRequest request)
        {
            var marshaller = GetRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<GetRequestValidatorRequest,GetRequestValidatorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRequestValidatorResponse> GetRequestValidatorAsync(GetRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorResponseUnmarshaller.Instance;

            return InvokeAsync<GetRequestValidatorRequest,GetRequestValidatorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRequestValidators

        internal virtual GetRequestValidatorsResponse GetRequestValidators(GetRequestValidatorsRequest request)
        {
            var marshaller = GetRequestValidatorsRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorsResponseUnmarshaller.Instance;

            return Invoke<GetRequestValidatorsRequest,GetRequestValidatorsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRequestValidators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRequestValidators operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRequestValidatorsResponse> GetRequestValidatorsAsync(GetRequestValidatorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRequestValidatorsRequestMarshaller.Instance;
            var unmarshaller = GetRequestValidatorsResponseUnmarshaller.Instance;

            return InvokeAsync<GetRequestValidatorsRequest,GetRequestValidatorsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResource

        internal virtual GetResourceResponse GetResource(GetResourceRequest request)
        {
            var marshaller = GetResourceRequestMarshaller.Instance;
            var unmarshaller = GetResourceResponseUnmarshaller.Instance;

            return Invoke<GetResourceRequest,GetResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetResourceResponse> GetResourceAsync(GetResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourceRequestMarshaller.Instance;
            var unmarshaller = GetResourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourceRequest,GetResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetResources

        internal virtual GetResourcesResponse GetResources(GetResourcesRequest request)
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return Invoke<GetResourcesRequest,GetResourcesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetResourcesResponse> GetResourcesAsync(GetResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetResourcesRequestMarshaller.Instance;
            var unmarshaller = GetResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesRequest,GetResourcesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRestApi

        internal virtual GetRestApiResponse GetRestApi(GetRestApiRequest request)
        {
            var marshaller = GetRestApiRequestMarshaller.Instance;
            var unmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return Invoke<GetRestApiRequest,GetRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRestApiResponse> GetRestApiAsync(GetRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRestApiRequestMarshaller.Instance;
            var unmarshaller = GetRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<GetRestApiRequest,GetRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetRestApis

        internal virtual GetRestApisResponse GetRestApis(GetRestApisRequest request)
        {
            var marshaller = GetRestApisRequestMarshaller.Instance;
            var unmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return Invoke<GetRestApisRequest,GetRestApisResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRestApis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRestApis operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetRestApisResponse> GetRestApisAsync(GetRestApisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetRestApisRequestMarshaller.Instance;
            var unmarshaller = GetRestApisResponseUnmarshaller.Instance;

            return InvokeAsync<GetRestApisRequest,GetRestApisResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSdk

        internal virtual GetSdkResponse GetSdk(GetSdkRequest request)
        {
            var marshaller = GetSdkRequestMarshaller.Instance;
            var unmarshaller = GetSdkResponseUnmarshaller.Instance;

            return Invoke<GetSdkRequest,GetSdkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSdk operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdk operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSdkResponse> GetSdkAsync(GetSdkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSdkRequestMarshaller.Instance;
            var unmarshaller = GetSdkResponseUnmarshaller.Instance;

            return InvokeAsync<GetSdkRequest,GetSdkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSdkType

        internal virtual GetSdkTypeResponse GetSdkType(GetSdkTypeRequest request)
        {
            var marshaller = GetSdkTypeRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypeResponseUnmarshaller.Instance;

            return Invoke<GetSdkTypeRequest,GetSdkTypeResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSdkType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdkType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSdkTypeResponse> GetSdkTypeAsync(GetSdkTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSdkTypeRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypeResponseUnmarshaller.Instance;

            return InvokeAsync<GetSdkTypeRequest,GetSdkTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetSdkTypes

        internal virtual GetSdkTypesResponse GetSdkTypes(GetSdkTypesRequest request)
        {
            var marshaller = GetSdkTypesRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypesResponseUnmarshaller.Instance;

            return Invoke<GetSdkTypesRequest,GetSdkTypesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSdkTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSdkTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetSdkTypesResponse> GetSdkTypesAsync(GetSdkTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetSdkTypesRequestMarshaller.Instance;
            var unmarshaller = GetSdkTypesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSdkTypesRequest,GetSdkTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStage

        internal virtual GetStageResponse GetStage(GetStageRequest request)
        {
            var marshaller = GetStageRequestMarshaller.Instance;
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return Invoke<GetStageRequest,GetStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetStageResponse> GetStageAsync(GetStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetStageRequestMarshaller.Instance;
            var unmarshaller = GetStageResponseUnmarshaller.Instance;

            return InvokeAsync<GetStageRequest,GetStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetStages

        internal virtual GetStagesResponse GetStages(GetStagesRequest request)
        {
            var marshaller = GetStagesRequestMarshaller.Instance;
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return Invoke<GetStagesRequest,GetStagesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetStages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetStages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetStagesResponse> GetStagesAsync(GetStagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetStagesRequestMarshaller.Instance;
            var unmarshaller = GetStagesResponseUnmarshaller.Instance;

            return InvokeAsync<GetStagesRequest,GetStagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetTags

        internal virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var marshaller = GetTagsRequestMarshaller.Instance;
            var unmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsRequest,GetTagsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetTagsRequestMarshaller.Instance;
            var unmarshaller = GetTagsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagsRequest,GetTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUsage

        internal virtual GetUsageResponse GetUsage(GetUsageRequest request)
        {
            var marshaller = GetUsageRequestMarshaller.Instance;
            var unmarshaller = GetUsageResponseUnmarshaller.Instance;

            return Invoke<GetUsageRequest,GetUsageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUsageResponse> GetUsageAsync(GetUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUsageRequestMarshaller.Instance;
            var unmarshaller = GetUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsageRequest,GetUsageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUsagePlan

        internal virtual GetUsagePlanResponse GetUsagePlan(GetUsagePlanRequest request)
        {
            var marshaller = GetUsagePlanRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanRequest,GetUsagePlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUsagePlanResponse> GetUsagePlanAsync(GetUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUsagePlanRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsagePlanRequest,GetUsagePlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUsagePlanKey

        internal virtual GetUsagePlanKeyResponse GetUsagePlanKey(GetUsagePlanKeyRequest request)
        {
            var marshaller = GetUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeyResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanKeyRequest,GetUsagePlanKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlanKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUsagePlanKeyResponse> GetUsagePlanKeyAsync(GetUsagePlanKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUsagePlanKeyRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeyResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsagePlanKeyRequest,GetUsagePlanKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUsagePlanKeys

        internal virtual GetUsagePlanKeysResponse GetUsagePlanKeys(GetUsagePlanKeysRequest request)
        {
            var marshaller = GetUsagePlanKeysRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeysResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlanKeysRequest,GetUsagePlanKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlanKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlanKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUsagePlanKeysResponse> GetUsagePlanKeysAsync(GetUsagePlanKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUsagePlanKeysRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlanKeysResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsagePlanKeysRequest,GetUsagePlanKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetUsagePlans

        internal virtual GetUsagePlansResponse GetUsagePlans(GetUsagePlansRequest request)
        {
            var marshaller = GetUsagePlansRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlansResponseUnmarshaller.Instance;

            return Invoke<GetUsagePlansRequest,GetUsagePlansResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUsagePlans operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUsagePlans operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetUsagePlansResponse> GetUsagePlansAsync(GetUsagePlansRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetUsagePlansRequestMarshaller.Instance;
            var unmarshaller = GetUsagePlansResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsagePlansRequest,GetUsagePlansResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetVpcLink

        internal virtual GetVpcLinkResponse GetVpcLink(GetVpcLinkRequest request)
        {
            var marshaller = GetVpcLinkRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinkRequest,GetVpcLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetVpcLinkResponse> GetVpcLinkAsync(GetVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetVpcLinkRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<GetVpcLinkRequest,GetVpcLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetVpcLinks

        internal virtual GetVpcLinksResponse GetVpcLinks(GetVpcLinksRequest request)
        {
            var marshaller = GetVpcLinksRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return Invoke<GetVpcLinksRequest,GetVpcLinksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcLinks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetVpcLinksResponse> GetVpcLinksAsync(GetVpcLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetVpcLinksRequestMarshaller.Instance;
            var unmarshaller = GetVpcLinksResponseUnmarshaller.Instance;

            return InvokeAsync<GetVpcLinksRequest,GetVpcLinksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportApiKeys

        internal virtual ImportApiKeysResponse ImportApiKeys(ImportApiKeysRequest request)
        {
            var marshaller = ImportApiKeysRequestMarshaller.Instance;
            var unmarshaller = ImportApiKeysResponseUnmarshaller.Instance;

            return Invoke<ImportApiKeysRequest,ImportApiKeysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportApiKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportApiKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ImportApiKeysResponse> ImportApiKeysAsync(ImportApiKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportApiKeysRequestMarshaller.Instance;
            var unmarshaller = ImportApiKeysResponseUnmarshaller.Instance;

            return InvokeAsync<ImportApiKeysRequest,ImportApiKeysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportDocumentationParts

        internal virtual ImportDocumentationPartsResponse ImportDocumentationParts(ImportDocumentationPartsRequest request)
        {
            var marshaller = ImportDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = ImportDocumentationPartsResponseUnmarshaller.Instance;

            return Invoke<ImportDocumentationPartsRequest,ImportDocumentationPartsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportDocumentationParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportDocumentationParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ImportDocumentationPartsResponse> ImportDocumentationPartsAsync(ImportDocumentationPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportDocumentationPartsRequestMarshaller.Instance;
            var unmarshaller = ImportDocumentationPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ImportDocumentationPartsRequest,ImportDocumentationPartsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportRestApi

        internal virtual ImportRestApiResponse ImportRestApi(ImportRestApiRequest request)
        {
            var marshaller = ImportRestApiRequestMarshaller.Instance;
            var unmarshaller = ImportRestApiResponseUnmarshaller.Instance;

            return Invoke<ImportRestApiRequest,ImportRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ImportRestApiResponse> ImportRestApiAsync(ImportRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ImportRestApiRequestMarshaller.Instance;
            var unmarshaller = ImportRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<ImportRestApiRequest,ImportRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutGatewayResponse

        internal virtual PutGatewayResponseResponse PutGatewayResponse(PutGatewayResponseRequest request)
        {
            var marshaller = PutGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = PutGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<PutGatewayResponseRequest,PutGatewayResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGatewayResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutGatewayResponseResponse> PutGatewayResponseAsync(PutGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = PutGatewayResponseResponseUnmarshaller.Instance;

            return InvokeAsync<PutGatewayResponseRequest,PutGatewayResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutIntegration

        internal virtual PutIntegrationResponse PutIntegration(PutIntegrationRequest request)
        {
            var marshaller = PutIntegrationRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationRequest,PutIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutIntegrationRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntegrationRequest,PutIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutIntegrationResponse

        internal virtual PutIntegrationResponseResponse PutIntegrationResponse(PutIntegrationResponseRequest request)
        {
            var marshaller = PutIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<PutIntegrationResponseRequest,PutIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutIntegrationResponseResponse> PutIntegrationResponseAsync(PutIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = PutIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<PutIntegrationResponseRequest,PutIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMethod

        internal virtual PutMethodResponse PutMethod(PutMethodRequest request)
        {
            var marshaller = PutMethodRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseUnmarshaller.Instance;

            return Invoke<PutMethodRequest,PutMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutMethodResponse> PutMethodAsync(PutMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutMethodRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseUnmarshaller.Instance;

            return InvokeAsync<PutMethodRequest,PutMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutMethodResponse

        internal virtual PutMethodResponseResponse PutMethodResponse(PutMethodResponseRequest request)
        {
            var marshaller = PutMethodResponseRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return Invoke<PutMethodResponseRequest,PutMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutMethodResponseResponse> PutMethodResponseAsync(PutMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutMethodResponseRequestMarshaller.Instance;
            var unmarshaller = PutMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<PutMethodResponseRequest,PutMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutRestApi

        internal virtual PutRestApiResponse PutRestApi(PutRestApiRequest request)
        {
            var marshaller = PutRestApiRequestMarshaller.Instance;
            var unmarshaller = PutRestApiResponseUnmarshaller.Instance;

            return Invoke<PutRestApiRequest,PutRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutRestApiResponse> PutRestApiAsync(PutRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = PutRestApiRequestMarshaller.Instance;
            var unmarshaller = PutRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<PutRestApiRequest,PutRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceRequest,TagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TagResourceRequestMarshaller.Instance;
            var unmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceRequest,TagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestInvokeAuthorizer

        internal virtual TestInvokeAuthorizerResponse TestInvokeAuthorizer(TestInvokeAuthorizerRequest request)
        {
            var marshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            var unmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return Invoke<TestInvokeAuthorizerRequest,TestInvokeAuthorizerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<TestInvokeAuthorizerResponse> TestInvokeAuthorizerAsync(TestInvokeAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TestInvokeAuthorizerRequestMarshaller.Instance;
            var unmarshaller = TestInvokeAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<TestInvokeAuthorizerRequest,TestInvokeAuthorizerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TestInvokeMethod

        internal virtual TestInvokeMethodResponse TestInvokeMethod(TestInvokeMethodRequest request)
        {
            var marshaller = TestInvokeMethodRequestMarshaller.Instance;
            var unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return Invoke<TestInvokeMethodRequest,TestInvokeMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TestInvokeMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestInvokeMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<TestInvokeMethodResponse> TestInvokeMethodAsync(TestInvokeMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = TestInvokeMethodRequestMarshaller.Instance;
            var unmarshaller = TestInvokeMethodResponseUnmarshaller.Instance;

            return InvokeAsync<TestInvokeMethodRequest,TestInvokeMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceRequest,UntagResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UntagResourceRequestMarshaller.Instance;
            var unmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceRequest,UntagResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccount

        internal virtual UpdateAccountResponse UpdateAccount(UpdateAccountRequest request)
        {
            var marshaller = UpdateAccountRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateAccountResponse> UpdateAccountAsync(UpdateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAccountRequestMarshaller.Instance;
            var unmarshaller = UpdateAccountResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountRequest,UpdateAccountResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateApiKey

        internal virtual UpdateApiKeyResponse UpdateApiKey(UpdateApiKeyRequest request)
        {
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return Invoke<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApiKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApiKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateApiKeyResponse> UpdateApiKeyAsync(UpdateApiKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateApiKeyRequestMarshaller.Instance;
            var unmarshaller = UpdateApiKeyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApiKeyRequest,UpdateApiKeyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuthorizer

        internal virtual UpdateAuthorizerResponse UpdateAuthorizer(UpdateAuthorizerRequest request)
        {
            var marshaller = UpdateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return Invoke<UpdateAuthorizerRequest,UpdateAuthorizerResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuthorizer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuthorizer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateAuthorizerResponse> UpdateAuthorizerAsync(UpdateAuthorizerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateAuthorizerRequestMarshaller.Instance;
            var unmarshaller = UpdateAuthorizerResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuthorizerRequest,UpdateAuthorizerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateBasePathMapping

        internal virtual UpdateBasePathMappingResponse UpdateBasePathMapping(UpdateBasePathMappingRequest request)
        {
            var marshaller = UpdateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return Invoke<UpdateBasePathMappingRequest,UpdateBasePathMappingResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBasePathMapping operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBasePathMapping operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateBasePathMappingResponse> UpdateBasePathMappingAsync(UpdateBasePathMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateBasePathMappingRequestMarshaller.Instance;
            var unmarshaller = UpdateBasePathMappingResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBasePathMappingRequest,UpdateBasePathMappingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateClientCertificate

        internal virtual UpdateClientCertificateResponse UpdateClientCertificate(UpdateClientCertificateRequest request)
        {
            var marshaller = UpdateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return Invoke<UpdateClientCertificateRequest,UpdateClientCertificateResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateClientCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateClientCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateClientCertificateResponse> UpdateClientCertificateAsync(UpdateClientCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateClientCertificateRequestMarshaller.Instance;
            var unmarshaller = UpdateClientCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateClientCertificateRequest,UpdateClientCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeployment

        internal virtual UpdateDeploymentResponse UpdateDeployment(UpdateDeploymentRequest request)
        {
            var marshaller = UpdateDeploymentRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return Invoke<UpdateDeploymentRequest,UpdateDeploymentResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeployment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateDeploymentResponse> UpdateDeploymentAsync(UpdateDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDeploymentRequestMarshaller.Instance;
            var unmarshaller = UpdateDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeploymentRequest,UpdateDeploymentResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentationPart

        internal virtual UpdateDocumentationPartResponse UpdateDocumentationPart(UpdateDocumentationPartRequest request)
        {
            var marshaller = UpdateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationPartResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentationPartRequest,UpdateDocumentationPartResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentationPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateDocumentationPartResponse> UpdateDocumentationPartAsync(UpdateDocumentationPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDocumentationPartRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationPartResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentationPartRequest,UpdateDocumentationPartResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDocumentationVersion

        internal virtual UpdateDocumentationVersionResponse UpdateDocumentationVersion(UpdateDocumentationVersionRequest request)
        {
            var marshaller = UpdateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateDocumentationVersionRequest,UpdateDocumentationVersionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDocumentationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDocumentationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateDocumentationVersionResponse> UpdateDocumentationVersionAsync(UpdateDocumentationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDocumentationVersionRequestMarshaller.Instance;
            var unmarshaller = UpdateDocumentationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDocumentationVersionRequest,UpdateDocumentationVersionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDomainName

        internal virtual UpdateDomainNameResponse UpdateDomainName(UpdateDomainNameRequest request)
        {
            var marshaller = UpdateDomainNameRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return Invoke<UpdateDomainNameRequest,UpdateDomainNameResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDomainName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDomainName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateDomainNameResponse> UpdateDomainNameAsync(UpdateDomainNameRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDomainNameRequestMarshaller.Instance;
            var unmarshaller = UpdateDomainNameResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDomainNameRequest,UpdateDomainNameResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateGatewayResponse

        internal virtual UpdateGatewayResponseResponse UpdateGatewayResponse(UpdateGatewayResponseRequest request)
        {
            var marshaller = UpdateGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewayResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateGatewayResponseRequest,UpdateGatewayResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGatewayResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGatewayResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateGatewayResponseResponse> UpdateGatewayResponseAsync(UpdateGatewayResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateGatewayResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateGatewayResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGatewayResponseRequest,UpdateGatewayResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegration

        internal virtual UpdateIntegrationResponse UpdateIntegration(UpdateIntegrationRequest request)
        {
            var marshaller = UpdateIntegrationRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationRequest,UpdateIntegrationResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateIntegrationResponse> UpdateIntegrationAsync(UpdateIntegrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateIntegrationRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationRequest,UpdateIntegrationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateIntegrationResponse

        internal virtual UpdateIntegrationResponseResponse UpdateIntegrationResponse(UpdateIntegrationResponseRequest request)
        {
            var marshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateIntegrationResponseRequest,UpdateIntegrationResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIntegrationResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntegrationResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateIntegrationResponseResponse> UpdateIntegrationResponseAsync(UpdateIntegrationResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateIntegrationResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateIntegrationResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIntegrationResponseRequest,UpdateIntegrationResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMethod

        internal virtual UpdateMethodResponse UpdateMethod(UpdateMethodRequest request)
        {
            var marshaller = UpdateMethodRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodRequest,UpdateMethodResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateMethodResponse> UpdateMethodAsync(UpdateMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateMethodRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMethodRequest,UpdateMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateMethodResponse

        internal virtual UpdateMethodResponseResponse UpdateMethodResponse(UpdateMethodResponseRequest request)
        {
            var marshaller = UpdateMethodResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return Invoke<UpdateMethodResponseRequest,UpdateMethodResponseResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMethodResponse operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMethodResponse operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateMethodResponseResponse> UpdateMethodResponseAsync(UpdateMethodResponseRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateMethodResponseRequestMarshaller.Instance;
            var unmarshaller = UpdateMethodResponseResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMethodResponseRequest,UpdateMethodResponseResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateModel

        internal virtual UpdateModelResponse UpdateModel(UpdateModelRequest request)
        {
            var marshaller = UpdateModelRequestMarshaller.Instance;
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return Invoke<UpdateModelRequest,UpdateModelResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateModel operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateModelResponse> UpdateModelAsync(UpdateModelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateModelRequestMarshaller.Instance;
            var unmarshaller = UpdateModelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateModelRequest,UpdateModelResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRequestValidator

        internal virtual UpdateRequestValidatorResponse UpdateRequestValidator(UpdateRequestValidatorRequest request)
        {
            var marshaller = UpdateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = UpdateRequestValidatorResponseUnmarshaller.Instance;

            return Invoke<UpdateRequestValidatorRequest,UpdateRequestValidatorResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRequestValidator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRequestValidator operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateRequestValidatorResponse> UpdateRequestValidatorAsync(UpdateRequestValidatorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRequestValidatorRequestMarshaller.Instance;
            var unmarshaller = UpdateRequestValidatorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRequestValidatorRequest,UpdateRequestValidatorResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateResource

        internal virtual UpdateResourceResponse UpdateResource(UpdateResourceRequest request)
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateResourceResponse> UpdateResourceAsync(UpdateResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateResourceRequestMarshaller.Instance;
            var unmarshaller = UpdateResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResourceRequest,UpdateResourceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRestApi

        internal virtual UpdateRestApiResponse UpdateRestApi(UpdateRestApiRequest request)
        {
            var marshaller = UpdateRestApiRequestMarshaller.Instance;
            var unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return Invoke<UpdateRestApiRequest,UpdateRestApiResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRestApi operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRestApi operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateRestApiResponse> UpdateRestApiAsync(UpdateRestApiRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRestApiRequestMarshaller.Instance;
            var unmarshaller = UpdateRestApiResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRestApiRequest,UpdateRestApiResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateStage

        internal virtual UpdateStageResponse UpdateStage(UpdateStageRequest request)
        {
            var marshaller = UpdateStageRequestMarshaller.Instance;
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return Invoke<UpdateStageRequest,UpdateStageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateStageResponse> UpdateStageAsync(UpdateStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateStageRequestMarshaller.Instance;
            var unmarshaller = UpdateStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateStageRequest,UpdateStageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUsage

        internal virtual UpdateUsageResponse UpdateUsage(UpdateUsageRequest request)
        {
            var marshaller = UpdateUsageRequestMarshaller.Instance;
            var unmarshaller = UpdateUsageResponseUnmarshaller.Instance;

            return Invoke<UpdateUsageRequest,UpdateUsageResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateUsageResponse> UpdateUsageAsync(UpdateUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUsageRequestMarshaller.Instance;
            var unmarshaller = UpdateUsageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUsageRequest,UpdateUsageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateUsagePlan

        internal virtual UpdateUsagePlanResponse UpdateUsagePlan(UpdateUsagePlanRequest request)
        {
            var marshaller = UpdateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = UpdateUsagePlanResponseUnmarshaller.Instance;

            return Invoke<UpdateUsagePlanRequest,UpdateUsagePlanResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUsagePlan operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUsagePlan operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateUsagePlanResponse> UpdateUsagePlanAsync(UpdateUsagePlanRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateUsagePlanRequestMarshaller.Instance;
            var unmarshaller = UpdateUsagePlanResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateUsagePlanRequest,UpdateUsagePlanResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateVpcLink

        internal virtual UpdateVpcLinkResponse UpdateVpcLink(UpdateVpcLinkRequest request)
        {
            var marshaller = UpdateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcLinkRequest,UpdateVpcLinkResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UpdateVpcLinkResponse> UpdateVpcLinkAsync(UpdateVpcLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateVpcLinkRequestMarshaller.Instance;
            var unmarshaller = UpdateVpcLinkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVpcLinkRequest,UpdateVpcLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}