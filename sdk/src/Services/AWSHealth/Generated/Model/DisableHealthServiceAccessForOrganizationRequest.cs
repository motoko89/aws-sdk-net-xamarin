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
 * Do not modify this file. This file is generated from the health-2016-08-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSHealth.Model
{
    /// <summary>
    /// Container for the parameters to the DisableHealthServiceAccessForOrganization operation.
    /// Calling this operation disables Health from working with AWS Organizations. This does
    /// not remove the Service Linked Role (SLR) from the the master account in your organization.
    /// Use the IAM console, API, or AWS CLI to remove the SLR if desired. To call this operation,
    /// you must sign in as an IAM user, assume an IAM role, or sign in as the root user (not
    /// recommended) in the organization's master account.
    /// </summary>
    public partial class DisableHealthServiceAccessForOrganizationRequest : AmazonAWSHealthRequest
    {

    }
}