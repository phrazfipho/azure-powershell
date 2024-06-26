// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Extensions;

    /// <summary>Describes the properties of a Virtual Network.</summary>
    public partial class VirtualNetworkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkPropertiesInternal
    {

        /// <summary>Backing field for <see cref="CustomResourceName" /> property.</summary>
        private string _customResourceName;

        /// <summary>Gets the name of the corresponding resource in Kubernetes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string CustomResourceName { get => this._customResourceName; }

        /// <summary>Backing field for <see cref="InventoryItemId" /> property.</summary>
        private string _inventoryItemId;

        /// <summary>Gets or sets the inventory Item ID for the virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string InventoryItemId { get => this._inventoryItemId; set => this._inventoryItemId = value; }

        /// <summary>Internal Acessors for CustomResourceName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkPropertiesInternal.CustomResourceName { get => this._customResourceName; set { {_customResourceName = value;} } }

        /// <summary>Internal Acessors for MoName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkPropertiesInternal.MoName { get => this._moName; set { {_moName = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkPropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Statuses</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus> Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkPropertiesInternal.Statuses { get => this._statuses; set { {_statuses = value;} } }

        /// <summary>Internal Acessors for Uuid</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IVirtualNetworkPropertiesInternal.Uuid { get => this._uuid; set { {_uuid = value;} } }

        /// <summary>Backing field for <see cref="MoName" /> property.</summary>
        private string _moName;

        /// <summary>Gets or sets the vCenter Managed Object name for the virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string MoName { get => this._moName; }

        /// <summary>Backing field for <see cref="MoRefId" /> property.</summary>
        private string _moRefId;

        /// <summary>
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string MoRefId { get => this._moRefId; set => this._moRefId = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Gets the provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Statuses" /> property.</summary>
        private System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus> _statuses;

        /// <summary>The resource status information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus> Statuses { get => this._statuses; }

        /// <summary>Backing field for <see cref="Uuid" /> property.</summary>
        private string _uuid;

        /// <summary>Gets or sets a unique identifier for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string Uuid { get => this._uuid; }

        /// <summary>Backing field for <see cref="VCenterId" /> property.</summary>
        private string _vCenterId;

        /// <summary>Gets or sets the ARM Id of the vCenter resource in which this template resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Origin(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PropertyOrigin.Owned)]
        public string VCenterId { get => this._vCenterId; set => this._vCenterId = value; }

        /// <summary>Creates an new <see cref="VirtualNetworkProperties" /> instance.</summary>
        public VirtualNetworkProperties()
        {

        }
    }
    /// Describes the properties of a Virtual Network.
    public partial interface IVirtualNetworkProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.IJsonSerializable
    {
        /// <summary>Gets the name of the corresponding resource in Kubernetes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the name of the corresponding resource in Kubernetes.",
        SerializedName = @"customResourceName",
        PossibleTypes = new [] { typeof(string) })]
        string CustomResourceName { get;  }
        /// <summary>Gets or sets the inventory Item ID for the virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the inventory Item ID for the virtual network.",
        SerializedName = @"inventoryItemId",
        PossibleTypes = new [] { typeof(string) })]
        string InventoryItemId { get; set; }
        /// <summary>Gets or sets the vCenter Managed Object name for the virtual network.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets the vCenter Managed Object name for the virtual network.",
        SerializedName = @"moName",
        PossibleTypes = new [] { typeof(string) })]
        string MoName { get;  }
        /// <summary>
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual network.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual network.",
        SerializedName = @"moRefId",
        PossibleTypes = new [] { typeof(string) })]
        string MoRefId { get; set; }
        /// <summary>Gets the provisioning state.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets the provisioning state.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted", "Created")]
        string ProvisioningState { get;  }
        /// <summary>The resource status information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"The resource status information.",
        SerializedName = @"statuses",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus> Statuses { get;  }
        /// <summary>Gets or sets a unique identifier for this resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Gets or sets a unique identifier for this resource.",
        SerializedName = @"uuid",
        PossibleTypes = new [] { typeof(string) })]
        string Uuid { get;  }
        /// <summary>Gets or sets the ARM Id of the vCenter resource in which this template resides.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Gets or sets the ARM Id of the vCenter resource in which this template resides.",
        SerializedName = @"vCenterId",
        PossibleTypes = new [] { typeof(string) })]
        string VCenterId { get; set; }

    }
    /// Describes the properties of a Virtual Network.
    internal partial interface IVirtualNetworkPropertiesInternal

    {
        /// <summary>Gets the name of the corresponding resource in Kubernetes.</summary>
        string CustomResourceName { get; set; }
        /// <summary>Gets or sets the inventory Item ID for the virtual network.</summary>
        string InventoryItemId { get; set; }
        /// <summary>Gets or sets the vCenter Managed Object name for the virtual network.</summary>
        string MoName { get; set; }
        /// <summary>
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual network.
        /// </summary>
        string MoRefId { get; set; }
        /// <summary>Gets the provisioning state.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.PSArgumentCompleterAttribute("Succeeded", "Failed", "Canceled", "Provisioning", "Updating", "Deleting", "Accepted", "Created")]
        string ProvisioningState { get; set; }
        /// <summary>The resource status information.</summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.ConnectedVMware.Models.IResourceStatus> Statuses { get; set; }
        /// <summary>Gets or sets a unique identifier for this resource.</summary>
        string Uuid { get; set; }
        /// <summary>Gets or sets the ARM Id of the vCenter resource in which this template resides.</summary>
        string VCenterId { get; set; }

    }
}