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
 * Do not modify this file. This file is generated from the secretsmanager-2017-10-17.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SecretsManager.Model;
using Amazon.SecretsManager.Model.Internal.MarshallTransformations;
using Amazon.SecretsManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SecretsManager
{
    /// <summary>
    /// Implementation for accessing SecretsManager
    ///
    /// AWS Secrets Manager API Reference 
    /// <para>
    /// AWS Secrets Manager is a web service that enables you to store, manage, and retrieve,
    /// secrets.
    /// </para>
    ///  
    /// <para>
    /// This guide provides descriptions of the Secrets Manager API. For more information
    /// about using this service, see the <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/introduction.html">AWS
    /// Secrets Manager User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Version</b> 
    /// </para>
    ///  
    /// <para>
    /// This version of the Secrets Manager API Reference documents the Secrets Manager API
    /// version 2017-10-17.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to using the API directly, you can use one of the AWS SDKs, which
    /// consist of libraries and sample code for various programming languages and platforms
    /// (such as Java, Ruby, .NET, iOS, and Android). The SDKs provide a convenient way to
    /// create programmatic access to AWS Secrets Manager. For example, the SDKs take care
    /// of cryptographically signing requests, managing errors, and retrying requests automatically.
    /// For more information about the AWS SDKs, including how to download and install them,
    /// see <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to Secrets Manager.
    /// However, you also can use the Secrets Manager HTTP Query API to make direct calls
    /// to the Secrets Manager web service. To learn more about the Secrets Manager HTTP Query
    /// API, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/query-requests.html">Making
    /// Query Requests</a> in the <i>AWS Secrets Manager User Guide</i>. 
    /// </para>
    ///  
    /// <para>
    /// Secrets Manager supports GET and POST requests for all actions. That is, the API doesn't
    /// require you to use GET for some actions and POST for others. However, GET requests
    /// are subject to the limitation size of a URL. Therefore, for operations that require
    /// larger sizes, use a POST request.
    /// </para>
    ///  
    /// <para>
    ///  <b>Support and Feedback for AWS Secrets Manager</b> 
    /// </para>
    ///  
    /// <para>
    /// We welcome your feedback. Send your comments to <a href="mailto:awssecretsmanager-feedback@amazon.com">awssecretsmanager-feedback@amazon.com</a>,
    /// or post your feedback and questions in the <a href="http://forums.aws.amazon.com/forum.jspa?forumID=296">AWS
    /// Secrets Manager Discussion Forum</a>. For more information about the AWS Discussion
    /// Forums, see <a href="http://forums.aws.amazon.com/help.jspa">Forums Help</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>How examples are presented</b> 
    /// </para>
    ///  
    /// <para>
    /// The JSON that AWS Secrets Manager expects as your request parameters and that the
    /// service returns as a response to HTTP query requests are single, long strings without
    /// line breaks or white space formatting. The JSON shown in the examples is formatted
    /// with both line breaks and white space to improve readability. When example input parameters
    /// would also result in long strings that extend beyond the screen, we insert line breaks
    /// to enhance readability. You should always submit the input as a single JSON text string.
    /// </para>
    ///  
    /// <para>
    ///  <b>Logging API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS Secrets Manager supports AWS CloudTrail, a service that records AWS API calls
    /// for your AWS account and delivers log files to an Amazon S3 bucket. By using information
    /// that's collected by AWS CloudTrail, you can determine which requests were successfully
    /// made to Secrets Manager, who made the request, when it was made, and so on. For more
    /// about AWS Secrets Manager and its support for AWS CloudTrail, see <a href="http://docs.aws.amazon.com/secretsmanager/latest/userguide/monitoring.html#monitoring_cloudtrail">Logging
    /// AWS Secrets Manager Events with AWS CloudTrail</a> in the <i>AWS Secrets Manager User
    /// Guide</i>. To learn more about CloudTrail, including how to turn it on and find your
    /// log files, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonSecretsManagerClient : AmazonServiceClient, IAmazonSecretsManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonSecretsManagerMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonSecretsManagerClient with the credentials loaded from the application's
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
        public AmazonSecretsManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecretsManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with the credentials loaded from the application's
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
        public AmazonSecretsManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSecretsManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(AmazonSecretsManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSecretsManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSecretsManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSecretsManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Credentials and an
        /// AmazonSecretsManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(AWSCredentials credentials, AmazonSecretsManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecretsManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSecretsManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecretsManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecretsManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecretsManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSecretsManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSecretsManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSecretsManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSecretsManagerClient Configuration Object</param>
        public AmazonSecretsManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecretsManagerConfig clientConfig)
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


        #region  CancelRotateSecret

        internal virtual CancelRotateSecretResponse CancelRotateSecret(CancelRotateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRotateSecretResponseUnmarshaller.Instance;

            return Invoke<CancelRotateSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelRotateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelRotateSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CancelRotateSecret">REST API Reference for CancelRotateSecret Operation</seealso>
        public virtual Task<CancelRotateSecretResponse> CancelRotateSecretAsync(CancelRotateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelRotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelRotateSecretResponseUnmarshaller.Instance;

            return InvokeAsync<CancelRotateSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecret

        internal virtual CreateSecretResponse CreateSecret(CreateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecretResponseUnmarshaller.Instance;

            return Invoke<CreateSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CreateSecret">REST API Reference for CreateSecret Operation</seealso>
        public virtual Task<CreateSecretResponse> CreateSecretAsync(CreateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecretResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecret

        internal virtual DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecretResponseUnmarshaller.Instance;

            return Invoke<DeleteSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteSecret">REST API Reference for DeleteSecret Operation</seealso>
        public virtual Task<DeleteSecretResponse> DeleteSecretAsync(DeleteSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecretResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecret

        internal virtual DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecretResponseUnmarshaller.Instance;

            return Invoke<DescribeSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DescribeSecret">REST API Reference for DescribeSecret Operation</seealso>
        public virtual Task<DescribeSecretResponse> DescribeSecretAsync(DescribeSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecretResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRandomPassword

        internal virtual GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRandomPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRandomPasswordResponseUnmarshaller.Instance;

            return Invoke<GetRandomPasswordResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetRandomPassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRandomPassword operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetRandomPassword">REST API Reference for GetRandomPassword Operation</seealso>
        public virtual Task<GetRandomPasswordResponse> GetRandomPasswordAsync(GetRandomPasswordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRandomPasswordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRandomPasswordResponseUnmarshaller.Instance;

            return InvokeAsync<GetRandomPasswordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSecretValue

        internal virtual GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecretValueResponseUnmarshaller.Instance;

            return Invoke<GetSecretValueResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSecretValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSecretValue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetSecretValue">REST API Reference for GetSecretValue Operation</seealso>
        public virtual Task<GetSecretValueResponse> GetSecretValueAsync(GetSecretValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSecretValueResponseUnmarshaller.Instance;

            return InvokeAsync<GetSecretValueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecrets

        internal virtual ListSecretsResponse ListSecrets(ListSecretsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretsResponseUnmarshaller.Instance;

            return Invoke<ListSecretsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSecrets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecrets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        public virtual Task<ListSecretsResponse> ListSecretsAsync(ListSecretsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecretsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSecretVersionIds

        internal virtual ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretVersionIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretVersionIdsResponseUnmarshaller.Instance;

            return Invoke<ListSecretVersionIdsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSecretVersionIds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSecretVersionIds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        public virtual Task<ListSecretVersionIdsResponse> ListSecretVersionIdsAsync(ListSecretVersionIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSecretVersionIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSecretVersionIdsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSecretVersionIdsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSecretValue

        internal virtual PutSecretValueResponse PutSecretValue(PutSecretValueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSecretValueResponseUnmarshaller.Instance;

            return Invoke<PutSecretValueResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutSecretValue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSecretValue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutSecretValue">REST API Reference for PutSecretValue Operation</seealso>
        public virtual Task<PutSecretValueResponse> PutSecretValueAsync(PutSecretValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSecretValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSecretValueResponseUnmarshaller.Instance;

            return InvokeAsync<PutSecretValueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreSecret

        internal virtual RestoreSecretResponse RestoreSecret(RestoreSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreSecretResponseUnmarshaller.Instance;

            return Invoke<RestoreSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RestoreSecret">REST API Reference for RestoreSecret Operation</seealso>
        public virtual Task<RestoreSecretResponse> RestoreSecretAsync(RestoreSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreSecretResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RotateSecret

        internal virtual RotateSecretResponse RotateSecret(RotateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateSecretResponseUnmarshaller.Instance;

            return Invoke<RotateSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RotateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RotateSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RotateSecret">REST API Reference for RotateSecret Operation</seealso>
        public virtual Task<RotateSecretResponse> RotateSecretAsync(RotateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RotateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RotateSecretResponseUnmarshaller.Instance;

            return InvokeAsync<RotateSecretResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecret

        internal virtual UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretResponseUnmarshaller.Instance;

            return Invoke<UpdateSecretResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecret operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecret operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecret">REST API Reference for UpdateSecret Operation</seealso>
        public virtual Task<UpdateSecretResponse> UpdateSecretAsync(UpdateSecretRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecretResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecretVersionStage

        internal virtual UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretVersionStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretVersionStageResponseUnmarshaller.Instance;

            return Invoke<UpdateSecretVersionStageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecretVersionStage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecretVersionStage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecretVersionStage">REST API Reference for UpdateSecretVersionStage Operation</seealso>
        public virtual Task<UpdateSecretVersionStageResponse> UpdateSecretVersionStageAsync(UpdateSecretVersionStageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecretVersionStageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecretVersionStageResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecretVersionStageResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}