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
 * Do not modify this file. This file is generated from the worklink-2018-09-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkLink.Model;
using Amazon.WorkLink.Model.Internal.MarshallTransformations;
using Amazon.WorkLink.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkLink
{
    /// <summary>
    /// Implementation for accessing WorkLink
    ///
    /// Amazon WorkLink is a cloud-based service that provides secure access to internal websites
    /// and web apps from iOS phones. In a single step, your users, such as employees, can
    /// access internal websites as efficiently as they access any other public website. They
    /// enter a URL in their web browser, or choose a link to an internal website in an email.
    /// Amazon WorkLink authenticates the user's access and securely renders authorized internal
    /// web content in a secure rendering service in the AWS cloud. Amazon WorkLink doesn't
    /// download or store any internal web content on mobile devices.
    /// </summary>
    public partial class AmazonWorkLinkClient : AmazonServiceClient, IAmazonWorkLink
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkLinkMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        public AmazonWorkLinkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkLinkConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        public AmazonWorkLinkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkLinkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(AmazonWorkLinkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkLinkClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkLinkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Credentials and an
        /// AmazonWorkLinkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(AWSCredentials credentials, AmazonWorkLinkConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkLinkConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkLinkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkLinkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkLinkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkLinkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkLinkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkLinkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkLinkClient Configuration Object</param>
        public AmazonWorkLinkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkLinkConfig clientConfig)
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


        #region  AssociateWebsiteCertificateAuthority

        internal virtual AssociateWebsiteCertificateAuthorityResponse AssociateWebsiteCertificateAuthority(AssociateWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<AssociateWebsiteCertificateAuthorityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/AssociateWebsiteCertificateAuthority">REST API Reference for AssociateWebsiteCertificateAuthority Operation</seealso>
        public virtual Task<AssociateWebsiteCertificateAuthorityResponse> AssociateWebsiteCertificateAuthorityAsync(AssociateWebsiteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWebsiteCertificateAuthorityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleet

        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAuditStreamConfiguration

        internal virtual DescribeAuditStreamConfigurationResponse DescribeAuditStreamConfiguration(DescribeAuditStreamConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeAuditStreamConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAuditStreamConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeAuditStreamConfiguration">REST API Reference for DescribeAuditStreamConfiguration Operation</seealso>
        public virtual Task<DescribeAuditStreamConfigurationResponse> DescribeAuditStreamConfigurationAsync(DescribeAuditStreamConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAuditStreamConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAuditStreamConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCompanyNetworkConfiguration

        internal virtual DescribeCompanyNetworkConfigurationResponse DescribeCompanyNetworkConfiguration(DescribeCompanyNetworkConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeCompanyNetworkConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompanyNetworkConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeCompanyNetworkConfiguration">REST API Reference for DescribeCompanyNetworkConfiguration Operation</seealso>
        public virtual Task<DescribeCompanyNetworkConfigurationResponse> DescribeCompanyNetworkConfigurationAsync(DescribeCompanyNetworkConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCompanyNetworkConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDevice

        internal virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDevicePolicyConfiguration

        internal virtual DescribeDevicePolicyConfigurationResponse DescribeDevicePolicyConfiguration(DescribeDevicePolicyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeDevicePolicyConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevicePolicyConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeDevicePolicyConfiguration">REST API Reference for DescribeDevicePolicyConfiguration Operation</seealso>
        public virtual Task<DescribeDevicePolicyConfigurationResponse> DescribeDevicePolicyConfigurationAsync(DescribeDevicePolicyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDevicePolicyConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetMetadata

        internal virtual DescribeFleetMetadataResponse DescribeFleetMetadata(DescribeFleetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetMetadataResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeFleetMetadata">REST API Reference for DescribeFleetMetadata Operation</seealso>
        public virtual Task<DescribeFleetMetadataResponse> DescribeFleetMetadataAsync(DescribeFleetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityProviderConfiguration

        internal virtual DescribeIdentityProviderConfigurationResponse DescribeIdentityProviderConfiguration(DescribeIdentityProviderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityProviderConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityProviderConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeIdentityProviderConfiguration">REST API Reference for DescribeIdentityProviderConfiguration Operation</seealso>
        public virtual Task<DescribeIdentityProviderConfigurationResponse> DescribeIdentityProviderConfigurationAsync(DescribeIdentityProviderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityProviderConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWebsiteCertificateAuthority

        internal virtual DescribeWebsiteCertificateAuthorityResponse DescribeWebsiteCertificateAuthority(DescribeWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DescribeWebsiteCertificateAuthorityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DescribeWebsiteCertificateAuthority">REST API Reference for DescribeWebsiteCertificateAuthority Operation</seealso>
        public virtual Task<DescribeWebsiteCertificateAuthorityResponse> DescribeWebsiteCertificateAuthorityAsync(DescribeWebsiteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeWebsiteCertificateAuthorityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateWebsiteCertificateAuthority

        internal virtual DisassociateWebsiteCertificateAuthorityResponse DisassociateWebsiteCertificateAuthority(DisassociateWebsiteCertificateAuthorityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return Invoke<DisassociateWebsiteCertificateAuthorityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateWebsiteCertificateAuthority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWebsiteCertificateAuthority operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/DisassociateWebsiteCertificateAuthority">REST API Reference for DisassociateWebsiteCertificateAuthority Operation</seealso>
        public virtual Task<DisassociateWebsiteCertificateAuthorityResponse> DisassociateWebsiteCertificateAuthorityAsync(DisassociateWebsiteCertificateAuthorityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateWebsiteCertificateAuthorityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWebsiteCertificateAuthorityResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWebsiteCertificateAuthorityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDevices

        internal virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFleets

        internal virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListWebsiteCertificateAuthorities

        internal virtual ListWebsiteCertificateAuthoritiesResponse ListWebsiteCertificateAuthorities(ListWebsiteCertificateAuthoritiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;

            return Invoke<ListWebsiteCertificateAuthoritiesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListWebsiteCertificateAuthorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWebsiteCertificateAuthorities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/ListWebsiteCertificateAuthorities">REST API Reference for ListWebsiteCertificateAuthorities Operation</seealso>
        public virtual Task<ListWebsiteCertificateAuthoritiesResponse> ListWebsiteCertificateAuthoritiesAsync(ListWebsiteCertificateAuthoritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListWebsiteCertificateAuthoritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWebsiteCertificateAuthoritiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWebsiteCertificateAuthoritiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SignOutUser

        internal virtual SignOutUserResponse SignOutUser(SignOutUserRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignOutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignOutUserResponseUnmarshaller.Instance;

            return Invoke<SignOutUserResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SignOutUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SignOutUser operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/SignOutUser">REST API Reference for SignOutUser Operation</seealso>
        public virtual Task<SignOutUserResponse> SignOutUserAsync(SignOutUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SignOutUserRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SignOutUserResponseUnmarshaller.Instance;

            return InvokeAsync<SignOutUserResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAuditStreamConfiguration

        internal virtual UpdateAuditStreamConfigurationResponse UpdateAuditStreamConfiguration(UpdateAuditStreamConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateAuditStreamConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAuditStreamConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAuditStreamConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateAuditStreamConfiguration">REST API Reference for UpdateAuditStreamConfiguration Operation</seealso>
        public virtual Task<UpdateAuditStreamConfigurationResponse> UpdateAuditStreamConfigurationAsync(UpdateAuditStreamConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAuditStreamConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAuditStreamConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAuditStreamConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCompanyNetworkConfiguration

        internal virtual UpdateCompanyNetworkConfigurationResponse UpdateCompanyNetworkConfiguration(UpdateCompanyNetworkConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateCompanyNetworkConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCompanyNetworkConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCompanyNetworkConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateCompanyNetworkConfiguration">REST API Reference for UpdateCompanyNetworkConfiguration Operation</seealso>
        public virtual Task<UpdateCompanyNetworkConfigurationResponse> UpdateCompanyNetworkConfigurationAsync(UpdateCompanyNetworkConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCompanyNetworkConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCompanyNetworkConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCompanyNetworkConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevicePolicyConfiguration

        internal virtual UpdateDevicePolicyConfigurationResponse UpdateDevicePolicyConfiguration(UpdateDevicePolicyConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateDevicePolicyConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevicePolicyConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevicePolicyConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateDevicePolicyConfiguration">REST API Reference for UpdateDevicePolicyConfiguration Operation</seealso>
        public virtual Task<UpdateDevicePolicyConfigurationResponse> UpdateDevicePolicyConfigurationAsync(UpdateDevicePolicyConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDevicePolicyConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDevicePolicyConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDevicePolicyConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetMetadata

        internal virtual UpdateFleetMetadataResponse UpdateFleetMetadata(UpdateFleetMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetMetadataResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateFleetMetadata">REST API Reference for UpdateFleetMetadata Operation</seealso>
        public virtual Task<UpdateFleetMetadataResponse> UpdateFleetMetadataAsync(UpdateFleetMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateIdentityProviderConfiguration

        internal virtual UpdateIdentityProviderConfigurationResponse UpdateIdentityProviderConfiguration(UpdateIdentityProviderConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateIdentityProviderConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateIdentityProviderConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateIdentityProviderConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/worklink-2018-09-25/UpdateIdentityProviderConfiguration">REST API Reference for UpdateIdentityProviderConfiguration Operation</seealso>
        public virtual Task<UpdateIdentityProviderConfigurationResponse> UpdateIdentityProviderConfigurationAsync(UpdateIdentityProviderConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateIdentityProviderConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateIdentityProviderConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateIdentityProviderConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}