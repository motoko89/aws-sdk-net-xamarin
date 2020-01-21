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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Transfer.Model;

namespace Amazon.Transfer
{
    /// <summary>
    /// Interface for accessing Transfer
    ///
    /// AWS Transfer for SFTP is a fully managed service that enables the transfer of files
    /// directly into and out of Amazon S3 using the Secure File Transfer Protocol (SFTP)—also
    /// known as Secure Shell (SSH) File Transfer Protocol. AWS helps you seamlessly migrate
    /// your file transfer workflows to AWS Transfer for SFTP—by integrating with existing
    /// authentication systems, and providing DNS routing with Amazon Route 53—so nothing
    /// changes for your customers and partners, or their applications. With your data in
    /// S3, you can use it with AWS services for processing, analytics, machine learning,
    /// and archiving. Getting started with AWS Transfer for SFTP (AWS SFTP) is easy; there
    /// is no infrastructure to buy and set up.
    /// </summary>
    public partial interface IAmazonTransfer : IAmazonService, IDisposable
    {
                
        #region  CreateServer



        /// <summary>
        /// Instantiates an autoscaling virtual server based on Secure File Transfer Protocol
        /// (SFTP) in AWS. When you make updates to your server or when you work with users, use
        /// the service-generated <code>ServerId</code> property that is assigned to the newly
        /// created server.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateServer">REST API Reference for CreateServer Operation</seealso>
        Task<CreateServerResponse> CreateServerAsync(CreateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateUser



        /// <summary>
        /// Creates a user and associates them with an existing Secure File Transfer Protocol
        /// (SFTP) server. You can only create and associate users with SFTP servers that have
        /// the <code>IdentityProviderType</code> set to <code>SERVICE_MANAGED</code>. Using parameters
        /// for <code>CreateUser</code>, you can specify the user name, set the home directory,
        /// store the user's public key, and assign the user's AWS Identity and Access Management
        /// (IAM) role. You can also optionally add a scope-down policy, and assign metadata with
        /// tags that can be used to group and search for users.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/CreateUser">REST API Reference for CreateUser Operation</seealso>
        Task<CreateUserResponse> CreateUserAsync(CreateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteServer



        /// <summary>
        /// Deletes the Secure File Transfer Protocol (SFTP) server that you specify.
        /// 
        ///  
        /// <para>
        /// No response returns from this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteServer">REST API Reference for DeleteServer Operation</seealso>
        Task<DeleteServerResponse> DeleteServerAsync(DeleteServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSshPublicKey



        /// <summary>
        /// Deletes a user's Secure Shell (SSH) public key.
        /// 
        ///  
        /// <para>
        /// No response is returned from this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSshPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        ///  HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteSshPublicKey">REST API Reference for DeleteSshPublicKey Operation</seealso>
        Task<DeleteSshPublicKeyResponse> DeleteSshPublicKeyAsync(DeleteSshPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteUser



        /// <summary>
        /// Deletes the user belonging to the server you specify.
        /// 
        ///  
        /// <para>
        /// No response returns from this operation.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you delete a user from a server, the user's information is lost.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DeleteUser">REST API Reference for DeleteUser Operation</seealso>
        Task<DeleteUserResponse> DeleteUserAsync(DeleteUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeServer



        /// <summary>
        /// Describes the server that you specify by passing the <code>ServerId</code> parameter.
        /// 
        ///  
        /// <para>
        /// The response contains a description of the server's properties. When you set <code>EndpointType</code>
        /// to VPC, the response will contain the <code>EndpointDetails</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeServer">REST API Reference for DescribeServer Operation</seealso>
        Task<DescribeServerResponse> DescribeServerAsync(DescribeServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeUser



        /// <summary>
        /// Describes the user assigned to a specific server, as identified by its <code>ServerId</code>
        /// property.
        /// 
        ///  
        /// <para>
        /// The response from this call returns the properties of the user associated with the
        /// <code>ServerId</code> value that was specified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/DescribeUser">REST API Reference for DescribeUser Operation</seealso>
        Task<DescribeUserResponse> DescribeUserAsync(DescribeUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ImportSshPublicKey



        /// <summary>
        /// Adds a Secure Shell (SSH) public key to a user account identified by a <code>UserName</code>
        /// value assigned to a specific server, identified by <code>ServerId</code>.
        /// 
        ///  
        /// <para>
        /// The response returns the <code>UserName</code> value, the <code>ServerId</code> value,
        /// and the name of the <code>SshPublicKeyId</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSshPublicKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportSshPublicKey service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        ///  HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ImportSshPublicKey">REST API Reference for ImportSshPublicKey Operation</seealso>
        Task<ImportSshPublicKeyResponse> ImportSshPublicKeyAsync(ImportSshPublicKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListServers



        /// <summary>
        /// Lists the Secure File Transfer Protocol (SFTP) servers that are associated with your
        /// AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListServers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListServers">REST API Reference for ListServers Operation</seealso>
        Task<ListServersResponse> ListServersAsync(ListServersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Number (ARN) you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListUsers



        /// <summary>
        /// Lists the users for the server that you specify by passing the <code>ServerId</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListUsers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListUsers service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidNextTokenException">
        /// The <code>NextToken</code> parameter that was passed is invalid.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/ListUsers">REST API Reference for ListUsers Operation</seealso>
        Task<ListUsersResponse> ListUsersAsync(ListUsersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartServer



        /// <summary>
        /// Changes the state of a Secure File Transfer Protocol (SFTP) server from <code>OFFLINE</code>
        /// to <code>ONLINE</code>. It has no impact on an SFTP server that is already <code>ONLINE</code>.
        /// An <code>ONLINE</code> server can accept and process file transfer jobs.
        /// 
        ///  
        /// <para>
        /// The state of <code>STARTING</code> indicates that the server is in an intermediate
        /// state, either not fully able to respond, or not fully online. The values of <code>START_FAILED</code>
        /// can indicate an error condition. 
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        ///  HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StartServer">REST API Reference for StartServer Operation</seealso>
        Task<StartServerResponse> StartServerAsync(StartServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopServer



        /// <summary>
        /// Changes the state of an SFTP server from <code>ONLINE</code> to <code>OFFLINE</code>.
        /// An <code>OFFLINE</code> server cannot accept and process file transfer jobs. Information
        /// tied to your server such as server and user properties are not affected by stopping
        /// your server. Stopping a server will not reduce or impact your Secure File Transfer
        /// Protocol (SFTP) endpoint billing.
        /// 
        ///  
        /// <para>
        /// The state of <code>STOPPING</code> indicates that the server is in an intermediate
        /// state, either not fully able to respond, or not fully offline. The values of <code>STOP_FAILED</code>
        /// can indicate an error condition.
        /// </para>
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        ///  HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/StopServer">REST API Reference for StopServer Operation</seealso>
        Task<StopServerResponse> StopServerAsync(StopServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// 
        ///  
        /// <para>
        /// There is no response returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TestIdentityProvider



        /// <summary>
        /// If the <code>IdentityProviderType</code> of the server is <code>API_Gateway</code>,
        /// tests whether your API Gateway is set up successfully. We highly recommend that you
        /// call this operation to test your authentication method as soon as you create your
        /// server. By doing so, you can troubleshoot issues with the API Gateway integration
        /// to ensure that your users can successfully use the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestIdentityProvider service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestIdentityProvider service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/TestIdentityProvider">REST API Reference for TestIdentityProvider Operation</seealso>
        Task<TestIdentityProviderResponse> TestIdentityProviderAsync(TestIdentityProviderRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// 
        ///  
        /// <para>
        /// No response is returned from this call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateServer



        /// <summary>
        /// Updates the server properties after that server has been created.
        /// 
        ///  
        /// <para>
        /// The <code>UpdateServer</code> call returns the <code>ServerId</code> of the Secure
        /// File Transfer Protocol (SFTP) server you updated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateServer service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.ConflictException">
        /// This exception is thrown when the <code>UpdatServer</code> is called for a server
        /// that has VPC as the endpoint type and the server's <code>VpcEndpointID</code> is not
        /// in the available state.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceExistsException">
        /// The requested resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        ///  HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateServer">REST API Reference for UpdateServer Operation</seealso>
        Task<UpdateServerResponse> UpdateServerAsync(UpdateServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateUser



        /// <summary>
        /// Assigns new properties to a user. Parameters you pass modify any or all of the following:
        /// the home directory, role, and policy for the <code>UserName</code> and <code>ServerId</code>
        /// you specify.
        /// 
        ///  
        /// <para>
        /// The response returns the <code>ServerId</code> and the <code>UserName</code> for the
        /// updated user.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateUser service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateUser service method, as returned by Transfer.</returns>
        /// <exception cref="Amazon.Transfer.Model.InternalServiceErrorException">
        /// This exception is thrown when an error occurs in the AWS Transfer for SFTP service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.InvalidRequestException">
        /// This exception is thrown when the client submits a malformed request.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ResourceNotFoundException">
        /// This exception is thrown when a resource is not found by the AWS Transfer for SFTP
        /// service.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ServiceUnavailableException">
        /// The request has failed because the AWS Transfer for SFTP service is not available.
        /// </exception>
        /// <exception cref="Amazon.Transfer.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// 
        ///  
        /// <para>
        ///  HTTP Status Code: 400
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/transfer-2018-11-05/UpdateUser">REST API Reference for UpdateUser Operation</seealso>
        Task<UpdateUserResponse> UpdateUserAsync(UpdateUserRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}