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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ResilienceHub.Model;
using Amazon.ResilienceHub.Model.Internal.MarshallTransformations;
using Amazon.ResilienceHub.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ResilienceHub
{
    /// <summary>
    /// Implementation for accessing ResilienceHub
    ///
    /// AWS Resilience Hub helps you proactively prepare and protect your Amazon Web Services
    /// applications from disruptions. Resilience Hub offers continuous resiliency assessment
    /// and validation that integrates into your software development lifecycle. This enables
    /// you to uncover resiliency weaknesses, ensure recovery time objective (RTO) and recovery
    /// point objective (RPO) targets for your applications are met, and resolve issues before
    /// they are released into production.
    /// </summary>
    public partial class AmazonResilienceHubClient : AmazonServiceClient, IAmazonResilienceHub
    {
        private static IServiceMetadata serviceMetadata = new AmazonResilienceHubMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonResilienceHubClient with the credentials loaded from the application's
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
        public AmazonResilienceHubClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResilienceHubConfig()) { }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with the credentials loaded from the application's
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
        public AmazonResilienceHubClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonResilienceHubConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(AmazonResilienceHubConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonResilienceHubClient(AWSCredentials credentials)
            : this(credentials, new AmazonResilienceHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResilienceHubClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonResilienceHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Credentials and an
        /// AmazonResilienceHubClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(AWSCredentials credentials, AmazonResilienceHubConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResilienceHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonResilienceHubConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResilienceHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonResilienceHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResilienceHubConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonResilienceHubConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonResilienceHubClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonResilienceHubClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonResilienceHubClient Configuration Object</param>
        public AmazonResilienceHubClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonResilienceHubConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IResilienceHubPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IResilienceHubPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ResilienceHubPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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


        #region  AddDraftAppVersionResourceMappings

        internal virtual AddDraftAppVersionResourceMappingsResponse AddDraftAppVersionResourceMappings(AddDraftAppVersionResourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return Invoke<AddDraftAppVersionResourceMappingsResponse>(request, options);
        }



        /// <summary>
        /// Adds the resource mapping for the draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddDraftAppVersionResourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/AddDraftAppVersionResourceMappings">REST API Reference for AddDraftAppVersionResourceMappings Operation</seealso>
        public virtual Task<AddDraftAppVersionResourceMappingsResponse> AddDraftAppVersionResourceMappingsAsync(AddDraftAppVersionResourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<AddDraftAppVersionResourceMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApp

        internal virtual CreateAppResponse CreateApp(CreateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return Invoke<CreateAppResponse>(request, options);
        }



        /// <summary>
        /// Creates a Resilience Hub application. A Resilience Hub application is a collection
        /// of Amazon Web Services resources structured to prevent and recover Amazon Web Services
        /// application disruptions. To describe a Resilience Hub application, you provide an
        /// application name, resources from one or more–up to five–CloudFormation stacks, and
        /// an appropriate resiliency policy.
        /// 
        ///  <pre><code> &lt;p&gt;After you create a Resilience Hub application, you publish it
        /// so that you can run a resiliency assessment on it. You can then use recommendations
        /// from the assessment to improve resiliency by running another assessment, comparing
        /// results, and then iterating the process until you achieve your goals for recovery
        /// time objective (RTO) and recovery point objective (RPO).&lt;/p&gt; </code></pre>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateApp">REST API Reference for CreateApp Operation</seealso>
        public virtual Task<CreateAppResponse> CreateAppAsync(CreateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAppResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRecommendationTemplate

        internal virtual CreateRecommendationTemplateResponse CreateRecommendationTemplate(CreateRecommendationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommendationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateRecommendationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new recommendation template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRecommendationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateRecommendationTemplate">REST API Reference for CreateRecommendationTemplate Operation</seealso>
        public virtual Task<CreateRecommendationTemplateResponse> CreateRecommendationTemplateAsync(CreateRecommendationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRecommendationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRecommendationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateResiliencyPolicy

        internal virtual CreateResiliencyPolicyResponse CreateResiliencyPolicy(CreateResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateResiliencyPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a resiliency policy for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/CreateResiliencyPolicy">REST API Reference for CreateResiliencyPolicy Operation</seealso>
        public virtual Task<CreateResiliencyPolicyResponse> CreateResiliencyPolicyAsync(CreateResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateResiliencyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateResiliencyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApp

        internal virtual DeleteAppResponse DeleteApp(DeleteAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return Invoke<DeleteAppResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AWS Resilience Hub application. This is a destructive action that can't
        /// be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteApp">REST API Reference for DeleteApp Operation</seealso>
        public virtual Task<DeleteAppResponse> DeleteAppAsync(DeleteAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAppAssessment

        internal virtual DeleteAppAssessmentResponse DeleteAppAssessment(DeleteAppAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppAssessmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAppAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an AWS Resilience Hub application assessment. This is a destructive action
        /// that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAppAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteAppAssessment">REST API Reference for DeleteAppAssessment Operation</seealso>
        public virtual Task<DeleteAppAssessmentResponse> DeleteAppAssessmentAsync(DeleteAppAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAppAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAppAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRecommendationTemplate

        internal virtual DeleteRecommendationTemplateResponse DeleteRecommendationTemplate(DeleteRecommendationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteRecommendationTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a recommendation template. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRecommendationTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRecommendationTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteRecommendationTemplate">REST API Reference for DeleteRecommendationTemplate Operation</seealso>
        public virtual Task<DeleteRecommendationTemplateResponse> DeleteRecommendationTemplateAsync(DeleteRecommendationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRecommendationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRecommendationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRecommendationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResiliencyPolicy

        internal virtual DeleteResiliencyPolicyResponse DeleteResiliencyPolicy(DeleteResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResiliencyPolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a resiliency policy. This is a destructive action that can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DeleteResiliencyPolicy">REST API Reference for DeleteResiliencyPolicy Operation</seealso>
        public virtual Task<DeleteResiliencyPolicyResponse> DeleteResiliencyPolicyAsync(DeleteResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResiliencyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResiliencyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApp

        internal virtual DescribeAppResponse DescribeApp(DescribeAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return Invoke<DescribeAppResponse>(request, options);
        }



        /// <summary>
        /// Describes an AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeApp">REST API Reference for DescribeApp Operation</seealso>
        public virtual Task<DescribeAppResponse> DescribeAppAsync(DescribeAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppAssessment

        internal virtual DescribeAppAssessmentResponse DescribeAppAssessment(DescribeAppAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppAssessmentResponseUnmarshaller.Instance;

            return Invoke<DescribeAppAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Describes an assessment for an AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppAssessment">REST API Reference for DescribeAppAssessment Operation</seealso>
        public virtual Task<DescribeAppAssessmentResponse> DescribeAppAssessmentAsync(DescribeAppAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppVersionResourcesResolutionStatus

        internal virtual DescribeAppVersionResourcesResolutionStatusResponse DescribeAppVersionResourcesResolutionStatus(DescribeAppVersionResourcesResolutionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionResourcesResolutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResourcesResolutionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionResourcesResolutionStatusResponse>(request, options);
        }



        /// <summary>
        /// Returns the resolution status for the specified resolution identifier for an application
        /// version. If <code>resolutionId</code> is not specified, the current resolution status
        /// is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionResourcesResolutionStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppVersionResourcesResolutionStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionResourcesResolutionStatus">REST API Reference for DescribeAppVersionResourcesResolutionStatus Operation</seealso>
        public virtual Task<DescribeAppVersionResourcesResolutionStatusResponse> DescribeAppVersionResourcesResolutionStatusAsync(DescribeAppVersionResourcesResolutionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionResourcesResolutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionResourcesResolutionStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppVersionResourcesResolutionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAppVersionTemplate

        internal virtual DescribeAppVersionTemplateResponse DescribeAppVersionTemplate(DescribeAppVersionTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionTemplateResponseUnmarshaller.Instance;

            return Invoke<DescribeAppVersionTemplateResponse>(request, options);
        }



        /// <summary>
        /// Describes details about an AWS Resilience Hub
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAppVersionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeAppVersionTemplate">REST API Reference for DescribeAppVersionTemplate Operation</seealso>
        public virtual Task<DescribeAppVersionTemplateResponse> DescribeAppVersionTemplateAsync(DescribeAppVersionTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAppVersionTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAppVersionTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDraftAppVersionResourcesImportStatus

        internal virtual DescribeDraftAppVersionResourcesImportStatusResponse DescribeDraftAppVersionResourcesImportStatus(DescribeDraftAppVersionResourcesImportStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDraftAppVersionResourcesImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDraftAppVersionResourcesImportStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeDraftAppVersionResourcesImportStatusResponse>(request, options);
        }



        /// <summary>
        /// Describes the status of importing resources to an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDraftAppVersionResourcesImportStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDraftAppVersionResourcesImportStatus service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeDraftAppVersionResourcesImportStatus">REST API Reference for DescribeDraftAppVersionResourcesImportStatus Operation</seealso>
        public virtual Task<DescribeDraftAppVersionResourcesImportStatusResponse> DescribeDraftAppVersionResourcesImportStatusAsync(DescribeDraftAppVersionResourcesImportStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDraftAppVersionResourcesImportStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDraftAppVersionResourcesImportStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDraftAppVersionResourcesImportStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResiliencyPolicy

        internal virtual DescribeResiliencyPolicyResponse DescribeResiliencyPolicy(DescribeResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<DescribeResiliencyPolicyResponse>(request, options);
        }



        /// <summary>
        /// Describes a specified resiliency policy for an AWS Resilience Hub application. The
        /// returned policy object includes creation time, data location constraints, the Amazon
        /// Resource Name (ARN) for the policy, tags, tier, and more.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/DescribeResiliencyPolicy">REST API Reference for DescribeResiliencyPolicy Operation</seealso>
        public virtual Task<DescribeResiliencyPolicyResponse> DescribeResiliencyPolicyAsync(DescribeResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResiliencyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResiliencyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportResourcesToDraftAppVersion

        internal virtual ImportResourcesToDraftAppVersionResponse ImportResourcesToDraftAppVersion(ImportResourcesToDraftAppVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportResourcesToDraftAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportResourcesToDraftAppVersionResponseUnmarshaller.Instance;

            return Invoke<ImportResourcesToDraftAppVersionResponse>(request, options);
        }



        /// <summary>
        /// Imports resources from sources such as a CloudFormation stack, resource-groups, or
        /// application registry app to a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportResourcesToDraftAppVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportResourcesToDraftAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ImportResourcesToDraftAppVersion">REST API Reference for ImportResourcesToDraftAppVersion Operation</seealso>
        public virtual Task<ImportResourcesToDraftAppVersionResponse> ImportResourcesToDraftAppVersionAsync(ImportResourcesToDraftAppVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportResourcesToDraftAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportResourcesToDraftAppVersionResponseUnmarshaller.Instance;

            return InvokeAsync<ImportResourcesToDraftAppVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAlarmRecommendations

        internal virtual ListAlarmRecommendationsResponse ListAlarmRecommendations(ListAlarmRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlarmRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListAlarmRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the alarm recommendations for a AWS Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlarmRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAlarmRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAlarmRecommendations">REST API Reference for ListAlarmRecommendations Operation</seealso>
        public virtual Task<ListAlarmRecommendationsResponse> ListAlarmRecommendationsAsync(ListAlarmRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAlarmRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAlarmRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAlarmRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppAssessments

        internal virtual ListAppAssessmentsResponse ListAppAssessments(ListAppAssessmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppAssessmentsResponseUnmarshaller.Instance;

            return Invoke<ListAppAssessmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the assessments for an AWS Resilience Hub application. You can use request parameters
        /// to refine the results for the response object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppAssessments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppAssessments service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppAssessments">REST API Reference for ListAppAssessments Operation</seealso>
        public virtual Task<ListAppAssessmentsResponse> ListAppAssessmentsAsync(ListAppAssessmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppAssessmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppAssessmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppAssessmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppComponentCompliances

        internal virtual ListAppComponentCompliancesResponse ListAppComponentCompliances(ListAppComponentCompliancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentCompliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentCompliancesResponseUnmarshaller.Instance;

            return Invoke<ListAppComponentCompliancesResponse>(request, options);
        }



        /// <summary>
        /// Lists the compliances for an AWS Resilience Hub component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentCompliances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppComponentCompliances service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentCompliances">REST API Reference for ListAppComponentCompliances Operation</seealso>
        public virtual Task<ListAppComponentCompliancesResponse> ListAppComponentCompliancesAsync(ListAppComponentCompliancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentCompliancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentCompliancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppComponentCompliancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppComponentRecommendations

        internal virtual ListAppComponentRecommendationsResponse ListAppComponentRecommendations(ListAppComponentRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListAppComponentRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the recommendations for an AWS Resilience Hub component.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppComponentRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppComponentRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppComponentRecommendations">REST API Reference for ListAppComponentRecommendations Operation</seealso>
        public virtual Task<ListAppComponentRecommendationsResponse> ListAppComponentRecommendationsAsync(ListAppComponentRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppComponentRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppComponentRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppComponentRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListApps

        internal virtual ListAppsResponse ListApps(ListAppsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return Invoke<ListAppsResponse>(request, options);
        }



        /// <summary>
        /// Lists your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApps service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApps service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListApps">REST API Reference for ListApps Operation</seealso>
        public virtual Task<ListAppsResponse> ListAppsAsync(ListAppsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppVersionResourceMappings

        internal virtual ListAppVersionResourceMappingsResponse ListAppVersionResourceMappings(ListAppVersionResourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionResourceMappingsResponse>(request, options);
        }



        /// <summary>
        /// Lists how the resources in an application version are mapped/sourced from. Mappings
        /// can be physical resource identifiers, CloudFormation stacks, resource-groups, or an
        /// application registry app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResourceMappings">REST API Reference for ListAppVersionResourceMappings Operation</seealso>
        public virtual Task<ListAppVersionResourceMappingsResponse> ListAppVersionResourceMappingsAsync(ListAppVersionResourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppVersionResourceMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppVersionResources

        internal virtual ListAppVersionResourcesResponse ListAppVersionResources(ListAppVersionResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the resources in an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersionResources">REST API Reference for ListAppVersionResources Operation</seealso>
        public virtual Task<ListAppVersionResourcesResponse> ListAppVersionResourcesAsync(ListAppVersionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppVersionResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAppVersions

        internal virtual ListAppVersionsResponse ListAppVersions(ListAppVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionsResponseUnmarshaller.Instance;

            return Invoke<ListAppVersionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the different versions for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAppVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAppVersions service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListAppVersions">REST API Reference for ListAppVersions Operation</seealso>
        public virtual Task<ListAppVersionsResponse> ListAppVersionsAsync(ListAppVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAppVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAppVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAppVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRecommendationTemplates

        internal virtual ListRecommendationTemplatesResponse ListRecommendationTemplates(ListRecommendationTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListRecommendationTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists the recommendation templates for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecommendationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRecommendationTemplates service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListRecommendationTemplates">REST API Reference for ListRecommendationTemplates Operation</seealso>
        public virtual Task<ListRecommendationTemplatesResponse> ListRecommendationTemplatesAsync(ListRecommendationTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRecommendationTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRecommendationTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRecommendationTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResiliencyPolicies

        internal virtual ListResiliencyPoliciesResponse ListResiliencyPolicies(ListResiliencyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResiliencyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResiliencyPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResiliencyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListResiliencyPolicies">REST API Reference for ListResiliencyPolicies Operation</seealso>
        public virtual Task<ListResiliencyPoliciesResponse> ListResiliencyPoliciesAsync(ListResiliencyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResiliencyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResiliencyPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSopRecommendations

        internal virtual ListSopRecommendationsResponse ListSopRecommendations(ListSopRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSopRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSopRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListSopRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the standard operating procedure (SOP) recommendations for the Resilience Hub
        /// applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSopRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSopRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSopRecommendations">REST API Reference for ListSopRecommendations Operation</seealso>
        public virtual Task<ListSopRecommendationsResponse> ListSopRecommendationsAsync(ListSopRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSopRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSopRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSopRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSuggestedResiliencyPolicies

        internal virtual ListSuggestedResiliencyPoliciesResponse ListSuggestedResiliencyPolicies(ListSuggestedResiliencyPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuggestedResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuggestedResiliencyPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListSuggestedResiliencyPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Lists the suggested resiliency policies for the Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSuggestedResiliencyPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSuggestedResiliencyPolicies service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListSuggestedResiliencyPolicies">REST API Reference for ListSuggestedResiliencyPolicies Operation</seealso>
        public virtual Task<ListSuggestedResiliencyPoliciesResponse> ListSuggestedResiliencyPoliciesAsync(ListSuggestedResiliencyPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSuggestedResiliencyPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSuggestedResiliencyPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSuggestedResiliencyPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for your resources in your Resilience Hub applications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTestRecommendations

        internal virtual ListTestRecommendationsResponse ListTestRecommendations(ListTestRecommendationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRecommendationsResponseUnmarshaller.Instance;

            return Invoke<ListTestRecommendationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the test recommendations for the Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTestRecommendations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTestRecommendations service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListTestRecommendations">REST API Reference for ListTestRecommendations Operation</seealso>
        public virtual Task<ListTestRecommendationsResponse> ListTestRecommendationsAsync(ListTestRecommendationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTestRecommendationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTestRecommendationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTestRecommendationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUnsupportedAppVersionResources

        internal virtual ListUnsupportedAppVersionResourcesResponse ListUnsupportedAppVersionResources(ListUnsupportedAppVersionResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUnsupportedAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUnsupportedAppVersionResourcesResponseUnmarshaller.Instance;

            return Invoke<ListUnsupportedAppVersionResourcesResponse>(request, options);
        }



        /// <summary>
        /// Lists the resources that are not currently supported in AWS Resilience Hub. An unsupported
        /// resource is a resource that exists in the object that was used to create an app, but
        /// is not supported by Resilience Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUnsupportedAppVersionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUnsupportedAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ListUnsupportedAppVersionResources">REST API Reference for ListUnsupportedAppVersionResources Operation</seealso>
        public virtual Task<ListUnsupportedAppVersionResourcesResponse> ListUnsupportedAppVersionResourcesAsync(ListUnsupportedAppVersionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUnsupportedAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUnsupportedAppVersionResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListUnsupportedAppVersionResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PublishAppVersion

        internal virtual PublishAppVersionResponse PublishAppVersion(PublishAppVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishAppVersionResponseUnmarshaller.Instance;

            return Invoke<PublishAppVersionResponse>(request, options);
        }



        /// <summary>
        /// Publishes a new version of a specific Resilience Hub application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishAppVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishAppVersion service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PublishAppVersion">REST API Reference for PublishAppVersion Operation</seealso>
        public virtual Task<PublishAppVersionResponse> PublishAppVersionAsync(PublishAppVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PublishAppVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishAppVersionResponseUnmarshaller.Instance;

            return InvokeAsync<PublishAppVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDraftAppVersionTemplate

        internal virtual PutDraftAppVersionTemplateResponse PutDraftAppVersionTemplate(PutDraftAppVersionTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDraftAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDraftAppVersionTemplateResponseUnmarshaller.Instance;

            return Invoke<PutDraftAppVersionTemplateResponse>(request, options);
        }



        /// <summary>
        /// Adds or updates the app template for a draft version of a Resilience Hub app.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDraftAppVersionTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDraftAppVersionTemplate service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/PutDraftAppVersionTemplate">REST API Reference for PutDraftAppVersionTemplate Operation</seealso>
        public virtual Task<PutDraftAppVersionTemplateResponse> PutDraftAppVersionTemplateAsync(PutDraftAppVersionTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDraftAppVersionTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDraftAppVersionTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<PutDraftAppVersionTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveDraftAppVersionResourceMappings

        internal virtual RemoveDraftAppVersionResourceMappingsResponse RemoveDraftAppVersionResourceMappings(RemoveDraftAppVersionResourceMappingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return Invoke<RemoveDraftAppVersionResourceMappingsResponse>(request, options);
        }



        /// <summary>
        /// Removes resource mappings from a draft application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveDraftAppVersionResourceMappings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveDraftAppVersionResourceMappings service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/RemoveDraftAppVersionResourceMappings">REST API Reference for RemoveDraftAppVersionResourceMappings Operation</seealso>
        public virtual Task<RemoveDraftAppVersionResourceMappingsResponse> RemoveDraftAppVersionResourceMappingsAsync(RemoveDraftAppVersionResourceMappingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveDraftAppVersionResourceMappingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveDraftAppVersionResourceMappingsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveDraftAppVersionResourceMappingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResolveAppVersionResources

        internal virtual ResolveAppVersionResourcesResponse ResolveAppVersionResources(ResolveAppVersionResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAppVersionResourcesResponseUnmarshaller.Instance;

            return Invoke<ResolveAppVersionResourcesResponse>(request, options);
        }



        /// <summary>
        /// Resolves the resources for an application version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResolveAppVersionResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveAppVersionResources service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/ResolveAppVersionResources">REST API Reference for ResolveAppVersionResources Operation</seealso>
        public virtual Task<ResolveAppVersionResourcesResponse> ResolveAppVersionResourcesAsync(ResolveAppVersionResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAppVersionResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAppVersionResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveAppVersionResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartAppAssessment

        internal virtual StartAppAssessmentResponse StartAppAssessment(StartAppAssessmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppAssessmentResponseUnmarshaller.Instance;

            return Invoke<StartAppAssessmentResponse>(request, options);
        }



        /// <summary>
        /// Creates a new application assessment for an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartAppAssessment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartAppAssessment service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ServiceQuotaExceededException">
        /// You have exceeded your service quota. To perform the requested action, remove some
        /// of the relevant resources, or use Service Quotas to request a service quota increase.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/StartAppAssessment">REST API Reference for StartAppAssessment Operation</seealso>
        public virtual Task<StartAppAssessmentResponse> StartAppAssessmentAsync(StartAppAssessmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartAppAssessmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartAppAssessmentResponseUnmarshaller.Instance;

            return InvokeAsync<StartAppAssessmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Applies one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApp

        internal virtual UpdateAppResponse UpdateApp(UpdateAppRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return Invoke<UpdateAppResponse>(request, options);
        }



        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApp service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApp service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateApp">REST API Reference for UpdateApp Operation</seealso>
        public virtual Task<UpdateAppResponse> UpdateAppAsync(UpdateAppRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAppRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAppResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAppResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateResiliencyPolicy

        internal virtual UpdateResiliencyPolicyResponse UpdateResiliencyPolicy(UpdateResiliencyPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResiliencyPolicyResponseUnmarshaller.Instance;

            return Invoke<UpdateResiliencyPolicyResponse>(request, options);
        }



        /// <summary>
        /// Updates a resiliency policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateResiliencyPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateResiliencyPolicy service method, as returned by ResilienceHub.</returns>
        /// <exception cref="Amazon.ResilienceHub.Model.AccessDeniedException">
        /// You don't have permissions to perform the requested operation. The user or role that
        /// is making the request must have at least one IAM permissions policy attached that
        /// grants the required permissions.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ConflictException">
        /// Occurs when a conflict with a previous successful write is detected. This generally
        /// occurs when the previous write did not have time to propagate to the host serving
        /// the current request. A retry (with appropriate backoff logic) is the recommended response
        /// to this exception.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.InternalServerException">
        /// This exception occurs when there is an internal failure in the AWS Resilience Hub
        /// service.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ThrottlingException">
        /// The limit on the number of requests per second was exceeded.
        /// </exception>
        /// <exception cref="Amazon.ResilienceHub.Model.ValidationException">
        /// Indicates that a request was not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/resiliencehub-2020-04-30/UpdateResiliencyPolicy">REST API Reference for UpdateResiliencyPolicy Operation</seealso>
        public virtual Task<UpdateResiliencyPolicyResponse> UpdateResiliencyPolicyAsync(UpdateResiliencyPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateResiliencyPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateResiliencyPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateResiliencyPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}