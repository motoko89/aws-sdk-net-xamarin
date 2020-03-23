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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.GlobalAccelerator.Model;

namespace Amazon.GlobalAccelerator
{
    /// <summary>
    /// Interface for accessing GlobalAccelerator
    ///
    /// AWS Global Accelerator 
    /// <para>
    /// This is the <i>AWS Global Accelerator API Reference</i>. This guide is for developers
    /// who need detailed information about AWS Global Accelerator API actions, data types,
    /// and errors. For more information about Global Accelerator features, see the <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/Welcome.html">AWS
    /// Global Accelerator Developer Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// AWS Global Accelerator is a service in which you create accelerators to improve availability
    /// and performance of your applications for local and global users. 
    /// </para>
    ///  <important> 
    /// <para>
    /// You must specify the US West (Oregon) Region to create or update accelerators.
    /// </para>
    ///  </important> 
    /// <para>
    /// By default, Global Accelerator provides you with static IP addresses that you associate
    /// with your accelerator. (Instead of using the IP addresses that Global Accelerator
    /// provides, you can configure these entry points to be IPv4 addresses from your own
    /// IP address ranges that you bring to Global Accelerator.) The static IP addresses are
    /// anycast from the AWS edge network and distribute incoming application traffic across
    /// multiple endpoint resources in multiple AWS Regions, which increases the availability
    /// of your applications. Endpoints can be Network Load Balancers, Application Load Balancers,
    /// EC2 instances, or Elastic IP addresses that are located in one AWS Region or multiple
    /// Regions.
    /// </para>
    ///  
    /// <para>
    /// Global Accelerator uses the AWS global network to route traffic to the optimal regional
    /// endpoint based on health, client location, and policies that you configure. The service
    /// reacts instantly to changes in health or configuration to ensure that internet traffic
    /// from clients is directed to only healthy endpoints.
    /// </para>
    ///  
    /// <para>
    /// Global Accelerator includes components that work together to help you improve performance
    /// and availability for your applications:
    /// </para>
    ///  <dl> <dt>Static IP address</dt> <dd> 
    /// <para>
    /// By default, AWS Global Accelerator provides you with a set of static IP addresses
    /// that are anycast from the AWS edge network and serve as the single fixed entry points
    /// for your clients. Or you can configure these entry points to be IPv4 addresses from
    /// your own IP address ranges that you bring to Global Accelerator (BYOIP). For more
    /// information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
    /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
    /// If you already have load balancers, EC2 instances, or Elastic IP addresses set up
    /// for your applications, you can easily add those to Global Accelerator to allow the
    /// resources to be accessed by the static IP addresses.
    /// </para>
    ///  <important> 
    /// <para>
    /// The static IP addresses remain assigned to your accelerator for as long as it exists,
    /// even if you disable the accelerator and it no longer accepts or routes traffic. However,
    /// when you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
    /// to it, so you can no longer route traffic by using them. You can use IAM policies
    /// with Global Accelerator to limit the users who have permissions to delete an accelerator.
    /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/auth-and-access-control.html">Authentication
    /// and Access Control</a> in the <i>AWS Global Accelerator Developer Guide</i>. 
    /// </para>
    ///  </important> </dd> <dt>Accelerator</dt> <dd> 
    /// <para>
    /// An accelerator directs traffic to optimal endpoints over the AWS global network to
    /// improve availability and performance for your internet applications that have a global
    /// audience. Each accelerator includes one or more listeners.
    /// </para>
    ///  </dd> <dt>DNS name</dt> <dd> 
    /// <para>
    /// Global Accelerator assigns each accelerator a default Domain Name System (DNS) name,
    /// similar to <code>a1234567890abcdef.awsglobalaccelerator.com</code>, that points to
    /// your Global Accelerator static IP addresses. Depending on the use case, you can use
    /// your accelerator's static IP addresses or DNS name to route traffic to your accelerator,
    /// or set up DNS records to route traffic using your own custom domain name.
    /// </para>
    ///  </dd> <dt>Network zone</dt> <dd> 
    /// <para>
    /// A network zone services the static IP addresses for your accelerator from a unique
    /// IP subnet. Similar to an AWS Availability Zone, a network zone is an isolated unit
    /// with its own set of physical infrastructure. When you configure an accelerator, by
    /// default, Global Accelerator allocates two IPv4 addresses for it. If one IP address
    /// from a network zone becomes unavailable due to IP address blocking by certain client
    /// networks, or network disruptions, then client applications can retry on the healthy
    /// static IP address from the other isolated network zone.
    /// </para>
    ///  </dd> <dt>Listener</dt> <dd> 
    /// <para>
    /// A listener processes inbound connections from clients to Global Accelerator, based
    /// on the protocol and port that you configure. Each listener has one or more endpoint
    /// groups associated with it, and traffic is forwarded to endpoints in one of the groups.
    /// You associate endpoint groups with listeners by specifying the Regions that you want
    /// to distribute traffic to. Traffic is distributed to optimal endpoints within the endpoint
    /// groups associated with a listener.
    /// </para>
    ///  </dd> <dt>Endpoint group</dt> <dd> 
    /// <para>
    /// Each endpoint group is associated with a specific AWS Region. Endpoint groups include
    /// one or more endpoints in the Region. You can increase or reduce the percentage of
    /// traffic that would be otherwise directed to an endpoint group by adjusting a setting
    /// called a <i>traffic dial</i>. The traffic dial lets you easily do performance testing
    /// or blue/green deployment testing for new releases across different AWS Regions, for
    /// example. 
    /// </para>
    ///  </dd> <dt>Endpoint</dt> <dd> 
    /// <para>
    /// An endpoint is a Network Load Balancer, Application Load Balancer, EC2 instance, or
    /// Elastic IP address. Traffic is routed to endpoints based on several factors, including
    /// the geo-proximity to the user, the health of the endpoint, and the configuration options
    /// that you choose, such as endpoint weights. For each endpoint, you can configure weights,
    /// which are numbers that you can use to specify the proportion of traffic to route to
    /// each one. This can be useful, for example, to do performance testing within a Region.
    /// </para>
    ///  </dd> </dl>
    /// </summary>
    public partial interface IAmazonGlobalAccelerator : IAmazonService, IDisposable
    {

        
        #region  AdvertiseByoipCidr


