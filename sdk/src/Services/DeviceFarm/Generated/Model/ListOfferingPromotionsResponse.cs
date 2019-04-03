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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// This is the response object from the ListOfferingPromotions operation.
    /// </summary>
    public partial class ListOfferingPromotionsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<OfferingPromotion> _offeringPromotions = new List<OfferingPromotion>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier to be used in the next call to this operation, to return the next set
        /// of items in the list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingPromotions. 
        /// <para>
        /// Information about the offering promotions.
        /// </para>
        /// </summary>
        public List<OfferingPromotion> OfferingPromotions
        {
            get { return this._offeringPromotions; }
            set { this._offeringPromotions = value; }
        }

        // Check to see if OfferingPromotions property is set
        internal bool IsSetOfferingPromotions()
        {
            return this._offeringPromotions != null && this._offeringPromotions.Count > 0; 
        }

    }
}