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
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// Container for the parameters to the ListFunctions operation.
    /// Returns a list of your Lambda functions. For each function, the response includes
    /// the function configuration information. You must use <a>GetFunction</a> to retrieve
    /// the code for your function.
    /// 
    ///  
    /// <para>
    /// This operation requires permission for the <code>lambda:ListFunctions</code> action.
    /// </para>
    ///  
    /// <para>
    /// If you are using the versioning feature, you can list all of your functions or only
    /// <code>$LATEST</code> versions. For information about the versioning feature, see <a
    /// href="http://docs.aws.amazon.com/lambda/latest/dg/versioning-aliases.html">AWS Lambda
    /// Function Versioning and Aliases</a>. 
    /// </para>
    /// </summary>
    public partial class ListFunctionsRequest : AmazonLambdaRequest
    {
        private FunctionVersion _functionVersion;
        private string _marker;
        private string _masterRegion;
        private int? _maxItems;

        /// <summary>
        /// Gets and sets the property FunctionVersion. 
        /// <para>
        /// Set to <code>ALL</code> to list all published versions. If not specified, only the
        /// latest unpublished version ARN is returned.
        /// </para>
        /// </summary>
        public FunctionVersion FunctionVersion
        {
            get { return this._functionVersion; }
            set { this._functionVersion = value; }
        }

        // Check to see if FunctionVersion property is set
        internal bool IsSetFunctionVersion()
        {
            return this._functionVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Optional string. An opaque pagination token returned from a previous <code>ListFunctions</code>
        /// operation. If present, indicates where to continue the listing. 
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MasterRegion. 
        /// <para>
        /// Specify a region (e.g. <code>us-east-2</code>) to only list functions that were created
        /// in that region, or <code>ALL</code> to include functions replicated from any region.
        /// If specified, you also must specify the <code>FunctionVersion</code>.
        /// </para>
        /// </summary>
        public string MasterRegion
        {
            get { return this._masterRegion; }
            set { this._masterRegion = value; }
        }

        // Check to see if MasterRegion property is set
        internal bool IsSetMasterRegion()
        {
            return this._masterRegion != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Optional integer. Specifies the maximum number of AWS Lambda functions to return in
        /// response. This parameter value must be greater than 0. The absolute maximum of AWS
        /// Lambda functions that can be returned is 50.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

    }
}