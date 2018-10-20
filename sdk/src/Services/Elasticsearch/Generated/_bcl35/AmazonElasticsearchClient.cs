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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Elasticsearch.Model;
using Amazon.Elasticsearch.Model.Internal.MarshallTransformations;
using Amazon.Elasticsearch.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Elasticsearch
{
    /// <summary>
    /// Implementation for accessing Elasticsearch
    ///
    /// Amazon Elasticsearch Configuration Service 
    /// <para>
    /// Use the Amazon Elasticsearch configuration API to create, configure, and manage Elasticsearch
    /// domains.
    /// </para>
    ///  
    /// <para>
    /// The endpoint for configuration service requests is region-specific: es.<i>region</i>.amazonaws.com.
    /// For example, es.us-east-1.amazonaws.com. For a current list of supported regions and
    /// endpoints, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticsearch-service-regions"
    /// target="_blank">Regions and Endpoints</a>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticsearchClient : AmazonServiceClient, IAmazonElasticsearch
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticsearchMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
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
        public AmazonElasticsearchClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticsearchConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
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
        public AmazonElasticsearchClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticsearchConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(AmazonElasticsearchConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticsearchClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticsearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Credentials and an
        /// AmazonElasticsearchClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(AWSCredentials credentials, AmazonElasticsearchConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticsearchConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticsearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticsearchConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticsearchConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticsearchConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticsearchClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticsearchClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticsearchClient Configuration Object</param>
        public AmazonElasticsearchClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticsearchConfig clientConfig)
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

        
        #region  AddTags

        /// <summary>
        /// Attaches tags to an existing Elasticsearch domain. Tags are a set of case-sensitive
        /// key value pairs. An Elasticsearch domain may have up to 10 tags. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-managedomains.html#es-managedomains-awsresorcetagging"
        /// target="_blank"> Tagging Amazon Elasticsearch Service Domains for more information.</a>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        public virtual IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return BeginInvoke<AddTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from Elasticsearch.</returns>
        public virtual AddTagsResponse EndAddTags(IAsyncResult asyncResult)
        {
            return EndInvoke<AddTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelElasticsearchServiceSoftwareUpdate

        /// <summary>
        /// Cancels a scheduled service software update for an Amazon ES domain. You can only
        /// perform this operation before the <code>AutomatedUpdateDate</code> and when the <code>UpdateStatus</code>
        /// is in the <code>PENDING_UPDATE</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the CancelElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual CancelElasticsearchServiceSoftwareUpdateResponse CancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request)
        {
            var marshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            var unmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<CancelElasticsearchServiceSoftwareUpdateRequest,CancelElasticsearchServiceSoftwareUpdateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelElasticsearchServiceSoftwareUpdate operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelElasticsearchServiceSoftwareUpdate
        ///         operation.</returns>
        public virtual IAsyncResult BeginCancelElasticsearchServiceSoftwareUpdate(CancelElasticsearchServiceSoftwareUpdateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CancelElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            var unmarshaller = CancelElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return BeginInvoke<CancelElasticsearchServiceSoftwareUpdateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelElasticsearchServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  CancelElasticsearchServiceSoftwareUpdateResult from Elasticsearch.</returns>
        public virtual CancelElasticsearchServiceSoftwareUpdateResponse EndCancelElasticsearchServiceSoftwareUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelElasticsearchServiceSoftwareUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateElasticsearchDomain

        /// <summary>
        /// Creates a new Elasticsearch domain. For more information, see <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-createupdatedomains.html#es-createdomains"
        /// target="_blank">Creating Elasticsearch Domains</a> in the <i>Amazon Elasticsearch
        /// Service Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the CreateElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual CreateElasticsearchDomainResponse CreateElasticsearchDomain(CreateElasticsearchDomainRequest request)
        {
            var marshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<CreateElasticsearchDomainRequest,CreateElasticsearchDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateElasticsearchDomain
        ///         operation.</returns>
        public virtual IAsyncResult BeginCreateElasticsearchDomain(CreateElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = CreateElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = CreateElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke<CreateElasticsearchDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  CreateElasticsearchDomainResult from Elasticsearch.</returns>
        public virtual CreateElasticsearchDomainResponse EndCreateElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteElasticsearchDomain

        /// <summary>
        /// Permanently deletes the specified Elasticsearch domain and all of its data. Once a
        /// domain is deleted, it cannot be recovered.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DeleteElasticsearchDomainResponse DeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request)
        {
            var marshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchDomainRequest,DeleteElasticsearchDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteElasticsearchDomain
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteElasticsearchDomain(DeleteElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = DeleteElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteElasticsearchDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  DeleteElasticsearchDomainResult from Elasticsearch.</returns>
        public virtual DeleteElasticsearchDomainResponse EndDeleteElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteElasticsearchServiceRole

        /// <summary>
        /// Deletes the service-linked role that Elasticsearch Service uses to manage and maintain
        /// VPC domains. Role deletion will fail if any existing VPC domains use the role. You
        /// must delete any such Elasticsearch domains before deleting the role. See <a href="http://docs.aws.amazon.com/elasticsearch-service/latest/developerguide/es-vpc.html#es-enabling-slr"
        /// target="_blank">Deleting Elasticsearch Service Role</a> in <i>VPC Endpoints for Amazon
        /// Elasticsearch Service Domains</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole service method.</param>
        /// 
        /// <returns>The response from the DeleteElasticsearchServiceRole service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DeleteElasticsearchServiceRoleResponse DeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request)
        {
            var marshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            var unmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return Invoke<DeleteElasticsearchServiceRoleRequest,DeleteElasticsearchServiceRoleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteElasticsearchServiceRole operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteElasticsearchServiceRole
        ///         operation.</returns>
        public virtual IAsyncResult BeginDeleteElasticsearchServiceRole(DeleteElasticsearchServiceRoleRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DeleteElasticsearchServiceRoleRequestMarshaller.Instance;
            var unmarshaller = DeleteElasticsearchServiceRoleResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteElasticsearchServiceRoleRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteElasticsearchServiceRole operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteElasticsearchServiceRole.</param>
        /// 
        /// <returns>Returns a  DeleteElasticsearchServiceRoleResult from Elasticsearch.</returns>
        public virtual DeleteElasticsearchServiceRoleResponse EndDeleteElasticsearchServiceRole(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteElasticsearchServiceRoleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeElasticsearchDomain

        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domain,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchDomainResponse DescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request)
        {
            var marshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainRequest,DescribeElasticsearchDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomain
        ///         operation.</returns>
        public virtual IAsyncResult BeginDescribeElasticsearchDomain(DescribeElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeElasticsearchDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainResult from Elasticsearch.</returns>
        public virtual DescribeElasticsearchDomainResponse EndDescribeElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeElasticsearchDomainConfig

        /// <summary>
        /// Provides cluster configuration information about the specified Elasticsearch domain,
        /// such as the state, creation date, update version, and update date for cluster options.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchDomainConfigResponse DescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request)
        {
            var marshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainConfigRequest,DescribeElasticsearchDomainConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomainConfig operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomainConfig
        ///         operation.</returns>
        public virtual IAsyncResult BeginDescribeElasticsearchDomainConfig(DescribeElasticsearchDomainConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeElasticsearchDomainConfigRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeElasticsearchDomainConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomainConfig.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainConfigResult from Elasticsearch.</returns>
        public virtual DescribeElasticsearchDomainConfigResponse EndDescribeElasticsearchDomainConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchDomainConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeElasticsearchDomains

        /// <summary>
        /// Returns domain configuration information about the specified Elasticsearch domains,
        /// including the domain ID, domain endpoint, and domain ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchDomains service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchDomainsResponse DescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request)
        {
            var marshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchDomainsRequest,DescribeElasticsearchDomainsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchDomains operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchDomains
        ///         operation.</returns>
        public virtual IAsyncResult BeginDescribeElasticsearchDomains(DescribeElasticsearchDomainsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeElasticsearchDomainsRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchDomainsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeElasticsearchDomainsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchDomains operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchDomains.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchDomainsResult from Elasticsearch.</returns>
        public virtual DescribeElasticsearchDomainsResponse EndDescribeElasticsearchDomains(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchDomainsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeElasticsearchInstanceTypeLimits

        /// <summary>
        /// Describe Elasticsearch Limits for a given InstanceType and ElasticsearchVersion.
        /// When modifying existing Domain, specify the <code> <a>DomainName</a> </code> to know
        /// what Limits are supported for modifying.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticsearchInstanceTypeLimits service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeElasticsearchInstanceTypeLimitsResponse DescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request)
        {
            var marshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticsearchInstanceTypeLimitsRequest,DescribeElasticsearchInstanceTypeLimitsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticsearchInstanceTypeLimits operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticsearchInstanceTypeLimits
        ///         operation.</returns>
        public virtual IAsyncResult BeginDescribeElasticsearchInstanceTypeLimits(DescribeElasticsearchInstanceTypeLimitsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeElasticsearchInstanceTypeLimitsRequestMarshaller.Instance;
            var unmarshaller = DescribeElasticsearchInstanceTypeLimitsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeElasticsearchInstanceTypeLimitsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticsearchInstanceTypeLimits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticsearchInstanceTypeLimits.</param>
        /// 
        /// <returns>Returns a  DescribeElasticsearchInstanceTypeLimitsResult from Elasticsearch.</returns>
        public virtual DescribeElasticsearchInstanceTypeLimitsResponse EndDescribeElasticsearchInstanceTypeLimits(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeElasticsearchInstanceTypeLimitsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstanceOfferings

        /// <summary>
        /// Lists available reserved Elasticsearch instance offerings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstanceOfferings service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeReservedElasticsearchInstanceOfferingsResponse DescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request)
        {
            var marshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstanceOfferingsRequest,DescribeReservedElasticsearchInstanceOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstanceOfferings operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedElasticsearchInstanceOfferings
        ///         operation.</returns>
        public virtual IAsyncResult BeginDescribeReservedElasticsearchInstanceOfferings(DescribeReservedElasticsearchInstanceOfferingsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeReservedElasticsearchInstanceOfferingsRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedElasticsearchInstanceOfferingsResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReservedElasticsearchInstanceOfferingsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedElasticsearchInstanceOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedElasticsearchInstanceOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedElasticsearchInstanceOfferingsResult from Elasticsearch.</returns>
        public virtual DescribeReservedElasticsearchInstanceOfferingsResponse EndDescribeReservedElasticsearchInstanceOfferings(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedElasticsearchInstanceOfferingsResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeReservedElasticsearchInstances

        /// <summary>
        /// Returns information about reserved Elasticsearch instances for this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedElasticsearchInstances service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual DescribeReservedElasticsearchInstancesResponse DescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request)
        {
            var marshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedElasticsearchInstancesRequest,DescribeReservedElasticsearchInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedElasticsearchInstances operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedElasticsearchInstances
        ///         operation.</returns>
        public virtual IAsyncResult BeginDescribeReservedElasticsearchInstances(DescribeReservedElasticsearchInstancesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = DescribeReservedElasticsearchInstancesRequestMarshaller.Instance;
            var unmarshaller = DescribeReservedElasticsearchInstancesResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeReservedElasticsearchInstancesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedElasticsearchInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedElasticsearchInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedElasticsearchInstancesResult from Elasticsearch.</returns>
        public virtual DescribeReservedElasticsearchInstancesResponse EndDescribeReservedElasticsearchInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeReservedElasticsearchInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCompatibleElasticsearchVersions

        /// <summary>
        /// Returns a list of upgrade compatible Elastisearch versions. You can optionally pass
        /// a <code> <a>DomainName</a> </code> to get all upgrade compatible Elasticsearch versions
        /// for that specific domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the GetCompatibleElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual GetCompatibleElasticsearchVersionsResponse GetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request)
        {
            var marshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            var unmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<GetCompatibleElasticsearchVersionsRequest,GetCompatibleElasticsearchVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCompatibleElasticsearchVersions operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCompatibleElasticsearchVersions
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetCompatibleElasticsearchVersions(GetCompatibleElasticsearchVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetCompatibleElasticsearchVersionsRequestMarshaller.Instance;
            var unmarshaller = GetCompatibleElasticsearchVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<GetCompatibleElasticsearchVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCompatibleElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCompatibleElasticsearchVersions.</param>
        /// 
        /// <returns>Returns a  GetCompatibleElasticsearchVersionsResult from Elasticsearch.</returns>
        public virtual GetCompatibleElasticsearchVersionsResponse EndGetCompatibleElasticsearchVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCompatibleElasticsearchVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUpgradeHistory

        /// <summary>
        /// Retrieves the complete history of the last 10 upgrades that were performed on the
        /// domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeHistory service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual GetUpgradeHistoryResponse GetUpgradeHistory(GetUpgradeHistoryRequest request)
        {
            var marshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            var unmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeHistoryRequest,GetUpgradeHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeHistory operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeHistory
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetUpgradeHistory(GetUpgradeHistoryRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUpgradeHistoryRequestMarshaller.Instance;
            var unmarshaller = GetUpgradeHistoryResponseUnmarshaller.Instance;

            return BeginInvoke<GetUpgradeHistoryRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeHistory.</param>
        /// 
        /// <returns>Returns a  GetUpgradeHistoryResult from Elasticsearch.</returns>
        public virtual GetUpgradeHistoryResponse EndGetUpgradeHistory(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUpgradeHistoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetUpgradeStatus

        /// <summary>
        /// Retrieves the latest status of the last upgrade or upgrade eligibility check that
        /// was performed on the domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus service method.</param>
        /// 
        /// <returns>The response from the GetUpgradeStatus service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual GetUpgradeStatusResponse GetUpgradeStatus(GetUpgradeStatusRequest request)
        {
            var marshaller = GetUpgradeStatusRequestMarshaller.Instance;
            var unmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return Invoke<GetUpgradeStatusRequest,GetUpgradeStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUpgradeStatus operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetUpgradeStatus
        ///         operation.</returns>
        public virtual IAsyncResult BeginGetUpgradeStatus(GetUpgradeStatusRequest request, AsyncCallback callback, object state)
        {
            var marshaller = GetUpgradeStatusRequestMarshaller.Instance;
            var unmarshaller = GetUpgradeStatusResponseUnmarshaller.Instance;

            return BeginInvoke<GetUpgradeStatusRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetUpgradeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetUpgradeStatus.</param>
        /// 
        /// <returns>Returns a  GetUpgradeStatusResult from Elasticsearch.</returns>
        public virtual GetUpgradeStatusResponse EndGetUpgradeStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetUpgradeStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListDomainNames

        /// <summary>
        /// Returns the name of all Elasticsearch domains owned by the current user's account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames service method.</param>
        /// 
        /// <returns>The response from the ListDomainNames service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListDomainNamesResponse ListDomainNames(ListDomainNamesRequest request)
        {
            var marshaller = ListDomainNamesRequestMarshaller.Instance;
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return Invoke<ListDomainNamesRequest,ListDomainNamesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDomainNames operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDomainNames
        ///         operation.</returns>
        public virtual IAsyncResult BeginListDomainNames(ListDomainNamesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListDomainNamesRequestMarshaller.Instance;
            var unmarshaller = ListDomainNamesResponseUnmarshaller.Instance;

            return BeginInvoke<ListDomainNamesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListDomainNames operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDomainNames.</param>
        /// 
        /// <returns>Returns a  ListDomainNamesResult from Elasticsearch.</returns>
        public virtual ListDomainNamesResponse EndListDomainNames(IAsyncResult asyncResult)
        {
            return EndInvoke<ListDomainNamesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListElasticsearchInstanceTypes

        /// <summary>
        /// List all Elasticsearch instance types that are supported for given ElasticsearchVersion
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchInstanceTypes service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListElasticsearchInstanceTypesResponse ListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request)
        {
            var marshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            var unmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchInstanceTypesRequest,ListElasticsearchInstanceTypesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchInstanceTypes operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListElasticsearchInstanceTypes
        ///         operation.</returns>
        public virtual IAsyncResult BeginListElasticsearchInstanceTypes(ListElasticsearchInstanceTypesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListElasticsearchInstanceTypesRequestMarshaller.Instance;
            var unmarshaller = ListElasticsearchInstanceTypesResponseUnmarshaller.Instance;

            return BeginInvoke<ListElasticsearchInstanceTypesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListElasticsearchInstanceTypes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListElasticsearchInstanceTypes.</param>
        /// 
        /// <returns>Returns a  ListElasticsearchInstanceTypesResult from Elasticsearch.</returns>
        public virtual ListElasticsearchInstanceTypesResponse EndListElasticsearchInstanceTypes(IAsyncResult asyncResult)
        {
            return EndInvoke<ListElasticsearchInstanceTypesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListElasticsearchVersions

        /// <summary>
        /// List all supported Elasticsearch versions
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions service method.</param>
        /// 
        /// <returns>The response from the ListElasticsearchVersions service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListElasticsearchVersionsResponse ListElasticsearchVersions(ListElasticsearchVersionsRequest request)
        {
            var marshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            var unmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return Invoke<ListElasticsearchVersionsRequest,ListElasticsearchVersionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListElasticsearchVersions operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListElasticsearchVersions
        ///         operation.</returns>
        public virtual IAsyncResult BeginListElasticsearchVersions(ListElasticsearchVersionsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListElasticsearchVersionsRequestMarshaller.Instance;
            var unmarshaller = ListElasticsearchVersionsResponseUnmarshaller.Instance;

            return BeginInvoke<ListElasticsearchVersionsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListElasticsearchVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListElasticsearchVersions.</param>
        /// 
        /// <returns>Returns a  ListElasticsearchVersionsResult from Elasticsearch.</returns>
        public virtual ListElasticsearchVersionsResponse EndListElasticsearchVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListElasticsearchVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTags

        /// <summary>
        /// Returns all tags for the given Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual ListTagsResponse ListTags(ListTagsRequest request)
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return Invoke<ListTagsRequest,ListTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        public virtual IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = ListTagsRequestMarshaller.Instance;
            var unmarshaller = ListTagsResponseUnmarshaller.Instance;

            return BeginInvoke<ListTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from Elasticsearch.</returns>
        public virtual ListTagsResponse EndListTags(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  PurchaseReservedElasticsearchInstanceOffering

        /// <summary>
        /// Allows you to purchase reserved Elasticsearch instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedElasticsearchInstanceOffering service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual PurchaseReservedElasticsearchInstanceOfferingResponse PurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request)
        {
            var marshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            var unmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedElasticsearchInstanceOfferingRequest,PurchaseReservedElasticsearchInstanceOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedElasticsearchInstanceOffering operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedElasticsearchInstanceOffering
        ///         operation.</returns>
        public virtual IAsyncResult BeginPurchaseReservedElasticsearchInstanceOffering(PurchaseReservedElasticsearchInstanceOfferingRequest request, AsyncCallback callback, object state)
        {
            var marshaller = PurchaseReservedElasticsearchInstanceOfferingRequestMarshaller.Instance;
            var unmarshaller = PurchaseReservedElasticsearchInstanceOfferingResponseUnmarshaller.Instance;

            return BeginInvoke<PurchaseReservedElasticsearchInstanceOfferingRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedElasticsearchInstanceOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedElasticsearchInstanceOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedElasticsearchInstanceOfferingResult from Elasticsearch.</returns>
        public virtual PurchaseReservedElasticsearchInstanceOfferingResponse EndPurchaseReservedElasticsearchInstanceOffering(IAsyncResult asyncResult)
        {
            return EndInvoke<PurchaseReservedElasticsearchInstanceOfferingResponse>(asyncResult);
        }

        #endregion
        
        #region  RemoveTags

        /// <summary>
        /// Removes the specified set of tags from the specified Elasticsearch domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = RemoveTagsRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRemoveTags
        ///         operation.</returns>
        public virtual IAsyncResult BeginRemoveTags(RemoveTagsRequest request, AsyncCallback callback, object state)
        {
            var marshaller = RemoveTagsRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return BeginInvoke<RemoveTagsRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemoveTags.</param>
        /// 
        /// <returns>Returns a  RemoveTagsResult from Elasticsearch.</returns>
        public virtual RemoveTagsResponse EndRemoveTags(IAsyncResult asyncResult)
        {
            return EndInvoke<RemoveTagsResponse>(asyncResult);
        }

        #endregion
        
        #region  StartElasticsearchServiceSoftwareUpdate

        /// <summary>
        /// Schedules a service software update for an Amazon ES domain.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate service method.</param>
        /// 
        /// <returns>The response from the StartElasticsearchServiceSoftwareUpdate service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual StartElasticsearchServiceSoftwareUpdateResponse StartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request)
        {
            var marshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            var unmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return Invoke<StartElasticsearchServiceSoftwareUpdateRequest,StartElasticsearchServiceSoftwareUpdateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartElasticsearchServiceSoftwareUpdate operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartElasticsearchServiceSoftwareUpdate
        ///         operation.</returns>
        public virtual IAsyncResult BeginStartElasticsearchServiceSoftwareUpdate(StartElasticsearchServiceSoftwareUpdateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = StartElasticsearchServiceSoftwareUpdateRequestMarshaller.Instance;
            var unmarshaller = StartElasticsearchServiceSoftwareUpdateResponseUnmarshaller.Instance;

            return BeginInvoke<StartElasticsearchServiceSoftwareUpdateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartElasticsearchServiceSoftwareUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartElasticsearchServiceSoftwareUpdate.</param>
        /// 
        /// <returns>Returns a  StartElasticsearchServiceSoftwareUpdateResult from Elasticsearch.</returns>
        public virtual StartElasticsearchServiceSoftwareUpdateResponse EndStartElasticsearchServiceSoftwareUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<StartElasticsearchServiceSoftwareUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateElasticsearchDomainConfig

        /// <summary>
        /// Modifies the cluster configuration of the specified Elasticsearch domain, setting
        /// as setting the instance type and the number of instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateElasticsearchDomainConfig service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InvalidTypeException">
        /// An exception for trying to create or access sub-resource that is either invalid or
        /// not supported. Gives http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.LimitExceededException">
        /// An exception for trying to create more than allowed resources or sub-resources. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual UpdateElasticsearchDomainConfigResponse UpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request)
        {
            var marshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateElasticsearchDomainConfigRequest,UpdateElasticsearchDomainConfigResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateElasticsearchDomainConfig operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateElasticsearchDomainConfig
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpdateElasticsearchDomainConfig(UpdateElasticsearchDomainConfigRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpdateElasticsearchDomainConfigRequestMarshaller.Instance;
            var unmarshaller = UpdateElasticsearchDomainConfigResponseUnmarshaller.Instance;

            return BeginInvoke<UpdateElasticsearchDomainConfigRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateElasticsearchDomainConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateElasticsearchDomainConfig.</param>
        /// 
        /// <returns>Returns a  UpdateElasticsearchDomainConfigResult from Elasticsearch.</returns>
        public virtual UpdateElasticsearchDomainConfigResponse EndUpdateElasticsearchDomainConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateElasticsearchDomainConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  UpgradeElasticsearchDomain

        /// <summary>
        /// Allows you to either upgrade your domain or perform an Upgrade eligibility check to
        /// a compatible Elasticsearch version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain service method.</param>
        /// 
        /// <returns>The response from the UpgradeElasticsearchDomain service method, as returned by Elasticsearch.</returns>
        /// <exception cref="Amazon.Elasticsearch.Model.BaseException">
        /// An error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.DisabledOperationException">
        /// An error occured because the client wanted to access a not supported operation. Gives
        /// http status code of 409.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.InternalException">
        /// The request processing has failed because of an unknown error, exception or failure
        /// (the failure is internal to the service) . Gives http status code of 500.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceAlreadyExistsException">
        /// An exception for creating a resource that already exists. Gives http status code of
        /// 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ResourceNotFoundException">
        /// An exception for accessing or deleting a resource that does not exist. Gives http
        /// status code of 400.
        /// </exception>
        /// <exception cref="Amazon.Elasticsearch.Model.ValidationException">
        /// An exception for missing / invalid input fields. Gives http status code of 400.
        /// </exception>
        public virtual UpgradeElasticsearchDomainResponse UpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request)
        {
            var marshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return Invoke<UpgradeElasticsearchDomainRequest,UpgradeElasticsearchDomainResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpgradeElasticsearchDomain operation on AmazonElasticsearchClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpgradeElasticsearchDomain
        ///         operation.</returns>
        public virtual IAsyncResult BeginUpgradeElasticsearchDomain(UpgradeElasticsearchDomainRequest request, AsyncCallback callback, object state)
        {
            var marshaller = UpgradeElasticsearchDomainRequestMarshaller.Instance;
            var unmarshaller = UpgradeElasticsearchDomainResponseUnmarshaller.Instance;

            return BeginInvoke<UpgradeElasticsearchDomainRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpgradeElasticsearchDomain operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpgradeElasticsearchDomain.</param>
        /// 
        /// <returns>Returns a  UpgradeElasticsearchDomainResult from Elasticsearch.</returns>
        public virtual UpgradeElasticsearchDomainResponse EndUpgradeElasticsearchDomain(IAsyncResult asyncResult)
        {
            return EndInvoke<UpgradeElasticsearchDomainResponse>(asyncResult);
        }

        #endregion
        
    }
}