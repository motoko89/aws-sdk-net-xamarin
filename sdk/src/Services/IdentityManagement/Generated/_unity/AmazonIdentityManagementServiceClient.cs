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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.IdentityManagement.Model;
using Amazon.IdentityManagement.Model.Internal.MarshallTransformations;
using Amazon.IdentityManagement.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.IdentityManagement
{
    /// <summary>
    /// Implementation for accessing IdentityManagementService
    ///
    /// AWS Identity and Access Management 
    /// <para>
    /// AWS Identity and Access Management (IAM) is a web service for securely controlling
    /// access to AWS services. With IAM, you can centrally manage users, security credentials
    /// such as access keys, and permissions that control which AWS resources users and applications
    /// can access. For more information about IAM, see <a href="http://aws.amazon.com/iam/">AWS
    /// Identity and Access Management (IAM)</a> and the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/">AWS
    /// Identity and Access Management User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIdentityManagementServiceClient : AmazonServiceClient, IAmazonIdentityManagementService
    {
        private static IServiceMetadata serviceMetadata = new AmazonIdentityManagementServiceMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIdentityManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Credentials and an
        /// AmazonIdentityManagementServiceClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(AWSCredentials credentials, AmazonIdentityManagementServiceConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIdentityManagementServiceConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIdentityManagementServiceConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityManagementServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIdentityManagementServiceConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIdentityManagementServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIdentityManagementServiceClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIdentityManagementServiceClient Configuration Object</param>
        public AmazonIdentityManagementServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIdentityManagementServiceConfig clientConfig)
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


        #region  AddClientIDToOpenIDConnectProvider

        /// <summary>
        /// Initiates the asynchronous execution of the AddClientIDToOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddClientIDToOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddClientIDToOpenIDConnectProvider">REST API Reference for AddClientIDToOpenIDConnectProvider Operation</seealso>
        public virtual void AddClientIDToOpenIDConnectProviderAsync(AddClientIDToOpenIDConnectProviderRequest request, AmazonServiceCallback<AddClientIDToOpenIDConnectProviderRequest, AddClientIDToOpenIDConnectProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AddClientIDToOpenIDConnectProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AddClientIDToOpenIDConnectProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AddClientIDToOpenIDConnectProviderRequest,AddClientIDToOpenIDConnectProviderResponse> responseObject 
                            = new AmazonServiceResult<AddClientIDToOpenIDConnectProviderRequest,AddClientIDToOpenIDConnectProviderResponse>((AddClientIDToOpenIDConnectProviderRequest)req, (AddClientIDToOpenIDConnectProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AddRoleToInstanceProfile

        /// <summary>
        /// Initiates the asynchronous execution of the AddRoleToInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddRoleToInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddRoleToInstanceProfile">REST API Reference for AddRoleToInstanceProfile Operation</seealso>
        public virtual void AddRoleToInstanceProfileAsync(AddRoleToInstanceProfileRequest request, AmazonServiceCallback<AddRoleToInstanceProfileRequest, AddRoleToInstanceProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AddRoleToInstanceProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AddRoleToInstanceProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AddRoleToInstanceProfileRequest,AddRoleToInstanceProfileResponse> responseObject 
                            = new AmazonServiceResult<AddRoleToInstanceProfileRequest,AddRoleToInstanceProfileResponse>((AddRoleToInstanceProfileRequest)req, (AddRoleToInstanceProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AddUserToGroup

        /// <summary>
        /// Initiates the asynchronous execution of the AddUserToGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddUserToGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AddUserToGroup">REST API Reference for AddUserToGroup Operation</seealso>
        public virtual void AddUserToGroupAsync(AddUserToGroupRequest request, AmazonServiceCallback<AddUserToGroupRequest, AddUserToGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AddUserToGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AddUserToGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AddUserToGroupRequest,AddUserToGroupResponse> responseObject 
                            = new AmazonServiceResult<AddUserToGroupRequest,AddUserToGroupResponse>((AddUserToGroupRequest)req, (AddUserToGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AttachGroupPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the AttachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachGroupPolicy">REST API Reference for AttachGroupPolicy Operation</seealso>
        public virtual void AttachGroupPolicyAsync(AttachGroupPolicyRequest request, AmazonServiceCallback<AttachGroupPolicyRequest, AttachGroupPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AttachGroupPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AttachGroupPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AttachGroupPolicyRequest,AttachGroupPolicyResponse> responseObject 
                            = new AmazonServiceResult<AttachGroupPolicyRequest,AttachGroupPolicyResponse>((AttachGroupPolicyRequest)req, (AttachGroupPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AttachRolePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the AttachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachRolePolicy">REST API Reference for AttachRolePolicy Operation</seealso>
        public virtual void AttachRolePolicyAsync(AttachRolePolicyRequest request, AmazonServiceCallback<AttachRolePolicyRequest, AttachRolePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AttachRolePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AttachRolePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AttachRolePolicyRequest,AttachRolePolicyResponse> responseObject 
                            = new AmazonServiceResult<AttachRolePolicyRequest,AttachRolePolicyResponse>((AttachRolePolicyRequest)req, (AttachRolePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  AttachUserPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the AttachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/AttachUserPolicy">REST API Reference for AttachUserPolicy Operation</seealso>
        public virtual void AttachUserPolicyAsync(AttachUserPolicyRequest request, AmazonServiceCallback<AttachUserPolicyRequest, AttachUserPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AttachUserPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AttachUserPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AttachUserPolicyRequest,AttachUserPolicyResponse> responseObject 
                            = new AmazonServiceResult<AttachUserPolicyRequest,AttachUserPolicyResponse>((AttachUserPolicyRequest)req, (AttachUserPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ChangePassword

        /// <summary>
        /// Initiates the asynchronous execution of the ChangePassword operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangePassword operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ChangePassword">REST API Reference for ChangePassword Operation</seealso>
        public virtual void ChangePasswordAsync(ChangePasswordRequest request, AmazonServiceCallback<ChangePasswordRequest, ChangePasswordResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ChangePasswordRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ChangePasswordResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ChangePasswordRequest,ChangePasswordResponse> responseObject 
                            = new AmazonServiceResult<ChangePasswordRequest,ChangePasswordResponse>((ChangePasswordRequest)req, (ChangePasswordResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateAccessKey

        /// <summary>
        /// Creates a new AWS secret access key and corresponding AWS access key ID for the specified
        /// user. The default status for new keys is <code>Active</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID signing the request. This operation works for access keys under
        /// the AWS account. Consequently, you can use this operation to manage AWS account root
        /// user credentials. This is true even if the AWS account has no associated users.
        /// </para>
        ///  
        /// <para>
        ///  For information about limits on the number of keys you can create, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// To ensure the security of your AWS account, the secret access key is accessible only
        /// during key and user creation. You must save the key (for example, in a text file)
        /// if you want to be able to access it again. If a secret key is lost, you can delete
        /// the access keys for the associated user and then create new keys.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the CreateAccessKey service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        public virtual void CreateAccessKeyAsync(AmazonServiceCallback<CreateAccessKeyRequest, CreateAccessKeyResponse> callback, AsyncOptions options = null)
        {
            CreateAccessKeyAsync(new CreateAccessKeyRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccessKey">REST API Reference for CreateAccessKey Operation</seealso>
        public virtual void CreateAccessKeyAsync(CreateAccessKeyRequest request, AmazonServiceCallback<CreateAccessKeyRequest, CreateAccessKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateAccessKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateAccessKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateAccessKeyRequest,CreateAccessKeyResponse> responseObject 
                            = new AmazonServiceResult<CreateAccessKeyRequest,CreateAccessKeyResponse>((CreateAccessKeyRequest)req, (CreateAccessKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateAccountAlias

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateAccountAlias">REST API Reference for CreateAccountAlias Operation</seealso>
        public virtual void CreateAccountAliasAsync(CreateAccountAliasRequest request, AmazonServiceCallback<CreateAccountAliasRequest, CreateAccountAliasResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateAccountAliasRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateAccountAliasResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateAccountAliasRequest,CreateAccountAliasResponse> responseObject 
                            = new AmazonServiceResult<CreateAccountAliasRequest,CreateAccountAliasResponse>((CreateAccountAliasRequest)req, (CreateAccountAliasResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateGroup

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateGroup">REST API Reference for CreateGroup Operation</seealso>
        public virtual void CreateGroupAsync(CreateGroupRequest request, AmazonServiceCallback<CreateGroupRequest, CreateGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateGroupRequest,CreateGroupResponse> responseObject 
                            = new AmazonServiceResult<CreateGroupRequest,CreateGroupResponse>((CreateGroupRequest)req, (CreateGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateInstanceProfile

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateInstanceProfile">REST API Reference for CreateInstanceProfile Operation</seealso>
        public virtual void CreateInstanceProfileAsync(CreateInstanceProfileRequest request, AmazonServiceCallback<CreateInstanceProfileRequest, CreateInstanceProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateInstanceProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateInstanceProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateInstanceProfileRequest,CreateInstanceProfileResponse> responseObject 
                            = new AmazonServiceResult<CreateInstanceProfileRequest,CreateInstanceProfileResponse>((CreateInstanceProfileRequest)req, (CreateInstanceProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateLoginProfile

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateLoginProfile">REST API Reference for CreateLoginProfile Operation</seealso>
        public virtual void CreateLoginProfileAsync(CreateLoginProfileRequest request, AmazonServiceCallback<CreateLoginProfileRequest, CreateLoginProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateLoginProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateLoginProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateLoginProfileRequest,CreateLoginProfileResponse> responseObject 
                            = new AmazonServiceResult<CreateLoginProfileRequest,CreateLoginProfileResponse>((CreateLoginProfileRequest)req, (CreateLoginProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateOpenIDConnectProvider

        /// <summary>
        /// Initiates the asynchronous execution of the CreateOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateOpenIDConnectProvider">REST API Reference for CreateOpenIDConnectProvider Operation</seealso>
        public virtual void CreateOpenIDConnectProviderAsync(CreateOpenIDConnectProviderRequest request, AmazonServiceCallback<CreateOpenIDConnectProviderRequest, CreateOpenIDConnectProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateOpenIDConnectProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateOpenIDConnectProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateOpenIDConnectProviderRequest,CreateOpenIDConnectProviderResponse> responseObject 
                            = new AmazonServiceResult<CreateOpenIDConnectProviderRequest,CreateOpenIDConnectProviderResponse>((CreateOpenIDConnectProviderRequest)req, (CreateOpenIDConnectProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreatePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        public virtual void CreatePolicyAsync(CreatePolicyRequest request, AmazonServiceCallback<CreatePolicyRequest, CreatePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreatePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreatePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreatePolicyRequest,CreatePolicyResponse> responseObject 
                            = new AmazonServiceResult<CreatePolicyRequest,CreatePolicyResponse>((CreatePolicyRequest)req, (CreatePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreatePolicyVersion

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreatePolicyVersion">REST API Reference for CreatePolicyVersion Operation</seealso>
        public virtual void CreatePolicyVersionAsync(CreatePolicyVersionRequest request, AmazonServiceCallback<CreatePolicyVersionRequest, CreatePolicyVersionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreatePolicyVersionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreatePolicyVersionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreatePolicyVersionRequest,CreatePolicyVersionResponse> responseObject 
                            = new AmazonServiceResult<CreatePolicyVersionRequest,CreatePolicyVersionResponse>((CreatePolicyVersionRequest)req, (CreatePolicyVersionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateRole

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateRole">REST API Reference for CreateRole Operation</seealso>
        public virtual void CreateRoleAsync(CreateRoleRequest request, AmazonServiceCallback<CreateRoleRequest, CreateRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateRoleRequest,CreateRoleResponse> responseObject 
                            = new AmazonServiceResult<CreateRoleRequest,CreateRoleResponse>((CreateRoleRequest)req, (CreateRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateSAMLProvider

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateSAMLProvider">REST API Reference for CreateSAMLProvider Operation</seealso>
        public virtual void CreateSAMLProviderAsync(CreateSAMLProviderRequest request, AmazonServiceCallback<CreateSAMLProviderRequest, CreateSAMLProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateSAMLProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateSAMLProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateSAMLProviderRequest,CreateSAMLProviderResponse> responseObject 
                            = new AmazonServiceResult<CreateSAMLProviderRequest,CreateSAMLProviderResponse>((CreateSAMLProviderRequest)req, (CreateSAMLProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateServiceLinkedRole

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceLinkedRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceLinkedRole">REST API Reference for CreateServiceLinkedRole Operation</seealso>
        public virtual void CreateServiceLinkedRoleAsync(CreateServiceLinkedRoleRequest request, AmazonServiceCallback<CreateServiceLinkedRoleRequest, CreateServiceLinkedRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateServiceLinkedRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateServiceLinkedRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateServiceLinkedRoleRequest,CreateServiceLinkedRoleResponse> responseObject 
                            = new AmazonServiceResult<CreateServiceLinkedRoleRequest,CreateServiceLinkedRoleResponse>((CreateServiceLinkedRoleRequest)req, (CreateServiceLinkedRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateServiceSpecificCredential

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateServiceSpecificCredential">REST API Reference for CreateServiceSpecificCredential Operation</seealso>
        public virtual void CreateServiceSpecificCredentialAsync(CreateServiceSpecificCredentialRequest request, AmazonServiceCallback<CreateServiceSpecificCredentialRequest, CreateServiceSpecificCredentialResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateServiceSpecificCredentialRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateServiceSpecificCredentialResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateServiceSpecificCredentialRequest,CreateServiceSpecificCredentialResponse> responseObject 
                            = new AmazonServiceResult<CreateServiceSpecificCredentialRequest,CreateServiceSpecificCredentialResponse>((CreateServiceSpecificCredentialRequest)req, (CreateServiceSpecificCredentialResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateUser

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateUser">REST API Reference for CreateUser Operation</seealso>
        public virtual void CreateUserAsync(CreateUserRequest request, AmazonServiceCallback<CreateUserRequest, CreateUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateUserRequest,CreateUserResponse> responseObject 
                            = new AmazonServiceResult<CreateUserRequest,CreateUserResponse>((CreateUserRequest)req, (CreateUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CreateVirtualMFADevice

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/CreateVirtualMFADevice">REST API Reference for CreateVirtualMFADevice Operation</seealso>
        public virtual void CreateVirtualMFADeviceAsync(CreateVirtualMFADeviceRequest request, AmazonServiceCallback<CreateVirtualMFADeviceRequest, CreateVirtualMFADeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CreateVirtualMFADeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CreateVirtualMFADeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CreateVirtualMFADeviceRequest,CreateVirtualMFADeviceResponse> responseObject 
                            = new AmazonServiceResult<CreateVirtualMFADeviceRequest,CreateVirtualMFADeviceResponse>((CreateVirtualMFADeviceRequest)req, (CreateVirtualMFADeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeactivateMFADevice

        /// <summary>
        /// Initiates the asynchronous execution of the DeactivateMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeactivateMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeactivateMFADevice">REST API Reference for DeactivateMFADevice Operation</seealso>
        public virtual void DeactivateMFADeviceAsync(DeactivateMFADeviceRequest request, AmazonServiceCallback<DeactivateMFADeviceRequest, DeactivateMFADeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeactivateMFADeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeactivateMFADeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeactivateMFADeviceRequest,DeactivateMFADeviceResponse> responseObject 
                            = new AmazonServiceResult<DeactivateMFADeviceRequest,DeactivateMFADeviceResponse>((DeactivateMFADeviceRequest)req, (DeactivateMFADeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteAccessKey

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccessKey">REST API Reference for DeleteAccessKey Operation</seealso>
        public virtual void DeleteAccessKeyAsync(DeleteAccessKeyRequest request, AmazonServiceCallback<DeleteAccessKeyRequest, DeleteAccessKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteAccessKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteAccessKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteAccessKeyRequest,DeleteAccessKeyResponse> responseObject 
                            = new AmazonServiceResult<DeleteAccessKeyRequest,DeleteAccessKeyResponse>((DeleteAccessKeyRequest)req, (DeleteAccessKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteAccountAlias

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountAlias operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountAlias">REST API Reference for DeleteAccountAlias Operation</seealso>
        public virtual void DeleteAccountAliasAsync(DeleteAccountAliasRequest request, AmazonServiceCallback<DeleteAccountAliasRequest, DeleteAccountAliasResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteAccountAliasRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteAccountAliasResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteAccountAliasRequest,DeleteAccountAliasResponse> responseObject 
                            = new AmazonServiceResult<DeleteAccountAliasRequest,DeleteAccountAliasResponse>((DeleteAccountAliasRequest)req, (DeleteAccountAliasResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteAccountPasswordPolicy

        /// <summary>
        /// Deletes the password policy for the AWS account. There are no parameters.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the DeleteAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        public virtual void DeleteAccountPasswordPolicyAsync(AmazonServiceCallback<DeleteAccountPasswordPolicyRequest, DeleteAccountPasswordPolicyResponse> callback, AsyncOptions options = null)
        {
            DeleteAccountPasswordPolicyAsync(new DeleteAccountPasswordPolicyRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteAccountPasswordPolicy">REST API Reference for DeleteAccountPasswordPolicy Operation</seealso>
        public virtual void DeleteAccountPasswordPolicyAsync(DeleteAccountPasswordPolicyRequest request, AmazonServiceCallback<DeleteAccountPasswordPolicyRequest, DeleteAccountPasswordPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteAccountPasswordPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteAccountPasswordPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteAccountPasswordPolicyRequest,DeleteAccountPasswordPolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteAccountPasswordPolicyRequest,DeleteAccountPasswordPolicyResponse>((DeleteAccountPasswordPolicyRequest)req, (DeleteAccountPasswordPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteGroup

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroup">REST API Reference for DeleteGroup Operation</seealso>
        public virtual void DeleteGroupAsync(DeleteGroupRequest request, AmazonServiceCallback<DeleteGroupRequest, DeleteGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteGroupRequest,DeleteGroupResponse> responseObject 
                            = new AmazonServiceResult<DeleteGroupRequest,DeleteGroupResponse>((DeleteGroupRequest)req, (DeleteGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteGroupPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteGroupPolicy">REST API Reference for DeleteGroupPolicy Operation</seealso>
        public virtual void DeleteGroupPolicyAsync(DeleteGroupPolicyRequest request, AmazonServiceCallback<DeleteGroupPolicyRequest, DeleteGroupPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteGroupPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteGroupPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteGroupPolicyRequest,DeleteGroupPolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteGroupPolicyRequest,DeleteGroupPolicyResponse>((DeleteGroupPolicyRequest)req, (DeleteGroupPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteInstanceProfile

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteInstanceProfile">REST API Reference for DeleteInstanceProfile Operation</seealso>
        public virtual void DeleteInstanceProfileAsync(DeleteInstanceProfileRequest request, AmazonServiceCallback<DeleteInstanceProfileRequest, DeleteInstanceProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteInstanceProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteInstanceProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteInstanceProfileRequest,DeleteInstanceProfileResponse> responseObject 
                            = new AmazonServiceResult<DeleteInstanceProfileRequest,DeleteInstanceProfileResponse>((DeleteInstanceProfileRequest)req, (DeleteInstanceProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteLoginProfile

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteLoginProfile">REST API Reference for DeleteLoginProfile Operation</seealso>
        public virtual void DeleteLoginProfileAsync(DeleteLoginProfileRequest request, AmazonServiceCallback<DeleteLoginProfileRequest, DeleteLoginProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteLoginProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteLoginProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteLoginProfileRequest,DeleteLoginProfileResponse> responseObject 
                            = new AmazonServiceResult<DeleteLoginProfileRequest,DeleteLoginProfileResponse>((DeleteLoginProfileRequest)req, (DeleteLoginProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteOpenIDConnectProvider

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteOpenIDConnectProvider">REST API Reference for DeleteOpenIDConnectProvider Operation</seealso>
        public virtual void DeleteOpenIDConnectProviderAsync(DeleteOpenIDConnectProviderRequest request, AmazonServiceCallback<DeleteOpenIDConnectProviderRequest, DeleteOpenIDConnectProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteOpenIDConnectProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteOpenIDConnectProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteOpenIDConnectProviderRequest,DeleteOpenIDConnectProviderResponse> responseObject 
                            = new AmazonServiceResult<DeleteOpenIDConnectProviderRequest,DeleteOpenIDConnectProviderResponse>((DeleteOpenIDConnectProviderRequest)req, (DeleteOpenIDConnectProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeletePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        public virtual void DeletePolicyAsync(DeletePolicyRequest request, AmazonServiceCallback<DeletePolicyRequest, DeletePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeletePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeletePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeletePolicyRequest,DeletePolicyResponse> responseObject 
                            = new AmazonServiceResult<DeletePolicyRequest,DeletePolicyResponse>((DeletePolicyRequest)req, (DeletePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeletePolicyVersion

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeletePolicyVersion">REST API Reference for DeletePolicyVersion Operation</seealso>
        public virtual void DeletePolicyVersionAsync(DeletePolicyVersionRequest request, AmazonServiceCallback<DeletePolicyVersionRequest, DeletePolicyVersionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeletePolicyVersionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeletePolicyVersionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeletePolicyVersionRequest,DeletePolicyVersionResponse> responseObject 
                            = new AmazonServiceResult<DeletePolicyVersionRequest,DeletePolicyVersionResponse>((DeletePolicyVersionRequest)req, (DeletePolicyVersionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteRole

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRole">REST API Reference for DeleteRole Operation</seealso>
        public virtual void DeleteRoleAsync(DeleteRoleRequest request, AmazonServiceCallback<DeleteRoleRequest, DeleteRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteRoleRequest,DeleteRoleResponse> responseObject 
                            = new AmazonServiceResult<DeleteRoleRequest,DeleteRoleResponse>((DeleteRoleRequest)req, (DeleteRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteRolePermissionsBoundary

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePermissionsBoundary">REST API Reference for DeleteRolePermissionsBoundary Operation</seealso>
        public virtual void DeleteRolePermissionsBoundaryAsync(DeleteRolePermissionsBoundaryRequest request, AmazonServiceCallback<DeleteRolePermissionsBoundaryRequest, DeleteRolePermissionsBoundaryResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteRolePermissionsBoundaryRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteRolePermissionsBoundaryResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteRolePermissionsBoundaryRequest,DeleteRolePermissionsBoundaryResponse> responseObject 
                            = new AmazonServiceResult<DeleteRolePermissionsBoundaryRequest,DeleteRolePermissionsBoundaryResponse>((DeleteRolePermissionsBoundaryRequest)req, (DeleteRolePermissionsBoundaryResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteRolePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteRolePolicy">REST API Reference for DeleteRolePolicy Operation</seealso>
        public virtual void DeleteRolePolicyAsync(DeleteRolePolicyRequest request, AmazonServiceCallback<DeleteRolePolicyRequest, DeleteRolePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteRolePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteRolePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteRolePolicyRequest,DeleteRolePolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteRolePolicyRequest,DeleteRolePolicyResponse>((DeleteRolePolicyRequest)req, (DeleteRolePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteSAMLProvider

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSAMLProvider">REST API Reference for DeleteSAMLProvider Operation</seealso>
        public virtual void DeleteSAMLProviderAsync(DeleteSAMLProviderRequest request, AmazonServiceCallback<DeleteSAMLProviderRequest, DeleteSAMLProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteSAMLProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteSAMLProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteSAMLProviderRequest,DeleteSAMLProviderResponse> responseObject 
                            = new AmazonServiceResult<DeleteSAMLProviderRequest,DeleteSAMLProviderResponse>((DeleteSAMLProviderRequest)req, (DeleteSAMLProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteServerCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServerCertificate">REST API Reference for DeleteServerCertificate Operation</seealso>
        public virtual void DeleteServerCertificateAsync(DeleteServerCertificateRequest request, AmazonServiceCallback<DeleteServerCertificateRequest, DeleteServerCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteServerCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteServerCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteServerCertificateRequest,DeleteServerCertificateResponse> responseObject 
                            = new AmazonServiceResult<DeleteServerCertificateRequest,DeleteServerCertificateResponse>((DeleteServerCertificateRequest)req, (DeleteServerCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteServiceLinkedRole

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceLinkedRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceLinkedRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceLinkedRole">REST API Reference for DeleteServiceLinkedRole Operation</seealso>
        public virtual void DeleteServiceLinkedRoleAsync(DeleteServiceLinkedRoleRequest request, AmazonServiceCallback<DeleteServiceLinkedRoleRequest, DeleteServiceLinkedRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteServiceLinkedRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteServiceLinkedRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteServiceLinkedRoleRequest,DeleteServiceLinkedRoleResponse> responseObject 
                            = new AmazonServiceResult<DeleteServiceLinkedRoleRequest,DeleteServiceLinkedRoleResponse>((DeleteServiceLinkedRoleRequest)req, (DeleteServiceLinkedRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteServiceSpecificCredential

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteServiceSpecificCredential">REST API Reference for DeleteServiceSpecificCredential Operation</seealso>
        public virtual void DeleteServiceSpecificCredentialAsync(DeleteServiceSpecificCredentialRequest request, AmazonServiceCallback<DeleteServiceSpecificCredentialRequest, DeleteServiceSpecificCredentialResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteServiceSpecificCredentialRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteServiceSpecificCredentialResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteServiceSpecificCredentialRequest,DeleteServiceSpecificCredentialResponse> responseObject 
                            = new AmazonServiceResult<DeleteServiceSpecificCredentialRequest,DeleteServiceSpecificCredentialResponse>((DeleteServiceSpecificCredentialRequest)req, (DeleteServiceSpecificCredentialResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteSigningCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSigningCertificate">REST API Reference for DeleteSigningCertificate Operation</seealso>
        public virtual void DeleteSigningCertificateAsync(DeleteSigningCertificateRequest request, AmazonServiceCallback<DeleteSigningCertificateRequest, DeleteSigningCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteSigningCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteSigningCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteSigningCertificateRequest,DeleteSigningCertificateResponse> responseObject 
                            = new AmazonServiceResult<DeleteSigningCertificateRequest,DeleteSigningCertificateResponse>((DeleteSigningCertificateRequest)req, (DeleteSigningCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteSSHPublicKey

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteSSHPublicKey">REST API Reference for DeleteSSHPublicKey Operation</seealso>
        public virtual void DeleteSSHPublicKeyAsync(DeleteSSHPublicKeyRequest request, AmazonServiceCallback<DeleteSSHPublicKeyRequest, DeleteSSHPublicKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteSSHPublicKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteSSHPublicKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteSSHPublicKeyRequest,DeleteSSHPublicKeyResponse> responseObject 
                            = new AmazonServiceResult<DeleteSSHPublicKeyRequest,DeleteSSHPublicKeyResponse>((DeleteSSHPublicKeyRequest)req, (DeleteSSHPublicKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUser

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        public virtual void DeleteUserAsync(DeleteUserRequest request, AmazonServiceCallback<DeleteUserRequest, DeleteUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserRequest,DeleteUserResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserRequest,DeleteUserResponse>((DeleteUserRequest)req, (DeleteUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPermissionsBoundary

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPermissionsBoundary">REST API Reference for DeleteUserPermissionsBoundary Operation</seealso>
        public virtual void DeleteUserPermissionsBoundaryAsync(DeleteUserPermissionsBoundaryRequest request, AmazonServiceCallback<DeleteUserPermissionsBoundaryRequest, DeleteUserPermissionsBoundaryResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserPermissionsBoundaryRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserPermissionsBoundaryResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPermissionsBoundaryRequest,DeleteUserPermissionsBoundaryResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPermissionsBoundaryRequest,DeleteUserPermissionsBoundaryResponse>((DeleteUserPermissionsBoundaryRequest)req, (DeleteUserPermissionsBoundaryResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteUserPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteUserPolicy">REST API Reference for DeleteUserPolicy Operation</seealso>
        public virtual void DeleteUserPolicyAsync(DeleteUserPolicyRequest request, AmazonServiceCallback<DeleteUserPolicyRequest, DeleteUserPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteUserPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteUserPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteUserPolicyRequest,DeleteUserPolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteUserPolicyRequest,DeleteUserPolicyResponse>((DeleteUserPolicyRequest)req, (DeleteUserPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteVirtualMFADevice

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DeleteVirtualMFADevice">REST API Reference for DeleteVirtualMFADevice Operation</seealso>
        public virtual void DeleteVirtualMFADeviceAsync(DeleteVirtualMFADeviceRequest request, AmazonServiceCallback<DeleteVirtualMFADeviceRequest, DeleteVirtualMFADeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteVirtualMFADeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteVirtualMFADeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteVirtualMFADeviceRequest,DeleteVirtualMFADeviceResponse> responseObject 
                            = new AmazonServiceResult<DeleteVirtualMFADeviceRequest,DeleteVirtualMFADeviceResponse>((DeleteVirtualMFADeviceRequest)req, (DeleteVirtualMFADeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetachGroupPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DetachGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachGroupPolicy">REST API Reference for DetachGroupPolicy Operation</seealso>
        public virtual void DetachGroupPolicyAsync(DetachGroupPolicyRequest request, AmazonServiceCallback<DetachGroupPolicyRequest, DetachGroupPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetachGroupPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetachGroupPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetachGroupPolicyRequest,DetachGroupPolicyResponse> responseObject 
                            = new AmazonServiceResult<DetachGroupPolicyRequest,DetachGroupPolicyResponse>((DetachGroupPolicyRequest)req, (DetachGroupPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetachRolePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DetachRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachRolePolicy">REST API Reference for DetachRolePolicy Operation</seealso>
        public virtual void DetachRolePolicyAsync(DetachRolePolicyRequest request, AmazonServiceCallback<DetachRolePolicyRequest, DetachRolePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetachRolePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetachRolePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetachRolePolicyRequest,DetachRolePolicyResponse> responseObject 
                            = new AmazonServiceResult<DetachRolePolicyRequest,DetachRolePolicyResponse>((DetachRolePolicyRequest)req, (DetachRolePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DetachUserPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DetachUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/DetachUserPolicy">REST API Reference for DetachUserPolicy Operation</seealso>
        public virtual void DetachUserPolicyAsync(DetachUserPolicyRequest request, AmazonServiceCallback<DetachUserPolicyRequest, DetachUserPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DetachUserPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DetachUserPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DetachUserPolicyRequest,DetachUserPolicyResponse> responseObject 
                            = new AmazonServiceResult<DetachUserPolicyRequest,DetachUserPolicyResponse>((DetachUserPolicyRequest)req, (DetachUserPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  EnableMFADevice

        /// <summary>
        /// Initiates the asynchronous execution of the EnableMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/EnableMFADevice">REST API Reference for EnableMFADevice Operation</seealso>
        public virtual void EnableMFADeviceAsync(EnableMFADeviceRequest request, AmazonServiceCallback<EnableMFADeviceRequest, EnableMFADeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = EnableMFADeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = EnableMFADeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<EnableMFADeviceRequest,EnableMFADeviceResponse> responseObject 
                            = new AmazonServiceResult<EnableMFADeviceRequest,EnableMFADeviceResponse>((EnableMFADeviceRequest)req, (EnableMFADeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GenerateCredentialReport

        /// <summary>
        /// Generates a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GenerateCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual void GenerateCredentialReportAsync(AmazonServiceCallback<GenerateCredentialReportRequest, GenerateCredentialReportResponse> callback, AsyncOptions options = null)
        {
            GenerateCredentialReportAsync(new GenerateCredentialReportRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GenerateCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateCredentialReport">REST API Reference for GenerateCredentialReport Operation</seealso>
        public virtual void GenerateCredentialReportAsync(GenerateCredentialReportRequest request, AmazonServiceCallback<GenerateCredentialReportRequest, GenerateCredentialReportResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GenerateCredentialReportRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GenerateCredentialReportResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GenerateCredentialReportRequest,GenerateCredentialReportResponse> responseObject 
                            = new AmazonServiceResult<GenerateCredentialReportRequest,GenerateCredentialReportResponse>((GenerateCredentialReportRequest)req, (GenerateCredentialReportResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GenerateOrganizationsAccessReport

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateOrganizationsAccessReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateOrganizationsAccessReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateOrganizationsAccessReport">REST API Reference for GenerateOrganizationsAccessReport Operation</seealso>
        public virtual void GenerateOrganizationsAccessReportAsync(GenerateOrganizationsAccessReportRequest request, AmazonServiceCallback<GenerateOrganizationsAccessReportRequest, GenerateOrganizationsAccessReportResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GenerateOrganizationsAccessReportRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GenerateOrganizationsAccessReportResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GenerateOrganizationsAccessReportRequest,GenerateOrganizationsAccessReportResponse> responseObject 
                            = new AmazonServiceResult<GenerateOrganizationsAccessReportRequest,GenerateOrganizationsAccessReportResponse>((GenerateOrganizationsAccessReportRequest)req, (GenerateOrganizationsAccessReportResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GenerateServiceLastAccessedDetails

        /// <summary>
        /// Initiates the asynchronous execution of the GenerateServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GenerateServiceLastAccessedDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GenerateServiceLastAccessedDetails">REST API Reference for GenerateServiceLastAccessedDetails Operation</seealso>
        public virtual void GenerateServiceLastAccessedDetailsAsync(GenerateServiceLastAccessedDetailsRequest request, AmazonServiceCallback<GenerateServiceLastAccessedDetailsRequest, GenerateServiceLastAccessedDetailsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GenerateServiceLastAccessedDetailsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GenerateServiceLastAccessedDetailsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GenerateServiceLastAccessedDetailsRequest,GenerateServiceLastAccessedDetailsResponse> responseObject 
                            = new AmazonServiceResult<GenerateServiceLastAccessedDetailsRequest,GenerateServiceLastAccessedDetailsResponse>((GenerateServiceLastAccessedDetailsRequest)req, (GenerateServiceLastAccessedDetailsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetAccessKeyLastUsed

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessKeyLastUsed operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessKeyLastUsed operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccessKeyLastUsed">REST API Reference for GetAccessKeyLastUsed Operation</seealso>
        public virtual void GetAccessKeyLastUsedAsync(GetAccessKeyLastUsedRequest request, AmazonServiceCallback<GetAccessKeyLastUsedRequest, GetAccessKeyLastUsedResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetAccessKeyLastUsedRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetAccessKeyLastUsedResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAccessKeyLastUsedRequest,GetAccessKeyLastUsedResponse> responseObject 
                            = new AmazonServiceResult<GetAccessKeyLastUsedRequest,GetAccessKeyLastUsedResponse>((GetAccessKeyLastUsedRequest)req, (GetAccessKeyLastUsedResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetAccountAuthorizationDetails

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountAuthorizationDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountAuthorizationDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountAuthorizationDetails">REST API Reference for GetAccountAuthorizationDetails Operation</seealso>
        public virtual void GetAccountAuthorizationDetailsAsync(GetAccountAuthorizationDetailsRequest request, AmazonServiceCallback<GetAccountAuthorizationDetailsRequest, GetAccountAuthorizationDetailsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetAccountAuthorizationDetailsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetAccountAuthorizationDetailsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAccountAuthorizationDetailsRequest,GetAccountAuthorizationDetailsResponse> responseObject 
                            = new AmazonServiceResult<GetAccountAuthorizationDetailsRequest,GetAccountAuthorizationDetailsResponse>((GetAccountAuthorizationDetailsRequest)req, (GetAccountAuthorizationDetailsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetAccountPasswordPolicy

        /// <summary>
        /// Retrieves the password policy for the AWS account. For more information about using
        /// a password policy, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a>.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        public virtual void GetAccountPasswordPolicyAsync(AmazonServiceCallback<GetAccountPasswordPolicyRequest, GetAccountPasswordPolicyResponse> callback, AsyncOptions options = null)
        {
            GetAccountPasswordPolicyAsync(new GetAccountPasswordPolicyRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountPasswordPolicy">REST API Reference for GetAccountPasswordPolicy Operation</seealso>
        public virtual void GetAccountPasswordPolicyAsync(GetAccountPasswordPolicyRequest request, AmazonServiceCallback<GetAccountPasswordPolicyRequest, GetAccountPasswordPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetAccountPasswordPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetAccountPasswordPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAccountPasswordPolicyRequest,GetAccountPasswordPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetAccountPasswordPolicyRequest,GetAccountPasswordPolicyResponse>((GetAccountPasswordPolicyRequest)req, (GetAccountPasswordPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetAccountSummary

        /// <summary>
        /// Retrieves information about IAM entity usage and IAM quotas in the AWS account.
        /// 
        ///  
        /// <para>
        ///  For information about limitations on IAM entities, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
        /// on IAM Entities</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetAccountSummary service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        public virtual void GetAccountSummaryAsync(AmazonServiceCallback<GetAccountSummaryRequest, GetAccountSummaryResponse> callback, AsyncOptions options = null)
        {
            GetAccountSummaryAsync(new GetAccountSummaryRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSummary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetAccountSummary">REST API Reference for GetAccountSummary Operation</seealso>
        public virtual void GetAccountSummaryAsync(GetAccountSummaryRequest request, AmazonServiceCallback<GetAccountSummaryRequest, GetAccountSummaryResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetAccountSummaryRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetAccountSummaryResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetAccountSummaryRequest,GetAccountSummaryResponse> responseObject 
                            = new AmazonServiceResult<GetAccountSummaryRequest,GetAccountSummaryResponse>((GetAccountSummaryRequest)req, (GetAccountSummaryResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetContextKeysForCustomPolicy

        /// <summary>
        /// Gets a list of all of the context keys referenced in the input policies. The policies
        /// are supplied as a list of one or more strings. To get the context keys from policies
        /// associated with an IAM user, group, or role, use <a>GetContextKeysForPrincipalPolicy</a>.
        /// 
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. Context keys can be evaluated by testing
        /// against a value specified in an IAM policy. Use <code>GetContextKeysForCustomPolicy</code>
        /// to understand what key names and values you must supply when you call <a>SimulateCustomPolicy</a>.
        /// Note that all parameters are shown in unencoded form here for clarity but must be
        /// URL encoded to be included as a part of a real HTML request.
        /// </para>
        /// </summary>
        /// <param name="policyInputList">A list of policies for which you want the list of context keys referenced in those policies. Each document is specified as a string containing the complete, valid JSON text of an IAM policy. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForCustomPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        public virtual void GetContextKeysForCustomPolicyAsync(List<string> policyInputList,  AmazonServiceCallback<GetContextKeysForCustomPolicyRequest, GetContextKeysForCustomPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new GetContextKeysForCustomPolicyRequest();
            request.PolicyInputList = policyInputList;
            GetContextKeysForCustomPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForCustomPolicy">REST API Reference for GetContextKeysForCustomPolicy Operation</seealso>
        public virtual void GetContextKeysForCustomPolicyAsync(GetContextKeysForCustomPolicyRequest request, AmazonServiceCallback<GetContextKeysForCustomPolicyRequest, GetContextKeysForCustomPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetContextKeysForCustomPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetContextKeysForCustomPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetContextKeysForCustomPolicyRequest,GetContextKeysForCustomPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetContextKeysForCustomPolicyRequest,GetContextKeysForCustomPolicyResponse>((GetContextKeysForCustomPolicyRequest)req, (GetContextKeysForCustomPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetContextKeysForPrincipalPolicy

        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. Context keys can be evaluated by testing
        /// against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a> to understand
        /// what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        public virtual void GetContextKeysForPrincipalPolicyAsync(string policySourceArn,  AmazonServiceCallback<GetContextKeysForPrincipalPolicyRequest, GetContextKeysForPrincipalPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            GetContextKeysForPrincipalPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Gets a list of all of the context keys referenced in all the IAM policies that are
        /// attached to the specified IAM entity. The entity can be an IAM user, group, or role.
        /// If you specify a user, then the request also includes all of the policies attached
        /// to groups that the user is a member of.
        /// 
        ///  
        /// <para>
        /// You can optionally include a list of one or more additional policies, specified as
        /// strings. If you want to include <i>only</i> a list of policies by string, use <a>GetContextKeysForCustomPolicy</a>
        /// instead.
        /// </para>
        ///  
        /// <para>
        ///  <b>Note:</b> This API discloses information about the permissions granted to other
        /// users. If you do not want users to see other user's permissions, then consider allowing
        /// them to use <a>GetContextKeysForCustomPolicy</a> instead.
        /// </para>
        ///  
        /// <para>
        /// Context keys are variables maintained by AWS and its services that provide details
        /// about the context of an API query request. Context keys can be evaluated by testing
        /// against a value in an IAM policy. Use <a>GetContextKeysForPrincipalPolicy</a> to understand
        /// what key names and values you must supply when you call <a>SimulatePrincipalPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="policySourceArn">The ARN of a user, group, or role whose policies contain the context keys that you want listed. If you specify a user, the list includes context keys that are found in all policies that are attached to the user. The list also includes all groups that the user is a member of. If you pick a group or a role, then it includes only those context keys that are found in policies attached to that entity. Note that all parameters are shown in unencoded form here for clarity, but must be URL encoded to be included as a part of a real HTML request. For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.</param>
        /// <param name="policyInputList">An optional list of additional policies for which you want the list of context keys that are referenced. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetContextKeysForPrincipalPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.InvalidInputException">
        /// The request was rejected because an invalid or out-of-range value was supplied for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        public virtual void GetContextKeysForPrincipalPolicyAsync(string policySourceArn, List<string> policyInputList,  AmazonServiceCallback<GetContextKeysForPrincipalPolicyRequest, GetContextKeysForPrincipalPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new GetContextKeysForPrincipalPolicyRequest();
            request.PolicySourceArn = policySourceArn;
            request.PolicyInputList = policyInputList;
            GetContextKeysForPrincipalPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetContextKeysForPrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetContextKeysForPrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetContextKeysForPrincipalPolicy">REST API Reference for GetContextKeysForPrincipalPolicy Operation</seealso>
        public virtual void GetContextKeysForPrincipalPolicyAsync(GetContextKeysForPrincipalPolicyRequest request, AmazonServiceCallback<GetContextKeysForPrincipalPolicyRequest, GetContextKeysForPrincipalPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetContextKeysForPrincipalPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetContextKeysForPrincipalPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetContextKeysForPrincipalPolicyRequest,GetContextKeysForPrincipalPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetContextKeysForPrincipalPolicyRequest,GetContextKeysForPrincipalPolicyResponse>((GetContextKeysForPrincipalPolicyRequest)req, (GetContextKeysForPrincipalPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetCredentialReport

        /// <summary>
        /// Retrieves a credential report for the AWS account. For more information about the
        /// credential report, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetCredentialReport service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportExpiredException">
        /// The request was rejected because the most recent credential report has expired. To
        /// generate a new credential report, use <a>GenerateCredentialReport</a>. For more information
        /// about credential report expiration, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/credential-reports.html">Getting
        /// Credential Reports</a> in the <i>IAM User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotPresentException">
        /// The request was rejected because the credential report does not exist. To generate
        /// a credential report, use <a>GenerateCredentialReport</a>.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.CredentialReportNotReadyException">
        /// The request was rejected because the credential report is still being generated.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        public virtual void GetCredentialReportAsync(AmazonServiceCallback<GetCredentialReportRequest, GetCredentialReportResponse> callback, AsyncOptions options = null)
        {
            GetCredentialReportAsync(new GetCredentialReportRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCredentialReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCredentialReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetCredentialReport">REST API Reference for GetCredentialReport Operation</seealso>
        public virtual void GetCredentialReportAsync(GetCredentialReportRequest request, AmazonServiceCallback<GetCredentialReportRequest, GetCredentialReportResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetCredentialReportRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetCredentialReportResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCredentialReportRequest,GetCredentialReportResponse> responseObject 
                            = new AmazonServiceResult<GetCredentialReportRequest,GetCredentialReportResponse>((GetCredentialReportRequest)req, (GetCredentialReportResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetGroup

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroup">REST API Reference for GetGroup Operation</seealso>
        public virtual void GetGroupAsync(GetGroupRequest request, AmazonServiceCallback<GetGroupRequest, GetGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetGroupRequest,GetGroupResponse> responseObject 
                            = new AmazonServiceResult<GetGroupRequest,GetGroupResponse>((GetGroupRequest)req, (GetGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetGroupPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetGroupPolicy">REST API Reference for GetGroupPolicy Operation</seealso>
        public virtual void GetGroupPolicyAsync(GetGroupPolicyRequest request, AmazonServiceCallback<GetGroupPolicyRequest, GetGroupPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetGroupPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetGroupPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetGroupPolicyRequest,GetGroupPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetGroupPolicyRequest,GetGroupPolicyResponse>((GetGroupPolicyRequest)req, (GetGroupPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetInstanceProfile

        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetInstanceProfile">REST API Reference for GetInstanceProfile Operation</seealso>
        public virtual void GetInstanceProfileAsync(GetInstanceProfileRequest request, AmazonServiceCallback<GetInstanceProfileRequest, GetInstanceProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetInstanceProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetInstanceProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetInstanceProfileRequest,GetInstanceProfileResponse> responseObject 
                            = new AmazonServiceResult<GetInstanceProfileRequest,GetInstanceProfileResponse>((GetInstanceProfileRequest)req, (GetInstanceProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetLoginProfile

        /// <summary>
        /// Initiates the asynchronous execution of the GetLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetLoginProfile">REST API Reference for GetLoginProfile Operation</seealso>
        public virtual void GetLoginProfileAsync(GetLoginProfileRequest request, AmazonServiceCallback<GetLoginProfileRequest, GetLoginProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetLoginProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetLoginProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetLoginProfileRequest,GetLoginProfileResponse> responseObject 
                            = new AmazonServiceResult<GetLoginProfileRequest,GetLoginProfileResponse>((GetLoginProfileRequest)req, (GetLoginProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetOpenIDConnectProvider

        /// <summary>
        /// Initiates the asynchronous execution of the GetOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOpenIDConnectProvider">REST API Reference for GetOpenIDConnectProvider Operation</seealso>
        public virtual void GetOpenIDConnectProviderAsync(GetOpenIDConnectProviderRequest request, AmazonServiceCallback<GetOpenIDConnectProviderRequest, GetOpenIDConnectProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetOpenIDConnectProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetOpenIDConnectProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetOpenIDConnectProviderRequest,GetOpenIDConnectProviderResponse> responseObject 
                            = new AmazonServiceResult<GetOpenIDConnectProviderRequest,GetOpenIDConnectProviderResponse>((GetOpenIDConnectProviderRequest)req, (GetOpenIDConnectProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetOrganizationsAccessReport

        /// <summary>
        /// Initiates the asynchronous execution of the GetOrganizationsAccessReport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetOrganizationsAccessReport operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetOrganizationsAccessReport">REST API Reference for GetOrganizationsAccessReport Operation</seealso>
        public virtual void GetOrganizationsAccessReportAsync(GetOrganizationsAccessReportRequest request, AmazonServiceCallback<GetOrganizationsAccessReportRequest, GetOrganizationsAccessReportResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetOrganizationsAccessReportRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetOrganizationsAccessReportResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetOrganizationsAccessReportRequest,GetOrganizationsAccessReportResponse> responseObject 
                            = new AmazonServiceResult<GetOrganizationsAccessReportRequest,GetOrganizationsAccessReportResponse>((GetOrganizationsAccessReportRequest)req, (GetOrganizationsAccessReportResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicy">REST API Reference for GetPolicy Operation</seealso>
        public virtual void GetPolicyAsync(GetPolicyRequest request, AmazonServiceCallback<GetPolicyRequest, GetPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetPolicyRequest,GetPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetPolicyRequest,GetPolicyResponse>((GetPolicyRequest)req, (GetPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetPolicyVersion

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual void GetPolicyVersionAsync(GetPolicyVersionRequest request, AmazonServiceCallback<GetPolicyVersionRequest, GetPolicyVersionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetPolicyVersionRequest,GetPolicyVersionResponse> responseObject 
                            = new AmazonServiceResult<GetPolicyVersionRequest,GetPolicyVersionResponse>((GetPolicyVersionRequest)req, (GetPolicyVersionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetRole

        /// <summary>
        /// Initiates the asynchronous execution of the GetRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRole">REST API Reference for GetRole Operation</seealso>
        public virtual void GetRoleAsync(GetRoleRequest request, AmazonServiceCallback<GetRoleRequest, GetRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetRoleRequest,GetRoleResponse> responseObject 
                            = new AmazonServiceResult<GetRoleRequest,GetRoleResponse>((GetRoleRequest)req, (GetRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetRolePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetRolePolicy">REST API Reference for GetRolePolicy Operation</seealso>
        public virtual void GetRolePolicyAsync(GetRolePolicyRequest request, AmazonServiceCallback<GetRolePolicyRequest, GetRolePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetRolePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetRolePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetRolePolicyRequest,GetRolePolicyResponse> responseObject 
                            = new AmazonServiceResult<GetRolePolicyRequest,GetRolePolicyResponse>((GetRolePolicyRequest)req, (GetRolePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetSAMLProvider

        /// <summary>
        /// Initiates the asynchronous execution of the GetSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSAMLProvider">REST API Reference for GetSAMLProvider Operation</seealso>
        public virtual void GetSAMLProviderAsync(GetSAMLProviderRequest request, AmazonServiceCallback<GetSAMLProviderRequest, GetSAMLProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetSAMLProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetSAMLProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetSAMLProviderRequest,GetSAMLProviderResponse> responseObject 
                            = new AmazonServiceResult<GetSAMLProviderRequest,GetSAMLProviderResponse>((GetSAMLProviderRequest)req, (GetSAMLProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetServerCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the GetServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServerCertificate">REST API Reference for GetServerCertificate Operation</seealso>
        public virtual void GetServerCertificateAsync(GetServerCertificateRequest request, AmazonServiceCallback<GetServerCertificateRequest, GetServerCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetServerCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetServerCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetServerCertificateRequest,GetServerCertificateResponse> responseObject 
                            = new AmazonServiceResult<GetServerCertificateRequest,GetServerCertificateResponse>((GetServerCertificateRequest)req, (GetServerCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetServiceLastAccessedDetails

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLastAccessedDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetails operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetails">REST API Reference for GetServiceLastAccessedDetails Operation</seealso>
        public virtual void GetServiceLastAccessedDetailsAsync(GetServiceLastAccessedDetailsRequest request, AmazonServiceCallback<GetServiceLastAccessedDetailsRequest, GetServiceLastAccessedDetailsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetServiceLastAccessedDetailsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetServiceLastAccessedDetailsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetServiceLastAccessedDetailsRequest,GetServiceLastAccessedDetailsResponse> responseObject 
                            = new AmazonServiceResult<GetServiceLastAccessedDetailsRequest,GetServiceLastAccessedDetailsResponse>((GetServiceLastAccessedDetailsRequest)req, (GetServiceLastAccessedDetailsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetServiceLastAccessedDetailsWithEntities

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLastAccessedDetailsWithEntities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLastAccessedDetailsWithEntities operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLastAccessedDetailsWithEntities">REST API Reference for GetServiceLastAccessedDetailsWithEntities Operation</seealso>
        public virtual void GetServiceLastAccessedDetailsWithEntitiesAsync(GetServiceLastAccessedDetailsWithEntitiesRequest request, AmazonServiceCallback<GetServiceLastAccessedDetailsWithEntitiesRequest, GetServiceLastAccessedDetailsWithEntitiesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetServiceLastAccessedDetailsWithEntitiesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetServiceLastAccessedDetailsWithEntitiesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetServiceLastAccessedDetailsWithEntitiesRequest,GetServiceLastAccessedDetailsWithEntitiesResponse> responseObject 
                            = new AmazonServiceResult<GetServiceLastAccessedDetailsWithEntitiesRequest,GetServiceLastAccessedDetailsWithEntitiesResponse>((GetServiceLastAccessedDetailsWithEntitiesRequest)req, (GetServiceLastAccessedDetailsWithEntitiesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetServiceLinkedRoleDeletionStatus

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceLinkedRoleDeletionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceLinkedRoleDeletionStatus operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetServiceLinkedRoleDeletionStatus">REST API Reference for GetServiceLinkedRoleDeletionStatus Operation</seealso>
        public virtual void GetServiceLinkedRoleDeletionStatusAsync(GetServiceLinkedRoleDeletionStatusRequest request, AmazonServiceCallback<GetServiceLinkedRoleDeletionStatusRequest, GetServiceLinkedRoleDeletionStatusResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetServiceLinkedRoleDeletionStatusRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetServiceLinkedRoleDeletionStatusResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetServiceLinkedRoleDeletionStatusRequest,GetServiceLinkedRoleDeletionStatusResponse> responseObject 
                            = new AmazonServiceResult<GetServiceLinkedRoleDeletionStatusRequest,GetServiceLinkedRoleDeletionStatusResponse>((GetServiceLinkedRoleDeletionStatusRequest)req, (GetServiceLinkedRoleDeletionStatusResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetSSHPublicKey

        /// <summary>
        /// Initiates the asynchronous execution of the GetSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetSSHPublicKey">REST API Reference for GetSSHPublicKey Operation</seealso>
        public virtual void GetSSHPublicKeyAsync(GetSSHPublicKeyRequest request, AmazonServiceCallback<GetSSHPublicKeyRequest, GetSSHPublicKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetSSHPublicKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetSSHPublicKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetSSHPublicKeyRequest,GetSSHPublicKeyResponse> responseObject 
                            = new AmazonServiceResult<GetSSHPublicKeyRequest,GetSSHPublicKeyResponse>((GetSSHPublicKeyRequest)req, (GetSSHPublicKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetUser

        /// <summary>
        /// Retrieves information about the specified IAM user, including the user's creation
        /// date, path, unique ID, and ARN.
        /// 
        ///  
        /// <para>
        /// If you do not specify a user name, IAM determines the user name implicitly based on
        /// the AWS access key ID used to sign the request to this API.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the GetUser service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual void GetUserAsync(AmazonServiceCallback<GetUserRequest, GetUserResponse> callback, AsyncOptions options = null)
        {
            GetUserAsync(new GetUserRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUser">REST API Reference for GetUser Operation</seealso>
        public virtual void GetUserAsync(GetUserRequest request, AmazonServiceCallback<GetUserRequest, GetUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserRequest,GetUserResponse> responseObject 
                            = new AmazonServiceResult<GetUserRequest,GetUserResponse>((GetUserRequest)req, (GetUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetUserPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/GetUserPolicy">REST API Reference for GetUserPolicy Operation</seealso>
        public virtual void GetUserPolicyAsync(GetUserPolicyRequest request, AmazonServiceCallback<GetUserPolicyRequest, GetUserPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetUserPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetUserPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetUserPolicyRequest,GetUserPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetUserPolicyRequest,GetUserPolicyResponse>((GetUserPolicyRequest)req, (GetUserPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListAccessKeys

        /// <summary>
        /// Returns information about the access key IDs associated with the specified IAM user.
        /// If there is none, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of keys, you can still paginate the
        /// results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request. This operation works for
        /// access keys under the AWS account. Consequently, you can use this operation to manage
        /// AWS account root user credentials even if the AWS account has no associated users.
        /// </para>
        ///  <note> 
        /// <para>
        /// To ensure the security of your AWS account, the secret access key is accessible only
        /// during key and user creation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListAccessKeys service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        public virtual void ListAccessKeysAsync(AmazonServiceCallback<ListAccessKeysRequest, ListAccessKeysResponse> callback, AsyncOptions options = null)
        {
            ListAccessKeysAsync(new ListAccessKeysRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccessKeys">REST API Reference for ListAccessKeys Operation</seealso>
        public virtual void ListAccessKeysAsync(ListAccessKeysRequest request, AmazonServiceCallback<ListAccessKeysRequest, ListAccessKeysResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListAccessKeysRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListAccessKeysResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListAccessKeysRequest,ListAccessKeysResponse> responseObject 
                            = new AmazonServiceResult<ListAccessKeysRequest,ListAccessKeysResponse>((ListAccessKeysRequest)req, (ListAccessKeysResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListAccountAliases

        /// <summary>
        /// Lists the account alias associated with the AWS account (Note: you can have only one).
        /// For information about using an AWS account alias, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AccountAlias.html">Using
        /// an Alias for Your AWS Account ID</a> in the <i>IAM User Guide</i>.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListAccountAliases service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        public virtual void ListAccountAliasesAsync(AmazonServiceCallback<ListAccountAliasesRequest, ListAccountAliasesResponse> callback, AsyncOptions options = null)
        {
            ListAccountAliasesAsync(new ListAccountAliasesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountAliases operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAccountAliases">REST API Reference for ListAccountAliases Operation</seealso>
        public virtual void ListAccountAliasesAsync(ListAccountAliasesRequest request, AmazonServiceCallback<ListAccountAliasesRequest, ListAccountAliasesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListAccountAliasesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListAccountAliasesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListAccountAliasesRequest,ListAccountAliasesResponse> responseObject 
                            = new AmazonServiceResult<ListAccountAliasesRequest,ListAccountAliasesResponse>((ListAccountAliasesRequest)req, (ListAccountAliasesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListAttachedGroupPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedGroupPolicies">REST API Reference for ListAttachedGroupPolicies Operation</seealso>
        public virtual void ListAttachedGroupPoliciesAsync(ListAttachedGroupPoliciesRequest request, AmazonServiceCallback<ListAttachedGroupPoliciesRequest, ListAttachedGroupPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListAttachedGroupPoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListAttachedGroupPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListAttachedGroupPoliciesRequest,ListAttachedGroupPoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListAttachedGroupPoliciesRequest,ListAttachedGroupPoliciesResponse>((ListAttachedGroupPoliciesRequest)req, (ListAttachedGroupPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListAttachedRolePolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedRolePolicies">REST API Reference for ListAttachedRolePolicies Operation</seealso>
        public virtual void ListAttachedRolePoliciesAsync(ListAttachedRolePoliciesRequest request, AmazonServiceCallback<ListAttachedRolePoliciesRequest, ListAttachedRolePoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListAttachedRolePoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListAttachedRolePoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListAttachedRolePoliciesRequest,ListAttachedRolePoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListAttachedRolePoliciesRequest,ListAttachedRolePoliciesResponse>((ListAttachedRolePoliciesRequest)req, (ListAttachedRolePoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListAttachedUserPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachedUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachedUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListAttachedUserPolicies">REST API Reference for ListAttachedUserPolicies Operation</seealso>
        public virtual void ListAttachedUserPoliciesAsync(ListAttachedUserPoliciesRequest request, AmazonServiceCallback<ListAttachedUserPoliciesRequest, ListAttachedUserPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListAttachedUserPoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListAttachedUserPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListAttachedUserPoliciesRequest,ListAttachedUserPoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListAttachedUserPoliciesRequest,ListAttachedUserPoliciesResponse>((ListAttachedUserPoliciesRequest)req, (ListAttachedUserPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListEntitiesForPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the ListEntitiesForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEntitiesForPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListEntitiesForPolicy">REST API Reference for ListEntitiesForPolicy Operation</seealso>
        public virtual void ListEntitiesForPolicyAsync(ListEntitiesForPolicyRequest request, AmazonServiceCallback<ListEntitiesForPolicyRequest, ListEntitiesForPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListEntitiesForPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListEntitiesForPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListEntitiesForPolicyRequest,ListEntitiesForPolicyResponse> responseObject 
                            = new AmazonServiceResult<ListEntitiesForPolicyRequest,ListEntitiesForPolicyResponse>((ListEntitiesForPolicyRequest)req, (ListEntitiesForPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListGroupPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupPolicies">REST API Reference for ListGroupPolicies Operation</seealso>
        public virtual void ListGroupPoliciesAsync(ListGroupPoliciesRequest request, AmazonServiceCallback<ListGroupPoliciesRequest, ListGroupPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListGroupPoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListGroupPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListGroupPoliciesRequest,ListGroupPoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListGroupPoliciesRequest,ListGroupPoliciesResponse>((ListGroupPoliciesRequest)req, (ListGroupPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListGroups

        /// <summary>
        /// Lists the IAM groups that have the specified path prefix.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListGroups service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual void ListGroupsAsync(AmazonServiceCallback<ListGroupsRequest, ListGroupsResponse> callback, AsyncOptions options = null)
        {
            ListGroupsAsync(new ListGroupsRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroups operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroups">REST API Reference for ListGroups Operation</seealso>
        public virtual void ListGroupsAsync(ListGroupsRequest request, AmazonServiceCallback<ListGroupsRequest, ListGroupsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListGroupsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListGroupsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListGroupsRequest,ListGroupsResponse> responseObject 
                            = new AmazonServiceResult<ListGroupsRequest,ListGroupsResponse>((ListGroupsRequest)req, (ListGroupsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListGroupsForUser

        /// <summary>
        /// Initiates the asynchronous execution of the ListGroupsForUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListGroupsForUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListGroupsForUser">REST API Reference for ListGroupsForUser Operation</seealso>
        public virtual void ListGroupsForUserAsync(ListGroupsForUserRequest request, AmazonServiceCallback<ListGroupsForUserRequest, ListGroupsForUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListGroupsForUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListGroupsForUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListGroupsForUserRequest,ListGroupsForUserResponse> responseObject 
                            = new AmazonServiceResult<ListGroupsForUserRequest,ListGroupsForUserResponse>((ListGroupsForUserRequest)req, (ListGroupsForUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListInstanceProfiles

        /// <summary>
        /// Lists the instance profiles that have the specified path prefix. If there are none,
        /// the operation returns an empty list. For more information about instance profiles,
        /// go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/AboutInstanceProfiles.html">About
        /// Instance Profiles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListInstanceProfiles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual void ListInstanceProfilesAsync(AmazonServiceCallback<ListInstanceProfilesRequest, ListInstanceProfilesResponse> callback, AsyncOptions options = null)
        {
            ListInstanceProfilesAsync(new ListInstanceProfilesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfiles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfiles">REST API Reference for ListInstanceProfiles Operation</seealso>
        public virtual void ListInstanceProfilesAsync(ListInstanceProfilesRequest request, AmazonServiceCallback<ListInstanceProfilesRequest, ListInstanceProfilesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListInstanceProfilesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListInstanceProfilesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListInstanceProfilesRequest,ListInstanceProfilesResponse> responseObject 
                            = new AmazonServiceResult<ListInstanceProfilesRequest,ListInstanceProfilesResponse>((ListInstanceProfilesRequest)req, (ListInstanceProfilesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListInstanceProfilesForRole

        /// <summary>
        /// Initiates the asynchronous execution of the ListInstanceProfilesForRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInstanceProfilesForRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListInstanceProfilesForRole">REST API Reference for ListInstanceProfilesForRole Operation</seealso>
        public virtual void ListInstanceProfilesForRoleAsync(ListInstanceProfilesForRoleRequest request, AmazonServiceCallback<ListInstanceProfilesForRoleRequest, ListInstanceProfilesForRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListInstanceProfilesForRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListInstanceProfilesForRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListInstanceProfilesForRoleRequest,ListInstanceProfilesForRoleResponse> responseObject 
                            = new AmazonServiceResult<ListInstanceProfilesForRoleRequest,ListInstanceProfilesForRoleResponse>((ListInstanceProfilesForRoleRequest)req, (ListInstanceProfilesForRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListMFADevices

        /// <summary>
        /// Lists the MFA devices for an IAM user. If the request includes a IAM user name, then
        /// this operation lists all the MFA devices associated with the specified user. If you
        /// do not specify a user name, IAM determines the user name implicitly based on the AWS
        /// access key ID signing the request for this API.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        public virtual void ListMFADevicesAsync(AmazonServiceCallback<ListMFADevicesRequest, ListMFADevicesResponse> callback, AsyncOptions options = null)
        {
            ListMFADevicesAsync(new ListMFADevicesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListMFADevices">REST API Reference for ListMFADevices Operation</seealso>
        public virtual void ListMFADevicesAsync(ListMFADevicesRequest request, AmazonServiceCallback<ListMFADevicesRequest, ListMFADevicesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListMFADevicesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListMFADevicesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListMFADevicesRequest,ListMFADevicesResponse> responseObject 
                            = new AmazonServiceResult<ListMFADevicesRequest,ListMFADevicesResponse>((ListMFADevicesRequest)req, (ListMFADevicesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListOpenIDConnectProviders

        /// <summary>
        /// Initiates the asynchronous execution of the ListOpenIDConnectProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOpenIDConnectProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListOpenIDConnectProviders">REST API Reference for ListOpenIDConnectProviders Operation</seealso>
        public virtual void ListOpenIDConnectProvidersAsync(ListOpenIDConnectProvidersRequest request, AmazonServiceCallback<ListOpenIDConnectProvidersRequest, ListOpenIDConnectProvidersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListOpenIDConnectProvidersRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListOpenIDConnectProvidersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListOpenIDConnectProvidersRequest,ListOpenIDConnectProvidersResponse> responseObject 
                            = new AmazonServiceResult<ListOpenIDConnectProvidersRequest,ListOpenIDConnectProvidersResponse>((ListOpenIDConnectProvidersRequest)req, (ListOpenIDConnectProvidersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListPolicies

        /// <summary>
        /// Lists all the managed policies that are available in your AWS account, including your
        /// own customer-defined managed policies and all AWS managed policies.
        /// 
        ///  
        /// <para>
        /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
        /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
        /// the customer managed policies in your AWS account, set <code>Scope</code> to <code>Local</code>.
        /// To list only AWS managed policies, set <code>Scope</code> to <code>AWS</code>.
        /// </para>
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about managed policies, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
        /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual void ListPoliciesAsync(AmazonServiceCallback<ListPoliciesRequest, ListPoliciesResponse> callback, AsyncOptions options = null)
        {
            ListPoliciesAsync(new ListPoliciesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual void ListPoliciesAsync(ListPoliciesRequest request, AmazonServiceCallback<ListPoliciesRequest, ListPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListPoliciesRequest,ListPoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListPoliciesRequest,ListPoliciesResponse>((ListPoliciesRequest)req, (ListPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListPoliciesGrantingServiceAccess

        /// <summary>
        /// Initiates the asynchronous execution of the ListPoliciesGrantingServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesGrantingServiceAccess operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPoliciesGrantingServiceAccess">REST API Reference for ListPoliciesGrantingServiceAccess Operation</seealso>
        public virtual void ListPoliciesGrantingServiceAccessAsync(ListPoliciesGrantingServiceAccessRequest request, AmazonServiceCallback<ListPoliciesGrantingServiceAccessRequest, ListPoliciesGrantingServiceAccessResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListPoliciesGrantingServiceAccessRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListPoliciesGrantingServiceAccessResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListPoliciesGrantingServiceAccessRequest,ListPoliciesGrantingServiceAccessResponse> responseObject 
                            = new AmazonServiceResult<ListPoliciesGrantingServiceAccessRequest,ListPoliciesGrantingServiceAccessResponse>((ListPoliciesGrantingServiceAccessRequest)req, (ListPoliciesGrantingServiceAccessResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListPolicyVersions

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual void ListPolicyVersionsAsync(ListPolicyVersionsRequest request, AmazonServiceCallback<ListPolicyVersionsRequest, ListPolicyVersionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListPolicyVersionsRequest,ListPolicyVersionsResponse> responseObject 
                            = new AmazonServiceResult<ListPolicyVersionsRequest,ListPolicyVersionsResponse>((ListPolicyVersionsRequest)req, (ListPolicyVersionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListRolePolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListRolePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRolePolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRolePolicies">REST API Reference for ListRolePolicies Operation</seealso>
        public virtual void ListRolePoliciesAsync(ListRolePoliciesRequest request, AmazonServiceCallback<ListRolePoliciesRequest, ListRolePoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListRolePoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListRolePoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListRolePoliciesRequest,ListRolePoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListRolePoliciesRequest,ListRolePoliciesResponse>((ListRolePoliciesRequest)req, (ListRolePoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListRoles

        /// <summary>
        /// Lists the IAM roles that have the specified path prefix. If there are none, the operation
        /// returns an empty list. For more information about roles, go to <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/WorkingWithRoles.html">Working
        /// with Roles</a>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListRoles service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual void ListRolesAsync(AmazonServiceCallback<ListRolesRequest, ListRolesResponse> callback, AsyncOptions options = null)
        {
            ListRolesAsync(new ListRolesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoles operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoles">REST API Reference for ListRoles Operation</seealso>
        public virtual void ListRolesAsync(ListRolesRequest request, AmazonServiceCallback<ListRolesRequest, ListRolesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListRolesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListRolesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListRolesRequest,ListRolesResponse> responseObject 
                            = new AmazonServiceResult<ListRolesRequest,ListRolesResponse>((ListRolesRequest)req, (ListRolesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListRoleTags

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoleTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoleTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListRoleTags">REST API Reference for ListRoleTags Operation</seealso>
        public virtual void ListRoleTagsAsync(ListRoleTagsRequest request, AmazonServiceCallback<ListRoleTagsRequest, ListRoleTagsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListRoleTagsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListRoleTagsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListRoleTagsRequest,ListRoleTagsResponse> responseObject 
                            = new AmazonServiceResult<ListRoleTagsRequest,ListRoleTagsResponse>((ListRoleTagsRequest)req, (ListRoleTagsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListSAMLProviders

        /// <summary>
        /// Lists the SAML provider resource objects defined in IAM in the account.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListSAMLProviders service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        public virtual void ListSAMLProvidersAsync(AmazonServiceCallback<ListSAMLProvidersRequest, ListSAMLProvidersResponse> callback, AsyncOptions options = null)
        {
            ListSAMLProvidersAsync(new ListSAMLProvidersRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSAMLProviders operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSAMLProviders operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSAMLProviders">REST API Reference for ListSAMLProviders Operation</seealso>
        public virtual void ListSAMLProvidersAsync(ListSAMLProvidersRequest request, AmazonServiceCallback<ListSAMLProvidersRequest, ListSAMLProvidersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListSAMLProvidersRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListSAMLProvidersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListSAMLProvidersRequest,ListSAMLProvidersResponse> responseObject 
                            = new AmazonServiceResult<ListSAMLProvidersRequest,ListSAMLProvidersResponse>((ListSAMLProvidersRequest)req, (ListSAMLProvidersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListServerCertificates

        /// <summary>
        /// Lists the server certificates stored in IAM that have the specified path prefix. If
        /// none exist, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        ///  You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
        /// with Server Certificates</a> in the <i>IAM User Guide</i>. This topic also includes
        /// a list of AWS services that can use the server certificates that you manage with IAM.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListServerCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        public virtual void ListServerCertificatesAsync(AmazonServiceCallback<ListServerCertificatesRequest, ListServerCertificatesResponse> callback, AsyncOptions options = null)
        {
            ListServerCertificatesAsync(new ListServerCertificatesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListServerCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServerCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServerCertificates">REST API Reference for ListServerCertificates Operation</seealso>
        public virtual void ListServerCertificatesAsync(ListServerCertificatesRequest request, AmazonServiceCallback<ListServerCertificatesRequest, ListServerCertificatesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListServerCertificatesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListServerCertificatesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListServerCertificatesRequest,ListServerCertificatesResponse> responseObject 
                            = new AmazonServiceResult<ListServerCertificatesRequest,ListServerCertificatesResponse>((ListServerCertificatesRequest)req, (ListServerCertificatesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListServiceSpecificCredentials

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceSpecificCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceSpecificCredentials operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListServiceSpecificCredentials">REST API Reference for ListServiceSpecificCredentials Operation</seealso>
        public virtual void ListServiceSpecificCredentialsAsync(ListServiceSpecificCredentialsRequest request, AmazonServiceCallback<ListServiceSpecificCredentialsRequest, ListServiceSpecificCredentialsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListServiceSpecificCredentialsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListServiceSpecificCredentialsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListServiceSpecificCredentialsRequest,ListServiceSpecificCredentialsResponse> responseObject 
                            = new AmazonServiceResult<ListServiceSpecificCredentialsRequest,ListServiceSpecificCredentialsResponse>((ListServiceSpecificCredentialsRequest)req, (ListServiceSpecificCredentialsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListSigningCertificates

        /// <summary>
        /// Returns information about the signing certificates associated with the specified IAM
        /// user. If none exists, the operation returns an empty list.
        /// 
        ///  
        /// <para>
        /// Although each user is limited to a small number of signing certificates, you can still
        /// paginate the results using the <code>MaxItems</code> and <code>Marker</code> parameters.
        /// </para>
        ///  
        /// <para>
        /// If the <code>UserName</code> field is not specified, the user name is determined implicitly
        /// based on the AWS access key ID used to sign the request for this API. This operation
        /// works for access keys under the AWS account. Consequently, you can use this operation
        /// to manage AWS account root user credentials even if the AWS account has no associated
        /// users.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListSigningCertificates service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        public virtual void ListSigningCertificatesAsync(AmazonServiceCallback<ListSigningCertificatesRequest, ListSigningCertificatesResponse> callback, AsyncOptions options = null)
        {
            ListSigningCertificatesAsync(new ListSigningCertificatesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningCertificates operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSigningCertificates">REST API Reference for ListSigningCertificates Operation</seealso>
        public virtual void ListSigningCertificatesAsync(ListSigningCertificatesRequest request, AmazonServiceCallback<ListSigningCertificatesRequest, ListSigningCertificatesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListSigningCertificatesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListSigningCertificatesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListSigningCertificatesRequest,ListSigningCertificatesResponse> responseObject 
                            = new AmazonServiceResult<ListSigningCertificatesRequest,ListSigningCertificatesResponse>((ListSigningCertificatesRequest)req, (ListSigningCertificatesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListSSHPublicKeys

        /// <summary>
        /// Initiates the asynchronous execution of the ListSSHPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSSHPublicKeys operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListSSHPublicKeys">REST API Reference for ListSSHPublicKeys Operation</seealso>
        public virtual void ListSSHPublicKeysAsync(ListSSHPublicKeysRequest request, AmazonServiceCallback<ListSSHPublicKeysRequest, ListSSHPublicKeysResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListSSHPublicKeysRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListSSHPublicKeysResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListSSHPublicKeysRequest,ListSSHPublicKeysResponse> responseObject 
                            = new AmazonServiceResult<ListSSHPublicKeysRequest,ListSSHPublicKeysResponse>((ListSSHPublicKeysRequest)req, (ListSSHPublicKeysResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserPolicies

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserPolicies operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserPolicies">REST API Reference for ListUserPolicies Operation</seealso>
        public virtual void ListUserPoliciesAsync(ListUserPoliciesRequest request, AmazonServiceCallback<ListUserPoliciesRequest, ListUserPoliciesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUserPoliciesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUserPoliciesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserPoliciesRequest,ListUserPoliciesResponse> responseObject 
                            = new AmazonServiceResult<ListUserPoliciesRequest,ListUserPoliciesResponse>((ListUserPoliciesRequest)req, (ListUserPoliciesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUsers

        /// <summary>
        /// Lists the IAM users that have the specified path prefix. If no path prefix is specified,
        /// the operation returns all users in the AWS account. If there are none, the operation
        /// returns an empty list.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual void ListUsersAsync(AmazonServiceCallback<ListUsersRequest, ListUsersResponse> callback, AsyncOptions options = null)
        {
            ListUsersAsync(new ListUsersRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListUsers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUsers operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUsers">REST API Reference for ListUsers Operation</seealso>
        public virtual void ListUsersAsync(ListUsersRequest request, AmazonServiceCallback<ListUsersRequest, ListUsersResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUsersRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUsersResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUsersRequest,ListUsersResponse> responseObject 
                            = new AmazonServiceResult<ListUsersRequest,ListUsersResponse>((ListUsersRequest)req, (ListUsersResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListUserTags

        /// <summary>
        /// Initiates the asynchronous execution of the ListUserTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListUserTags operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListUserTags">REST API Reference for ListUserTags Operation</seealso>
        public virtual void ListUserTagsAsync(ListUserTagsRequest request, AmazonServiceCallback<ListUserTagsRequest, ListUserTagsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListUserTagsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListUserTagsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListUserTagsRequest,ListUserTagsResponse> responseObject 
                            = new AmazonServiceResult<ListUserTagsRequest,ListUserTagsResponse>((ListUserTagsRequest)req, (ListUserTagsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListVirtualMFADevices

        /// <summary>
        /// Lists the virtual MFA devices defined in the AWS account by assignment status. If
        /// you do not specify an assignment status, the operation returns a list of all virtual
        /// MFA devices. Assignment status can be <code>Assigned</code>, <code>Unassigned</code>,
        /// or <code>Any</code>.
        /// 
        ///  
        /// <para>
        /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
        /// parameters.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListVirtualMFADevices service method, as returned by IdentityManagementService.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        public virtual void ListVirtualMFADevicesAsync(AmazonServiceCallback<ListVirtualMFADevicesRequest, ListVirtualMFADevicesResponse> callback, AsyncOptions options = null)
        {
            ListVirtualMFADevicesAsync(new ListVirtualMFADevicesRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualMFADevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualMFADevices operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ListVirtualMFADevices">REST API Reference for ListVirtualMFADevices Operation</seealso>
        public virtual void ListVirtualMFADevicesAsync(ListVirtualMFADevicesRequest request, AmazonServiceCallback<ListVirtualMFADevicesRequest, ListVirtualMFADevicesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListVirtualMFADevicesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListVirtualMFADevicesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListVirtualMFADevicesRequest,ListVirtualMFADevicesResponse> responseObject 
                            = new AmazonServiceResult<ListVirtualMFADevicesRequest,ListVirtualMFADevicesResponse>((ListVirtualMFADevicesRequest)req, (ListVirtualMFADevicesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutGroupPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutGroupPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutGroupPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutGroupPolicy">REST API Reference for PutGroupPolicy Operation</seealso>
        public virtual void PutGroupPolicyAsync(PutGroupPolicyRequest request, AmazonServiceCallback<PutGroupPolicyRequest, PutGroupPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutGroupPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutGroupPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutGroupPolicyRequest,PutGroupPolicyResponse> responseObject 
                            = new AmazonServiceResult<PutGroupPolicyRequest,PutGroupPolicyResponse>((PutGroupPolicyRequest)req, (PutGroupPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutRolePermissionsBoundary

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePermissionsBoundary">REST API Reference for PutRolePermissionsBoundary Operation</seealso>
        public virtual void PutRolePermissionsBoundaryAsync(PutRolePermissionsBoundaryRequest request, AmazonServiceCallback<PutRolePermissionsBoundaryRequest, PutRolePermissionsBoundaryResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutRolePermissionsBoundaryRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutRolePermissionsBoundaryResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutRolePermissionsBoundaryRequest,PutRolePermissionsBoundaryResponse> responseObject 
                            = new AmazonServiceResult<PutRolePermissionsBoundaryRequest,PutRolePermissionsBoundaryResponse>((PutRolePermissionsBoundaryRequest)req, (PutRolePermissionsBoundaryResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutRolePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutRolePolicy">REST API Reference for PutRolePolicy Operation</seealso>
        public virtual void PutRolePolicyAsync(PutRolePolicyRequest request, AmazonServiceCallback<PutRolePolicyRequest, PutRolePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutRolePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutRolePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutRolePolicyRequest,PutRolePolicyResponse> responseObject 
                            = new AmazonServiceResult<PutRolePolicyRequest,PutRolePolicyResponse>((PutRolePolicyRequest)req, (PutRolePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutUserPermissionsBoundary

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPermissionsBoundary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPermissionsBoundary operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPermissionsBoundary">REST API Reference for PutUserPermissionsBoundary Operation</seealso>
        public virtual void PutUserPermissionsBoundaryAsync(PutUserPermissionsBoundaryRequest request, AmazonServiceCallback<PutUserPermissionsBoundaryRequest, PutUserPermissionsBoundaryResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutUserPermissionsBoundaryRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutUserPermissionsBoundaryResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutUserPermissionsBoundaryRequest,PutUserPermissionsBoundaryResponse> responseObject 
                            = new AmazonServiceResult<PutUserPermissionsBoundaryRequest,PutUserPermissionsBoundaryResponse>((PutUserPermissionsBoundaryRequest)req, (PutUserPermissionsBoundaryResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutUserPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutUserPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutUserPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/PutUserPolicy">REST API Reference for PutUserPolicy Operation</seealso>
        public virtual void PutUserPolicyAsync(PutUserPolicyRequest request, AmazonServiceCallback<PutUserPolicyRequest, PutUserPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutUserPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutUserPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutUserPolicyRequest,PutUserPolicyResponse> responseObject 
                            = new AmazonServiceResult<PutUserPolicyRequest,PutUserPolicyResponse>((PutUserPolicyRequest)req, (PutUserPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  RemoveClientIDFromOpenIDConnectProvider

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveClientIDFromOpenIDConnectProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveClientIDFromOpenIDConnectProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveClientIDFromOpenIDConnectProvider">REST API Reference for RemoveClientIDFromOpenIDConnectProvider Operation</seealso>
        public virtual void RemoveClientIDFromOpenIDConnectProviderAsync(RemoveClientIDFromOpenIDConnectProviderRequest request, AmazonServiceCallback<RemoveClientIDFromOpenIDConnectProviderRequest, RemoveClientIDFromOpenIDConnectProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = RemoveClientIDFromOpenIDConnectProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = RemoveClientIDFromOpenIDConnectProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RemoveClientIDFromOpenIDConnectProviderRequest,RemoveClientIDFromOpenIDConnectProviderResponse> responseObject 
                            = new AmazonServiceResult<RemoveClientIDFromOpenIDConnectProviderRequest,RemoveClientIDFromOpenIDConnectProviderResponse>((RemoveClientIDFromOpenIDConnectProviderRequest)req, (RemoveClientIDFromOpenIDConnectProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  RemoveRoleFromInstanceProfile

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveRoleFromInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveRoleFromInstanceProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveRoleFromInstanceProfile">REST API Reference for RemoveRoleFromInstanceProfile Operation</seealso>
        public virtual void RemoveRoleFromInstanceProfileAsync(RemoveRoleFromInstanceProfileRequest request, AmazonServiceCallback<RemoveRoleFromInstanceProfileRequest, RemoveRoleFromInstanceProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = RemoveRoleFromInstanceProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = RemoveRoleFromInstanceProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RemoveRoleFromInstanceProfileRequest,RemoveRoleFromInstanceProfileResponse> responseObject 
                            = new AmazonServiceResult<RemoveRoleFromInstanceProfileRequest,RemoveRoleFromInstanceProfileResponse>((RemoveRoleFromInstanceProfileRequest)req, (RemoveRoleFromInstanceProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  RemoveUserFromGroup

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveUserFromGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveUserFromGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/RemoveUserFromGroup">REST API Reference for RemoveUserFromGroup Operation</seealso>
        public virtual void RemoveUserFromGroupAsync(RemoveUserFromGroupRequest request, AmazonServiceCallback<RemoveUserFromGroupRequest, RemoveUserFromGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = RemoveUserFromGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = RemoveUserFromGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RemoveUserFromGroupRequest,RemoveUserFromGroupResponse> responseObject 
                            = new AmazonServiceResult<RemoveUserFromGroupRequest,RemoveUserFromGroupResponse>((RemoveUserFromGroupRequest)req, (RemoveUserFromGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ResetServiceSpecificCredential

        /// <summary>
        /// Initiates the asynchronous execution of the ResetServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResetServiceSpecificCredential">REST API Reference for ResetServiceSpecificCredential Operation</seealso>
        public virtual void ResetServiceSpecificCredentialAsync(ResetServiceSpecificCredentialRequest request, AmazonServiceCallback<ResetServiceSpecificCredentialRequest, ResetServiceSpecificCredentialResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ResetServiceSpecificCredentialRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ResetServiceSpecificCredentialResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ResetServiceSpecificCredentialRequest,ResetServiceSpecificCredentialResponse> responseObject 
                            = new AmazonServiceResult<ResetServiceSpecificCredentialRequest,ResetServiceSpecificCredentialResponse>((ResetServiceSpecificCredentialRequest)req, (ResetServiceSpecificCredentialResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ResyncMFADevice

        /// <summary>
        /// Initiates the asynchronous execution of the ResyncMFADevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResyncMFADevice operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/ResyncMFADevice">REST API Reference for ResyncMFADevice Operation</seealso>
        public virtual void ResyncMFADeviceAsync(ResyncMFADeviceRequest request, AmazonServiceCallback<ResyncMFADeviceRequest, ResyncMFADeviceResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ResyncMFADeviceRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ResyncMFADeviceResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ResyncMFADeviceRequest,ResyncMFADeviceResponse> responseObject 
                            = new AmazonServiceResult<ResyncMFADeviceRequest,ResyncMFADeviceResponse>((ResyncMFADeviceRequest)req, (ResyncMFADeviceResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetDefaultPolicyVersion

        /// <summary>
        /// Initiates the asynchronous execution of the SetDefaultPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultPolicyVersion operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetDefaultPolicyVersion">REST API Reference for SetDefaultPolicyVersion Operation</seealso>
        public virtual void SetDefaultPolicyVersionAsync(SetDefaultPolicyVersionRequest request, AmazonServiceCallback<SetDefaultPolicyVersionRequest, SetDefaultPolicyVersionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetDefaultPolicyVersionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetDefaultPolicyVersionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetDefaultPolicyVersionRequest,SetDefaultPolicyVersionResponse> responseObject 
                            = new AmazonServiceResult<SetDefaultPolicyVersionRequest,SetDefaultPolicyVersionResponse>((SetDefaultPolicyVersionRequest)req, (SetDefaultPolicyVersionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SetSecurityTokenServicePreferences

        /// <summary>
        /// Initiates the asynchronous execution of the SetSecurityTokenServicePreferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityTokenServicePreferences operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SetSecurityTokenServicePreferences">REST API Reference for SetSecurityTokenServicePreferences Operation</seealso>
        public virtual void SetSecurityTokenServicePreferencesAsync(SetSecurityTokenServicePreferencesRequest request, AmazonServiceCallback<SetSecurityTokenServicePreferencesRequest, SetSecurityTokenServicePreferencesResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SetSecurityTokenServicePreferencesRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SetSecurityTokenServicePreferencesResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SetSecurityTokenServicePreferencesRequest,SetSecurityTokenServicePreferencesResponse> responseObject 
                            = new AmazonServiceResult<SetSecurityTokenServicePreferencesRequest,SetSecurityTokenServicePreferencesResponse>((SetSecurityTokenServicePreferencesRequest)req, (SetSecurityTokenServicePreferencesResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SimulateCustomPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the SimulateCustomPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulateCustomPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulateCustomPolicy">REST API Reference for SimulateCustomPolicy Operation</seealso>
        public virtual void SimulateCustomPolicyAsync(SimulateCustomPolicyRequest request, AmazonServiceCallback<SimulateCustomPolicyRequest, SimulateCustomPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SimulateCustomPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SimulateCustomPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SimulateCustomPolicyRequest,SimulateCustomPolicyResponse> responseObject 
                            = new AmazonServiceResult<SimulateCustomPolicyRequest,SimulateCustomPolicyResponse>((SimulateCustomPolicyRequest)req, (SimulateCustomPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SimulatePrincipalPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the SimulatePrincipalPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SimulatePrincipalPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/SimulatePrincipalPolicy">REST API Reference for SimulatePrincipalPolicy Operation</seealso>
        public virtual void SimulatePrincipalPolicyAsync(SimulatePrincipalPolicyRequest request, AmazonServiceCallback<SimulatePrincipalPolicyRequest, SimulatePrincipalPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SimulatePrincipalPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SimulatePrincipalPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SimulatePrincipalPolicyRequest,SimulatePrincipalPolicyResponse> responseObject 
                            = new AmazonServiceResult<SimulatePrincipalPolicyRequest,SimulatePrincipalPolicyResponse>((SimulatePrincipalPolicyRequest)req, (SimulatePrincipalPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  TagRole

        /// <summary>
        /// Initiates the asynchronous execution of the TagRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagRole">REST API Reference for TagRole Operation</seealso>
        public virtual void TagRoleAsync(TagRoleRequest request, AmazonServiceCallback<TagRoleRequest, TagRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = TagRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = TagRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<TagRoleRequest,TagRoleResponse> responseObject 
                            = new AmazonServiceResult<TagRoleRequest,TagRoleResponse>((TagRoleRequest)req, (TagRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  TagUser

        /// <summary>
        /// Initiates the asynchronous execution of the TagUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/TagUser">REST API Reference for TagUser Operation</seealso>
        public virtual void TagUserAsync(TagUserRequest request, AmazonServiceCallback<TagUserRequest, TagUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = TagUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = TagUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<TagUserRequest,TagUserResponse> responseObject 
                            = new AmazonServiceResult<TagUserRequest,TagUserResponse>((TagUserRequest)req, (TagUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UntagRole

        /// <summary>
        /// Initiates the asynchronous execution of the UntagRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagRole">REST API Reference for UntagRole Operation</seealso>
        public virtual void UntagRoleAsync(UntagRoleRequest request, AmazonServiceCallback<UntagRoleRequest, UntagRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UntagRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UntagRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UntagRoleRequest,UntagRoleResponse> responseObject 
                            = new AmazonServiceResult<UntagRoleRequest,UntagRoleResponse>((UntagRoleRequest)req, (UntagRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UntagUser

        /// <summary>
        /// Initiates the asynchronous execution of the UntagUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UntagUser">REST API Reference for UntagUser Operation</seealso>
        public virtual void UntagUserAsync(UntagUserRequest request, AmazonServiceCallback<UntagUserRequest, UntagUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UntagUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UntagUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UntagUserRequest,UntagUserResponse> responseObject 
                            = new AmazonServiceResult<UntagUserRequest,UntagUserResponse>((UntagUserRequest)req, (UntagUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAccessKey

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccessKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccessKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccessKey">REST API Reference for UpdateAccessKey Operation</seealso>
        public virtual void UpdateAccessKeyAsync(UpdateAccessKeyRequest request, AmazonServiceCallback<UpdateAccessKeyRequest, UpdateAccessKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateAccessKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateAccessKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAccessKeyRequest,UpdateAccessKeyResponse> responseObject 
                            = new AmazonServiceResult<UpdateAccessKeyRequest,UpdateAccessKeyResponse>((UpdateAccessKeyRequest)req, (UpdateAccessKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAccountPasswordPolicy

        /// <summary>
        /// Updates the password policy settings for the AWS account.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This operation does not support partial updates. No parameters are required, but if
        /// you do not specify a parameter, that parameter's value reverts to its default value.
        /// See the <b>Request Parameters</b> section for each parameter's default value. Also
        /// note that some parameters do not allow the default parameter to be explicitly set.
        /// Instead, to invoke the default value, do not include that parameter when you invoke
        /// the operation.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        ///  For more information about using a password policy, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_ManagingPasswordPolicies.html">Managing
        /// an IAM Password Policy</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the UpdateAccountPasswordPolicy service method, as returned by IdentityManagementService.</returns>
        /// <exception cref="Amazon.IdentityManagement.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error message describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.MalformedPolicyDocumentException">
        /// The request was rejected because the policy document was malformed. The error message
        /// describes the specific error.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.NoSuchEntityException">
        /// The request was rejected because it referenced a resource entity that does not exist.
        /// The error message describes the resource.
        /// </exception>
        /// <exception cref="Amazon.IdentityManagement.Model.ServiceFailureException">
        /// The request processing has failed because of an unknown error, exception or failure.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        public virtual void UpdateAccountPasswordPolicyAsync(AmazonServiceCallback<UpdateAccountPasswordPolicyRequest, UpdateAccountPasswordPolicyResponse> callback, AsyncOptions options = null)
        {
            UpdateAccountPasswordPolicyAsync(new UpdateAccountPasswordPolicyRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountPasswordPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPasswordPolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAccountPasswordPolicy">REST API Reference for UpdateAccountPasswordPolicy Operation</seealso>
        public virtual void UpdateAccountPasswordPolicyAsync(UpdateAccountPasswordPolicyRequest request, AmazonServiceCallback<UpdateAccountPasswordPolicyRequest, UpdateAccountPasswordPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateAccountPasswordPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateAccountPasswordPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAccountPasswordPolicyRequest,UpdateAccountPasswordPolicyResponse> responseObject 
                            = new AmazonServiceResult<UpdateAccountPasswordPolicyRequest,UpdateAccountPasswordPolicyResponse>((UpdateAccountPasswordPolicyRequest)req, (UpdateAccountPasswordPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateAssumeRolePolicy

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAssumeRolePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAssumeRolePolicy operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateAssumeRolePolicy">REST API Reference for UpdateAssumeRolePolicy Operation</seealso>
        public virtual void UpdateAssumeRolePolicyAsync(UpdateAssumeRolePolicyRequest request, AmazonServiceCallback<UpdateAssumeRolePolicyRequest, UpdateAssumeRolePolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateAssumeRolePolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateAssumeRolePolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateAssumeRolePolicyRequest,UpdateAssumeRolePolicyResponse> responseObject 
                            = new AmazonServiceResult<UpdateAssumeRolePolicyRequest,UpdateAssumeRolePolicyResponse>((UpdateAssumeRolePolicyRequest)req, (UpdateAssumeRolePolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateGroup

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGroup operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateGroup">REST API Reference for UpdateGroup Operation</seealso>
        public virtual void UpdateGroupAsync(UpdateGroupRequest request, AmazonServiceCallback<UpdateGroupRequest, UpdateGroupResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateGroupRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateGroupResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateGroupRequest,UpdateGroupResponse> responseObject 
                            = new AmazonServiceResult<UpdateGroupRequest,UpdateGroupResponse>((UpdateGroupRequest)req, (UpdateGroupResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateLoginProfile

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLoginProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLoginProfile operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateLoginProfile">REST API Reference for UpdateLoginProfile Operation</seealso>
        public virtual void UpdateLoginProfileAsync(UpdateLoginProfileRequest request, AmazonServiceCallback<UpdateLoginProfileRequest, UpdateLoginProfileResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateLoginProfileRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateLoginProfileResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateLoginProfileRequest,UpdateLoginProfileResponse> responseObject 
                            = new AmazonServiceResult<UpdateLoginProfileRequest,UpdateLoginProfileResponse>((UpdateLoginProfileRequest)req, (UpdateLoginProfileResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateOpenIDConnectProviderThumbprint

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOpenIDConnectProviderThumbprint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOpenIDConnectProviderThumbprint operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateOpenIDConnectProviderThumbprint">REST API Reference for UpdateOpenIDConnectProviderThumbprint Operation</seealso>
        public virtual void UpdateOpenIDConnectProviderThumbprintAsync(UpdateOpenIDConnectProviderThumbprintRequest request, AmazonServiceCallback<UpdateOpenIDConnectProviderThumbprintRequest, UpdateOpenIDConnectProviderThumbprintResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateOpenIDConnectProviderThumbprintRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateOpenIDConnectProviderThumbprintResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateOpenIDConnectProviderThumbprintRequest,UpdateOpenIDConnectProviderThumbprintResponse> responseObject 
                            = new AmazonServiceResult<UpdateOpenIDConnectProviderThumbprintRequest,UpdateOpenIDConnectProviderThumbprintResponse>((UpdateOpenIDConnectProviderThumbprintRequest)req, (UpdateOpenIDConnectProviderThumbprintResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateRole

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRole operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRole operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRole">REST API Reference for UpdateRole Operation</seealso>
        public virtual void UpdateRoleAsync(UpdateRoleRequest request, AmazonServiceCallback<UpdateRoleRequest, UpdateRoleResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateRoleRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateRoleResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateRoleRequest,UpdateRoleResponse> responseObject 
                            = new AmazonServiceResult<UpdateRoleRequest,UpdateRoleResponse>((UpdateRoleRequest)req, (UpdateRoleResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateRoleDescription

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoleDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoleDescription operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateRoleDescription">REST API Reference for UpdateRoleDescription Operation</seealso>
        public virtual void UpdateRoleDescriptionAsync(UpdateRoleDescriptionRequest request, AmazonServiceCallback<UpdateRoleDescriptionRequest, UpdateRoleDescriptionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateRoleDescriptionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateRoleDescriptionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateRoleDescriptionRequest,UpdateRoleDescriptionResponse> responseObject 
                            = new AmazonServiceResult<UpdateRoleDescriptionRequest,UpdateRoleDescriptionResponse>((UpdateRoleDescriptionRequest)req, (UpdateRoleDescriptionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateSAMLProvider

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSAMLProvider operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSAMLProvider operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSAMLProvider">REST API Reference for UpdateSAMLProvider Operation</seealso>
        public virtual void UpdateSAMLProviderAsync(UpdateSAMLProviderRequest request, AmazonServiceCallback<UpdateSAMLProviderRequest, UpdateSAMLProviderResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateSAMLProviderRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateSAMLProviderResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateSAMLProviderRequest,UpdateSAMLProviderResponse> responseObject 
                            = new AmazonServiceResult<UpdateSAMLProviderRequest,UpdateSAMLProviderResponse>((UpdateSAMLProviderRequest)req, (UpdateSAMLProviderResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateServerCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServerCertificate">REST API Reference for UpdateServerCertificate Operation</seealso>
        public virtual void UpdateServerCertificateAsync(UpdateServerCertificateRequest request, AmazonServiceCallback<UpdateServerCertificateRequest, UpdateServerCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateServerCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateServerCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateServerCertificateRequest,UpdateServerCertificateResponse> responseObject 
                            = new AmazonServiceResult<UpdateServerCertificateRequest,UpdateServerCertificateResponse>((UpdateServerCertificateRequest)req, (UpdateServerCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateServiceSpecificCredential

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceSpecificCredential operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceSpecificCredential operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateServiceSpecificCredential">REST API Reference for UpdateServiceSpecificCredential Operation</seealso>
        public virtual void UpdateServiceSpecificCredentialAsync(UpdateServiceSpecificCredentialRequest request, AmazonServiceCallback<UpdateServiceSpecificCredentialRequest, UpdateServiceSpecificCredentialResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateServiceSpecificCredentialRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateServiceSpecificCredentialResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateServiceSpecificCredentialRequest,UpdateServiceSpecificCredentialResponse> responseObject 
                            = new AmazonServiceResult<UpdateServiceSpecificCredentialRequest,UpdateServiceSpecificCredentialResponse>((UpdateServiceSpecificCredentialRequest)req, (UpdateServiceSpecificCredentialResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateSigningCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSigningCertificate">REST API Reference for UpdateSigningCertificate Operation</seealso>
        public virtual void UpdateSigningCertificateAsync(UpdateSigningCertificateRequest request, AmazonServiceCallback<UpdateSigningCertificateRequest, UpdateSigningCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateSigningCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateSigningCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateSigningCertificateRequest,UpdateSigningCertificateResponse> responseObject 
                            = new AmazonServiceResult<UpdateSigningCertificateRequest,UpdateSigningCertificateResponse>((UpdateSigningCertificateRequest)req, (UpdateSigningCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateSSHPublicKey

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateSSHPublicKey">REST API Reference for UpdateSSHPublicKey Operation</seealso>
        public virtual void UpdateSSHPublicKeyAsync(UpdateSSHPublicKeyRequest request, AmazonServiceCallback<UpdateSSHPublicKeyRequest, UpdateSSHPublicKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateSSHPublicKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateSSHPublicKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateSSHPublicKeyRequest,UpdateSSHPublicKeyResponse> responseObject 
                            = new AmazonServiceResult<UpdateSSHPublicKeyRequest,UpdateSSHPublicKeyResponse>((UpdateSSHPublicKeyRequest)req, (UpdateSSHPublicKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UpdateUser

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateUser operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        public virtual void UpdateUserAsync(UpdateUserRequest request, AmazonServiceCallback<UpdateUserRequest, UpdateUserResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UpdateUserRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UpdateUserResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UpdateUserRequest,UpdateUserResponse> responseObject 
                            = new AmazonServiceResult<UpdateUserRequest,UpdateUserResponse>((UpdateUserRequest)req, (UpdateUserResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UploadServerCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the UploadServerCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadServerCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadServerCertificate">REST API Reference for UploadServerCertificate Operation</seealso>
        public virtual void UploadServerCertificateAsync(UploadServerCertificateRequest request, AmazonServiceCallback<UploadServerCertificateRequest, UploadServerCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UploadServerCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UploadServerCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UploadServerCertificateRequest,UploadServerCertificateResponse> responseObject 
                            = new AmazonServiceResult<UploadServerCertificateRequest,UploadServerCertificateResponse>((UploadServerCertificateRequest)req, (UploadServerCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UploadSigningCertificate

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSigningCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSigningCertificate operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSigningCertificate">REST API Reference for UploadSigningCertificate Operation</seealso>
        public virtual void UploadSigningCertificateAsync(UploadSigningCertificateRequest request, AmazonServiceCallback<UploadSigningCertificateRequest, UploadSigningCertificateResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UploadSigningCertificateRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UploadSigningCertificateResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UploadSigningCertificateRequest,UploadSigningCertificateResponse> responseObject 
                            = new AmazonServiceResult<UploadSigningCertificateRequest,UploadSigningCertificateResponse>((UploadSigningCertificateRequest)req, (UploadSigningCertificateResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UploadSSHPublicKey

        /// <summary>
        /// Initiates the asynchronous execution of the UploadSSHPublicKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadSSHPublicKey operation on AmazonIdentityManagementServiceClient.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/iam-2010-05-08/UploadSSHPublicKey">REST API Reference for UploadSSHPublicKey Operation</seealso>
        public virtual void UploadSSHPublicKeyAsync(UploadSSHPublicKeyRequest request, AmazonServiceCallback<UploadSSHPublicKeyRequest, UploadSSHPublicKeyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UploadSSHPublicKeyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UploadSSHPublicKeyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UploadSSHPublicKeyRequest,UploadSSHPublicKeyResponse> responseObject 
                            = new AmazonServiceResult<UploadSSHPublicKeyRequest,UploadSSHPublicKeyResponse>((UploadSSHPublicKeyRequest)req, (UploadSSHPublicKeyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
    }
}