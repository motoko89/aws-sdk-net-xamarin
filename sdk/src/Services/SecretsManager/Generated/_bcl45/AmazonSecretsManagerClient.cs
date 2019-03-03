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


        /// <summary>
        /// Disables automatic scheduled rotation and cancels the rotation of a secret if one
        /// is currently in progress.
        /// 
        ///  
        /// <para>
        /// To re-enable scheduled rotation, call <a>RotateSecret</a> with <code>AutomaticallyRotateAfterDays</code>
        /// set to a value greater than 0. This will immediately rotate your secret and then enable
        /// the automatic schedule.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you cancel a rotation that is in progress, it can leave the <code>VersionStage</code>
        /// labels in an unexpected state. Depending on what step of the rotation was in progress,
        /// you might need to remove the staging label <code>AWSPENDING</code> from the partially
        /// created version, specified by the <code>VersionId</code> response value. You should
        /// also evaluate the partially rotated new version to see if it should be deleted, which
        /// you can do by removing all staging labels from the new version's <code>VersionStage</code>
        /// field.
        /// </para>
        ///  </note> 
        /// <para>
        /// To successfully start a rotation, the staging label <code>AWSPENDING</code> must be
        /// in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Not be attached to any version at all
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Attached to the same version as the staging label <code>AWSCURRENT</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the staging label <code>AWSPENDING</code> is attached to a different version than
        /// the version with <code>AWSCURRENT</code> then the attempt to rotate fails.
        /// </para>
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:CancelRotateSecret
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure rotation for a secret or to manually trigger a rotation, use <a>RotateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get the rotation configuration details for a secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list all of the currently available secrets, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list all of the versions currently associated with a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelRotateSecret service method.</param>
        /// 
        /// <returns>The response from the CancelRotateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CancelRotateSecret">REST API Reference for CancelRotateSecret Operation</seealso>
        public virtual CancelRotateSecretResponse CancelRotateSecret(CancelRotateSecretRequest request)
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


        /// <summary>
        /// Creates a new secret. A secret in Secrets Manager consists of both the protected secret
        /// data and the important information needed to manage the secret.
        /// 
        ///  
        /// <para>
        /// Secrets Manager stores the encrypted secret data in one of a collection of "versions"
        /// associated with the secret. Each version contains a copy of the encrypted secret data.
        /// Each version is associated with one or more "staging labels" that identify where the
        /// version is in the rotation cycle. The <code>SecretVersionsToStages</code> field of
        /// the secret contains the mapping of staging labels to the active versions of the secret.
        /// Versions without a staging label are considered deprecated and are not included in
        /// the list.
        /// </para>
        ///  
        /// <para>
        /// You provide the secret data to be encrypted by putting text in either the <code>SecretString</code>
        /// parameter or binary data in the <code>SecretBinary</code> parameter, but not both.
        /// If you include <code>SecretString</code> or <code>SecretBinary</code> then Secrets
        /// Manager also creates an initial secret version and automatically attaches the staging
        /// label <code>AWSCURRENT</code> to the new version.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If you call an operation that needs to encrypt or decrypt the <code>SecretString</code>
        /// or <code>SecretBinary</code> for a secret in the same account as the calling user
        /// and that secret doesn't specify a AWS KMS encryption key, Secrets Manager uses the
        /// account's default AWS managed customer master key (CMK) with the alias <code>aws/secretsmanager</code>.
        /// If this key doesn't already exist in your account then Secrets Manager creates it
        /// for you automatically. All users and roles in the same AWS account automatically have
        /// access to use the default CMK. Note that if an Secrets Manager API call results in
        /// AWS having to create the account's AWS-managed CMK, it can result in a one-time significant
        /// delay in returning the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the secret is in a different AWS account from the credentials calling an API that
        /// requires encryption or decryption of the secret value then you must create and use
        /// a custom AWS KMS CMK because you can't access the default CMK for the account using
        /// credentials from a different AWS account. Store the ARN of the CMK in the secret when
        /// you create the secret or when you update it by including it in the <code>KMSKeyId</code>.
        /// If you call an API that must encrypt or decrypt <code>SecretString</code> or <code>SecretBinary</code>
        /// using credentials from a different account then the AWS KMS key policy must grant
        /// cross-account access to that other account's user or role for both the kms:GenerateDataKey
        /// and kms:Decrypt operations.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        ///  
        /// </para>
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:CreateSecret
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:GenerateDataKey - needed only if you use a customer-managed AWS KMS key to encrypt
        /// the secret. You do not need this permission to use the account's default AWS managed
        /// CMK for Secrets Manager.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:Decrypt - needed only if you use a customer-managed AWS KMS key to encrypt the
        /// secret. You do not need this permission to use the account's default AWS managed CMK
        /// for Secrets Manager.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// secretsmanager:TagResource - needed only if you include the <code>Tags</code> parameter.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To delete a secret, use <a>DeleteSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To modify an existing secret, use <a>UpdateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a new version of a secret, use <a>PutSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve the encrypted secure string and secure binary values, use <a>GetSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve all other details for a secret, use <a>DescribeSecret</a>. This does not
        /// include the encrypted secure string and secure binary values.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve the list of secret versions associated with the current secret, use <a>DescribeSecret</a>
        /// and examine the <code>SecretVersionsToStages</code> response value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecret service method.</param>
        /// 
        /// <returns>The response from the CreateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.EncryptionFailureException">
        /// Secrets Manager can't encrypt the protected secret text using the provided KMS key.
        /// Check that the customer master key (CMK) is available, enabled, and not in an invalid
        /// state. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a>.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager internal limits.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The policy document that you provided isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.PreconditionNotMetException">
        /// The request failed because you did not complete all the prerequisite steps.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceExistsException">
        /// A resource with the ID you requested already exists.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/CreateSecret">REST API Reference for CreateSecret Operation</seealso>
        public virtual CreateSecretResponse CreateSecret(CreateSecretRequest request)
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


        /// <summary>
        /// Deletes the resource-based permission policy that's attached to the secret.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:DeleteResourcePolicy
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To attach a resource policy to a secret, use <a>PutResourcePolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve the current resource-based policy that's attached to a secret, use <a>GetResourcePolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list all of the currently available secrets, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
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


        /// <summary>
        /// Deletes an entire secret and all of its versions. You can optionally include a recovery
        /// window during which you can restore the secret. If you don't specify a recovery window
        /// value, the operation defaults to 30 days. Secrets Manager attaches a <code>DeletionDate</code>
        /// stamp to the secret that specifies the end of the recovery window. At the end of the
        /// recovery window, Secrets Manager deletes the secret permanently.
        /// 
        ///  
        /// <para>
        /// At any time before recovery window ends, you can use <a>RestoreSecret</a> to remove
        /// the <code>DeletionDate</code> and cancel the deletion of the secret.
        /// </para>
        ///  
        /// <para>
        /// You cannot access the encrypted secret information in any secret that is scheduled
        /// for deletion. If you need to access that information, you must cancel the deletion
        /// with <a>RestoreSecret</a> and then retrieve the information.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// There is no explicit operation to delete a version of a secret. Instead, remove all
        /// staging labels from the <code>VersionStage</code> field of a version. That marks the
        /// version as deprecated and allows Secrets Manager to delete it as needed. Versions
        /// that do not have any staging labels do not show up in <a>ListSecretVersionIds</a>
        /// unless you specify <code>IncludeDeprecated</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The permanent secret deletion at the end of the waiting period is performed as a background
        /// task with low priority. There is no guarantee of a specific time after the recovery
        /// window for the actual delete operation to occur.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:DeleteSecret
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a secret, use <a>CreateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To cancel deletion of a version of a secret before the recovery window has expired,
        /// use <a>RestoreSecret</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecret service method.</param>
        /// 
        /// <returns>The response from the DeleteSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DeleteSecret">REST API Reference for DeleteSecret Operation</seealso>
        public virtual DeleteSecretResponse DeleteSecret(DeleteSecretRequest request)
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


        /// <summary>
        /// Retrieves the details of a secret. It does not include the encrypted fields. Only
        /// those fields that are populated with a value are returned in the response. 
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:DescribeSecret
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a secret, use <a>CreateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To modify a secret, use <a>UpdateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve the encrypted secret information in a version of the secret, use <a>GetSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list all of the secrets in the AWS account, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecret service method.</param>
        /// 
        /// <returns>The response from the DescribeSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/DescribeSecret">REST API Reference for DescribeSecret Operation</seealso>
        public virtual DescribeSecretResponse DescribeSecret(DescribeSecretRequest request)
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


        /// <summary>
        /// Generates a random password of the specified complexity. This operation is intended
        /// for use in the Lambda rotation function. Per best practice, we recommend that you
        /// specify the maximum length and include every character type that the system you are
        /// generating a password for can support.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:GetRandomPassword
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRandomPassword service method.</param>
        /// 
        /// <returns>The response from the GetRandomPassword service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetRandomPassword">REST API Reference for GetRandomPassword Operation</seealso>
        public virtual GetRandomPasswordResponse GetRandomPassword(GetRandomPasswordRequest request)
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


        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document that's attached to the
        /// specified secret. The JSON request string input and response output are shown formatted
        /// with white space and line breaks for better readability. Submit your input as a single
        /// line JSON string.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:GetResourcePolicy
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To attach a resource policy to a secret, use <a>PutResourcePolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete the resource-based policy that's attached to a secret, use <a>DeleteResourcePolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list all of the currently available secrets, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
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


        /// <summary>
        /// Retrieves the contents of the encrypted fields <code>SecretString</code> or <code>SecretBinary</code>
        /// from the specified version of a secret, whichever contains content.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:GetSecretValue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:Decrypt - required only if you use a customer-managed AWS KMS key to encrypt the
        /// secret. You do not need this permission to use the account's default AWS managed CMK
        /// for Secrets Manager.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a new version of the secret with different encrypted information, use <a>PutSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To retrieve the non-encrypted details for the secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSecretValue service method.</param>
        /// 
        /// <returns>The response from the GetSecretValue service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.DecryptionFailureException">
        /// Secrets Manager can't decrypt the protected secret text using the provided KMS key.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/GetSecretValue">REST API Reference for GetSecretValue Operation</seealso>
        public virtual GetSecretValueResponse GetSecretValue(GetSecretValueRequest request)
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


        /// <summary>
        /// Lists all of the secrets that are stored by Secrets Manager in the AWS account. To
        /// list the versions currently stored for a specific secret, use <a>ListSecretVersionIds</a>.
        /// The encrypted fields <code>SecretString</code> and <code>SecretBinary</code> are not
        /// included in the output. To get that information, call the <a>GetSecretValue</a> operation.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter when calling any of the
        /// <code>List*</code> operations. These operations can occasionally return an empty or
        /// shorter than expected list of results even when there are more results available.
        /// When this happens, the <code>NextToken</code> response parameter contains a value
        /// to pass to the next call to the same API to request the next part of the list.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:ListSecrets
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To list the versions attached to a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecrets service method.</param>
        /// 
        /// <returns>The response from the ListSecrets service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// You provided an invalid <code>NextToken</code> value.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecrets">REST API Reference for ListSecrets Operation</seealso>
        public virtual ListSecretsResponse ListSecrets(ListSecretsRequest request)
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


        /// <summary>
        /// Lists all of the versions attached to the specified secret. The output does not include
        /// the <code>SecretString</code> or <code>SecretBinary</code> fields. By default, the
        /// list includes only versions that have at least one staging label in <code>VersionStage</code>
        /// attached.
        /// 
        ///  <note> 
        /// <para>
        /// Always check the <code>NextToken</code> response parameter when calling any of the
        /// <code>List*</code> operations. These operations can occasionally return an empty or
        /// shorter than expected list of results even when there are more results available.
        /// When this happens, the <code>NextToken</code> response parameter contains a value
        /// to pass to the next call to the same API to request the next part of the list.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:ListSecretVersionIds
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To list the secrets in an account, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSecretVersionIds service method.</param>
        /// 
        /// <returns>The response from the ListSecretVersionIds service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidNextTokenException">
        /// You provided an invalid <code>NextToken</code> value.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/ListSecretVersionIds">REST API Reference for ListSecretVersionIds Operation</seealso>
        public virtual ListSecretVersionIdsResponse ListSecretVersionIds(ListSecretVersionIdsRequest request)
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


        /// <summary>
        /// Attaches the contents of the specified resource-based permission policy to a secret.
        /// A resource-based policy is optional. Alternatively, you can use IAM identity-based
        /// policies that specify the secret's Amazon Resource Name (ARN) in the policy statement's
        /// <code>Resources</code> element. You can also use a combination of both identity-based
        /// and resource-based policies. The affected users and roles receive the permissions
        /// that are permitted by all of the relevant policies. For more information, see <a href="http://docs.aws.amazon.com/secretsmanager/latest/userguide/auth-and-access_resource-based-policies.html">Using
        /// Resource-Based Policies for AWS Secrets Manager</a>. For the complete description
        /// of the AWS policy syntax and grammar, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies.html">IAM
        /// JSON Policy Reference</a> in the <i>IAM User Guide</i>.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:PutResourcePolicy
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve the resource policy that's attached to a secret, use <a>GetResourcePolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete the resource-based policy that's attached to a secret, use <a>DeleteResourcePolicy</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list all of the currently available secrets, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The policy document that you provided isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
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


        /// <summary>
        /// Stores a new encrypted secret value in the specified secret. To do this, the operation
        /// creates a new version and attaches it to the secret. The version can contain a new
        /// <code>SecretString</code> value or a new <code>SecretBinary</code> value. You can
        /// also specify the staging labels that are initially attached to the new version.
        /// 
        ///  <note> 
        /// <para>
        /// The Secrets Manager console uses only the <code>SecretString</code> field. To add
        /// binary data to a secret with the <code>SecretBinary</code> field you must use the
        /// AWS CLI or one of the AWS SDKs.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// If this operation creates the first version for the secret then Secrets Manager automatically
        /// attaches the staging label <code>AWSCURRENT</code> to the new version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If another version of this secret already exists, then this operation does not automatically
        /// move any staging labels other than those that you explicitly specify in the <code>VersionStages</code>
        /// parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If this operation moves the staging label <code>AWSCURRENT</code> from another version
        /// to this version (because you included it in the <code>StagingLabels</code> parameter)
        /// then Secrets Manager also automatically moves the staging label <code>AWSPREVIOUS</code>
        /// to the version that <code>AWSCURRENT</code> was removed from.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This operation is idempotent. If a version with a <code>VersionId</code> with the
        /// same value as the <code>ClientRequestToken</code> parameter already exists and you
        /// specify the same secret data, the operation succeeds but does nothing. However, if
        /// the secret data is different, then the operation fails because you cannot modify an
        /// existing version; you can only create new ones.
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If you call an operation that needs to encrypt or decrypt the <code>SecretString</code>
        /// or <code>SecretBinary</code> for a secret in the same account as the calling user
        /// and that secret doesn't specify a AWS KMS encryption key, Secrets Manager uses the
        /// account's default AWS managed customer master key (CMK) with the alias <code>aws/secretsmanager</code>.
        /// If this key doesn't already exist in your account then Secrets Manager creates it
        /// for you automatically. All users and roles in the same AWS account automatically have
        /// access to use the default CMK. Note that if an Secrets Manager API call results in
        /// AWS having to create the account's AWS-managed CMK, it can result in a one-time significant
        /// delay in returning the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the secret is in a different AWS account from the credentials calling an API that
        /// requires encryption or decryption of the secret value then you must create and use
        /// a custom AWS KMS CMK because you can't access the default CMK for the account using
        /// credentials from a different AWS account. Store the ARN of the CMK in the secret when
        /// you create the secret or when you update it by including it in the <code>KMSKeyId</code>.
        /// If you call an API that must encrypt or decrypt <code>SecretString</code> or <code>SecretBinary</code>
        /// using credentials from a different account then the AWS KMS key policy must grant
        /// cross-account access to that other account's user or role for both the kms:GenerateDataKey
        /// and kms:Decrypt operations.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:PutSecretValue
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:GenerateDataKey - needed only if you use a customer-managed AWS KMS key to encrypt
        /// the secret. You do not need this permission to use the account's default AWS managed
        /// CMK for Secrets Manager.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To retrieve the encrypted value you store in the version of a secret, use <a>GetSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a secret, use <a>CreateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get the details for a secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list the versions attached to a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSecretValue service method.</param>
        /// 
        /// <returns>The response from the PutSecretValue service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.EncryptionFailureException">
        /// Secrets Manager can't encrypt the protected secret text using the provided KMS key.
        /// Check that the customer master key (CMK) is available, enabled, and not in an invalid
        /// state. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a>.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager internal limits.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceExistsException">
        /// A resource with the ID you requested already exists.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/PutSecretValue">REST API Reference for PutSecretValue Operation</seealso>
        public virtual PutSecretValueResponse PutSecretValue(PutSecretValueRequest request)
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


        /// <summary>
        /// Cancels the scheduled deletion of a secret by removing the <code>DeletedDate</code>
        /// time stamp. This makes the secret accessible to query once again.
        /// 
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:RestoreSecret
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To delete a secret, use <a>DeleteSecret</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreSecret service method.</param>
        /// 
        /// <returns>The response from the RestoreSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RestoreSecret">REST API Reference for RestoreSecret Operation</seealso>
        public virtual RestoreSecretResponse RestoreSecret(RestoreSecretRequest request)
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


        /// <summary>
        /// Configures and starts the asynchronous process of rotating this secret. If you include
        /// the configuration parameters, the operation sets those values for the secret and then
        /// immediately starts a rotation. If you do not include the configuration parameters,
        /// the operation starts a rotation with the values already stored in the secret. After
        /// the rotation completes, the protected service and its clients all use the new version
        /// of the secret. 
        /// 
        ///  
        /// <para>
        /// This required configuration information includes the ARN of an AWS Lambda function
        /// and the time between scheduled rotations. The Lambda rotation function creates a new
        /// version of the secret and creates or updates the credentials on the protected service
        /// to match. After testing the new credentials, the function marks the new secret with
        /// the staging label <code>AWSCURRENT</code> so that your clients all immediately begin
        /// to use the new version. For more information about rotating secrets and how to configure
        /// a Lambda function to rotate the secrets for your protected service, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/rotating-secrets.html">Rotating
        /// Secrets in AWS Secrets Manager</a> in the <i>AWS Secrets Manager User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Secrets Manager schedules the next rotation when the previous one is complete. Secrets
        /// Manager schedules the date by adding the rotation interval (number of days) to the
        /// actual date of the last rotation. The service chooses the hour within that 24-hour
        /// date window randomly. The minute is also chosen somewhat randomly, but weighted towards
        /// the top of the hour and influenced by a variety of factors that help distribute load.
        /// </para>
        ///  
        /// <para>
        /// The rotation function must end with the versions of the secret in one of two states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <code>AWSPENDING</code> and <code>AWSCURRENT</code> staging labels are attached
        /// to the same version of the secret, or
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>AWSPENDING</code> staging label is not attached to any version of the secret.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If instead the <code>AWSPENDING</code> staging label is present but is not attached
        /// to the same version as <code>AWSCURRENT</code> then any later invocation of <code>RotateSecret</code>
        /// assumes that a previous rotation request is still in progress and returns an error.
        /// </para>
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:RotateSecret
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// lambda:InvokeFunction (on the function specified in the secret's metadata)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To list the secrets in your account, use <a>ListSecrets</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get the details for a version of a secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a new version of a secret, use <a>CreateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To attach staging labels to or remove staging labels from a version of a secret, use
        /// <a>UpdateSecretVersionStage</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateSecret service method.</param>
        /// 
        /// <returns>The response from the RotateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/RotateSecret">REST API Reference for RotateSecret Operation</seealso>
        public virtual RotateSecretResponse RotateSecret(RotateSecretRequest request)
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


        /// <summary>
        /// Attaches one or more tags, each consisting of a key name and a value, to the specified
        /// secret. Tags are part of the secret's overall metadata, and are not associated with
        /// any specific version of the secret. This operation only appends tags to the existing
        /// list of tags. To remove tags, you must use <a>UntagResource</a>.
        /// 
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per secret—50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length—127 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length—255 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use the <code>aws:</code> prefix in your tag names or values because it is
        /// reserved for AWS use. You can't edit or delete tag names or values with this prefix.
        /// Tags with this prefix do not count against your tags per secret limit.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema will be used across multiple services and resources, remember
        /// that other services might have restrictions on allowed characters. Generally allowed
        /// characters are: letters, spaces, and numbers representable in UTF-8, plus the following
        /// special characters: + - = . _ : / @.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If you use tags as part of your security strategy, then adding or removing a tag can
        /// change permissions. If successfully completing this operation would result in you
        /// losing your permissions for this secret, then the operation is blocked and returns
        /// an Access Denied error.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:TagResource
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To remove one or more tags from the collection attached to a secret, use <a>UntagResource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To view the list of tags attached to a secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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


        /// <summary>
        /// Removes one or more tags from the specified secret.
        /// 
        ///  
        /// <para>
        /// This operation is idempotent. If a requested tag is not attached to the secret, no
        /// error is returned and the secret metadata is unchanged.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you use tags as part of your security strategy, then removing a tag can change
        /// permissions. If successfully completing this operation would result in you losing
        /// your permissions for this secret, then the operation is blocked and returns an Access
        /// Denied error.
        /// </para>
        ///  </important> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:UntagResource
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To add one or more tags to the collection attached to a secret, use <a>TagResource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To view the list of tags attached to a secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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


        /// <summary>
        /// Modifies many of the details of the specified secret. If you include a <code>ClientRequestToken</code>
        /// and <i>either</i> <code>SecretString</code> or <code>SecretBinary</code> then it also
        /// creates a new version attached to the secret.
        /// 
        ///  
        /// <para>
        /// To modify the rotation configuration of a secret, use <a>RotateSecret</a> instead.
        /// </para>
        ///  <note> 
        /// <para>
        /// The Secrets Manager console uses only the <code>SecretString</code> parameter and
        /// therefore limits you to encrypting and storing only a text string. To encrypt and
        /// store binary data as part of the version of a secret, you must use either the AWS
        /// CLI or one of the AWS SDKs.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        /// If a version with a <code>VersionId</code> with the same value as the <code>ClientRequestToken</code>
        /// parameter already exists, the operation results in an error. You cannot modify an
        /// existing version, you can only create a new version.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you include <code>SecretString</code> or <code>SecretBinary</code> to create a
        /// new secret version, Secrets Manager automatically attaches the staging label <code>AWSCURRENT</code>
        /// to the new version. 
        /// </para>
        ///  </li> </ul> <note> <ul> <li> 
        /// <para>
        /// If you call an operation that needs to encrypt or decrypt the <code>SecretString</code>
        /// or <code>SecretBinary</code> for a secret in the same account as the calling user
        /// and that secret doesn't specify a AWS KMS encryption key, Secrets Manager uses the
        /// account's default AWS managed customer master key (CMK) with the alias <code>aws/secretsmanager</code>.
        /// If this key doesn't already exist in your account then Secrets Manager creates it
        /// for you automatically. All users and roles in the same AWS account automatically have
        /// access to use the default CMK. Note that if an Secrets Manager API call results in
        /// AWS having to create the account's AWS-managed CMK, it can result in a one-time significant
        /// delay in returning the result.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the secret is in a different AWS account from the credentials calling an API that
        /// requires encryption or decryption of the secret value then you must create and use
        /// a custom AWS KMS CMK because you can't access the default CMK for the account using
        /// credentials from a different AWS account. Store the ARN of the CMK in the secret when
        /// you create the secret or when you update it by including it in the <code>KMSKeyId</code>.
        /// If you call an API that must encrypt or decrypt <code>SecretString</code> or <code>SecretBinary</code>
        /// using credentials from a different account then the AWS KMS key policy must grant
        /// cross-account access to that other account's user or role for both the kms:GenerateDataKey
        /// and kms:Decrypt operations.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:UpdateSecret
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:GenerateDataKey - needed only if you use a custom AWS KMS key to encrypt the secret.
        /// You do not need this permission to use the account's AWS managed CMK for Secrets Manager.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// kms:Decrypt - needed only if you use a custom AWS KMS key to encrypt the secret. You
        /// do not need this permission to use the account's AWS managed CMK for Secrets Manager.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a new secret, use <a>CreateSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add only a new version to an existing secret, use <a>PutSecretValue</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To get the details for a secret, use <a>DescribeSecret</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To list the versions contained in a secret, use <a>ListSecretVersionIds</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecret service method.</param>
        /// 
        /// <returns>The response from the UpdateSecret service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.EncryptionFailureException">
        /// Secrets Manager can't encrypt the protected secret text using the provided KMS key.
        /// Check that the customer master key (CMK) is available, enabled, and not in an invalid
        /// state. For more information, see <a href="http://docs.aws.amazon.com/kms/latest/developerguide/key-state.html">How
        /// Key State Affects Use of a Customer Master Key</a>.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager internal limits.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.MalformedPolicyDocumentException">
        /// The policy document that you provided isn't valid.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.PreconditionNotMetException">
        /// The request failed because you did not complete all the prerequisite steps.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceExistsException">
        /// A resource with the ID you requested already exists.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecret">REST API Reference for UpdateSecret Operation</seealso>
        public virtual UpdateSecretResponse UpdateSecret(UpdateSecretRequest request)
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


        /// <summary>
        /// Modifies the staging labels attached to a version of a secret. Staging labels are
        /// used to track a version as it progresses through the secret rotation process. You
        /// can attach a staging label to only one version of a secret at a time. If a staging
        /// label to be added is already attached to another version, then it is moved--removed
        /// from the other version first and then attached to this one. For more information about
        /// staging labels, see <a href="https://docs.aws.amazon.com/secretsmanager/latest/userguide/terms-concepts.html#term_staging-label">Staging
        /// Labels</a> in the <i>AWS Secrets Manager User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// The staging labels that you specify in the <code>VersionStage</code> parameter are
        /// added to the existing list of staging labels--they don't replace it.
        /// </para>
        ///  
        /// <para>
        /// You can move the <code>AWSCURRENT</code> staging label to this version by including
        /// it in this call.
        /// </para>
        ///  <note> 
        /// <para>
        /// Whenever you move <code>AWSCURRENT</code>, Secrets Manager automatically moves the
        /// label <code>AWSPREVIOUS</code> to the version that <code>AWSCURRENT</code> was removed
        /// from.
        /// </para>
        ///  </note> 
        /// <para>
        /// If this action results in the last label being removed from a version, then the version
        /// is considered to be 'deprecated' and can be deleted by Secrets Manager.
        /// </para>
        ///  
        /// <para>
        ///  <b>Minimum permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// To run this command, you must have the following permissions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// secretsmanager:UpdateSecretVersionStage
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To get the list of staging labels that are currently associated with a version of
        /// a secret, use <code> <a>DescribeSecret</a> </code> and examine the <code>SecretVersionsToStages</code>
        /// response value. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecretVersionStage service method.</param>
        /// 
        /// <returns>The response from the UpdateSecretVersionStage service method, as returned by SecretsManager.</returns>
        /// <exception cref="Amazon.SecretsManager.Model.InternalServiceErrorException">
        /// An error occurred on the server side.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidParameterException">
        /// You provided an invalid value for a parameter.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.InvalidRequestException">
        /// You provided a parameter value that is not valid for the current state of the resource.
        /// 
        ///  
        /// <para>
        /// Possible causes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You tried to perform the operation on a secret that's currently marked deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You tried to enable rotation on a secret that doesn't already have a Lambda function
        /// ARN configured and you didn't include such an ARN as a parameter in this call. 
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.LimitExceededException">
        /// The request failed because it would exceed one of the Secrets Manager internal limits.
        /// </exception>
        /// <exception cref="Amazon.SecretsManager.Model.ResourceNotFoundException">
        /// We can't find the resource that you asked for.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/secretsmanager-2017-10-17/UpdateSecretVersionStage">REST API Reference for UpdateSecretVersionStage Operation</seealso>
        public virtual UpdateSecretVersionStageResponse UpdateSecretVersionStage(UpdateSecretVersionStageRequest request)
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