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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.ConfigService.Model;
using Amazon.ConfigService.Model.Internal.MarshallTransformations;
using Amazon.ConfigService.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ConfigService
{
    /// <summary>
    /// Implementation for accessing ConfigService
    ///
    /// AWS Config 
    /// <para>
    /// AWS Config provides a way to keep track of the configurations of all the AWS resources
    /// associated with your AWS account. You can use AWS Config to get the current and historical
    /// configurations of each AWS resource and also to get information about the relationship
    /// between the resources. An AWS resource can be an Amazon Compute Cloud (Amazon EC2)
    /// instance, an Elastic Block Store (EBS) volume, an elastic network Interface (ENI),
    /// or a security group. For a complete list of resources currently supported by AWS Config,
    /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/resource-config-reference.html#supported-resources">Supported
    /// AWS Resources</a>.
    /// </para>
    ///  
    /// <para>
    /// You can access and manage AWS Config through the AWS Management Console, the AWS Command
    /// Line Interface (AWS CLI), the AWS Config API, or the AWS SDKs for AWS Config. This
    /// reference guide contains documentation for the AWS Config API and the AWS CLI commands
    /// that you can use to manage AWS Config. The AWS Config API uses the Signature Version
    /// 4 protocol for signing requests. For more information about how to sign a request
    /// with this protocol, see <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4 Signing Process</a>. For detailed information about AWS Config features
    /// and their associated actions or commands, as well as how to work with AWS Management
    /// Console, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/WhatIsConfig.html">What
    /// Is AWS Config</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonConfigServiceClient : AmazonServiceClient, IAmazonConfigService
    {
        private static IServiceMetadata serviceMetadata = new AmazonConfigServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        public AmazonConfigServiceClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConfigServiceConfig()) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        public AmazonConfigServiceClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonConfigServiceConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(AmazonConfigServiceConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonConfigServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonConfigServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Credentials and an
        /// AmazonConfigServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(AWSCredentials credentials, AmazonConfigServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonConfigServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConfigServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonConfigServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConfigServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonConfigServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonConfigServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonConfigServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonConfigServiceClient Configuration Object</param>
        public AmazonConfigServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonConfigServiceConfig clientConfig)
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


        #region  BatchGetAggregateResourceConfig

        /// <summary>
        /// Returns the current configuration items for resources that are present in your AWS
        /// Config aggregator. The operation also returns a list of resources that are not processed
        /// in the current request. If there are no unprocessed resources, the operation returns
        /// an empty <code>unprocessedResourceIdentifiers</code> list. 
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The API does not return results for deleted resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The API does not return tags and relationships.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAggregateResourceConfig service method.</param>
        /// 
        /// <returns>The response from the BatchGetAggregateResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetAggregateResourceConfig">REST API Reference for BatchGetAggregateResourceConfig Operation</seealso>
        public virtual BatchGetAggregateResourceConfigResponse BatchGetAggregateResourceConfig(BatchGetAggregateResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAggregateResourceConfigResponseUnmarshaller.Instance;

            return Invoke<BatchGetAggregateResourceConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetAggregateResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetAggregateResourceConfig operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetAggregateResourceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetAggregateResourceConfig">REST API Reference for BatchGetAggregateResourceConfig Operation</seealso>
        public virtual IAsyncResult BeginBatchGetAggregateResourceConfig(BatchGetAggregateResourceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetAggregateResourceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetAggregateResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetAggregateResourceConfig.</param>
        /// 
        /// <returns>Returns a  BatchGetAggregateResourceConfigResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetAggregateResourceConfig">REST API Reference for BatchGetAggregateResourceConfig Operation</seealso>
        public virtual BatchGetAggregateResourceConfigResponse EndBatchGetAggregateResourceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetAggregateResourceConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  BatchGetResourceConfig

        /// <summary>
        /// Returns the current configuration for one or more requested resources. The operation
        /// also returns a list of resources that are not processed in the current request. If
        /// there are no unprocessed resources, the operation returns an empty unprocessedResourceKeys
        /// list. 
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// The API does not return results for deleted resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  The API does not return any tags for the requested resources. This information is
        /// filtered out of the supplementaryConfiguration section of the API response.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetResourceConfig service method.</param>
        /// 
        /// <returns>The response from the BatchGetResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetResourceConfig">REST API Reference for BatchGetResourceConfig Operation</seealso>
        public virtual BatchGetResourceConfigResponse BatchGetResourceConfig(BatchGetResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetResourceConfigResponseUnmarshaller.Instance;

            return Invoke<BatchGetResourceConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetResourceConfig operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetResourceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetResourceConfig">REST API Reference for BatchGetResourceConfig Operation</seealso>
        public virtual IAsyncResult BeginBatchGetResourceConfig(BatchGetResourceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BatchGetResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BatchGetResourceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetResourceConfig.</param>
        /// 
        /// <returns>Returns a  BatchGetResourceConfigResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/BatchGetResourceConfig">REST API Reference for BatchGetResourceConfig Operation</seealso>
        public virtual BatchGetResourceConfigResponse EndBatchGetResourceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<BatchGetResourceConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAggregationAuthorization

        /// <summary>
        /// Deletes the authorization granted to the specified configuration aggregator account
        /// in a specified region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAggregationAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteAggregationAuthorization service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteAggregationAuthorization">REST API Reference for DeleteAggregationAuthorization Operation</seealso>
        public virtual DeleteAggregationAuthorizationResponse DeleteAggregationAuthorization(DeleteAggregationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAggregationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteAggregationAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAggregationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAggregationAuthorization operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAggregationAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteAggregationAuthorization">REST API Reference for DeleteAggregationAuthorization Operation</seealso>
        public virtual IAsyncResult BeginDeleteAggregationAuthorization(DeleteAggregationAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAggregationAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAggregationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAggregationAuthorization.</param>
        /// 
        /// <returns>Returns a  DeleteAggregationAuthorizationResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteAggregationAuthorization">REST API Reference for DeleteAggregationAuthorization Operation</seealso>
        public virtual DeleteAggregationAuthorizationResponse EndDeleteAggregationAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAggregationAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigRule

        /// <summary>
        /// Deletes the specified AWS Config rule and all of its evaluation results.
        /// 
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to <code>DELETING</code> until the deletion is
        /// complete. You cannot update a rule while it is in this state. If you make a <code>PutConfigRule</code>
        /// or <code>DeleteConfigRule</code> request for the rule, you will receive a <code>ResourceInUseException</code>.
        /// </para>
        ///  
        /// <para>
        /// You can check the state of a rule by using the <code>DescribeConfigRules</code> request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted or the rule is deleting your evaluation results.
        /// Try your request again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigRule">REST API Reference for DeleteConfigRule Operation</seealso>
        public virtual DeleteConfigRuleResponse DeleteConfigRule(DeleteConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigRule">REST API Reference for DeleteConfigRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigRule(DeleteConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigRule.</param>
        /// 
        /// <returns>Returns a  DeleteConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigRule">REST API Reference for DeleteConfigRule Operation</seealso>
        public virtual DeleteConfigRuleResponse EndDeleteConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationAggregator

        /// <summary>
        /// Deletes the specified configuration aggregator and the aggregated data associated
        /// with the aggregator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationAggregator service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationAggregator service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationAggregator">REST API Reference for DeleteConfigurationAggregator Operation</seealso>
        public virtual DeleteConfigurationAggregatorResponse DeleteConfigurationAggregator(DeleteConfigurationAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationAggregatorResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationAggregatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationAggregator operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationAggregator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationAggregator">REST API Reference for DeleteConfigurationAggregator Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationAggregator(DeleteConfigurationAggregatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationAggregatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationAggregator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationAggregator.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationAggregatorResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationAggregator">REST API Reference for DeleteConfigurationAggregator Operation</seealso>
        public virtual DeleteConfigurationAggregatorResponse EndDeleteConfigurationAggregator(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationAggregatorResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConfigurationRecorder

        /// <summary>
        /// Deletes the configuration recorder.
        /// 
        ///  
        /// <para>
        /// After the configuration recorder is deleted, AWS Config will not record resource configuration
        /// changes until you create a new configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// This action does not delete the configuration information that was previously recorded.
        /// You will be able to access the previously recorded information by using the <code>GetResourceConfigHistory</code>
        /// action, but you will not be able to access this information in the AWS Config console
        /// until you create a new configuration recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the DeleteConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationRecorder">REST API Reference for DeleteConfigurationRecorder Operation</seealso>
        public virtual DeleteConfigurationRecorderResponse DeleteConfigurationRecorder(DeleteConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationRecorderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConfigurationRecorder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationRecorder">REST API Reference for DeleteConfigurationRecorder Operation</seealso>
        public virtual IAsyncResult BeginDeleteConfigurationRecorder(DeleteConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  DeleteConfigurationRecorderResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteConfigurationRecorder">REST API Reference for DeleteConfigurationRecorder Operation</seealso>
        public virtual DeleteConfigurationRecorderResponse EndDeleteConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDeliveryChannel

        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel to delete.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        public virtual DeleteDeliveryChannelResponse DeleteDeliveryChannel(string deliveryChannelName)
        {
            var request = new DeleteDeliveryChannelRequest();
            request.DeliveryChannelName = deliveryChannelName;
            return DeleteDeliveryChannel(request);
        }


        /// <summary>
        /// Deletes the delivery channel.
        /// 
        ///  
        /// <para>
        /// Before you can delete the delivery channel, you must stop the configuration recorder
        /// by using the <a>StopConfigurationRecorder</a> action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.LastDeliveryChannelDeleteFailedException">
        /// You cannot delete the delivery channel you specified because the configuration recorder
        /// is running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        public virtual DeleteDeliveryChannelResponse DeleteDeliveryChannel(DeleteDeliveryChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryChannelResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryChannel operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliveryChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeliveryChannel(DeleteDeliveryChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliveryChannel.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryChannelResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteDeliveryChannel">REST API Reference for DeleteDeliveryChannel Operation</seealso>
        public virtual DeleteDeliveryChannelResponse EndDeleteDeliveryChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEvaluationResults

        /// <summary>
        /// Deletes the evaluation results for the specified AWS Config rule. You can specify
        /// one AWS Config rule per request. After you delete the evaluation results, you can
        /// call the <a>StartConfigRulesEvaluation</a> API to start evaluating your AWS resources
        /// against the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluationResults service method.</param>
        /// 
        /// <returns>The response from the DeleteEvaluationResults service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted or the rule is deleting your evaluation results.
        /// Try your request again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteEvaluationResults">REST API Reference for DeleteEvaluationResults Operation</seealso>
        public virtual DeleteEvaluationResultsResponse DeleteEvaluationResults(DeleteEvaluationResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEvaluationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEvaluationResultsResponseUnmarshaller.Instance;

            return Invoke<DeleteEvaluationResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEvaluationResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEvaluationResults operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEvaluationResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteEvaluationResults">REST API Reference for DeleteEvaluationResults Operation</seealso>
        public virtual IAsyncResult BeginDeleteEvaluationResults(DeleteEvaluationResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEvaluationResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEvaluationResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEvaluationResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEvaluationResults.</param>
        /// 
        /// <returns>Returns a  DeleteEvaluationResultsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteEvaluationResults">REST API Reference for DeleteEvaluationResults Operation</seealso>
        public virtual DeleteEvaluationResultsResponse EndDeleteEvaluationResults(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEvaluationResultsResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteOrganizationConfigRule

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationConfigRule service method.</param>
        /// 
        /// <returns>The response from the DeleteOrganizationConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// No permission to call the EnableAWSServiceAccess API.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted or the rule is deleting your evaluation results.
        /// Try your request again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConfigRule">REST API Reference for DeleteOrganizationConfigRule Operation</seealso>
        public virtual DeleteOrganizationConfigRuleResponse DeleteOrganizationConfigRule(DeleteOrganizationConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteOrganizationConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganizationConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteOrganizationConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConfigRule">REST API Reference for DeleteOrganizationConfigRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteOrganizationConfigRule(DeleteOrganizationConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteOrganizationConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOrganizationConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteOrganizationConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteOrganizationConfigRule.</param>
        /// 
        /// <returns>Returns a  DeleteOrganizationConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteOrganizationConfigRule">REST API Reference for DeleteOrganizationConfigRule Operation</seealso>
        public virtual DeleteOrganizationConfigRuleResponse EndDeleteOrganizationConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteOrganizationConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePendingAggregationRequest

        /// <summary>
        /// Deletes pending authorization requests for a specified aggregator account in a specified
        /// region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePendingAggregationRequest service method.</param>
        /// 
        /// <returns>The response from the DeletePendingAggregationRequest service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeletePendingAggregationRequest">REST API Reference for DeletePendingAggregationRequest Operation</seealso>
        public virtual DeletePendingAggregationRequestResponse DeletePendingAggregationRequest(DeletePendingAggregationRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePendingAggregationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePendingAggregationRequestResponseUnmarshaller.Instance;

            return Invoke<DeletePendingAggregationRequestResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePendingAggregationRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePendingAggregationRequest operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePendingAggregationRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeletePendingAggregationRequest">REST API Reference for DeletePendingAggregationRequest Operation</seealso>
        public virtual IAsyncResult BeginDeletePendingAggregationRequest(DeletePendingAggregationRequestRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePendingAggregationRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePendingAggregationRequestResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePendingAggregationRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePendingAggregationRequest.</param>
        /// 
        /// <returns>Returns a  DeletePendingAggregationRequestResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeletePendingAggregationRequest">REST API Reference for DeletePendingAggregationRequest Operation</seealso>
        public virtual DeletePendingAggregationRequestResponse EndDeletePendingAggregationRequest(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePendingAggregationRequestResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRemediationConfiguration

        /// <summary>
        /// Deletes the remediation configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemediationConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteRemediationConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.RemediationInProgressException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationConfiguration">REST API Reference for DeleteRemediationConfiguration Operation</seealso>
        public virtual DeleteRemediationConfigurationResponse DeleteRemediationConfiguration(DeleteRemediationConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRemediationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRemediationConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteRemediationConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRemediationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRemediationConfiguration operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRemediationConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationConfiguration">REST API Reference for DeleteRemediationConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteRemediationConfiguration(DeleteRemediationConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRemediationConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRemediationConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRemediationConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRemediationConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteRemediationConfigurationResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRemediationConfiguration">REST API Reference for DeleteRemediationConfiguration Operation</seealso>
        public virtual DeleteRemediationConfigurationResponse EndDeleteRemediationConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRemediationConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRetentionConfiguration

        /// <summary>
        /// Deletes the retention configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteRetentionConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRetentionConfigurationException">
        /// You have specified a retention configuration that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRetentionConfiguration">REST API Reference for DeleteRetentionConfiguration Operation</seealso>
        public virtual DeleteRetentionConfigurationResponse DeleteRetentionConfiguration(DeleteRetentionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteRetentionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetentionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionConfiguration operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRetentionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRetentionConfiguration">REST API Reference for DeleteRetentionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginDeleteRetentionConfiguration(DeleteRetentionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRetentionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRetentionConfiguration.</param>
        /// 
        /// <returns>Returns a  DeleteRetentionConfigurationResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeleteRetentionConfiguration">REST API Reference for DeleteRetentionConfiguration Operation</seealso>
        public virtual DeleteRetentionConfigurationResponse EndDeleteRetentionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRetentionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  DeliverConfigSnapshot

        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="deliveryChannelName">The name of the delivery channel through which the snapshot is delivered.</param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        public virtual DeliverConfigSnapshotResponse DeliverConfigSnapshot(string deliveryChannelName)
        {
            var request = new DeliverConfigSnapshotRequest();
            request.DeliveryChannelName = deliveryChannelName;
            return DeliverConfigSnapshot(request);
        }


        /// <summary>
        /// Schedules delivery of a configuration snapshot to the Amazon S3 bucket in the specified
        /// delivery channel. After the delivery has started, AWS Config sends the following notifications
        /// using an Amazon SNS topic that you have specified.
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Notification of the start of the delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of the completion of the delivery, if the delivery was successfully completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Notification of delivery failure, if the delivery failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeliverConfigSnapshot service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoRunningConfigurationRecorderException">
        /// There is no configuration recorder running.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        public virtual DeliverConfigSnapshotResponse DeliverConfigSnapshot(DeliverConfigSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeliverConfigSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeliverConfigSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeliverConfigSnapshotResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeliverConfigSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeliverConfigSnapshot operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeliverConfigSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        public virtual IAsyncResult BeginDeliverConfigSnapshot(DeliverConfigSnapshotRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeliverConfigSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeliverConfigSnapshotResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeliverConfigSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeliverConfigSnapshot.</param>
        /// 
        /// <returns>Returns a  DeliverConfigSnapshotResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DeliverConfigSnapshot">REST API Reference for DeliverConfigSnapshot Operation</seealso>
        public virtual DeliverConfigSnapshotResponse EndDeliverConfigSnapshot(IAsyncResult asyncResult)
        {
            return EndInvoke<DeliverConfigSnapshotResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAggregateComplianceByConfigRules

        /// <summary>
        /// Returns a list of compliant and noncompliant rules with the number of resources for
        /// compliant and noncompliant rules. 
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page, but if you have a nextToken, the results
        /// are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateComplianceByConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeAggregateComplianceByConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregateComplianceByConfigRules">REST API Reference for DescribeAggregateComplianceByConfigRules Operation</seealso>
        public virtual DescribeAggregateComplianceByConfigRulesResponse DescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateComplianceByConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateComplianceByConfigRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregateComplianceByConfigRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregateComplianceByConfigRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateComplianceByConfigRules operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAggregateComplianceByConfigRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregateComplianceByConfigRules">REST API Reference for DescribeAggregateComplianceByConfigRules Operation</seealso>
        public virtual IAsyncResult BeginDescribeAggregateComplianceByConfigRules(DescribeAggregateComplianceByConfigRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateComplianceByConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateComplianceByConfigRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAggregateComplianceByConfigRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAggregateComplianceByConfigRules.</param>
        /// 
        /// <returns>Returns a  DescribeAggregateComplianceByConfigRulesResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregateComplianceByConfigRules">REST API Reference for DescribeAggregateComplianceByConfigRules Operation</seealso>
        public virtual DescribeAggregateComplianceByConfigRulesResponse EndDescribeAggregateComplianceByConfigRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAggregateComplianceByConfigRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeAggregationAuthorizations

        /// <summary>
        /// Returns a list of authorizations granted to various aggregator accounts and regions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregationAuthorizations service method.</param>
        /// 
        /// <returns>The response from the DescribeAggregationAuthorizations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregationAuthorizations">REST API Reference for DescribeAggregationAuthorizations Operation</seealso>
        public virtual DescribeAggregationAuthorizationsResponse DescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregationAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregationAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregationAuthorizationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregationAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregationAuthorizations operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAggregationAuthorizations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregationAuthorizations">REST API Reference for DescribeAggregationAuthorizations Operation</seealso>
        public virtual IAsyncResult BeginDescribeAggregationAuthorizations(DescribeAggregationAuthorizationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregationAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregationAuthorizationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAggregationAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAggregationAuthorizations.</param>
        /// 
        /// <returns>Returns a  DescribeAggregationAuthorizationsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeAggregationAuthorizations">REST API Reference for DescribeAggregationAuthorizations Operation</seealso>
        public virtual DescribeAggregationAuthorizationsResponse EndDescribeAggregationAuthorizations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAggregationAuthorizationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComplianceByConfigRule

        /// <summary>
        /// Indicates whether the specified AWS Config rules are compliant. If a rule is noncompliant,
        /// this action returns the number of AWS resources that do not comply with the rule.
        /// 
        ///  
        /// <para>
        /// A rule is compliant if all of the evaluated resources comply with it. It is noncompliant
        /// if any of these resources do not comply.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the rule, it returns <code>INSUFFICIENT_DATA</code>.
        /// This result might indicate one of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
        /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
        /// and <code>LastFailedInvocationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role you assigned to your configuration recorder includes the <code>config:PutEvaluations</code>
        /// permission. If the rule is a custom rule, verify that the AWS Lambda execution role
        /// includes the <code>config:PutEvaluations</code> permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
        /// results. This can occur if the resources were deleted or removed from the rule's scope.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule service method.</param>
        /// 
        /// <returns>The response from the DescribeComplianceByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByConfigRule">REST API Reference for DescribeComplianceByConfigRule Operation</seealso>
        public virtual DescribeComplianceByConfigRuleResponse DescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeComplianceByConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComplianceByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComplianceByConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByConfigRule">REST API Reference for DescribeComplianceByConfigRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeComplianceByConfigRule(DescribeComplianceByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComplianceByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComplianceByConfigRule.</param>
        /// 
        /// <returns>Returns a  DescribeComplianceByConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByConfigRule">REST API Reference for DescribeComplianceByConfigRule Operation</seealso>
        public virtual DescribeComplianceByConfigRuleResponse EndDescribeComplianceByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComplianceByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeComplianceByResource

        /// <summary>
        /// Indicates whether the specified AWS resources are compliant. If a resource is noncompliant,
        /// this action returns the number of AWS Config rules that the resource does not comply
        /// with.
        /// 
        ///  
        /// <para>
        /// A resource is compliant if it complies with all the AWS Config rules that evaluate
        /// it. It is noncompliant if it does not comply with one or more of these rules.
        /// </para>
        ///  
        /// <para>
        /// If AWS Config has no current evaluation results for the resource, it returns <code>INSUFFICIENT_DATA</code>.
        /// This result might indicate one of the following conditions about the rules that evaluate
        /// the resource:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AWS Config has never invoked an evaluation for the rule. To check whether it has,
        /// use the <code>DescribeConfigRuleEvaluationStatus</code> action to get the <code>LastSuccessfulInvocationTime</code>
        /// and <code>LastFailedInvocationTime</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function is failing to send evaluation results to AWS Config.
        /// Verify that the role that you assigned to your configuration recorder includes the
        /// <code>config:PutEvaluations</code> permission. If the rule is a custom rule, verify
        /// that the AWS Lambda execution role includes the <code>config:PutEvaluations</code>
        /// permission.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The rule's AWS Lambda function has returned <code>NOT_APPLICABLE</code> for all evaluation
        /// results. This can occur if the resources were deleted or removed from the rule's scope.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource service method.</param>
        /// 
        /// <returns>The response from the DescribeComplianceByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByResource">REST API Reference for DescribeComplianceByResource Operation</seealso>
        public virtual DescribeComplianceByResourceResponse DescribeComplianceByResource(DescribeComplianceByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByResourceResponseUnmarshaller.Instance;

            return Invoke<DescribeComplianceByResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeComplianceByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeComplianceByResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeComplianceByResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByResource">REST API Reference for DescribeComplianceByResource Operation</seealso>
        public virtual IAsyncResult BeginDescribeComplianceByResource(DescribeComplianceByResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeComplianceByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeComplianceByResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeComplianceByResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeComplianceByResource.</param>
        /// 
        /// <returns>Returns a  DescribeComplianceByResourceResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeComplianceByResource">REST API Reference for DescribeComplianceByResource Operation</seealso>
        public virtual DescribeComplianceByResourceResponse EndDescribeComplianceByResource(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeComplianceByResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigRuleEvaluationStatus

        /// <summary>
        /// Returns status information for each of your AWS managed Config rules. The status includes
        /// information such as the last time AWS Config invoked the rule, the last time AWS Config
        /// failed to invoke the rule, and the related error for the last failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigRuleEvaluationStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRuleEvaluationStatus">REST API Reference for DescribeConfigRuleEvaluationStatus Operation</seealso>
        public virtual DescribeConfigRuleEvaluationStatusResponse DescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRuleEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRuleEvaluationStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigRuleEvaluationStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigRuleEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRuleEvaluationStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigRuleEvaluationStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRuleEvaluationStatus">REST API Reference for DescribeConfigRuleEvaluationStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigRuleEvaluationStatus(DescribeConfigRuleEvaluationStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRuleEvaluationStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRuleEvaluationStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigRuleEvaluationStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigRuleEvaluationStatus.</param>
        /// 
        /// <returns>Returns a  DescribeConfigRuleEvaluationStatusResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRuleEvaluationStatus">REST API Reference for DescribeConfigRuleEvaluationStatus Operation</seealso>
        public virtual DescribeConfigRuleEvaluationStatusResponse EndDescribeConfigRuleEvaluationStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigRuleEvaluationStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigRules

        /// <summary>
        /// Returns details about your AWS Config rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRules">REST API Reference for DescribeConfigRules Operation</seealso>
        public virtual DescribeConfigRulesResponse DescribeConfigRules(DescribeConfigRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigRules operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRules">REST API Reference for DescribeConfigRules Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigRules(DescribeConfigRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigRules.</param>
        /// 
        /// <returns>Returns a  DescribeConfigRulesResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigRules">REST API Reference for DescribeConfigRules Operation</seealso>
        public virtual DescribeConfigRulesResponse EndDescribeConfigRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationAggregators

        /// <summary>
        /// Returns the details of one or more configuration aggregators. If the configuration
        /// aggregator is not specified, this action returns the details for all the configuration
        /// aggregators associated with the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregators service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationAggregators service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregators">REST API Reference for DescribeConfigurationAggregators Operation</seealso>
        public virtual DescribeConfigurationAggregatorsResponse DescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationAggregatorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationAggregators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregators operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationAggregators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregators">REST API Reference for DescribeConfigurationAggregators Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationAggregators(DescribeConfigurationAggregatorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationAggregators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationAggregators.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationAggregatorsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregators">REST API Reference for DescribeConfigurationAggregators Operation</seealso>
        public virtual DescribeConfigurationAggregatorsResponse EndDescribeConfigurationAggregators(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationAggregatorsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationAggregatorSourcesStatus

        /// <summary>
        /// Returns status information for sources within an aggregator. The status includes information
        /// about the last time AWS Config verified authorization between the source account and
        /// an aggregator account. In case of a failure, the status contains the related error
        /// code or message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregatorSourcesStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationAggregatorSourcesStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregatorSourcesStatus">REST API Reference for DescribeConfigurationAggregatorSourcesStatus Operation</seealso>
        public virtual DescribeConfigurationAggregatorSourcesStatusResponse DescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorSourcesStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorSourcesStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationAggregatorSourcesStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationAggregatorSourcesStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationAggregatorSourcesStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationAggregatorSourcesStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregatorSourcesStatus">REST API Reference for DescribeConfigurationAggregatorSourcesStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationAggregatorSourcesStatus(DescribeConfigurationAggregatorSourcesStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationAggregatorSourcesStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationAggregatorSourcesStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationAggregatorSourcesStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationAggregatorSourcesStatus.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationAggregatorSourcesStatusResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationAggregatorSourcesStatus">REST API Reference for DescribeConfigurationAggregatorSourcesStatus Operation</seealso>
        public virtual DescribeConfigurationAggregatorSourcesStatusResponse EndDescribeConfigurationAggregatorSourcesStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationAggregatorSourcesStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationRecorders

        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        public virtual DescribeConfigurationRecordersResponse DescribeConfigurationRecorders()
        {
            return DescribeConfigurationRecorders(new DescribeConfigurationRecordersRequest());
        }

        /// <summary>
        /// Returns the details for the specified configuration recorders. If the configuration
        /// recorder is not specified, this action returns the details for all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorders service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        public virtual DescribeConfigurationRecordersResponse DescribeConfigurationRecorders(DescribeConfigurationRecordersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecordersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecordersResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRecordersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorders operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRecorders
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationRecorders(DescribeConfigurationRecordersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecordersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecordersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRecorders operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRecorders.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRecordersResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorders">REST API Reference for DescribeConfigurationRecorders Operation</seealso>
        public virtual DescribeConfigurationRecordersResponse EndDescribeConfigurationRecorders(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationRecordersResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeConfigurationRecorderStatus

        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        public virtual DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus()
        {
            return DescribeConfigurationRecorderStatus(new DescribeConfigurationRecorderStatusRequest());
        }

        /// <summary>
        /// Returns the current status of the specified configuration recorder. If a configuration
        /// recorder is not specified, this action returns the status of all configuration recorders
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationRecorderStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        public virtual DescribeConfigurationRecorderStatusResponse DescribeConfigurationRecorderStatus(DescribeConfigurationRecorderStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecorderStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationRecorderStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationRecorderStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationRecorderStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConfigurationRecorderStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeConfigurationRecorderStatus(DescribeConfigurationRecorderStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationRecorderStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationRecorderStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConfigurationRecorderStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConfigurationRecorderStatus.</param>
        /// 
        /// <returns>Returns a  DescribeConfigurationRecorderStatusResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeConfigurationRecorderStatus">REST API Reference for DescribeConfigurationRecorderStatus Operation</seealso>
        public virtual DescribeConfigurationRecorderStatusResponse EndDescribeConfigurationRecorderStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeConfigurationRecorderStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeliveryChannels

        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        public virtual DescribeDeliveryChannelsResponse DescribeDeliveryChannels()
        {
            return DescribeDeliveryChannels(new DescribeDeliveryChannelsRequest());
        }

        /// <summary>
        /// Returns details about the specified delivery channel. If a delivery channel is not
        /// specified, this action returns the details of all delivery channels associated with
        /// the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannels service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        public virtual DescribeDeliveryChannelsResponse DescribeDeliveryChannels(DescribeDeliveryChannelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelsResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryChannelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannels operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryChannels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeliveryChannels(DescribeDeliveryChannelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryChannels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryChannels.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryChannelsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannels">REST API Reference for DescribeDeliveryChannels Operation</seealso>
        public virtual DescribeDeliveryChannelsResponse EndDescribeDeliveryChannels(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryChannelsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeDeliveryChannelStatus

        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        public virtual DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus()
        {
            return DescribeDeliveryChannelStatus(new DescribeDeliveryChannelStatusRequest());
        }

        /// <summary>
        /// Returns the current status of the specified delivery channel. If a delivery channel
        /// is not specified, this action returns the current status of all delivery channels
        /// associated with the account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryChannelStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchDeliveryChannelException">
        /// You have specified a delivery channel that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        public virtual DescribeDeliveryChannelStatusResponse DescribeDeliveryChannelStatus(DescribeDeliveryChannelStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryChannelStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryChannelStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryChannelStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryChannelStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeliveryChannelStatus(DescribeDeliveryChannelStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryChannelStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryChannelStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryChannelStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryChannelStatus.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryChannelStatusResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeDeliveryChannelStatus">REST API Reference for DescribeDeliveryChannelStatus Operation</seealso>
        public virtual DescribeDeliveryChannelStatusResponse EndDescribeDeliveryChannelStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryChannelStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrganizationConfigRules

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRules service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfigRules service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// No permission to call the EnableAWSServiceAccess API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRules">REST API Reference for DescribeOrganizationConfigRules Operation</seealso>
        public virtual DescribeOrganizationConfigRulesResponse DescribeOrganizationConfigRules(DescribeOrganizationConfigRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationConfigRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRules operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfigRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRules">REST API Reference for DescribeOrganizationConfigRules Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrganizationConfigRules(DescribeOrganizationConfigRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationConfigRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationConfigRules.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationConfigRulesResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRules">REST API Reference for DescribeOrganizationConfigRules Operation</seealso>
        public virtual DescribeOrganizationConfigRulesResponse EndDescribeOrganizationConfigRules(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationConfigRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeOrganizationConfigRuleStatuses

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRuleStatuses service method.</param>
        /// 
        /// <returns>The response from the DescribeOrganizationConfigRuleStatuses service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// No permission to call the EnableAWSServiceAccess API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRuleStatuses">REST API Reference for DescribeOrganizationConfigRuleStatuses Operation</seealso>
        public virtual DescribeOrganizationConfigRuleStatusesResponse DescribeOrganizationConfigRuleStatuses(DescribeOrganizationConfigRuleStatusesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigRuleStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigRuleStatusesResponseUnmarshaller.Instance;

            return Invoke<DescribeOrganizationConfigRuleStatusesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationConfigRuleStatuses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationConfigRuleStatuses operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOrganizationConfigRuleStatuses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRuleStatuses">REST API Reference for DescribeOrganizationConfigRuleStatuses Operation</seealso>
        public virtual IAsyncResult BeginDescribeOrganizationConfigRuleStatuses(DescribeOrganizationConfigRuleStatusesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeOrganizationConfigRuleStatusesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOrganizationConfigRuleStatusesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeOrganizationConfigRuleStatuses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOrganizationConfigRuleStatuses.</param>
        /// 
        /// <returns>Returns a  DescribeOrganizationConfigRuleStatusesResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeOrganizationConfigRuleStatuses">REST API Reference for DescribeOrganizationConfigRuleStatuses Operation</seealso>
        public virtual DescribeOrganizationConfigRuleStatusesResponse EndDescribeOrganizationConfigRuleStatuses(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeOrganizationConfigRuleStatusesResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribePendingAggregationRequests

        /// <summary>
        /// Returns a list of all pending aggregation requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingAggregationRequests service method.</param>
        /// 
        /// <returns>The response from the DescribePendingAggregationRequests service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribePendingAggregationRequests">REST API Reference for DescribePendingAggregationRequests Operation</seealso>
        public virtual DescribePendingAggregationRequestsResponse DescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingAggregationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingAggregationRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribePendingAggregationRequestsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePendingAggregationRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePendingAggregationRequests operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePendingAggregationRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribePendingAggregationRequests">REST API Reference for DescribePendingAggregationRequests Operation</seealso>
        public virtual IAsyncResult BeginDescribePendingAggregationRequests(DescribePendingAggregationRequestsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePendingAggregationRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePendingAggregationRequestsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePendingAggregationRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePendingAggregationRequests.</param>
        /// 
        /// <returns>Returns a  DescribePendingAggregationRequestsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribePendingAggregationRequests">REST API Reference for DescribePendingAggregationRequests Operation</seealso>
        public virtual DescribePendingAggregationRequestsResponse EndDescribePendingAggregationRequests(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribePendingAggregationRequestsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRemediationConfigurations

        /// <summary>
        /// Returns the details of one or more remediation configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeRemediationConfigurations service method, as returned by ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationConfigurations">REST API Reference for DescribeRemediationConfigurations Operation</seealso>
        public virtual DescribeRemediationConfigurationsResponse DescribeRemediationConfigurations(DescribeRemediationConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRemediationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRemediationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRemediationConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRemediationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationConfigurations operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRemediationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationConfigurations">REST API Reference for DescribeRemediationConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDescribeRemediationConfigurations(DescribeRemediationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRemediationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRemediationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRemediationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRemediationConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeRemediationConfigurationsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationConfigurations">REST API Reference for DescribeRemediationConfigurations Operation</seealso>
        public virtual DescribeRemediationConfigurationsResponse EndDescribeRemediationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRemediationConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRemediationExecutionStatus

        /// <summary>
        /// Provides a detailed view of a Remediation Execution for a set of resources including
        /// state, timestamps for when steps for the remediation execution occur, and any error
        /// messages for steps that have failed. When you specify the limit and the next token,
        /// you receive a paginated response.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationExecutionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeRemediationExecutionStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExecutionStatus">REST API Reference for DescribeRemediationExecutionStatus Operation</seealso>
        public virtual DescribeRemediationExecutionStatusResponse DescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRemediationExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRemediationExecutionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeRemediationExecutionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRemediationExecutionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRemediationExecutionStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRemediationExecutionStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExecutionStatus">REST API Reference for DescribeRemediationExecutionStatus Operation</seealso>
        public virtual IAsyncResult BeginDescribeRemediationExecutionStatus(DescribeRemediationExecutionStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRemediationExecutionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRemediationExecutionStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRemediationExecutionStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRemediationExecutionStatus.</param>
        /// 
        /// <returns>Returns a  DescribeRemediationExecutionStatusResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRemediationExecutionStatus">REST API Reference for DescribeRemediationExecutionStatus Operation</seealso>
        public virtual DescribeRemediationExecutionStatusResponse EndDescribeRemediationExecutionStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRemediationExecutionStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRetentionConfigurations

        /// <summary>
        /// Returns the details of one or more retention configurations. If the retention configuration
        /// name is not specified, this action returns the details for all the retention configurations
        /// for that account.
        /// 
        ///  <note> 
        /// <para>
        /// Currently, AWS Config supports only one retention configuration per region in your
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetentionConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeRetentionConfigurations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRetentionConfigurationException">
        /// You have specified a retention configuration that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRetentionConfigurations">REST API Reference for DescribeRetentionConfigurations Operation</seealso>
        public virtual DescribeRetentionConfigurationsResponse DescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRetentionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRetentionConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRetentionConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRetentionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRetentionConfigurations operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRetentionConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRetentionConfigurations">REST API Reference for DescribeRetentionConfigurations Operation</seealso>
        public virtual IAsyncResult BeginDescribeRetentionConfigurations(DescribeRetentionConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRetentionConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRetentionConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRetentionConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRetentionConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeRetentionConfigurationsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/DescribeRetentionConfigurations">REST API Reference for DescribeRetentionConfigurations Operation</seealso>
        public virtual DescribeRetentionConfigurationsResponse EndDescribeRetentionConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRetentionConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAggregateComplianceDetailsByConfigRule

        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule for a specific resource
        /// in a rule. The results indicate which AWS resources were evaluated by the rule, when
        /// each resource was last evaluated, and whether each resource complies with the rule.
        /// 
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page. But if you have a nextToken, the results
        /// are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateComplianceDetailsByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetAggregateComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateComplianceDetailsByConfigRule">REST API Reference for GetAggregateComplianceDetailsByConfigRule Operation</seealso>
        public virtual GetAggregateComplianceDetailsByConfigRuleResponse GetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetAggregateComplianceDetailsByConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateComplianceDetailsByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAggregateComplianceDetailsByConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateComplianceDetailsByConfigRule">REST API Reference for GetAggregateComplianceDetailsByConfigRule Operation</seealso>
        public virtual IAsyncResult BeginGetAggregateComplianceDetailsByConfigRule(GetAggregateComplianceDetailsByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAggregateComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAggregateComplianceDetailsByConfigRule.</param>
        /// 
        /// <returns>Returns a  GetAggregateComplianceDetailsByConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateComplianceDetailsByConfigRule">REST API Reference for GetAggregateComplianceDetailsByConfigRule Operation</seealso>
        public virtual GetAggregateComplianceDetailsByConfigRuleResponse EndGetAggregateComplianceDetailsByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAggregateComplianceDetailsByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAggregateConfigRuleComplianceSummary

        /// <summary>
        /// Returns the number of compliant and noncompliant rules for one or more accounts and
        /// regions in an aggregator.
        /// 
        ///  <note> 
        /// <para>
        /// The results can return an empty result page, but if you have a nextToken, the results
        /// are displayed on the next page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateConfigRuleComplianceSummary service method.</param>
        /// 
        /// <returns>The response from the GetAggregateConfigRuleComplianceSummary service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateConfigRuleComplianceSummary">REST API Reference for GetAggregateConfigRuleComplianceSummary Operation</seealso>
        public virtual GetAggregateConfigRuleComplianceSummaryResponse GetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateConfigRuleComplianceSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateConfigRuleComplianceSummaryResponseUnmarshaller.Instance;

            return Invoke<GetAggregateConfigRuleComplianceSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateConfigRuleComplianceSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateConfigRuleComplianceSummary operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAggregateConfigRuleComplianceSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateConfigRuleComplianceSummary">REST API Reference for GetAggregateConfigRuleComplianceSummary Operation</seealso>
        public virtual IAsyncResult BeginGetAggregateConfigRuleComplianceSummary(GetAggregateConfigRuleComplianceSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateConfigRuleComplianceSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateConfigRuleComplianceSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAggregateConfigRuleComplianceSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAggregateConfigRuleComplianceSummary.</param>
        /// 
        /// <returns>Returns a  GetAggregateConfigRuleComplianceSummaryResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateConfigRuleComplianceSummary">REST API Reference for GetAggregateConfigRuleComplianceSummary Operation</seealso>
        public virtual GetAggregateConfigRuleComplianceSummaryResponse EndGetAggregateConfigRuleComplianceSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAggregateConfigRuleComplianceSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAggregateDiscoveredResourceCounts

        /// <summary>
        /// Returns the resource counts across accounts and regions that are present in your AWS
        /// Config aggregator. You can request the resource counts by providing filters and GroupByKey.
        /// 
        ///  
        /// <para>
        /// For example, if the input contains accountID 12345678910 and region us-east-1 in filters,
        /// the API returns the count of resources in account ID 12345678910 and region us-east-1.
        /// If the input contains ACCOUNT_ID as a GroupByKey, the API returns resource counts
        /// for all source accounts that are present in your aggregator.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateDiscoveredResourceCounts service method.</param>
        /// 
        /// <returns>The response from the GetAggregateDiscoveredResourceCounts service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateDiscoveredResourceCounts">REST API Reference for GetAggregateDiscoveredResourceCounts Operation</seealso>
        public virtual GetAggregateDiscoveredResourceCountsResponse GetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return Invoke<GetAggregateDiscoveredResourceCountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateDiscoveredResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateDiscoveredResourceCounts operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAggregateDiscoveredResourceCounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateDiscoveredResourceCounts">REST API Reference for GetAggregateDiscoveredResourceCounts Operation</seealso>
        public virtual IAsyncResult BeginGetAggregateDiscoveredResourceCounts(GetAggregateDiscoveredResourceCountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAggregateDiscoveredResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAggregateDiscoveredResourceCounts.</param>
        /// 
        /// <returns>Returns a  GetAggregateDiscoveredResourceCountsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateDiscoveredResourceCounts">REST API Reference for GetAggregateDiscoveredResourceCounts Operation</seealso>
        public virtual GetAggregateDiscoveredResourceCountsResponse EndGetAggregateDiscoveredResourceCounts(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAggregateDiscoveredResourceCountsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAggregateResourceConfig

        /// <summary>
        /// Returns configuration item that is aggregated for your specific resource in a specific
        /// source account and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateResourceConfig service method.</param>
        /// 
        /// <returns>The response from the GetAggregateResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OversizedConfigurationItemException">
        /// The configuration item size is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateResourceConfig">REST API Reference for GetAggregateResourceConfig Operation</seealso>
        public virtual GetAggregateResourceConfigResponse GetAggregateResourceConfig(GetAggregateResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateResourceConfigResponseUnmarshaller.Instance;

            return Invoke<GetAggregateResourceConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAggregateResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAggregateResourceConfig operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAggregateResourceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateResourceConfig">REST API Reference for GetAggregateResourceConfig Operation</seealso>
        public virtual IAsyncResult BeginGetAggregateResourceConfig(GetAggregateResourceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAggregateResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAggregateResourceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAggregateResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAggregateResourceConfig.</param>
        /// 
        /// <returns>Returns a  GetAggregateResourceConfigResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetAggregateResourceConfig">REST API Reference for GetAggregateResourceConfig Operation</seealso>
        public virtual GetAggregateResourceConfigResponse EndGetAggregateResourceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAggregateResourceConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceDetailsByConfigRule

        /// <summary>
        /// Returns the evaluation results for the specified AWS Config rule. The results indicate
        /// which AWS resources were evaluated by the rule, when each resource was last evaluated,
        /// and whether each resource complies with the rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByConfigRule">REST API Reference for GetComplianceDetailsByConfigRule Operation</seealso>
        public virtual GetComplianceDetailsByConfigRuleResponse GetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailsByConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceDetailsByConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByConfigRule">REST API Reference for GetComplianceDetailsByConfigRule Operation</seealso>
        public virtual IAsyncResult BeginGetComplianceDetailsByConfigRule(GetComplianceDetailsByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceDetailsByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceDetailsByConfigRule.</param>
        /// 
        /// <returns>Returns a  GetComplianceDetailsByConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByConfigRule">REST API Reference for GetComplianceDetailsByConfigRule Operation</seealso>
        public virtual GetComplianceDetailsByConfigRuleResponse EndGetComplianceDetailsByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceDetailsByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceDetailsByResource

        /// <summary>
        /// Returns the evaluation results for the specified AWS resource. The results indicate
        /// which AWS Config rules were used to evaluate the resource, when each rule was last
        /// used, and whether the resource complies with each rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource service method.</param>
        /// 
        /// <returns>The response from the GetComplianceDetailsByResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByResource">REST API Reference for GetComplianceDetailsByResource Operation</seealso>
        public virtual GetComplianceDetailsByResourceResponse GetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByResourceResponseUnmarshaller.Instance;

            return Invoke<GetComplianceDetailsByResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceDetailsByResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceDetailsByResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceDetailsByResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByResource">REST API Reference for GetComplianceDetailsByResource Operation</seealso>
        public virtual IAsyncResult BeginGetComplianceDetailsByResource(GetComplianceDetailsByResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceDetailsByResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceDetailsByResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceDetailsByResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceDetailsByResource.</param>
        /// 
        /// <returns>Returns a  GetComplianceDetailsByResourceResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceDetailsByResource">REST API Reference for GetComplianceDetailsByResource Operation</seealso>
        public virtual GetComplianceDetailsByResourceResponse EndGetComplianceDetailsByResource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceDetailsByResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceSummaryByConfigRule

        /// <summary>
        /// Returns the number of AWS Config rules that are compliant and noncompliant, up to
        /// a maximum of 25 for each.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByConfigRule service method, as returned by ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByConfigRule">REST API Reference for GetComplianceSummaryByConfigRule Operation</seealso>
        public virtual GetComplianceSummaryByConfigRuleResponse GetComplianceSummaryByConfigRule(GetComplianceSummaryByConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByConfigRuleResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryByConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummaryByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceSummaryByConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByConfigRule">REST API Reference for GetComplianceSummaryByConfigRule Operation</seealso>
        public virtual IAsyncResult BeginGetComplianceSummaryByConfigRule(GetComplianceSummaryByConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceSummaryByConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceSummaryByConfigRule.</param>
        /// 
        /// <returns>Returns a  GetComplianceSummaryByConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByConfigRule">REST API Reference for GetComplianceSummaryByConfigRule Operation</seealso>
        public virtual GetComplianceSummaryByConfigRuleResponse EndGetComplianceSummaryByConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceSummaryByConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComplianceSummaryByResourceType

        /// <summary>
        /// Returns the number of resources that are compliant and the number that are noncompliant.
        /// You can specify one or more resource types to get these numbers for each resource
        /// type. The maximum number returned is 100.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType service method.</param>
        /// 
        /// <returns>The response from the GetComplianceSummaryByResourceType service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByResourceType">REST API Reference for GetComplianceSummaryByResourceType Operation</seealso>
        public virtual GetComplianceSummaryByResourceTypeResponse GetComplianceSummaryByResourceType(GetComplianceSummaryByResourceTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByResourceTypeResponseUnmarshaller.Instance;

            return Invoke<GetComplianceSummaryByResourceTypeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComplianceSummaryByResourceType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComplianceSummaryByResourceType operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComplianceSummaryByResourceType
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByResourceType">REST API Reference for GetComplianceSummaryByResourceType Operation</seealso>
        public virtual IAsyncResult BeginGetComplianceSummaryByResourceType(GetComplianceSummaryByResourceTypeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComplianceSummaryByResourceTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComplianceSummaryByResourceTypeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComplianceSummaryByResourceType operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComplianceSummaryByResourceType.</param>
        /// 
        /// <returns>Returns a  GetComplianceSummaryByResourceTypeResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetComplianceSummaryByResourceType">REST API Reference for GetComplianceSummaryByResourceType Operation</seealso>
        public virtual GetComplianceSummaryByResourceTypeResponse EndGetComplianceSummaryByResourceType(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComplianceSummaryByResourceTypeResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDiscoveredResourceCounts

        /// <summary>
        /// Returns the resource types, the number of each resource type, and the total number
        /// of resources that AWS Config is recording in this region for your AWS account. 
        /// 
        ///  <p class="title"> <b>Example</b> 
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// AWS Config is recording three resource types in the US East (Ohio) Region for your
        /// account: 25 EC2 instances, 20 IAM users, and 15 S3 buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You make a call to the <code>GetDiscoveredResourceCounts</code> action and specify
        /// that you want all resource types. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config returns the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The resource types (EC2 instances, IAM users, and S3 buckets).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The number of each resource type (25, 20, and 15).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The total number of all resources (60).
        /// </para>
        ///  </li> </ul> </li> </ol> 
        /// <para>
        /// The response is paginated. By default, AWS Config lists 100 <a>ResourceCount</a> objects
        /// on each page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you make a call to the <a>GetDiscoveredResourceCounts</a> action, you might not
        /// immediately receive resource counts in the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You are a new AWS Config customer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You just enabled resource recording.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It might take a few minutes for AWS Config to record and count your resources. Wait
        /// a few minutes and then retry the <a>GetDiscoveredResourceCounts</a> action. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredResourceCounts service method.</param>
        /// 
        /// <returns>The response from the GetDiscoveredResourceCounts service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetDiscoveredResourceCounts">REST API Reference for GetDiscoveredResourceCounts Operation</seealso>
        public virtual GetDiscoveredResourceCountsResponse GetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return Invoke<GetDiscoveredResourceCountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDiscoveredResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDiscoveredResourceCounts operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDiscoveredResourceCounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetDiscoveredResourceCounts">REST API Reference for GetDiscoveredResourceCounts Operation</seealso>
        public virtual IAsyncResult BeginGetDiscoveredResourceCounts(GetDiscoveredResourceCountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDiscoveredResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDiscoveredResourceCountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDiscoveredResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDiscoveredResourceCounts.</param>
        /// 
        /// <returns>Returns a  GetDiscoveredResourceCountsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetDiscoveredResourceCounts">REST API Reference for GetDiscoveredResourceCounts Operation</seealso>
        public virtual GetDiscoveredResourceCountsResponse EndGetDiscoveredResourceCounts(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDiscoveredResourceCountsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetOrganizationConfigRuleDetailedStatus

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationConfigRuleDetailedStatus service method.</param>
        /// 
        /// <returns>The response from the GetOrganizationConfigRuleDetailedStatus service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchOrganizationConfigRuleException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// No permission to call the EnableAWSServiceAccess API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConfigRuleDetailedStatus">REST API Reference for GetOrganizationConfigRuleDetailedStatus Operation</seealso>
        public virtual GetOrganizationConfigRuleDetailedStatusResponse GetOrganizationConfigRuleDetailedStatus(GetOrganizationConfigRuleDetailedStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationConfigRuleDetailedStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationConfigRuleDetailedStatusResponseUnmarshaller.Instance;

            return Invoke<GetOrganizationConfigRuleDetailedStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationConfigRuleDetailedStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationConfigRuleDetailedStatus operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetOrganizationConfigRuleDetailedStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConfigRuleDetailedStatus">REST API Reference for GetOrganizationConfigRuleDetailedStatus Operation</seealso>
        public virtual IAsyncResult BeginGetOrganizationConfigRuleDetailedStatus(GetOrganizationConfigRuleDetailedStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetOrganizationConfigRuleDetailedStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetOrganizationConfigRuleDetailedStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetOrganizationConfigRuleDetailedStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetOrganizationConfigRuleDetailedStatus.</param>
        /// 
        /// <returns>Returns a  GetOrganizationConfigRuleDetailedStatusResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetOrganizationConfigRuleDetailedStatus">REST API Reference for GetOrganizationConfigRuleDetailedStatus Operation</seealso>
        public virtual GetOrganizationConfigRuleDetailedStatusResponse EndGetOrganizationConfigRuleDetailedStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetOrganizationConfigRuleDetailedStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourceConfigHistory

        /// <summary>
        /// Returns a list of configuration items for the specified resource. The list contains
        /// details about each state of the resource during the specified time interval. If you
        /// specified a retention period to retain your <code>ConfigurationItems</code> between
        /// a minimum of 30 days and a maximum of 7 years (2557 days), AWS Config returns the
        /// <code>ConfigurationItems</code> for the specified retention period. 
        /// 
        ///  
        /// <para>
        /// The response is paginated. By default, AWS Config returns a limit of 10 configuration
        /// items per page. You can customize this number with the <code>limit</code> parameter.
        /// The response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        ///  <note> 
        /// <para>
        /// Each call to the API is limited to span a duration of seven days. It is likely that
        /// the number of records returned is smaller than the specified <code>limit</code>. In
        /// such cases, you can make another call, using the <code>nextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory service method.</param>
        /// 
        /// <returns>The response from the GetResourceConfigHistory service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidTimeRangeException">
        /// The specified time range is not valid. The earlier time is not chronologically before
        /// the later time.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotDiscoveredException">
        /// You have specified a resource that is either unknown or has not been discovered.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetResourceConfigHistory">REST API Reference for GetResourceConfigHistory Operation</seealso>
        public virtual GetResourceConfigHistoryResponse GetResourceConfigHistory(GetResourceConfigHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceConfigHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceConfigHistoryResponseUnmarshaller.Instance;

            return Invoke<GetResourceConfigHistoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourceConfigHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourceConfigHistory operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourceConfigHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetResourceConfigHistory">REST API Reference for GetResourceConfigHistory Operation</seealso>
        public virtual IAsyncResult BeginGetResourceConfigHistory(GetResourceConfigHistoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourceConfigHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourceConfigHistoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourceConfigHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourceConfigHistory.</param>
        /// 
        /// <returns>Returns a  GetResourceConfigHistoryResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/GetResourceConfigHistory">REST API Reference for GetResourceConfigHistory Operation</seealso>
        public virtual GetResourceConfigHistoryResponse EndGetResourceConfigHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourceConfigHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAggregateDiscoveredResources

        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers that are aggregated
        /// for a specific resource type across accounts and regions. A resource identifier includes
        /// the resource type, ID, (if available) the custom resource name, source account, and
        /// source region. You can narrow the results to include only resources that have specific
        /// resource IDs, or a resource name, or source account ID, or source region.
        /// 
        ///  
        /// <para>
        /// For example, if the input consists of accountID 12345678910 and the region is us-east-1
        /// for resource type <code>AWS::EC2::Instance</code> then the API returns all the EC2
        /// instance identifiers of accountID 12345678910 and region us-east-1.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListAggregateDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationAggregatorException">
        /// You have specified a configuration aggregator that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListAggregateDiscoveredResources">REST API Reference for ListAggregateDiscoveredResources Operation</seealso>
        public virtual ListAggregateDiscoveredResourcesResponse ListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAggregateDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregateDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListAggregateDiscoveredResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAggregateDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAggregateDiscoveredResources operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAggregateDiscoveredResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListAggregateDiscoveredResources">REST API Reference for ListAggregateDiscoveredResources Operation</seealso>
        public virtual IAsyncResult BeginListAggregateDiscoveredResources(ListAggregateDiscoveredResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAggregateDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAggregateDiscoveredResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAggregateDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAggregateDiscoveredResources.</param>
        /// 
        /// <returns>Returns a  ListAggregateDiscoveredResourcesResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListAggregateDiscoveredResources">REST API Reference for ListAggregateDiscoveredResources Operation</seealso>
        public virtual ListAggregateDiscoveredResourcesResponse EndListAggregateDiscoveredResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAggregateDiscoveredResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDiscoveredResources

        /// <summary>
        /// Accepts a resource type and returns a list of resource identifiers for the resources
        /// of that type. A resource identifier includes the resource type, ID, and (if available)
        /// the custom resource name. The results consist of resources that AWS Config has discovered,
        /// including those that AWS Config is not currently recording. You can narrow the results
        /// to include only resources that have specific resource IDs or a resource name.
        /// 
        ///  <note> 
        /// <para>
        /// You can specify either resource IDs or a resource name, but not both, in the same
        /// request.
        /// </para>
        ///  </note> 
        /// <para>
        /// The response is paginated. By default, AWS Config lists 100 resource identifiers on
        /// each page. You can customize this number with the <code>limit</code> parameter. The
        /// response includes a <code>nextToken</code> string. To get the next page of results,
        /// run the request again and specify the string for the <code>nextToken</code> parameter.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources service method.</param>
        /// 
        /// <returns>The response from the ListDiscoveredResources service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual ListDiscoveredResourcesResponse ListDiscoveredResources(ListDiscoveredResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return Invoke<ListDiscoveredResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDiscoveredResources operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDiscoveredResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual IAsyncResult BeginListDiscoveredResources(ListDiscoveredResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDiscoveredResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDiscoveredResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDiscoveredResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDiscoveredResources.</param>
        /// 
        /// <returns>Returns a  ListDiscoveredResourcesResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListDiscoveredResources">REST API Reference for ListDiscoveredResources Operation</seealso>
        public virtual ListDiscoveredResourcesResponse EndListDiscoveredResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDiscoveredResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List the tags for AWS Config resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutAggregationAuthorization

        /// <summary>
        /// Authorizes the aggregator account and region to collect data from the source account
        /// and region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAggregationAuthorization service method.</param>
        /// 
        /// <returns>The response from the PutAggregationAuthorization service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutAggregationAuthorization">REST API Reference for PutAggregationAuthorization Operation</seealso>
        public virtual PutAggregationAuthorizationResponse PutAggregationAuthorization(PutAggregationAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAggregationAuthorizationResponseUnmarshaller.Instance;

            return Invoke<PutAggregationAuthorizationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAggregationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAggregationAuthorization operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAggregationAuthorization
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutAggregationAuthorization">REST API Reference for PutAggregationAuthorization Operation</seealso>
        public virtual IAsyncResult BeginPutAggregationAuthorization(PutAggregationAuthorizationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAggregationAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAggregationAuthorizationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAggregationAuthorization operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAggregationAuthorization.</param>
        /// 
        /// <returns>Returns a  PutAggregationAuthorizationResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutAggregationAuthorization">REST API Reference for PutAggregationAuthorization Operation</seealso>
        public virtual PutAggregationAuthorizationResponse EndPutAggregationAuthorization(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAggregationAuthorizationResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfigRule

        /// <summary>
        /// Adds or updates an AWS Config rule for evaluating whether your AWS resources comply
        /// with your desired configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action for custom AWS Config rules and AWS managed Config rules.
        /// A custom AWS Config rule is a rule that you develop and maintain. An AWS managed Config
        /// rule is a customizable, predefined rule that AWS Config provides.
        /// </para>
        ///  
        /// <para>
        /// If you are adding a new custom AWS Config rule, you must first create the AWS Lambda
        /// function that the rule invokes to evaluate your resources. When you use the <code>PutConfigRule</code>
        /// action to add the rule to AWS Config, you must specify the Amazon Resource Name (ARN)
        /// that AWS Lambda assigns to the function. Specify the ARN for the <code>SourceIdentifier</code>
        /// key. This key is part of the <code>Source</code> object, which is part of the <code>ConfigRule</code>
        /// object. 
        /// </para>
        ///  
        /// <para>
        /// If you are adding an AWS managed Config rule, specify the rule's identifier for the
        /// <code>SourceIdentifier</code> key. To reference AWS managed Config rule identifiers,
        /// see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config_use-managed-rules.html">About
        /// AWS Managed Config Rules</a>.
        /// </para>
        ///  
        /// <para>
        /// For any new rule that you add, specify the <code>ConfigRuleName</code> in the <code>ConfigRule</code>
        /// object. Do not specify the <code>ConfigRuleArn</code> or the <code>ConfigRuleId</code>.
        /// These values are generated by AWS Config for new rules.
        /// </para>
        ///  
        /// <para>
        /// If you are updating a rule that you added previously, you can specify the rule by
        /// <code>ConfigRuleName</code>, <code>ConfigRuleId</code>, or <code>ConfigRuleArn</code>
        /// in the <code>ConfigRule</code> data type that you use in this request.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of rules that AWS Config supports is 150.
        /// </para>
        ///  
        /// <para>
        /// For information about requesting a rule limit increase, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_config">AWS
        /// Config Limits</a> in the <i>AWS General Reference Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about developing and using AWS Config rules, see <a href="https://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
        /// AWS Resource Configurations with AWS Config</a> in the <i>AWS Config Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule service method.</param>
        /// 
        /// <returns>The response from the PutConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The rule cannot be created because the IAM role assigned to AWS Config lacks permissions
        /// to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The AWS Lambda function cannot be invoked. Check the function ARN, and check the function's
        /// permissions.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigRulesExceededException">
        /// Failed to add the AWS Config rule because the account already contains the maximum
        /// number of 150 rules. Consider deleting any deactivated rules before you add new rules.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted or the rule is deleting your evaluation results.
        /// Try your request again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigRule">REST API Reference for PutConfigRule Operation</seealso>
        public virtual PutConfigRuleResponse PutConfigRule(PutConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigRuleResponseUnmarshaller.Instance;

            return Invoke<PutConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigRule">REST API Reference for PutConfigRule Operation</seealso>
        public virtual IAsyncResult BeginPutConfigRule(PutConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigRule.</param>
        /// 
        /// <returns>Returns a  PutConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigRule">REST API Reference for PutConfigRule Operation</seealso>
        public virtual PutConfigRuleResponse EndPutConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfigurationAggregator

        /// <summary>
        /// Creates and updates the configuration aggregator with the selected source accounts
        /// and regions. The source account can be individual account(s) or an organization.
        /// 
        ///  <note> 
        /// <para>
        /// AWS Config should be enabled in source accounts and regions you want to aggregate.
        /// </para>
        ///  
        /// <para>
        /// If your source type is an organization, you must be signed in to the master account
        /// and all features must be enabled in your organization. AWS Config calls <code>EnableAwsServiceAccess</code>
        /// API to enable integration between AWS Config and AWS Organizations. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationAggregator service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationAggregator service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.LimitExceededException">
        /// For <code>StartConfigRulesEvaluation</code> API, this exception is thrown if an evaluation
        /// is in progress or if you call the <a>StartConfigRulesEvaluation</a> API more than
        /// once per minute.
        /// 
        ///  
        /// <para>
        /// For <code>PutConfigurationAggregator</code> API, this exception is thrown if the number
        /// of accounts and aggregators exceeds the limit.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization does is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// No permission to call the EnableAWSServiceAccess API.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// The configuration aggregator cannot be created because organization does not have
        /// all features enabled.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationAggregator">REST API Reference for PutConfigurationAggregator Operation</seealso>
        public virtual PutConfigurationAggregatorResponse PutConfigurationAggregator(PutConfigurationAggregatorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationAggregatorResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationAggregatorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationAggregator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationAggregator operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationAggregator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationAggregator">REST API Reference for PutConfigurationAggregator Operation</seealso>
        public virtual IAsyncResult BeginPutConfigurationAggregator(PutConfigurationAggregatorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationAggregatorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationAggregatorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationAggregator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationAggregator.</param>
        /// 
        /// <returns>Returns a  PutConfigurationAggregatorResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationAggregator">REST API Reference for PutConfigurationAggregator Operation</seealso>
        public virtual PutConfigurationAggregatorResponse EndPutConfigurationAggregator(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfigurationAggregatorResponse>(asyncResult);
        }

        #endregion
        
        #region  PutConfigurationRecorder

        /// <summary>
        /// Creates a new configuration recorder to record the selected resource configurations.
        /// 
        ///  
        /// <para>
        /// You can use this action to change the role <code>roleARN</code> or the <code>recordingGroup</code>
        /// of an existing recorder. To change the role, call the action on the existing configuration
        /// recorder and specify a role.
        /// </para>
        ///  <note> 
        /// <para>
        /// Currently, you can specify only one configuration recorder per region in your account.
        /// </para>
        ///  
        /// <para>
        /// If <code>ConfigurationRecorder</code> does not have the <b>recordingGroup</b> parameter
        /// specified, the default is to record all supported resource types.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the PutConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidConfigurationRecorderNameException">
        /// You have provided a configuration recorder name that is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRecordingGroupException">
        /// AWS Config throws an exception if the recording group does not contain a valid list
        /// of resource types. Invalid values might also be incorrectly formatted.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidRoleException">
        /// You have provided a null or empty role ARN.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfConfigurationRecordersExceededException">
        /// You have reached the limit of the number of recorders you can create.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationRecorder">REST API Reference for PutConfigurationRecorder Operation</seealso>
        public virtual PutConfigurationRecorderResponse PutConfigurationRecorder(PutConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<PutConfigurationRecorderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutConfigurationRecorder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationRecorder">REST API Reference for PutConfigurationRecorder Operation</seealso>
        public virtual IAsyncResult BeginPutConfigurationRecorder(PutConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  PutConfigurationRecorderResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutConfigurationRecorder">REST API Reference for PutConfigurationRecorder Operation</seealso>
        public virtual PutConfigurationRecorderResponse EndPutConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<PutConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDeliveryChannel

        /// <summary>
        /// Creates a delivery channel object to deliver configuration information to an Amazon
        /// S3 bucket and Amazon SNS topic.
        /// 
        ///  
        /// <para>
        /// Before you can create a delivery channel, you must create a configuration recorder.
        /// </para>
        ///  
        /// <para>
        /// You can use this action to change the Amazon S3 bucket or an Amazon SNS topic of the
        /// existing delivery channel. To change the Amazon S3 bucket or an Amazon SNS topic,
        /// call this action and specify the changed values for the S3 bucket and the SNS topic.
        /// If you specify a different value for either the S3 bucket or the SNS topic, this action
        /// will keep the existing value for the parameter that is not changed.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can have only one delivery channel per region in your account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel service method.</param>
        /// 
        /// <returns>The response from the PutDeliveryChannel service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientDeliveryPolicyException">
        /// Your Amazon S3 bucket policy does not permit AWS Config to write to it.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidDeliveryChannelNameException">
        /// The specified delivery channel name is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidS3KeyPrefixException">
        /// The specified Amazon S3 key prefix is not valid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidSNSTopicARNException">
        /// The specified Amazon SNS topic does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfDeliveryChannelsExceededException">
        /// You have reached the limit of the number of delivery channels you can create.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableConfigurationRecorderException">
        /// There are no configuration recorders available to provide the role needed to describe
        /// your resources. Create a configuration recorder.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchBucketException">
        /// The specified Amazon S3 bucket does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutDeliveryChannel">REST API Reference for PutDeliveryChannel Operation</seealso>
        public virtual PutDeliveryChannelResponse PutDeliveryChannel(PutDeliveryChannelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryChannelResponseUnmarshaller.Instance;

            return Invoke<PutDeliveryChannelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryChannel operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliveryChannel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutDeliveryChannel">REST API Reference for PutDeliveryChannel Operation</seealso>
        public virtual IAsyncResult BeginPutDeliveryChannel(PutDeliveryChannelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryChannelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryChannelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliveryChannel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliveryChannel.</param>
        /// 
        /// <returns>Returns a  PutDeliveryChannelResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutDeliveryChannel">REST API Reference for PutDeliveryChannel Operation</seealso>
        public virtual PutDeliveryChannelResponse EndPutDeliveryChannel(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDeliveryChannelResponse>(asyncResult);
        }

        #endregion
        
        #region  PutEvaluations

        /// <summary>
        /// Used by an AWS Lambda function to deliver evaluation results to AWS Config. This action
        /// is required in every AWS Lambda function that is invoked by an AWS Config rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations service method.</param>
        /// 
        /// <returns>The response from the PutEvaluations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidResultTokenException">
        /// The specified <code>ResultToken</code> is invalid.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutEvaluations">REST API Reference for PutEvaluations Operation</seealso>
        public virtual PutEvaluationsResponse PutEvaluations(PutEvaluationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEvaluationsResponseUnmarshaller.Instance;

            return Invoke<PutEvaluationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutEvaluations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutEvaluations operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutEvaluations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutEvaluations">REST API Reference for PutEvaluations Operation</seealso>
        public virtual IAsyncResult BeginPutEvaluations(PutEvaluationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutEvaluationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutEvaluationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutEvaluations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutEvaluations.</param>
        /// 
        /// <returns>Returns a  PutEvaluationsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutEvaluations">REST API Reference for PutEvaluations Operation</seealso>
        public virtual PutEvaluationsResponse EndPutEvaluations(IAsyncResult asyncResult)
        {
            return EndInvoke<PutEvaluationsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutOrganizationConfigRule

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationConfigRule service method.</param>
        /// 
        /// <returns>The response from the PutOrganizationConfigRule service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The rule cannot be created because the IAM role assigned to AWS Config lacks permissions
        /// to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The AWS Lambda function cannot be invoked. Check the function ARN, and check the function's
        /// permissions.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfOrganizationConfigRulesExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableOrganizationException">
        /// Organization does is no longer available.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAccessDeniedException">
        /// No permission to call the EnableAWSServiceAccess API.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.OrganizationAllFeaturesNotEnabledException">
        /// The configuration aggregator cannot be created because organization does not have
        /// all features enabled.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted or the rule is deleting your evaluation results.
        /// Try your request again later.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConfigRule">REST API Reference for PutOrganizationConfigRule Operation</seealso>
        public virtual PutOrganizationConfigRuleResponse PutOrganizationConfigRule(PutOrganizationConfigRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOrganizationConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOrganizationConfigRuleResponseUnmarshaller.Instance;

            return Invoke<PutOrganizationConfigRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutOrganizationConfigRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutOrganizationConfigRule operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutOrganizationConfigRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConfigRule">REST API Reference for PutOrganizationConfigRule Operation</seealso>
        public virtual IAsyncResult BeginPutOrganizationConfigRule(PutOrganizationConfigRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutOrganizationConfigRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOrganizationConfigRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutOrganizationConfigRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutOrganizationConfigRule.</param>
        /// 
        /// <returns>Returns a  PutOrganizationConfigRuleResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutOrganizationConfigRule">REST API Reference for PutOrganizationConfigRule Operation</seealso>
        public virtual PutOrganizationConfigRuleResponse EndPutOrganizationConfigRule(IAsyncResult asyncResult)
        {
            return EndInvoke<PutOrganizationConfigRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRemediationConfigurations

        /// <summary>
        /// Adds or updates the remediation configuration with a specific AWS Config rule with
        /// the selected target or action. The API creates the <code>RemediationConfiguration</code>
        /// object for the AWS Config rule. The AWS Config rule must already exist for you to
        /// add a remediation configuration. The target (SSM document) must exist and have permissions
        /// to use the target.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRemediationConfigurations service method.</param>
        /// 
        /// <returns>The response from the PutRemediationConfigurations service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The rule cannot be created because the IAM role assigned to AWS Config lacks permissions
        /// to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The AWS Lambda function cannot be invoked. Check the function ARN, and check the function's
        /// permissions.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationConfigurations">REST API Reference for PutRemediationConfigurations Operation</seealso>
        public virtual PutRemediationConfigurationsResponse PutRemediationConfigurations(PutRemediationConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRemediationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRemediationConfigurationsResponseUnmarshaller.Instance;

            return Invoke<PutRemediationConfigurationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRemediationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRemediationConfigurations operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRemediationConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationConfigurations">REST API Reference for PutRemediationConfigurations Operation</seealso>
        public virtual IAsyncResult BeginPutRemediationConfigurations(PutRemediationConfigurationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRemediationConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRemediationConfigurationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRemediationConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRemediationConfigurations.</param>
        /// 
        /// <returns>Returns a  PutRemediationConfigurationsResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRemediationConfigurations">REST API Reference for PutRemediationConfigurations Operation</seealso>
        public virtual PutRemediationConfigurationsResponse EndPutRemediationConfigurations(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRemediationConfigurationsResponse>(asyncResult);
        }

        #endregion
        
        #region  PutRetentionConfiguration

        /// <summary>
        /// Creates and updates the retention configuration with details about retention period
        /// (number of days) that AWS Config stores your historical information. The API creates
        /// the <code>RetentionConfiguration</code> object and names the object as <b>default</b>.
        /// When you have a <code>RetentionConfiguration</code> object named <b>default</b>, calling
        /// the API modifies the default object. 
        /// 
        ///  <note> 
        /// <para>
        /// Currently, AWS Config supports only one retention configuration per region in your
        /// account.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionConfiguration service method.</param>
        /// 
        /// <returns>The response from the PutRetentionConfiguration service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.MaxNumberOfRetentionConfigurationsExceededException">
        /// Failed to add the retention configuration because a retention configuration with that
        /// name already exists.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRetentionConfiguration">REST API Reference for PutRetentionConfiguration Operation</seealso>
        public virtual PutRetentionConfigurationResponse PutRetentionConfiguration(PutRetentionConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutRetentionConfigurationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionConfiguration operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRetentionConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRetentionConfiguration">REST API Reference for PutRetentionConfiguration Operation</seealso>
        public virtual IAsyncResult BeginPutRetentionConfiguration(PutRetentionConfigurationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionConfigurationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRetentionConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRetentionConfiguration.</param>
        /// 
        /// <returns>Returns a  PutRetentionConfigurationResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/PutRetentionConfiguration">REST API Reference for PutRetentionConfiguration Operation</seealso>
        public virtual PutRetentionConfigurationResponse EndPutRetentionConfiguration(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRetentionConfigurationResponse>(asyncResult);
        }

        #endregion
        
        #region  SelectResourceConfig

        /// <summary>
        /// Accepts a structured query language (SQL) <code>SELECT</code> command, performs the
        /// corresponding search, and returns resource configurations matching the properties.
        /// 
        ///  
        /// <para>
        /// For more information about query components, see the <a href="https://docs.aws.amazon.com/config/latest/developerguide/query-components.html">
        /// <b>Query Components</b> </a> section in the AWS Config Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SelectResourceConfig service method.</param>
        /// 
        /// <returns>The response from the SelectResourceConfig service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidExpressionException">
        /// The syntax of the query is incorrect.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidLimitException">
        /// The specified limit is outside the allowable range.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.InvalidNextTokenException">
        /// The specified next token is invalid. Specify the <code>nextToken</code> string that
        /// was returned in the previous response to get the next page of results.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/SelectResourceConfig">REST API Reference for SelectResourceConfig Operation</seealso>
        public virtual SelectResourceConfigResponse SelectResourceConfig(SelectResourceConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectResourceConfigResponseUnmarshaller.Instance;

            return Invoke<SelectResourceConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SelectResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SelectResourceConfig operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSelectResourceConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/SelectResourceConfig">REST API Reference for SelectResourceConfig Operation</seealso>
        public virtual IAsyncResult BeginSelectResourceConfig(SelectResourceConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectResourceConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectResourceConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  SelectResourceConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSelectResourceConfig.</param>
        /// 
        /// <returns>Returns a  SelectResourceConfigResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/SelectResourceConfig">REST API Reference for SelectResourceConfig Operation</seealso>
        public virtual SelectResourceConfigResponse EndSelectResourceConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<SelectResourceConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  StartConfigRulesEvaluation

        /// <summary>
        /// Runs an on-demand evaluation for the specified AWS Config rules against the last known
        /// configuration state of the resources. Use <code>StartConfigRulesEvaluation</code>
        /// when you want to test that a rule you updated is working as expected. <code>StartConfigRulesEvaluation</code>
        /// does not re-record the latest configuration state for your resources. It re-runs an
        /// evaluation against the last known state of your resources. 
        /// 
        ///  
        /// <para>
        /// You can specify up to 25 AWS Config rules per request. 
        /// </para>
        ///  
        /// <para>
        /// An existing <code>StartConfigRulesEvaluation</code> call for the specified rules must
        /// complete before you can call the API again. If you chose to have AWS Config stream
        /// to an Amazon SNS topic, you will receive a <code>ConfigRuleEvaluationStarted</code>
        /// notification when the evaluation starts.
        /// </para>
        ///  <note> 
        /// <para>
        /// You don't need to call the <code>StartConfigRulesEvaluation</code> API to run an evaluation
        /// for a new rule. When you create a rule, AWS Config evaluates your resources against
        /// the rule automatically. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The <code>StartConfigRulesEvaluation</code> API is useful if you want to run on-demand
        /// evaluations, such as the following example:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// You have a custom rule that evaluates your IAM resources every 24 hours.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You update your Lambda function to add additional conditions to your rule.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instead of waiting for the next periodic evaluation, you call the <code>StartConfigRulesEvaluation</code>
        /// API.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Config invokes your Lambda function and evaluates your IAM resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Your custom rule will still run periodic evaluations every 24 hours.
        /// </para>
        ///  </li> </ol>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigRulesEvaluation service method.</param>
        /// 
        /// <returns>The response from the StartConfigRulesEvaluation service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InvalidParameterValueException">
        /// One or more of the specified parameters are invalid. Verify that your parameters are
        /// valid and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.LimitExceededException">
        /// For <code>StartConfigRulesEvaluation</code> API, this exception is thrown if an evaluation
        /// is in progress or if you call the <a>StartConfigRulesEvaluation</a> API more than
        /// once per minute.
        /// 
        ///  
        /// <para>
        /// For <code>PutConfigurationAggregator</code> API, this exception is thrown if the number
        /// of accounts and aggregators exceeds the limit.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigRuleException">
        /// One or more AWS Config rules in the request are invalid. Verify that the rule names
        /// are correct and try again.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ResourceInUseException">
        /// The rule is currently being deleted or the rule is deleting your evaluation results.
        /// Try your request again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigRulesEvaluation">REST API Reference for StartConfigRulesEvaluation Operation</seealso>
        public virtual StartConfigRulesEvaluationResponse StartConfigRulesEvaluation(StartConfigRulesEvaluationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigRulesEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigRulesEvaluationResponseUnmarshaller.Instance;

            return Invoke<StartConfigRulesEvaluationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigRulesEvaluation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigRulesEvaluation operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigRulesEvaluation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigRulesEvaluation">REST API Reference for StartConfigRulesEvaluation Operation</seealso>
        public virtual IAsyncResult BeginStartConfigRulesEvaluation(StartConfigRulesEvaluationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigRulesEvaluationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigRulesEvaluationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigRulesEvaluation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigRulesEvaluation.</param>
        /// 
        /// <returns>Returns a  StartConfigRulesEvaluationResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigRulesEvaluation">REST API Reference for StartConfigRulesEvaluation Operation</seealso>
        public virtual StartConfigRulesEvaluationResponse EndStartConfigRulesEvaluation(IAsyncResult asyncResult)
        {
            return EndInvoke<StartConfigRulesEvaluationResponse>(asyncResult);
        }

        #endregion
        
        #region  StartConfigurationRecorder

        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        public virtual StartConfigurationRecorderResponse StartConfigurationRecorder(string configurationRecorderName)
        {
            var request = new StartConfigurationRecorderRequest();
            request.ConfigurationRecorderName = configurationRecorderName;
            return StartConfigurationRecorder(request);
        }


        /// <summary>
        /// Starts recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// 
        ///  
        /// <para>
        /// You must have created at least one delivery channel to successfully start the configuration
        /// recorder.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the StartConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoAvailableDeliveryChannelException">
        /// There is no delivery channel available to record configurations.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        public virtual StartConfigurationRecorderResponse StartConfigurationRecorder(StartConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<StartConfigurationRecorderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartConfigurationRecorder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        public virtual IAsyncResult BeginStartConfigurationRecorder(StartConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  StartConfigurationRecorderResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartConfigurationRecorder">REST API Reference for StartConfigurationRecorder Operation</seealso>
        public virtual StartConfigurationRecorderResponse EndStartConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<StartConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRemediationExecution

        /// <summary>
        /// Runs an on-demand remediation for the specified AWS Config rules against the last
        /// known remediation configuration. It runs an execution against the current state of
        /// your resources. Remediation execution is asynchronous.
        /// 
        ///  
        /// <para>
        /// You can specify up to 100 resource keys per request. An existing StartRemediationExecution
        /// call for the specified resource keys must complete before you can call the API again.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRemediationExecution service method.</param>
        /// 
        /// <returns>The response from the StartRemediationExecution service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.InsufficientPermissionsException">
        /// Indicates one of the following errors:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// The rule cannot be created because the IAM role assigned to AWS Config lacks permissions
        /// to perform the config:Put* action.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The AWS Lambda function cannot be invoked. Check the function ARN, and check the function's
        /// permissions.
        /// </para>
        ///  </li> </ul>
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchRemediationConfigurationException">
        /// You specified an AWS Config rule without a remediation configuration.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartRemediationExecution">REST API Reference for StartRemediationExecution Operation</seealso>
        public virtual StartRemediationExecutionResponse StartRemediationExecution(StartRemediationExecutionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRemediationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRemediationExecutionResponseUnmarshaller.Instance;

            return Invoke<StartRemediationExecutionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRemediationExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRemediationExecution operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRemediationExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartRemediationExecution">REST API Reference for StartRemediationExecution Operation</seealso>
        public virtual IAsyncResult BeginStartRemediationExecution(StartRemediationExecutionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRemediationExecutionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRemediationExecutionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRemediationExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRemediationExecution.</param>
        /// 
        /// <returns>Returns a  StartRemediationExecutionResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StartRemediationExecution">REST API Reference for StartRemediationExecution Operation</seealso>
        public virtual StartRemediationExecutionResponse EndStartRemediationExecution(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRemediationExecutionResponse>(asyncResult);
        }

        #endregion
        
        #region  StopConfigurationRecorder

        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="configurationRecorderName">The name of the recorder object that records each configuration change made to the resources.</param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        public virtual StopConfigurationRecorderResponse StopConfigurationRecorder(string configurationRecorderName)
        {
            var request = new StopConfigurationRecorderRequest();
            request.ConfigurationRecorderName = configurationRecorderName;
            return StopConfigurationRecorder(request);
        }


        /// <summary>
        /// Stops recording configurations of the AWS resources you have selected to record in
        /// your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder service method.</param>
        /// 
        /// <returns>The response from the StopConfigurationRecorder service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.NoSuchConfigurationRecorderException">
        /// You have specified a configuration recorder that does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        public virtual StopConfigurationRecorderResponse StopConfigurationRecorder(StopConfigurationRecorderRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopConfigurationRecorderResponseUnmarshaller.Instance;

            return Invoke<StopConfigurationRecorderResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopConfigurationRecorder operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopConfigurationRecorder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        public virtual IAsyncResult BeginStopConfigurationRecorder(StopConfigurationRecorderRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopConfigurationRecorderRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopConfigurationRecorderResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopConfigurationRecorder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopConfigurationRecorder.</param>
        /// 
        /// <returns>Returns a  StopConfigurationRecorderResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/StopConfigurationRecorder">REST API Reference for StopConfigurationRecorder Operation</seealso>
        public virtual StopConfigurationRecorderResponse EndStopConfigurationRecorder(IAsyncResult asyncResult)
        {
            return EndInvoke<StopConfigurationRecorderResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Associates the specified tags to a resource with the specified resourceArn. If existing
        /// tags on a resource are not specified in the request parameters, they are not changed.
        /// When a resource is deleted, the tags associated with that resource are deleted as
        /// well.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.TooManyTagsException">
        /// You have reached the limit of the number of tags you can use. You have more than 50
        /// tags.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Deletes specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by ConfigService.</returns>
        /// <exception cref="Amazon.ConfigService.Model.ResourceNotFoundException">
        /// You have specified a resource that does not exist.
        /// </exception>
        /// <exception cref="Amazon.ConfigService.Model.ValidationException">
        /// The requested action is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonConfigServiceClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from ConfigService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/config-2014-11-12/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}