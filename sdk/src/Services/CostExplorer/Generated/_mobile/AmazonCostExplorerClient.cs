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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.CostExplorer.Model;
using Amazon.CostExplorer.Model.Internal.MarshallTransformations;
using Amazon.CostExplorer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CostExplorer
{
    /// <summary>
    /// Implementation for accessing CostExplorer
    ///
    /// The Cost Explorer API enables you to programmatically query your cost and usage data.
    /// You can query for aggregated data such as total monthly costs or total daily usage.
    /// You can also query for granular data, such as the number of daily write operations
    /// for Amazon DynamoDB database tables in your production environment. 
    /// 
    ///  
    /// <para>
    /// Service Endpoint
    /// </para>
    ///  
    /// <para>
    /// The Cost Explorer API provides the following endpoint:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>https://ce.us-east-1.amazonaws.com</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about costs associated with the Cost Explorer API, see <a href="https://aws.amazon.com/aws-cost-management/pricing/">AWS
    /// Cost Management Pricing</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCostExplorerClient : AmazonServiceClient, IAmazonCostExplorer
    {
        private static IServiceMetadata serviceMetadata = new AmazonCostExplorerMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonCostExplorerClient with the credentials loaded from the application's
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
        public AmazonCostExplorerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCostExplorerConfig()) { }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with the credentials loaded from the application's
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
        public AmazonCostExplorerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCostExplorerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(AmazonCostExplorerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCostExplorerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCostExplorerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostExplorerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCostExplorerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Credentials and an
        /// AmazonCostExplorerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(AWSCredentials credentials, AmazonCostExplorerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostExplorerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCostExplorerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostExplorerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCostExplorerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostExplorerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCostExplorerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCostExplorerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCostExplorerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCostExplorerClient Configuration Object</param>
        public AmazonCostExplorerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCostExplorerConfig clientConfig)
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


        #region  GetCostAndUsage

        internal virtual GetCostAndUsageResponse GetCostAndUsage(GetCostAndUsageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageResponseUnmarshaller.Instance;

            return Invoke<GetCostAndUsageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves cost and usage metrics for your account. You can specify which cost and
        /// usage-related metric, such as <code>BlendedCosts</code> or <code>UsageQuantity</code>,
        /// that you want the request to return. You can also filter and group your data by various
        /// dimensions, such as <code>SERVICE</code> or <code>AZ</code>, in a specific time range.
        /// For a complete list of valid dimensions, see the <a href="http://docs.aws.amazon.com/aws-cost-management/latest/APIReference/API_GetDimensionValues.html">GetDimensionValues</a>
        /// operation. Master accounts in an organization in AWS Organizations have access to
        /// all member accounts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostAndUsage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostAndUsage service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostAndUsage">REST API Reference for GetCostAndUsage Operation</seealso>
        public virtual Task<GetCostAndUsageResponse> GetCostAndUsageAsync(GetCostAndUsageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostAndUsageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostAndUsageResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostAndUsageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCostForecast

        internal virtual GetCostForecastResponse GetCostForecast(GetCostForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostForecastResponseUnmarshaller.Instance;

            return Invoke<GetCostForecastResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a forecast for how much Amazon Web Services predicts that you will spend
        /// over the forecast time period that you select, based on your past costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCostForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCostForecast service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetCostForecast">REST API Reference for GetCostForecast Operation</seealso>
        public virtual Task<GetCostForecastResponse> GetCostForecastAsync(GetCostForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCostForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCostForecastResponseUnmarshaller.Instance;

            return InvokeAsync<GetCostForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDimensionValues

        internal virtual GetDimensionValuesResponse GetDimensionValues(GetDimensionValuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDimensionValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDimensionValuesResponseUnmarshaller.Instance;

            return Invoke<GetDimensionValuesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves all available filter values for a specified filter over a period of time.
        /// You can search the dimension values for an arbitrary string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDimensionValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDimensionValues service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetDimensionValues">REST API Reference for GetDimensionValues Operation</seealso>
        public virtual Task<GetDimensionValuesResponse> GetDimensionValuesAsync(GetDimensionValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDimensionValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDimensionValuesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDimensionValuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReservationCoverage

        internal virtual GetReservationCoverageResponse GetReservationCoverage(GetReservationCoverageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationCoverageResponseUnmarshaller.Instance;

            return Invoke<GetReservationCoverageResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the reservation coverage for your account. This enables you to see how much
        /// of your Amazon Elastic Compute Cloud, Amazon ElastiCache, Amazon Relational Database
        /// Service, or Amazon Redshift usage is covered by a reservation. An organization's master
        /// account can see the coverage of the associated member accounts. For any time period,
        /// you can filter data about reservation usage by the following dimensions:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// AZ
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CACHE_ENGINE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DATABASE_ENGINE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// DEPLOYMENT_OPTION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// INSTANCE_TYPE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// LINKED_ACCOUNT
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPERATING_SYSTEM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PLATFORM
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// REGION
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SERVICE
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TAG
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TENANCY
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To determine valid values for a dimension, use the <code>GetDimensionValues</code>
        /// operation. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationCoverage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationCoverage service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationCoverage">REST API Reference for GetReservationCoverage Operation</seealso>
        public virtual Task<GetReservationCoverageResponse> GetReservationCoverageAsync(GetReservationCoverageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationCoverageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationCoverageResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationCoverageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReservationPurchaseRecommendation

        internal virtual GetReservationPurchaseRecommendationResponse GetReservationPurchaseRecommendation(GetReservationPurchaseRecommendationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationPurchaseRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationPurchaseRecommendationResponseUnmarshaller.Instance;

            return Invoke<GetReservationPurchaseRecommendationResponse>(request, options);
        }



        /// <summary>
        /// Gets recommendations for which reservations to purchase. These recommendations could
        /// help you reduce your costs. Reservations provide a discounted hourly rate (up to 75%)
        /// compared to On-Demand pricing.
        /// 
        ///  
        /// <para>
        /// AWS generates your recommendations by identifying your On-Demand usage during a specific
        /// time period and collecting your usage into categories that are eligible for a reservation.
        /// After AWS has these categories, it simulates every combination of reservations in
        /// each category of usage to identify the best number of each type of RI to purchase
        /// to maximize your estimated savings. 
        /// </para>
        ///  
        /// <para>
        /// For example, AWS automatically aggregates your Amazon EC2 Linux, shared tenancy, and
        /// c4 family usage in the US West (Oregon) Region and recommends that you buy size-flexible
        /// regional reservations to apply to the c4 family usage. AWS recommends the smallest
        /// size instance in an instance family. This makes it easier to purchase a size-flexible
        /// RI. AWS also shows the equal number of normalized units so that you can purchase any
        /// instance size that you want. For this example, your RI recommendation would be for
        /// <code>c4.large</code> because that is the smallest size instance in the c4 instance
        /// family.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationPurchaseRecommendation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationPurchaseRecommendation service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationPurchaseRecommendation">REST API Reference for GetReservationPurchaseRecommendation Operation</seealso>
        public virtual Task<GetReservationPurchaseRecommendationResponse> GetReservationPurchaseRecommendationAsync(GetReservationPurchaseRecommendationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationPurchaseRecommendationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationPurchaseRecommendationResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationPurchaseRecommendationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReservationUtilization

        internal virtual GetReservationUtilizationResponse GetReservationUtilization(GetReservationUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationUtilizationResponseUnmarshaller.Instance;

            return Invoke<GetReservationUtilizationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the reservation utilization for your account. Master accounts in an organization
        /// have access to member accounts. You can filter data by dimensions in a time period.
        /// You can use <code>GetDimensionValues</code> to determine the possible dimension values.
        /// Currently, you can group only by <code>SUBSCRIPTION_ID</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservationUtilization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservationUtilization service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetReservationUtilization">REST API Reference for GetReservationUtilization Operation</seealso>
        public virtual Task<GetReservationUtilizationResponse> GetReservationUtilizationAsync(GetReservationUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservationUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservationUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservationUtilizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTags

        internal virtual GetTagsResponse GetTags(GetTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return Invoke<GetTagsResponse>(request, options);
        }



        /// <summary>
        /// Queries for available tag keys and tag values for a specified period. You can search
        /// the tag values for an arbitrary string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTags service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.BillExpirationException">
        /// The requested report expired. Update the date interval and try again.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.InvalidNextTokenException">
        /// The pagination token is invalid. Try again without a pagination token.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.RequestChangedException">
        /// Your request parameters changed between pages. Try again with the old parameters or
        /// without a pagination token.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetTags">REST API Reference for GetTags Operation</seealso>
        public virtual Task<GetTagsResponse> GetTagsAsync(GetTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTagsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetUsageForecast

        internal virtual GetUsageForecastResponse GetUsageForecast(GetUsageForecastRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageForecastResponseUnmarshaller.Instance;

            return Invoke<GetUsageForecastResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a forecast for how much Amazon Web Services predicts that you will use over
        /// the forecast time period that you select, based on your past usage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUsageForecast service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetUsageForecast service method, as returned by CostExplorer.</returns>
        /// <exception cref="Amazon.CostExplorer.Model.DataUnavailableException">
        /// The requested data is unavailable.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.LimitExceededException">
        /// You made too many calls in a short period of time. Try again later.
        /// </exception>
        /// <exception cref="Amazon.CostExplorer.Model.UnresolvableUsageUnitException">
        /// Cost Explorer was unable to identify the usage unit. Provide <code>UsageType/UsageTypeGroup</code>
        /// filter selections that contain matching units, for example: <code>hours</code>.(
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ce-2017-10-25/GetUsageForecast">REST API Reference for GetUsageForecast Operation</seealso>
        public virtual Task<GetUsageForecastResponse> GetUsageForecastAsync(GetUsageForecastRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetUsageForecastRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetUsageForecastResponseUnmarshaller.Instance;

            return InvokeAsync<GetUsageForecastResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}