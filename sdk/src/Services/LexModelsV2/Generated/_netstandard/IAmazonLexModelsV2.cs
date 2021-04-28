/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.LexModelsV2.Model;

namespace Amazon.LexModelsV2
{
    /// <summary>
    /// Interface for accessing LexModelsV2
    ///
    /// 
    /// </summary>
    public partial interface IAmazonLexModelsV2 : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ILexModelsV2PaginatorFactory Paginators { get; }
#endif
                
        #region  BuildBotLocale



        /// <summary>
        /// Builds a bot, its intents, and its slot types into a specific locale. A bot can be
        /// built into multiple locales. At runtime the locale is used to choose a specific build
        /// of the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BuildBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BuildBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/BuildBotLocale">REST API Reference for BuildBotLocale Operation</seealso>
        Task<BuildBotLocaleResponse> BuildBotLocaleAsync(BuildBotLocaleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBot



        /// <summary>
        /// Creates an Amazon Lex conversational bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBot">REST API Reference for CreateBot Operation</seealso>
        Task<CreateBotResponse> CreateBotAsync(CreateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBotAlias



        /// <summary>
        /// Creates an alias for the specified version of a bot. Use an alias to enable you to
        /// change the version of a bot without updating applications that use the bot.
        /// 
        ///  
        /// <para>
        /// For example, you can create an alias called "PROD" that your applications use to call
        /// the Amazon Lex bot. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotAlias">REST API Reference for CreateBotAlias Operation</seealso>
        Task<CreateBotAliasResponse> CreateBotAliasAsync(CreateBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBotLocale



        /// <summary>
        /// Creates a locale in the bot. The locale contains the intents and slot types that the
        /// bot uses in conversations with users in the specified language and locale. You must
        /// add a locale to a bot before you can add intents and slot types to the bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotLocale">REST API Reference for CreateBotLocale Operation</seealso>
        Task<CreateBotLocaleResponse> CreateBotLocaleAsync(CreateBotLocaleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateBotVersion



        /// <summary>
        /// Creates a new version of the bot based on the <code>DRAFT</code> version. If the <code>DRAFT</code>
        /// version of this resource hasn't changed since you created the last version, Amazon
        /// Lex doesn't create a new version, it returns the last created version.
        /// 
        ///  
        /// <para>
        /// When you create the first version of a bot, Amazon Lex sets the version to 1. Subsequent
        /// versions increment by 1.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBotVersion service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateBotVersion">REST API Reference for CreateBotVersion Operation</seealso>
        Task<CreateBotVersionResponse> CreateBotVersionAsync(CreateBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateIntent



        /// <summary>
        /// Creates an intent.
        /// 
        ///  
        /// <para>
        /// To define the interaction between the user and your bot, you define one or more intents.
        /// For example, for a pizza ordering bot you would create an <code>OrderPizza</code>
        /// intent.
        /// </para>
        ///  
        /// <para>
        /// When you create an intent, you must provide a name. You can optionally provide the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Sample utterances. For example, "I want to order a pizza" and "Can I order a pizza."
        /// You can't provide utterances for built-in intents.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Information to be gathered. You specify slots for the information that you bot requests
        /// from the user. You can specify standard slot types, such as date and time, or custom
        /// slot types for your application.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// How the intent is fulfilled. You can provide a Lambda function or configure the intent
        /// to return the intent information to your client application. If you use a Lambda function,
        /// Amazon Lex invokes the function when all of the intent information is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A confirmation prompt to send to the user to confirm an intent. For example, "Shall
        /// I order your pizza?"
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A conclusion statement to send to the user after the intent is fulfilled. For example,
        /// "I ordered your pizza."
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A follow-up prompt that asks the user for additional activity. For example, "Do you
        /// want a drink with your pizza?"
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateIntent">REST API Reference for CreateIntent Operation</seealso>
        Task<CreateIntentResponse> CreateIntentAsync(CreateIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSlot



        /// <summary>
        /// Creates a slot in an intent. A slot is a variable needed to fulfill an intent. For
        /// example, an <code>OrderPizza</code> intent might need slots for size, crust, and number
        /// of pizzas. For each slot, you define one or more utterances that Amazon Lex uses to
        /// elicit a response from the user.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlot">REST API Reference for CreateSlot Operation</seealso>
        Task<CreateSlotResponse> CreateSlotAsync(CreateSlotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateSlotType



        /// <summary>
        /// Creates a custom slot type
        /// 
        ///  
        /// <para>
        ///  To create a custom slot type, specify a name for the slot type and a set of enumeration
        /// values, the values that a slot of this type can assume. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/CreateSlotType">REST API Reference for CreateSlotType Operation</seealso>
        Task<CreateSlotTypeResponse> CreateSlotTypeAsync(CreateSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBot



        /// <summary>
        /// Deletes all versions of a bot, including the <code>Draft</code> version. To delete
        /// a specific version, use the <code>DeleteBotVersion</code> operation.
        /// 
        ///  
        /// <para>
        /// When you delete a bot, all of the resources contained in the bot are also deleted.
        /// Deleting a bot removes all locales, intents, slot, and slot types defined for the
        /// bot.
        /// </para>
        ///  
        /// <para>
        /// If a bot has an alias, the <code>DeleteBot</code> operation returns a <code>ResourceInUseException</code>
        /// exception. If you want to delete the bot and the alias, set the <code>skipResourceInUseCheck</code>
        /// parameter to <code>true</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBot">REST API Reference for DeleteBot Operation</seealso>
        Task<DeleteBotResponse> DeleteBotAsync(DeleteBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBotAlias



        /// <summary>
        /// Deletes the specified bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotAlias">REST API Reference for DeleteBotAlias Operation</seealso>
        Task<DeleteBotAliasResponse> DeleteBotAliasAsync(DeleteBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBotLocale



        /// <summary>
        /// Removes a locale from a bot.
        /// 
        ///  
        /// <para>
        /// When you delete a locale, all intents, slots, and slot types defined for the locale
        /// are also deleted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotLocale">REST API Reference for DeleteBotLocale Operation</seealso>
        Task<DeleteBotLocaleResponse> DeleteBotLocaleAsync(DeleteBotLocaleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBotVersion



        /// <summary>
        /// Deletes a specific version of a bot. To delete all version of a bot, use the <a>DeleteBot</a>
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBotVersion service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteBotVersion">REST API Reference for DeleteBotVersion Operation</seealso>
        Task<DeleteBotVersionResponse> DeleteBotVersionAsync(DeleteBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteIntent



        /// <summary>
        /// Removes the specified intent.
        /// 
        ///  
        /// <para>
        /// Deleting an intent also deletes the slots associated with the intent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteIntent">REST API Reference for DeleteIntent Operation</seealso>
        Task<DeleteIntentResponse> DeleteIntentAsync(DeleteIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSlot



        /// <summary>
        /// Deletes the specified slot from an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlot">REST API Reference for DeleteSlot Operation</seealso>
        Task<DeleteSlotResponse> DeleteSlotAsync(DeleteSlotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteSlotType



        /// <summary>
        /// Deletes a slot type from a bot locale.
        /// 
        ///  
        /// <para>
        /// If a slot is using the slot type, Amazon Lex throws a <code>ResourceInUseException</code>
        /// exception. To avoid the exception, set the <code>skipResourceInUseCheck</code> parameter
        /// to <code>true</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DeleteSlotType">REST API Reference for DeleteSlotType Operation</seealso>
        Task<DeleteSlotTypeResponse> DeleteSlotTypeAsync(DeleteSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBot



        /// <summary>
        /// Provides metadata information about a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBot">REST API Reference for DescribeBot Operation</seealso>
        Task<DescribeBotResponse> DescribeBotAsync(DescribeBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBotAlias



        /// <summary>
        /// Get information about a specific bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotAlias">REST API Reference for DescribeBotAlias Operation</seealso>
        Task<DescribeBotAliasResponse> DescribeBotAliasAsync(DescribeBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBotLocale



        /// <summary>
        /// Describes the settings that a bot has for a specific locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotLocale">REST API Reference for DescribeBotLocale Operation</seealso>
        Task<DescribeBotLocaleResponse> DescribeBotLocaleAsync(DescribeBotLocaleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeBotVersion



        /// <summary>
        /// Provides metadata about a version of a bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBotVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBotVersion service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeBotVersion">REST API Reference for DescribeBotVersion Operation</seealso>
        Task<DescribeBotVersionResponse> DescribeBotVersionAsync(DescribeBotVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeIntent



        /// <summary>
        /// Returns metadata about an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeIntent">REST API Reference for DescribeIntent Operation</seealso>
        Task<DescribeIntentResponse> DescribeIntentAsync(DescribeIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSlot



        /// <summary>
        /// Gets metadata information about a slot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlot">REST API Reference for DescribeSlot Operation</seealso>
        Task<DescribeSlotResponse> DescribeSlotAsync(DescribeSlotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeSlotType



        /// <summary>
        /// Gets metadata information about a slot type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/DescribeSlotType">REST API Reference for DescribeSlotType Operation</seealso>
        Task<DescribeSlotTypeResponse> DescribeSlotTypeAsync(DescribeSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBotAliases



        /// <summary>
        /// Gets a list of aliases for the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotAliases service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBotAliases service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotAliases">REST API Reference for ListBotAliases Operation</seealso>
        Task<ListBotAliasesResponse> ListBotAliasesAsync(ListBotAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBotLocales



        /// <summary>
        /// Gets a list of locales for the specified bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotLocales service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBotLocales service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotLocales">REST API Reference for ListBotLocales Operation</seealso>
        Task<ListBotLocalesResponse> ListBotLocalesAsync(ListBotLocalesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBots



        /// <summary>
        /// Gets a list of available bots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBots service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBots">REST API Reference for ListBots Operation</seealso>
        Task<ListBotsResponse> ListBotsAsync(ListBotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBotVersions



        /// <summary>
        /// Gets information about all of the versions of a bot.
        /// 
        ///  
        /// <para>
        /// The <code>ListBotVersions</code> operation returns a summary of each version of a
        /// bot. For example, if a bot has three numbered versions, the <code>ListBotVersions</code>
        /// operation returns for summaries, one for each numbered version and one for the <code>DRAFT</code>
        /// version.
        /// </para>
        ///  
        /// <para>
        /// The <code>ListBotVersions</code> operation always returns at least one version, the
        /// <code>DRAFT</code> version.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBotVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBotVersions service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBotVersions">REST API Reference for ListBotVersions Operation</seealso>
        Task<ListBotVersionsResponse> ListBotVersionsAsync(ListBotVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuiltInIntents



        /// <summary>
        /// Gets a list of built-in intents provided by Amazon Lex that you can use in your bot.
        /// 
        /// 
        ///  
        /// <para>
        /// To use a built-in intent as a the base for your own intent, include the built-in intent
        /// signature in the <code>parentIntentSignature</code> parameter when you call the <code>CreateIntent</code>
        /// operation. For more information, see <a>CreateIntent</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInIntents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuiltInIntents service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInIntents">REST API Reference for ListBuiltInIntents Operation</seealso>
        Task<ListBuiltInIntentsResponse> ListBuiltInIntentsAsync(ListBuiltInIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuiltInSlotTypes



        /// <summary>
        /// Gets a list of built-in slot types that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBuiltInSlotTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuiltInSlotTypes service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListBuiltInSlotTypes">REST API Reference for ListBuiltInSlotTypes Operation</seealso>
        Task<ListBuiltInSlotTypesResponse> ListBuiltInSlotTypesAsync(ListBuiltInSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListIntents



        /// <summary>
        /// Get a list of intents that meet the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntents service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListIntents">REST API Reference for ListIntents Operation</seealso>
        Task<ListIntentsResponse> ListIntentsAsync(ListIntentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSlots



        /// <summary>
        /// Gets a list of slots that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSlots service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlots">REST API Reference for ListSlots Operation</seealso>
        Task<ListSlotsResponse> ListSlotsAsync(ListSlotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListSlotTypes



        /// <summary>
        /// Gets a list of slot types that match the specified criteria.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSlotTypes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSlotTypes service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListSlotTypes">REST API Reference for ListSlotTypes Operation</seealso>
        Task<ListSlotTypesResponse> ListSlotTypesAsync(ListSlotTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTagsForResource



        /// <summary>
        /// Gets a list of tags associated with a resource. Only bots, bot aliases, and bot channels
        /// can have tags associated with them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  TagResource



        /// <summary>
        /// Adds the specified tags to the specified resource. If a tag key already exists, the
        /// existing value is replaced with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UntagResource



        /// <summary>
        /// Removes tags from a bot, bot alias, or bot channel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ResourceNotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBot



        /// <summary>
        /// Updates the configuration of an existing bot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBot">REST API Reference for UpdateBot Operation</seealso>
        Task<UpdateBotResponse> UpdateBotAsync(UpdateBotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBotAlias



        /// <summary>
        /// Updates the configuration of an existing bot alias.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotAlias service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBotAlias service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotAlias">REST API Reference for UpdateBotAlias Operation</seealso>
        Task<UpdateBotAliasResponse> UpdateBotAliasAsync(UpdateBotAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateBotLocale



        /// <summary>
        /// Updates the settings that a bot has for a specific locale.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBotLocale service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBotLocale service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateBotLocale">REST API Reference for UpdateBotLocale Operation</seealso>
        Task<UpdateBotLocaleResponse> UpdateBotLocaleAsync(UpdateBotLocaleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateIntent



        /// <summary>
        /// Updates the settings for an intent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateIntent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateIntent service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateIntent">REST API Reference for UpdateIntent Operation</seealso>
        Task<UpdateIntentResponse> UpdateIntentAsync(UpdateIntentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSlot



        /// <summary>
        /// Updates the settings for a slot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSlot service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlot">REST API Reference for UpdateSlot Operation</seealso>
        Task<UpdateSlotResponse> UpdateSlotAsync(UpdateSlotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateSlotType



        /// <summary>
        /// Updates the configuration of an existing slot type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlotType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSlotType service method, as returned by LexModelsV2.</returns>
        /// <exception cref="Amazon.LexModelsV2.Model.ConflictException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.InternalServerException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.PreconditionFailedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ServiceQuotaExceededException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ThrottlingException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.LexModelsV2.Model.ValidationException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/models.lex.v2-2020-08-07/UpdateSlotType">REST API Reference for UpdateSlotType Operation</seealso>
        Task<UpdateSlotTypeResponse> UpdateSlotTypeAsync(UpdateSlotTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}