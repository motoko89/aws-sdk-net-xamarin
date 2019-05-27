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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Organizations.Model;

namespace Amazon.Organizations
{
    /// <summary>
    /// Interface for accessing Organizations
    ///
    /// AWS Organizations API Reference 
    /// <para>
    /// AWS Organizations is a web service that enables you to consolidate your multiple AWS
    /// accounts into an <i>organization</i> and centrally manage your accounts and their
    /// resources.
    /// </para>
    ///  
    /// <para>
    /// This guide provides descriptions of the Organizations API. For more information about
    /// using this service, see the <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">AWS
    /// Organizations User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Version</b> 
    /// </para>
    ///  
    /// <para>
    /// This version of the Organizations API Reference documents the Organizations API version
    /// 2016-11-28.
    /// </para>
    ///  <note> 
    /// <para>
    /// As an alternative to using the API directly, you can use one of the AWS SDKs, which
    /// consist of libraries and sample code for various programming languages and platforms
    /// (Java, Ruby, .NET, iOS, Android, and more). The SDKs provide a convenient way to create
    /// programmatic access to AWS Organizations. For example, the SDKs take care of cryptographically
    /// signing requests, managing errors, and retrying requests automatically. For more information
    /// about the AWS SDKs, including how to download and install them, see <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// We recommend that you use the AWS SDKs to make programmatic API calls to Organizations.
    /// However, you also can use the Organizations Query API to make direct calls to the
    /// Organizations web service. To learn more about the Organizations Query API, see <a
    /// href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_query-requests.html">Making
    /// Query Requests</a> in the <i>AWS Organizations User Guide</i>. Organizations supports
    /// GET and POST requests for all actions. That is, the API does not require you to use
    /// GET for some actions and POST for others. However, GET requests are subject to the
    /// limitation size of a URL. Therefore, for operations that require larger sizes, use
    /// a POST request.
    /// </para>
    ///  
    /// <para>
    ///  <b>Signing Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// When you send HTTP requests to AWS, you must sign the requests so that AWS can identify
    /// who sent them. You sign requests with your AWS access key, which consists of an access
    /// key ID and a secret access key. We strongly recommend that you do not create an access
    /// key for your root account. Anyone who has the access key for your root account has
    /// unrestricted access to all the resources in your account. Instead, create an access
    /// key for an IAM user account that has administrative privileges. As another option,
    /// use AWS Security Token Service to generate temporary security credentials, and use
    /// those credentials to sign requests. 
    /// </para>
    ///  
    /// <para>
    /// To sign requests, we recommend that you use <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>. If you have an existing application that uses Signature Version 2,
    /// you do not have to update it to use Signature Version 4. However, some operations
    /// now require Signature Version 4. The documentation for operations that require version
    /// 4 indicate this requirement. 
    /// </para>
    ///  
    /// <para>
    /// When you use the AWS Command Line Interface (AWS CLI) or one of the AWS SDKs to make
    /// requests to AWS, these tools automatically sign the requests for you with the access
    /// key that you specify when you configure the tools.
    /// </para>
    ///  
    /// <para>
    /// In this release, each organization can have only one root. In a future release, a
    /// single organization will support multiple roots.
    /// </para>
    ///  
    /// <para>
    ///  <b>Support and Feedback for AWS Organizations</b> 
    /// </para>
    ///  
    /// <para>
    /// We welcome your feedback. Send your comments to <a href="mailto:feedback-awsorganizations@amazon.com">feedback-awsorganizations@amazon.com</a>
    /// or post your feedback and questions in the <a href="http://forums.aws.amazon.com/forum.jspa?forumID=219">AWS
    /// Organizations support forum</a>. For more information about the AWS support forums,
    /// see <a href="http://forums.aws.amazon.com/help.jspa">Forums Help</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoint to Call When Using the CLI or the AWS API</b> 
    /// </para>
    ///  
    /// <para>
    /// For the current release of Organizations, you must specify the <code>us-east-1</code>
    /// region for all AWS API and CLI calls. You can do this in the CLI by using these parameters
    /// and commands:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use the following parameter with each command to specify both the endpoint and its
    /// region:
    /// </para>
    ///  
    /// <para>
    ///  <code>--endpoint-url https://organizations.us-east-1.amazonaws.com</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the default endpoint, but configure your default region with this command:
    /// </para>
    ///  
    /// <para>
    ///  <code>aws configure set default.region us-east-1</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the following parameter with each command to specify the endpoint:
    /// </para>
    ///  
    /// <para>
    ///  <code>--region us-east-1</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For the various SDKs used to call the APIs, see the documentation for the SDK of interest
    /// to learn how to direct the requests to a specific endpoint. For more information,
    /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#sts_region">Regions
    /// and Endpoints</a> in the <i>AWS General Reference</i>. 
    /// </para>
    ///  
    /// <para>
    ///  <b>How examples are presented</b> 
    /// </para>
    ///  
    /// <para>
    /// The JSON returned by the AWS Organizations service as response to your requests is
    /// returned as a single long string without line breaks or formatting whitespace. Both
    /// line breaks and whitespace are included in the examples in this guide to improve readability.
    /// When example input parameters also would result in long strings that would extend
    /// beyond the screen, we insert line breaks to enhance readability. You should always
    /// submit the input as a single JSON text string.
    /// </para>
    ///  
    /// <para>
    ///  <b>Recording API Requests</b> 
    /// </para>
    ///  
    /// <para>
    /// AWS Organizations supports AWS CloudTrail, a service that records AWS API calls for
    /// your AWS account and delivers log files to an Amazon S3 bucket. By using information
    /// collected by AWS CloudTrail, you can determine which requests were successfully made
    /// to Organizations, who made the request, when it was made, and so on. For more about
    /// AWS Organizations and its support for AWS CloudTrail, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_monitoring.html#orgs_cloudtrail-integration">Logging
    /// AWS Organizations Events with AWS CloudTrail</a> in the <i>AWS Organizations User
    /// Guide</i>. To learn more about CloudTrail, including how to turn it on and find your
    /// log files, see the <a href="https://docs.aws.amazon.com/awscloudtrail/latest/userguide/what_is_cloud_trail_top_level.html">AWS
    /// CloudTrail User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonOrganizations : IAmazonService, IDisposable
    {
                
        #region  AcceptHandshake


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AcceptHandshake">REST API Reference for AcceptHandshake Operation</seealso>
        Task<AcceptHandshakeResponse> AcceptHandshakeAsync(AcceptHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  AttachPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the AttachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/AttachPolicy">REST API Reference for AttachPolicy Operation</seealso>
        Task<AttachPolicyResponse> AttachPolicyAsync(AttachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CancelHandshake


        /// <summary>
        /// Initiates the asynchronous execution of the CancelHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CancelHandshake">REST API Reference for CancelHandshake Operation</seealso>
        Task<CancelHandshakeResponse> CancelHandshakeAsync(CancelHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateAccount


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateAccount">REST API Reference for CreateAccount Operation</seealso>
        Task<CreateAccountResponse> CreateAccountAsync(CreateAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateGovCloudAccount


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGovCloudAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGovCloudAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateGovCloudAccount">REST API Reference for CreateGovCloudAccount Operation</seealso>
        Task<CreateGovCloudAccountResponse> CreateGovCloudAccountAsync(CreateGovCloudAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganization">REST API Reference for CreateOrganization Operation</seealso>
        Task<CreateOrganizationResponse> CreateOrganizationAsync(CreateOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateOrganizationalUnit


        /// <summary>
        /// Initiates the asynchronous execution of the CreateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreateOrganizationalUnit">REST API Reference for CreateOrganizationalUnit Operation</seealso>
        Task<CreateOrganizationalUnitResponse> CreateOrganizationalUnitAsync(CreateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreatePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/CreatePolicy">REST API Reference for CreatePolicy Operation</seealso>
        Task<CreatePolicyResponse> CreatePolicyAsync(CreatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeclineHandshake


        /// <summary>
        /// Initiates the asynchronous execution of the DeclineHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeclineHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeclineHandshake">REST API Reference for DeclineHandshake Operation</seealso>
        Task<DeclineHandshakeResponse> DeclineHandshakeAsync(DeclineHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganization">REST API Reference for DeleteOrganization Operation</seealso>
        Task<DeleteOrganizationResponse> DeleteOrganizationAsync(DeleteOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteOrganizationalUnit


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeleteOrganizationalUnit">REST API Reference for DeleteOrganizationalUnit Operation</seealso>
        Task<DeleteOrganizationalUnitResponse> DeleteOrganizationalUnitAsync(DeleteOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeletePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DeletePolicy">REST API Reference for DeletePolicy Operation</seealso>
        Task<DeletePolicyResponse> DeletePolicyAsync(DeletePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeAccount


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        Task<DescribeAccountResponse> DescribeAccountAsync(DescribeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeCreateAccountStatus


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCreateAccountStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeCreateAccountStatus">REST API Reference for DescribeCreateAccountStatus Operation</seealso>
        Task<DescribeCreateAccountStatusResponse> DescribeCreateAccountStatusAsync(DescribeCreateAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeHandshake


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHandshake operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHandshake operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeHandshake">REST API Reference for DescribeHandshake Operation</seealso>
        Task<DescribeHandshakeResponse> DescribeHandshakeAsync(DescribeHandshakeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganization">REST API Reference for DescribeOrganization Operation</seealso>
        Task<DescribeOrganizationResponse> DescribeOrganizationAsync(DescribeOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeOrganizationalUnit


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribeOrganizationalUnit">REST API Reference for DescribeOrganizationalUnit Operation</seealso>
        Task<DescribeOrganizationalUnitResponse> DescribeOrganizationalUnitAsync(DescribeOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DescribePolicy">REST API Reference for DescribePolicy Operation</seealso>
        Task<DescribePolicyResponse> DescribePolicyAsync(DescribePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DetachPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the DetachPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DetachPolicy">REST API Reference for DetachPolicy Operation</seealso>
        Task<DetachPolicyResponse> DetachPolicyAsync(DetachPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisableAWSServiceAccess


        /// <summary>
        /// Initiates the asynchronous execution of the DisableAWSServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAWSServiceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisableAWSServiceAccess">REST API Reference for DisableAWSServiceAccess Operation</seealso>
        Task<DisableAWSServiceAccessResponse> DisableAWSServiceAccessAsync(DisableAWSServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DisablePolicyType


        /// <summary>
        /// Initiates the asynchronous execution of the DisablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisablePolicyType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/DisablePolicyType">REST API Reference for DisablePolicyType Operation</seealso>
        Task<DisablePolicyTypeResponse> DisablePolicyTypeAsync(DisablePolicyTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableAllFeatures


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAllFeatures operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAllFeatures operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAllFeatures">REST API Reference for EnableAllFeatures Operation</seealso>
        Task<EnableAllFeaturesResponse> EnableAllFeaturesAsync(EnableAllFeaturesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnableAWSServiceAccess


        /// <summary>
        /// Initiates the asynchronous execution of the EnableAWSServiceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAWSServiceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnableAWSServiceAccess">REST API Reference for EnableAWSServiceAccess Operation</seealso>
        Task<EnableAWSServiceAccessResponse> EnableAWSServiceAccessAsync(EnableAWSServiceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  EnablePolicyType


        /// <summary>
        /// Initiates the asynchronous execution of the EnablePolicyType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnablePolicyType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/EnablePolicyType">REST API Reference for EnablePolicyType Operation</seealso>
        Task<EnablePolicyTypeResponse> EnablePolicyTypeAsync(EnablePolicyTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InviteAccountToOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the InviteAccountToOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InviteAccountToOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/InviteAccountToOrganization">REST API Reference for InviteAccountToOrganization Operation</seealso>
        Task<InviteAccountToOrganizationResponse> InviteAccountToOrganizationAsync(InviteAccountToOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  LeaveOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the LeaveOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LeaveOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/LeaveOrganization">REST API Reference for LeaveOrganization Operation</seealso>
        Task<LeaveOrganizationResponse> LeaveOrganizationAsync(LeaveOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccounts


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccounts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccounts">REST API Reference for ListAccounts Operation</seealso>
        Task<ListAccountsResponse> ListAccountsAsync(ListAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAccountsForParent


        /// <summary>
        /// Initiates the asynchronous execution of the ListAccountsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccountsForParent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAccountsForParent">REST API Reference for ListAccountsForParent Operation</seealso>
        Task<ListAccountsForParentResponse> ListAccountsForParentAsync(ListAccountsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListAWSServiceAccessForOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the ListAWSServiceAccessForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAWSServiceAccessForOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListAWSServiceAccessForOrganization">REST API Reference for ListAWSServiceAccessForOrganization Operation</seealso>
        Task<ListAWSServiceAccessForOrganizationResponse> ListAWSServiceAccessForOrganizationAsync(ListAWSServiceAccessForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChildren


        /// <summary>
        /// Initiates the asynchronous execution of the ListChildren operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListChildren operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListChildren">REST API Reference for ListChildren Operation</seealso>
        Task<ListChildrenResponse> ListChildrenAsync(ListChildrenRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListCreateAccountStatus


        /// <summary>
        /// Initiates the asynchronous execution of the ListCreateAccountStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCreateAccountStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListCreateAccountStatus">REST API Reference for ListCreateAccountStatus Operation</seealso>
        Task<ListCreateAccountStatusResponse> ListCreateAccountStatusAsync(ListCreateAccountStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHandshakesForAccount


        /// <summary>
        /// Initiates the asynchronous execution of the ListHandshakesForAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForAccount">REST API Reference for ListHandshakesForAccount Operation</seealso>
        Task<ListHandshakesForAccountResponse> ListHandshakesForAccountAsync(ListHandshakesForAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListHandshakesForOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the ListHandshakesForOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHandshakesForOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListHandshakesForOrganization">REST API Reference for ListHandshakesForOrganization Operation</seealso>
        Task<ListHandshakesForOrganizationResponse> ListHandshakesForOrganizationAsync(ListHandshakesForOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListOrganizationalUnitsForParent


        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationalUnitsForParent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationalUnitsForParent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListOrganizationalUnitsForParent">REST API Reference for ListOrganizationalUnitsForParent Operation</seealso>
        Task<ListOrganizationalUnitsForParentResponse> ListOrganizationalUnitsForParentAsync(ListOrganizationalUnitsForParentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListParents


        /// <summary>
        /// Initiates the asynchronous execution of the ListParents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListParents">REST API Reference for ListParents Operation</seealso>
        Task<ListParentsResponse> ListParentsAsync(ListParentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPolicies


        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPoliciesForTarget


        /// <summary>
        /// Initiates the asynchronous execution of the ListPoliciesForTarget operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPoliciesForTarget operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListPoliciesForTarget">REST API Reference for ListPoliciesForTarget Operation</seealso>
        Task<ListPoliciesForTargetResponse> ListPoliciesForTargetAsync(ListPoliciesForTargetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListRoots


        /// <summary>
        /// Initiates the asynchronous execution of the ListRoots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListRoots">REST API Reference for ListRoots Operation</seealso>
        Task<ListRootsResponse> ListRootsAsync(ListRootsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTargetsForPolicy


        /// <summary>
        /// Initiates the asynchronous execution of the ListTargetsForPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTargetsForPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/ListTargetsForPolicy">REST API Reference for ListTargetsForPolicy Operation</seealso>
        Task<ListTargetsForPolicyResponse> ListTargetsForPolicyAsync(ListTargetsForPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  MoveAccount


        /// <summary>
        /// Initiates the asynchronous execution of the MoveAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/MoveAccount">REST API Reference for MoveAccount Operation</seealso>
        Task<MoveAccountResponse> MoveAccountAsync(MoveAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveAccountFromOrganization


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveAccountFromOrganization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveAccountFromOrganization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/RemoveAccountFromOrganization">REST API Reference for RemoveAccountFromOrganization Operation</seealso>
        Task<RemoveAccountFromOrganizationResponse> RemoveAccountFromOrganizationAsync(RemoveAccountFromOrganizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateOrganizationalUnit


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateOrganizationalUnit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateOrganizationalUnit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdateOrganizationalUnit">REST API Reference for UpdateOrganizationalUnit Operation</seealso>
        Task<UpdateOrganizationalUnitResponse> UpdateOrganizationalUnitAsync(UpdateOrganizationalUnitRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdatePolicy


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/organizations-2016-11-28/UpdatePolicy">REST API Reference for UpdatePolicy Operation</seealso>
        Task<UpdatePolicyResponse> UpdatePolicyAsync(UpdatePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}