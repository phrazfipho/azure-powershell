// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Extensions;

    /// <summary>Set tempDb storage settings for SQL Server.</summary>
    public partial class SqlTempDbSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettings,
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Models.Api20220801Preview.ISqlTempDbSettingsInternal
    {

        /// <summary>Backing field for <see cref="DataFileCount" /> property.</summary>
        private int? _dataFileCount;

        /// <summary>SQL Server tempdb data file count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? DataFileCount { get => this._dataFileCount; set => this._dataFileCount = value; }

        /// <summary>Backing field for <see cref="DataFileSize" /> property.</summary>
        private int? _dataFileSize;

        /// <summary>SQL Server tempdb data file size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? DataFileSize { get => this._dataFileSize; set => this._dataFileSize = value; }

        /// <summary>Backing field for <see cref="DataGrowth" /> property.</summary>
        private int? _dataGrowth;

        /// <summary>SQL Server tempdb data file autoGrowth size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? DataGrowth { get => this._dataGrowth; set => this._dataGrowth = value; }

        /// <summary>Backing field for <see cref="DefaultFilePath" /> property.</summary>
        private string _defaultFilePath;

        /// <summary>SQL Server default file path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string DefaultFilePath { get => this._defaultFilePath; set => this._defaultFilePath = value; }

        /// <summary>Backing field for <see cref="LogFileSize" /> property.</summary>
        private int? _logFileSize;

        /// <summary>SQL Server tempdb log file size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? LogFileSize { get => this._logFileSize; set => this._logFileSize = value; }

        /// <summary>Backing field for <see cref="LogGrowth" /> property.</summary>
        private int? _logGrowth;

        /// <summary>SQL Server tempdb log file autoGrowth size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int? LogGrowth { get => this._logGrowth; set => this._logGrowth = value; }

        /// <summary>Backing field for <see cref="Lun" /> property.</summary>
        private int[] _lun;

        /// <summary>Logical Unit Numbers for the disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public int[] Lun { get => this._lun; set => this._lun = value; }

        /// <summary>Backing field for <see cref="PersistFolder" /> property.</summary>
        private bool? _persistFolder;

        /// <summary>SQL Server tempdb persist folder choice</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public bool? PersistFolder { get => this._persistFolder; set => this._persistFolder = value; }

        /// <summary>Backing field for <see cref="PersistFolderPath" /> property.</summary>
        private string _persistFolderPath;

        /// <summary>SQL Server tempdb persist folder location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Origin(Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.PropertyOrigin.Owned)]
        public string PersistFolderPath { get => this._persistFolderPath; set => this._persistFolderPath = value; }

        /// <summary>Creates an new <see cref="SqlTempDbSettings" /> instance.</summary>
        public SqlTempDbSettings()
        {

        }
    }
    /// Set tempDb storage settings for SQL Server.
    public partial interface ISqlTempDbSettings :
        Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.IJsonSerializable
    {
        /// <summary>SQL Server tempdb data file count</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb data file count",
        SerializedName = @"dataFileCount",
        PossibleTypes = new [] { typeof(int) })]
        int? DataFileCount { get; set; }
        /// <summary>SQL Server tempdb data file size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb data file size",
        SerializedName = @"dataFileSize",
        PossibleTypes = new [] { typeof(int) })]
        int? DataFileSize { get; set; }
        /// <summary>SQL Server tempdb data file autoGrowth size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb data file autoGrowth size",
        SerializedName = @"dataGrowth",
        PossibleTypes = new [] { typeof(int) })]
        int? DataGrowth { get; set; }
        /// <summary>SQL Server default file path</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server default file path",
        SerializedName = @"defaultFilePath",
        PossibleTypes = new [] { typeof(string) })]
        string DefaultFilePath { get; set; }
        /// <summary>SQL Server tempdb log file size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb log file size",
        SerializedName = @"logFileSize",
        PossibleTypes = new [] { typeof(int) })]
        int? LogFileSize { get; set; }
        /// <summary>SQL Server tempdb log file autoGrowth size</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb log file autoGrowth size",
        SerializedName = @"logGrowth",
        PossibleTypes = new [] { typeof(int) })]
        int? LogGrowth { get; set; }
        /// <summary>Logical Unit Numbers for the disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Logical Unit Numbers for the disks.",
        SerializedName = @"luns",
        PossibleTypes = new [] { typeof(int) })]
        int[] Lun { get; set; }
        /// <summary>SQL Server tempdb persist folder choice</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb persist folder choice",
        SerializedName = @"persistFolder",
        PossibleTypes = new [] { typeof(bool) })]
        bool? PersistFolder { get; set; }
        /// <summary>SQL Server tempdb persist folder location</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.SqlVirtualMachine.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"SQL Server tempdb persist folder location",
        SerializedName = @"persistFolderPath",
        PossibleTypes = new [] { typeof(string) })]
        string PersistFolderPath { get; set; }

    }
    /// Set tempDb storage settings for SQL Server.
    internal partial interface ISqlTempDbSettingsInternal

    {
        /// <summary>SQL Server tempdb data file count</summary>
        int? DataFileCount { get; set; }
        /// <summary>SQL Server tempdb data file size</summary>
        int? DataFileSize { get; set; }
        /// <summary>SQL Server tempdb data file autoGrowth size</summary>
        int? DataGrowth { get; set; }
        /// <summary>SQL Server default file path</summary>
        string DefaultFilePath { get; set; }
        /// <summary>SQL Server tempdb log file size</summary>
        int? LogFileSize { get; set; }
        /// <summary>SQL Server tempdb log file autoGrowth size</summary>
        int? LogGrowth { get; set; }
        /// <summary>Logical Unit Numbers for the disks.</summary>
        int[] Lun { get; set; }
        /// <summary>SQL Server tempdb persist folder choice</summary>
        bool? PersistFolder { get; set; }
        /// <summary>SQL Server tempdb persist folder location</summary>
        string PersistFolderPath { get; set; }

    }
}