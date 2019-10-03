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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Log configuration options to send to a custom log driver for the container.
    /// </summary>
    public partial class LogConfiguration
    {
        private LogDriver _logDriver;
        private Dictionary<string, string> _options = new Dictionary<string, string>();
        private List<Secret> _secretOptions = new List<Secret>();

        /// <summary>
        /// Gets and sets the property LogDriver. 
        /// <para>
        /// The log driver to use for the container. The valid values listed for this parameter
        /// are log drivers that the Amazon ECS container agent can communicate with by default.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the Fargate launch type, the supported log drivers are <code>awslogs</code>,
        /// <code>splunk</code>, and <code>awsfirelens</code>.
        /// </para>
        ///  
        /// <para>
        /// For tasks using the EC2 launch type, the supported log drivers are <code>awslogs</code>,
        /// <code>fluentd</code>, <code>gelf</code>, <code>json-file</code>, <code>journald</code>,
        /// <code>logentries</code>, <code>syslog</code>, <code>splunk</code>, and <code>awsfirelens</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>awslogs</code> log driver, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_awslogs.html">Using
        /// the awslogs Log Driver</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>awsfirelens</code> log driver, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/using_firelens.html">Custom
        /// Log Routing</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you have a custom driver that is not listed above that you would like to work with
        /// the Amazon ECS container agent, you can fork the Amazon ECS container agent project
        /// that is <a href="https://github.com/aws/amazon-ecs-agent">available on GitHub</a>
        /// and customize it to work with that driver. We encourage you to submit pull requests
        /// for changes that you would like to have included. However, Amazon Web Services does
        /// not currently support running modified copies of this software.
        /// </para>
        ///  </note> 
        /// <para>
        /// This parameter requires version 1.18 of the Docker Remote API or greater on your container
        /// instance. To check the Docker Remote API version on your container instance, log in
        /// to your container instance and run the following command: <code>sudo docker version
        /// --format '{{.Server.APIVersion}}'</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LogDriver LogDriver
        {
            get { return this._logDriver; }
            set { this._logDriver = value; }
        }

        // Check to see if LogDriver property is set
        internal bool IsSetLogDriver()
        {
            return this._logDriver != null;
        }

        /// <summary>
        /// Gets and sets the property Options. 
        /// <para>
        /// The configuration options to send to the log driver. This parameter requires version
        /// 1.19 of the Docker Remote API or greater on your container instance. To check the
        /// Docker Remote API version on your container instance, log in to your container instance
        /// and run the following command: <code>sudo docker version --format '{{.Server.APIVersion}}'</code>
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null && this._options.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecretOptions. 
        /// <para>
        /// The secrets to pass to the log configuration. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/specifying-sensitive-data.html">Specifying
        /// Sensitive Data</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public List<Secret> SecretOptions
        {
            get { return this._secretOptions; }
            set { this._secretOptions = value; }
        }

        // Check to see if SecretOptions property is set
        internal bool IsSetSecretOptions()
        {
            return this._secretOptions != null && this._secretOptions.Count > 0; 
        }

    }
}