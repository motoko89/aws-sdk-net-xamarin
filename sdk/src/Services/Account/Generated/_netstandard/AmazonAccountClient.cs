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
 * Do not modify this file. This file is generated from the account-2021-02-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Account.Model;
using Amazon.Account.Model.Internal.MarshallTransformations;
using Amazon.Account.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Account
{
    /// <summary>
    /// Implementation for accessing Account
    ///
    /// Operations for Amazon Web Services Account Management
    /// </summary>
    public partial class AmazonAccountClient : AmazonServiceClient, IAmazonAccount
    {
        private static IServiceMetadata serviceMetadata = new AmazonAccountMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        public AmazonAccountClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAccountConfig()) { }

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        public AmazonAccountClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAccountConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAccountClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(AmazonAccountConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAccountClient(AWSCredentials credentials)
            : this(credentials, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Credentials and an
        /// AmazonAccountClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(AWSCredentials credentials, AmazonAccountConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAccountConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAccountConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAccountConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAccountClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAccountClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAccountClient Configuration Object</param>
        public AmazonAccountClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAccountConfig clientConfig)
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


        #region  DeleteAlternateContact

        internal virtual DeleteAlternateContactResponse DeleteAlternateContact(DeleteAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlternateContactResponseUnmarshaller.Instance;

            return Invoke<DeleteAlternateContactResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified alternate contact from an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/DeleteAlternateContact">REST API Reference for DeleteAlternateContact Operation</seealso>
        public virtual Task<DeleteAlternateContactResponse> DeleteAlternateContactAsync(DeleteAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAlternateContactResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAlternateContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAlternateContact

        internal virtual GetAlternateContactResponse GetAlternateContact(GetAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlternateContactResponseUnmarshaller.Instance;

            return Invoke<GetAlternateContactResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ResourceNotFoundException">
        /// The operation failed because it specified a resource that can't be found.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/GetAlternateContact">REST API Reference for GetAlternateContact Operation</seealso>
        public virtual Task<GetAlternateContactResponse> GetAlternateContactAsync(GetAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAlternateContactResponseUnmarshaller.Instance;

            return InvokeAsync<GetAlternateContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutAlternateContact

        internal virtual PutAlternateContactResponse PutAlternateContact(PutAlternateContactRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlternateContactResponseUnmarshaller.Instance;

            return Invoke<PutAlternateContactResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified alternate contact attached to an Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// For complete details about how to use the alternate contact operations, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-update-contact.html">Access
        /// or updating the alternate contacts</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAlternateContact service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAlternateContact service method, as returned by Account.</returns>
        /// <exception cref="Amazon.Account.Model.AccessDeniedException">
        /// The operation failed because the calling identity doesn't have the minimum required
        /// permissions.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.InternalServerException">
        /// The operation failed because of an error internal to Amazon Web Services. Try your
        /// operation again later.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.TooManyRequestsException">
        /// The operation failed because it was called too frequently and exceeded a throttle
        /// limit.
        /// </exception>
        /// <exception cref="Amazon.Account.Model.ValidationException">
        /// The operation failed because one of the input parameters was invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/account-2021-02-01/PutAlternateContact">REST API Reference for PutAlternateContact Operation</seealso>
        public virtual Task<PutAlternateContactResponse> PutAlternateContactAsync(PutAlternateContactRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAlternateContactRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAlternateContactResponseUnmarshaller.Instance;

            return InvokeAsync<PutAlternateContactResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}