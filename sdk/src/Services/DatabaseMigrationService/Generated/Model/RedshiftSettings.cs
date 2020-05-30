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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Provides information that defines an Amazon Redshift endpoint.
    /// </summary>
    public partial class RedshiftSettings
    {
        private bool? _acceptAnyDate;
        private string _afterConnectScript;
        private string _bucketFolder;
        private string _bucketName;
        private int? _connectionTimeout;
        private string _databaseName;
        private string _dateFormat;
        private bool? _emptyAsNull;
        private EncryptionModeValue _encryptionMode;
        private int? _fileTransferUploadStreams;
        private int? _loadTimeout;
        private int? _maxFileSize;
        private string _password;
        private int? _port;
        private bool? _removeQuotes;
        private string _replaceChars;
        private string _replaceInvalidChars;
        private string _serverName;
        private string _serverSideEncryptionKmsKeyId;
        private string _serviceAccessRoleArn;
        private string _timeFormat;
        private bool? _trimBlanks;
        private bool? _truncateColumns;
        private string _username;
        private int? _writeBufferSize;

        /// <summary>
        /// Gets and sets the property AcceptAnyDate. 
        /// <para>
        /// A value that indicates to allow any date format, including invalid formats such as
        /// 00/00/00 00:00:00, to be loaded without generating an error. You can choose <code>true</code>
        /// or <code>false</code> (the default).
        /// </para>
        ///  
        /// <para>
        /// This parameter applies only to TIMESTAMP and DATE columns. Always use ACCEPTANYDATE
        /// with the DATEFORMAT parameter. If the date format for the data doesn't match the DATEFORMAT
        /// specification, Amazon Redshift inserts a NULL value into that field. 
        /// </para>
        /// </summary>
        public bool AcceptAnyDate
        {
            get { return this._acceptAnyDate.GetValueOrDefault(); }
            set { this._acceptAnyDate = value; }
        }

        // Check to see if AcceptAnyDate property is set
        internal bool IsSetAcceptAnyDate()
        {
            return this._acceptAnyDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AfterConnectScript. 
        /// <para>
        /// Code to run after connecting. This parameter should contain the code itself, not the
        /// name of a file containing the code.
        /// </para>
        /// </summary>
        public string AfterConnectScript
        {
            get { return this._afterConnectScript; }
            set { this._afterConnectScript = value; }
        }

        // Check to see if AfterConnectScript property is set
        internal bool IsSetAfterConnectScript()
        {
            return this._afterConnectScript != null;
        }

        /// <summary>
        /// Gets and sets the property BucketFolder. 
        /// <para>
        /// The location where the comma-separated value (.csv) files are stored before being
        /// uploaded to the S3 bucket. 
        /// </para>
        /// </summary>
        public string BucketFolder
        {
            get { return this._bucketFolder; }
            set { this._bucketFolder = value; }
        }

        // Check to see if BucketFolder property is set
        internal bool IsSetBucketFolder()
        {
            return this._bucketFolder != null;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the S3 bucket you want to use
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectionTimeout. 
        /// <para>
        /// A value that sets the amount of time to wait (in milliseconds) before timing out,
        /// beginning from when you initially establish a connection.
        /// </para>
        /// </summary>
        public int ConnectionTimeout
        {
            get { return this._connectionTimeout.GetValueOrDefault(); }
            set { this._connectionTimeout = value; }
        }

        // Check to see if ConnectionTimeout property is set
        internal bool IsSetConnectionTimeout()
        {
            return this._connectionTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the Amazon Redshift data warehouse (service) that you are working with.
        /// </para>
        /// </summary>
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property DateFormat. 
        /// <para>
        /// The date format that you are using. Valid values are <code>auto</code> (case-sensitive),
        /// your date format string enclosed in quotes, or NULL. If this parameter is left unset
        /// (NULL), it defaults to a format of 'YYYY-MM-DD'. Using <code>auto</code> recognizes
        /// most strings, even some that aren't supported when you use a date format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this to <code>auto</code>.
        /// 
        /// </para>
        /// </summary>
        public string DateFormat
        {
            get { return this._dateFormat; }
            set { this._dateFormat = value; }
        }

        // Check to see if DateFormat property is set
        internal bool IsSetDateFormat()
        {
            return this._dateFormat != null;
        }

        /// <summary>
        /// Gets and sets the property EmptyAsNull. 
        /// <para>
        /// A value that specifies whether AWS DMS should migrate empty CHAR and VARCHAR fields
        /// as NULL. A value of <code>true</code> sets empty CHAR and VARCHAR fields to null.
        /// The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool EmptyAsNull
        {
            get { return this._emptyAsNull.GetValueOrDefault(); }
            set { this._emptyAsNull = value; }
        }

        // Check to see if EmptyAsNull property is set
        internal bool IsSetEmptyAsNull()
        {
            return this._emptyAsNull.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionMode. 
        /// <para>
        /// The type of server-side encryption that you want to use for your data. This encryption
        /// type is part of the endpoint settings or the extra connections attributes for Amazon
        /// S3. You can choose either <code>SSE_S3</code> (the default) or <code>SSE_KMS</code>.
        /// To use <code>SSE_S3</code>, create an AWS Identity and Access Management (IAM) role
        /// with a policy that allows <code>"arn:aws:s3:::*"</code> to use the following actions:
        /// <code>"s3:PutObject", "s3:ListBucket"</code> 
        /// </para>
        /// </summary>
        public EncryptionModeValue EncryptionMode
        {
            get { return this._encryptionMode; }
            set { this._encryptionMode = value; }
        }

        // Check to see if EncryptionMode property is set
        internal bool IsSetEncryptionMode()
        {
            return this._encryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property FileTransferUploadStreams. 
        /// <para>
        /// The number of threads used to upload a single file. This parameter accepts a value
        /// from 1 through 64. It defaults to 10.
        /// </para>
        /// </summary>
        public int FileTransferUploadStreams
        {
            get { return this._fileTransferUploadStreams.GetValueOrDefault(); }
            set { this._fileTransferUploadStreams = value; }
        }

        // Check to see if FileTransferUploadStreams property is set
        internal bool IsSetFileTransferUploadStreams()
        {
            return this._fileTransferUploadStreams.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LoadTimeout. 
        /// <para>
        /// The amount of time to wait (in milliseconds) before timing out, beginning from when
        /// you begin loading.
        /// </para>
        /// </summary>
        public int LoadTimeout
        {
            get { return this._loadTimeout.GetValueOrDefault(); }
            set { this._loadTimeout = value; }
        }

        // Check to see if LoadTimeout property is set
        internal bool IsSetLoadTimeout()
        {
            return this._loadTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxFileSize. 
        /// <para>
        /// The maximum size (in KB) of any .csv file used to transfer data to Amazon Redshift.
        /// This accepts a value from 1 through 1,048,576. It defaults to 32,768 KB (32 MB).
        /// </para>
        /// </summary>
        public int MaxFileSize
        {
            get { return this._maxFileSize.GetValueOrDefault(); }
            set { this._maxFileSize = value; }
        }

        // Check to see if MaxFileSize property is set
        internal bool IsSetMaxFileSize()
        {
            return this._maxFileSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Password. 
        /// <para>
        /// The password for the user named in the <code>username</code> property.
        /// </para>
        /// </summary>
        public string Password
        {
            get { return this._password; }
            set { this._password = value; }
        }

        // Check to see if Password property is set
        internal bool IsSetPassword()
        {
            return this._password != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number for Amazon Redshift. The default value is 5439.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemoveQuotes. 
        /// <para>
        /// A value that specifies to remove surrounding quotation marks from strings in the incoming
        /// data. All characters within the quotation marks, including delimiters, are retained.
        /// Choose <code>true</code> to remove quotation marks. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool RemoveQuotes
        {
            get { return this._removeQuotes.GetValueOrDefault(); }
            set { this._removeQuotes = value; }
        }

        // Check to see if RemoveQuotes property is set
        internal bool IsSetRemoveQuotes()
        {
            return this._removeQuotes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplaceChars. 
        /// <para>
        /// A value that specifies to replaces the invalid characters specified in <code>ReplaceInvalidChars</code>,
        /// substituting the specified characters instead. The default is <code>"?"</code>.
        /// </para>
        /// </summary>
        public string ReplaceChars
        {
            get { return this._replaceChars; }
            set { this._replaceChars = value; }
        }

        // Check to see if ReplaceChars property is set
        internal bool IsSetReplaceChars()
        {
            return this._replaceChars != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceInvalidChars. 
        /// <para>
        /// A list of characters that you want to replace. Use with <code>ReplaceChars</code>.
        /// </para>
        /// </summary>
        public string ReplaceInvalidChars
        {
            get { return this._replaceInvalidChars; }
            set { this._replaceInvalidChars = value; }
        }

        // Check to see if ReplaceInvalidChars property is set
        internal bool IsSetReplaceInvalidChars()
        {
            return this._replaceInvalidChars != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of the Amazon Redshift cluster you are using.
        /// </para>
        /// </summary>
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKmsKeyId. 
        /// <para>
        /// The AWS KMS key ID. If you are using <code>SSE_KMS</code> for the <code>EncryptionMode</code>,
        /// provide this key ID. The key that you use needs an attached policy that enables IAM
        /// user permissions and allows use of the key.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKmsKeyId
        {
            get { return this._serverSideEncryptionKmsKeyId; }
            set { this._serverSideEncryptionKmsKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKmsKeyId property is set
        internal bool IsSetServerSideEncryptionKmsKeyId()
        {
            return this._serverSideEncryptionKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceAccessRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that has access to the Amazon Redshift
        /// service.
        /// </para>
        /// </summary>
        public string ServiceAccessRoleArn
        {
            get { return this._serviceAccessRoleArn; }
            set { this._serviceAccessRoleArn = value; }
        }

        // Check to see if ServiceAccessRoleArn property is set
        internal bool IsSetServiceAccessRoleArn()
        {
            return this._serviceAccessRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TimeFormat. 
        /// <para>
        /// The time format that you want to use. Valid values are <code>auto</code> (case-sensitive),
        /// <code>'timeformat_string'</code>, <code>'epochsecs'</code>, or <code>'epochmillisecs'</code>.
        /// It defaults to 10. Using <code>auto</code> recognizes most strings, even some that
        /// aren't supported when you use a time format string. 
        /// </para>
        ///  
        /// <para>
        /// If your date and time values use formats different from each other, set this parameter
        /// to <code>auto</code>. 
        /// </para>
        /// </summary>
        public string TimeFormat
        {
            get { return this._timeFormat; }
            set { this._timeFormat = value; }
        }

        // Check to see if TimeFormat property is set
        internal bool IsSetTimeFormat()
        {
            return this._timeFormat != null;
        }

        /// <summary>
        /// Gets and sets the property TrimBlanks. 
        /// <para>
        /// A value that specifies to remove the trailing white space characters from a VARCHAR
        /// string. This parameter applies only to columns with a VARCHAR data type. Choose <code>true</code>
        /// to remove unneeded white space. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool TrimBlanks
        {
            get { return this._trimBlanks.GetValueOrDefault(); }
            set { this._trimBlanks = value; }
        }

        // Check to see if TrimBlanks property is set
        internal bool IsSetTrimBlanks()
        {
            return this._trimBlanks.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TruncateColumns. 
        /// <para>
        /// A value that specifies to truncate data in columns to the appropriate number of characters,
        /// so that the data fits in the column. This parameter applies only to columns with a
        /// VARCHAR or CHAR data type, and rows with a size of 4 MB or less. Choose <code>true</code>
        /// to truncate data. The default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool TruncateColumns
        {
            get { return this._truncateColumns.GetValueOrDefault(); }
            set { this._truncateColumns = value; }
        }

        // Check to see if TruncateColumns property is set
        internal bool IsSetTruncateColumns()
        {
            return this._truncateColumns.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Username. 
        /// <para>
        /// An Amazon Redshift user name for a registered user.
        /// </para>
        /// </summary>
        public string Username
        {
            get { return this._username; }
            set { this._username = value; }
        }

        // Check to see if Username property is set
        internal bool IsSetUsername()
        {
            return this._username != null;
        }

        /// <summary>
        /// Gets and sets the property WriteBufferSize. 
        /// <para>
        /// The size of the write buffer to use in rows. Valid values range from 1 through 2,048.
        /// The default is 1,024. Use this setting to tune performance. 
        /// </para>
        /// </summary>
        public int WriteBufferSize
        {
            get { return this._writeBufferSize.GetValueOrDefault(); }
            set { this._writeBufferSize = value; }
        }

        // Check to see if WriteBufferSize property is set
        internal bool IsSetWriteBufferSize()
        {
            return this._writeBufferSize.HasValue; 
        }

    }
}