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
 * Do not modify this file. This file is generated from the cloudfront-2019-03-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFront.Model
{
    /// <summary>
    /// A complex type that specifies whether you want CloudFront to forward cookies to the
    /// origin and, if so, which ones. For more information about forwarding cookies to the
    /// origin, see <a href="https://docs.aws.amazon.com/AmazonCloudFront/latest/DeveloperGuide/header-caching.html">
    /// Caching Content Based on Request Headers</a> in the <i>Amazon CloudFront Developer
    /// Guide</i>.
    /// </summary>
    public partial class CookieNames
    {
        private List<string> _items = new List<string>();
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property Items. 
        /// <para>
        /// A complex type that contains one <code>Name</code> element for each cookie that you
        /// want CloudFront to forward to the origin for this cache behavior. It must contain
        /// the same number of items that is specified in the <code>Quantity</code> field.
        /// </para>
        ///  
        /// <para>
        /// When you set <code>Forward = whitelist</code> (in the <code>CookiePreferences</code>
        /// object), this field must contain at least one item.
        /// </para>
        /// </summary>
        public List<string> Items
        {
            get { return this._items; }
            set { this._items = value; }
        }

        // Check to see if Items property is set
        internal bool IsSetItems()
        {
            return this._items != null && this._items.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of different cookies that you want CloudFront to forward to the origin
        /// for this cache behavior. The value must equal the number of items that are in the
        /// <code>Items</code> field.
        /// </para>
        ///  
        /// <para>
        /// When you set <code>Forward = whitelist</code> (in the <code>CookiePreferences</code>
        /// object), this value must be <code>1</code> or higher.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Quantity
        {
            get { return this._quantity.GetValueOrDefault(); }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}