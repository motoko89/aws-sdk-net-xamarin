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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// If your input captions are SCC, SMI, SRT, STL, TTML, or IMSC 1.1 in an xml file, specify
    /// the URI of the input caption source file. If your caption source is IMSC in an IMF
    /// package, use TrackSourceSettings instead of FileSoureSettings.
    /// </summary>
    public partial class FileSourceSettings
    {
        private FileSourceConvert608To708 _convert608To708;
        private string _sourceFile;
        private int? _timeDelta;

        /// <summary>
        /// Gets and sets the property Convert608To708. Specify whether this set of input captions
        /// appears in your outputs in both 608 and 708 format. If you choose Upconvert (UPCONVERT),
        /// MediaConvert includes the captions data in two ways: it passes the 608 data through
        /// using the 608 compatibility bytes fields of the 708 wrapper, and it also translates
        /// the 608 data into 708.
        /// </summary>
        public FileSourceConvert608To708 Convert608To708
        {
            get { return this._convert608To708; }
            set { this._convert608To708 = value; }
        }

        // Check to see if Convert608To708 property is set
        internal bool IsSetConvert608To708()
        {
            return this._convert608To708 != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFile. External caption file used for loading captions.
        /// Accepted file extensions are 'scc', 'ttml', 'dfxp', 'stl', 'srt', 'xml', and 'smi'.
        /// </summary>
        [AWSProperty(Min=14)]
        public string SourceFile
        {
            get { return this._sourceFile; }
            set { this._sourceFile = value; }
        }

        // Check to see if SourceFile property is set
        internal bool IsSetSourceFile()
        {
            return this._sourceFile != null;
        }

        /// <summary>
        /// Gets and sets the property TimeDelta. Specifies a time delta in seconds to offset
        /// the captions from the source file.
        /// </summary>
        [AWSProperty(Min=-2147483648, Max=2147483647)]
        public int TimeDelta
        {
            get { return this._timeDelta.GetValueOrDefault(); }
            set { this._timeDelta = value; }
        }

        // Check to see if TimeDelta property is set
        internal bool IsSetTimeDelta()
        {
            return this._timeDelta.HasValue; 
        }

    }
}