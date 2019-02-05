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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeCommit.Model;

namespace Amazon.CodeCommit
{
    /// <summary>
    /// Interface for accessing CodeCommit
    ///
    /// AWS CodeCommit 
    /// <para>
    /// This is the <i>AWS CodeCommit API Reference</i>. This reference provides descriptions
    /// of the operations and data types for AWS CodeCommit API along with usage examples.
    /// </para>
    ///  
    /// <para>
    /// You can use the AWS CodeCommit API to work with the following objects:
    /// </para>
    ///  
    /// <para>
    /// Repositories, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchGetRepositories</a>, which returns information about one or more repositories
    /// associated with your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateRepository</a>, which creates an AWS CodeCommit repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteRepository</a>, which deletes an AWS CodeCommit repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetRepository</a>, which returns information about a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRepositories</a>, which lists all AWS CodeCommit repositories associated with
    /// your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryDescription</a>, which sets or updates the description of the
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateRepositoryName</a>, which changes the name of the repository. If you change
    /// the name of a repository, no other users of that repository will be able to access
    /// it until you send them the new HTTPS or SSH URL to use.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Branches, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBranch</a>, which creates a new branch in a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteBranch</a>, which deletes the specified branch in a repository unless it
    /// is the default branch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetBranch</a>, which returns information about a specified branch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListBranches</a>, which lists all branches for a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateDefaultBranch</a>, which changes the default branch for a repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Files, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteFile</a>, which deletes the content of a specified file from a specified
    /// branch.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetFile</a>, which returns the base-64 encoded content of a specified file.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetFolder</a>, which returns the contents of a specified folder or directory.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutFile</a>, which adds or modifies a file in a specified repository and branch.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Information about committed code in a repository, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetBlob</a>, which returns the base-64 encoded content of an individual Git blob
    /// object within a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommit</a>, which returns information about a commit, including commit messages
    /// and author and committer information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetDifferences</a>, which returns information about the differences in a valid
    /// commit specifier (such as a branch, tag, HEAD, commit ID or other fully qualified
    /// reference).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Pull requests, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreatePullRequest</a>, which creates a pull request in a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePullRequestEvents</a>, which returns information about one or more pull
    /// request events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentsForPullRequest</a>, which returns information about comments on a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeConflicts</a>, which returns information about merge conflicts between
    /// the source and destination branch in a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequest</a>, which returns information about a specified pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListPullRequests</a>, which lists all pull requests for a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergePullRequestByFastForward</a>, which merges the source destination branch
    /// of a pull request into the specified destination branch for that pull request using
    /// the fast-forward merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentForPullRequest</a>, which posts a comment to a pull request at the
    /// specified line, file, or request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestDescription</a>, which updates the description of a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestStatus</a>, which updates the status of a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestTitle</a>, which updates the title of a pull request.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Information about comments in a repository, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>DeleteCommentContent</a>, which deletes the content of a comment on a commit in
    /// a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetComment</a>, which returns information about a comment on a commit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentsForComparedCommit</a>, which returns information about comments on
    /// the comparison between two commit specifiers in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentForComparedCommit</a>, which creates a comment on the comparison between
    /// two commit specifiers in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentReply</a>, which creates a reply to a comment.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateComment</a>, which updates the content of a comment on a commit in a repository.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Triggers, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>GetRepositoryTriggers</a>, which returns information about triggers configured
    /// for a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PutRepositoryTriggers</a>, which replaces all triggers for a repository and can
    /// be used to create or delete triggers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TestRepositoryTriggers</a>, which tests the functionality of a repository trigger
    /// by sending data to the trigger target.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For information about how to use AWS CodeCommit, see the <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
    /// CodeCommit User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeCommit : IAmazonService, IDisposable
    {

        
        #region  BatchGetRepositories


        /// <summary>
        /// Returns information about one or more repositories.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchGetRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 25.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// A repository names object is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        BatchGetRepositoriesResponse BatchGetRepositories(BatchGetRepositoriesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        Task<BatchGetRepositoriesResponse> BatchGetRepositoriesAsync(BatchGetRepositoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateBranch


        /// <summary>
        /// Creates a new branch in a repository and points the branch to a commit.
        /// 
        ///  <note> 
        /// <para>
        /// Calling the create branch operation does not set a repository's default branch. To
        /// do this, call the update default branch operation.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch service method.</param>
        /// 
        /// <returns>The response from the CreateBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameExistsException">
        /// The specified branch name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        CreateBranchResponse CreateBranch(CreateBranchRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        Task<CreateBranchResponse> CreateBranchAsync(CreateBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreatePullRequest


        /// <summary>
        /// Creates a pull request in the specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequest service method.</param>
        /// 
        /// <returns>The response from the CreatePullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that when provided in a request, ensures the request cannot be repeated
        /// with a changed parameter. If a request is received with the same parameters and a
        /// token is included, the request will return information about the initial request that
        /// used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be re-used.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions are limited to 1,000 characters
        /// in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReferenceNameException">
        /// The specified reference name format is not valid. Reference names must conform to
        /// the Git references format, for example refs/heads/master. For more information, see
        /// <a href="https://git-scm.com/book/en/v2/Git-Internals-Git-References">Git Internals
        /// - Git References</a> or consult your Git documentation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetException">
        /// The target for the pull request is not valid. A target must contain the full values
        /// for the repository name, source branch, and destination branch for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetsException">
        /// The targets for the pull request is not valid or not in a valid format. Targets are
        /// a list of target objects. Each target object must contain the full values for the
        /// repository name, source branch, and destination branch for a pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTitleException">
        /// The title of the pull request is not valid. Pull request titles cannot exceed 100
        /// characters in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumOpenPullRequestsExceededException">
        /// You cannot create the pull request because the repository has too many open pull requests.
        /// The maximum number of open pull requests for a repository is 1,000. Close one or more
        /// open pull requests, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleRepositoriesInPullRequestException">
        /// You cannot include more than one repository in a pull request. Make sure you have
        /// specified only one repository name in your request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceDoesNotExistException">
        /// The specified reference does not exist. You must provide a full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceNameRequiredException">
        /// A reference name is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceTypeNotSupportedException">
        /// The specified reference is not a supported type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceAndDestinationAreSameException">
        /// The source branch and the destination branch for the pull request are the same. You
        /// must specify different branches for the source and destination.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TargetRequiredException">
        /// A pull request target is required. It cannot be empty or null. A pull request target
        /// must contain the full values for the repository name, source branch, and destination
        /// branch for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TargetsRequiredException">
        /// An array of target objects is required. It cannot be empty or null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TitleRequiredException">
        /// A pull request title is required. It cannot be empty or null.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        CreatePullRequestResponse CreatePullRequest(CreatePullRequestRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        Task<CreatePullRequestResponse> CreatePullRequestAsync(CreatePullRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRepository


        /// <summary>
        /// Creates a new, empty repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryLimitExceededException">
        /// A repository resource limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteBranch


        /// <summary>
        /// Deletes a branch from a repository, unless that branch is the default branch for the
        /// repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch service method.</param>
        /// 
        /// <returns>The response from the DeleteBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DefaultBranchCannotBeDeletedException">
        /// The specified branch is the default branch for the repository, and cannot be deleted.
        /// To delete this branch, you must first set another branch as the default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        DeleteBranchResponse DeleteBranch(DeleteBranchRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        Task<DeleteBranchResponse> DeleteBranchAsync(DeleteBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCommentContent


        /// <summary>
        /// Deletes the content of a comment made on a change, file, or commit in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCommentContent service method.</param>
        /// 
        /// <returns>The response from the DeleteCommentContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have provided the correct
        /// ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        DeleteCommentContentResponse DeleteCommentContent(DeleteCommentContentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCommentContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCommentContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        Task<DeleteCommentContentResponse> DeleteCommentContentAsync(DeleteCommentContentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteFile


        /// <summary>
        /// Deletes a specified file from a specified branch. A commit is created on the branch
        /// that contains the revision. The file will still exist in the commits prior to the
        /// commit that contains the deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile service method.</param>
        /// 
        /// <returns>The response from the DeleteFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Type the name of
        /// a current branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have provided the correct name
        /// of the file, including its full path and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for file names.
        /// File names, including the path to the file, cannot exceed the character limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        DeleteFileResponse DeleteFile(DeleteFileRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        Task<DeleteFileResponse> DeleteFileAsync(DeleteFileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes a repository. If a specified repository was already deleted, a null repository
        /// ID will be returned.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a repository also deletes all associated objects and metadata. After a repository
        /// is deleted, all future push calls to the deleted repository will fail.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribePullRequestEvents


        /// <summary>
        /// Returns information about one or more pull request events.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePullRequestEvents service method.</param>
        /// 
        /// <returns>The response from the DescribePullRequestEvents service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ActorDoesNotExistException">
        /// The specified Amazon Resource Name (ARN) does not exist in the AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidActorArnException">
        /// The Amazon Resource Name (ARN) is not valid. Make sure that you have provided the
        /// full ARN for the user who initiated the change for the pull request, and then try
        /// again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestEventTypeException">
        /// The pull request event type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        DescribePullRequestEventsResponse DescribePullRequestEvents(DescribePullRequestEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePullRequestEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePullRequestEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        Task<DescribePullRequestEventsResponse> DescribePullRequestEventsAsync(DescribePullRequestEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBlob


        /// <summary>
        /// Returns the base-64 encoded content of an individual blob within a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlob service method.</param>
        /// 
        /// <returns>The response from the GetBlob service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdDoesNotExistException">
        /// The specified blob does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdRequiredException">
        /// A blob ID is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for AWS CodeCommit. For more information
        /// about limits in AWS CodeCommit, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBlobIdException">
        /// The specified blob is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        GetBlobResponse GetBlob(GetBlobRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        Task<GetBlobResponse> GetBlobAsync(GetBlobRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetBranch


        /// <summary>
        /// Returns information about a repository branch, including its name and the last commit
        /// ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBranch service method.</param>
        /// 
        /// <returns>The response from the GetBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        GetBranchResponse GetBranch(GetBranchRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        Task<GetBranchResponse> GetBranchAsync(GetBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetComment


        /// <summary>
        /// Returns the content of a comment made on a change, file, or commit in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComment service method.</param>
        /// 
        /// <returns>The response from the GetComment service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have provided the correct
        /// ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        GetCommentResponse GetComment(GetCommentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        Task<GetCommentResponse> GetCommentAsync(GetCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCommentsForComparedCommit


        /// <summary>
        /// Returns information about comments made on the comparison between two commits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForComparedCommit service method.</param>
        /// 
        /// <returns>The response from the GetCommentsForComparedCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        GetCommentsForComparedCommitResponse GetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCommentsForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForComparedCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        Task<GetCommentsForComparedCommitResponse> GetCommentsForComparedCommitAsync(GetCommentsForComparedCommitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCommentsForPullRequest


        /// <summary>
        /// Returns comments made on a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForPullRequest service method.</param>
        /// 
        /// <returns>The response from the GetCommentsForPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Check
        /// to make sure you have provided the correct repository name for the pull request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        GetCommentsForPullRequestResponse GetCommentsForPullRequest(GetCommentsForPullRequestRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCommentsForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForPullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        Task<GetCommentsForPullRequestResponse> GetCommentsForPullRequestAsync(GetCommentsForPullRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetCommit


        /// <summary>
        /// Returns information about a commit, including commit message and committer information.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCommit service method.</param>
        /// 
        /// <returns>The response from the GetCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdDoesNotExistException">
        /// The specified commit ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        GetCommitResponse GetCommit(GetCommitRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        Task<GetCommitResponse> GetCommitAsync(GetCommitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDifferences


        /// <summary>
        /// Returns information about the differences in a valid commit specifier (such as a branch,
        /// tag, HEAD, commit ID or other fully qualified reference). Results can be limited to
        /// a specified path.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDifferences service method.</param>
        /// 
        /// <returns>The response from the GetDifferences service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        GetDifferencesResponse GetDifferences(GetDifferencesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetDifferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDifferences operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        Task<GetDifferencesResponse> GetDifferencesAsync(GetDifferencesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFile


        /// <summary>
        /// Returns the base-64 encoded contents of a specified file and its metadata.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFile service method.</param>
        /// 
        /// <returns>The response from the GetFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have provided the correct name
        /// of the file, including its full path and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for AWS CodeCommit. For more information
        /// about limits in AWS CodeCommit, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        GetFileResponse GetFile(GetFileRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        Task<GetFileResponse> GetFileAsync(GetFileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetFolder


        /// <summary>
        /// Returns the contents of a specified folder in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetFolder service method.</param>
        /// 
        /// <returns>The response from the GetFolder service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderDoesNotExistException">
        /// The specified folder does not exist. Either the folder name is not correct, or you
        /// did not provide the full path to the folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        GetFolderResponse GetFolder(GetFolderRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolder operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        Task<GetFolderResponse> GetFolderAsync(GetFolderRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetMergeConflicts


        /// <summary>
        /// Returns information about merge conflicts between the before and after commit IDs
        /// for a pull request in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeConflicts service method.</param>
        /// 
        /// <returns>The response from the GetMergeConflicts service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDestinationCommitSpecifierException">
        /// The destination commit specifier is not valid. You must provide a valid branch name,
        /// tag, or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid. The only valid value is FAST_FORWARD_MERGE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSourceCommitSpecifierException">
        /// The source commit specifier is not valid. You must provide a valid branch name, tag,
        /// or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        GetMergeConflictsResponse GetMergeConflicts(GetMergeConflictsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMergeConflicts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        Task<GetMergeConflictsResponse> GetMergeConflictsAsync(GetMergeConflictsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetPullRequest


        /// <summary>
        /// Gets information about a pull request in a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequest service method.</param>
        /// 
        /// <returns>The response from the GetPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        GetPullRequestResponse GetPullRequest(GetPullRequestRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        Task<GetPullRequestResponse> GetPullRequestAsync(GetPullRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRepository


        /// <summary>
        /// Returns information about a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepository service method.</param>
        /// 
        /// <returns>The response from the GetRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        GetRepositoryResponse GetRepository(GetRepositoryRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepository operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetRepositoryTriggers


        /// <summary>
        /// Gets information about triggers configured for a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryTriggers service method.</param>
        /// 
        /// <returns>The response from the GetRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        GetRepositoryTriggersResponse GetRepositoryTriggers(GetRepositoryTriggersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        Task<GetRepositoryTriggersResponse> GetRepositoryTriggersAsync(GetRepositoryTriggersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListBranches


        /// <summary>
        /// Gets information about one or more branches in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBranches service method.</param>
        /// 
        /// <returns>The response from the ListBranches service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        ListBranchesResponse ListBranches(ListBranchesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBranches operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        Task<ListBranchesResponse> ListBranchesAsync(ListBranchesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListPullRequests


        /// <summary>
        /// Returns a list of pull requests for a specified repository. The return list can be
        /// refined by pull request status or pull request author ARN.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPullRequests service method.</param>
        /// 
        /// <returns>The response from the ListPullRequests service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.AuthorDoesNotExistException">
        /// The specified Amazon Resource Name (ARN) does not exist in the AWS account.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidAuthorArnException">
        /// The Amazon Resource Name (ARN) is not valid. Make sure that you have provided the
        /// full ARN for the author of the pull request, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusException">
        /// The pull request status is not valid. The only valid values are <code>OPEN</code>
        /// and <code>CLOSED</code>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        ListPullRequestsResponse ListPullRequests(ListPullRequestsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListPullRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPullRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        Task<ListPullRequestsResponse> ListPullRequestsAsync(ListPullRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListRepositories


        /// <summary>
        /// Gets information about one or more repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// 
        /// <returns>The response from the ListRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOrderException">
        /// The specified sort order is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSortByException">
        /// The specified sort by value is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  MergePullRequestByFastForward


        /// <summary>
        /// Closes a pull request and attempts to merge the source commit of a pull request into
        /// the specified destination branch for that pull request at the specified commit using
        /// the fast-forward merge option.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReferenceDoesNotExistException">
        /// The specified reference does not exist. You must provide a full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Check
        /// to make sure you have provided the correct repository name for the pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        MergePullRequestByFastForwardResponse MergePullRequestByFastForward(MergePullRequestByFastForwardRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the MergePullRequestByFastForward operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        Task<MergePullRequestByFastForwardResponse> MergePullRequestByFastForwardAsync(MergePullRequestByFastForwardRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PostCommentForComparedCommit


        /// <summary>
        /// Posts a comment on the comparison between two commits.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForComparedCommit service method.</param>
        /// 
        /// <returns>The response from the PostCommentForComparedCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BeforeCommitIdAndAfterCommitIdAreSameException">
        /// The before commit ID and the after commit ID are the same, which is not valid. The
        /// before commit ID and the after commit ID must be different commit IDs.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that when provided in a request, ensures the request cannot be repeated
        /// with a changed parameter. If a request is received with the same parameters and a
        /// token is included, the request will return information about the initial request that
        /// used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 1,000 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be re-used.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the extension of
        /// the file as well as the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFilePositionException">
        /// The position is not valid. Make sure that the line number exists in the version of
        /// the file you want to comment on.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRelativeFileVersionEnumException">
        /// Either the enum is not in a valid format, or the specified file version enum is not
        /// valid in respect to the current file version.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        PostCommentForComparedCommitResponse PostCommentForComparedCommit(PostCommentForComparedCommitRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForComparedCommit operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        Task<PostCommentForComparedCommitResponse> PostCommentForComparedCommitAsync(PostCommentForComparedCommitRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PostCommentForPullRequest


        /// <summary>
        /// Posts a comment on a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForPullRequest service method.</param>
        /// 
        /// <returns>The response from the PostCommentForPullRequest service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BeforeCommitIdAndAfterCommitIdAreSameException">
        /// The before commit ID and the after commit ID are the same, which is not valid. The
        /// before commit ID and the after commit ID must be different commit IDs.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that when provided in a request, ensures the request cannot be repeated
        /// with a changed parameter. If a request is received with the same parameters and a
        /// token is included, the request will return information about the initial request that
        /// used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 1,000 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdRequiredException">
        /// A commit ID was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be re-used.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the extension of
        /// the file as well as the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFilePositionException">
        /// The position is not valid. Make sure that the line number exists in the version of
        /// the file you want to comment on.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRelativeFileVersionEnumException">
        /// Either the enum is not in a valid format, or the specified file version enum is not
        /// valid in respect to the current file version.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathDoesNotExistException">
        /// The specified path does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Check
        /// to make sure you have provided the correct repository name for the pull request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        PostCommentForPullRequestResponse PostCommentForPullRequest(PostCommentForPullRequestRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForPullRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        Task<PostCommentForPullRequestResponse> PostCommentForPullRequestAsync(PostCommentForPullRequestRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PostCommentReply


        /// <summary>
        /// Posts a comment in reply to an existing comment on a comparison between commits or
        /// a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostCommentReply service method.</param>
        /// 
        /// <returns>The response from the PostCommentReply service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ClientRequestTokenRequiredException">
        /// A client request token is required. A client request token is an unique, client-generated
        /// idempotency token that when provided in a request, ensures the request cannot be repeated
        /// with a changed parameter. If a request is received with the same parameters and a
        /// token is included, the request will return information about the initial request that
        /// used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 1,000 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have provided the correct
        /// ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be re-used.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        PostCommentReplyResponse PostCommentReply(PostCommentReplyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentReply operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentReply operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        Task<PostCommentReplyResponse> PostCommentReplyAsync(PostCommentReplyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutFile


        /// <summary>
        /// Adds or updates a file in a branch in an AWS CodeCommit repository, and generates
        /// a commit for the addition in the specified branch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutFile service method.</param>
        /// 
        /// <returns>The response from the PutFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Type the name of
        /// a current branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.DirectoryNameConflictsWithFileNameException">
        /// A file cannot be added to the repository because the specified path name has the same
        /// name as a file that already exists in this repository. Either provide a different
        /// name for the file, or specify a different path for the file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentRequiredException">
        /// The file cannot be added because it is empty. Empty files cannot be added to the repository
        /// with this API.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size that can be
        /// added using PutFile is 6 MB. For files larger than 6 MB but smaller than 2 GB, add
        /// them using a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The specified file path or folder has the same path as a submodule in this repository.
        /// Either provide a different name for the file, or save the file in a directory that
        /// does not conflict with the submodule path.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The specified file is in a folder that exceeds the folder content size limit. Either
        /// save the file in a folder that has less content, or remove files or subfolders from
        /// the folder so it does not exceed the size limit. For more information about limits
        /// in AWS CodeCommit, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDeletionParameterException">
        /// The specified deletion parameter is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidParentCommitIdException">
        /// The parent commit ID is not valid. The commit ID cannot be empty, and must match the
        /// head commit ID for the branch of the repository where you want to add or update a
        /// file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for file names.
        /// File names, including the path to the file, cannot exceed the character limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitDoesNotExistException">
        /// The parent commit ID is not valid because it does not exist. The specified parent
        /// commit ID does not exist in the specified branch of the repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdOutdatedException">
        /// The file could not be added because the provided parent commit ID is not the current
        /// tip of the specified branch. To view the full commit ID of the current head of the
        /// branch, use <a>GetBranch</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ParentCommitIdRequiredException">
        /// A parent commit ID is required. To view the full commit ID of a branch in a repository,
        /// use <a>GetBranch</a> or a Git command (for example, git pull or git log).
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SameFileContentException">
        /// The file was not added or updated because the content of the file is exactly the same
        /// as the content of that file in the repository and branch that you specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        PutFileResponse PutFile(PutFileRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutFile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        Task<PutFileResponse> PutFileAsync(PutFileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRepositoryTriggers


        /// <summary>
        /// Replaces all triggers for a repository. This can be used to create or delete triggers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryTriggers service method.</param>
        /// 
        /// <returns>The response from the PutRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerBranchNameException">
        /// One or more branch names specified for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerCustomDataException">
        /// The custom data provided for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerDestinationArnException">
        /// The Amazon Resource Name (ARN) for the trigger is not valid for the specified destination.
        /// The most common reason for this error is that the ARN does not meet the requirements
        /// for the service type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerEventsException">
        /// One or more events specified for the trigger is not valid. Check to make sure that
        /// all events specified match the requirements for allowed events.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerNameException">
        /// The name of the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerRegionException">
        /// The region for the trigger target does not match the region for the repository. Triggers
        /// must be created in the same region as the target for the trigger.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumBranchesExceededException">
        /// The number of branches for the trigger was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryTriggersExceededException">
        /// The number of triggers allowed for the repository was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        PutRepositoryTriggersResponse PutRepositoryTriggers(PutRepositoryTriggersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        Task<PutRepositoryTriggersResponse> PutRepositoryTriggersAsync(PutRepositoryTriggersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestRepositoryTriggers


        /// <summary>
        /// Tests the functionality of repository triggers by sending information to the trigger
        /// target. If real data is available in the repository, the test will send data from
        /// the last commit. If no data is available, sample data will be generated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestRepositoryTriggers service method.</param>
        /// 
        /// <returns>The response from the TestRepositoryTriggers service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerBranchNameException">
        /// One or more branch names specified for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerCustomDataException">
        /// The custom data provided for the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerDestinationArnException">
        /// The Amazon Resource Name (ARN) for the trigger is not valid for the specified destination.
        /// The most common reason for this error is that the ARN does not meet the requirements
        /// for the service type.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerEventsException">
        /// One or more events specified for the trigger is not valid. Check to make sure that
        /// all events specified match the requirements for allowed events.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerNameException">
        /// The name of the trigger is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryTriggerRegionException">
        /// The region for the trigger target does not match the region for the repository. Triggers
        /// must be created in the same region as the target for the trigger.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumBranchesExceededException">
        /// The number of branches for the trigger was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryTriggersExceededException">
        /// The number of triggers allowed for the repository was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        TestRepositoryTriggersResponse TestRepositoryTriggers(TestRepositoryTriggersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRepositoryTriggers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        Task<TestRepositoryTriggersResponse> TestRepositoryTriggersAsync(TestRepositoryTriggersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateComment


        /// <summary>
        /// Replaces the contents of a comment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComment service method.</param>
        /// 
        /// <returns>The response from the UpdateComment service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 1,000 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDeletedException">
        /// This comment has already been deleted. You cannot edit or delete a deleted comment.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have provided the correct
        /// ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentNotCreatedByCallerException">
        /// You cannot modify or delete this comment. Only comment authors can modify or delete
        /// their comments.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommentIdException">
        /// The comment ID is not in a valid format. Make sure that you have provided the full
        /// comment ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        UpdateCommentResponse UpdateComment(UpdateCommentRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        Task<UpdateCommentResponse> UpdateCommentAsync(UpdateCommentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDefaultBranch


        /// <summary>
        /// Sets or changes the default branch name for the specified repository.
        /// 
        ///  <note> 
        /// <para>
        /// If you use this operation to change the default branch name to the current default
        /// branch name, a success message is returned even though the default branch did not
        /// change.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch service method.</param>
        /// 
        /// <returns>The response from the UpdateDefaultBranch service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        UpdateDefaultBranchResponse UpdateDefaultBranch(UpdateDefaultBranchRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        Task<UpdateDefaultBranchResponse> UpdateDefaultBranchAsync(UpdateDefaultBranchRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePullRequestDescription


        /// <summary>
        /// Replaces the contents of the description of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions are limited to 1,000 characters
        /// in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        UpdatePullRequestDescriptionResponse UpdatePullRequestDescription(UpdatePullRequestDescriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        Task<UpdatePullRequestDescriptionResponse> UpdatePullRequestDescriptionAsync(UpdatePullRequestDescriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePullRequestStatus


        /// <summary>
        /// Updates the status of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestStatus service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestStatus service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusException">
        /// The pull request status is not valid. The only valid values are <code>OPEN</code>
        /// and <code>CLOSED</code>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestStatusUpdateException">
        /// The pull request status update is not valid. The only valid update is from <code>OPEN</code>
        /// to <code>CLOSED</code>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestStatusRequiredException">
        /// A pull request status is required, but none was provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        UpdatePullRequestStatusResponse UpdatePullRequestStatus(UpdatePullRequestStatusRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        Task<UpdatePullRequestStatusResponse> UpdatePullRequestStatusAsync(UpdatePullRequestStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdatePullRequestTitle


        /// <summary>
        /// Replaces the title of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestTitle service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestTitle service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTitleException">
        /// The title of the pull request is not valid. Pull request titles cannot exceed 100
        /// characters in length.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TitleRequiredException">
        /// A pull request title is required. It cannot be empty or null.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        UpdatePullRequestTitleResponse UpdatePullRequestTitle(UpdatePullRequestTitleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestTitle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestTitle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        Task<UpdatePullRequestTitleResponse> UpdatePullRequestTitleAsync(UpdatePullRequestTitleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRepositoryDescription


        /// <summary>
        /// Sets or changes the comment or description for a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a web page could expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a web page.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionIntegrityChecksFailedException">
        /// An encryption integrity check failed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyAccessDeniedException">
        /// An encryption key could not be accessed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyDisabledException">
        /// The encryption key is disabled.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyNotFoundException">
        /// No encryption key was found.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.EncryptionKeyUnavailableException">
        /// The encryption key is not available.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryDescriptionException">
        /// The specified repository description is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        UpdateRepositoryDescriptionResponse UpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        Task<UpdateRepositoryDescriptionResponse> UpdateRepositoryDescriptionAsync(UpdateRepositoryDescriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateRepositoryName


        /// <summary>
        /// Renames a repository. The repository name must be unique across the calling AWS account.
        /// In addition, repository names are limited to 100 alphanumeric, dash, and underscore
        /// characters, and cannot include certain characters. The suffix ".git" is prohibited.
        /// For a full description of the limits on repository names, see <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Limits</a>
        /// in the AWS CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// At least one specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception only occurs when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        UpdateRepositoryNameResponse UpdateRepositoryName(UpdateRepositoryNameRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        Task<UpdateRepositoryNameResponse> UpdateRepositoryNameAsync(UpdateRepositoryNameRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}