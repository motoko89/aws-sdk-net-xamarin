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
    /// Specifies media input
    /// </summary>
    public partial class Input
    {
        private Dictionary<string, AudioSelectorGroup> _audioSelectorGroups = new Dictionary<string, AudioSelectorGroup>();
        private Dictionary<string, AudioSelector> _audioSelectors = new Dictionary<string, AudioSelector>();
        private Dictionary<string, CaptionSelector> _captionSelectors = new Dictionary<string, CaptionSelector>();
        private InputDeblockFilter _deblockFilter;
        private InputDecryptionSettings _decryptionSettings;
        private InputDenoiseFilter _denoiseFilter;
        private string _fileInput;
        private InputFilterEnable _filterEnable;
        private int? _filterStrength;
        private ImageInserter _imageInserter;
        private List<InputClipping> _inputClippings = new List<InputClipping>();
        private int? _programNumber;
        private InputPsiControl _psiControl;
        private List<string> _supplementalImps = new List<string>();
        private InputTimecodeSource _timecodeSource;
        private VideoSelector _videoSelector;

        /// <summary>
        /// Gets and sets the property AudioSelectorGroups. Specifies set of audio selectors within
        /// an input to combine. An input may have multiple audio selector groups. See "Audio
        /// Selector Group":#inputs-audio_selector_group for more information.
        /// </summary>
        public Dictionary<string, AudioSelectorGroup> AudioSelectorGroups
        {
            get { return this._audioSelectorGroups; }
            set { this._audioSelectorGroups = value; }
        }

        // Check to see if AudioSelectorGroups property is set
        internal bool IsSetAudioSelectorGroups()
        {
            return this._audioSelectorGroups != null && this._audioSelectorGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AudioSelectors. Use Audio selectors (AudioSelectors) to
        /// specify a track or set of tracks from the input that you will use in your outputs.
        /// You can use mutiple Audio selectors per input.
        /// </summary>
        public Dictionary<string, AudioSelector> AudioSelectors
        {
            get { return this._audioSelectors; }
            set { this._audioSelectors = value; }
        }

        // Check to see if AudioSelectors property is set
        internal bool IsSetAudioSelectors()
        {
            return this._audioSelectors != null && this._audioSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CaptionSelectors. Use Captions selectors (CaptionSelectors)
        /// to specify the captions data from the input that you will use in your outputs. You
        /// can use mutiple captions selectors per input.
        /// </summary>
        public Dictionary<string, CaptionSelector> CaptionSelectors
        {
            get { return this._captionSelectors; }
            set { this._captionSelectors = value; }
        }

        // Check to see if CaptionSelectors property is set
        internal bool IsSetCaptionSelectors()
        {
            return this._captionSelectors != null && this._captionSelectors.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DeblockFilter. Enable Deblock (InputDeblockFilter) to produce
        /// smoother motion in the output. Default is disabled. Only manaully controllable for
        /// MPEG2 and uncompressed video inputs.
        /// </summary>
        public InputDeblockFilter DeblockFilter
        {
            get { return this._deblockFilter; }
            set { this._deblockFilter = value; }
        }

        // Check to see if DeblockFilter property is set
        internal bool IsSetDeblockFilter()
        {
            return this._deblockFilter != null;
        }

        /// <summary>
        /// Gets and sets the property DecryptionSettings. Settings for decrypting any input files
        /// that you encrypt before you upload them to Amazon S3. MediaConvert can decrypt files
        /// only when you use AWS Key Management Service (KMS) to encrypt the data key that you
        /// use to encrypt your content.
        /// </summary>
        public InputDecryptionSettings DecryptionSettings
        {
            get { return this._decryptionSettings; }
            set { this._decryptionSettings = value; }
        }

        // Check to see if DecryptionSettings property is set
        internal bool IsSetDecryptionSettings()
        {
            return this._decryptionSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DenoiseFilter. Enable Denoise (InputDenoiseFilter) to filter
        /// noise from the input.  Default is disabled. Only applicable to MPEG2, H.264, H.265,
        /// and uncompressed video inputs.
        /// </summary>
        public InputDenoiseFilter DenoiseFilter
        {
            get { return this._denoiseFilter; }
            set { this._denoiseFilter = value; }
        }

        // Check to see if DenoiseFilter property is set
        internal bool IsSetDenoiseFilter()
        {
            return this._denoiseFilter != null;
        }

        /// <summary>
        /// Gets and sets the property FileInput. Specify the source file for your transcoding
        /// job. You can use multiple inputs in a single job. The service concatenates these inputs,
        /// in the order that you specify them in the job, to create the outputs. If your input
        /// format is IMF, specify your input by providing the path to your CPL. For example,
        /// "s3://bucket/vf/cpl.xml". If the CPL is in an incomplete IMP, make sure to use *Supplemental
        /// IMPs* (SupplementalImps) to specify any supplemental IMPs that contain assets referenced
        /// by the CPL.
        /// </summary>
        public string FileInput
        {
            get { return this._fileInput; }
            set { this._fileInput = value; }
        }

        // Check to see if FileInput property is set
        internal bool IsSetFileInput()
        {
            return this._fileInput != null;
        }

        /// <summary>
        /// Gets and sets the property FilterEnable. Use Filter enable (InputFilterEnable) to
        /// specify how the transcoding service applies the denoise and deblock filters. You must
        /// also enable the filters separately, with Denoise (InputDenoiseFilter) and Deblock
        /// (InputDeblockFilter). * Auto - The transcoding service determines whether to apply
        /// filtering, depending on input type and quality. * Disable - The input is not filtered.
        /// This is true even if you use the API to enable them in (InputDeblockFilter) and (InputDeblockFilter).
        /// * Force - The in put is filtered regardless of input type.
        /// </summary>
        public InputFilterEnable FilterEnable
        {
            get { return this._filterEnable; }
            set { this._filterEnable = value; }
        }

        // Check to see if FilterEnable property is set
        internal bool IsSetFilterEnable()
        {
            return this._filterEnable != null;
        }

        /// <summary>
        /// Gets and sets the property FilterStrength. Use Filter strength (FilterStrength) to
        /// adjust the magnitude the input filter settings (Deblock and Denoise). The range is
        /// -5 to 5. Default is 0.
        /// </summary>
        [AWSProperty(Min=-5, Max=5)]
        public int FilterStrength
        {
            get { return this._filterStrength.GetValueOrDefault(); }
            set { this._filterStrength = value; }
        }

        // Check to see if FilterStrength property is set
        internal bool IsSetFilterStrength()
        {
            return this._filterStrength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageInserter. Enable the image inserter feature to include
        /// a graphic overlay on your video. Enable or disable this feature for each input individually.
        /// This setting is disabled by default.
        /// </summary>
        public ImageInserter ImageInserter
        {
            get { return this._imageInserter; }
            set { this._imageInserter = value; }
        }

        // Check to see if ImageInserter property is set
        internal bool IsSetImageInserter()
        {
            return this._imageInserter != null;
        }

        /// <summary>
        /// Gets and sets the property InputClippings. (InputClippings) contains sets of start
        /// and end times that together specify a portion of the input to be used in the outputs.
        /// If you provide only a start time, the clip will be the entire input from that point
        /// to the end. If you provide only an end time, it will be the entire input up to that
        /// point. When you specify more than one input clip, the transcoding service creates
        /// the job outputs by stringing the clips together in the order you specify them.
        /// </summary>
        public List<InputClipping> InputClippings
        {
            get { return this._inputClippings; }
            set { this._inputClippings = value; }
        }

        // Check to see if InputClippings property is set
        internal bool IsSetInputClippings()
        {
            return this._inputClippings != null && this._inputClippings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProgramNumber. Use Program (programNumber) to select a
        /// specific program from within a multi-program transport stream. Note that Quad 4K is
        /// not currently supported. Default is the first program within the transport stream.
        /// If the program you specify doesn't exist, the transcoding service will use this default.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ProgramNumber
        {
            get { return this._programNumber.GetValueOrDefault(); }
            set { this._programNumber = value; }
        }

        // Check to see if ProgramNumber property is set
        internal bool IsSetProgramNumber()
        {
            return this._programNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PsiControl. Set PSI control (InputPsiControl) for transport
        /// stream inputs to specify which data the demux process to scans. * Ignore PSI - Scan
        /// all PIDs for audio and video. * Use PSI - Scan only PSI data.
        /// </summary>
        public InputPsiControl PsiControl
        {
            get { return this._psiControl; }
            set { this._psiControl = value; }
        }

        // Check to see if PsiControl property is set
        internal bool IsSetPsiControl()
        {
            return this._psiControl != null;
        }

        /// <summary>
        /// Gets and sets the property SupplementalImps. Provide a list of any necessary supplemental
        /// IMPs. You need supplemental IMPs if the CPL that you're using for your input is in
        /// an incomplete IMP. Specify either the supplemental IMP directories with a trailing
        /// slash or the ASSETMAP.xml files. For example ["s3://bucket/ov/", "s3://bucket/vf2/ASSETMAP.xml"].
        /// You don't need to specify the IMP that contains your input CPL, because the service
        /// automatically detects it.
        /// </summary>
        public List<string> SupplementalImps
        {
            get { return this._supplementalImps; }
            set { this._supplementalImps = value; }
        }

        // Check to see if SupplementalImps property is set
        internal bool IsSetSupplementalImps()
        {
            return this._supplementalImps != null && this._supplementalImps.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TimecodeSource. Timecode source under input settings (InputTimecodeSource)
        /// only affects the behavior of features that apply to a single input at a time, such
        /// as input clipping and synchronizing some captions formats. Use this setting to specify
        /// whether the service counts frames by timecodes embedded in the video (EMBEDDED) or
        /// by starting the first frame at zero (ZEROBASED). In both cases, the timecode format
        /// is HH:MM:SS:FF or HH:MM:SS;FF, where FF is the frame number. Only set this to EMBEDDED
        /// if your source video has embedded timecodes.
        /// </summary>
        public InputTimecodeSource TimecodeSource
        {
            get { return this._timecodeSource; }
            set { this._timecodeSource = value; }
        }

        // Check to see if TimecodeSource property is set
        internal bool IsSetTimecodeSource()
        {
            return this._timecodeSource != null;
        }

        /// <summary>
        /// Gets and sets the property VideoSelector. Selector for video.
        /// </summary>
        public VideoSelector VideoSelector
        {
            get { return this._videoSelector; }
            set { this._videoSelector = value; }
        }

        // Check to see if VideoSelector property is set
        internal bool IsSetVideoSelector()
        {
            return this._videoSelector != null;
        }

    }
}