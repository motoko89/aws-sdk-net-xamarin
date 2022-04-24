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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateServerConfig operation.
    /// Updates the configuration of the specified server.
    /// </summary>
    public partial class UpdateServerConfigRequest : AmazonMigrationHubStrategyRecommendationsRequest
    {
        private string _serverId;
        private StrategyOption _strategyOption;

        /// <summary>
        /// Gets and sets the property ServerId. 
        /// <para>
        ///  The ID of the server. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=27)]
        public string ServerId
        {
            get { return this._serverId; }
            set { this._serverId = value; }
        }

        // Check to see if ServerId property is set
        internal bool IsSetServerId()
        {
            return this._serverId != null;
        }

        /// <summary>
        /// Gets and sets the property StrategyOption. 
        /// <para>
        ///  The preferred strategy options for the application component. See the response from
        /// <a>GetServerStrategies</a>.
        /// </para>
        /// </summary>
        public StrategyOption StrategyOption
        {
            get { return this._strategyOption; }
            set { this._strategyOption = value; }
        }

        // Check to see if StrategyOption property is set
        internal bool IsSetStrategyOption()
        {
            return this._strategyOption != null;
        }

    }
}