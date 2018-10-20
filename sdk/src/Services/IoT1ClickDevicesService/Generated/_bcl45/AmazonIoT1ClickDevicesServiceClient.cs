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
 * Do not modify this file. This file is generated from the iot1click-devices-2018-05-14.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.IoT1ClickDevicesService.Model;
using Amazon.IoT1ClickDevicesService.Model.Internal.MarshallTransformations;
using Amazon.IoT1ClickDevicesService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IoT1ClickDevicesService
{
    /// <summary>
    /// Implementation for accessing IoT1ClickDevicesService
    ///
    /// Stub description
    /// </summary>
    public partial class AmazonIoT1ClickDevicesServiceClient : AmazonServiceClient, IAmazonIoT1ClickDevicesService
    {
        private static IServiceMetadata serviceMetadata = new AmazonIoT1ClickDevicesServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with the credentials loaded from the application's
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
        public AmazonIoT1ClickDevicesServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoT1ClickDevicesServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with the credentials loaded from the application's
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
        public AmazonIoT1ClickDevicesServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonIoT1ClickDevicesServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIoT1ClickDevicesServiceClient Configuration Object</param>
        public AmazonIoT1ClickDevicesServiceClient(AmazonIoT1ClickDevicesServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIoT1ClickDevicesServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonIoT1ClickDevicesServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoT1ClickDevicesServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIoT1ClickDevicesServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Credentials and an
        /// AmazonIoT1ClickDevicesServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIoT1ClickDevicesServiceClient Configuration Object</param>
        public AmazonIoT1ClickDevicesServiceClient(AWSCredentials credentials, AmazonIoT1ClickDevicesServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIoT1ClickDevicesServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoT1ClickDevicesServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoT1ClickDevicesServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIoT1ClickDevicesServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoT1ClickDevicesServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIoT1ClickDevicesServiceClient Configuration Object</param>
        public AmazonIoT1ClickDevicesServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIoT1ClickDevicesServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIoT1ClickDevicesServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoT1ClickDevicesServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIoT1ClickDevicesServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIoT1ClickDevicesServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIoT1ClickDevicesServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIoT1ClickDevicesServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIoT1ClickDevicesServiceClient Configuration Object</param>
        public AmazonIoT1ClickDevicesServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIoT1ClickDevicesServiceConfig clientConfig)
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

        
        #region  ClaimDevicesByClaimCode


        /// <summary>
        /// Adds device(s) to your account (i.e., claim one or more devices) if and only if you
        /// received a claim code with the device(s).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ClaimDevicesByClaimCode service method.</param>
        /// 
        /// <returns>The response from the ClaimDevicesByClaimCode service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ForbiddenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ClaimDevicesByClaimCode">REST API Reference for ClaimDevicesByClaimCode Operation</seealso>
        public virtual ClaimDevicesByClaimCodeResponse ClaimDevicesByClaimCode(ClaimDevicesByClaimCodeRequest request)
        {
            var marshaller = ClaimDevicesByClaimCodeRequestMarshaller.Instance;
            var unmarshaller = ClaimDevicesByClaimCodeResponseUnmarshaller.Instance;

            return Invoke<ClaimDevicesByClaimCodeRequest,ClaimDevicesByClaimCodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ClaimDevicesByClaimCode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ClaimDevicesByClaimCode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ClaimDevicesByClaimCode">REST API Reference for ClaimDevicesByClaimCode Operation</seealso>
        public virtual Task<ClaimDevicesByClaimCodeResponse> ClaimDevicesByClaimCodeAsync(ClaimDevicesByClaimCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ClaimDevicesByClaimCodeRequestMarshaller.Instance;
            var unmarshaller = ClaimDevicesByClaimCodeResponseUnmarshaller.Instance;

            return InvokeAsync<ClaimDevicesByClaimCodeRequest,ClaimDevicesByClaimCodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDevice


        /// <summary>
        /// Given a device ID, returns a DescribeDeviceResponse object describing the details
        /// of the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request)
        {
            var marshaller = DescribeDeviceRequestMarshaller.Instance;
            var unmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return Invoke<DescribeDeviceRequest,DescribeDeviceResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        public virtual Task<DescribeDeviceResponse> DescribeDeviceAsync(DescribeDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeDeviceRequestMarshaller.Instance;
            var unmarshaller = DescribeDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDeviceRequest,DescribeDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  FinalizeDeviceClaim


        /// <summary>
        /// Given a device ID, finalizes the claim request for the associated device.
        /// 
        /// <note> 
        /// <para>
        /// Claiming a device consists of initiating a claim, then publishing a device event,
        /// and finalizing the claim. For a device of type button, a device event can be published
        /// by simply clicking the device.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FinalizeDeviceClaim service method.</param>
        /// 
        /// <returns>The response from the FinalizeDeviceClaim service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/FinalizeDeviceClaim">REST API Reference for FinalizeDeviceClaim Operation</seealso>
        public virtual FinalizeDeviceClaimResponse FinalizeDeviceClaim(FinalizeDeviceClaimRequest request)
        {
            var marshaller = FinalizeDeviceClaimRequestMarshaller.Instance;
            var unmarshaller = FinalizeDeviceClaimResponseUnmarshaller.Instance;

            return Invoke<FinalizeDeviceClaimRequest,FinalizeDeviceClaimResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FinalizeDeviceClaim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FinalizeDeviceClaim operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/FinalizeDeviceClaim">REST API Reference for FinalizeDeviceClaim Operation</seealso>
        public virtual Task<FinalizeDeviceClaimResponse> FinalizeDeviceClaimAsync(FinalizeDeviceClaimRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = FinalizeDeviceClaimRequestMarshaller.Instance;
            var unmarshaller = FinalizeDeviceClaimResponseUnmarshaller.Instance;

            return InvokeAsync<FinalizeDeviceClaimRequest,FinalizeDeviceClaimResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetDeviceMethods


        /// <summary>
        /// Given a device ID, returns the invokable methods associated with the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceMethods service method.</param>
        /// 
        /// <returns>The response from the GetDeviceMethods service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/GetDeviceMethods">REST API Reference for GetDeviceMethods Operation</seealso>
        public virtual GetDeviceMethodsResponse GetDeviceMethods(GetDeviceMethodsRequest request)
        {
            var marshaller = GetDeviceMethodsRequestMarshaller.Instance;
            var unmarshaller = GetDeviceMethodsResponseUnmarshaller.Instance;

            return Invoke<GetDeviceMethodsRequest,GetDeviceMethodsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeviceMethods operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeviceMethods operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/GetDeviceMethods">REST API Reference for GetDeviceMethods Operation</seealso>
        public virtual Task<GetDeviceMethodsResponse> GetDeviceMethodsAsync(GetDeviceMethodsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = GetDeviceMethodsRequestMarshaller.Instance;
            var unmarshaller = GetDeviceMethodsResponseUnmarshaller.Instance;

            return InvokeAsync<GetDeviceMethodsRequest,GetDeviceMethodsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InitiateDeviceClaim


        /// <summary>
        /// Given a device ID, initiates a claim request for the associated device.
        /// 
        /// <note> 
        /// <para>
        /// Claiming a device consists of initiating a claim, then publishing a device event,
        /// and finalizing the claim. For a device of type button, a device event can be published
        /// by simply clicking the device.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InitiateDeviceClaim service method.</param>
        /// 
        /// <returns>The response from the InitiateDeviceClaim service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InitiateDeviceClaim">REST API Reference for InitiateDeviceClaim Operation</seealso>
        public virtual InitiateDeviceClaimResponse InitiateDeviceClaim(InitiateDeviceClaimRequest request)
        {
            var marshaller = InitiateDeviceClaimRequestMarshaller.Instance;
            var unmarshaller = InitiateDeviceClaimResponseUnmarshaller.Instance;

            return Invoke<InitiateDeviceClaimRequest,InitiateDeviceClaimResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateDeviceClaim operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateDeviceClaim operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InitiateDeviceClaim">REST API Reference for InitiateDeviceClaim Operation</seealso>
        public virtual Task<InitiateDeviceClaimResponse> InitiateDeviceClaimAsync(InitiateDeviceClaimRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InitiateDeviceClaimRequestMarshaller.Instance;
            var unmarshaller = InitiateDeviceClaimResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateDeviceClaimRequest,InitiateDeviceClaimResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  InvokeDeviceMethod


        /// <summary>
        /// Given a device ID, issues a request to invoke a named device method (with possible
        /// parameters). See the "Example POST" code snippet below.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InvokeDeviceMethod service method.</param>
        /// 
        /// <returns>The response from the InvokeDeviceMethod service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.RangeNotSatisfiableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InvokeDeviceMethod">REST API Reference for InvokeDeviceMethod Operation</seealso>
        public virtual InvokeDeviceMethodResponse InvokeDeviceMethod(InvokeDeviceMethodRequest request)
        {
            var marshaller = InvokeDeviceMethodRequestMarshaller.Instance;
            var unmarshaller = InvokeDeviceMethodResponseUnmarshaller.Instance;

            return Invoke<InvokeDeviceMethodRequest,InvokeDeviceMethodResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the InvokeDeviceMethod operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InvokeDeviceMethod operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/InvokeDeviceMethod">REST API Reference for InvokeDeviceMethod Operation</seealso>
        public virtual Task<InvokeDeviceMethodResponse> InvokeDeviceMethodAsync(InvokeDeviceMethodRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = InvokeDeviceMethodRequestMarshaller.Instance;
            var unmarshaller = InvokeDeviceMethodResponseUnmarshaller.Instance;

            return InvokeAsync<InvokeDeviceMethodRequest,InvokeDeviceMethodResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDeviceEvents


        /// <summary>
        /// Using a device ID, returns a DeviceEventsResponse object containing an array of events
        /// for the device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents service method.</param>
        /// 
        /// <returns>The response from the ListDeviceEvents service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.RangeNotSatisfiableException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        public virtual ListDeviceEventsResponse ListDeviceEvents(ListDeviceEventsRequest request)
        {
            var marshaller = ListDeviceEventsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;

            return Invoke<ListDeviceEventsRequest,ListDeviceEventsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDeviceEvents">REST API Reference for ListDeviceEvents Operation</seealso>
        public virtual Task<ListDeviceEventsResponse> ListDeviceEventsAsync(ListDeviceEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDeviceEventsRequestMarshaller.Instance;
            var unmarshaller = ListDeviceEventsResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeviceEventsRequest,ListDeviceEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Lists the 1-Click compatible devices associated with your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.RangeNotSatisfiableException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual ListDevicesResponse ListDevices(ListDevicesRequest request)
        {
            var marshaller = ListDevicesRequestMarshaller.Instance;
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return Invoke<ListDevicesRequest,ListDevicesResponse>(request, marshaller, unmarshaller);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/ListDevices">REST API Reference for ListDevices Operation</seealso>
        public virtual Task<ListDevicesResponse> ListDevicesAsync(ListDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListDevicesRequestMarshaller.Instance;
            var unmarshaller = ListDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDevicesRequest,ListDevicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnclaimDevice


        /// <summary>
        /// Disassociates a device from your AWS account using its device ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnclaimDevice service method.</param>
        /// 
        /// <returns>The response from the UnclaimDevice service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UnclaimDevice">REST API Reference for UnclaimDevice Operation</seealso>
        public virtual UnclaimDeviceResponse UnclaimDevice(UnclaimDeviceRequest request)
        {
            var marshaller = UnclaimDeviceRequestMarshaller.Instance;
            var unmarshaller = UnclaimDeviceResponseUnmarshaller.Instance;

            return Invoke<UnclaimDeviceRequest,UnclaimDeviceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnclaimDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnclaimDevice operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UnclaimDevice">REST API Reference for UnclaimDevice Operation</seealso>
        public virtual Task<UnclaimDeviceResponse> UnclaimDeviceAsync(UnclaimDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UnclaimDeviceRequestMarshaller.Instance;
            var unmarshaller = UnclaimDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<UnclaimDeviceRequest,UnclaimDeviceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateDeviceState


        /// <summary>
        /// Using a Boolean value (true or false), this operation enables or disables the device
        /// given a device ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceState service method.</param>
        /// 
        /// <returns>The response from the UpdateDeviceState service method, as returned by IoT1ClickDevicesService.</returns>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InternalFailureException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.InvalidRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.IoT1ClickDevicesService.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UpdateDeviceState">REST API Reference for UpdateDeviceState Operation</seealso>
        public virtual UpdateDeviceStateResponse UpdateDeviceState(UpdateDeviceStateRequest request)
        {
            var marshaller = UpdateDeviceStateRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceStateResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceStateRequest,UpdateDeviceStateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDeviceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeviceState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/devices-2018-05-14/UpdateDeviceState">REST API Reference for UpdateDeviceState Operation</seealso>
        public virtual Task<UpdateDeviceStateResponse> UpdateDeviceStateAsync(UpdateDeviceStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateDeviceStateRequestMarshaller.Instance;
            var unmarshaller = UpdateDeviceStateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceStateRequest,UpdateDeviceStateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}