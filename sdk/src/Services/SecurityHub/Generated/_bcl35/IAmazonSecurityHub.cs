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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SecurityHub.Model;

namespace Amazon.SecurityHub
{
    /// <summary>
    /// Interface for accessing SecurityHub
    ///
    /// Security Hub provides you with a comprehensive view of the security state of your
    /// AWS environment and resources. It also provides you with the compliance status of
    /// your environment based on controls from supported standards. Security Hub collects
    /// security data from AWS accounts, services, and integrated third-party products and
    /// helps you analyze security trends in your environment to identify the highest priority
    /// security issues. For more information about Security Hub, see the <i> <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/what-is-securityhub.html">AWS
    /// Security Hub User Guide</a> </i>.
    /// 
    ///  
    /// <para>
    /// When you use operations in the Security Hub API, the requests are executed only in
    /// the AWS Region that is currently active or in the specific AWS Region that you specify
    /// in your request. Any configuration or settings change that results from the operation
    /// is applied only to that Region. To make the same change in other Regions, execute
    /// the same command for each Region to apply the change to.
    /// </para>
    ///  
    /// <para>
    /// For example, if your Region is set to <code>us-west-2</code>, when you use <code>
    /// <a>CreateMembers</a> </code> to add a member account to Security Hub, the association
    /// of the member account with the master account is created only in the <code>us-west-2</code>
    /// Region. Security Hub must be enabled for the member account in the same Region that
    /// the invitation was sent from.
    /// </para>
    ///  
    /// <para>
    /// The following throttling limits apply to using Security Hub API operations.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code> <a>GetFindings</a> </code> - <code>RateLimit</code> of 3 requests per second.
    /// <code>BurstLimit</code> of 6 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code> <a>UpdateFindings</a> </code> - <code>RateLimit</code> of 1 request per second.
    /// <code>BurstLimit</code> of 5 requests per second.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All other operations - <code>RateLimit</code> of 10 requests per second. <code>BurstLimit</code>
    /// of 30 requests per second.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonSecurityHub : IAmazonService, IDisposable
    {

        
        #region  AcceptInvitation


        /// <summary>
        /// Accepts the invitation to be a member account and be monitored by the Security Hub
        /// master account that the invitation was sent from.
        /// 
        ///  
        /// <para>
        /// When the member account accepts the invitation, permission is granted to the master
        /// account to view findings generated in the member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation service method.</param>
        /// 
        /// <returns>The response from the AcceptInvitation service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        AcceptInvitationResponse AcceptInvitation(AcceptInvitationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptInvitation operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptInvitation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        IAsyncResult BeginAcceptInvitation(AcceptInvitationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptInvitation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptInvitation.</param>
        /// 
        /// <returns>Returns a  AcceptInvitationResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/AcceptInvitation">REST API Reference for AcceptInvitation Operation</seealso>
        AcceptInvitationResponse EndAcceptInvitation(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisableStandards


        /// <summary>
        /// Disables the standards specified by the provided <code>StandardsSubscriptionArns</code>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Compliance
        /// Standards</a> section of the <i>AWS Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards service method.</param>
        /// 
        /// <returns>The response from the BatchDisableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        BatchDisableStandardsResponse BatchDisableStandards(BatchDisableStandardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisableStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisableStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisableStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        IAsyncResult BeginBatchDisableStandards(BatchDisableStandardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisableStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisableStandards.</param>
        /// 
        /// <returns>Returns a  BatchDisableStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchDisableStandards">REST API Reference for BatchDisableStandards Operation</seealso>
        BatchDisableStandardsResponse EndBatchDisableStandards(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchEnableStandards


        /// <summary>
        /// Enables the standards specified by the provided <code>StandardsArn</code>. To obtain
        /// the ARN for a standard, use the <code> <a>DescribeStandards</a> </code> operation.
        /// 
        ///  
        /// <para>
        /// For more information, see the <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-standards.html">Compliance
        /// Standards</a> section of the <i>AWS Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards service method.</param>
        /// 
        /// <returns>The response from the BatchEnableStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        BatchEnableStandardsResponse BatchEnableStandards(BatchEnableStandardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchEnableStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchEnableStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchEnableStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        IAsyncResult BeginBatchEnableStandards(BatchEnableStandardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchEnableStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchEnableStandards.</param>
        /// 
        /// <returns>Returns a  BatchEnableStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchEnableStandards">REST API Reference for BatchEnableStandards Operation</seealso>
        BatchEnableStandardsResponse EndBatchEnableStandards(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchImportFindings


        /// <summary>
        /// Imports security findings generated from an integrated third-party product into Security
        /// Hub. This action is requested by the integrated product to import its findings into
        /// Security Hub.
        /// 
        ///  
        /// <para>
        /// The maximum allowed size for a finding is 240 Kb. An error is returned for any finding
        /// larger than 240 Kb.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings service method.</param>
        /// 
        /// <returns>The response from the BatchImportFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        BatchImportFindingsResponse BatchImportFindings(BatchImportFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchImportFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchImportFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchImportFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        IAsyncResult BeginBatchImportFindings(BatchImportFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchImportFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchImportFindings.</param>
        /// 
        /// <returns>Returns a  BatchImportFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/BatchImportFindings">REST API Reference for BatchImportFindings Operation</seealso>
        BatchImportFindingsResponse EndBatchImportFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateActionTarget


        /// <summary>
        /// Creates a custom action target in Security Hub.
        /// 
        ///  
        /// <para>
        /// You can use custom actions on findings and insights in Security Hub to trigger target
        /// actions in Amazon CloudWatch Events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActionTarget service method.</param>
        /// 
        /// <returns>The response from the CreateActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        CreateActionTargetResponse CreateActionTarget(CreateActionTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActionTarget operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        IAsyncResult BeginCreateActionTarget(CreateActionTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActionTarget.</param>
        /// 
        /// <returns>Returns a  CreateActionTargetResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateActionTarget">REST API Reference for CreateActionTarget Operation</seealso>
        CreateActionTargetResponse EndCreateActionTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInsight


        /// <summary>
        /// Creates a custom insight in Security Hub. An insight is a consolidation of findings
        /// that relate to a security issue that requires attention or remediation.
        /// 
        ///  
        /// <para>
        /// To group the related findings in the insight, use the <code>GroupByAttribute</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight service method.</param>
        /// 
        /// <returns>The response from the CreateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        CreateInsightResponse CreateInsight(CreateInsightRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInsight operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        IAsyncResult BeginCreateInsight(CreateInsightRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInsight.</param>
        /// 
        /// <returns>Returns a  CreateInsightResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateInsight">REST API Reference for CreateInsight Operation</seealso>
        CreateInsightResponse EndCreateInsight(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateMembers


        /// <summary>
        /// Creates a member association in Security Hub between the specified accounts and the
        /// account used to make the request, which is the master account. To successfully create
        /// a member, you must use this action from an account that already has Security Hub enabled.
        /// To enable Security Hub, you can use the <code> <a>EnableSecurityHub</a> </code> operation.
        /// 
        ///  
        /// <para>
        /// After you use <code>CreateMembers</code> to create member account associations in
        /// Security Hub, you must use the <code> <a>InviteMembers</a> </code> operation to invite
        /// the accounts to enable Security Hub and become member accounts in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// If the account owner accepts the invitation, the account becomes a member account
        /// in Security Hub, and a permission policy is added that permits the master account
        /// to view the findings generated in the member account. When Security Hub is enabled
        /// in the invited account, findings start to be sent to both the member and master accounts.
        /// </para>
        ///  
        /// <para>
        /// To remove the association between the master and member accounts, use the <code> <a>DisassociateFromMasterAccount</a>
        /// </code> or <code> <a>DisassociateMembers</a> </code> operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers service method.</param>
        /// 
        /// <returns>The response from the CreateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        CreateMembersResponse CreateMembers(CreateMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        IAsyncResult BeginCreateMembers(CreateMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateMembers.</param>
        /// 
        /// <returns>Returns a  CreateMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/CreateMembers">REST API Reference for CreateMembers Operation</seealso>
        CreateMembersResponse EndCreateMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  DeclineInvitations


        /// <summary>
        /// Declines invitations to become a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations service method.</param>
        /// 
        /// <returns>The response from the DeclineInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse DeclineInvitations(DeclineInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineInvitations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeclineInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        IAsyncResult BeginDeclineInvitations(DeclineInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeclineInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeclineInvitations.</param>
        /// 
        /// <returns>Returns a  DeclineInvitationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeclineInvitations">REST API Reference for DeclineInvitations Operation</seealso>
        DeclineInvitationsResponse EndDeclineInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteActionTarget


        /// <summary>
        /// Deletes a custom action target from Security Hub.
        /// 
        ///  
        /// <para>
        /// Deleting a custom action target does not affect any findings or insights that were
        /// already sent to Amazon CloudWatch Events using the custom action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionTarget service method.</param>
        /// 
        /// <returns>The response from the DeleteActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        DeleteActionTargetResponse DeleteActionTarget(DeleteActionTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteActionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActionTarget operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        IAsyncResult BeginDeleteActionTarget(DeleteActionTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActionTarget.</param>
        /// 
        /// <returns>Returns a  DeleteActionTargetResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteActionTarget">REST API Reference for DeleteActionTarget Operation</seealso>
        DeleteActionTargetResponse EndDeleteActionTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInsight


        /// <summary>
        /// Deletes the insight specified by the <code>InsightArn</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight service method.</param>
        /// 
        /// <returns>The response from the DeleteInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        DeleteInsightResponse DeleteInsight(DeleteInsightRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInsight operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        IAsyncResult BeginDeleteInsight(DeleteInsightRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInsight.</param>
        /// 
        /// <returns>Returns a  DeleteInsightResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInsight">REST API Reference for DeleteInsight Operation</seealso>
        DeleteInsightResponse EndDeleteInsight(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInvitations


        /// <summary>
        /// Deletes invitations received by the AWS account to become a member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations service method.</param>
        /// 
        /// <returns>The response from the DeleteInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse DeleteInvitations(DeleteInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInvitations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        IAsyncResult BeginDeleteInvitations(DeleteInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInvitations.</param>
        /// 
        /// <returns>Returns a  DeleteInvitationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteInvitations">REST API Reference for DeleteInvitations Operation</seealso>
        DeleteInvitationsResponse EndDeleteInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteMembers


        /// <summary>
        /// Deletes the specified member accounts from Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers service method.</param>
        /// 
        /// <returns>The response from the DeleteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        DeleteMembersResponse DeleteMembers(DeleteMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        IAsyncResult BeginDeleteMembers(DeleteMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMembers.</param>
        /// 
        /// <returns>Returns a  DeleteMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DeleteMembers">REST API Reference for DeleteMembers Operation</seealso>
        DeleteMembersResponse EndDeleteMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeActionTargets


        /// <summary>
        /// Returns a list of the custom action targets in Security Hub in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionTargets service method.</param>
        /// 
        /// <returns>The response from the DescribeActionTargets service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        DescribeActionTargetsResponse DescribeActionTargets(DescribeActionTargetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActionTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActionTargets operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActionTargets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        IAsyncResult BeginDescribeActionTargets(DescribeActionTargetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActionTargets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActionTargets.</param>
        /// 
        /// <returns>Returns a  DescribeActionTargetsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeActionTargets">REST API Reference for DescribeActionTargets Operation</seealso>
        DescribeActionTargetsResponse EndDescribeActionTargets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHub


        /// <summary>
        /// Returns details about the Hub resource in your account, including the <code>HubArn</code>
        /// and the time when you enabled Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub service method.</param>
        /// 
        /// <returns>The response from the DescribeHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        DescribeHubResponse DescribeHub(DescribeHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHub operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        IAsyncResult BeginDescribeHub(DescribeHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHub.</param>
        /// 
        /// <returns>Returns a  DescribeHubResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeHub">REST API Reference for DescribeHub Operation</seealso>
        DescribeHubResponse EndDescribeHub(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeProducts


        /// <summary>
        /// Returns information about the available products that you can subscribe to and integrate
        /// with Security Hub in order to consolidate findings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProducts service method.</param>
        /// 
        /// <returns>The response from the DescribeProducts service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        DescribeProductsResponse DescribeProducts(DescribeProductsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeProducts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeProducts operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeProducts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        IAsyncResult BeginDescribeProducts(DescribeProductsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeProducts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeProducts.</param>
        /// 
        /// <returns>Returns a  DescribeProductsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeProducts">REST API Reference for DescribeProducts Operation</seealso>
        DescribeProductsResponse EndDescribeProducts(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStandards


        /// <summary>
        /// Returns a list of the available standards in Security Hub.
        /// 
        ///  
        /// <para>
        /// For each standard, the results include the standard ARN, the name, and a description.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandards service method.</param>
        /// 
        /// <returns>The response from the DescribeStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        DescribeStandardsResponse DescribeStandards(DescribeStandardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        IAsyncResult BeginDescribeStandards(DescribeStandardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStandards.</param>
        /// 
        /// <returns>Returns a  DescribeStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandards">REST API Reference for DescribeStandards Operation</seealso>
        DescribeStandardsResponse EndDescribeStandards(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStandardsControls


        /// <summary>
        /// Returns a list of compliance standards controls.
        /// 
        ///  
        /// <para>
        /// For each control, the results include information about whether it is currently enabled,
        /// the severity, and a link to remediation information.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandardsControls service method.</param>
        /// 
        /// <returns>The response from the DescribeStandardsControls service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        DescribeStandardsControlsResponse DescribeStandardsControls(DescribeStandardsControlsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStandardsControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStandardsControls operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStandardsControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        IAsyncResult BeginDescribeStandardsControls(DescribeStandardsControlsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStandardsControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStandardsControls.</param>
        /// 
        /// <returns>Returns a  DescribeStandardsControlsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DescribeStandardsControls">REST API Reference for DescribeStandardsControls Operation</seealso>
        DescribeStandardsControlsResponse EndDescribeStandardsControls(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableImportFindingsForProduct


        /// <summary>
        /// Disables the integration of the specified product with Security Hub. After the integration
        /// is disabled, findings from that product are no longer sent to Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct service method.</param>
        /// 
        /// <returns>The response from the DisableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        DisableImportFindingsForProductResponse DisableImportFindingsForProduct(DisableImportFindingsForProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableImportFindingsForProduct operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableImportFindingsForProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        IAsyncResult BeginDisableImportFindingsForProduct(DisableImportFindingsForProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableImportFindingsForProduct.</param>
        /// 
        /// <returns>Returns a  DisableImportFindingsForProductResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableImportFindingsForProduct">REST API Reference for DisableImportFindingsForProduct Operation</seealso>
        DisableImportFindingsForProductResponse EndDisableImportFindingsForProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableSecurityHub


        /// <summary>
        /// Disables Security Hub in your account only in the current Region. To disable Security
        /// Hub in all Regions, you must submit one request per Region where you have enabled
        /// Security Hub.
        /// 
        ///  
        /// <para>
        /// When you disable Security Hub for a master account, it doesn't disable Security Hub
        /// for any associated member accounts.
        /// </para>
        ///  
        /// <para>
        /// When you disable Security Hub, your existing findings and insights and any Security
        /// Hub configuration settings are deleted after 90 days and cannot be recovered. Any
        /// standards that were enabled are disabled, and your master and member account associations
        /// are removed.
        /// </para>
        ///  
        /// <para>
        /// If you want to save your existing findings, you must export them before you disable
        /// Security Hub.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub service method.</param>
        /// 
        /// <returns>The response from the DisableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        DisableSecurityHubResponse DisableSecurityHub(DisableSecurityHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableSecurityHub operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableSecurityHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        IAsyncResult BeginDisableSecurityHub(DisableSecurityHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableSecurityHub.</param>
        /// 
        /// <returns>Returns a  DisableSecurityHubResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisableSecurityHub">REST API Reference for DisableSecurityHub Operation</seealso>
        DisableSecurityHubResponse EndDisableSecurityHub(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateFromMasterAccount


        /// <summary>
        /// Disassociates the current Security Hub member account from the associated master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        DisassociateFromMasterAccountResponse DisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromMasterAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateFromMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        IAsyncResult BeginDisassociateFromMasterAccount(DisassociateFromMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateFromMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateFromMasterAccount.</param>
        /// 
        /// <returns>Returns a  DisassociateFromMasterAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateFromMasterAccount">REST API Reference for DisassociateFromMasterAccount Operation</seealso>
        DisassociateFromMasterAccountResponse EndDisassociateFromMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateMembers


        /// <summary>
        /// Disassociates the specified member accounts from the associated master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers service method.</param>
        /// 
        /// <returns>The response from the DisassociateMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        DisassociateMembersResponse DisassociateMembers(DisassociateMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        IAsyncResult BeginDisassociateMembers(DisassociateMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateMembers.</param>
        /// 
        /// <returns>Returns a  DisassociateMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/DisassociateMembers">REST API Reference for DisassociateMembers Operation</seealso>
        DisassociateMembersResponse EndDisassociateMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableImportFindingsForProduct


        /// <summary>
        /// Enables the integration of a partner product with Security Hub. Integrated products
        /// send findings to Security Hub.
        /// 
        ///  
        /// <para>
        /// When you enable a product integration, a permission policy that grants permission
        /// for the product to send findings to Security Hub is applied.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct service method.</param>
        /// 
        /// <returns>The response from the EnableImportFindingsForProduct service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        EnableImportFindingsForProductResponse EnableImportFindingsForProduct(EnableImportFindingsForProductRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableImportFindingsForProduct operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableImportFindingsForProduct
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        IAsyncResult BeginEnableImportFindingsForProduct(EnableImportFindingsForProductRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableImportFindingsForProduct operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableImportFindingsForProduct.</param>
        /// 
        /// <returns>Returns a  EnableImportFindingsForProductResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableImportFindingsForProduct">REST API Reference for EnableImportFindingsForProduct Operation</seealso>
        EnableImportFindingsForProductResponse EndEnableImportFindingsForProduct(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableSecurityHub


        /// <summary>
        /// Enables Security Hub for your account in the current Region or the Region you specify
        /// in the request.
        /// 
        ///  
        /// <para>
        /// When you enable Security Hub, you grant to Security Hub the permissions necessary
        /// to gather findings from AWS Config, Amazon GuardDuty, Amazon Inspector, and Amazon
        /// Macie.
        /// </para>
        ///  
        /// <para>
        /// When you use the <code>EnableSecurityHub</code> operation to enable Security Hub,
        /// you also automatically enable the CIS AWS Foundations standard. You do not enable
        /// the Payment Card Industry Data Security Standard (PCI DSS) standard. To enable a standard,
        /// use the <code> <a>BatchEnableStandards</a> </code> operation. To disable a standard,
        /// use the <code> <a>BatchDisableStandards</a> </code> operation.
        /// </para>
        ///  
        /// <para>
        /// To learn more, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-settingup.html">Setting
        /// Up AWS Security Hub</a> in the <i>AWS Security Hub User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub service method.</param>
        /// 
        /// <returns>The response from the EnableSecurityHub service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.AccessDeniedException">
        /// You don't have permission to perform the action specified in the request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceConflictException">
        /// The resource specified in the request conflicts with an existing resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        EnableSecurityHubResponse EnableSecurityHub(EnableSecurityHubRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableSecurityHub operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableSecurityHub
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        IAsyncResult BeginEnableSecurityHub(EnableSecurityHubRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableSecurityHub operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableSecurityHub.</param>
        /// 
        /// <returns>Returns a  EnableSecurityHubResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/EnableSecurityHub">REST API Reference for EnableSecurityHub Operation</seealso>
        EnableSecurityHubResponse EndEnableSecurityHub(IAsyncResult asyncResult);

        #endregion
        
        #region  GetEnabledStandards


        /// <summary>
        /// Returns a list of the standards that are currently enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards service method.</param>
        /// 
        /// <returns>The response from the GetEnabledStandards service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        GetEnabledStandardsResponse GetEnabledStandards(GetEnabledStandardsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnabledStandards operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnabledStandards operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnabledStandards
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        IAsyncResult BeginGetEnabledStandards(GetEnabledStandardsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnabledStandards operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnabledStandards.</param>
        /// 
        /// <returns>Returns a  GetEnabledStandardsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetEnabledStandards">REST API Reference for GetEnabledStandards Operation</seealso>
        GetEnabledStandardsResponse EndGetEnabledStandards(IAsyncResult asyncResult);

        #endregion
        
        #region  GetFindings


        /// <summary>
        /// Returns a list of findings that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFindings service method.</param>
        /// 
        /// <returns>The response from the GetFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse GetFindings(GetFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        IAsyncResult BeginGetFindings(GetFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFindings.</param>
        /// 
        /// <returns>Returns a  GetFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetFindings">REST API Reference for GetFindings Operation</seealso>
        GetFindingsResponse EndGetFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInsightResults


        /// <summary>
        /// Lists the results of the Security Hub insight specified by the insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsightResults service method.</param>
        /// 
        /// <returns>The response from the GetInsightResults service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        GetInsightResultsResponse GetInsightResults(GetInsightResultsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsightResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsightResults operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsightResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        IAsyncResult BeginGetInsightResults(GetInsightResultsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsightResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsightResults.</param>
        /// 
        /// <returns>Returns a  GetInsightResultsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsightResults">REST API Reference for GetInsightResults Operation</seealso>
        GetInsightResultsResponse EndGetInsightResults(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInsights


        /// <summary>
        /// Lists and describes insights for the specified insight ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInsights service method.</param>
        /// 
        /// <returns>The response from the GetInsights service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        GetInsightsResponse GetInsights(GetInsightsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInsights operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInsights operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInsights
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        IAsyncResult BeginGetInsights(GetInsightsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInsights operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInsights.</param>
        /// 
        /// <returns>Returns a  GetInsightsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInsights">REST API Reference for GetInsights Operation</seealso>
        GetInsightsResponse EndGetInsights(IAsyncResult asyncResult);

        #endregion
        
        #region  GetInvitationsCount


        /// <summary>
        /// Returns the count of all Security Hub membership invitations that were sent to the
        /// current member account, not including the currently accepted invitation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount service method.</param>
        /// 
        /// <returns>The response from the GetInvitationsCount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse GetInvitationsCount(GetInvitationsCountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInvitationsCount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetInvitationsCount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        IAsyncResult BeginGetInvitationsCount(GetInvitationsCountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetInvitationsCount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetInvitationsCount.</param>
        /// 
        /// <returns>Returns a  GetInvitationsCountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetInvitationsCount">REST API Reference for GetInvitationsCount Operation</seealso>
        GetInvitationsCountResponse EndGetInvitationsCount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMasterAccount


        /// <summary>
        /// Provides the details for the Security Hub master account for the current member account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount service method.</param>
        /// 
        /// <returns>The response from the GetMasterAccount service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        GetMasterAccountResponse GetMasterAccount(GetMasterAccountRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMasterAccount operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMasterAccount
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        IAsyncResult BeginGetMasterAccount(GetMasterAccountRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMasterAccount operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMasterAccount.</param>
        /// 
        /// <returns>Returns a  GetMasterAccountResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMasterAccount">REST API Reference for GetMasterAccount Operation</seealso>
        GetMasterAccountResponse EndGetMasterAccount(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMembers


        /// <summary>
        /// Returns the details for the Security Hub member accounts for the specified account
        /// IDs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMembers service method.</param>
        /// 
        /// <returns>The response from the GetMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        GetMembersResponse GetMembers(GetMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        IAsyncResult BeginGetMembers(GetMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMembers.</param>
        /// 
        /// <returns>Returns a  GetMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/GetMembers">REST API Reference for GetMembers Operation</seealso>
        GetMembersResponse EndGetMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  InviteMembers


        /// <summary>
        /// Invites other AWS accounts to become member accounts for the Security Hub master account
        /// that the invitation is sent from.
        /// 
        ///  
        /// <para>
        /// Before you can use this action to invite a member, you must first use the <code> <a>CreateMembers</a>
        /// </code> action to create the member account in Security Hub.
        /// </para>
        ///  
        /// <para>
        /// When the account owner accepts the invitation to become a member account and enables
        /// Security Hub, the master account can view the findings generated from the member account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers service method.</param>
        /// 
        /// <returns>The response from the InviteMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        InviteMembersResponse InviteMembers(InviteMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndInviteMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        IAsyncResult BeginInviteMembers(InviteMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  InviteMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInviteMembers.</param>
        /// 
        /// <returns>Returns a  InviteMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/InviteMembers">REST API Reference for InviteMembers Operation</seealso>
        InviteMembersResponse EndInviteMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEnabledProductsForImport


        /// <summary>
        /// Lists all findings-generating solutions (products) that you are subscribed to receive
        /// findings from in Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport service method.</param>
        /// 
        /// <returns>The response from the ListEnabledProductsForImport service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        ListEnabledProductsForImportResponse ListEnabledProductsForImport(ListEnabledProductsForImportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnabledProductsForImport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnabledProductsForImport operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnabledProductsForImport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        IAsyncResult BeginListEnabledProductsForImport(ListEnabledProductsForImportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnabledProductsForImport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnabledProductsForImport.</param>
        /// 
        /// <returns>Returns a  ListEnabledProductsForImportResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListEnabledProductsForImport">REST API Reference for ListEnabledProductsForImport Operation</seealso>
        ListEnabledProductsForImportResponse EndListEnabledProductsForImport(IAsyncResult asyncResult);

        #endregion
        
        #region  ListInvitations


        /// <summary>
        /// Lists all Security Hub membership invitations that were sent to the current AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations service method.</param>
        /// 
        /// <returns>The response from the ListInvitations service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse ListInvitations(ListInvitationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListInvitations operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListInvitations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        IAsyncResult BeginListInvitations(ListInvitationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListInvitations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListInvitations.</param>
        /// 
        /// <returns>Returns a  ListInvitationsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListInvitations">REST API Reference for ListInvitations Operation</seealso>
        ListInvitationsResponse EndListInvitations(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMembers


        /// <summary>
        /// Lists details about all member accounts for the current Security Hub master account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMembers service method.</param>
        /// 
        /// <returns>The response from the ListMembers service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse ListMembers(ListMembersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMembers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMembers operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMembers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        IAsyncResult BeginListMembers(ListMembersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMembers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMembers.</param>
        /// 
        /// <returns>Returns a  ListMembersResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListMembers">REST API Reference for ListMembers Operation</seealso>
        ListMembersResponse EndListMembers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds one or more tags to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateActionTarget


        /// <summary>
        /// Updates the name and description of a custom action target in Security Hub.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionTarget service method.</param>
        /// 
        /// <returns>The response from the UpdateActionTarget service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        UpdateActionTargetResponse UpdateActionTarget(UpdateActionTargetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateActionTarget operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateActionTarget
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        IAsyncResult BeginUpdateActionTarget(UpdateActionTargetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateActionTarget operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateActionTarget.</param>
        /// 
        /// <returns>Returns a  UpdateActionTargetResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateActionTarget">REST API Reference for UpdateActionTarget Operation</seealso>
        UpdateActionTargetResponse EndUpdateActionTarget(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateFindings


        /// <summary>
        /// Updates the <code>Note</code> and <code>RecordState</code> of the Security Hub-aggregated
        /// findings that the filter attributes specify. Any member account that can view the
        /// finding also sees the update to the finding.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings service method.</param>
        /// 
        /// <returns>The response from the UpdateFindings service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        UpdateFindingsResponse UpdateFindings(UpdateFindingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFindings operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateFindings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        IAsyncResult BeginUpdateFindings(UpdateFindingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateFindings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateFindings.</param>
        /// 
        /// <returns>Returns a  UpdateFindingsResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateFindings">REST API Reference for UpdateFindings Operation</seealso>
        UpdateFindingsResponse EndUpdateFindings(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateInsight


        /// <summary>
        /// Updates the Security Hub insight identified by the specified insight ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight service method.</param>
        /// 
        /// <returns>The response from the UpdateInsight service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.LimitExceededException">
        /// The request was rejected because it attempted to create resources beyond the current
        /// AWS account limits. The error code describes the limit exceeded.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        UpdateInsightResponse UpdateInsight(UpdateInsightRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateInsight operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateInsight operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateInsight
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        IAsyncResult BeginUpdateInsight(UpdateInsightRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateInsight operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateInsight.</param>
        /// 
        /// <returns>Returns a  UpdateInsightResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateInsight">REST API Reference for UpdateInsight Operation</seealso>
        UpdateInsightResponse EndUpdateInsight(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStandardsControl


        /// <summary>
        /// Used to control whether an individual compliance standard control is enabled or disabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl service method.</param>
        /// 
        /// <returns>The response from the UpdateStandardsControl service method, as returned by SecurityHub.</returns>
        /// <exception cref="Amazon.SecurityHub.Model.InternalException">
        /// Internal server error.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidAccessException">
        /// AWS Security Hub isn't enabled for the account used to make this request.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.InvalidInputException">
        /// The request was rejected because you supplied an invalid or out-of-range value for
        /// an input parameter.
        /// </exception>
        /// <exception cref="Amazon.SecurityHub.Model.ResourceNotFoundException">
        /// The request was rejected because we can't find the specified resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        UpdateStandardsControlResponse UpdateStandardsControl(UpdateStandardsControlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStandardsControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStandardsControl operation on AmazonSecurityHubClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStandardsControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        IAsyncResult BeginUpdateStandardsControl(UpdateStandardsControlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStandardsControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStandardsControl.</param>
        /// 
        /// <returns>Returns a  UpdateStandardsControlResult from SecurityHub.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/securityhub-2018-10-26/UpdateStandardsControl">REST API Reference for UpdateStandardsControl Operation</seealso>
        UpdateStandardsControlResponse EndUpdateStandardsControl(IAsyncResult asyncResult);

        #endregion
        
    }
}