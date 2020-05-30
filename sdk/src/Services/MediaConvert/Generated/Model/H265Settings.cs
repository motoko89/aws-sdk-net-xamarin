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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings for H265 codec
    /// </summary>
    public partial class H265Settings
    {
        private H265AdaptiveQuantization _adaptiveQuantization;
        private H265AlternateTransferFunctionSei _alternateTransferFunctionSei;
        private int? _bitrate;
        private H265CodecLevel _codecLevel;
        private H265CodecProfile _codecProfile;
        private H265DynamicSubGop _dynamicSubGop;
        private H265FlickerAdaptiveQuantization _flickerAdaptiveQuantization;
        private H265FramerateControl _framerateControl;
        private H265FramerateConversionAlgorithm _framerateConversionAlgorithm;
        private int? _framerateDenominator;
        private int? _framerateNumerator;
        private H265GopBReference _gopBReference;
        private int? _gopClosedCadence;
        private double? _gopSize;
        private H265GopSizeUnits _gopSizeUnits;
        private int? _hrdBufferInitialFillPercentage;
        private int? _hrdBufferSize;
        private H265InterlaceMode _interlaceMode;
        private int? _maxBitrate;
        private int? _minIInterval;
        private int? _numberBFramesBetweenReferenceFrames;
        private int? _numberReferenceFrames;
        private H265ParControl _parControl;
        private int? _parDenominator;
        private int? _parNumerator;
        private H265QualityTuningLevel _qualityTuningLevel;
        private H265QvbrSettings _qvbrSettings;
        private H265RateControlMode _rateControlMode;
        private H265SampleAdaptiveOffsetFilterMode _sampleAdaptiveOffsetFilterMode;
        private H265SceneChangeDetect _sceneChangeDetect;
        private int? _slices;
        private H265SlowPal _slowPal;
        private H265SpatialAdaptiveQuantization _spatialAdaptiveQuantization;
        private H265Telecine _telecine;
        private H265TemporalAdaptiveQuantization _temporalAdaptiveQuantization;
        private H265TemporalIds _temporalIds;
        private H265Tiles _tiles;
        private H265UnregisteredSeiTimecode _unregisteredSeiTimecode;
        private H265WriteMp4PackagingType _writeMp4PackagingType;

        /// <summary>
        /// Gets and sets the property AdaptiveQuantization. Adaptive quantization. Allows intra-frame
        /// quantizers to vary to improve visual quality.
        /// </summary>
        public H265AdaptiveQuantization AdaptiveQuantization
        {
            get { return this._adaptiveQuantization; }
            set { this._adaptiveQuantization = value; }
        }

        // Check to see if AdaptiveQuantization property is set
        internal bool IsSetAdaptiveQuantization()
        {
            return this._adaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property AlternateTransferFunctionSei. Enables Alternate Transfer
        /// Function SEI message for outputs using Hybrid Log Gamma (HLG) Electro-Optical Transfer
        /// Function (EOTF).
        /// </summary>
        public H265AlternateTransferFunctionSei AlternateTransferFunctionSei
        {
            get { return this._alternateTransferFunctionSei; }
            set { this._alternateTransferFunctionSei = value; }
        }

        // Check to see if AlternateTransferFunctionSei property is set
        internal bool IsSetAlternateTransferFunctionSei()
        {
            return this._alternateTransferFunctionSei != null;
        }

        /// <summary>
        /// Gets and sets the property Bitrate. Specify the average bitrate in bits per second.
        /// Required for VBR and CBR. For MS Smooth outputs, bitrates must be unique when rounded
        /// down to the nearest multiple of 1000.
        /// </summary>
        [AWSProperty(Min=1000, Max=1466400000)]
        public int Bitrate
        {
            get { return this._bitrate.GetValueOrDefault(); }
            set { this._bitrate = value; }
        }

        // Check to see if Bitrate property is set
        internal bool IsSetBitrate()
        {
            return this._bitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CodecLevel. H.265 Level.
        /// </summary>
        public H265CodecLevel CodecLevel
        {
            get { return this._codecLevel; }
            set { this._codecLevel = value; }
        }

        // Check to see if CodecLevel property is set
        internal bool IsSetCodecLevel()
        {
            return this._codecLevel != null;
        }

        /// <summary>
        /// Gets and sets the property CodecProfile. Represents the Profile and Tier, per the
        /// HEVC (H.265) specification. Selections are grouped as [Profile] / [Tier], so "Main/High"
        /// represents Main Profile with High Tier. 4:2:2 profiles are only available with the
        /// HEVC 4:2:2 License.
        /// </summary>
        public H265CodecProfile CodecProfile
        {
            get { return this._codecProfile; }
            set { this._codecProfile = value; }
        }

        // Check to see if CodecProfile property is set
        internal bool IsSetCodecProfile()
        {
            return this._codecProfile != null;
        }

        /// <summary>
        /// Gets and sets the property DynamicSubGop. Choose Adaptive to improve subjective video
        /// quality for high-motion content. This will cause the service to use fewer B-frames
        /// (which infer information based on other frames) for high-motion portions of the video
        /// and more B-frames for low-motion portions. The maximum number of B-frames is limited
        /// by the value you provide for the setting B frames between reference frames (numberBFramesBetweenReferenceFrames).
        /// </summary>
        public H265DynamicSubGop DynamicSubGop
        {
            get { return this._dynamicSubGop; }
            set { this._dynamicSubGop = value; }
        }

        // Check to see if DynamicSubGop property is set
        internal bool IsSetDynamicSubGop()
        {
            return this._dynamicSubGop != null;
        }

        /// <summary>
        /// Gets and sets the property FlickerAdaptiveQuantization. Adjust quantization within
        /// each frame to reduce flicker or 'pop' on I-frames.
        /// </summary>
        public H265FlickerAdaptiveQuantization FlickerAdaptiveQuantization
        {
            get { return this._flickerAdaptiveQuantization; }
            set { this._flickerAdaptiveQuantization = value; }
        }

        // Check to see if FlickerAdaptiveQuantization property is set
        internal bool IsSetFlickerAdaptiveQuantization()
        {
            return this._flickerAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateControl. If you are using the console, use the
        /// Framerate setting to specify the frame rate for this output. If you want to keep the
        /// same frame rate as the input video, choose Follow source. If you want to do frame
        /// rate conversion, choose a frame rate from the dropdown list or choose Custom. The
        /// framerates shown in the dropdown list are decimal approximations of fractions. If
        /// you choose Custom, specify your frame rate as a fraction. If you are creating your
        /// transcoding job sepecification as a JSON file without the console, use FramerateControl
        /// to specify which value the service uses for the frame rate for this output. Choose
        /// INITIALIZE_FROM_SOURCE if you want the service to use the frame rate from the input.
        /// Choose SPECIFIED if you want the service to use the frame rate you specify in the
        /// settings FramerateNumerator and FramerateDenominator.
        /// </summary>
        public H265FramerateControl FramerateControl
        {
            get { return this._framerateControl; }
            set { this._framerateControl = value; }
        }

        // Check to see if FramerateControl property is set
        internal bool IsSetFramerateControl()
        {
            return this._framerateControl != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateConversionAlgorithm. When set to INTERPOLATE,
        /// produces smoother motion during frame rate conversion.
        /// </summary>
        public H265FramerateConversionAlgorithm FramerateConversionAlgorithm
        {
            get { return this._framerateConversionAlgorithm; }
            set { this._framerateConversionAlgorithm = value; }
        }

        // Check to see if FramerateConversionAlgorithm property is set
        internal bool IsSetFramerateConversionAlgorithm()
        {
            return this._framerateConversionAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property FramerateDenominator. Frame rate denominator.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FramerateDenominator
        {
            get { return this._framerateDenominator.GetValueOrDefault(); }
            set { this._framerateDenominator = value; }
        }

        // Check to see if FramerateDenominator property is set
        internal bool IsSetFramerateDenominator()
        {
            return this._framerateDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FramerateNumerator. Frame rate numerator - frame rate is
        /// a fraction, e.g. 24000 / 1001 = 23.976 fps.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int FramerateNumerator
        {
            get { return this._framerateNumerator.GetValueOrDefault(); }
            set { this._framerateNumerator = value; }
        }

        // Check to see if FramerateNumerator property is set
        internal bool IsSetFramerateNumerator()
        {
            return this._framerateNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopBReference. If enable, use reference B frames for GOP
        /// structures that have B frames > 1.
        /// </summary>
        public H265GopBReference GopBReference
        {
            get { return this._gopBReference; }
            set { this._gopBReference = value; }
        }

        // Check to see if GopBReference property is set
        internal bool IsSetGopBReference()
        {
            return this._gopBReference != null;
        }

        /// <summary>
        /// Gets and sets the property GopClosedCadence. Frequency of closed GOPs. In streaming
        /// applications, it is recommended that this be set to 1 so a decoder joining mid-stream
        /// will receive an IDR frame as quickly as possible. Setting this value to 0 will break
        /// output segmenting.
        /// </summary>
        [AWSProperty(Min=0, Max=2147483647)]
        public int GopClosedCadence
        {
            get { return this._gopClosedCadence.GetValueOrDefault(); }
            set { this._gopClosedCadence = value; }
        }

        // Check to see if GopClosedCadence property is set
        internal bool IsSetGopClosedCadence()
        {
            return this._gopClosedCadence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSize. GOP Length (keyframe interval) in frames or seconds.
        /// Must be greater than zero.
        /// </summary>
        public double GopSize
        {
            get { return this._gopSize.GetValueOrDefault(); }
            set { this._gopSize = value; }
        }

        // Check to see if GopSize property is set
        internal bool IsSetGopSize()
        {
            return this._gopSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GopSizeUnits. Indicates if the GOP Size in H265 is specified
        /// in frames or seconds. If seconds the system will convert the GOP Size into a frame
        /// count at run time.
        /// </summary>
        public H265GopSizeUnits GopSizeUnits
        {
            get { return this._gopSizeUnits; }
            set { this._gopSizeUnits = value; }
        }

        // Check to see if GopSizeUnits property is set
        internal bool IsSetGopSizeUnits()
        {
            return this._gopSizeUnits != null;
        }

        /// <summary>
        /// Gets and sets the property HrdBufferInitialFillPercentage. Percentage of the buffer
        /// that should initially be filled (HRD buffer model).
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int HrdBufferInitialFillPercentage
        {
            get { return this._hrdBufferInitialFillPercentage.GetValueOrDefault(); }
            set { this._hrdBufferInitialFillPercentage = value; }
        }

        // Check to see if HrdBufferInitialFillPercentage property is set
        internal bool IsSetHrdBufferInitialFillPercentage()
        {
            return this._hrdBufferInitialFillPercentage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HrdBufferSize. Size of buffer (HRD buffer model) in bits.
        /// For example, enter five megabits as 5000000.
        /// </summary>
        [AWSProperty(Min=0, Max=1466400000)]
        public int HrdBufferSize
        {
            get { return this._hrdBufferSize.GetValueOrDefault(); }
            set { this._hrdBufferSize = value; }
        }

        // Check to see if HrdBufferSize property is set
        internal bool IsSetHrdBufferSize()
        {
            return this._hrdBufferSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InterlaceMode. Choose the scan line type for the output.
        /// Choose Progressive (PROGRESSIVE) to create a progressive output, regardless of the
        /// scan type of your input. Choose Top Field First (TOP_FIELD) or Bottom Field First
        /// (BOTTOM_FIELD) to create an output that's interlaced with the same field polarity
        /// throughout. Choose Follow, Default Top (FOLLOW_TOP_FIELD) or Follow, Default Bottom
        /// (FOLLOW_BOTTOM_FIELD) to create an interlaced output with the same field polarity
        /// as the source. If the source is interlaced, the output will be interlaced with the
        /// same polarity as the source (it will follow the source). The output could therefore
        /// be a mix of "top field first" and "bottom field first". If the source is progressive,
        /// your output will be interlaced with "top field first" or "bottom field first" polarity,
        /// depending on which of the Follow options you chose. If you don't choose a value, the
        /// service will default to Progressive (PROGRESSIVE).
        /// </summary>
        public H265InterlaceMode InterlaceMode
        {
            get { return this._interlaceMode; }
            set { this._interlaceMode = value; }
        }

        // Check to see if InterlaceMode property is set
        internal bool IsSetInterlaceMode()
        {
            return this._interlaceMode != null;
        }

        /// <summary>
        /// Gets and sets the property MaxBitrate. Maximum bitrate in bits/second. For example,
        /// enter five megabits per second as 5000000. Required when Rate control mode is QVBR.
        /// </summary>
        [AWSProperty(Min=1000, Max=1466400000)]
        public int MaxBitrate
        {
            get { return this._maxBitrate.GetValueOrDefault(); }
            set { this._maxBitrate = value; }
        }

        // Check to see if MaxBitrate property is set
        internal bool IsSetMaxBitrate()
        {
            return this._maxBitrate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinIInterval. Enforces separation between repeated (cadence)
        /// I-frames and I-frames inserted by Scene Change Detection. If a scene change I-frame
        /// is within I-interval frames of a cadence I-frame, the GOP is shrunk and/or stretched
        /// to the scene change I-frame. GOP stretch requires enabling lookahead as well as setting
        /// I-interval. The normal cadence resumes for the next GOP. This setting is only used
        /// when Scene Change Detect is enabled. Note: Maximum GOP stretch = GOP size + Min-I-interval
        /// - 1
        /// </summary>
        [AWSProperty(Min=0, Max=30)]
        public int MinIInterval
        {
            get { return this._minIInterval.GetValueOrDefault(); }
            set { this._minIInterval = value; }
        }

        // Check to see if MinIInterval property is set
        internal bool IsSetMinIInterval()
        {
            return this._minIInterval.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberBFramesBetweenReferenceFrames. Number of B-frames
        /// between reference frames.
        /// </summary>
        [AWSProperty(Min=0, Max=7)]
        public int NumberBFramesBetweenReferenceFrames
        {
            get { return this._numberBFramesBetweenReferenceFrames.GetValueOrDefault(); }
            set { this._numberBFramesBetweenReferenceFrames = value; }
        }

        // Check to see if NumberBFramesBetweenReferenceFrames property is set
        internal bool IsSetNumberBFramesBetweenReferenceFrames()
        {
            return this._numberBFramesBetweenReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberReferenceFrames. Number of reference frames to use.
        /// The encoder may use more than requested if using B-frames and/or interlaced encoding.
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public int NumberReferenceFrames
        {
            get { return this._numberReferenceFrames.GetValueOrDefault(); }
            set { this._numberReferenceFrames = value; }
        }

        // Check to see if NumberReferenceFrames property is set
        internal bool IsSetNumberReferenceFrames()
        {
            return this._numberReferenceFrames.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParControl. Using the API, enable ParFollowSource if you
        /// want the service to use the pixel aspect ratio from the input. Using the console,
        /// do this by choosing Follow source for Pixel aspect ratio.
        /// </summary>
        public H265ParControl ParControl
        {
            get { return this._parControl; }
            set { this._parControl = value; }
        }

        // Check to see if ParControl property is set
        internal bool IsSetParControl()
        {
            return this._parControl != null;
        }

        /// <summary>
        /// Gets and sets the property ParDenominator. Pixel Aspect Ratio denominator.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParDenominator
        {
            get { return this._parDenominator.GetValueOrDefault(); }
            set { this._parDenominator = value; }
        }

        // Check to see if ParDenominator property is set
        internal bool IsSetParDenominator()
        {
            return this._parDenominator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ParNumerator. Pixel Aspect Ratio numerator.
        /// </summary>
        [AWSProperty(Min=1, Max=2147483647)]
        public int ParNumerator
        {
            get { return this._parNumerator.GetValueOrDefault(); }
            set { this._parNumerator = value; }
        }

        // Check to see if ParNumerator property is set
        internal bool IsSetParNumerator()
        {
            return this._parNumerator.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property QualityTuningLevel. Use Quality tuning level (H265QualityTuningLevel)
        /// to specifiy whether to use fast single-pass, high-quality singlepass, or high-quality
        /// multipass video encoding.
        /// </summary>
        public H265QualityTuningLevel QualityTuningLevel
        {
            get { return this._qualityTuningLevel; }
            set { this._qualityTuningLevel = value; }
        }

        // Check to see if QualityTuningLevel property is set
        internal bool IsSetQualityTuningLevel()
        {
            return this._qualityTuningLevel != null;
        }

        /// <summary>
        /// Gets and sets the property QvbrSettings. Settings for quality-defined variable bitrate
        /// encoding with the H.265 codec. Required when you set Rate control mode to QVBR. Not
        /// valid when you set Rate control mode to a value other than QVBR, or when you don't
        /// define Rate control mode.
        /// </summary>
        public H265QvbrSettings QvbrSettings
        {
            get { return this._qvbrSettings; }
            set { this._qvbrSettings = value; }
        }

        // Check to see if QvbrSettings property is set
        internal bool IsSetQvbrSettings()
        {
            return this._qvbrSettings != null;
        }

        /// <summary>
        /// Gets and sets the property RateControlMode. Use this setting to specify whether this
        /// output has a variable bitrate (VBR), constant bitrate (CBR) or quality-defined variable
        /// bitrate (QVBR).
        /// </summary>
        public H265RateControlMode RateControlMode
        {
            get { return this._rateControlMode; }
            set { this._rateControlMode = value; }
        }

        // Check to see if RateControlMode property is set
        internal bool IsSetRateControlMode()
        {
            return this._rateControlMode != null;
        }

        /// <summary>
        /// Gets and sets the property SampleAdaptiveOffsetFilterMode. Specify Sample Adaptive
        /// Offset (SAO) filter strength.  Adaptive mode dynamically selects best strength based
        /// on content
        /// </summary>
        public H265SampleAdaptiveOffsetFilterMode SampleAdaptiveOffsetFilterMode
        {
            get { return this._sampleAdaptiveOffsetFilterMode; }
            set { this._sampleAdaptiveOffsetFilterMode = value; }
        }

        // Check to see if SampleAdaptiveOffsetFilterMode property is set
        internal bool IsSetSampleAdaptiveOffsetFilterMode()
        {
            return this._sampleAdaptiveOffsetFilterMode != null;
        }

        /// <summary>
        /// Gets and sets the property SceneChangeDetect. Enable this setting to insert I-frames
        /// at scene changes that the service automatically detects. This improves video quality
        /// and is enabled by default. If this output uses QVBR, choose Transition detection (TRANSITION_DETECTION)
        /// for further video quality improvement. For more information about QVBR, see https://docs.aws.amazon.com/console/mediaconvert/cbr-vbr-qvbr.
        /// </summary>
        public H265SceneChangeDetect SceneChangeDetect
        {
            get { return this._sceneChangeDetect; }
            set { this._sceneChangeDetect = value; }
        }

        // Check to see if SceneChangeDetect property is set
        internal bool IsSetSceneChangeDetect()
        {
            return this._sceneChangeDetect != null;
        }

        /// <summary>
        /// Gets and sets the property Slices. Number of slices per picture. Must be less than
        /// or equal to the number of macroblock rows for progressive pictures, and less than
        /// or equal to half the number of macroblock rows for interlaced pictures.
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public int Slices
        {
            get { return this._slices.GetValueOrDefault(); }
            set { this._slices = value; }
        }

        // Check to see if Slices property is set
        internal bool IsSetSlices()
        {
            return this._slices.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SlowPal. Enables Slow PAL rate conversion. 23.976fps and
        /// 24fps input is relabeled as 25fps, and audio is sped up correspondingly.
        /// </summary>
        public H265SlowPal SlowPal
        {
            get { return this._slowPal; }
            set { this._slowPal = value; }
        }

        // Check to see if SlowPal property is set
        internal bool IsSetSlowPal()
        {
            return this._slowPal != null;
        }

        /// <summary>
        /// Gets and sets the property SpatialAdaptiveQuantization. Adjust quantization within
        /// each frame based on spatial variation of content complexity.
        /// </summary>
        public H265SpatialAdaptiveQuantization SpatialAdaptiveQuantization
        {
            get { return this._spatialAdaptiveQuantization; }
            set { this._spatialAdaptiveQuantization = value; }
        }

        // Check to see if SpatialAdaptiveQuantization property is set
        internal bool IsSetSpatialAdaptiveQuantization()
        {
            return this._spatialAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property Telecine. This field applies only if the Streams > Advanced
        /// > Framerate (framerate) field  is set to 29.970. This field works with the Streams
        /// > Advanced > Preprocessors > Deinterlacer  field (deinterlace_mode) and the Streams
        /// > Advanced > Interlaced Mode field (interlace_mode)  to identify the scan type for
        /// the output: Progressive, Interlaced, Hard Telecine or Soft Telecine. - Hard: produces
        /// 29.97i output from 23.976 input. - Soft: produces 23.976; the player converts this
        /// output to 29.97i.
        /// </summary>
        public H265Telecine Telecine
        {
            get { return this._telecine; }
            set { this._telecine = value; }
        }

        // Check to see if Telecine property is set
        internal bool IsSetTelecine()
        {
            return this._telecine != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalAdaptiveQuantization. Adjust quantization within
        /// each frame based on temporal variation of content complexity.
        /// </summary>
        public H265TemporalAdaptiveQuantization TemporalAdaptiveQuantization
        {
            get { return this._temporalAdaptiveQuantization; }
            set { this._temporalAdaptiveQuantization = value; }
        }

        // Check to see if TemporalAdaptiveQuantization property is set
        internal bool IsSetTemporalAdaptiveQuantization()
        {
            return this._temporalAdaptiveQuantization != null;
        }

        /// <summary>
        /// Gets and sets the property TemporalIds. Enables temporal layer identifiers in the
        /// encoded bitstream. Up to 3 layers are supported depending on GOP structure: I- and
        /// P-frames form one layer, reference B-frames can form a second layer and non-reference
        /// b-frames can form a third layer. Decoders can optionally decode only the lower temporal
        /// layers to generate a lower frame rate output. For example, given a bitstream with
        /// temporal IDs and with b-frames = 1 (i.e. IbPbPb display order), a decoder could decode
        /// all the frames for full frame rate output or only the I and P frames (lowest temporal
        /// layer) for a half frame rate output.
        /// </summary>
        public H265TemporalIds TemporalIds
        {
            get { return this._temporalIds; }
            set { this._temporalIds = value; }
        }

        // Check to see if TemporalIds property is set
        internal bool IsSetTemporalIds()
        {
            return this._temporalIds != null;
        }

        /// <summary>
        /// Gets and sets the property Tiles. Enable use of tiles, allowing horizontal as well
        /// as vertical subdivision of the encoded pictures.
        /// </summary>
        public H265Tiles Tiles
        {
            get { return this._tiles; }
            set { this._tiles = value; }
        }

        // Check to see if Tiles property is set
        internal bool IsSetTiles()
        {
            return this._tiles != null;
        }

        /// <summary>
        /// Gets and sets the property UnregisteredSeiTimecode. Inserts timecode for each frame
        /// as 4 bytes of an unregistered SEI message.
        /// </summary>
        public H265UnregisteredSeiTimecode UnregisteredSeiTimecode
        {
            get { return this._unregisteredSeiTimecode; }
            set { this._unregisteredSeiTimecode = value; }
        }

        // Check to see if UnregisteredSeiTimecode property is set
        internal bool IsSetUnregisteredSeiTimecode()
        {
            return this._unregisteredSeiTimecode != null;
        }

        /// <summary>
        /// Gets and sets the property WriteMp4PackagingType. If the location of parameter set
        /// NAL units doesn't matter in your workflow, ignore this setting. Use this setting only
        /// with CMAF or DASH outputs, or with standalone file outputs in an MPEG-4 container
        /// (MP4 outputs). Choose HVC1 to mark your output as HVC1. This makes your output compliant
        /// with the following specification: ISO IECJTC1 SC29 N13798 Text ISO/IEC FDIS 14496-15
        /// 3rd Edition. For these outputs, the service stores parameter set NAL units in the
        /// sample headers but not in the samples directly. For MP4 outputs, when you choose HVC1,
        /// your output video might not work properly with some downstream systems and video players.
        /// The service defaults to marking your output as HEV1. For these outputs, the service
        /// writes parameter set NAL units directly into the samples.
        /// </summary>
        public H265WriteMp4PackagingType WriteMp4PackagingType
        {
            get { return this._writeMp4PackagingType; }
            set { this._writeMp4PackagingType = value; }
        }

        // Check to see if WriteMp4PackagingType property is set
        internal bool IsSetWriteMp4PackagingType()
        {
            return this._writeMp4PackagingType != null;
        }

    }
}