        /// <summary>
        /// Advertises an IPv4 address range that is provisioned for use with your AWS resources
        /// through bring your own IP addresses (BYOIP). It can take a few minutes before traffic
        /// to the specified addresses starts routing to AWS because of propagation delays. To
        /// see an AWS CLI example of advertising an address range, scroll down to <b>Example</b>.
        /// 
        ///  
        /// <para>
        /// To stop advertising the BYOIP address range, use <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/WithdrawByoipCidr.html">
        /// WithdrawByoipCidr</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr service method.</param>
        /// 
        /// <returns>The response from the AdvertiseByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ByoipCidrNotFoundException">
        /// The CIDR that you specified was not found or is incorrect.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        AdvertiseByoipCidrResponse AdvertiseByoipCidr(AdvertiseByoipCidrRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AdvertiseByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAdvertiseByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        IAsyncResult BeginAdvertiseByoipCidr(AdvertiseByoipCidrRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AdvertiseByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAdvertiseByoipCidr.</param>
        /// 
        /// <returns>Returns a  AdvertiseByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        AdvertiseByoipCidrResponse EndAdvertiseByoipCidr(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAccelerator


        /// <summary>
        /// Create an accelerator. An accelerator includes one or more listeners that process
        /// inbound connections and direct traffic to one or more endpoint groups, each of which
        /// includes endpoints, such as Network Load Balancers. To see an AWS CLI example of creating
        /// an accelerator, scroll down to <b>Example</b>.
        /// 
        ///  
        /// <para>
        /// If you bring your own IP address ranges to AWS Global Accelerator (BYOIP), you can
        /// assign IP addresses from your own pool to your accelerator as the static IP address
        /// entry points. Only one IP address from each of your IP address ranges can be used
        /// for each accelerator.
        /// </para>
        ///  <important> 
        /// <para>
        /// You must specify the US West (Oregon) Region to create or update accelerators.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccelerator service method.</param>
        /// 
        /// <returns>The response from the CreateAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        CreateAcceleratorResponse CreateAccelerator(CreateAcceleratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        IAsyncResult BeginCreateAccelerator(CreateAcceleratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccelerator.</param>
        /// 
        /// <returns>Returns a  CreateAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateAccelerator">REST API Reference for CreateAccelerator Operation</seealso>
        CreateAcceleratorResponse EndCreateAccelerator(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpointGroup


        /// <summary>
        /// Create an endpoint group for the specified listener. An endpoint group is a collection
        /// of endpoints in one AWS Region. To see an AWS CLI example of creating an endpoint
        /// group, scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupAlreadyExistsException">
        /// The endpoint group that you specified already exists.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        CreateEndpointGroupResponse CreateEndpointGroup(CreateEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        IAsyncResult BeginCreateEndpointGroup(CreateEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointGroup.</param>
        /// 
        /// <returns>Returns a  CreateEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateEndpointGroup">REST API Reference for CreateEndpointGroup Operation</seealso>
        CreateEndpointGroupResponse EndCreateEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateListener


        /// <summary>
        /// Create a listener to process inbound connections from clients to an accelerator. Connections
        /// arrive to assigned static IP addresses on a port, port range, or list of port ranges
        /// that you specify. To see an AWS CLI example of creating a listener, scroll down to
        /// <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        CreateListenerResponse CreateListener(CreateListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        IAsyncResult BeginCreateListener(CreateListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateListener.</param>
        /// 
        /// <returns>Returns a  CreateListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/CreateListener">REST API Reference for CreateListener Operation</seealso>
        CreateListenerResponse EndCreateListener(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccelerator


        /// <summary>
        /// Delete an accelerator. Before you can delete an accelerator, you must disable it and
        /// remove all dependent resources (listeners and endpoint groups). To disable the accelerator,
        /// update the accelerator to set <code>Enabled</code> to false.
        /// 
        ///  <important> 
        /// <para>
        /// When you create an accelerator, by default, Global Accelerator provides you with a
        /// set of two static IP addresses. Alternatively, you can bring your own IP address ranges
        /// to Global Accelerator and assign IP addresses from those ranges. 
        /// </para>
        ///  
        /// <para>
        /// The IP addresses are assigned to your accelerator for as long as it exists, even if
        /// you disable the accelerator and it no longer accepts or routes traffic. However, when
        /// you <i>delete</i> an accelerator, you lose the static IP addresses that are assigned
        /// to the accelerator, so you can no longer route traffic by using them. As a best practice,
        /// ensure that you have permissions in place to avoid inadvertently deleting accelerators.
        /// You can use IAM policies with Global Accelerator to limit the users who have permissions
        /// to delete an accelerator. For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/auth-and-access-control.html">Authentication
        /// and Access Control</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccelerator service method.</param>
        /// 
        /// <returns>The response from the DeleteAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotDisabledException">
        /// The accelerator that you specified could not be disabled.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AssociatedListenerFoundException">
        /// The accelerator that you specified has a listener associated with it. You must remove
        /// all dependent resources from an accelerator before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        DeleteAcceleratorResponse DeleteAccelerator(DeleteAcceleratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        IAsyncResult BeginDeleteAccelerator(DeleteAcceleratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccelerator.</param>
        /// 
        /// <returns>Returns a  DeleteAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteAccelerator">REST API Reference for DeleteAccelerator Operation</seealso>
        DeleteAcceleratorResponse EndDeleteAccelerator(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpointGroup


        /// <summary>
        /// Delete an endpoint group from a listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        DeleteEndpointGroupResponse DeleteEndpointGroup(DeleteEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        IAsyncResult BeginDeleteEndpointGroup(DeleteEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteEndpointGroup">REST API Reference for DeleteEndpointGroup Operation</seealso>
        DeleteEndpointGroupResponse EndDeleteEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteListener


        /// <summary>
        /// Delete a listener from an accelerator.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AssociatedEndpointGroupFoundException">
        /// The listener that you specified has an endpoint group associated with it. You must
        /// remove all dependent resources from a listener before you can delete it.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        DeleteListenerResponse DeleteListener(DeleteListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        IAsyncResult BeginDeleteListener(DeleteListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteListener.</param>
        /// 
        /// <returns>Returns a  DeleteListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        DeleteListenerResponse EndDeleteListener(IAsyncResult asyncResult);

        #endregion
        
        #region  DeprovisionByoipCidr


        /// <summary>
        /// Releases the specified address range that you provisioned to use with your AWS resources
        /// through bring your own IP addresses (BYOIP) and deletes the corresponding address
        /// pool. To see an AWS CLI example of deprovisioning an address range, scroll down to
        /// <b>Example</b>.
        /// 
        ///  
        /// <para>
        /// Before you can release an address range, you must stop advertising it by using <a
        /// href="https://docs.aws.amazon.com/global-accelerator/latest/api/WithdrawByoipCidr.html">WithdrawByoipCidr</a>
        /// and you must not have any accelerators that are using static IP addresses allocated
        /// from its address range. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr service method.</param>
        /// 
        /// <returns>The response from the DeprovisionByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ByoipCidrNotFoundException">
        /// The CIDR that you specified was not found or is incorrect.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        DeprovisionByoipCidrResponse DeprovisionByoipCidr(DeprovisionByoipCidrRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeprovisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeprovisionByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        IAsyncResult BeginDeprovisionByoipCidr(DeprovisionByoipCidrRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeprovisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeprovisionByoipCidr.</param>
        /// 
        /// <returns>Returns a  DeprovisionByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        DeprovisionByoipCidrResponse EndDeprovisionByoipCidr(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccelerator


        /// <summary>
        /// Describe an accelerator. To see an AWS CLI example of describing an accelerator, scroll
        /// down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerator service method.</param>
        /// 
        /// <returns>The response from the DescribeAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        DescribeAcceleratorResponse DescribeAccelerator(DescribeAcceleratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        IAsyncResult BeginDescribeAccelerator(DescribeAcceleratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccelerator.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAccelerator">REST API Reference for DescribeAccelerator Operation</seealso>
        DescribeAcceleratorResponse EndDescribeAccelerator(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAcceleratorAttributes


        /// <summary>
        /// Describe the attributes of an accelerator. To see an AWS CLI example of describing
        /// the attributes of an accelerator, scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAcceleratorAttributes service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        DescribeAcceleratorAttributesResponse DescribeAcceleratorAttributes(DescribeAcceleratorAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAcceleratorAttributes operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAcceleratorAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        IAsyncResult BeginDescribeAcceleratorAttributes(DescribeAcceleratorAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAcceleratorAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAcceleratorAttributesResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeAcceleratorAttributes">REST API Reference for DescribeAcceleratorAttributes Operation</seealso>
        DescribeAcceleratorAttributesResponse EndDescribeAcceleratorAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpointGroup


        /// <summary>
        /// Describe an endpoint group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        DescribeEndpointGroupResponse DescribeEndpointGroup(DescribeEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        IAsyncResult BeginDescribeEndpointGroup(DescribeEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointGroup.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeEndpointGroup">REST API Reference for DescribeEndpointGroup Operation</seealso>
        DescribeEndpointGroupResponse EndDescribeEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeListener


        /// <summary>
        /// Describe a listener. To see an AWS CLI example of describing a listener, scroll down
        /// to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListener service method.</param>
        /// 
        /// <returns>The response from the DescribeListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        DescribeListenerResponse DescribeListener(DescribeListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        IAsyncResult BeginDescribeListener(DescribeListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeListener.</param>
        /// 
        /// <returns>Returns a  DescribeListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/DescribeListener">REST API Reference for DescribeListener Operation</seealso>
        DescribeListenerResponse EndDescribeListener(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccelerators


        /// <summary>
        /// List the accelerators for an AWS account. To see an AWS CLI example of listing the
        /// accelerators for an AWS account, scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccelerators service method.</param>
        /// 
        /// <returns>The response from the ListAccelerators service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        ListAcceleratorsResponse ListAccelerators(ListAcceleratorsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccelerators operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccelerators operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccelerators
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        IAsyncResult BeginListAccelerators(ListAcceleratorsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccelerators operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccelerators.</param>
        /// 
        /// <returns>Returns a  ListAcceleratorsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListAccelerators">REST API Reference for ListAccelerators Operation</seealso>
        ListAcceleratorsResponse EndListAccelerators(IAsyncResult asyncResult);

        #endregion
        
        #region  ListByoipCidrs


        /// <summary>
        /// Lists the IP address ranges that were specified in calls to <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/ProvisionByoipCidr.html">ProvisionByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// To see an AWS CLI example of listing BYOIP CIDR addresses, scroll down to <b>Example</b>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListByoipCidrs service method.</param>
        /// 
        /// <returns>The response from the ListByoipCidrs service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListByoipCidrs">REST API Reference for ListByoipCidrs Operation</seealso>
        ListByoipCidrsResponse ListByoipCidrs(ListByoipCidrsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListByoipCidrs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListByoipCidrs operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListByoipCidrs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListByoipCidrs">REST API Reference for ListByoipCidrs Operation</seealso>
        IAsyncResult BeginListByoipCidrs(ListByoipCidrsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListByoipCidrs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListByoipCidrs.</param>
        /// 
        /// <returns>Returns a  ListByoipCidrsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListByoipCidrs">REST API Reference for ListByoipCidrs Operation</seealso>
        ListByoipCidrsResponse EndListByoipCidrs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpointGroups


        /// <summary>
        /// List the endpoint groups that are associated with a listener. To see an AWS CLI example
        /// of listing the endpoint groups for listener, scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointGroups service method.</param>
        /// 
        /// <returns>The response from the ListEndpointGroups service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        ListEndpointGroupsResponse ListEndpointGroups(ListEndpointGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointGroups operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        IAsyncResult BeginListEndpointGroups(ListEndpointGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointGroups.</param>
        /// 
        /// <returns>Returns a  ListEndpointGroupsResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListEndpointGroups">REST API Reference for ListEndpointGroups Operation</seealso>
        ListEndpointGroupsResponse EndListEndpointGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  ListListeners


        /// <summary>
        /// List the listeners for an accelerator. To see an AWS CLI example of listing the listeners
        /// for an accelerator, scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListListeners service method.</param>
        /// 
        /// <returns>The response from the ListListeners service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidNextTokenException">
        /// There isn't another item to return.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        ListListenersResponse ListListeners(ListListenersRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListListeners operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListListeners
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        IAsyncResult BeginListListeners(ListListenersRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListListeners operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListListeners.</param>
        /// 
        /// <returns>Returns a  ListListenersResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListListeners">REST API Reference for ListListeners Operation</seealso>
        ListListenersResponse EndListListeners(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List all tags for an accelerator. To see an AWS CLI example of listing tags for an
        /// accelerator, scroll down to <b>Example</b>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ProvisionByoipCidr


        /// <summary>
        /// Provisions an IP address range to use with your AWS resources through bring your own
        /// IP addresses (BYOIP) and creates a corresponding address pool. After the address range
        /// is provisioned, it is ready to be advertised using <a href="https://docs.aws.amazon.com/global-accelerator/latest/api/AdvertiseByoipCidr.html">
        /// AdvertiseByoipCidr</a>.
        /// 
        ///  
        /// <para>
        /// To see an AWS CLI example of provisioning an address range for BYOIP, scroll down
        /// to <b>Example</b>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr service method.</param>
        /// 
        /// <returns>The response from the ProvisionByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        ProvisionByoipCidrResponse ProvisionByoipCidr(ProvisionByoipCidrRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndProvisionByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        IAsyncResult BeginProvisionByoipCidr(ProvisionByoipCidrRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ProvisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginProvisionByoipCidr.</param>
        /// 
        /// <returns>Returns a  ProvisionByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        ProvisionByoipCidrResponse EndProvisionByoipCidr(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add tags to an accelerator resource. To see an AWS CLI example of adding tags to an
        /// accelerator, scroll down to <b>Example</b>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove tags from a Global Accelerator resource. When you specify a tag key, the action
        /// removes both that key and its associated value. To see an AWS CLI example of removing
        /// tags from an accelerator, scroll down to <b>Example</b>. The operation succeeds even
        /// if you attempt to remove tags from an accelerator that was already removed.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/tagging-in-global-accelerator.html">Tagging
        /// in AWS Global Accelerator</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAccelerator


        /// <summary>
        /// Update an accelerator. To see an AWS CLI example of updating an accelerator, scroll
        /// down to <b>Example</b>.
        /// 
        ///  <important> 
        /// <para>
        /// You must specify the US West (Oregon) Region to create or update accelerators.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccelerator service method.</param>
        /// 
        /// <returns>The response from the UpdateAccelerator service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        UpdateAcceleratorResponse UpdateAccelerator(UpdateAcceleratorRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccelerator operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccelerator
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        IAsyncResult BeginUpdateAccelerator(UpdateAcceleratorRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccelerator operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccelerator.</param>
        /// 
        /// <returns>Returns a  UpdateAcceleratorResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAccelerator">REST API Reference for UpdateAccelerator Operation</seealso>
        UpdateAcceleratorResponse EndUpdateAccelerator(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateAcceleratorAttributes


        /// <summary>
        /// Update the attributes for an accelerator. To see an AWS CLI example of updating an
        /// accelerator to enable flow logs, scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcceleratorAttributes service method.</param>
        /// 
        /// <returns>The response from the UpdateAcceleratorAttributes service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AcceleratorNotFoundException">
        /// The accelerator that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        UpdateAcceleratorAttributesResponse UpdateAcceleratorAttributes(UpdateAcceleratorAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAcceleratorAttributes operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAcceleratorAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        IAsyncResult BeginUpdateAcceleratorAttributes(UpdateAcceleratorAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAcceleratorAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAcceleratorAttributes.</param>
        /// 
        /// <returns>Returns a  UpdateAcceleratorAttributesResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateAcceleratorAttributes">REST API Reference for UpdateAcceleratorAttributes Operation</seealso>
        UpdateAcceleratorAttributesResponse EndUpdateAcceleratorAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointGroup


        /// <summary>
        /// Update an endpoint group. To see an AWS CLI example of updating an endpoint group,
        /// scroll down to <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointGroup service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.EndpointGroupNotFoundException">
        /// The endpoint group that you specified doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        UpdateEndpointGroupResponse UpdateEndpointGroup(UpdateEndpointGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointGroup operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        IAsyncResult BeginUpdateEndpointGroup(UpdateEndpointGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointGroup.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointGroupResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateEndpointGroup">REST API Reference for UpdateEndpointGroup Operation</seealso>
        UpdateEndpointGroupResponse EndUpdateEndpointGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateListener


        /// <summary>
        /// Update a listener. To see an AWS CLI example of updating listener, scroll down to
        /// <b>Example</b>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener service method.</param>
        /// 
        /// <returns>The response from the UpdateListener service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidPortRangeException">
        /// The port numbers that you specified are not valid numbers or are not unique for this
        /// accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.LimitExceededException">
        /// Processing your request would cause you to exceed an AWS Global Accelerator limit.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ListenerNotFoundException">
        /// The listener that you specified doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        UpdateListenerResponse UpdateListener(UpdateListenerRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateListener operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateListener
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        IAsyncResult BeginUpdateListener(UpdateListenerRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateListener operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateListener.</param>
        /// 
        /// <returns>Returns a  UpdateListenerResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/UpdateListener">REST API Reference for UpdateListener Operation</seealso>
        UpdateListenerResponse EndUpdateListener(IAsyncResult asyncResult);

        #endregion
        
        #region  WithdrawByoipCidr


        /// <summary>
        /// Stops advertising an address range that is provisioned as an address pool. You can
        /// perform this operation at most once every 10 seconds, even if you specify different
        /// address ranges each time. To see an AWS CLI example of withdrawing an address range
        /// for BYOIP so it will no longer be advertised by AWS, scroll down to <b>Example</b>.
        /// 
        ///  
        /// <para>
        /// It can take a few minutes before traffic to the specified addresses stops routing
        /// to AWS because of propagation delays.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/global-accelerator/latest/dg/using-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>AWS Global Accelerator Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr service method.</param>
        /// 
        /// <returns>The response from the WithdrawByoipCidr service method, as returned by GlobalAccelerator.</returns>
        /// <exception cref="Amazon.GlobalAccelerator.Model.AccessDeniedException">
        /// You don't have access permission.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.ByoipCidrNotFoundException">
        /// The CIDR that you specified was not found or is incorrect.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.IncorrectCidrStateException">
        /// The CIDR that you specified is not valid for this action. For example, the state of
        /// the CIDR might be incorrect for this action.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InternalServiceErrorException">
        /// There was an internal error for AWS Global Accelerator.
        /// </exception>
        /// <exception cref="Amazon.GlobalAccelerator.Model.InvalidArgumentException">
        /// An argument that you specified is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        WithdrawByoipCidrResponse WithdrawByoipCidr(WithdrawByoipCidrRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the WithdrawByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr operation on AmazonGlobalAcceleratorClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndWithdrawByoipCidr
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        IAsyncResult BeginWithdrawByoipCidr(WithdrawByoipCidrRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  WithdrawByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginWithdrawByoipCidr.</param>
        /// 
        /// <returns>Returns a  WithdrawByoipCidrResult from GlobalAccelerator.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/globalaccelerator-2018-08-08/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        WithdrawByoipCidrResponse EndWithdrawByoipCidr(IAsyncResult asyncResult);

        #endregion
        
    }
}