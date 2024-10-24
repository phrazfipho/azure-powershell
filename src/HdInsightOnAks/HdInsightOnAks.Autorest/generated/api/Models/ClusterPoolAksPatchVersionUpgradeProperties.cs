// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Extensions;

    /// <summary>Properties of upgrading cluster pool's AKS patch version.</summary>
    public partial class ClusterPoolAksPatchVersionUpgradeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolAksPatchVersionUpgradeProperties,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolAksPatchVersionUpgradePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolUpgradeProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolUpgradeProperties __clusterPoolUpgradeProperties = new Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.ClusterPoolUpgradeProperties();

        /// <summary>Backing field for <see cref="TargetAksVersion" /> property.</summary>
        private string _targetAksVersion;

        /// <summary>
        /// Target AKS version. When it's not set, latest version will be used. When upgradeClusterPool is true and upgradeAllClusterNodes
        /// is false, target version should be greater or equal to current version. When upgradeClusterPool is false and upgradeAllClusterNodes
        /// is true, target version should be equal to AKS version of cluster pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public string TargetAksVersion { get => this._targetAksVersion; set => this._targetAksVersion = value; }

        /// <summary>Backing field for <see cref="UpgradeAllClusterNode" /> property.</summary>
        private bool? _upgradeAllClusterNode;

        /// <summary>
        /// whether upgrade all clusters' nodes. If it's true, upgradeClusterPool should be false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public bool? UpgradeAllClusterNode { get => this._upgradeAllClusterNode; set => this._upgradeAllClusterNode = value; }

        /// <summary>Backing field for <see cref="UpgradeClusterPool" /> property.</summary>
        private bool? _upgradeClusterPool;

        /// <summary>
        /// whether upgrade cluster pool or not. If it's true, upgradeAllClusterNodes should be false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Owned)]
        public bool? UpgradeClusterPool { get => this._upgradeClusterPool; set => this._upgradeClusterPool = value; }

        /// <summary>Type of upgrade.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Origin(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.PropertyOrigin.Inherited)]
        public string UpgradeType { get => "AKSPatchUpgrade"; set => ((Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolUpgradePropertiesInternal)__clusterPoolUpgradeProperties).UpgradeType = "AKSPatchUpgrade"; }

        /// <summary>
        /// Creates an new <see cref="ClusterPoolAksPatchVersionUpgradeProperties" /> instance.
        /// </summary>
        public ClusterPoolAksPatchVersionUpgradeProperties()
        {
            this.__clusterPoolUpgradeProperties.UpgradeType = "AKSPatchUpgrade";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__clusterPoolUpgradeProperties), __clusterPoolUpgradeProperties);
            await eventListener.AssertObjectIsValid(nameof(__clusterPoolUpgradeProperties), __clusterPoolUpgradeProperties);
        }
    }
    /// Properties of upgrading cluster pool's AKS patch version.
    public partial interface IClusterPoolAksPatchVersionUpgradeProperties :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolUpgradeProperties
    {
        /// <summary>
        /// Target AKS version. When it's not set, latest version will be used. When upgradeClusterPool is true and upgradeAllClusterNodes
        /// is false, target version should be greater or equal to current version. When upgradeClusterPool is false and upgradeAllClusterNodes
        /// is true, target version should be equal to AKS version of cluster pool.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Target AKS version. When it's not set, latest version will be used. When upgradeClusterPool is true and upgradeAllClusterNodes is false, target version should be greater or equal to current version. When upgradeClusterPool is false and upgradeAllClusterNodes is true, target version should be equal to AKS version of cluster pool.",
        SerializedName = @"targetAksVersion",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAksVersion { get; set; }
        /// <summary>
        /// whether upgrade all clusters' nodes. If it's true, upgradeClusterPool should be false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"whether upgrade all clusters' nodes. If it's true, upgradeClusterPool should be false.",
        SerializedName = @"upgradeAllClusterNodes",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UpgradeAllClusterNode { get; set; }
        /// <summary>
        /// whether upgrade cluster pool or not. If it's true, upgradeAllClusterNodes should be false.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"whether upgrade cluster pool or not. If it's true, upgradeAllClusterNodes should be false.",
        SerializedName = @"upgradeClusterPool",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UpgradeClusterPool { get; set; }

    }
    /// Properties of upgrading cluster pool's AKS patch version.
    internal partial interface IClusterPoolAksPatchVersionUpgradePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.HdInsightOnAks.Models.IClusterPoolUpgradePropertiesInternal
    {
        /// <summary>
        /// Target AKS version. When it's not set, latest version will be used. When upgradeClusterPool is true and upgradeAllClusterNodes
        /// is false, target version should be greater or equal to current version. When upgradeClusterPool is false and upgradeAllClusterNodes
        /// is true, target version should be equal to AKS version of cluster pool.
        /// </summary>
        string TargetAksVersion { get; set; }
        /// <summary>
        /// whether upgrade all clusters' nodes. If it's true, upgradeClusterPool should be false.
        /// </summary>
        bool? UpgradeAllClusterNode { get; set; }
        /// <summary>
        /// whether upgrade cluster pool or not. If it's true, upgradeAllClusterNodes should be false.
        /// </summary>
        bool? UpgradeClusterPool { get; set; }

    }
}