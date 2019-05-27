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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.GameLift.Model;
using Amazon.GameLift.Model.Internal.MarshallTransformations;
using Amazon.GameLift.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.GameLift
{
    /// <summary>
    /// Implementation for accessing GameLift
    ///
    /// Amazon GameLift Service 
    /// <para>
    ///  Amazon GameLift is a managed service for developers who need a scalable, dedicated
    /// server solution for their multiplayer games. Use Amazon GameLift for these tasks:
    /// (1) set up computing resources and deploy your game servers, (2) run game sessions
    /// and get players into games, (3) automatically scale your resources to meet player
    /// demand and manage costs, and (4) track in-depth metrics on game server performance
    /// and player usage.
    /// </para>
    ///  
    /// <para>
    /// When setting up hosting resources, you can deploy your custom game server or use the
    /// Amazon GameLift Realtime Servers. Realtime Servers gives you the ability to quickly
    /// stand up lightweight, efficient game servers with the core Amazon GameLift infrastructure
    /// already built in.
    /// </para>
    ///  
    /// <para>
    ///  <b>Get Amazon GameLift Tools and Resources</b> 
    /// </para>
    ///  
    /// <para>
    /// This reference guide describes the low-level service API for Amazon GameLift and provides
    /// links to language-specific SDK reference topics. See also <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-components.html">
    /// Amazon GameLift Tools and Resources</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>API Summary</b> 
    /// </para>
    ///  
    /// <para>
    /// The Amazon GameLift service API includes two key sets of actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Manage game sessions and player access -- Integrate this functionality into game client
    /// services in order to create new game sessions, retrieve information on existing game
    /// sessions; reserve a player slot in a game session, request matchmaking, etc.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Configure and manage game server resources -- Manage your Amazon GameLift hosting
    /// resources, including builds, scripts, fleets, queues, and aliases. Set up matchmakers,
    /// configure auto-scaling, retrieve game logs, and get hosting and game metrics.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b> <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html">
    /// Task-based list of API actions</a> </b> 
    /// </para>
    /// </summary>
    public partial class AmazonGameLiftClient : AmazonServiceClient, IAmazonGameLift
    {
        private static IServiceMetadata serviceMetadata = new AmazonGameLiftMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
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
        public AmazonGameLiftClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig()) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
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
        public AmazonGameLiftClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonGameLiftConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonGameLiftClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AmazonGameLiftConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonGameLiftClient(AWSCredentials credentials)
            : this(credentials, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Credentials and an
        /// AmazonGameLiftClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(AWSCredentials credentials, AmazonGameLiftConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonGameLiftConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonGameLiftConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonGameLiftConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonGameLiftClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonGameLiftClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonGameLiftClient Configuration Object</param>
        public AmazonGameLiftClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonGameLiftConfig clientConfig)
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


        #region  AcceptMatch

        internal virtual AcceptMatchResponse AcceptMatch(AcceptMatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return Invoke<AcceptMatchResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptMatch operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptMatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/AcceptMatch">REST API Reference for AcceptMatch Operation</seealso>
        public virtual Task<AcceptMatchResponse> AcceptMatchAsync(AcceptMatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptMatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptMatchResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptMatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateAlias

        internal virtual CreateAliasResponse CreateAlias(CreateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return Invoke<CreateAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateAlias">REST API Reference for CreateAlias Operation</seealso>
        public virtual Task<CreateAliasResponse> CreateAliasAsync(CreateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBuild

        internal virtual CreateBuildResponse CreateBuild(CreateBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return Invoke<CreateBuildResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateBuild">REST API Reference for CreateBuild Operation</seealso>
        public virtual Task<CreateBuildResponse> CreateBuildAsync(CreateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGameSession

        internal virtual CreateGameSessionResponse CreateGameSession(CreateGameSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSession">REST API Reference for CreateGameSession Operation</seealso>
        public virtual Task<CreateGameSessionResponse> CreateGameSessionAsync(CreateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGameSessionQueue

        internal virtual CreateGameSessionQueueResponse CreateGameSessionQueue(CreateGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<CreateGameSessionQueueResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGameSessionQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateGameSessionQueue">REST API Reference for CreateGameSessionQueue Operation</seealso>
        public virtual Task<CreateGameSessionQueueResponse> CreateGameSessionQueueAsync(CreateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGameSessionQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMatchmakingConfiguration

        internal virtual CreateMatchmakingConfigurationResponse CreateMatchmakingConfiguration(CreateMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingConfiguration">REST API Reference for CreateMatchmakingConfiguration Operation</seealso>
        public virtual Task<CreateMatchmakingConfigurationResponse> CreateMatchmakingConfigurationAsync(CreateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMatchmakingRuleSet

        internal virtual CreateMatchmakingRuleSetResponse CreateMatchmakingRuleSet(CreateMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<CreateMatchmakingRuleSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMatchmakingRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateMatchmakingRuleSet">REST API Reference for CreateMatchmakingRuleSet Operation</seealso>
        public virtual Task<CreateMatchmakingRuleSetResponse> CreateMatchmakingRuleSetAsync(CreateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlayerSession

        internal virtual CreatePlayerSessionResponse CreatePlayerSession(CreatePlayerSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionResponse>(request, options);
        }


        /// <summary>
        /// Reserves an open player slot in an active game session. Before a player can be added,
        /// a game session must have an <code>ACTIVE</code> status, have a creation policy of
        /// <code>ALLOW_ALL</code>, and have an open player slot. To add a group of players to
        /// a game session, use <a>CreatePlayerSessions</a>. When the player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create a player session, specify a game session ID, player ID, and optionally a
        /// string of player data. If successful, a slot is reserved in the game session for the
        /// player and a new <a>PlayerSession</a> object is returned. Player sessions cannot be
        /// updated. 
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for the game session to add a player to.</param>
        /// <param name="playerId">Unique identifier for a player. Player IDs are developer-defined.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlayerSession service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(string gameSessionId, string playerId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePlayerSessionRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerId = playerId;
            return CreatePlayerSessionAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSession">REST API Reference for CreatePlayerSession Operation</seealso>
        public virtual Task<CreatePlayerSessionResponse> CreatePlayerSessionAsync(CreatePlayerSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlayerSessions

        internal virtual CreatePlayerSessionsResponse CreatePlayerSessions(CreatePlayerSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<CreatePlayerSessionsResponse>(request, options);
        }


        /// <summary>
        /// Reserves open slots in a game session for a group of players. Before players can be
        /// added, a game session must have an <code>ACTIVE</code> status, have a creation policy
        /// of <code>ALLOW_ALL</code>, and have an open player slot. To add a single player to
        /// a game session, use <a>CreatePlayerSession</a>. When a player connects to the game
        /// server and references a player session ID, the game server contacts the Amazon GameLift
        /// service to validate the player reservation and accept the player.
        /// 
        ///  
        /// <para>
        /// To create player sessions, specify a game session ID, a list of player IDs, and optionally
        /// a set of player data strings. If successful, a slot is reserved in the game session
        /// for each player and a set of new <a>PlayerSession</a> objects is returned. Player
        /// sessions cannot be updated.
        /// </para>
        ///  
        /// <para>
        ///  <i>Available in Amazon GameLift Local.</i> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreatePlayerSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreatePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribePlayerSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for the game session to add players to.</param>
        /// <param name="playerIds">List of unique identifiers for the players to be added.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePlayerSessions service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.GameSessionFullException">
        /// The game instance is currently full and cannot allow the requested player(s) to join.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidGameSessionStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the game instance. Resolve the conflict before
        /// retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(string gameSessionId, List<string> playerIds, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreatePlayerSessionsRequest();
            request.GameSessionId = gameSessionId;
            request.PlayerIds = playerIds;
            return CreatePlayerSessionsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlayerSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreatePlayerSessions">REST API Reference for CreatePlayerSessions Operation</seealso>
        public virtual Task<CreatePlayerSessionsResponse> CreatePlayerSessionsAsync(CreatePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlayerSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateScript

        internal virtual CreateScriptResponse CreateScript(CreateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return Invoke<CreateScriptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateScript">REST API Reference for CreateScript Operation</seealso>
        public virtual Task<CreateScriptResponse> CreateScriptAsync(CreateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<CreateScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringAuthorization

        internal virtual CreateVpcPeeringAuthorizationResponse CreateVpcPeeringAuthorization(CreateVpcPeeringAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringAuthorization">REST API Reference for CreateVpcPeeringAuthorization Operation</seealso>
        public virtual Task<CreateVpcPeeringAuthorizationResponse> CreateVpcPeeringAuthorizationAsync(CreateVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAlias

        internal virtual DeleteAliasResponse DeleteAlias(DeleteAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return Invoke<DeleteAliasResponse>(request, options);
        }


        /// <summary>
        /// Deletes an alias. This action removes all record of the alias. Game clients attempting
        /// to access a server process using the deleted alias receive an error. To delete an
        /// alias, specify the alias ID to be deleted.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteAliasRequest();
            request.AliasId = aliasId;
            return DeleteAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteAlias">REST API Reference for DeleteAlias Operation</seealso>
        public virtual Task<DeleteAliasResponse> DeleteAliasAsync(DeleteAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBuild

        internal virtual DeleteBuildResponse DeleteBuild(DeleteBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return Invoke<DeleteBuildResponse>(request, options);
        }


        /// <summary>
        /// Deletes a build. This action permanently deletes the build record and any uploaded
        /// build files.
        /// 
        ///  
        /// <para>
        /// To delete a build, specify its ID. Deleting a build does not affect the status of
        /// any active fleets using the build, but you can no longer create new fleets with the
        /// deleted build.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/build-intro.html">
        /// Working with Builds</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">Unique identifier for a build to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        public virtual Task<DeleteBuildResponse> DeleteBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBuildRequest();
            request.BuildId = buildId;
            return DeleteBuildAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteBuild">REST API Reference for DeleteBuild Operation</seealso>
        public virtual Task<DeleteBuildResponse> DeleteBuildAsync(DeleteBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleet

        internal virtual DeleteFleetResponse DeleteFleet(DeleteFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetResponse>(request, options);
        }


        /// <summary>
        /// Deletes everything related to a fleet. Before deleting a fleet, you must set the fleet's
        /// desired capacity to zero. See <a>UpdateFleetCapacity</a>.
        /// 
        ///  
        /// <para>
        /// This action removes the fleet's resources and the fleet record. Once a fleet is deleted,
        /// you can no longer use that fleet.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">
        /// Working with Fleets</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="fleetId">Unique identifier for a fleet to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteFleet service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidFleetStatusException">
        /// The requested operation would cause a conflict with the current state of a resource
        /// associated with the request and/or the fleet. Resolve the conflict before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteFleetRequest();
            request.FleetId = fleetId;
            return DeleteFleetAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteFleet">REST API Reference for DeleteFleet Operation</seealso>
        public virtual Task<DeleteFleetResponse> DeleteFleetAsync(DeleteFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGameSessionQueue

        internal virtual DeleteGameSessionQueueResponse DeleteGameSessionQueue(DeleteGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteGameSessionQueueResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGameSessionQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteGameSessionQueue">REST API Reference for DeleteGameSessionQueue Operation</seealso>
        public virtual Task<DeleteGameSessionQueueResponse> DeleteGameSessionQueueAsync(DeleteGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGameSessionQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMatchmakingConfiguration

        internal virtual DeleteMatchmakingConfigurationResponse DeleteMatchmakingConfiguration(DeleteMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingConfiguration">REST API Reference for DeleteMatchmakingConfiguration Operation</seealso>
        public virtual Task<DeleteMatchmakingConfigurationResponse> DeleteMatchmakingConfigurationAsync(DeleteMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMatchmakingRuleSet

        internal virtual DeleteMatchmakingRuleSetResponse DeleteMatchmakingRuleSet(DeleteMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<DeleteMatchmakingRuleSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMatchmakingRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteMatchmakingRuleSet">REST API Reference for DeleteMatchmakingRuleSet Operation</seealso>
        public virtual Task<DeleteMatchmakingRuleSetResponse> DeleteMatchmakingRuleSetAsync(DeleteMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScalingPolicy

        internal virtual DeleteScalingPolicyResponse DeleteScalingPolicy(DeleteScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteScalingPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScalingPolicy">REST API Reference for DeleteScalingPolicy Operation</seealso>
        public virtual Task<DeleteScalingPolicyResponse> DeleteScalingPolicyAsync(DeleteScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteScript

        internal virtual DeleteScriptResponse DeleteScript(DeleteScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return Invoke<DeleteScriptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteScript">REST API Reference for DeleteScript Operation</seealso>
        public virtual Task<DeleteScriptResponse> DeleteScriptAsync(DeleteScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteScriptResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringAuthorization

        internal virtual DeleteVpcPeeringAuthorizationResponse DeleteVpcPeeringAuthorization(DeleteVpcPeeringAuthorizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringAuthorization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringAuthorization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringAuthorization">REST API Reference for DeleteVpcPeeringAuthorization Operation</seealso>
        public virtual Task<DeleteVpcPeeringAuthorizationResponse> DeleteVpcPeeringAuthorizationAsync(DeleteVpcPeeringAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringAuthorizationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAlias

        internal virtual DescribeAliasResponse DescribeAlias(DescribeAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return Invoke<DescribeAliasResponse>(request, options);
        }


        /// <summary>
        /// Retrieves properties for an alias. This operation returns all alias metadata and settings.
        /// To get an alias's target fleet ID only, use <code>ResolveAlias</code>. 
        /// 
        ///  
        /// <para>
        /// To get alias properties, specify the alias ID. If successful, the requested alias
        /// record is returned.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">Unique identifier for a fleet alias. Specify the alias you want to retrieve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeAliasRequest();
            request.AliasId = aliasId;
            return DescribeAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeAlias">REST API Reference for DescribeAlias Operation</seealso>
        public virtual Task<DescribeAliasResponse> DescribeAliasAsync(DescribeAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAliasResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBuild

        internal virtual DescribeBuildResponse DescribeBuild(DescribeBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return Invoke<DescribeBuildResponse>(request, options);
        }


        /// <summary>
        /// Retrieves properties for a build. To request a build record, specify a build ID. If
        /// successful, an object containing the build properties is returned.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/build-intro.html">
        /// Working with Builds</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">Unique identifier for a build to retrieve properties for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBuild service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeBuildRequest();
            request.BuildId = buildId;
            return DescribeBuildAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeBuild">REST API Reference for DescribeBuild Operation</seealso>
        public virtual Task<DescribeBuildResponse> DescribeBuildAsync(DescribeBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBuildResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEC2InstanceLimits

        internal virtual DescribeEC2InstanceLimitsResponse DescribeEC2InstanceLimits(DescribeEC2InstanceLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeEC2InstanceLimitsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the following information for the specified EC2 instance type:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// maximum number of instances allowed per AWS account (service limit)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// current usage level for the AWS account
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Service limits vary depending on region. Available regions for Amazon GameLift can
        /// be found in the AWS Management Console for Amazon GameLift (see the drop-down list
        /// in the upper right corner).
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">
        /// Working with Fleets</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="ec2InstanceType">Name of an EC2 instance type that is supported in Amazon GameLift. A fleet instance type determines the computing resources of each instance in the fleet, including CPU, memory, storage, and networking capacity. Amazon GameLift supports the following EC2 instance types. See <a href="http://aws.amazon.com/ec2/instance-types/">Amazon EC2 Instance Types</a> for detailed descriptions. Leave this parameter blank to retrieve limits for all types.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEC2InstanceLimits service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(EC2InstanceType ec2InstanceType, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeEC2InstanceLimitsRequest();
            request.EC2InstanceType = ec2InstanceType;
            return DescribeEC2InstanceLimitsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEC2InstanceLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEC2InstanceLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeEC2InstanceLimits">REST API Reference for DescribeEC2InstanceLimits Operation</seealso>
        public virtual Task<DescribeEC2InstanceLimitsResponse> DescribeEC2InstanceLimitsAsync(DescribeEC2InstanceLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEC2InstanceLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEC2InstanceLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEC2InstanceLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetAttributes

        internal virtual DescribeFleetAttributesResponse DescribeFleetAttributes(DescribeFleetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetAttributes">REST API Reference for DescribeFleetAttributes Operation</seealso>
        public virtual Task<DescribeFleetAttributesResponse> DescribeFleetAttributesAsync(DescribeFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetCapacity

        internal virtual DescribeFleetCapacityResponse DescribeFleetCapacity(DescribeFleetCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetCapacityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetCapacity">REST API Reference for DescribeFleetCapacity Operation</seealso>
        public virtual Task<DescribeFleetCapacityResponse> DescribeFleetCapacityAsync(DescribeFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetEvents

        internal virtual DescribeFleetEventsResponse DescribeFleetEvents(DescribeFleetEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetEventsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetEvents">REST API Reference for DescribeFleetEvents Operation</seealso>
        public virtual Task<DescribeFleetEventsResponse> DescribeFleetEventsAsync(DescribeFleetEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetPortSettings

        internal virtual DescribeFleetPortSettingsResponse DescribeFleetPortSettings(DescribeFleetPortSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetPortSettingsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the inbound connection permissions for a fleet. Connection permissions include
        /// a range of IP addresses and port settings that incoming traffic can use to access
        /// server processes in the fleet. To get a fleet's inbound connection permissions, specify
        /// a fleet ID. If successful, a collection of <a>IpPermission</a> objects is returned
        /// for the requested fleet ID. If the requested fleet has been deleted, the result set
        /// is empty.
        /// 
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">
        /// Working with Fleets</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListFleets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteFleet</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Describe fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetUtilization</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeRuntimeConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeEC2InstanceLimits</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeFleetEvents</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Update fleets:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UpdateFleetAttributes</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetCapacity</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateFleetPortSettings</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateRuntimeConfiguration</a> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Manage fleet actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartFleetActions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopFleetActions</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="fleetId">Unique identifier for a fleet to retrieve port settings for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFleetPortSettings service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(string fleetId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeFleetPortSettingsRequest();
            request.FleetId = fleetId;
            return DescribeFleetPortSettingsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetPortSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetPortSettings">REST API Reference for DescribeFleetPortSettings Operation</seealso>
        public virtual Task<DescribeFleetPortSettingsResponse> DescribeFleetPortSettingsAsync(DescribeFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetPortSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetUtilization

        internal virtual DescribeFleetUtilizationResponse DescribeFleetUtilization(DescribeFleetUtilizationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetUtilizationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetUtilization operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetUtilization operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeFleetUtilization">REST API Reference for DescribeFleetUtilization Operation</seealso>
        public virtual Task<DescribeFleetUtilizationResponse> DescribeFleetUtilizationAsync(DescribeFleetUtilizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetUtilizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetUtilizationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetUtilizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionDetails

        internal virtual DescribeGameSessionDetailsResponse DescribeGameSessionDetails(DescribeGameSessionDetailsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionDetailsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionDetails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionDetails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionDetails">REST API Reference for DescribeGameSessionDetails Operation</seealso>
        public virtual Task<DescribeGameSessionDetailsResponse> DescribeGameSessionDetailsAsync(DescribeGameSessionDetailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionDetailsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionDetailsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionDetailsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionPlacement

        internal virtual DescribeGameSessionPlacementResponse DescribeGameSessionPlacement(DescribeGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionPlacementResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionPlacement">REST API Reference for DescribeGameSessionPlacement Operation</seealso>
        public virtual Task<DescribeGameSessionPlacementResponse> DescribeGameSessionPlacementAsync(DescribeGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessionQueues

        internal virtual DescribeGameSessionQueuesResponse DescribeGameSessionQueues(DescribeGameSessionQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionQueuesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessionQueues operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessionQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessionQueues">REST API Reference for DescribeGameSessionQueues Operation</seealso>
        public virtual Task<DescribeGameSessionQueuesResponse> DescribeGameSessionQueuesAsync(DescribeGameSessionQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionQueuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGameSessions

        internal virtual DescribeGameSessionsResponse DescribeGameSessions(DescribeGameSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribeGameSessionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGameSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeGameSessions">REST API Reference for DescribeGameSessions Operation</seealso>
        public virtual Task<DescribeGameSessionsResponse> DescribeGameSessionsAsync(DescribeGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGameSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmaking

        internal virtual DescribeMatchmakingResponse DescribeMatchmaking(DescribeMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmaking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmaking">REST API Reference for DescribeMatchmaking Operation</seealso>
        public virtual Task<DescribeMatchmakingResponse> DescribeMatchmakingAsync(DescribeMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmakingConfigurations

        internal virtual DescribeMatchmakingConfigurationsResponse DescribeMatchmakingConfigurations(DescribeMatchmakingConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmakingConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingConfigurations">REST API Reference for DescribeMatchmakingConfigurations Operation</seealso>
        public virtual Task<DescribeMatchmakingConfigurationsResponse> DescribeMatchmakingConfigurationsAsync(DescribeMatchmakingConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMatchmakingRuleSets

        internal virtual DescribeMatchmakingRuleSetsResponse DescribeMatchmakingRuleSets(DescribeMatchmakingRuleSetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeMatchmakingRuleSetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMatchmakingRuleSets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMatchmakingRuleSets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeMatchmakingRuleSets">REST API Reference for DescribeMatchmakingRuleSets Operation</seealso>
        public virtual Task<DescribeMatchmakingRuleSetsResponse> DescribeMatchmakingRuleSetsAsync(DescribeMatchmakingRuleSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMatchmakingRuleSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMatchmakingRuleSetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMatchmakingRuleSetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlayerSessions

        internal virtual DescribePlayerSessionsResponse DescribePlayerSessions(DescribePlayerSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return Invoke<DescribePlayerSessionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlayerSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlayerSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribePlayerSessions">REST API Reference for DescribePlayerSessions Operation</seealso>
        public virtual Task<DescribePlayerSessionsResponse> DescribePlayerSessionsAsync(DescribePlayerSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlayerSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlayerSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlayerSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRuntimeConfiguration

        internal virtual DescribeRuntimeConfigurationResponse DescribeRuntimeConfiguration(DescribeRuntimeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRuntimeConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRuntimeConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeRuntimeConfiguration">REST API Reference for DescribeRuntimeConfiguration Operation</seealso>
        public virtual Task<DescribeRuntimeConfigurationResponse> DescribeRuntimeConfigurationAsync(DescribeRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRuntimeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScalingPolicies

        internal virtual DescribeScalingPoliciesResponse DescribeScalingPolicies(DescribeScalingPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeScalingPoliciesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScalingPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScalingPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScalingPolicies">REST API Reference for DescribeScalingPolicies Operation</seealso>
        public virtual Task<DescribeScalingPoliciesResponse> DescribeScalingPoliciesAsync(DescribeScalingPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScalingPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScalingPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScalingPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScript

        internal virtual DescribeScriptResponse DescribeScript(DescribeScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return Invoke<DescribeScriptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeScript">REST API Reference for DescribeScript Operation</seealso>
        public virtual Task<DescribeScriptResponse> DescribeScriptAsync(DescribeScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScriptResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringAuthorizations

        internal virtual DescribeVpcPeeringAuthorizationsResponse DescribeVpcPeeringAuthorizations(DescribeVpcPeeringAuthorizationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringAuthorizationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringAuthorizations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringAuthorizations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringAuthorizations">REST API Reference for DescribeVpcPeeringAuthorizations Operation</seealso>
        public virtual Task<DescribeVpcPeeringAuthorizationsResponse> DescribeVpcPeeringAuthorizationsAsync(DescribeVpcPeeringAuthorizationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringAuthorizationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringAuthorizationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringAuthorizationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetGameSessionLogUrl

        internal virtual GetGameSessionLogUrlResponse GetGameSessionLogUrl(GetGameSessionLogUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return Invoke<GetGameSessionLogUrlResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the location of stored game session logs for a specified game session. When
        /// a game session is terminated, Amazon GameLift automatically stores the logs in Amazon
        /// S3 and retains them for 14 days. Use this URL to download the logs.
        /// 
        ///  <note> 
        /// <para>
        /// See the <a href="https://docs.aws.amazon.com/general/latest/gr/aws_service_limits.html#limits_gamelift">AWS
        /// Service Limits</a> page for maximum log file sizes. Log files that exceed this limit
        /// are not saved.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <a>CreateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionDetails</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>SearchGameSessions</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateGameSession</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetGameSessionLogUrl</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Game session placements
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>StartGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeGameSessionPlacement</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>StopGameSessionPlacement</a> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        /// <param name="gameSessionId">Unique identifier for the game session to get logs for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetGameSessionLogUrl service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(string gameSessionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetGameSessionLogUrlRequest();
            request.GameSessionId = gameSessionId;
            return GetGameSessionLogUrlAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetGameSessionLogUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetGameSessionLogUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetGameSessionLogUrl">REST API Reference for GetGameSessionLogUrl Operation</seealso>
        public virtual Task<GetGameSessionLogUrlResponse> GetGameSessionLogUrlAsync(GetGameSessionLogUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetGameSessionLogUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetGameSessionLogUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetGameSessionLogUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetInstanceAccess

        internal virtual GetInstanceAccessResponse GetInstanceAccess(GetInstanceAccessRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return Invoke<GetInstanceAccessResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetInstanceAccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetInstanceAccess operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/GetInstanceAccess">REST API Reference for GetInstanceAccess Operation</seealso>
        public virtual Task<GetInstanceAccessResponse> GetInstanceAccessAsync(GetInstanceAccessRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetInstanceAccessRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetInstanceAccessResponseUnmarshaller.Instance;

            return InvokeAsync<GetInstanceAccessResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAliases

        internal virtual ListAliasesResponse ListAliases(ListAliasesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return Invoke<ListAliasesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAliases operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListAliases">REST API Reference for ListAliases Operation</seealso>
        public virtual Task<ListAliasesResponse> ListAliasesAsync(ListAliasesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAliasesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAliasesResponseUnmarshaller.Instance;

            return InvokeAsync<ListAliasesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBuilds

        internal virtual ListBuildsResponse ListBuilds(ListBuildsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return Invoke<ListBuildsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuilds operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuilds operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListBuilds">REST API Reference for ListBuilds Operation</seealso>
        public virtual Task<ListBuildsResponse> ListBuildsAsync(ListBuildsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBuildsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBuildsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBuildsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListFleets

        internal virtual ListFleetsResponse ListFleets(ListFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return Invoke<ListFleetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListFleets">REST API Reference for ListFleets Operation</seealso>
        public virtual Task<ListFleetsResponse> ListFleetsAsync(ListFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListScripts

        internal virtual ListScriptsResponse ListScripts(ListScriptsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return Invoke<ListScriptsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListScripts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScripts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ListScripts">REST API Reference for ListScripts Operation</seealso>
        public virtual Task<ListScriptsResponse> ListScriptsAsync(ListScriptsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListScriptsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListScriptsResponseUnmarshaller.Instance;

            return InvokeAsync<ListScriptsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutScalingPolicy

        internal virtual PutScalingPolicyResponse PutScalingPolicy(PutScalingPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return Invoke<PutScalingPolicyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutScalingPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutScalingPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/PutScalingPolicy">REST API Reference for PutScalingPolicy Operation</seealso>
        public virtual Task<PutScalingPolicyResponse> PutScalingPolicyAsync(PutScalingPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutScalingPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutScalingPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutScalingPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestUploadCredentials

        internal virtual RequestUploadCredentialsResponse RequestUploadCredentials(RequestUploadCredentialsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return Invoke<RequestUploadCredentialsResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a fresh set of credentials for use when uploading a new set of game build
        /// files to Amazon GameLift's Amazon S3. This is done as part of the build creation process;
        /// see <a>CreateBuild</a>.
        /// 
        ///  
        /// <para>
        /// To request new credentials, specify the build ID as returned with an initial <code>CreateBuild</code>
        /// request. If successful, a new set of credentials are returned, along with the S3 storage
        /// location associated with the build ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>Learn more</b> 
        /// </para>
        ///  
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">Uploading
        /// Your Game</a> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuilds</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateBuild</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBuild</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="buildId">Unique identifier for a build to get credentials for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestUploadCredentials service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(string buildId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RequestUploadCredentialsRequest();
            request.BuildId = buildId;
            return RequestUploadCredentialsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestUploadCredentials operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestUploadCredentials operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/RequestUploadCredentials">REST API Reference for RequestUploadCredentials Operation</seealso>
        public virtual Task<RequestUploadCredentialsResponse> RequestUploadCredentialsAsync(RequestUploadCredentialsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestUploadCredentialsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestUploadCredentialsResponseUnmarshaller.Instance;

            return InvokeAsync<RequestUploadCredentialsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResolveAlias

        internal virtual ResolveAliasResponse ResolveAlias(ResolveAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return Invoke<ResolveAliasResponse>(request, options);
        }


        /// <summary>
        /// Retrieves the fleet ID that a specified alias is currently pointing to.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ResolveAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="aliasId">Unique identifier for the alias you want to resolve.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResolveAlias service method, as returned by GameLift.</returns>
        /// <exception cref="Amazon.GameLift.Model.InternalServiceException">
        /// The service encountered an unrecoverable internal failure while processing the request.
        /// Clients can retry such requests immediately or after a waiting period.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.InvalidRequestException">
        /// One or more parameter values in the request are invalid. Correct the invalid parameter
        /// values before retrying.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.NotFoundException">
        /// A service resource associated with the request could not be found. Clients should
        /// not retry such requests.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.TerminalRoutingStrategyException">
        /// The service is unable to resolve the routing for a particular alias because it has
        /// a terminal <a>RoutingStrategy</a> associated with it. The message returned in this
        /// exception is the message defined in the routing strategy itself. Such requests should
        /// only be retried if the routing strategy for the specified alias is modified.
        /// </exception>
        /// <exception cref="Amazon.GameLift.Model.UnauthorizedException">
        /// The client failed authentication. Clients should not retry such requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(string aliasId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ResolveAliasRequest();
            request.AliasId = aliasId;
            return ResolveAliasAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResolveAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResolveAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ResolveAlias">REST API Reference for ResolveAlias Operation</seealso>
        public virtual Task<ResolveAliasResponse> ResolveAliasAsync(ResolveAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResolveAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResolveAliasResponseUnmarshaller.Instance;

            return InvokeAsync<ResolveAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchGameSessions

        internal virtual SearchGameSessionsResponse SearchGameSessions(SearchGameSessionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return Invoke<SearchGameSessionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchGameSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchGameSessions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/SearchGameSessions">REST API Reference for SearchGameSessions Operation</seealso>
        public virtual Task<SearchGameSessionsResponse> SearchGameSessionsAsync(SearchGameSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchGameSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchGameSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<SearchGameSessionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartFleetActions

        internal virtual StartFleetActionsResponse StartFleetActions(StartFleetActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StartFleetActionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartFleetActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartFleetActions">REST API Reference for StartFleetActions Operation</seealso>
        public virtual Task<StartFleetActionsResponse> StartFleetActionsAsync(StartFleetActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartFleetActionsResponseUnmarshaller.Instance;

            return InvokeAsync<StartFleetActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartGameSessionPlacement

        internal virtual StartGameSessionPlacementResponse StartGameSessionPlacement(StartGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StartGameSessionPlacementResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartGameSessionPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartGameSessionPlacement">REST API Reference for StartGameSessionPlacement Operation</seealso>
        public virtual Task<StartGameSessionPlacementResponse> StartGameSessionPlacementAsync(StartGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StartGameSessionPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMatchBackfill

        internal virtual StartMatchBackfillResponse StartMatchBackfill(StartMatchBackfillRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return Invoke<StartMatchBackfillResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchBackfill operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchBackfill operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchBackfill">REST API Reference for StartMatchBackfill Operation</seealso>
        public virtual Task<StartMatchBackfillResponse> StartMatchBackfillAsync(StartMatchBackfillRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchBackfillRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchBackfillResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchBackfillResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMatchmaking

        internal virtual StartMatchmakingResponse StartMatchmaking(StartMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StartMatchmakingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartMatchmaking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StartMatchmaking">REST API Reference for StartMatchmaking Operation</seealso>
        public virtual Task<StartMatchmakingResponse> StartMatchmakingAsync(StartMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StartMatchmakingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopFleetActions

        internal virtual StopFleetActionsResponse StopFleetActions(StopFleetActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return Invoke<StopFleetActionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopFleetActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopFleetActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopFleetActions">REST API Reference for StopFleetActions Operation</seealso>
        public virtual Task<StopFleetActionsResponse> StopFleetActionsAsync(StopFleetActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopFleetActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopFleetActionsResponseUnmarshaller.Instance;

            return InvokeAsync<StopFleetActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopGameSessionPlacement

        internal virtual StopGameSessionPlacementResponse StopGameSessionPlacement(StopGameSessionPlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return Invoke<StopGameSessionPlacementResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopGameSessionPlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopGameSessionPlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopGameSessionPlacement">REST API Reference for StopGameSessionPlacement Operation</seealso>
        public virtual Task<StopGameSessionPlacementResponse> StopGameSessionPlacementAsync(StopGameSessionPlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopGameSessionPlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopGameSessionPlacementResponseUnmarshaller.Instance;

            return InvokeAsync<StopGameSessionPlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopMatchmaking

        internal virtual StopMatchmakingResponse StopMatchmaking(StopMatchmakingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return Invoke<StopMatchmakingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopMatchmaking operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopMatchmaking operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/StopMatchmaking">REST API Reference for StopMatchmaking Operation</seealso>
        public virtual Task<StopMatchmakingResponse> StopMatchmakingAsync(StopMatchmakingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopMatchmakingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopMatchmakingResponseUnmarshaller.Instance;

            return InvokeAsync<StopMatchmakingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAlias

        internal virtual UpdateAliasResponse UpdateAlias(UpdateAliasRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return Invoke<UpdateAliasResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAlias operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateAlias">REST API Reference for UpdateAlias Operation</seealso>
        public virtual Task<UpdateAliasResponse> UpdateAliasAsync(UpdateAliasRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAliasRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAliasResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAliasResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateBuild

        internal virtual UpdateBuildResponse UpdateBuild(UpdateBuildRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return Invoke<UpdateBuildResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateBuild operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateBuild operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateBuild">REST API Reference for UpdateBuild Operation</seealso>
        public virtual Task<UpdateBuildResponse> UpdateBuildAsync(UpdateBuildRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateBuildRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBuildResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBuildResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetAttributes

        internal virtual UpdateFleetAttributesResponse UpdateFleetAttributes(UpdateFleetAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetAttributes">REST API Reference for UpdateFleetAttributes Operation</seealso>
        public virtual Task<UpdateFleetAttributesResponse> UpdateFleetAttributesAsync(UpdateFleetAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetCapacity

        internal virtual UpdateFleetCapacityResponse UpdateFleetCapacity(UpdateFleetCapacityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetCapacityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetCapacity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetCapacity operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetCapacity">REST API Reference for UpdateFleetCapacity Operation</seealso>
        public virtual Task<UpdateFleetCapacityResponse> UpdateFleetCapacityAsync(UpdateFleetCapacityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetCapacityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetCapacityResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetCapacityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateFleetPortSettings

        internal virtual UpdateFleetPortSettingsResponse UpdateFleetPortSettings(UpdateFleetPortSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateFleetPortSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateFleetPortSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateFleetPortSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateFleetPortSettings">REST API Reference for UpdateFleetPortSettings Operation</seealso>
        public virtual Task<UpdateFleetPortSettingsResponse> UpdateFleetPortSettingsAsync(UpdateFleetPortSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateFleetPortSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateFleetPortSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateFleetPortSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameSession

        internal virtual UpdateGameSessionResponse UpdateGameSession(UpdateGameSessionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSession operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSession">REST API Reference for UpdateGameSession Operation</seealso>
        public virtual Task<UpdateGameSessionResponse> UpdateGameSessionAsync(UpdateGameSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGameSessionQueue

        internal virtual UpdateGameSessionQueueResponse UpdateGameSessionQueue(UpdateGameSessionQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return Invoke<UpdateGameSessionQueueResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGameSessionQueue operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGameSessionQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateGameSessionQueue">REST API Reference for UpdateGameSessionQueue Operation</seealso>
        public virtual Task<UpdateGameSessionQueueResponse> UpdateGameSessionQueueAsync(UpdateGameSessionQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGameSessionQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGameSessionQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGameSessionQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMatchmakingConfiguration

        internal virtual UpdateMatchmakingConfigurationResponse UpdateMatchmakingConfiguration(UpdateMatchmakingConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMatchmakingConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMatchmakingConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMatchmakingConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateMatchmakingConfiguration">REST API Reference for UpdateMatchmakingConfiguration Operation</seealso>
        public virtual Task<UpdateMatchmakingConfigurationResponse> UpdateMatchmakingConfigurationAsync(UpdateMatchmakingConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateMatchmakingConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMatchmakingConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateMatchmakingConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRuntimeConfiguration

        internal virtual UpdateRuntimeConfigurationResponse UpdateRuntimeConfiguration(UpdateRuntimeConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateRuntimeConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRuntimeConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRuntimeConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateRuntimeConfiguration">REST API Reference for UpdateRuntimeConfiguration Operation</seealso>
        public virtual Task<UpdateRuntimeConfigurationResponse> UpdateRuntimeConfigurationAsync(UpdateRuntimeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRuntimeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRuntimeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRuntimeConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateScript

        internal virtual UpdateScriptResponse UpdateScript(UpdateScriptRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return Invoke<UpdateScriptResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateScript operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateScript operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/UpdateScript">REST API Reference for UpdateScript Operation</seealso>
        public virtual Task<UpdateScriptResponse> UpdateScriptAsync(UpdateScriptRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateScriptRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateScriptResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateScriptResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateMatchmakingRuleSet

        internal virtual ValidateMatchmakingRuleSetResponse ValidateMatchmakingRuleSet(ValidateMatchmakingRuleSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return Invoke<ValidateMatchmakingRuleSetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ValidateMatchmakingRuleSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateMatchmakingRuleSet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/gamelift-2015-10-01/ValidateMatchmakingRuleSet">REST API Reference for ValidateMatchmakingRuleSet Operation</seealso>
        public virtual Task<ValidateMatchmakingRuleSetResponse> ValidateMatchmakingRuleSetAsync(ValidateMatchmakingRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateMatchmakingRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateMatchmakingRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateMatchmakingRuleSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}