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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// A single query result.
    /// 
    ///  
    /// <para>
    /// A query result contains information about a document returned by the query. This includes
    /// the original location of the document, a list of attributes assigned to the document,
    /// and relevant text from the document that satisfies the query.
    /// </para>
    /// </summary>
    public partial class QueryResultItem
    {
        private List<AdditionalResultAttribute> _additionalAttributes = new List<AdditionalResultAttribute>();
        private List<DocumentAttribute> _documentAttributes = new List<DocumentAttribute>();
        private TextWithHighlights _documentExcerpt;
        private string _documentId;
        private TextWithHighlights _documentTitle;
        private string _documentURI;
        private string _id;
        private QueryResultType _type;

        /// <summary>
        /// Gets and sets the property AdditionalAttributes. 
        /// <para>
        /// One or more additional attribues associated with the query result.
        /// </para>
        /// </summary>
        public List<AdditionalResultAttribute> AdditionalAttributes
        {
            get { return this._additionalAttributes; }
            set { this._additionalAttributes = value; }
        }

        // Check to see if AdditionalAttributes property is set
        internal bool IsSetAdditionalAttributes()
        {
            return this._additionalAttributes != null && this._additionalAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentAttributes. 
        /// <para>
        /// An array of document attributes for the document that the query result maps to. For
        /// example, the document author (Author) or the source URI (SourceUri) of the document.
        /// </para>
        /// </summary>
        public List<DocumentAttribute> DocumentAttributes
        {
            get { return this._documentAttributes; }
            set { this._documentAttributes = value; }
        }

        // Check to see if DocumentAttributes property is set
        internal bool IsSetDocumentAttributes()
        {
            return this._documentAttributes != null && this._documentAttributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DocumentExcerpt. 
        /// <para>
        /// An extract of the text in the document. Contains information about highlighting the
        /// relevant terms in the excerpt.
        /// </para>
        /// </summary>
        public TextWithHighlights DocumentExcerpt
        {
            get { return this._documentExcerpt; }
            set { this._documentExcerpt = value; }
        }

        // Check to see if DocumentExcerpt property is set
        internal bool IsSetDocumentExcerpt()
        {
            return this._documentExcerpt != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentId. 
        /// <para>
        /// The unique identifier for the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DocumentId
        {
            get { return this._documentId; }
            set { this._documentId = value; }
        }

        // Check to see if DocumentId property is set
        internal bool IsSetDocumentId()
        {
            return this._documentId != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentTitle. 
        /// <para>
        /// The title of the document. Contains the text of the title and information for highlighting
        /// the relevant terms in the title.
        /// </para>
        /// </summary>
        public TextWithHighlights DocumentTitle
        {
            get { return this._documentTitle; }
            set { this._documentTitle = value; }
        }

        // Check to see if DocumentTitle property is set
        internal bool IsSetDocumentTitle()
        {
            return this._documentTitle != null;
        }

        /// <summary>
        /// Gets and sets the property DocumentURI. 
        /// <para>
        /// The URI of the original location of the document.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string DocumentURI
        {
            get { return this._documentURI; }
            set { this._documentURI = value; }
        }

        // Check to see if DocumentURI property is set
        internal bool IsSetDocumentURI()
        {
            return this._documentURI != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the query result.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=73)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of document. 
        /// </para>
        /// </summary>
        public QueryResultType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}