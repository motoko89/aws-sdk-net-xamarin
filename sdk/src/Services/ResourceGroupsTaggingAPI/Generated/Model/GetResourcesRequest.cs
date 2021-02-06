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
 * Do not modify this file. This file is generated from the resourcegroupstaggingapi-2017-01-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroupsTaggingAPI.Model
{
    /// <summary>
    /// Container for the parameters to the GetResources operation.
    /// Returns all the tagged or previously tagged resources that are located in the specified
    /// Region for the AWS account.
    /// 
    ///  
    /// <para>
    /// Depending on what information you want returned, you can also specify the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <i>Filters</i> that specify what tags and resource types you want returned. The response
    /// includes all tags that are associated with the requested resources.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Information about compliance with the account's effective tag policy. For more information
    /// on tag policies, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_policies_tag-policies.html">Tag
    /// Policies</a> in the <i>AWS Organizations User Guide.</i> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation supports pagination, where the response can be sent in multiple pages.
    /// You should check the <code>PaginationToken</code> response parameter to determine
    /// if there are additional results available to return. Repeat the query, passing the
    /// <code>PaginationToken</code> response parameter value as an input to the next request
    /// until you recieve a <code>null</code> value. A null value for <code>PaginationToken</code>
    /// indicates that there are no more results waiting to be returned.
    /// </para>
    /// </summary>
    public partial class GetResourcesRequest : AmazonResourceGroupsTaggingAPIRequest
    {
        private bool? _excludeCompliantResources;
        private bool? _includeComplianceDetails;
        private string _paginationToken;
        private List<string> _resourceARNList = new List<string>();
        private int? _resourcesPerPage;
        private List<string> _resourceTypeFilters = new List<string>();
        private List<TagFilter> _tagFilters = new List<TagFilter>();
        private int? _tagsPerPage;

        /// <summary>
        /// Gets and sets the property ExcludeCompliantResources. 
        /// <para>
        /// Specifies whether to exclude resources that are compliant with the tag policy. Set
        /// this to <code>true</code> if you are interested in retrieving information on noncompliant
        /// resources only.
        /// </para>
        ///  
        /// <para>
        /// You can use this parameter only if the <code>IncludeComplianceDetails</code> parameter
        /// is also set to <code>true</code>.
        /// </para>
        /// </summary>
        public bool ExcludeCompliantResources
        {
            get { return this._excludeCompliantResources.GetValueOrDefault(); }
            set { this._excludeCompliantResources = value; }
        }

        // Check to see if ExcludeCompliantResources property is set
        internal bool IsSetExcludeCompliantResources()
        {
            return this._excludeCompliantResources.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IncludeComplianceDetails. 
        /// <para>
        /// Specifies whether to include details regarding the compliance with the effective tag
        /// policy. Set this to <code>true</code> to determine whether resources are compliant
        /// with the tag policy and to get details.
        /// </para>
        /// </summary>
        public bool IncludeComplianceDetails
        {
            get { return this._includeComplianceDetails.GetValueOrDefault(); }
            set { this._includeComplianceDetails = value; }
        }

        // Check to see if IncludeComplianceDetails property is set
        internal bool IsSetIncludeComplianceDetails()
        {
            return this._includeComplianceDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// Specifies a <code>PaginationToken</code> response value from a previous request to
        /// indicate that you want the next page of results. Leave this parameter empty in your
        /// initial request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceARNList. 
        /// <para>
        /// Specifies a list of ARNs of resources for which you want to retrieve tag data. You
        /// can't specify both this parameter and any of the pagination parameters (<code>ResourcesPerPage</code>,
        /// <code>TagsPerPage</code>, <code>PaginationToken</code>) in the same request. If you
        /// specify both, you get an <code>Invalid Parameter</code> exception.
        /// </para>
        ///  
        /// <para>
        /// If a resource specified by this parameter doesn't exist, it doesn't generate an error;
        /// it simply isn't included in the response.
        /// </para>
        ///  
        /// <para>
        /// An ARN (Amazon Resource Name) uniquely identifies a resource. For more information,
        /// see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<string> ResourceARNList
        {
            get { return this._resourceARNList; }
            set { this._resourceARNList = value; }
        }

        // Check to see if ResourceARNList property is set
        internal bool IsSetResourceARNList()
        {
            return this._resourceARNList != null && this._resourceARNList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourcesPerPage. 
        /// <para>
        /// Specifies the maximum number of results to be returned in each page. A query can return
        /// fewer than this maximum, even if there are more results still to return. You should
        /// always check the <code>PaginationToken</code> response value to see if there are more
        /// results. You can specify a minimum of 1 and a maximum value of 100.
        /// </para>
        /// </summary>
        public int ResourcesPerPage
        {
            get { return this._resourcesPerPage.GetValueOrDefault(); }
            set { this._resourcesPerPage = value; }
        }

        // Check to see if ResourcesPerPage property is set
        internal bool IsSetResourcesPerPage()
        {
            return this._resourcesPerPage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResourceTypeFilters. 
        /// <para>
        /// Specifies the resource types that you want included in the response. The format of
        /// each resource type is <code>service[:resourceType]</code>. For example, specifying
        /// a resource type of <code>ec2</code> returns all Amazon EC2 resources (which includes
        /// EC2 instances). Specifying a resource type of <code>ec2:instance</code> returns only
        /// EC2 instances. 
        /// </para>
        ///  
        /// <para>
        /// The string for each service name and resource type is the same as that embedded in
        /// a resource's Amazon Resource Name (ARN). Consult the <i>AWS General Reference</i>
        /// for the following:
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify multiple resource types by using an array. The array can include up
        /// to 100 items. Note that the length constraint requirement applies to each resource
        /// type filter. 
        /// </para>
        /// </summary>
        public List<string> ResourceTypeFilters
        {
            get { return this._resourceTypeFilters; }
            set { this._resourceTypeFilters = value; }
        }

        // Check to see if ResourceTypeFilters property is set
        internal bool IsSetResourceTypeFilters()
        {
            return this._resourceTypeFilters != null && this._resourceTypeFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagFilters. 
        /// <para>
        /// Specifies a list of TagFilters (keys and values) to restrict the output to only those
        /// resources that have the specified tag and, if included, the specified value. Each
        /// <code>TagFilter</code> must contain a key with values optional. A request can include
        /// up to 50 keys, and each key can include up to 20 values. 
        /// </para>
        ///  
        /// <para>
        /// Note the following when deciding how to use TagFilters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you <i>don't</i> specify a <code>TagFilter</code>, the response includes all resources
        /// that are currently tagged or ever had a tag. Resources that currently don't have tags
        /// are shown with an empty tag set, like this: <code>"Tags": []</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify more than one filter in a single request, the response returns only
        /// those resources that satisfy all filters.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you specify a filter that contains more than one value for a key, the response
        /// returns resources that match any of the specified values for that key.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify any values for a key, the response returns resources that are
        /// tagged with that key and any or no value.
        /// </para>
        ///  
        /// <para>
        /// For example, for the following filters: <code>filter1= {keyA,{value1}}</code>, <code>filter2={keyB,{value2,value3,value4}}</code>,
        /// <code>filter3= {keyC}</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>GetResources({filter1})</code> returns resources tagged with <code>key1=value1</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetResources({filter2})</code> returns resources tagged with <code>key2=value2</code>
        /// or <code>key2=value3</code> or <code>key2=value4</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetResources({filter3})</code> returns resources tagged with any tag with the
        /// key <code>key3</code>, and with any or no value
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>GetResources({filter1,filter2,filter3})</code> returns resources tagged with
        /// <code>(key1=value1) and (key2=value2 or key2=value3 or key2=value4) and (key3, any
        /// or no value)</code> 
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<TagFilter> TagFilters
        {
            get { return this._tagFilters; }
            set { this._tagFilters = value; }
        }

        // Check to see if TagFilters property is set
        internal bool IsSetTagFilters()
        {
            return this._tagFilters != null && this._tagFilters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TagsPerPage. 
        /// <para>
        /// AWS recommends using <code>ResourcesPerPage</code> instead of this parameter.
        /// </para>
        ///  
        /// <para>
        /// A limit that restricts the number of tags (key and value pairs) returned by <code>GetResources</code>
        /// in paginated output. A resource with no tags is counted as having one tag (one key
        /// and value pair).
        /// </para>
        ///  
        /// <para>
        ///  <code>GetResources</code> does not split a resource and its associated tags across
        /// pages. If the specified <code>TagsPerPage</code> would cause such a break, a <code>PaginationToken</code>
        /// is returned in place of the affected resource and its tags. Use that token in another
        /// request to get the remaining data. For example, if you specify a <code>TagsPerPage</code>
        /// of <code>100</code> and the account has 22 resources with 10 tags each (meaning that
        /// each resource has 10 key and value pairs), the output will consist of three pages.
        /// The first page displays the first 10 resources, each with its 10 tags. The second
        /// page displays the next 10 resources, each with its 10 tags. The third page displays
        /// the remaining 2 resources, each with its 10 tags.
        /// </para>
        ///  
        /// <para>
        /// You can set <code>TagsPerPage</code> to a minimum of 100 items up to a maximum of
        /// 500 items.
        /// </para>
        /// </summary>
        public int TagsPerPage
        {
            get { return this._tagsPerPage.GetValueOrDefault(); }
            set { this._tagsPerPage = value; }
        }

        // Check to see if TagsPerPage property is set
        internal bool IsSetTagsPerPage()
        {
            return this._tagsPerPage.HasValue; 
        }

    }
}