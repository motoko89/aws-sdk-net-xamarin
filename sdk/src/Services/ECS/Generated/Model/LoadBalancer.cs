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
    /// Details on a load balancer to be used with a service or task set.
    /// 
    ///  
    /// <para>
    /// If the service is using the <code>ECS</code> deployment controller, you are limited
    /// to one load balancer or target group.
    /// </para>
    ///  
    /// <para>
    /// If the service is using the <code>CODE_DEPLOY</code> deployment controller, the service
    /// is required to use either an Application Load Balancer or Network Load Balancer. When
    /// you are creating an AWS CodeDeploy deployment group, you specify two target groups
    /// (referred to as a <code>targetGroupPair</code>). Each target group binds to a separate
    /// task set in the deployment. The load balancer can also have up to two listeners, a
    /// required listener for production traffic and an optional listener that allows you
    /// to test new revisions of the service before routing production traffic to it.
    /// </para>
    ///  
    /// <para>
    /// Services with tasks that use the <code>awsvpc</code> network mode (for example, those
    /// with the Fargate launch type) only support Application Load Balancers and Network
    /// Load Balancers. Classic Load Balancers are not supported. Also, when you create any
    /// target groups for these services, you must choose <code>ip</code> as the target type,
    /// not <code>instance</code>. Tasks that use the <code>awsvpc</code> network mode are
    /// associated with an elastic network interface, not an Amazon EC2 instance.
    /// </para>
    /// </summary>
    public partial class LoadBalancer
    {
        private string _containerName;
        private int? _containerPort;
        private string _loadBalancerName;
        private string _targetGroupArn;

        /// <summary>
        /// Gets and sets the property ContainerName. 
        /// <para>
        /// The name of the container (as it appears in a container definition) to associate with
        /// the load balancer.
        /// </para>
        /// </summary>
        public string ContainerName
        {
            get { return this._containerName; }
            set { this._containerName = value; }
        }

        // Check to see if ContainerName property is set
        internal bool IsSetContainerName()
        {
            return this._containerName != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerPort. 
        /// <para>
        /// The port on the container to associate with the load balancer. This port must correspond
        /// to a <code>containerPort</code> in the service's task definition. Your container instances
        /// must allow ingress traffic on the <code>hostPort</code> of the port mapping.
        /// </para>
        /// </summary>
        public int ContainerPort
        {
            get { return this._containerPort.GetValueOrDefault(); }
            set { this._containerPort = value; }
        }

        // Check to see if ContainerPort property is set
        internal bool IsSetContainerPort()
        {
            return this._containerPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadBalancerName. 
        /// <para>
        /// The name of the load balancer to associate with the Amazon ECS service or task set.
        /// </para>
        ///  
        /// <para>
        /// A load balancer name is only specified when using a classic load balancer. If you
        /// are using an application load balancer or a network load balancer this should be omitted.
        /// </para>
        /// </summary>
        public string LoadBalancerName
        {
            get { return this._loadBalancerName; }
            set { this._loadBalancerName = value; }
        }

        // Check to see if LoadBalancerName property is set
        internal bool IsSetLoadBalancerName()
        {
            return this._loadBalancerName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetGroupArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the Elastic Load Balancing target group or
        /// groups associated with a service or task set.
        /// </para>
        ///  
        /// <para>
        /// A target group ARN is only specified when using an application load balancer or a
        /// network load balancer. If you are using a classic load balancer this should be omitted.
        /// </para>
        ///  
        /// <para>
        /// For services using the <code>ECS</code> deployment controller, you are limited to
        /// one target group. For services using the <code>CODE_DEPLOY</code> deployment controller,
        /// you are required to define two target groups for the load balancer.
        /// </para>
        ///  <important> 
        /// <para>
        /// If your service's task definition uses the <code>awsvpc</code> network mode (which
        /// is required for the Fargate launch type), you must choose <code>ip</code> as the target
        /// type, not <code>instance</code>, because tasks that use the <code>awsvpc</code> network
        /// mode are associated with an elastic network interface, not an Amazon EC2 instance.
        /// </para>
        ///  </important>
        /// </summary>
        public string TargetGroupArn
        {
            get { return this._targetGroupArn; }
            set { this._targetGroupArn = value; }
        }

        // Check to see if TargetGroupArn property is set
        internal bool IsSetTargetGroupArn()
        {
            return this._targetGroupArn != null;
        }

    }
}