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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */

using System;

using Amazon.Runtime;

namespace Amazon.SageMaker
{

    /// <summary>
    /// Constants used for properties of type AlgorithmSortBy.
    /// </summary>
    public class AlgorithmSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for AlgorithmSortBy
        /// </summary>
        public static readonly AlgorithmSortBy CreationTime = new AlgorithmSortBy("CreationTime");
        /// <summary>
        /// Constant Name for AlgorithmSortBy
        /// </summary>
        public static readonly AlgorithmSortBy Name = new AlgorithmSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmSortBy FindValue(string value)
        {
            return FindValue<AlgorithmSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AlgorithmStatus.
    /// </summary>
    public class AlgorithmStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Completed = new AlgorithmStatus("Completed");
        /// <summary>
        /// Constant Deleting for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Deleting = new AlgorithmStatus("Deleting");
        /// <summary>
        /// Constant Failed for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Failed = new AlgorithmStatus("Failed");
        /// <summary>
        /// Constant InProgress for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus InProgress = new AlgorithmStatus("InProgress");
        /// <summary>
        /// Constant Pending for AlgorithmStatus
        /// </summary>
        public static readonly AlgorithmStatus Pending = new AlgorithmStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AlgorithmStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AlgorithmStatus FindValue(string value)
        {
            return FindValue<AlgorithmStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AlgorithmStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type AssemblyType.
    /// </summary>
    public class AssemblyType : ConstantClass
    {

        /// <summary>
        /// Constant Line for AssemblyType
        /// </summary>
        public static readonly AssemblyType Line = new AssemblyType("Line");
        /// <summary>
        /// Constant None for AssemblyType
        /// </summary>
        public static readonly AssemblyType None = new AssemblyType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public AssemblyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static AssemblyType FindValue(string value)
        {
            return FindValue<AssemblyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator AssemblyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BatchStrategy.
    /// </summary>
    public class BatchStrategy : ConstantClass
    {

        /// <summary>
        /// Constant MultiRecord for BatchStrategy
        /// </summary>
        public static readonly BatchStrategy MultiRecord = new BatchStrategy("MultiRecord");
        /// <summary>
        /// Constant SingleRecord for BatchStrategy
        /// </summary>
        public static readonly BatchStrategy SingleRecord = new BatchStrategy("SingleRecord");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BatchStrategy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BatchStrategy FindValue(string value)
        {
            return FindValue<BatchStrategy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BatchStrategy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type BooleanOperator.
    /// </summary>
    public class BooleanOperator : ConstantClass
    {

        /// <summary>
        /// Constant And for BooleanOperator
        /// </summary>
        public static readonly BooleanOperator And = new BooleanOperator("And");
        /// <summary>
        /// Constant Or for BooleanOperator
        /// </summary>
        public static readonly BooleanOperator Or = new BooleanOperator("Or");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public BooleanOperator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static BooleanOperator FindValue(string value)
        {
            return FindValue<BooleanOperator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator BooleanOperator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRepositorySortBy.
    /// </summary>
    public class CodeRepositorySortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy CreationTime = new CodeRepositorySortBy("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy LastModifiedTime = new CodeRepositorySortBy("LastModifiedTime");
        /// <summary>
        /// Constant Name for CodeRepositorySortBy
        /// </summary>
        public static readonly CodeRepositorySortBy Name = new CodeRepositorySortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRepositorySortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRepositorySortBy FindValue(string value)
        {
            return FindValue<CodeRepositorySortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRepositorySortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CodeRepositorySortOrder.
    /// </summary>
    public class CodeRepositorySortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for CodeRepositorySortOrder
        /// </summary>
        public static readonly CodeRepositorySortOrder Ascending = new CodeRepositorySortOrder("Ascending");
        /// <summary>
        /// Constant Descending for CodeRepositorySortOrder
        /// </summary>
        public static readonly CodeRepositorySortOrder Descending = new CodeRepositorySortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CodeRepositorySortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CodeRepositorySortOrder FindValue(string value)
        {
            return FindValue<CodeRepositorySortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CodeRepositorySortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompilationJobStatus.
    /// </summary>
    public class CompilationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant COMPLETED for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus COMPLETED = new CompilationJobStatus("COMPLETED");
        /// <summary>
        /// Constant FAILED for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus FAILED = new CompilationJobStatus("FAILED");
        /// <summary>
        /// Constant INPROGRESS for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus INPROGRESS = new CompilationJobStatus("INPROGRESS");
        /// <summary>
        /// Constant STARTING for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus STARTING = new CompilationJobStatus("STARTING");
        /// <summary>
        /// Constant STOPPED for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus STOPPED = new CompilationJobStatus("STOPPED");
        /// <summary>
        /// Constant STOPPING for CompilationJobStatus
        /// </summary>
        public static readonly CompilationJobStatus STOPPING = new CompilationJobStatus("STOPPING");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompilationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompilationJobStatus FindValue(string value)
        {
            return FindValue<CompilationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompilationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type CompressionType.
    /// </summary>
    public class CompressionType : ConstantClass
    {

        /// <summary>
        /// Constant Gzip for CompressionType
        /// </summary>
        public static readonly CompressionType Gzip = new CompressionType("Gzip");
        /// <summary>
        /// Constant None for CompressionType
        /// </summary>
        public static readonly CompressionType None = new CompressionType("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public CompressionType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static CompressionType FindValue(string value)
        {
            return FindValue<CompressionType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator CompressionType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ContentClassifier.
    /// </summary>
    public class ContentClassifier : ConstantClass
    {

        /// <summary>
        /// Constant FreeOfAdultContent for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfAdultContent = new ContentClassifier("FreeOfAdultContent");
        /// <summary>
        /// Constant FreeOfPersonallyIdentifiableInformation for ContentClassifier
        /// </summary>
        public static readonly ContentClassifier FreeOfPersonallyIdentifiableInformation = new ContentClassifier("FreeOfPersonallyIdentifiableInformation");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ContentClassifier(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ContentClassifier FindValue(string value)
        {
            return FindValue<ContentClassifier>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ContentClassifier(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetailedAlgorithmStatus.
    /// </summary>
    public class DetailedAlgorithmStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus Completed = new DetailedAlgorithmStatus("Completed");
        /// <summary>
        /// Constant Failed for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus Failed = new DetailedAlgorithmStatus("Failed");
        /// <summary>
        /// Constant InProgress for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus InProgress = new DetailedAlgorithmStatus("InProgress");
        /// <summary>
        /// Constant NotStarted for DetailedAlgorithmStatus
        /// </summary>
        public static readonly DetailedAlgorithmStatus NotStarted = new DetailedAlgorithmStatus("NotStarted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedAlgorithmStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedAlgorithmStatus FindValue(string value)
        {
            return FindValue<DetailedAlgorithmStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedAlgorithmStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DetailedModelPackageStatus.
    /// </summary>
    public class DetailedModelPackageStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus Completed = new DetailedModelPackageStatus("Completed");
        /// <summary>
        /// Constant Failed for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus Failed = new DetailedModelPackageStatus("Failed");
        /// <summary>
        /// Constant InProgress for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus InProgress = new DetailedModelPackageStatus("InProgress");
        /// <summary>
        /// Constant NotStarted for DetailedModelPackageStatus
        /// </summary>
        public static readonly DetailedModelPackageStatus NotStarted = new DetailedModelPackageStatus("NotStarted");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DetailedModelPackageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DetailedModelPackageStatus FindValue(string value)
        {
            return FindValue<DetailedModelPackageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DetailedModelPackageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type DirectInternetAccess.
    /// </summary>
    public class DirectInternetAccess : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for DirectInternetAccess
        /// </summary>
        public static readonly DirectInternetAccess Disabled = new DirectInternetAccess("Disabled");
        /// <summary>
        /// Constant Enabled for DirectInternetAccess
        /// </summary>
        public static readonly DirectInternetAccess Enabled = new DirectInternetAccess("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public DirectInternetAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static DirectInternetAccess FindValue(string value)
        {
            return FindValue<DirectInternetAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator DirectInternetAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointConfigSortKey.
    /// </summary>
    public class EndpointConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for EndpointConfigSortKey
        /// </summary>
        public static readonly EndpointConfigSortKey CreationTime = new EndpointConfigSortKey("CreationTime");
        /// <summary>
        /// Constant Name for EndpointConfigSortKey
        /// </summary>
        public static readonly EndpointConfigSortKey Name = new EndpointConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointConfigSortKey FindValue(string value)
        {
            return FindValue<EndpointConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointSortKey.
    /// </summary>
    public class EndpointSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey CreationTime = new EndpointSortKey("CreationTime");
        /// <summary>
        /// Constant Name for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey Name = new EndpointSortKey("Name");
        /// <summary>
        /// Constant Status for EndpointSortKey
        /// </summary>
        public static readonly EndpointSortKey Status = new EndpointSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointSortKey FindValue(string value)
        {
            return FindValue<EndpointSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type EndpointStatus.
    /// </summary>
    public class EndpointStatus : ConstantClass
    {

        /// <summary>
        /// Constant Creating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Creating = new EndpointStatus("Creating");
        /// <summary>
        /// Constant Deleting for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Deleting = new EndpointStatus("Deleting");
        /// <summary>
        /// Constant Failed for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Failed = new EndpointStatus("Failed");
        /// <summary>
        /// Constant InService for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus InService = new EndpointStatus("InService");
        /// <summary>
        /// Constant OutOfService for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus OutOfService = new EndpointStatus("OutOfService");
        /// <summary>
        /// Constant RollingBack for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus RollingBack = new EndpointStatus("RollingBack");
        /// <summary>
        /// Constant SystemUpdating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus SystemUpdating = new EndpointStatus("SystemUpdating");
        /// <summary>
        /// Constant Updating for EndpointStatus
        /// </summary>
        public static readonly EndpointStatus Updating = new EndpointStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public EndpointStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static EndpointStatus FindValue(string value)
        {
            return FindValue<EndpointStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator EndpointStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemAccessMode.
    /// </summary>
    public class FileSystemAccessMode : ConstantClass
    {

        /// <summary>
        /// Constant Ro for FileSystemAccessMode
        /// </summary>
        public static readonly FileSystemAccessMode Ro = new FileSystemAccessMode("ro");
        /// <summary>
        /// Constant Rw for FileSystemAccessMode
        /// </summary>
        public static readonly FileSystemAccessMode Rw = new FileSystemAccessMode("rw");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemAccessMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemAccessMode FindValue(string value)
        {
            return FindValue<FileSystemAccessMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemAccessMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type FileSystemType.
    /// </summary>
    public class FileSystemType : ConstantClass
    {

        /// <summary>
        /// Constant EFS for FileSystemType
        /// </summary>
        public static readonly FileSystemType EFS = new FileSystemType("EFS");
        /// <summary>
        /// Constant FSxLustre for FileSystemType
        /// </summary>
        public static readonly FileSystemType FSxLustre = new FileSystemType("FSxLustre");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FileSystemType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FileSystemType FindValue(string value)
        {
            return FindValue<FileSystemType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FileSystemType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Framework.
    /// </summary>
    public class Framework : ConstantClass
    {

        /// <summary>
        /// Constant MXNET for Framework
        /// </summary>
        public static readonly Framework MXNET = new Framework("MXNET");
        /// <summary>
        /// Constant ONNX for Framework
        /// </summary>
        public static readonly Framework ONNX = new Framework("ONNX");
        /// <summary>
        /// Constant PYTORCH for Framework
        /// </summary>
        public static readonly Framework PYTORCH = new Framework("PYTORCH");
        /// <summary>
        /// Constant TENSORFLOW for Framework
        /// </summary>
        public static readonly Framework TENSORFLOW = new Framework("TENSORFLOW");
        /// <summary>
        /// Constant XGBOOST for Framework
        /// </summary>
        public static readonly Framework XGBOOST = new Framework("XGBOOST");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Framework(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Framework FindValue(string value)
        {
            return FindValue<Framework>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Framework(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterScalingType.
    /// </summary>
    public class HyperParameterScalingType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType Auto = new HyperParameterScalingType("Auto");
        /// <summary>
        /// Constant Linear for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType Linear = new HyperParameterScalingType("Linear");
        /// <summary>
        /// Constant Logarithmic for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType Logarithmic = new HyperParameterScalingType("Logarithmic");
        /// <summary>
        /// Constant ReverseLogarithmic for HyperParameterScalingType
        /// </summary>
        public static readonly HyperParameterScalingType ReverseLogarithmic = new HyperParameterScalingType("ReverseLogarithmic");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterScalingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterScalingType FindValue(string value)
        {
            return FindValue<HyperParameterScalingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterScalingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobObjectiveType.
    /// </summary>
    public class HyperParameterTuningJobObjectiveType : ConstantClass
    {

        /// <summary>
        /// Constant Maximize for HyperParameterTuningJobObjectiveType
        /// </summary>
        public static readonly HyperParameterTuningJobObjectiveType Maximize = new HyperParameterTuningJobObjectiveType("Maximize");
        /// <summary>
        /// Constant Minimize for HyperParameterTuningJobObjectiveType
        /// </summary>
        public static readonly HyperParameterTuningJobObjectiveType Minimize = new HyperParameterTuningJobObjectiveType("Minimize");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobObjectiveType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobObjectiveType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobObjectiveType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobObjectiveType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobSortByOptions.
    /// </summary>
    public class HyperParameterTuningJobSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions CreationTime = new HyperParameterTuningJobSortByOptions("CreationTime");
        /// <summary>
        /// Constant Name for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions Name = new HyperParameterTuningJobSortByOptions("Name");
        /// <summary>
        /// Constant Status for HyperParameterTuningJobSortByOptions
        /// </summary>
        public static readonly HyperParameterTuningJobSortByOptions Status = new HyperParameterTuningJobSortByOptions("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobSortByOptions FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobStatus.
    /// </summary>
    public class HyperParameterTuningJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Completed = new HyperParameterTuningJobStatus("Completed");
        /// <summary>
        /// Constant Failed for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Failed = new HyperParameterTuningJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus InProgress = new HyperParameterTuningJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Stopped = new HyperParameterTuningJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for HyperParameterTuningJobStatus
        /// </summary>
        public static readonly HyperParameterTuningJobStatus Stopping = new HyperParameterTuningJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobStatus FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobStrategyType.
    /// </summary>
    public class HyperParameterTuningJobStrategyType : ConstantClass
    {

        /// <summary>
        /// Constant Bayesian for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Bayesian = new HyperParameterTuningJobStrategyType("Bayesian");
        /// <summary>
        /// Constant Random for HyperParameterTuningJobStrategyType
        /// </summary>
        public static readonly HyperParameterTuningJobStrategyType Random = new HyperParameterTuningJobStrategyType("Random");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobStrategyType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobStrategyType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobStrategyType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobStrategyType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type HyperParameterTuningJobWarmStartType.
    /// </summary>
    public class HyperParameterTuningJobWarmStartType : ConstantClass
    {

        /// <summary>
        /// Constant IdenticalDataAndAlgorithm for HyperParameterTuningJobWarmStartType
        /// </summary>
        public static readonly HyperParameterTuningJobWarmStartType IdenticalDataAndAlgorithm = new HyperParameterTuningJobWarmStartType("IdenticalDataAndAlgorithm");
        /// <summary>
        /// Constant TransferLearning for HyperParameterTuningJobWarmStartType
        /// </summary>
        public static readonly HyperParameterTuningJobWarmStartType TransferLearning = new HyperParameterTuningJobWarmStartType("TransferLearning");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public HyperParameterTuningJobWarmStartType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static HyperParameterTuningJobWarmStartType FindValue(string value)
        {
            return FindValue<HyperParameterTuningJobWarmStartType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator HyperParameterTuningJobWarmStartType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type InstanceType.
    /// </summary>
    public class InstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC42xlarge = new InstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC44xlarge = new InstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC48xlarge = new InstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC4Xlarge = new InstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC518xlarge = new InstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC52xlarge = new InstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC54xlarge = new InstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC59xlarge = new InstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5d18xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d18xlarge = new InstanceType("ml.c5d.18xlarge");
        /// <summary>
        /// Constant MlC5d2xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d2xlarge = new InstanceType("ml.c5d.2xlarge");
        /// <summary>
        /// Constant MlC5d4xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d4xlarge = new InstanceType("ml.c5d.4xlarge");
        /// <summary>
        /// Constant MlC5d9xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5d9xlarge = new InstanceType("ml.c5d.9xlarge");
        /// <summary>
        /// Constant MlC5dXlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5dXlarge = new InstanceType("ml.c5d.xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlC5Xlarge = new InstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM410xlarge = new InstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM416xlarge = new InstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM42xlarge = new InstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM44xlarge = new InstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM4Xlarge = new InstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM512xlarge = new InstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM524xlarge = new InstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM52xlarge = new InstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM54xlarge = new InstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlM5Xlarge = new InstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP216xlarge = new InstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP28xlarge = new InstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP2Xlarge = new InstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP316xlarge = new InstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP32xlarge = new InstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlP38xlarge = new InstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlT22xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT22xlarge = new InstanceType("ml.t2.2xlarge");
        /// <summary>
        /// Constant MlT2Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Large = new InstanceType("ml.t2.large");
        /// <summary>
        /// Constant MlT2Medium for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Medium = new InstanceType("ml.t2.medium");
        /// <summary>
        /// Constant MlT2Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT2Xlarge = new InstanceType("ml.t2.xlarge");
        /// <summary>
        /// Constant MlT32xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT32xlarge = new InstanceType("ml.t3.2xlarge");
        /// <summary>
        /// Constant MlT3Large for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Large = new InstanceType("ml.t3.large");
        /// <summary>
        /// Constant MlT3Medium for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Medium = new InstanceType("ml.t3.medium");
        /// <summary>
        /// Constant MlT3Xlarge for InstanceType
        /// </summary>
        public static readonly InstanceType MlT3Xlarge = new InstanceType("ml.t3.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public InstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static InstanceType FindValue(string value)
        {
            return FindValue<InstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator InstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type JoinSource.
    /// </summary>
    public class JoinSource : ConstantClass
    {

        /// <summary>
        /// Constant Input for JoinSource
        /// </summary>
        public static readonly JoinSource Input = new JoinSource("Input");
        /// <summary>
        /// Constant None for JoinSource
        /// </summary>
        public static readonly JoinSource None = new JoinSource("None");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public JoinSource(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static JoinSource FindValue(string value)
        {
            return FindValue<JoinSource>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator JoinSource(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type LabelingJobStatus.
    /// </summary>
    public class LabelingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Completed = new LabelingJobStatus("Completed");
        /// <summary>
        /// Constant Failed for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Failed = new LabelingJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus InProgress = new LabelingJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Stopped = new LabelingJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for LabelingJobStatus
        /// </summary>
        public static readonly LabelingJobStatus Stopping = new LabelingJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public LabelingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static LabelingJobStatus FindValue(string value)
        {
            return FindValue<LabelingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator LabelingJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListCompilationJobsSortBy.
    /// </summary>
    public class ListCompilationJobsSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ListCompilationJobsSortBy
        /// </summary>
        public static readonly ListCompilationJobsSortBy CreationTime = new ListCompilationJobsSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ListCompilationJobsSortBy
        /// </summary>
        public static readonly ListCompilationJobsSortBy Name = new ListCompilationJobsSortBy("Name");
        /// <summary>
        /// Constant Status for ListCompilationJobsSortBy
        /// </summary>
        public static readonly ListCompilationJobsSortBy Status = new ListCompilationJobsSortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListCompilationJobsSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListCompilationJobsSortBy FindValue(string value)
        {
            return FindValue<ListCompilationJobsSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListCompilationJobsSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListLabelingJobsForWorkteamSortByOptions.
    /// </summary>
    public class ListLabelingJobsForWorkteamSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ListLabelingJobsForWorkteamSortByOptions
        /// </summary>
        public static readonly ListLabelingJobsForWorkteamSortByOptions CreationTime = new ListLabelingJobsForWorkteamSortByOptions("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListLabelingJobsForWorkteamSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListLabelingJobsForWorkteamSortByOptions FindValue(string value)
        {
            return FindValue<ListLabelingJobsForWorkteamSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListLabelingJobsForWorkteamSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ListWorkteamsSortByOptions.
    /// </summary>
    public class ListWorkteamsSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreateDate for ListWorkteamsSortByOptions
        /// </summary>
        public static readonly ListWorkteamsSortByOptions CreateDate = new ListWorkteamsSortByOptions("CreateDate");
        /// <summary>
        /// Constant Name for ListWorkteamsSortByOptions
        /// </summary>
        public static readonly ListWorkteamsSortByOptions Name = new ListWorkteamsSortByOptions("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ListWorkteamsSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ListWorkteamsSortByOptions FindValue(string value)
        {
            return FindValue<ListWorkteamsSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ListWorkteamsSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageSortBy.
    /// </summary>
    public class ModelPackageSortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelPackageSortBy
        /// </summary>
        public static readonly ModelPackageSortBy CreationTime = new ModelPackageSortBy("CreationTime");
        /// <summary>
        /// Constant Name for ModelPackageSortBy
        /// </summary>
        public static readonly ModelPackageSortBy Name = new ModelPackageSortBy("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageSortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageSortBy FindValue(string value)
        {
            return FindValue<ModelPackageSortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageSortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelPackageStatus.
    /// </summary>
    public class ModelPackageStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Completed = new ModelPackageStatus("Completed");
        /// <summary>
        /// Constant Deleting for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Deleting = new ModelPackageStatus("Deleting");
        /// <summary>
        /// Constant Failed for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Failed = new ModelPackageStatus("Failed");
        /// <summary>
        /// Constant InProgress for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus InProgress = new ModelPackageStatus("InProgress");
        /// <summary>
        /// Constant Pending for ModelPackageStatus
        /// </summary>
        public static readonly ModelPackageStatus Pending = new ModelPackageStatus("Pending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelPackageStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelPackageStatus FindValue(string value)
        {
            return FindValue<ModelPackageStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelPackageStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelSortKey.
    /// </summary>
    public class ModelSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for ModelSortKey
        /// </summary>
        public static readonly ModelSortKey CreationTime = new ModelSortKey("CreationTime");
        /// <summary>
        /// Constant Name for ModelSortKey
        /// </summary>
        public static readonly ModelSortKey Name = new ModelSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelSortKey FindValue(string value)
        {
            return FindValue<ModelSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceAcceleratorType.
    /// </summary>
    public class NotebookInstanceAcceleratorType : ConstantClass
    {

        /// <summary>
        /// Constant MlEia1Large for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia1Large = new NotebookInstanceAcceleratorType("ml.eia1.large");
        /// <summary>
        /// Constant MlEia1Medium for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia1Medium = new NotebookInstanceAcceleratorType("ml.eia1.medium");
        /// <summary>
        /// Constant MlEia1Xlarge for NotebookInstanceAcceleratorType
        /// </summary>
        public static readonly NotebookInstanceAcceleratorType MlEia1Xlarge = new NotebookInstanceAcceleratorType("ml.eia1.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceAcceleratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceAcceleratorType FindValue(string value)
        {
            return FindValue<NotebookInstanceAcceleratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceAcceleratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceLifecycleConfigSortKey.
    /// </summary>
    public class NotebookInstanceLifecycleConfigSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey CreationTime = new NotebookInstanceLifecycleConfigSortKey("CreationTime");
        /// <summary>
        /// Constant LastModifiedTime for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey LastModifiedTime = new NotebookInstanceLifecycleConfigSortKey("LastModifiedTime");
        /// <summary>
        /// Constant Name for NotebookInstanceLifecycleConfigSortKey
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortKey Name = new NotebookInstanceLifecycleConfigSortKey("Name");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceLifecycleConfigSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceLifecycleConfigSortKey FindValue(string value)
        {
            return FindValue<NotebookInstanceLifecycleConfigSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceLifecycleConfigSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceLifecycleConfigSortOrder.
    /// </summary>
    public class NotebookInstanceLifecycleConfigSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for NotebookInstanceLifecycleConfigSortOrder
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortOrder Ascending = new NotebookInstanceLifecycleConfigSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for NotebookInstanceLifecycleConfigSortOrder
        /// </summary>
        public static readonly NotebookInstanceLifecycleConfigSortOrder Descending = new NotebookInstanceLifecycleConfigSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceLifecycleConfigSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceLifecycleConfigSortOrder FindValue(string value)
        {
            return FindValue<NotebookInstanceLifecycleConfigSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceLifecycleConfigSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceSortKey.
    /// </summary>
    public class NotebookInstanceSortKey : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey CreationTime = new NotebookInstanceSortKey("CreationTime");
        /// <summary>
        /// Constant Name for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey Name = new NotebookInstanceSortKey("Name");
        /// <summary>
        /// Constant Status for NotebookInstanceSortKey
        /// </summary>
        public static readonly NotebookInstanceSortKey Status = new NotebookInstanceSortKey("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceSortKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceSortKey FindValue(string value)
        {
            return FindValue<NotebookInstanceSortKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceSortKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceSortOrder.
    /// </summary>
    public class NotebookInstanceSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for NotebookInstanceSortOrder
        /// </summary>
        public static readonly NotebookInstanceSortOrder Ascending = new NotebookInstanceSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for NotebookInstanceSortOrder
        /// </summary>
        public static readonly NotebookInstanceSortOrder Descending = new NotebookInstanceSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceSortOrder FindValue(string value)
        {
            return FindValue<NotebookInstanceSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type NotebookInstanceStatus.
    /// </summary>
    public class NotebookInstanceStatus : ConstantClass
    {

        /// <summary>
        /// Constant Deleting for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Deleting = new NotebookInstanceStatus("Deleting");
        /// <summary>
        /// Constant Failed for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Failed = new NotebookInstanceStatus("Failed");
        /// <summary>
        /// Constant InService for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus InService = new NotebookInstanceStatus("InService");
        /// <summary>
        /// Constant Pending for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Pending = new NotebookInstanceStatus("Pending");
        /// <summary>
        /// Constant Stopped for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Stopped = new NotebookInstanceStatus("Stopped");
        /// <summary>
        /// Constant Stopping for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Stopping = new NotebookInstanceStatus("Stopping");
        /// <summary>
        /// Constant Updating for NotebookInstanceStatus
        /// </summary>
        public static readonly NotebookInstanceStatus Updating = new NotebookInstanceStatus("Updating");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public NotebookInstanceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static NotebookInstanceStatus FindValue(string value)
        {
            return FindValue<NotebookInstanceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator NotebookInstanceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ObjectiveStatus.
    /// </summary>
    public class ObjectiveStatus : ConstantClass
    {

        /// <summary>
        /// Constant Failed for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Failed = new ObjectiveStatus("Failed");
        /// <summary>
        /// Constant Pending for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Pending = new ObjectiveStatus("Pending");
        /// <summary>
        /// Constant Succeeded for ObjectiveStatus
        /// </summary>
        public static readonly ObjectiveStatus Succeeded = new ObjectiveStatus("Succeeded");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ObjectiveStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ObjectiveStatus FindValue(string value)
        {
            return FindValue<ObjectiveStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ObjectiveStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type Operator.
    /// </summary>
    public class Operator : ConstantClass
    {

        /// <summary>
        /// Constant Contains for Operator
        /// </summary>
        public static readonly Operator Contains = new Operator("Contains");
        /// <summary>
        /// Constant Equals for Operator
        /// </summary>
        public static readonly Operator Equals = new Operator("Equals");
        /// <summary>
        /// Constant GreaterThan for Operator
        /// </summary>
        public static readonly Operator GreaterThan = new Operator("GreaterThan");
        /// <summary>
        /// Constant GreaterThanOrEqualTo for Operator
        /// </summary>
        public static readonly Operator GreaterThanOrEqualTo = new Operator("GreaterThanOrEqualTo");
        /// <summary>
        /// Constant LessThan for Operator
        /// </summary>
        public static readonly Operator LessThan = new Operator("LessThan");
        /// <summary>
        /// Constant LessThanOrEqualTo for Operator
        /// </summary>
        public static readonly Operator LessThanOrEqualTo = new Operator("LessThanOrEqualTo");
        /// <summary>
        /// Constant NotEquals for Operator
        /// </summary>
        public static readonly Operator NotEquals = new Operator("NotEquals");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public Operator(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static Operator FindValue(string value)
        {
            return FindValue<Operator>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator Operator(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type OrderKey.
    /// </summary>
    public class OrderKey : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for OrderKey
        /// </summary>
        public static readonly OrderKey Ascending = new OrderKey("Ascending");
        /// <summary>
        /// Constant Descending for OrderKey
        /// </summary>
        public static readonly OrderKey Descending = new OrderKey("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public OrderKey(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static OrderKey FindValue(string value)
        {
            return FindValue<OrderKey>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator OrderKey(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ParameterType.
    /// </summary>
    public class ParameterType : ConstantClass
    {

        /// <summary>
        /// Constant Categorical for ParameterType
        /// </summary>
        public static readonly ParameterType Categorical = new ParameterType("Categorical");
        /// <summary>
        /// Constant Continuous for ParameterType
        /// </summary>
        public static readonly ParameterType Continuous = new ParameterType("Continuous");
        /// <summary>
        /// Constant FreeText for ParameterType
        /// </summary>
        public static readonly ParameterType FreeText = new ParameterType("FreeText");
        /// <summary>
        /// Constant Integer for ParameterType
        /// </summary>
        public static readonly ParameterType Integer = new ParameterType("Integer");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ParameterType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ParameterType FindValue(string value)
        {
            return FindValue<ParameterType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ParameterType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductionVariantAcceleratorType.
    /// </summary>
    public class ProductionVariantAcceleratorType : ConstantClass
    {

        /// <summary>
        /// Constant MlEia1Large for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia1Large = new ProductionVariantAcceleratorType("ml.eia1.large");
        /// <summary>
        /// Constant MlEia1Medium for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia1Medium = new ProductionVariantAcceleratorType("ml.eia1.medium");
        /// <summary>
        /// Constant MlEia1Xlarge for ProductionVariantAcceleratorType
        /// </summary>
        public static readonly ProductionVariantAcceleratorType MlEia1Xlarge = new ProductionVariantAcceleratorType("ml.eia1.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductionVariantAcceleratorType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductionVariantAcceleratorType FindValue(string value)
        {
            return FindValue<ProductionVariantAcceleratorType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductionVariantAcceleratorType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ProductionVariantInstanceType.
    /// </summary>
    public class ProductionVariantInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC42xlarge = new ProductionVariantInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC44xlarge = new ProductionVariantInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC48xlarge = new ProductionVariantInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC4Large = new ProductionVariantInstanceType("ml.c4.large");
        /// <summary>
        /// Constant MlC4Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC4Xlarge = new ProductionVariantInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC518xlarge = new ProductionVariantInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC52xlarge = new ProductionVariantInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC54xlarge = new ProductionVariantInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC59xlarge = new ProductionVariantInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5Large = new ProductionVariantInstanceType("ml.c5.large");
        /// <summary>
        /// Constant MlC5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlC5Xlarge = new ProductionVariantInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlG4dn12xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn12xlarge = new ProductionVariantInstanceType("ml.g4dn.12xlarge");
        /// <summary>
        /// Constant MlG4dn16xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn16xlarge = new ProductionVariantInstanceType("ml.g4dn.16xlarge");
        /// <summary>
        /// Constant MlG4dn2xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn2xlarge = new ProductionVariantInstanceType("ml.g4dn.2xlarge");
        /// <summary>
        /// Constant MlG4dn4xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn4xlarge = new ProductionVariantInstanceType("ml.g4dn.4xlarge");
        /// <summary>
        /// Constant MlG4dn8xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dn8xlarge = new ProductionVariantInstanceType("ml.g4dn.8xlarge");
        /// <summary>
        /// Constant MlG4dnXlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlG4dnXlarge = new ProductionVariantInstanceType("ml.g4dn.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM410xlarge = new ProductionVariantInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM416xlarge = new ProductionVariantInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM42xlarge = new ProductionVariantInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM44xlarge = new ProductionVariantInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM4Xlarge = new ProductionVariantInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM512xlarge = new ProductionVariantInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM524xlarge = new ProductionVariantInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM52xlarge = new ProductionVariantInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM54xlarge = new ProductionVariantInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5Large = new ProductionVariantInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlM5Xlarge = new ProductionVariantInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP216xlarge = new ProductionVariantInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP28xlarge = new ProductionVariantInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP2Xlarge = new ProductionVariantInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP316xlarge = new ProductionVariantInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP32xlarge = new ProductionVariantInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlP38xlarge = new ProductionVariantInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlR512xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR512xlarge = new ProductionVariantInstanceType("ml.r5.12xlarge");
        /// <summary>
        /// Constant MlR524xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR524xlarge = new ProductionVariantInstanceType("ml.r5.24xlarge");
        /// <summary>
        /// Constant MlR52xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR52xlarge = new ProductionVariantInstanceType("ml.r5.2xlarge");
        /// <summary>
        /// Constant MlR54xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR54xlarge = new ProductionVariantInstanceType("ml.r5.4xlarge");
        /// <summary>
        /// Constant MlR5Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5Large = new ProductionVariantInstanceType("ml.r5.large");
        /// <summary>
        /// Constant MlR5Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlR5Xlarge = new ProductionVariantInstanceType("ml.r5.xlarge");
        /// <summary>
        /// Constant MlT22xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT22xlarge = new ProductionVariantInstanceType("ml.t2.2xlarge");
        /// <summary>
        /// Constant MlT2Large for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Large = new ProductionVariantInstanceType("ml.t2.large");
        /// <summary>
        /// Constant MlT2Medium for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Medium = new ProductionVariantInstanceType("ml.t2.medium");
        /// <summary>
        /// Constant MlT2Xlarge for ProductionVariantInstanceType
        /// </summary>
        public static readonly ProductionVariantInstanceType MlT2Xlarge = new ProductionVariantInstanceType("ml.t2.xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ProductionVariantInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ProductionVariantInstanceType FindValue(string value)
        {
            return FindValue<ProductionVariantInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ProductionVariantInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RecordWrapper.
    /// </summary>
    public class RecordWrapper : ConstantClass
    {

        /// <summary>
        /// Constant None for RecordWrapper
        /// </summary>
        public static readonly RecordWrapper None = new RecordWrapper("None");
        /// <summary>
        /// Constant RecordIO for RecordWrapper
        /// </summary>
        public static readonly RecordWrapper RecordIO = new RecordWrapper("RecordIO");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RecordWrapper(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RecordWrapper FindValue(string value)
        {
            return FindValue<RecordWrapper>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RecordWrapper(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ResourceType.
    /// </summary>
    public class ResourceType : ConstantClass
    {

        /// <summary>
        /// Constant TrainingJob for ResourceType
        /// </summary>
        public static readonly ResourceType TrainingJob = new ResourceType("TrainingJob");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ResourceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ResourceType FindValue(string value)
        {
            return FindValue<ResourceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ResourceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RootAccess.
    /// </summary>
    public class RootAccess : ConstantClass
    {

        /// <summary>
        /// Constant Disabled for RootAccess
        /// </summary>
        public static readonly RootAccess Disabled = new RootAccess("Disabled");
        /// <summary>
        /// Constant Enabled for RootAccess
        /// </summary>
        public static readonly RootAccess Enabled = new RootAccess("Enabled");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RootAccess(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RootAccess FindValue(string value)
        {
            return FindValue<RootAccess>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RootAccess(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataDistribution.
    /// </summary>
    public class S3DataDistribution : ConstantClass
    {

        /// <summary>
        /// Constant FullyReplicated for S3DataDistribution
        /// </summary>
        public static readonly S3DataDistribution FullyReplicated = new S3DataDistribution("FullyReplicated");
        /// <summary>
        /// Constant ShardedByS3Key for S3DataDistribution
        /// </summary>
        public static readonly S3DataDistribution ShardedByS3Key = new S3DataDistribution("ShardedByS3Key");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataDistribution(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataDistribution FindValue(string value)
        {
            return FindValue<S3DataDistribution>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataDistribution(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type S3DataType.
    /// </summary>
    public class S3DataType : ConstantClass
    {

        /// <summary>
        /// Constant AugmentedManifestFile for S3DataType
        /// </summary>
        public static readonly S3DataType AugmentedManifestFile = new S3DataType("AugmentedManifestFile");
        /// <summary>
        /// Constant ManifestFile for S3DataType
        /// </summary>
        public static readonly S3DataType ManifestFile = new S3DataType("ManifestFile");
        /// <summary>
        /// Constant S3Prefix for S3DataType
        /// </summary>
        public static readonly S3DataType S3Prefix = new S3DataType("S3Prefix");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public S3DataType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static S3DataType FindValue(string value)
        {
            return FindValue<S3DataType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator S3DataType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SearchSortOrder.
    /// </summary>
    public class SearchSortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SearchSortOrder
        /// </summary>
        public static readonly SearchSortOrder Ascending = new SearchSortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SearchSortOrder
        /// </summary>
        public static readonly SearchSortOrder Descending = new SearchSortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SearchSortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SearchSortOrder FindValue(string value)
        {
            return FindValue<SearchSortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SearchSortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SecondaryStatus.
    /// </summary>
    public class SecondaryStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Completed = new SecondaryStatus("Completed");
        /// <summary>
        /// Constant Downloading for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Downloading = new SecondaryStatus("Downloading");
        /// <summary>
        /// Constant DownloadingTrainingImage for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus DownloadingTrainingImage = new SecondaryStatus("DownloadingTrainingImage");
        /// <summary>
        /// Constant Failed for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Failed = new SecondaryStatus("Failed");
        /// <summary>
        /// Constant Interrupted for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Interrupted = new SecondaryStatus("Interrupted");
        /// <summary>
        /// Constant LaunchingMLInstances for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus LaunchingMLInstances = new SecondaryStatus("LaunchingMLInstances");
        /// <summary>
        /// Constant MaxRuntimeExceeded for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus MaxRuntimeExceeded = new SecondaryStatus("MaxRuntimeExceeded");
        /// <summary>
        /// Constant MaxWaitTimeExceeded for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus MaxWaitTimeExceeded = new SecondaryStatus("MaxWaitTimeExceeded");
        /// <summary>
        /// Constant PreparingTrainingStack for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus PreparingTrainingStack = new SecondaryStatus("PreparingTrainingStack");
        /// <summary>
        /// Constant Starting for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Starting = new SecondaryStatus("Starting");
        /// <summary>
        /// Constant Stopped for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Stopped = new SecondaryStatus("Stopped");
        /// <summary>
        /// Constant Stopping for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Stopping = new SecondaryStatus("Stopping");
        /// <summary>
        /// Constant Training for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Training = new SecondaryStatus("Training");
        /// <summary>
        /// Constant Uploading for SecondaryStatus
        /// </summary>
        public static readonly SecondaryStatus Uploading = new SecondaryStatus("Uploading");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SecondaryStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SecondaryStatus FindValue(string value)
        {
            return FindValue<SecondaryStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SecondaryStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortBy.
    /// </summary>
    public class SortBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortBy
        /// </summary>
        public static readonly SortBy CreationTime = new SortBy("CreationTime");
        /// <summary>
        /// Constant Name for SortBy
        /// </summary>
        public static readonly SortBy Name = new SortBy("Name");
        /// <summary>
        /// Constant Status for SortBy
        /// </summary>
        public static readonly SortBy Status = new SortBy("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortBy FindValue(string value)
        {
            return FindValue<SortBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SplitType.
    /// </summary>
    public class SplitType : ConstantClass
    {

        /// <summary>
        /// Constant Line for SplitType
        /// </summary>
        public static readonly SplitType Line = new SplitType("Line");
        /// <summary>
        /// Constant None for SplitType
        /// </summary>
        public static readonly SplitType None = new SplitType("None");
        /// <summary>
        /// Constant RecordIO for SplitType
        /// </summary>
        public static readonly SplitType RecordIO = new SplitType("RecordIO");
        /// <summary>
        /// Constant TFRecord for SplitType
        /// </summary>
        public static readonly SplitType TFRecord = new SplitType("TFRecord");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SplitType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SplitType FindValue(string value)
        {
            return FindValue<SplitType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SplitType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TargetDevice.
    /// </summary>
    public class TargetDevice : ConstantClass
    {

        /// <summary>
        /// Constant Aisage for TargetDevice
        /// </summary>
        public static readonly TargetDevice Aisage = new TargetDevice("aisage");
        /// <summary>
        /// Constant Deeplens for TargetDevice
        /// </summary>
        public static readonly TargetDevice Deeplens = new TargetDevice("deeplens");
        /// <summary>
        /// Constant Jetson_nano for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_nano = new TargetDevice("jetson_nano");
        /// <summary>
        /// Constant Jetson_tx1 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_tx1 = new TargetDevice("jetson_tx1");
        /// <summary>
        /// Constant Jetson_tx2 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Jetson_tx2 = new TargetDevice("jetson_tx2");
        /// <summary>
        /// Constant Lambda for TargetDevice
        /// </summary>
        public static readonly TargetDevice Lambda = new TargetDevice("lambda");
        /// <summary>
        /// Constant Ml_c4 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_c4 = new TargetDevice("ml_c4");
        /// <summary>
        /// Constant Ml_c5 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_c5 = new TargetDevice("ml_c5");
        /// <summary>
        /// Constant Ml_m4 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_m4 = new TargetDevice("ml_m4");
        /// <summary>
        /// Constant Ml_m5 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_m5 = new TargetDevice("ml_m5");
        /// <summary>
        /// Constant Ml_p2 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_p2 = new TargetDevice("ml_p2");
        /// <summary>
        /// Constant Ml_p3 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Ml_p3 = new TargetDevice("ml_p3");
        /// <summary>
        /// Constant Qcs603 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Qcs603 = new TargetDevice("qcs603");
        /// <summary>
        /// Constant Qcs605 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Qcs605 = new TargetDevice("qcs605");
        /// <summary>
        /// Constant Rasp3b for TargetDevice
        /// </summary>
        public static readonly TargetDevice Rasp3b = new TargetDevice("rasp3b");
        /// <summary>
        /// Constant Rk3288 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Rk3288 = new TargetDevice("rk3288");
        /// <summary>
        /// Constant Rk3399 for TargetDevice
        /// </summary>
        public static readonly TargetDevice Rk3399 = new TargetDevice("rk3399");
        /// <summary>
        /// Constant Sbe_c for TargetDevice
        /// </summary>
        public static readonly TargetDevice Sbe_c = new TargetDevice("sbe_c");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TargetDevice(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TargetDevice FindValue(string value)
        {
            return FindValue<TargetDevice>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TargetDevice(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingInputMode.
    /// </summary>
    public class TrainingInputMode : ConstantClass
    {

        /// <summary>
        /// Constant File for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode File = new TrainingInputMode("File");
        /// <summary>
        /// Constant Pipe for TrainingInputMode
        /// </summary>
        public static readonly TrainingInputMode Pipe = new TrainingInputMode("Pipe");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingInputMode(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingInputMode FindValue(string value)
        {
            return FindValue<TrainingInputMode>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingInputMode(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingInstanceType.
    /// </summary>
    public class TrainingInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC42xlarge = new TrainingInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC44xlarge = new TrainingInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC48xlarge = new TrainingInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC4Xlarge = new TrainingInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC518xlarge = new TrainingInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC52xlarge = new TrainingInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC54xlarge = new TrainingInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC59xlarge = new TrainingInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlC5Xlarge = new TrainingInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM410xlarge = new TrainingInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM416xlarge = new TrainingInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM42xlarge = new TrainingInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM44xlarge = new TrainingInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM4Xlarge = new TrainingInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM512xlarge = new TrainingInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM524xlarge = new TrainingInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM52xlarge = new TrainingInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM54xlarge = new TrainingInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM5Large = new TrainingInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlM5Xlarge = new TrainingInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP216xlarge = new TrainingInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP28xlarge = new TrainingInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP2Xlarge = new TrainingInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP316xlarge = new TrainingInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP32xlarge = new TrainingInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP38xlarge = new TrainingInstanceType("ml.p3.8xlarge");
        /// <summary>
        /// Constant MlP3dn24xlarge for TrainingInstanceType
        /// </summary>
        public static readonly TrainingInstanceType MlP3dn24xlarge = new TrainingInstanceType("ml.p3dn.24xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingInstanceType FindValue(string value)
        {
            return FindValue<TrainingInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobEarlyStoppingType.
    /// </summary>
    public class TrainingJobEarlyStoppingType : ConstantClass
    {

        /// <summary>
        /// Constant Auto for TrainingJobEarlyStoppingType
        /// </summary>
        public static readonly TrainingJobEarlyStoppingType Auto = new TrainingJobEarlyStoppingType("Auto");
        /// <summary>
        /// Constant Off for TrainingJobEarlyStoppingType
        /// </summary>
        public static readonly TrainingJobEarlyStoppingType Off = new TrainingJobEarlyStoppingType("Off");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobEarlyStoppingType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobEarlyStoppingType FindValue(string value)
        {
            return FindValue<TrainingJobEarlyStoppingType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobEarlyStoppingType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobSortByOptions.
    /// </summary>
    public class TrainingJobSortByOptions : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions CreationTime = new TrainingJobSortByOptions("CreationTime");
        /// <summary>
        /// Constant FinalObjectiveMetricValue for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions FinalObjectiveMetricValue = new TrainingJobSortByOptions("FinalObjectiveMetricValue");
        /// <summary>
        /// Constant Name for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions Name = new TrainingJobSortByOptions("Name");
        /// <summary>
        /// Constant Status for TrainingJobSortByOptions
        /// </summary>
        public static readonly TrainingJobSortByOptions Status = new TrainingJobSortByOptions("Status");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobSortByOptions(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobSortByOptions FindValue(string value)
        {
            return FindValue<TrainingJobSortByOptions>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobSortByOptions(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TrainingJobStatus.
    /// </summary>
    public class TrainingJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Completed = new TrainingJobStatus("Completed");
        /// <summary>
        /// Constant Failed for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Failed = new TrainingJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus InProgress = new TrainingJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Stopped = new TrainingJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TrainingJobStatus
        /// </summary>
        public static readonly TrainingJobStatus Stopping = new TrainingJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TrainingJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TrainingJobStatus FindValue(string value)
        {
            return FindValue<TrainingJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TrainingJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformInstanceType.
    /// </summary>
    public class TransformInstanceType : ConstantClass
    {

        /// <summary>
        /// Constant MlC42xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC42xlarge = new TransformInstanceType("ml.c4.2xlarge");
        /// <summary>
        /// Constant MlC44xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC44xlarge = new TransformInstanceType("ml.c4.4xlarge");
        /// <summary>
        /// Constant MlC48xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC48xlarge = new TransformInstanceType("ml.c4.8xlarge");
        /// <summary>
        /// Constant MlC4Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC4Xlarge = new TransformInstanceType("ml.c4.xlarge");
        /// <summary>
        /// Constant MlC518xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC518xlarge = new TransformInstanceType("ml.c5.18xlarge");
        /// <summary>
        /// Constant MlC52xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC52xlarge = new TransformInstanceType("ml.c5.2xlarge");
        /// <summary>
        /// Constant MlC54xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC54xlarge = new TransformInstanceType("ml.c5.4xlarge");
        /// <summary>
        /// Constant MlC59xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC59xlarge = new TransformInstanceType("ml.c5.9xlarge");
        /// <summary>
        /// Constant MlC5Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlC5Xlarge = new TransformInstanceType("ml.c5.xlarge");
        /// <summary>
        /// Constant MlM410xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM410xlarge = new TransformInstanceType("ml.m4.10xlarge");
        /// <summary>
        /// Constant MlM416xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM416xlarge = new TransformInstanceType("ml.m4.16xlarge");
        /// <summary>
        /// Constant MlM42xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM42xlarge = new TransformInstanceType("ml.m4.2xlarge");
        /// <summary>
        /// Constant MlM44xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM44xlarge = new TransformInstanceType("ml.m4.4xlarge");
        /// <summary>
        /// Constant MlM4Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM4Xlarge = new TransformInstanceType("ml.m4.xlarge");
        /// <summary>
        /// Constant MlM512xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM512xlarge = new TransformInstanceType("ml.m5.12xlarge");
        /// <summary>
        /// Constant MlM524xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM524xlarge = new TransformInstanceType("ml.m5.24xlarge");
        /// <summary>
        /// Constant MlM52xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM52xlarge = new TransformInstanceType("ml.m5.2xlarge");
        /// <summary>
        /// Constant MlM54xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM54xlarge = new TransformInstanceType("ml.m5.4xlarge");
        /// <summary>
        /// Constant MlM5Large for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM5Large = new TransformInstanceType("ml.m5.large");
        /// <summary>
        /// Constant MlM5Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlM5Xlarge = new TransformInstanceType("ml.m5.xlarge");
        /// <summary>
        /// Constant MlP216xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP216xlarge = new TransformInstanceType("ml.p2.16xlarge");
        /// <summary>
        /// Constant MlP28xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP28xlarge = new TransformInstanceType("ml.p2.8xlarge");
        /// <summary>
        /// Constant MlP2Xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP2Xlarge = new TransformInstanceType("ml.p2.xlarge");
        /// <summary>
        /// Constant MlP316xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP316xlarge = new TransformInstanceType("ml.p3.16xlarge");
        /// <summary>
        /// Constant MlP32xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP32xlarge = new TransformInstanceType("ml.p3.2xlarge");
        /// <summary>
        /// Constant MlP38xlarge for TransformInstanceType
        /// </summary>
        public static readonly TransformInstanceType MlP38xlarge = new TransformInstanceType("ml.p3.8xlarge");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformInstanceType(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformInstanceType FindValue(string value)
        {
            return FindValue<TransformInstanceType>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformInstanceType(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type TransformJobStatus.
    /// </summary>
    public class TransformJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Completed = new TransformJobStatus("Completed");
        /// <summary>
        /// Constant Failed for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Failed = new TransformJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus InProgress = new TransformJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Stopped = new TransformJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for TransformJobStatus
        /// </summary>
        public static readonly TransformJobStatus Stopping = new TransformJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public TransformJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static TransformJobStatus FindValue(string value)
        {
            return FindValue<TransformJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator TransformJobStatus(string value)
        {
            return FindValue(value);
        }
    }

}