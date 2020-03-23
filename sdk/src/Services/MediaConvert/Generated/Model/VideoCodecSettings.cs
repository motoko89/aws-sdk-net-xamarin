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
    /// Video codec settings, (CodecSettings) under (VideoDescription), contains the group
    /// of settings related to video encoding. The settings in this group vary depending on
    /// the value that you choose for Video codec (Codec). For each codec enum that you choose,
    /// define the corresponding settings object. The following lists the codec enum, settings
    /// object pairs. * FRAME_CAPTURE, FrameCaptureSettings * AV1, Av1Settings * H_264, H264Settings
    /// * H_265, H265Settings * MPEG2, Mpeg2Settings * PRORES, ProresSettings
    /// </summary>
    public partial class VideoCodecSettings
    {
        private Av1Settings _av1Settings;
        private VideoCodec _codec;
        private FrameCaptureSettings _frameCaptureSettings;
        private H264Settings _h264Settings;
        private H265Settings _h265Settings;
        private Mpeg2Settings _mpeg2Settings;
        private ProresSettings _proresSettings;

        /// <summary>
        /// Gets and sets the property Av1Settings. Required when you set Codec, under VideoDescription>CodecSettings
        /// to the value AV1.
        /// </summary>
        public Av1Settings Av1Settings
        {
            get { return this._av1Settings; }
            set { this._av1Settings = value; }
        }

        // Check to see if Av1Settings property is set
        internal bool IsSetAv1Settings()
        {
            return this._av1Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Codec. Specifies the video codec. This must be equal to
        /// one of the enum values defined by the object  VideoCodec.
        /// </summary>
        public VideoCodec Codec
        {
            get { return this._codec; }
            set { this._codec = value; }
        }

        // Check to see if Codec property is set
        internal bool IsSetCodec()
        {
            return this._codec != null;
        }

        /// <summary>
        /// Gets and sets the property FrameCaptureSettings. Required when you set (Codec) under
        /// (VideoDescription)>(CodecSettings) to the value FRAME_CAPTURE.
        /// </summary>
        public FrameCaptureSettings FrameCaptureSettings
        {
            get { return this._frameCaptureSettings; }
            set { this._frameCaptureSettings = value; }
        }

        // Check to see if FrameCaptureSettings property is set
        internal bool IsSetFrameCaptureSettings()
        {
            return this._frameCaptureSettings != null;
        }

        /// <summary>
        /// Gets and sets the property H264Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value H_264.
        /// </summary>
        public H264Settings H264Settings
        {
            get { return this._h264Settings; }
            set { this._h264Settings = value; }
        }

        // Check to see if H264Settings property is set
        internal bool IsSetH264Settings()
        {
            return this._h264Settings != null;
        }

        /// <summary>
        /// Gets and sets the property H265Settings. Settings for H265 codec
        /// </summary>
        public H265Settings H265Settings
        {
            get { return this._h265Settings; }
            set { this._h265Settings = value; }
        }

        // Check to see if H265Settings property is set
        internal bool IsSetH265Settings()
        {
            return this._h265Settings != null;
        }

        /// <summary>
        /// Gets and sets the property Mpeg2Settings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value MPEG2.
        /// </summary>
        public Mpeg2Settings Mpeg2Settings
        {
            get { return this._mpeg2Settings; }
            set { this._mpeg2Settings = value; }
        }

        // Check to see if Mpeg2Settings property is set
        internal bool IsSetMpeg2Settings()
        {
            return this._mpeg2Settings != null;
        }

        /// <summary>
        /// Gets and sets the property ProresSettings. Required when you set (Codec) under (VideoDescription)>(CodecSettings)
        /// to the value PRORES.
        /// </summary>
        public ProresSettings ProresSettings
        {
            get { return this._proresSettings; }
            set { this._proresSettings = value; }
        }

        // Check to see if ProresSettings property is set
        internal bool IsSetProresSettings()
        {
            return this._proresSettings != null;
        }

    }
}