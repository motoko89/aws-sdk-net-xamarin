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
    /// the name of a repository, no other users of that repository can access it until you
    /// send them the new HTTPS or SSH URL to use.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Branches, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateBranch</a>, which creates a branch in a specified repository.
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
    ///  <a>GetBlob</a>, which returns the base-64 encoded content of an individual Git blob
    /// object in a repository.
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
    ///  <a>PutFile</a>, which adds or modifies a single file in a specified repository and
    /// branch.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Commits, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchGetCommits</a>, which returns information about one or more commits in a
    /// repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateCommit</a>, which creates a commit for changes to a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommit</a>, which returns information about a commit, including commit messages
    /// and author and committer information.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetDifferences</a>, which returns information about the differences in a valid
    /// commit specifier (such as a branch, tag, HEAD, commit ID, or other fully qualified
    /// reference).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Merges, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>BatchDescribeMergeConflicts</a>, which returns information about conflicts in
    /// a merge between commits in a repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateUnreferencedMergeCommit</a>, which creates an unreferenced commit between
    /// two branches or commits for the purpose of comparing them and identifying any potential
    /// conflicts.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeMergeConflicts</a>, which returns information about merge conflicts between
    /// the base, source, and destination versions of a file in a potential merge.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeCommit</a>, which returns information about the merge between a source
    /// and destination commit. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeConflicts</a>, which returns information about merge conflicts between
    /// the source and destination branch in a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetMergeOptions</a>, which returns information about the available merge options
    /// between two branches or commit specifiers.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergeBranchesByFastForward</a>, which merges two branches using the fast-forward
    /// merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergeBranchesBySquash</a>, which merges two branches using the squash merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergeBranchesByThreeWay</a>, which merges two branches using the three-way merge
    /// option.
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
    ///  <a>CreatePullRequestApprovalRule</a>, which creates an approval rule for a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeletePullRequestApprovalRule</a>, which deletes an approval rule for a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribePullRequestEvents</a>, which returns information about one or more pull
    /// request events.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>EvaluatePullRequestApprovalRules</a>, which evaluates whether a pull request has
    /// met all the conditions specified in its associated approval rules.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetCommentsForPullRequest</a>, which returns information about comments on a specified
    /// pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequest</a>, which returns information about a specified pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequestApprovalStates</a>, which returns information about the approval
    /// states for a specified pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetPullRequestOverrideState</a>, which returns information about whether approval
    /// rules have been set aside (overriden) for a pull request, and if so, the Amazon Resource
    /// Name (ARN) of the user or identity that overrode the rules and their requirements
    /// for the pull request.
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
    ///  <a>MergePullRequestBySquash</a>, which merges the source destination branch of a
    /// pull request into the specified destination branch for that pull request using the
    /// squash merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>MergePullRequestByThreeWay</a>. which merges the source destination branch of
    /// a pull request into the specified destination branch for that pull request using the
    /// three-way merge option.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>OverridePullRequestApprovalRules</a>, which sets aside all approval rule requirements
    /// for a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>PostCommentForPullRequest</a>, which posts a comment to a pull request at the
    /// specified line, file, or request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestApprovalRuleContent</a>, which updates the structure of an approval
    /// rule for a pull request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdatePullRequestApprovalState</a>, which updates the state of an approval on
    /// a pull request.
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
    /// Approval rule templates, by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>AssociateApprovalRuleTemplateWithRepository</a>, which associates a template with
    /// a specified repository. After the template is associated with a repository, AWS CodeCommit
    /// creates approval rules that match the template conditions on every pull request created
    /// in the specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchAssociateApprovalRuleTemplateWithRepositories</a>, which associates a template
    /// with one or more specified repositories. After the template is associated with a repository,
    /// AWS CodeCommit creates approval rules that match the template conditions on every
    /// pull request created in the specified repositories.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>BatchDisassociateApprovalRuleTemplateFromRepositories</a>, which removes the association
    /// between a template and specified repositories so that approval rules based on the
    /// template are not automatically created when pull requests are created in those repositories.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateApprovalRuleTemplate</a>, which creates a template for approval rules that
    /// can then be associated with one or more repositories in your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteApprovalRuleTemplate</a>, which deletes the specified template. It does
    /// not remove approval rules on pull requests already created with the template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DisassociateApprovalRuleTemplateFromRepository</a>, which removes the association
    /// between a template and a repository so that approval rules based on the template are
    /// not automatically created when pull requests are created in the specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>GetApprovalRuleTemplate</a>, which returns information about an approval rule
    /// template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListApprovalRuleTemplates</a>, which lists all approval rule templates in the
    /// AWS Region in your AWS account.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListAssociatedApprovalRuleTemplatesForRepository</a>, which lists all approval
    /// rule templates that are associated with a specified repository.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListRepositoriesForApprovalRuleTemplate</a>, which lists all repositories associated
    /// with the specified approval rule template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateApprovalRuleTemplateDescription</a>, which updates the description of an
    /// approval rule template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateApprovalRuleTemplateName</a>, which updates the name of an approval rule
    /// template.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateApprovalRuleTemplateContent</a>, which updates the content of an approval
    /// rule template.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// Comments in a repository, by calling the following:
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
    /// Tags used to tag resources in AWS CodeCommit (not Git tags), by calling the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>ListTagsForResource</a>, which gets information about AWS tags for a specified
    /// Amazon Resource Name (ARN) in AWS CodeCommit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>TagResource</a>, which adds or updates tags for a resource in AWS CodeCommit.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UntagResource</a>, which removes tags for a resource in AWS CodeCommit.
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
    /// For information about how to use AWS CodeCommit, see the <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
    /// CodeCommit User Guide</a>.
    /// </para>
    /// </summary>
    public partial interface IAmazonCodeCommit : IAmazonService, IDisposable
    {

        
        #region  AssociateApprovalRuleTemplateWithRepository


        /// <summary>
        /// Creates an association between an approval rule template and a specified repository.
        /// Then, the next time a pull request is created in the repository where the destination
        /// reference (if specified) matches the destination reference (branch) for the pull request,
        /// an approval rule that matches the template conditions is automatically created for
        /// that pull request. If no destination references are specified in the template, an
        /// approval rule that matches the template contents is created for all pull requests
        /// in that repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovalRuleTemplateWithRepository service method.</param>
        /// 
        /// <returns>The response from the AssociateApprovalRuleTemplateWithRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRuleTemplatesAssociatedWithRepositoryException">
        /// The maximum number of approval rule templates for a repository has been exceeded.
        /// You cannot associate more than 25 approval rule templates with a repository.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/AssociateApprovalRuleTemplateWithRepository">REST API Reference for AssociateApprovalRuleTemplateWithRepository Operation</seealso>
        AssociateApprovalRuleTemplateWithRepositoryResponse AssociateApprovalRuleTemplateWithRepository(AssociateApprovalRuleTemplateWithRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateApprovalRuleTemplateWithRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateApprovalRuleTemplateWithRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateApprovalRuleTemplateWithRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/AssociateApprovalRuleTemplateWithRepository">REST API Reference for AssociateApprovalRuleTemplateWithRepository Operation</seealso>
        IAsyncResult BeginAssociateApprovalRuleTemplateWithRepository(AssociateApprovalRuleTemplateWithRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateApprovalRuleTemplateWithRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateApprovalRuleTemplateWithRepository.</param>
        /// 
        /// <returns>Returns a  AssociateApprovalRuleTemplateWithRepositoryResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/AssociateApprovalRuleTemplateWithRepository">REST API Reference for AssociateApprovalRuleTemplateWithRepository Operation</seealso>
        AssociateApprovalRuleTemplateWithRepositoryResponse EndAssociateApprovalRuleTemplateWithRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchAssociateApprovalRuleTemplateWithRepositories


        /// <summary>
        /// Creates an association between an approval rule template and one or more specified
        /// repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateApprovalRuleTemplateWithRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchAssociateApprovalRuleTemplateWithRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchAssociateApprovalRuleTemplateWithRepositories">REST API Reference for BatchAssociateApprovalRuleTemplateWithRepositories Operation</seealso>
        BatchAssociateApprovalRuleTemplateWithRepositoriesResponse BatchAssociateApprovalRuleTemplateWithRepositories(BatchAssociateApprovalRuleTemplateWithRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchAssociateApprovalRuleTemplateWithRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchAssociateApprovalRuleTemplateWithRepositories operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchAssociateApprovalRuleTemplateWithRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchAssociateApprovalRuleTemplateWithRepositories">REST API Reference for BatchAssociateApprovalRuleTemplateWithRepositories Operation</seealso>
        IAsyncResult BeginBatchAssociateApprovalRuleTemplateWithRepositories(BatchAssociateApprovalRuleTemplateWithRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchAssociateApprovalRuleTemplateWithRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchAssociateApprovalRuleTemplateWithRepositories.</param>
        /// 
        /// <returns>Returns a  BatchAssociateApprovalRuleTemplateWithRepositoriesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchAssociateApprovalRuleTemplateWithRepositories">REST API Reference for BatchAssociateApprovalRuleTemplateWithRepositories Operation</seealso>
        BatchAssociateApprovalRuleTemplateWithRepositoriesResponse EndBatchAssociateApprovalRuleTemplateWithRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDescribeMergeConflicts


        /// <summary>
        /// Returns information about one or more merge conflicts in the attempted merge of two
        /// commit specifiers using the squash or three-way merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeMergeConflicts service method.</param>
        /// 
        /// <returns>The response from the BatchDescribeMergeConflicts service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxConflictFilesException">
        /// The specified value for the number of conflict files to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxMergeHunksException">
        /// The specified value for the number of merge hunks to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDescribeMergeConflicts">REST API Reference for BatchDescribeMergeConflicts Operation</seealso>
        BatchDescribeMergeConflictsResponse BatchDescribeMergeConflicts(BatchDescribeMergeConflictsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDescribeMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDescribeMergeConflicts operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDescribeMergeConflicts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDescribeMergeConflicts">REST API Reference for BatchDescribeMergeConflicts Operation</seealso>
        IAsyncResult BeginBatchDescribeMergeConflicts(BatchDescribeMergeConflictsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDescribeMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDescribeMergeConflicts.</param>
        /// 
        /// <returns>Returns a  BatchDescribeMergeConflictsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDescribeMergeConflicts">REST API Reference for BatchDescribeMergeConflicts Operation</seealso>
        BatchDescribeMergeConflictsResponse EndBatchDescribeMergeConflicts(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchDisassociateApprovalRuleTemplateFromRepositories


        /// <summary>
        /// Removes the association between an approval rule template and one or more specified
        /// repositories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateApprovalRuleTemplateFromRepositories service method.</param>
        /// 
        /// <returns>The response from the BatchDisassociateApprovalRuleTemplateFromRepositories service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDisassociateApprovalRuleTemplateFromRepositories">REST API Reference for BatchDisassociateApprovalRuleTemplateFromRepositories Operation</seealso>
        BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse BatchDisassociateApprovalRuleTemplateFromRepositories(BatchDisassociateApprovalRuleTemplateFromRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchDisassociateApprovalRuleTemplateFromRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchDisassociateApprovalRuleTemplateFromRepositories operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchDisassociateApprovalRuleTemplateFromRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDisassociateApprovalRuleTemplateFromRepositories">REST API Reference for BatchDisassociateApprovalRuleTemplateFromRepositories Operation</seealso>
        IAsyncResult BeginBatchDisassociateApprovalRuleTemplateFromRepositories(BatchDisassociateApprovalRuleTemplateFromRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchDisassociateApprovalRuleTemplateFromRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchDisassociateApprovalRuleTemplateFromRepositories.</param>
        /// 
        /// <returns>Returns a  BatchDisassociateApprovalRuleTemplateFromRepositoriesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchDisassociateApprovalRuleTemplateFromRepositories">REST API Reference for BatchDisassociateApprovalRuleTemplateFromRepositories Operation</seealso>
        BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse EndBatchDisassociateApprovalRuleTemplateFromRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetCommits


        /// <summary>
        /// Returns information about the contents of one or more commits in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommits service method.</param>
        /// 
        /// <returns>The response from the BatchGetCommits service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdsLimitExceededException">
        /// The maximum number of allowed commit IDs in a batch request is 100. Verify that your
        /// batch requests contains no more than 100 commit IDs, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitIdsListRequiredException">
        /// A list of commit IDs is required, but was either not specified or the list was empty.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetCommits">REST API Reference for BatchGetCommits Operation</seealso>
        BatchGetCommitsResponse BatchGetCommits(BatchGetCommitsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetCommits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetCommits operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetCommits
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetCommits">REST API Reference for BatchGetCommits Operation</seealso>
        IAsyncResult BeginBatchGetCommits(BatchGetCommitsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetCommits operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetCommits.</param>
        /// 
        /// <returns>Returns a  BatchGetCommitsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetCommits">REST API Reference for BatchGetCommits Operation</seealso>
        BatchGetCommitsResponse EndBatchGetCommits(IAsyncResult asyncResult);

        #endregion
        
        #region  BatchGetRepositories


        /// <summary>
        /// Returns information about one or more repositories.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumRepositoryNamesExceededException">
        /// The maximum number of allowed repository names was exceeded. Currently, this number
        /// is 100.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNamesRequiredException">
        /// At least one repository name object is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        BatchGetRepositoriesResponse BatchGetRepositories(BatchGetRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BatchGetRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BatchGetRepositories operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBatchGetRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        IAsyncResult BeginBatchGetRepositories(BatchGetRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BatchGetRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBatchGetRepositories.</param>
        /// 
        /// <returns>Returns a  BatchGetRepositoriesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/BatchGetRepositories">REST API Reference for BatchGetRepositories Operation</seealso>
        BatchGetRepositoriesResponse EndBatchGetRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateApprovalRuleTemplate


        /// <summary>
        /// Creates a template for approval rules that can then be associated with one or more
        /// repositories in your AWS account. When you associate a template with a repository,
        /// AWS CodeCommit creates an approval rule that matches the conditions of the template
        /// for all pull requests that meet the conditions of the template. For more information,
        /// see <a>AssociateApprovalRuleTemplateWithRepository</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateContentRequiredException">
        /// The content for the approval rule template is empty. You must provide some content
        /// for an approval rule template. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameAlreadyExistsException">
        /// You cannot create an approval rule template with that name because a template with
        /// that name already exists in this AWS Region for your AWS account. Approval rule template
        /// names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateContentException">
        /// The content of the approval rule template is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateDescriptionException">
        /// The description for the approval rule template is not valid because it exceeds the
        /// maximum characters allowed for a description. For more information about limits in
        /// AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NumberOfRuleTemplatesExceededException">
        /// The maximum number of approval rule templates has been exceeded for this AWS Region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateApprovalRuleTemplate">REST API Reference for CreateApprovalRuleTemplate Operation</seealso>
        CreateApprovalRuleTemplateResponse CreateApprovalRuleTemplate(CreateApprovalRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalRuleTemplate operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApprovalRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateApprovalRuleTemplate">REST API Reference for CreateApprovalRuleTemplate Operation</seealso>
        IAsyncResult BeginCreateApprovalRuleTemplate(CreateApprovalRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApprovalRuleTemplate.</param>
        /// 
        /// <returns>Returns a  CreateApprovalRuleTemplateResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateApprovalRuleTemplate">REST API Reference for CreateApprovalRuleTemplate Operation</seealso>
        CreateApprovalRuleTemplateResponse EndCreateApprovalRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateBranch


        /// <summary>
        /// Creates a branch in a repository and points the branch to a commit.
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
        /// A branch name is required, but was not specified.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        CreateBranchResponse CreateBranch(CreateBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        IAsyncResult BeginCreateBranch(CreateBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateBranch.</param>
        /// 
        /// <returns>Returns a  CreateBranchResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateBranch">REST API Reference for CreateBranch Operation</seealso>
        CreateBranchResponse EndCreateBranch(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCommit


        /// <summary>
        /// Creates a commit for a repository on the tip of a specified branch.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCommit service method.</param>
        /// 
        /// <returns>The response from the CreateCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.FileContentAndSourceFileSpecifiedException">
        /// The commit cannot be created because both a source file and file content have been
        /// specified for the same file. You cannot provide both. Either specify a source file
        /// or provide the file content directly.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileEntryRequiredException">
        /// The commit cannot be created because no files have been specified as added, updated,
        /// or changed (PutFile or DeleteFile) for the commit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The commit cannot be created because a specified file path points to a submodule.
        /// Verify that the destination files have valid file paths that do not point to a submodule.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileEntriesExceededException">
        /// The number of specified files to change as part of this commit exceeds the maximum
        /// number of files that can be changed in a single commit. Consider using a Git client
        /// for these changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NoChangeException">
        /// The commit cannot be created because no changes will be made to the repository as
        /// a result of this commit. A commit must contain at least one change.
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
        /// <exception cref="Amazon.CodeCommit.Model.PutFileEntryConflictException">
        /// The commit cannot be created because one or more files specified in the commit reference
        /// both a file and a folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RestrictedSourceFileException">
        /// The commit cannot be created because one of the changes specifies copying or moving
        /// a .gitkeep file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SamePathRequestException">
        /// The commit cannot be created because one or more changes in this commit duplicate
        /// actions in the same file path. For example, you cannot make the same delete request
        /// to the same file in the same file path twice, or make a delete request and a move
        /// request to the same file as part of the same commit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceFileOrContentRequiredException">
        /// The commit cannot be created because no source files or file content have been specified
        /// for the commit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateCommit">REST API Reference for CreateCommit Operation</seealso>
        CreateCommitResponse CreateCommit(CreateCommitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCommit operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCommit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateCommit">REST API Reference for CreateCommit Operation</seealso>
        IAsyncResult BeginCreateCommit(CreateCommitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCommit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCommit.</param>
        /// 
        /// <returns>Returns a  CreateCommitResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateCommit">REST API Reference for CreateCommit Operation</seealso>
        CreateCommitResponse EndCreateCommit(IAsyncResult asyncResult);

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
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
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
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions cannot be more than 1,000
        /// characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReferenceNameException">
        /// The specified reference name format is not valid. Reference names must conform to
        /// the Git references format (for example, refs/heads/master). For more information,
        /// see <a href="https://git-scm.com/book/en/v2/Git-Internals-Git-References">Git Internals
        /// - Git References</a> or consult your Git documentation.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.SourceAndDestinationAreSameException">
        /// The source branch and destination branch for the pull request are the same. You must
        /// specify different branches for the source and destination.
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
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequest operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePullRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        IAsyncResult BeginCreatePullRequest(CreatePullRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePullRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePullRequest.</param>
        /// 
        /// <returns>Returns a  CreatePullRequestResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequest">REST API Reference for CreatePullRequest Operation</seealso>
        CreatePullRequestResponse EndCreatePullRequest(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePullRequestApprovalRule


        /// <summary>
        /// Creates an approval rule for a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequestApprovalRule service method.</param>
        /// 
        /// <returns>The response from the CreatePullRequestApprovalRule service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleContentRequiredException">
        /// The content for the approval rule is empty. You must provide some content for an approval
        /// rule. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameAlreadyExistsException">
        /// An approval rule with that name already exists. Approval rule names must be unique
        /// within the scope of a pull request.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleContentException">
        /// The content for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NumberOfRulesExceededException">
        /// The approval rule cannot be added. The pull request has the maximum number of approval
        /// rules associated with it.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequestApprovalRule">REST API Reference for CreatePullRequestApprovalRule Operation</seealso>
        CreatePullRequestApprovalRuleResponse CreatePullRequestApprovalRule(CreatePullRequestApprovalRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePullRequestApprovalRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePullRequestApprovalRule operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePullRequestApprovalRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequestApprovalRule">REST API Reference for CreatePullRequestApprovalRule Operation</seealso>
        IAsyncResult BeginCreatePullRequestApprovalRule(CreatePullRequestApprovalRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePullRequestApprovalRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePullRequestApprovalRule.</param>
        /// 
        /// <returns>Returns a  CreatePullRequestApprovalRuleResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreatePullRequestApprovalRule">REST API Reference for CreatePullRequestApprovalRule Operation</seealso>
        CreatePullRequestApprovalRuleResponse EndCreatePullRequestApprovalRule(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagsMapException">
        /// The map of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryLimitExceededException">
        /// A repository resource limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameExistsException">
        /// The specified repository name already exists.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an AWS CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        IAsyncResult BeginCreateRepository(CreateRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRepository.</param>
        /// 
        /// <returns>Returns a  CreateRepositoryResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        CreateRepositoryResponse EndCreateRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateUnreferencedMergeCommit


        /// <summary>
        /// Creates an unreferenced commit that represents the result of merging two branches
        /// using a specified merge strategy. This can help you determine the outcome of a potential
        /// merge. This API cannot be used with the fast-forward merge strategy because that strategy
        /// does not create a merge commit.
        /// 
        ///  <note> 
        /// <para>
        /// This unreferenced merge commit can only be accessed using the GetCommit API or through
        /// git commands such as git fetch. To retrieve this commit, you must specify its commit
        /// ID or otherwise reference it.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateUnreferencedMergeCommit service method.</param>
        /// 
        /// <returns>The response from the CreateUnreferencedMergeCommit service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateUnreferencedMergeCommit">REST API Reference for CreateUnreferencedMergeCommit Operation</seealso>
        CreateUnreferencedMergeCommitResponse CreateUnreferencedMergeCommit(CreateUnreferencedMergeCommitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateUnreferencedMergeCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateUnreferencedMergeCommit operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateUnreferencedMergeCommit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateUnreferencedMergeCommit">REST API Reference for CreateUnreferencedMergeCommit Operation</seealso>
        IAsyncResult BeginCreateUnreferencedMergeCommit(CreateUnreferencedMergeCommitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateUnreferencedMergeCommit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateUnreferencedMergeCommit.</param>
        /// 
        /// <returns>Returns a  CreateUnreferencedMergeCommitResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/CreateUnreferencedMergeCommit">REST API Reference for CreateUnreferencedMergeCommit Operation</seealso>
        CreateUnreferencedMergeCommitResponse EndCreateUnreferencedMergeCommit(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteApprovalRuleTemplate


        /// <summary>
        /// Deletes a specified approval rule template. Deleting a template does not remove approval
        /// rules on pull requests already created with the template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateInUseException">
        /// The approval rule template is associated with one or more repositories. You cannot
        /// delete a template that is associated with a repository. Remove all associations, and
        /// then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteApprovalRuleTemplate">REST API Reference for DeleteApprovalRuleTemplate Operation</seealso>
        DeleteApprovalRuleTemplateResponse DeleteApprovalRuleTemplate(DeleteApprovalRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApprovalRuleTemplate operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteApprovalRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteApprovalRuleTemplate">REST API Reference for DeleteApprovalRuleTemplate Operation</seealso>
        IAsyncResult BeginDeleteApprovalRuleTemplate(DeleteApprovalRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteApprovalRuleTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteApprovalRuleTemplateResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteApprovalRuleTemplate">REST API Reference for DeleteApprovalRuleTemplate Operation</seealso>
        DeleteApprovalRuleTemplateResponse EndDeleteApprovalRuleTemplate(IAsyncResult asyncResult);

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
        /// A branch name is required, but was not specified.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        DeleteBranchResponse DeleteBranch(DeleteBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        IAsyncResult BeginDeleteBranch(DeleteBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBranch.</param>
        /// 
        /// <returns>Returns a  DeleteBranchResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteBranch">REST API Reference for DeleteBranch Operation</seealso>
        DeleteBranchResponse EndDeleteBranch(IAsyncResult asyncResult);

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
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteCommentContent operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCommentContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        IAsyncResult BeginDeleteCommentContent(DeleteCommentContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCommentContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCommentContent.</param>
        /// 
        /// <returns>Returns a  DeleteCommentContentResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteCommentContent">REST API Reference for DeleteCommentContent Operation</seealso>
        DeleteCommentContentResponse EndDeleteCommentContent(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFile


        /// <summary>
        /// Deletes a specified file from a specified branch. A commit is created on the branch
        /// that contains the revision. The file still exists in the commits earlier to the commit
        /// that contains the deletion.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile service method.</param>
        /// 
        /// <returns>The response from the DeleteFile service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
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
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        DeleteFileResponse DeleteFile(DeleteFileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFile operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        IAsyncResult BeginDeleteFile(DeleteFileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFile.</param>
        /// 
        /// <returns>Returns a  DeleteFileResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteFile">REST API Reference for DeleteFile Operation</seealso>
        DeleteFileResponse EndDeleteFile(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePullRequestApprovalRule


        /// <summary>
        /// Deletes an approval rule from a specified pull request. Approval rules can be deleted
        /// from a pull request only if the pull request is open, and if the approval rule was
        /// created specifically for a pull request and not generated from an approval rule template
        /// associated with the repository where the pull request was created. You cannot delete
        /// an approval rule from a merged or closed pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePullRequestApprovalRule service method.</param>
        /// 
        /// <returns>The response from the DeletePullRequestApprovalRule service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CannotDeleteApprovalRuleFromTemplateException">
        /// The approval rule cannot be deleted from the pull request because it was created by
        /// an approval rule template and applied to the pull request automatically.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeletePullRequestApprovalRule">REST API Reference for DeletePullRequestApprovalRule Operation</seealso>
        DeletePullRequestApprovalRuleResponse DeletePullRequestApprovalRule(DeletePullRequestApprovalRuleRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePullRequestApprovalRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePullRequestApprovalRule operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePullRequestApprovalRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeletePullRequestApprovalRule">REST API Reference for DeletePullRequestApprovalRule Operation</seealso>
        IAsyncResult BeginDeletePullRequestApprovalRule(DeletePullRequestApprovalRuleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePullRequestApprovalRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePullRequestApprovalRule.</param>
        /// 
        /// <returns>Returns a  DeletePullRequestApprovalRuleResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeletePullRequestApprovalRule">REST API Reference for DeletePullRequestApprovalRule Operation</seealso>
        DeletePullRequestApprovalRuleResponse EndDeletePullRequestApprovalRule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRepository


        /// <summary>
        /// Deletes a repository. If a specified repository was already deleted, a null repository
        /// ID is returned.
        /// 
        ///  <important> 
        /// <para>
        /// Deleting a repository also deletes all associated objects and metadata. After a repository
        /// is deleted, all future push calls to the deleted repository fail.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        IAsyncResult BeginDeleteRepository(DeleteRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepository.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        DeleteRepositoryResponse EndDeleteRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMergeConflicts


        /// <summary>
        /// Returns information about one or more merge conflicts in the attempted merge of two
        /// commit specifiers using the squash or three-way merge strategy. If the merge option
        /// for the attempted merge is specified as FAST_FORWARD_MERGE, an exception is thrown.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMergeConflicts service method.</param>
        /// 
        /// <returns>The response from the DescribeMergeConflicts service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.FileDoesNotExistException">
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxMergeHunksException">
        /// The specified value for the number of merge hunks to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribeMergeConflicts">REST API Reference for DescribeMergeConflicts Operation</seealso>
        DescribeMergeConflictsResponse DescribeMergeConflicts(DescribeMergeConflictsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMergeConflicts operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMergeConflicts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribeMergeConflicts">REST API Reference for DescribeMergeConflicts Operation</seealso>
        IAsyncResult BeginDescribeMergeConflicts(DescribeMergeConflictsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMergeConflicts.</param>
        /// 
        /// <returns>Returns a  DescribeMergeConflictsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribeMergeConflicts">REST API Reference for DescribeMergeConflicts Operation</seealso>
        DescribeMergeConflictsResponse EndDescribeMergeConflicts(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the DescribePullRequestEvents operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePullRequestEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        IAsyncResult BeginDescribePullRequestEvents(DescribePullRequestEventsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePullRequestEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePullRequestEvents.</param>
        /// 
        /// <returns>Returns a  DescribePullRequestEventsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DescribePullRequestEvents">REST API Reference for DescribePullRequestEvents Operation</seealso>
        DescribePullRequestEventsResponse EndDescribePullRequestEvents(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateApprovalRuleTemplateFromRepository


        /// <summary>
        /// Removes the association between a template and a repository so that approval rules
        /// based on the template are not automatically created when pull requests are created
        /// in the specified repository. This does not delete any approval rules previously created
        /// for pull requests through the template association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovalRuleTemplateFromRepository service method.</param>
        /// 
        /// <returns>The response from the DisassociateApprovalRuleTemplateFromRepository service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DisassociateApprovalRuleTemplateFromRepository">REST API Reference for DisassociateApprovalRuleTemplateFromRepository Operation</seealso>
        DisassociateApprovalRuleTemplateFromRepositoryResponse DisassociateApprovalRuleTemplateFromRepository(DisassociateApprovalRuleTemplateFromRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateApprovalRuleTemplateFromRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateApprovalRuleTemplateFromRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateApprovalRuleTemplateFromRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DisassociateApprovalRuleTemplateFromRepository">REST API Reference for DisassociateApprovalRuleTemplateFromRepository Operation</seealso>
        IAsyncResult BeginDisassociateApprovalRuleTemplateFromRepository(DisassociateApprovalRuleTemplateFromRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateApprovalRuleTemplateFromRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateApprovalRuleTemplateFromRepository.</param>
        /// 
        /// <returns>Returns a  DisassociateApprovalRuleTemplateFromRepositoryResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/DisassociateApprovalRuleTemplateFromRepository">REST API Reference for DisassociateApprovalRuleTemplateFromRepository Operation</seealso>
        DisassociateApprovalRuleTemplateFromRepositoryResponse EndDisassociateApprovalRuleTemplateFromRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  EvaluatePullRequestApprovalRules


        /// <summary>
        /// Evaluates whether a pull request has met all the conditions specified in its associated
        /// approval rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EvaluatePullRequestApprovalRules service method.</param>
        /// 
        /// <returns>The response from the EvaluatePullRequestApprovalRules service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/EvaluatePullRequestApprovalRules">REST API Reference for EvaluatePullRequestApprovalRules Operation</seealso>
        EvaluatePullRequestApprovalRulesResponse EvaluatePullRequestApprovalRules(EvaluatePullRequestApprovalRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EvaluatePullRequestApprovalRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EvaluatePullRequestApprovalRules operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEvaluatePullRequestApprovalRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/EvaluatePullRequestApprovalRules">REST API Reference for EvaluatePullRequestApprovalRules Operation</seealso>
        IAsyncResult BeginEvaluatePullRequestApprovalRules(EvaluatePullRequestApprovalRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EvaluatePullRequestApprovalRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEvaluatePullRequestApprovalRules.</param>
        /// 
        /// <returns>Returns a  EvaluatePullRequestApprovalRulesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/EvaluatePullRequestApprovalRules">REST API Reference for EvaluatePullRequestApprovalRules Operation</seealso>
        EvaluatePullRequestApprovalRulesResponse EndEvaluatePullRequestApprovalRules(IAsyncResult asyncResult);

        #endregion
        
        #region  GetApprovalRuleTemplate


        /// <summary>
        /// Returns information about a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the GetApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetApprovalRuleTemplate">REST API Reference for GetApprovalRuleTemplate Operation</seealso>
        GetApprovalRuleTemplateResponse GetApprovalRuleTemplate(GetApprovalRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalRuleTemplate operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApprovalRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetApprovalRuleTemplate">REST API Reference for GetApprovalRuleTemplate Operation</seealso>
        IAsyncResult BeginGetApprovalRuleTemplate(GetApprovalRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApprovalRuleTemplate.</param>
        /// 
        /// <returns>Returns a  GetApprovalRuleTemplateResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetApprovalRuleTemplate">REST API Reference for GetApprovalRuleTemplate Operation</seealso>
        GetApprovalRuleTemplateResponse EndGetApprovalRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  GetBlob


        /// <summary>
        /// Returns the base-64 encoded content of an individual blob in a repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBlob service method.</param>
        /// 
        /// <returns>The response from the GetBlob service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdDoesNotExistException">
        /// The specified blob does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BlobIdRequiredException">
        /// A blob ID is required, but was not specified.
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
        /// about limits in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBlobIdException">
        /// The specified blob is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        GetBlobResponse GetBlob(GetBlobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBlob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBlob operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBlob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        IAsyncResult BeginGetBlob(GetBlobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBlob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBlob.</param>
        /// 
        /// <returns>Returns a  GetBlobResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBlob">REST API Reference for GetBlob Operation</seealso>
        GetBlobResponse EndGetBlob(IAsyncResult asyncResult);

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
        /// A branch name is required, but was not specified.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        GetBranchResponse GetBranch(GetBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        IAsyncResult BeginGetBranch(GetBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBranch.</param>
        /// 
        /// <returns>Returns a  GetBranchResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetBranch">REST API Reference for GetBranch Operation</seealso>
        GetBranchResponse EndGetBranch(IAsyncResult asyncResult);

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
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
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
        /// <param name="request">Container for the necessary parameters to execute the GetComment operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        IAsyncResult BeginGetComment(GetCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComment.</param>
        /// 
        /// <returns>Returns a  GetCommentResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetComment">REST API Reference for GetComment Operation</seealso>
        GetCommentResponse EndGetComment(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        GetCommentsForComparedCommitResponse GetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCommentsForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForComparedCommit operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCommentsForComparedCommit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        IAsyncResult BeginGetCommentsForComparedCommit(GetCommentsForComparedCommitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCommentsForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCommentsForComparedCommit.</param>
        /// 
        /// <returns>Returns a  GetCommentsForComparedCommitResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForComparedCommit">REST API Reference for GetCommentsForComparedCommit Operation</seealso>
        GetCommentsForComparedCommitResponse EndGetCommentsForComparedCommit(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        GetCommentsForPullRequestResponse GetCommentsForPullRequest(GetCommentsForPullRequestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCommentsForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommentsForPullRequest operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCommentsForPullRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        IAsyncResult BeginGetCommentsForPullRequest(GetCommentsForPullRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCommentsForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCommentsForPullRequest.</param>
        /// 
        /// <returns>Returns a  GetCommentsForPullRequestResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommentsForPullRequest">REST API Reference for GetCommentsForPullRequest Operation</seealso>
        GetCommentsForPullRequestResponse EndGetCommentsForPullRequest(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        GetCommitResponse GetCommit(GetCommitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCommit operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCommit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        IAsyncResult BeginGetCommit(GetCommitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetCommit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCommit.</param>
        /// 
        /// <returns>Returns a  GetCommitResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetCommit">REST API Reference for GetCommit Operation</seealso>
        GetCommitResponse EndGetCommit(IAsyncResult asyncResult);

        #endregion
        
        #region  GetDifferences


        /// <summary>
        /// Returns information about the differences in a valid commit specifier (such as a branch,
        /// tag, HEAD, commit ID, or other fully qualified reference). Results can be limited
        /// to a specified path.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        GetDifferencesResponse GetDifferences(GetDifferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetDifferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDifferences operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDifferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        IAsyncResult BeginGetDifferences(GetDifferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetDifferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDifferences.</param>
        /// 
        /// <returns>Returns a  GetDifferencesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetDifferences">REST API Reference for GetDifferences Operation</seealso>
        GetDifferencesResponse EndGetDifferences(IAsyncResult asyncResult);

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
        /// The specified file does not exist. Verify that you have used the correct file name,
        /// full path, and extension.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileTooLargeException">
        /// The specified file exceeds the file size limit for AWS CodeCommit. For more information
        /// about limits in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        GetFileResponse GetFile(GetFileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFile operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        IAsyncResult BeginGetFile(GetFileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFile.</param>
        /// 
        /// <returns>Returns a  GetFileResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFile">REST API Reference for GetFile Operation</seealso>
        GetFileResponse EndGetFile(IAsyncResult asyncResult);

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
        /// did not enter the full path to the folder.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        GetFolderResponse GetFolder(GetFolderRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetFolder operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetFolder operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetFolder
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        IAsyncResult BeginGetFolder(GetFolderRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetFolder operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetFolder.</param>
        /// 
        /// <returns>Returns a  GetFolderResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetFolder">REST API Reference for GetFolder Operation</seealso>
        GetFolderResponse EndGetFolder(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMergeCommit


        /// <summary>
        /// Returns information about a specified merge commit.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeCommit service method.</param>
        /// 
        /// <returns>The response from the GetMergeCommit service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeCommit">REST API Reference for GetMergeCommit Operation</seealso>
        GetMergeCommitResponse GetMergeCommit(GetMergeCommitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMergeCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMergeCommit operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMergeCommit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeCommit">REST API Reference for GetMergeCommit Operation</seealso>
        IAsyncResult BeginGetMergeCommit(GetMergeCommitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMergeCommit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMergeCommit.</param>
        /// 
        /// <returns>Returns a  GetMergeCommitResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeCommit">REST API Reference for GetMergeCommit Operation</seealso>
        GetMergeCommitResponse EndGetMergeCommit(IAsyncResult asyncResult);

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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDestinationCommitSpecifierException">
        /// The destination commit specifier is not valid. You must provide a valid branch name,
        /// tag, or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxConflictFilesException">
        /// The specified value for the number of conflict files to return is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMergeOptionException">
        /// The specified merge option is not valid for this operation. Not all merge strategies
        /// are supported for all operations.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSourceCommitSpecifierException">
        /// The source commit specifier is not valid. You must provide a valid branch name, tag,
        /// or full commit ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MergeOptionRequiredException">
        /// A merge option or stategy is required, and none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
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
        /// <param name="request">Container for the necessary parameters to execute the GetMergeConflicts operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMergeConflicts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        IAsyncResult BeginGetMergeConflicts(GetMergeConflictsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMergeConflicts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMergeConflicts.</param>
        /// 
        /// <returns>Returns a  GetMergeConflictsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeConflicts">REST API Reference for GetMergeConflicts Operation</seealso>
        GetMergeConflictsResponse EndGetMergeConflicts(IAsyncResult asyncResult);

        #endregion
        
        #region  GetMergeOptions


        /// <summary>
        /// Returns information about the merge options available for merging two specified branches.
        /// For details about why a merge option is not available, use GetMergeConflicts or DescribeMergeConflicts.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMergeOptions service method.</param>
        /// 
        /// <returns>The response from the GetMergeOptions service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeOptions">REST API Reference for GetMergeOptions Operation</seealso>
        GetMergeOptionsResponse GetMergeOptions(GetMergeOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetMergeOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetMergeOptions operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetMergeOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeOptions">REST API Reference for GetMergeOptions Operation</seealso>
        IAsyncResult BeginGetMergeOptions(GetMergeOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetMergeOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetMergeOptions.</param>
        /// 
        /// <returns>Returns a  GetMergeOptionsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetMergeOptions">REST API Reference for GetMergeOptions Operation</seealso>
        GetMergeOptionsResponse EndGetMergeOptions(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequest operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPullRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        IAsyncResult BeginGetPullRequest(GetPullRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPullRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPullRequest.</param>
        /// 
        /// <returns>Returns a  GetPullRequestResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequest">REST API Reference for GetPullRequest Operation</seealso>
        GetPullRequestResponse EndGetPullRequest(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPullRequestApprovalStates


        /// <summary>
        /// Gets information about the approval states for a specified pull request. Approval
        /// states only apply to pull requests that have one or more approval rules applied to
        /// them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestApprovalStates service method.</param>
        /// 
        /// <returns>The response from the GetPullRequestApprovalStates service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestApprovalStates">REST API Reference for GetPullRequestApprovalStates Operation</seealso>
        GetPullRequestApprovalStatesResponse GetPullRequestApprovalStates(GetPullRequestApprovalStatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPullRequestApprovalStates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestApprovalStates operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPullRequestApprovalStates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestApprovalStates">REST API Reference for GetPullRequestApprovalStates Operation</seealso>
        IAsyncResult BeginGetPullRequestApprovalStates(GetPullRequestApprovalStatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPullRequestApprovalStates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPullRequestApprovalStates.</param>
        /// 
        /// <returns>Returns a  GetPullRequestApprovalStatesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestApprovalStates">REST API Reference for GetPullRequestApprovalStates Operation</seealso>
        GetPullRequestApprovalStatesResponse EndGetPullRequestApprovalStates(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPullRequestOverrideState


        /// <summary>
        /// Returns information about whether approval rules have been set aside (overridden)
        /// for a pull request, and if so, the Amazon Resource Name (ARN) of the user or identity
        /// that overrode the rules and their requirements for the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestOverrideState service method.</param>
        /// 
        /// <returns>The response from the GetPullRequestOverrideState service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestOverrideState">REST API Reference for GetPullRequestOverrideState Operation</seealso>
        GetPullRequestOverrideStateResponse GetPullRequestOverrideState(GetPullRequestOverrideStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPullRequestOverrideState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPullRequestOverrideState operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPullRequestOverrideState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestOverrideState">REST API Reference for GetPullRequestOverrideState Operation</seealso>
        IAsyncResult BeginGetPullRequestOverrideState(GetPullRequestOverrideStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPullRequestOverrideState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPullRequestOverrideState.</param>
        /// 
        /// <returns>Returns a  GetPullRequestOverrideStateResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetPullRequestOverrideState">REST API Reference for GetPullRequestOverrideState Operation</seealso>
        GetPullRequestOverrideStateResponse EndGetPullRequestOverrideState(IAsyncResult asyncResult);

        #endregion
        
        #region  GetRepository


        /// <summary>
        /// Returns information about a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        GetRepositoryResponse GetRepository(GetRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        IAsyncResult BeginGetRepository(GetRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepository.</param>
        /// 
        /// <returns>Returns a  GetRepositoryResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepository">REST API Reference for GetRepository Operation</seealso>
        GetRepositoryResponse EndGetRepository(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        GetRepositoryTriggersResponse GetRepositoryTriggers(GetRepositoryTriggersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositoryTriggers operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositoryTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        IAsyncResult BeginGetRepositoryTriggers(GetRepositoryTriggersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositoryTriggers.</param>
        /// 
        /// <returns>Returns a  GetRepositoryTriggersResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/GetRepositoryTriggers">REST API Reference for GetRepositoryTriggers Operation</seealso>
        GetRepositoryTriggersResponse EndGetRepositoryTriggers(IAsyncResult asyncResult);

        #endregion
        
        #region  ListApprovalRuleTemplates


        /// <summary>
        /// Lists all approval rule templates in the specified AWS Region in your AWS account.
        /// If an AWS Region is not specified, the AWS Region where you are signed in is used.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalRuleTemplates service method.</param>
        /// 
        /// <returns>The response from the ListApprovalRuleTemplates service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListApprovalRuleTemplates">REST API Reference for ListApprovalRuleTemplates Operation</seealso>
        ListApprovalRuleTemplatesResponse ListApprovalRuleTemplates(ListApprovalRuleTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListApprovalRuleTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalRuleTemplates operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApprovalRuleTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListApprovalRuleTemplates">REST API Reference for ListApprovalRuleTemplates Operation</seealso>
        IAsyncResult BeginListApprovalRuleTemplates(ListApprovalRuleTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListApprovalRuleTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApprovalRuleTemplates.</param>
        /// 
        /// <returns>Returns a  ListApprovalRuleTemplatesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListApprovalRuleTemplates">REST API Reference for ListApprovalRuleTemplates Operation</seealso>
        ListApprovalRuleTemplatesResponse EndListApprovalRuleTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAssociatedApprovalRuleTemplatesForRepository


        /// <summary>
        /// Lists all approval rule templates that are associated with a specified repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedApprovalRuleTemplatesForRepository service method.</param>
        /// 
        /// <returns>The response from the ListAssociatedApprovalRuleTemplatesForRepository service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListAssociatedApprovalRuleTemplatesForRepository">REST API Reference for ListAssociatedApprovalRuleTemplatesForRepository Operation</seealso>
        ListAssociatedApprovalRuleTemplatesForRepositoryResponse ListAssociatedApprovalRuleTemplatesForRepository(ListAssociatedApprovalRuleTemplatesForRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedApprovalRuleTemplatesForRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedApprovalRuleTemplatesForRepository operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedApprovalRuleTemplatesForRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListAssociatedApprovalRuleTemplatesForRepository">REST API Reference for ListAssociatedApprovalRuleTemplatesForRepository Operation</seealso>
        IAsyncResult BeginListAssociatedApprovalRuleTemplatesForRepository(ListAssociatedApprovalRuleTemplatesForRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedApprovalRuleTemplatesForRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedApprovalRuleTemplatesForRepository.</param>
        /// 
        /// <returns>Returns a  ListAssociatedApprovalRuleTemplatesForRepositoryResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListAssociatedApprovalRuleTemplatesForRepository">REST API Reference for ListAssociatedApprovalRuleTemplatesForRepository Operation</seealso>
        ListAssociatedApprovalRuleTemplatesForRepositoryResponse EndListAssociatedApprovalRuleTemplatesForRepository(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        ListBranchesResponse ListBranches(ListBranchesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBranches operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBranches operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBranches
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        IAsyncResult BeginListBranches(ListBranchesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListBranches operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBranches.</param>
        /// 
        /// <returns>Returns a  ListBranchesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListBranches">REST API Reference for ListBranches Operation</seealso>
        ListBranchesResponse EndListBranches(IAsyncResult asyncResult);

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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        ListPullRequestsResponse ListPullRequests(ListPullRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListPullRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPullRequests operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPullRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        IAsyncResult BeginListPullRequests(ListPullRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListPullRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPullRequests.</param>
        /// 
        /// <returns>Returns a  ListPullRequestsResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListPullRequests">REST API Reference for ListPullRequests Operation</seealso>
        ListPullRequestsResponse EndListPullRequests(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        IAsyncResult BeginListRepositories(ListRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositories.</param>
        /// 
        /// <returns>Returns a  ListRepositoriesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        ListRepositoriesResponse EndListRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  ListRepositoriesForApprovalRuleTemplate


        /// <summary>
        /// Lists all repositories associated with the specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesForApprovalRuleTemplate service method.</param>
        /// 
        /// <returns>The response from the ListRepositoriesForApprovalRuleTemplate service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidContinuationTokenException">
        /// The specified continuation token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidMaxResultsException">
        /// The specified number of maximum results is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositoriesForApprovalRuleTemplate">REST API Reference for ListRepositoriesForApprovalRuleTemplate Operation</seealso>
        ListRepositoriesForApprovalRuleTemplateResponse ListRepositoriesForApprovalRuleTemplate(ListRepositoriesForApprovalRuleTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositoriesForApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositoriesForApprovalRuleTemplate operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositoriesForApprovalRuleTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositoriesForApprovalRuleTemplate">REST API Reference for ListRepositoriesForApprovalRuleTemplate Operation</seealso>
        IAsyncResult BeginListRepositoriesForApprovalRuleTemplate(ListRepositoriesForApprovalRuleTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositoriesForApprovalRuleTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositoriesForApprovalRuleTemplate.</param>
        /// 
        /// <returns>Returns a  ListRepositoriesForApprovalRuleTemplateResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListRepositoriesForApprovalRuleTemplate">REST API Reference for ListRepositoriesForApprovalRuleTemplate Operation</seealso>
        ListRepositoriesForApprovalRuleTemplateResponse EndListRepositoriesForApprovalRuleTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Gets information about AWS tags for a specified Amazon Resource Name (ARN) in AWS
        /// CodeCommit. For a list of valid resources in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the<i> AWS CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the AWS CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an AWS CodeCommit resource is required. For
        /// a list of valid resources in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the AWS CodeCommit User Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  MergeBranchesByFastForward


        /// <summary>
        /// Merges two branches using the fast-forward merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByFastForward service method.</param>
        /// 
        /// <returns>The response from the MergeBranchesByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByFastForward">REST API Reference for MergeBranchesByFastForward Operation</seealso>
        MergeBranchesByFastForwardResponse MergeBranchesByFastForward(MergeBranchesByFastForwardRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergeBranchesByFastForward operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByFastForward operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeBranchesByFastForward
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByFastForward">REST API Reference for MergeBranchesByFastForward Operation</seealso>
        IAsyncResult BeginMergeBranchesByFastForward(MergeBranchesByFastForwardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergeBranchesByFastForward operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeBranchesByFastForward.</param>
        /// 
        /// <returns>Returns a  MergeBranchesByFastForwardResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByFastForward">REST API Reference for MergeBranchesByFastForward Operation</seealso>
        MergeBranchesByFastForwardResponse EndMergeBranchesByFastForward(IAsyncResult asyncResult);

        #endregion
        
        #region  MergeBranchesBySquash


        /// <summary>
        /// Merges two branches using the squash merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesBySquash service method.</param>
        /// 
        /// <returns>The response from the MergeBranchesBySquash service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesBySquash">REST API Reference for MergeBranchesBySquash Operation</seealso>
        MergeBranchesBySquashResponse MergeBranchesBySquash(MergeBranchesBySquashRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergeBranchesBySquash operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesBySquash operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeBranchesBySquash
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesBySquash">REST API Reference for MergeBranchesBySquash Operation</seealso>
        IAsyncResult BeginMergeBranchesBySquash(MergeBranchesBySquashRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergeBranchesBySquash operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeBranchesBySquash.</param>
        /// 
        /// <returns>Returns a  MergeBranchesBySquashResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesBySquash">REST API Reference for MergeBranchesBySquash Operation</seealso>
        MergeBranchesBySquashResponse EndMergeBranchesBySquash(IAsyncResult asyncResult);

        #endregion
        
        #region  MergeBranchesByThreeWay


        /// <summary>
        /// Merges two specified branches using the three-way merge strategy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByThreeWay service method.</param>
        /// 
        /// <returns>The response from the MergeBranchesByThreeWay service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.BranchDoesNotExistException">
        /// The specified branch does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameIsTagNameException">
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitDoesNotExistException">
        /// The specified commit does not exist or no commit was specified, and the specified
        /// repository has no default branch.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommitRequiredException">
        /// A commit was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileModeRequiredException">
        /// The commit cannot be created because no file mode has been specified. A file mode
        /// is required to update mode permissions for a file.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidBranchNameException">
        /// The specified reference name is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitException">
        /// The specified commit is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTargetBranchException">
        /// The specified target branch is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByThreeWay">REST API Reference for MergeBranchesByThreeWay Operation</seealso>
        MergeBranchesByThreeWayResponse MergeBranchesByThreeWay(MergeBranchesByThreeWayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergeBranchesByThreeWay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergeBranchesByThreeWay operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergeBranchesByThreeWay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByThreeWay">REST API Reference for MergeBranchesByThreeWay Operation</seealso>
        IAsyncResult BeginMergeBranchesByThreeWay(MergeBranchesByThreeWayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergeBranchesByThreeWay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergeBranchesByThreeWay.</param>
        /// 
        /// <returns>Returns a  MergeBranchesByThreeWayResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergeBranchesByThreeWay">REST API Reference for MergeBranchesByThreeWay Operation</seealso>
        MergeBranchesByThreeWayResponse EndMergeBranchesByThreeWay(IAsyncResult asyncResult);

        #endregion
        
        #region  MergePullRequestByFastForward


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the fast-forward merge
        /// strategy. If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestByFastForward service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
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
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByFastForward operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergePullRequestByFastForward
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        IAsyncResult BeginMergePullRequestByFastForward(MergePullRequestByFastForwardRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergePullRequestByFastForward operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergePullRequestByFastForward.</param>
        /// 
        /// <returns>Returns a  MergePullRequestByFastForwardResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByFastForward">REST API Reference for MergePullRequestByFastForward Operation</seealso>
        MergePullRequestByFastForwardResponse EndMergePullRequestByFastForward(IAsyncResult asyncResult);

        #endregion
        
        #region  MergePullRequestBySquash


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the squash merge strategy.
        /// If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestBySquash service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestBySquash service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestBySquash">REST API Reference for MergePullRequestBySquash Operation</seealso>
        MergePullRequestBySquashResponse MergePullRequestBySquash(MergePullRequestBySquashRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergePullRequestBySquash operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestBySquash operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergePullRequestBySquash
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestBySquash">REST API Reference for MergePullRequestBySquash Operation</seealso>
        IAsyncResult BeginMergePullRequestBySquash(MergePullRequestBySquashRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergePullRequestBySquash operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergePullRequestBySquash.</param>
        /// 
        /// <returns>Returns a  MergePullRequestBySquashResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestBySquash">REST API Reference for MergePullRequestBySquash Operation</seealso>
        MergePullRequestBySquashResponse EndMergePullRequestBySquash(IAsyncResult asyncResult);

        #endregion
        
        #region  MergePullRequestByThreeWay


        /// <summary>
        /// Attempts to merge the source commit of a pull request into the specified destination
        /// branch for that pull request at the specified commit using the three-way merge strategy.
        /// If the merge is successful, it closes the pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByThreeWay service method.</param>
        /// 
        /// <returns>The response from the MergePullRequestByThreeWay service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.CommitMessageLengthExceededException">
        /// The commit message is too long. Provide a shorter string.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ConcurrentReferenceUpdateException">
        /// The merge cannot be completed because the target branch has been modified. Another
        /// user might have modified the target branch while the merge was in progress. Wait a
        /// few minutes, and then try again.
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
        /// <exception cref="Amazon.CodeCommit.Model.FileContentSizeLimitExceededException">
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictDetailLevelException">
        /// The specified conflict detail level is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionException">
        /// The specified conflict resolution list is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidConflictResolutionStrategyException">
        /// The specified conflict resolution strategy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidEmailException">
        /// The specified email address either contains one or more characters that are not allowed,
        /// or it exceeds the maximum number of characters allowed for an email address.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileModeException">
        /// The specified file mode permission is not valid. For a list of valid file mode permissions,
        /// see <a>PutFile</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPathException">
        /// The specified path is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementContentException">
        /// Automerge was specified for resolving the conflict, but the replacement type is not
        /// valid or content is missing.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidReplacementTypeException">
        /// Automerge was specified for resolving the conflict, but the specified replacement
        /// type is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ManualMergeRequiredException">
        /// The pull request cannot be merged automatically into the destination branch. You must
        /// manually merge the branches and resolve any conflicts.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumConflictResolutionEntriesExceededException">
        /// The number of allowed conflict resolution entries was exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumFileContentToLoadExceededException">
        /// The number of files to load exceeds the allowed limit.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumItemsToCompareExceededException">
        /// The number of items to compare between the source or destination branches and the
        /// merge base has exceeded the maximum allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MultipleConflictResolutionEntriesException">
        /// More than one conflict resolution entries exists for the conflict. A conflict can
        /// have only one conflict resolution entry.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PathRequiredException">
        /// The folderPath for a location cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestApprovalRulesNotSatisfiedException">
        /// The pull request cannot be merged because one or more approval rules applied to the
        /// pull request have conditions that have not been met.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementContentRequiredException">
        /// USE_NEW_CONTENT was specified, but no replacement content has been provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ReplacementTypeRequiredException">
        /// A replacement type is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipOfSourceReferenceIsDifferentException">
        /// The tip of the source branch in the destination repository does not match the tip
        /// of the source branch specified in your request. The pull request might have been updated.
        /// Make sure that you have the latest changes.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TipsDivergenceExceededException">
        /// The divergence between the tips of the provided commit specifiers is too great to
        /// determine whether there might be any merge conflicts. Locally compare the specifiers
        /// using <code>git diff</code> or a diff tool.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByThreeWay">REST API Reference for MergePullRequestByThreeWay Operation</seealso>
        MergePullRequestByThreeWayResponse MergePullRequestByThreeWay(MergePullRequestByThreeWayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MergePullRequestByThreeWay operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MergePullRequestByThreeWay operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMergePullRequestByThreeWay
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByThreeWay">REST API Reference for MergePullRequestByThreeWay Operation</seealso>
        IAsyncResult BeginMergePullRequestByThreeWay(MergePullRequestByThreeWayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MergePullRequestByThreeWay operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMergePullRequestByThreeWay.</param>
        /// 
        /// <returns>Returns a  MergePullRequestByThreeWayResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/MergePullRequestByThreeWay">REST API Reference for MergePullRequestByThreeWay Operation</seealso>
        MergePullRequestByThreeWayResponse EndMergePullRequestByThreeWay(IAsyncResult asyncResult);

        #endregion
        
        #region  OverridePullRequestApprovalRules


        /// <summary>
        /// Sets aside (overrides) all approval rule requirements for a specified pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the OverridePullRequestApprovalRules service method.</param>
        /// 
        /// <returns>The response from the OverridePullRequestApprovalRules service method, as returned by CodeCommit.</returns>
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidOverrideStatusException">
        /// The override status is not valid. Valid statuses are OVERRIDE and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OverrideAlreadySetException">
        /// The pull request has already had its approval rules set to override.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.OverrideStatusRequiredException">
        /// An override status is required, but no value was provided. Valid values include OVERRIDE
        /// and REVOKE.
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
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/OverridePullRequestApprovalRules">REST API Reference for OverridePullRequestApprovalRules Operation</seealso>
        OverridePullRequestApprovalRulesResponse OverridePullRequestApprovalRules(OverridePullRequestApprovalRulesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the OverridePullRequestApprovalRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the OverridePullRequestApprovalRules operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndOverridePullRequestApprovalRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/OverridePullRequestApprovalRules">REST API Reference for OverridePullRequestApprovalRules Operation</seealso>
        IAsyncResult BeginOverridePullRequestApprovalRules(OverridePullRequestApprovalRulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  OverridePullRequestApprovalRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginOverridePullRequestApprovalRules.</param>
        /// 
        /// <returns>Returns a  OverridePullRequestApprovalRulesResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/OverridePullRequestApprovalRules">REST API Reference for OverridePullRequestApprovalRules Operation</seealso>
        OverridePullRequestApprovalRulesResponse EndOverridePullRequestApprovalRules(IAsyncResult asyncResult);

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
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
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
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the file name and
        /// extension.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        PostCommentForComparedCommitResponse PostCommentForComparedCommit(PostCommentForComparedCommitRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForComparedCommit operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostCommentForComparedCommit
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        IAsyncResult BeginPostCommentForComparedCommit(PostCommentForComparedCommitRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PostCommentForComparedCommit operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostCommentForComparedCommit.</param>
        /// 
        /// <returns>Returns a  PostCommentForComparedCommitResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForComparedCommit">REST API Reference for PostCommentForComparedCommit Operation</seealso>
        PostCommentForComparedCommitResponse EndPostCommentForComparedCommit(IAsyncResult asyncResult);

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
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
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
        /// or the token has been used in a previous request and cannot be reused.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidClientRequestTokenException">
        /// The client request token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidCommitIdException">
        /// The specified commit ID is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidFileLocationException">
        /// The location of the file is not valid. Make sure that you include the file name and
        /// extension.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNotAssociatedWithPullRequestException">
        /// The repository does not contain any pull requests with that pull request ID. Use GetPullRequest
        /// to verify the correct repository name for the pull request ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        PostCommentForPullRequestResponse PostCommentForPullRequest(PostCommentForPullRequestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PostCommentForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PostCommentForPullRequest operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostCommentForPullRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        IAsyncResult BeginPostCommentForPullRequest(PostCommentForPullRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PostCommentForPullRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostCommentForPullRequest.</param>
        /// 
        /// <returns>Returns a  PostCommentForPullRequestResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentForPullRequest">REST API Reference for PostCommentForPullRequest Operation</seealso>
        PostCommentForPullRequestResponse EndPostCommentForPullRequest(IAsyncResult asyncResult);

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
        /// idempotency token that, when provided in a request, ensures the request cannot be
        /// repeated with a changed parameter. If a request is received with the same parameters
        /// and a token is included, the request returns information about the initial request
        /// that used that token.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentRequiredException">
        /// The comment is empty. You must provide some content for a comment. The content cannot
        /// be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentContentSizeLimitExceededException">
        /// The comment is too large. Comments are limited to 1,000 characters.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentDoesNotExistException">
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CommentIdRequiredException">
        /// The comment ID is missing or null. A comment ID is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.IdempotencyParameterMismatchException">
        /// The client request token is not valid. Either the token is not in a valid format,
        /// or the token has been used in a previous request and cannot be reused.
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
        /// <param name="request">Container for the necessary parameters to execute the PostCommentReply operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPostCommentReply
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        IAsyncResult BeginPostCommentReply(PostCommentReplyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PostCommentReply operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPostCommentReply.</param>
        /// 
        /// <returns>Returns a  PostCommentReplyResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PostCommentReply">REST API Reference for PostCommentReply Operation</seealso>
        PostCommentReplyResponse EndPostCommentReply(IAsyncResult asyncResult);

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
        /// The specified branch name is not valid because it is a tag name. Enter the name of
        /// a branch in the repository. For a list of valid branch names, use <a>ListBranches</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.BranchNameRequiredException">
        /// A branch name is required, but was not specified.
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
        /// The file cannot be added because it is too large. The maximum file size is 6 MB, and
        /// the combined file content change size is 7 MB. Consider making these changes using
        /// a Git client.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FileNameConflictsWithDirectoryNameException">
        /// A file cannot be added to the repository because the specified file name has the same
        /// name as a directory in this repository. Either provide another name for the file,
        /// or add the file in a directory that does not match the file name.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FilePathConflictsWithSubmodulePathException">
        /// The commit cannot be created because a specified file path points to a submodule.
        /// Verify that the destination files have valid file paths that do not point to a submodule.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.FolderContentSizeLimitExceededException">
        /// The commit cannot be created because at least one of the overall changes in the commit
        /// results in a folder whose contents exceed the limit of 6 MB. Either reduce the number
        /// and size of your changes, or split the changes across multiple folders.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.NameLengthExceededException">
        /// The user name is not valid because it has exceeded the character limit for author
        /// names.
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
        /// A repository name is required, but was not specified.
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
        /// <param name="request">Container for the necessary parameters to execute the PutFile operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutFile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        IAsyncResult BeginPutFile(PutFileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutFile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutFile.</param>
        /// 
        /// <returns>Returns a  PutFileResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutFile">REST API Reference for PutFile Operation</seealso>
        PutFileResponse EndPutFile(IAsyncResult asyncResult);

        #endregion
        
        #region  PutRepositoryTriggers


        /// <summary>
        /// Replaces all triggers for a repository. Used to create or delete triggers.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// The AWS Region for the trigger target does not match the AWS Region for the repository.
        /// Triggers must be created in the same Region as the target for the trigger.
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required, but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required, but was not
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        PutRepositoryTriggersResponse PutRepositoryTriggers(PutRepositoryTriggersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRepositoryTriggers operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRepositoryTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        IAsyncResult BeginPutRepositoryTriggers(PutRepositoryTriggersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRepositoryTriggers.</param>
        /// 
        /// <returns>Returns a  PutRepositoryTriggersResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/PutRepositoryTriggers">REST API Reference for PutRepositoryTriggers Operation</seealso>
        PutRepositoryTriggersResponse EndPutRepositoryTriggers(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or updates tags for a resource in AWS CodeCommit. For a list of valid resources
        /// in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the AWS CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagsMapException">
        /// The map of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an AWS CodeCommit resource is required. For
        /// a list of valid resources in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the AWS CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagsMapRequiredException">
        /// A map of tags is required.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an AWS CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  TestRepositoryTriggers


        /// <summary>
        /// Tests the functionality of repository triggers by sending information to the trigger
        /// target. If real data is available in the repository, the test sends data from the
        /// last commit. If no data is available, sample data is generated.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// The AWS Region for the trigger target does not match the AWS Region for the repository.
        /// Triggers must be created in the same Region as the target for the trigger.
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerBranchNameListRequiredException">
        /// At least one branch name is required, but was not specified in the trigger configuration.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerDestinationArnRequiredException">
        /// A destination ARN for the target service for the trigger is required, but was not
        /// specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerEventsListRequiredException">
        /// At least one event for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggerNameRequiredException">
        /// A name for the trigger is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryTriggersListRequiredException">
        /// The list of triggers for the repository is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        TestRepositoryTriggersResponse TestRepositoryTriggers(TestRepositoryTriggersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TestRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestRepositoryTriggers operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestRepositoryTriggers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        IAsyncResult BeginTestRepositoryTriggers(TestRepositoryTriggersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TestRepositoryTriggers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestRepositoryTriggers.</param>
        /// 
        /// <returns>Returns a  TestRepositoryTriggersResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/TestRepositoryTriggers">REST API Reference for TestRepositoryTriggers Operation</seealso>
        TestRepositoryTriggersResponse EndTestRepositoryTriggers(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes tags for a resource in AWS CodeCommit. For a list of valid resources in AWS
        /// CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the <i>AWS CodeCommit User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidResourceArnException">
        /// The value for the resource ARN is not valid. For more information about resources
        /// in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the AWS CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidSystemTagUsageException">
        /// The specified tag is not valid. Key names cannot be prefixed with aws:.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidTagKeysListException">
        /// The list of tags is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ResourceArnRequiredException">
        /// A valid Amazon Resource Name (ARN) for an AWS CodeCommit resource is required. For
        /// a list of valid resources in AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/auth-and-access-control-iam-access-control-identity-based.html#arn-formats">CodeCommit
        /// Resources and Operations</a> in the AWS CodeCommit User Guide.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagKeysListRequiredException">
        /// A list of tag keys is required. The list cannot be empty or null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TagPolicyException">
        /// The tag policy is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.TooManyTagsException">
        /// The maximum number of tags for an AWS CodeCommit resource has been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApprovalRuleTemplateContent


        /// <summary>
        /// Updates the content of an approval rule template. You can change the number of required
        /// approvals, the membership of the approval rule, and whether an approval pool is defined.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateContent service method.</param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateContentRequiredException">
        /// The content for the approval rule template is empty. You must provide some content
        /// for an approval rule template. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateContentException">
        /// The content of the approval rule template is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRuleContentSha256Exception">
        /// The SHA-256 hash signature for the rule content is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateContent">REST API Reference for UpdateApprovalRuleTemplateContent Operation</seealso>
        UpdateApprovalRuleTemplateContentResponse UpdateApprovalRuleTemplateContent(UpdateApprovalRuleTemplateContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApprovalRuleTemplateContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateContent operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApprovalRuleTemplateContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateContent">REST API Reference for UpdateApprovalRuleTemplateContent Operation</seealso>
        IAsyncResult BeginUpdateApprovalRuleTemplateContent(UpdateApprovalRuleTemplateContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApprovalRuleTemplateContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApprovalRuleTemplateContent.</param>
        /// 
        /// <returns>Returns a  UpdateApprovalRuleTemplateContentResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateContent">REST API Reference for UpdateApprovalRuleTemplateContent Operation</seealso>
        UpdateApprovalRuleTemplateContentResponse EndUpdateApprovalRuleTemplateContent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApprovalRuleTemplateDescription


        /// <summary>
        /// Updates the description for a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateDescription service method.</param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateDescriptionException">
        /// The description for the approval rule template is not valid because it exceeds the
        /// maximum characters allowed for a description. For more information about limits in
        /// AWS CodeCommit, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateDescription">REST API Reference for UpdateApprovalRuleTemplateDescription Operation</seealso>
        UpdateApprovalRuleTemplateDescriptionResponse UpdateApprovalRuleTemplateDescription(UpdateApprovalRuleTemplateDescriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApprovalRuleTemplateDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateDescription operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApprovalRuleTemplateDescription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateDescription">REST API Reference for UpdateApprovalRuleTemplateDescription Operation</seealso>
        IAsyncResult BeginUpdateApprovalRuleTemplateDescription(UpdateApprovalRuleTemplateDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApprovalRuleTemplateDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApprovalRuleTemplateDescription.</param>
        /// 
        /// <returns>Returns a  UpdateApprovalRuleTemplateDescriptionResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateDescription">REST API Reference for UpdateApprovalRuleTemplateDescription Operation</seealso>
        UpdateApprovalRuleTemplateDescriptionResponse EndUpdateApprovalRuleTemplateDescription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateApprovalRuleTemplateName


        /// <summary>
        /// Updates the name of a specified approval rule template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateName service method.</param>
        /// 
        /// <returns>The response from the UpdateApprovalRuleTemplateName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateDoesNotExistException">
        /// The specified approval rule template does not exist. Verify that the name is correct
        /// and that you are signed in to the AWS Region where the template was created, and then
        /// try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameAlreadyExistsException">
        /// You cannot create an approval rule template with that name because a template with
        /// that name already exists in this AWS Region for your AWS account. Approval rule template
        /// names must be unique.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleTemplateNameRequiredException">
        /// An approval rule template name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleTemplateNameException">
        /// The name of the approval rule template is not valid. Template names must be between
        /// 1 and 100 valid characters in length. For more information about limits in AWS CodeCommit,
        /// see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">AWS
        /// CodeCommit User Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateName">REST API Reference for UpdateApprovalRuleTemplateName Operation</seealso>
        UpdateApprovalRuleTemplateNameResponse UpdateApprovalRuleTemplateName(UpdateApprovalRuleTemplateNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApprovalRuleTemplateName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalRuleTemplateName operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApprovalRuleTemplateName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateName">REST API Reference for UpdateApprovalRuleTemplateName Operation</seealso>
        IAsyncResult BeginUpdateApprovalRuleTemplateName(UpdateApprovalRuleTemplateNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApprovalRuleTemplateName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApprovalRuleTemplateName.</param>
        /// 
        /// <returns>Returns a  UpdateApprovalRuleTemplateNameResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateApprovalRuleTemplateName">REST API Reference for UpdateApprovalRuleTemplateName Operation</seealso>
        UpdateApprovalRuleTemplateNameResponse EndUpdateApprovalRuleTemplateName(IAsyncResult asyncResult);

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
        /// No comment exists with the provided ID. Verify that you have used the correct ID,
        /// and then try again.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdateComment operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        IAsyncResult BeginUpdateComment(UpdateCommentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComment.</param>
        /// 
        /// <returns>Returns a  UpdateCommentResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateComment">REST API Reference for UpdateComment Operation</seealso>
        UpdateCommentResponse EndUpdateComment(IAsyncResult asyncResult);

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
        /// A branch name is required, but was not specified.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        UpdateDefaultBranchResponse UpdateDefaultBranch(UpdateDefaultBranchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDefaultBranch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDefaultBranch operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDefaultBranch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        IAsyncResult BeginUpdateDefaultBranch(UpdateDefaultBranchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDefaultBranch operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDefaultBranch.</param>
        /// 
        /// <returns>Returns a  UpdateDefaultBranchResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateDefaultBranch">REST API Reference for UpdateDefaultBranch Operation</seealso>
        UpdateDefaultBranchResponse EndUpdateDefaultBranch(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePullRequestApprovalRuleContent


        /// <summary>
        /// Updates the structure of an approval rule created specifically for a pull request.
        /// For example, you can change the number of required approvers and the approval pool
        /// for approvers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalRuleContent service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestApprovalRuleContent service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleContentRequiredException">
        /// The content for the approval rule is empty. You must provide some content for an approval
        /// rule. The content cannot be null.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleDoesNotExistException">
        /// The specified approval rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalRuleNameRequiredException">
        /// An approval rule name is required, but was not specified.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.CannotModifyApprovalRuleFromTemplateException">
        /// The approval rule cannot be modified for the pull request because it was created by
        /// an approval rule template and applied to the pull request automatically.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleContentException">
        /// The content for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalRuleNameException">
        /// The name for the approval rule is not valid.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRuleContentSha256Exception">
        /// The SHA-256 hash signature for the rule content is not valid.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalRuleContent">REST API Reference for UpdatePullRequestApprovalRuleContent Operation</seealso>
        UpdatePullRequestApprovalRuleContentResponse UpdatePullRequestApprovalRuleContent(UpdatePullRequestApprovalRuleContentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestApprovalRuleContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalRuleContent operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePullRequestApprovalRuleContent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalRuleContent">REST API Reference for UpdatePullRequestApprovalRuleContent Operation</seealso>
        IAsyncResult BeginUpdatePullRequestApprovalRuleContent(UpdatePullRequestApprovalRuleContentRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePullRequestApprovalRuleContent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePullRequestApprovalRuleContent.</param>
        /// 
        /// <returns>Returns a  UpdatePullRequestApprovalRuleContentResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalRuleContent">REST API Reference for UpdatePullRequestApprovalRuleContent Operation</seealso>
        UpdatePullRequestApprovalRuleContentResponse EndUpdatePullRequestApprovalRuleContent(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePullRequestApprovalState


        /// <summary>
        /// Updates the state of a user's approval on a pull request. The user is derived from
        /// the signed-in account when the request is made.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalState service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestApprovalState service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.ApprovalStateRequiredException">
        /// An approval state is required, but was not specified.
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
        /// <exception cref="Amazon.CodeCommit.Model.InvalidApprovalStateException">
        /// The state for the approval is not valid. Valid values include APPROVE and REVOKE.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidPullRequestIdException">
        /// The pull request ID is not valid. Make sure that you have provided the full ID and
        /// that the pull request is in the specified repository, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRevisionIdException">
        /// The revision ID is not valid. Use GetPullRequest to determine the value.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.MaximumNumberOfApprovalsExceededException">
        /// The number of approvals required for the approval rule exceeds the maximum number
        /// allowed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestAlreadyClosedException">
        /// The pull request status cannot be updated because it is already closed.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestCannotBeApprovedByAuthorException">
        /// The approval cannot be applied because the user approving the pull request matches
        /// the user who created the pull request. You cannot approve a pull request that you
        /// created.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestDoesNotExistException">
        /// The pull request ID could not be found. Make sure that you have specified the correct
        /// repository name and pull request ID, and then try again.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.PullRequestIdRequiredException">
        /// A pull request ID is required, but none was provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionIdRequiredException">
        /// A revision ID is required, but was not provided.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RevisionNotCurrentException">
        /// The revision ID provided in the request does not match the current revision ID. Use
        /// GetPullRequest to retrieve the current revision ID.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalState">REST API Reference for UpdatePullRequestApprovalState Operation</seealso>
        UpdatePullRequestApprovalStateResponse UpdatePullRequestApprovalState(UpdatePullRequestApprovalStateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdatePullRequestApprovalState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestApprovalState operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePullRequestApprovalState
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalState">REST API Reference for UpdatePullRequestApprovalState Operation</seealso>
        IAsyncResult BeginUpdatePullRequestApprovalState(UpdatePullRequestApprovalStateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePullRequestApprovalState operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePullRequestApprovalState.</param>
        /// 
        /// <returns>Returns a  UpdatePullRequestApprovalStateResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestApprovalState">REST API Reference for UpdatePullRequestApprovalState Operation</seealso>
        UpdatePullRequestApprovalStateResponse EndUpdatePullRequestApprovalState(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdatePullRequestDescription


        /// <summary>
        /// Replaces the contents of the description of a pull request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription service method.</param>
        /// 
        /// <returns>The response from the UpdatePullRequestDescription service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidDescriptionException">
        /// The pull request description is not valid. Descriptions cannot be more than 1,000
        /// characters.
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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestDescription operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePullRequestDescription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        IAsyncResult BeginUpdatePullRequestDescription(UpdatePullRequestDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePullRequestDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePullRequestDescription.</param>
        /// 
        /// <returns>Returns a  UpdatePullRequestDescriptionResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestDescription">REST API Reference for UpdatePullRequestDescription Operation</seealso>
        UpdatePullRequestDescriptionResponse EndUpdatePullRequestDescription(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestStatus operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePullRequestStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        IAsyncResult BeginUpdatePullRequestStatus(UpdatePullRequestStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePullRequestStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePullRequestStatus.</param>
        /// 
        /// <returns>Returns a  UpdatePullRequestStatusResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestStatus">REST API Reference for UpdatePullRequestStatus Operation</seealso>
        UpdatePullRequestStatusResponse EndUpdatePullRequestStatus(IAsyncResult asyncResult);

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
        /// <param name="request">Container for the necessary parameters to execute the UpdatePullRequestTitle operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdatePullRequestTitle
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        IAsyncResult BeginUpdatePullRequestTitle(UpdatePullRequestTitleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdatePullRequestTitle operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdatePullRequestTitle.</param>
        /// 
        /// <returns>Returns a  UpdatePullRequestTitleResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdatePullRequestTitle">REST API Reference for UpdatePullRequestTitle Operation</seealso>
        UpdatePullRequestTitleResponse EndUpdatePullRequestTitle(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRepositoryDescription


        /// <summary>
        /// Sets or changes the comment or description for a repository.
        /// 
        ///  <note> 
        /// <para>
        /// The description field for a repository accepts all HTML characters and all valid Unicode
        /// characters. Applications that do not HTML-encode the description and display it in
        /// a webpage can expose users to potentially malicious code. Make sure that you HTML-encode
        /// the description field in any application that uses this API to display the repository
        /// description on a webpage.
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
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
        /// occur when a required repository parameter is missing, or when a specified repository
        /// does not exist.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryDoesNotExistException">
        /// The specified repository does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeCommit.Model.RepositoryNameRequiredException">
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        UpdateRepositoryDescriptionResponse UpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryDescription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryDescription operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRepositoryDescription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        IAsyncResult BeginUpdateRepositoryDescription(UpdateRepositoryDescriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRepositoryDescription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRepositoryDescription.</param>
        /// 
        /// <returns>Returns a  UpdateRepositoryDescriptionResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryDescription">REST API Reference for UpdateRepositoryDescription Operation</seealso>
        UpdateRepositoryDescriptionResponse EndUpdateRepositoryDescription(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateRepositoryName


        /// <summary>
        /// Renames a repository. The repository name must be unique across the calling AWS account.
        /// Repository names are limited to 100 alphanumeric, dash, and underscore characters,
        /// and cannot include certain characters. The suffix .git is prohibited. For more information
        /// about the limits on repository names, see <a href="https://docs.aws.amazon.com/codecommit/latest/userguide/limits.html">Limits</a>
        /// in the AWS CodeCommit User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName service method.</param>
        /// 
        /// <returns>The response from the UpdateRepositoryName service method, as returned by CodeCommit.</returns>
        /// <exception cref="Amazon.CodeCommit.Model.InvalidRepositoryNameException">
        /// A specified repository name is not valid.
        /// 
        ///  <note> 
        /// <para>
        /// This exception occurs only when a specified repository name is not valid. Other exceptions
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
        /// A repository name is required, but was not specified.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        UpdateRepositoryNameResponse UpdateRepositoryName(UpdateRepositoryNameRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRepositoryName operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRepositoryName operation on AmazonCodeCommitClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRepositoryName
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        IAsyncResult BeginUpdateRepositoryName(UpdateRepositoryNameRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRepositoryName operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRepositoryName.</param>
        /// 
        /// <returns>Returns a  UpdateRepositoryNameResult from CodeCommit.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codecommit-2015-04-13/UpdateRepositoryName">REST API Reference for UpdateRepositoryName Operation</seealso>
        UpdateRepositoryNameResponse EndUpdateRepositoryName(IAsyncResult asyncResult);

        #endregion
        
    }
}