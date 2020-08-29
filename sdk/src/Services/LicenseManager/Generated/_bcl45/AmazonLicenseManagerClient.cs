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
 * Do not modify this file. This file is generated from the license-manager-2018-08-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.LicenseManager.Model;
using Amazon.LicenseManager.Model.Internal.MarshallTransformations;
using Amazon.LicenseManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.LicenseManager
{
    /// <summary>
    /// Implementation for accessing LicenseManager
    ///
    /// AWS License Manager  
    /// <para>
    /// AWS License Manager makes it easier to manage licenses from software vendors across
    /// multiple AWS accounts and on-premises servers.
    /// </para>
    /// </summary>
    public partial class AmazonLicenseManagerClient : AmazonServiceClient, IAmazonLicenseManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonLicenseManagerMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        public AmazonLicenseManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonLicenseManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(AmazonLicenseManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonLicenseManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Credentials and an
        /// AmazonLicenseManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(AWSCredentials credentials, AmazonLicenseManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonLicenseManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonLicenseManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonLicenseManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonLicenseManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonLicenseManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonLicenseManagerClient Configuration Object</param>
        public AmazonLicenseManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonLicenseManagerConfig clientConfig)
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


        #region  CreateLicenseConfiguration


        /// <summary>
        /// Creates a license configuration.
        /// 
        ///  
        /// <para>
        /// A license configuration is an abstraction of a customer license agreement that can
        /// be consumed and enforced by License Manager. Components include specifications for
        /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
        /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
        /// host (how long a license must be associated with a host), and the number of licenses
        /// purchased and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        public virtual CreateLicenseConfigurationResponse CreateLicenseConfiguration(CreateLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateLicenseConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates a license configuration.
        /// 
        ///  
        /// <para>
        /// A license configuration is an abstraction of a customer license agreement that can
        /// be consumed and enforced by License Manager. Components include specifications for
        /// the license type (licensing by instance, socket, CPU, or vCPU), allowed tenancy (shared
        /// tenancy, Dedicated Instance, Dedicated Host, or all of these), license affinity to
        /// host (how long a license must be associated with a host), and the number of licenses
        /// purchased and used.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/CreateLicenseConfiguration">REST API Reference for CreateLicenseConfiguration Operation</seealso>
        public virtual Task<CreateLicenseConfigurationResponse> CreateLicenseConfigurationAsync(CreateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLicenseConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLicenseConfiguration


        /// <summary>
        /// Deletes the specified license configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a license configuration that is in use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        public virtual DeleteLicenseConfigurationResponse DeleteLicenseConfiguration(DeleteLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLicenseConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified license configuration.
        /// 
        ///  
        /// <para>
        /// You cannot delete a license configuration that is in use.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/DeleteLicenseConfiguration">REST API Reference for DeleteLicenseConfiguration Operation</seealso>
        public virtual Task<DeleteLicenseConfigurationResponse> DeleteLicenseConfigurationAsync(DeleteLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLicenseConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLicenseConfiguration


        /// <summary>
        /// Gets detailed information about the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        public virtual GetLicenseConfigurationResponse GetLicenseConfiguration(GetLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLicenseConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Gets detailed information about the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetLicenseConfiguration">REST API Reference for GetLicenseConfiguration Operation</seealso>
        public virtual Task<GetLicenseConfigurationResponse> GetLicenseConfigurationAsync(GetLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLicenseConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceSettings


        /// <summary>
        /// Gets the License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual GetServiceSettingsResponse GetServiceSettings(GetServiceSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<GetServiceSettingsResponse>(request, options);
        }


        /// <summary>
        /// Gets the License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/GetServiceSettings">REST API Reference for GetServiceSettings Operation</seealso>
        public virtual Task<GetServiceSettingsResponse> GetServiceSettingsAsync(GetServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetServiceSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociationsForLicenseConfiguration


        /// <summary>
        /// Lists the resource associations for the specified license configuration.
        /// 
        ///  
        /// <para>
        /// Resource associations need not consume licenses from a license configuration. For
        /// example, an AMI or a stopped instance might not consume a license (depending on the
        /// license rules).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        public virtual ListAssociationsForLicenseConfigurationResponse ListAssociationsForLicenseConfiguration(ListAssociationsForLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsForLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsForLicenseConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Lists the resource associations for the specified license configuration.
        /// 
        ///  
        /// <para>
        /// Resource associations need not consume licenses from a license configuration. For
        /// example, an AMI or a stopped instance might not consume a license (depending on the
        /// license rules).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociationsForLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociationsForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListAssociationsForLicenseConfiguration">REST API Reference for ListAssociationsForLicenseConfiguration Operation</seealso>
        public virtual Task<ListAssociationsForLicenseConfigurationResponse> ListAssociationsForLicenseConfigurationAsync(ListAssociationsForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociationsForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsForLicenseConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssociationsForLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFailuresForLicenseConfigurationOperations


        /// <summary>
        /// Lists the license configuration operations that failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations service method.</param>
        /// 
        /// <returns>The response from the ListFailuresForLicenseConfigurationOperations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        public virtual ListFailuresForLicenseConfigurationOperationsResponse ListFailuresForLicenseConfigurationOperations(ListFailuresForLicenseConfigurationOperationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFailuresForLicenseConfigurationOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailuresForLicenseConfigurationOperationsResponseUnmarshaller.Instance;

            return Invoke<ListFailuresForLicenseConfigurationOperationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the license configuration operations that failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListFailuresForLicenseConfigurationOperations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListFailuresForLicenseConfigurationOperations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListFailuresForLicenseConfigurationOperations">REST API Reference for ListFailuresForLicenseConfigurationOperations Operation</seealso>
        public virtual Task<ListFailuresForLicenseConfigurationOperationsResponse> ListFailuresForLicenseConfigurationOperationsAsync(ListFailuresForLicenseConfigurationOperationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFailuresForLicenseConfigurationOperationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFailuresForLicenseConfigurationOperationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListFailuresForLicenseConfigurationOperationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseConfigurations


        /// <summary>
        /// Lists the license configurations for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        public virtual ListLicenseConfigurationsResponse ListLicenseConfigurations(ListLicenseConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListLicenseConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the license configurations for your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseConfigurations service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseConfigurations">REST API Reference for ListLicenseConfigurations Operation</seealso>
        public virtual Task<ListLicenseConfigurationsResponse> ListLicenseConfigurationsAsync(ListLicenseConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLicenseConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListLicenseSpecificationsForResource


        /// <summary>
        /// Describes the license configurations for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        public virtual ListLicenseSpecificationsForResourceResponse ListLicenseSpecificationsForResource(ListLicenseSpecificationsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListLicenseSpecificationsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Describes the license configurations for the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLicenseSpecificationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListLicenseSpecificationsForResource">REST API Reference for ListLicenseSpecificationsForResource Operation</seealso>
        public virtual Task<ListLicenseSpecificationsForResourceResponse> ListLicenseSpecificationsForResourceAsync(ListLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLicenseSpecificationsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListLicenseSpecificationsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListResourceInventory


        /// <summary>
        /// Lists resources managed using Systems Manager inventory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        public virtual ListResourceInventoryResponse ListResourceInventory(ListResourceInventoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceInventoryResponseUnmarshaller.Instance;

            return Invoke<ListResourceInventoryResponse>(request, options);
        }


        /// <summary>
        /// Lists resources managed using Systems Manager inventory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourceInventory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourceInventory service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FailedDependencyException">
        /// A dependency required to run the API is missing.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListResourceInventory">REST API Reference for ListResourceInventory Operation</seealso>
        public virtual Task<ListResourceInventoryResponse> ListResourceInventoryAsync(ListResourceInventoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListResourceInventoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourceInventoryResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListResourceInventoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags for the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists the tags for the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListUsageForLicenseConfiguration


        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        public virtual ListUsageForLicenseConfigurationResponse ListUsageForLicenseConfiguration(ListUsageForLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageForLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<ListUsageForLicenseConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Lists all license usage records for a license configuration, displaying license consumption
        /// details by resource at a selected point in time. Use this action to audit the current
        /// license consumption for any license inventory and configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsageForLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsageForLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.FilterLimitExceededException">
        /// The request uses too many filters or too many filter values.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/ListUsageForLicenseConfiguration">REST API Reference for ListUsageForLicenseConfiguration Operation</seealso>
        public virtual Task<ListUsageForLicenseConfigurationResponse> ListUsageForLicenseConfigurationAsync(ListUsageForLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListUsageForLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListUsageForLicenseConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListUsageForLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds the specified tags to the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds the specified tags to the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the specified tags from the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Removes the specified tags from the specified license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseConfiguration


        /// <summary>
        /// Modifies the attributes of an existing license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        public virtual UpdateLicenseConfigurationResponse UpdateLicenseConfiguration(UpdateLicenseConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Modifies the attributes of an existing license configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseConfiguration service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseConfiguration">REST API Reference for UpdateLicenseConfiguration Operation</seealso>
        public virtual Task<UpdateLicenseConfigurationResponse> UpdateLicenseConfigurationAsync(UpdateLicenseConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLicenseConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLicenseSpecificationsForResource


        /// <summary>
        /// Adds or removes the specified license configurations for the specified AWS resource.
        /// 
        ///  
        /// <para>
        /// You can update the license specifications of AMIs, instances, and hosts. You cannot
        /// update the license specifications for launch templates and AWS CloudFormation templates,
        /// as they send license configurations to the operation that creates the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        public virtual UpdateLicenseSpecificationsForResourceResponse UpdateLicenseSpecificationsForResource(UpdateLicenseSpecificationsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseSpecificationsForResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateLicenseSpecificationsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Adds or removes the specified license configurations for the specified AWS resource.
        /// 
        ///  
        /// <para>
        /// You can update the license specifications of AMIs, instances, and hosts. You cannot
        /// update the license specifications for launch templates and AWS CloudFormation templates,
        /// as they send license configurations to the operation that creates the resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLicenseSpecificationsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLicenseSpecificationsForResource service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidResourceStateException">
        /// License Manager cannot allocate a license to a resource because of its state. 
        /// 
        ///  
        /// <para>
        /// For example, you cannot allocate a license to an instance in the process of shutting
        /// down.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.LicenseUsageException">
        /// You do not have enough licenses available to support a new resource launch.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateLicenseSpecificationsForResource">REST API Reference for UpdateLicenseSpecificationsForResource Operation</seealso>
        public virtual Task<UpdateLicenseSpecificationsForResourceResponse> UpdateLicenseSpecificationsForResourceAsync(UpdateLicenseSpecificationsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLicenseSpecificationsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLicenseSpecificationsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateLicenseSpecificationsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceSettings


        /// <summary>
        /// Updates License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual UpdateServiceSettingsResponse UpdateServiceSettings(UpdateServiceSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceSettingsResponse>(request, options);
        }


        /// <summary>
        /// Updates License Manager settings for the current Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServiceSettings service method, as returned by LicenseManager.</returns>
        /// <exception cref="Amazon.LicenseManager.Model.AccessDeniedException">
        /// Access to resource denied.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.AuthorizationException">
        /// The AWS user account does not have permission to perform the action. Check the IAM
        /// policy associated with this account.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.InvalidParameterValueException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.RateLimitExceededException">
        /// Too many requests have been submitted. Try again after a brief wait.
        /// </exception>
        /// <exception cref="Amazon.LicenseManager.Model.ServerInternalException">
        /// The server experienced an internal error. Try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/license-manager-2018-08-01/UpdateServiceSettings">REST API Reference for UpdateServiceSettings Operation</seealso>
        public virtual Task<UpdateServiceSettingsResponse> UpdateServiceSettingsAsync(UpdateServiceSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceSettingsResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateServiceSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}