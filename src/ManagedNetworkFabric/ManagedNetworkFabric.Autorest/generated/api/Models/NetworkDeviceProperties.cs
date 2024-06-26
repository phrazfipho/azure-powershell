// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Extensions;

    /// <summary>Network Device Properties defines the properties of the resource.</summary>
    public partial class NetworkDeviceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDeviceProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource __annotationResource = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.AnnotationResource();

        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchableProperties"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchableProperties __networkDevicePatchableProperties = new Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.NetworkDevicePatchableProperties();

        /// <summary>Backing field for <see cref="AdministrativeState" /> property.</summary>
        private string _administrativeState;

        /// <summary>Administrative state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string AdministrativeState { get => this._administrativeState; }

        /// <summary>Switch configuration description.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string Annotation { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal)__annotationResource).Annotation = value ?? null; }

        /// <summary>Backing field for <see cref="ConfigurationState" /> property.</summary>
        private string _configurationState;

        /// <summary>Configuration state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ConfigurationState { get => this._configurationState; }

        /// <summary>The host name of the device.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string HostName { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)__networkDevicePatchableProperties).HostName; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)__networkDevicePatchableProperties).HostName = value ?? null; }

        /// <summary>Backing field for <see cref="ManagementIpv4Address" /> property.</summary>
        private string _managementIpv4Address;

        /// <summary>Management IPv4 Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ManagementIpv4Address { get => this._managementIpv4Address; }

        /// <summary>Backing field for <see cref="ManagementIpv6Address" /> property.</summary>
        private string _managementIpv6Address;

        /// <summary>Management IPv6 Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ManagementIpv6Address { get => this._managementIpv6Address; }

        /// <summary>Internal Acessors for AdministrativeState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.AdministrativeState { get => this._administrativeState; set { {_administrativeState = value;} } }

        /// <summary>Internal Acessors for ConfigurationState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.ConfigurationState { get => this._configurationState; set { {_configurationState = value;} } }

        /// <summary>Internal Acessors for ManagementIpv4Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.ManagementIpv4Address { get => this._managementIpv4Address; set { {_managementIpv4Address = value;} } }

        /// <summary>Internal Acessors for ManagementIpv6Address</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.ManagementIpv6Address { get => this._managementIpv6Address; set { {_managementIpv6Address = value;} } }

        /// <summary>Internal Acessors for NetworkDeviceRole</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.NetworkDeviceRole { get => this._networkDeviceRole; set { {_networkDeviceRole = value;} } }

        /// <summary>Internal Acessors for NetworkRackId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.NetworkRackId { get => this._networkRackId; set { {_networkRackId = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Version</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePropertiesInternal.Version { get => this._version; set { {_version = value;} } }

        /// <summary>Backing field for <see cref="NetworkDeviceRole" /> property.</summary>
        private string _networkDeviceRole;

        /// <summary>NetworkDeviceRole is the device role: Example: CE | ToR.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string NetworkDeviceRole { get => this._networkDeviceRole; }

        /// <summary>Backing field for <see cref="NetworkDeviceSku" /> property.</summary>
        private string _networkDeviceSku;

        /// <summary>Network Device SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string NetworkDeviceSku { get => this._networkDeviceSku; set => this._networkDeviceSku = value; }

        /// <summary>Backing field for <see cref="NetworkRackId" /> property.</summary>
        private string _networkRackId;

        /// <summary>Reference to network rack resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string NetworkRackId { get => this._networkRackId; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>
        /// Serial number of the device. Format of serial Number - Make;Model;HardwareRevisionId;SerialNumber.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Inherited)]
        public string SerialNumber { get => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)__networkDevicePatchableProperties).SerialNumber; set => ((Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal)__networkDevicePatchableProperties).SerialNumber = value ?? null; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>Current version of the device as defined in SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Origin(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PropertyOrigin.Owned)]
        public string Version { get => this._version; }

        /// <summary>Creates an new <see cref="NetworkDeviceProperties" /> instance.</summary>
        public NetworkDeviceProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertObjectIsValid(nameof(__annotationResource), __annotationResource);
            await eventListener.AssertNotNull(nameof(__networkDevicePatchableProperties), __networkDevicePatchableProperties);
            await eventListener.AssertObjectIsValid(nameof(__networkDevicePatchableProperties), __networkDevicePatchableProperties);
        }
    }
    /// Network Device Properties defines the properties of the resource.
    public partial interface INetworkDeviceProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResource,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchableProperties
    {
        /// <summary>Administrative state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Administrative state of the resource.",
        SerializedName = @"administrativeState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Enabled", "Disabled", "MAT", "RMA")]
        string AdministrativeState { get;  }
        /// <summary>Configuration state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Configuration state of the resource.",
        SerializedName = @"configurationState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Succeeded", "Failed", "Rejected", "Accepted", "Provisioned", "ErrorProvisioning", "Deprovisioning", "Deprovisioned", "ErrorDeprovisioning", "DeferredControl")]
        string ConfigurationState { get;  }
        /// <summary>Management IPv4 Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Management IPv4 Address.",
        SerializedName = @"managementIpv4Address",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementIpv4Address { get;  }
        /// <summary>Management IPv6 Address.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Management IPv6 Address.",
        SerializedName = @"managementIpv6Address",
        PossibleTypes = new [] { typeof(string) })]
        string ManagementIpv6Address { get;  }
        /// <summary>NetworkDeviceRole is the device role: Example: CE | ToR.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"NetworkDeviceRole is the device role: Example: CE | ToR.",
        SerializedName = @"networkDeviceRole",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("CE", "ToR", "NPB", "TS", "Management")]
        string NetworkDeviceRole { get;  }
        /// <summary>Network Device SKU name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = false,
        Description = @"Network Device SKU name.",
        SerializedName = @"networkDeviceSku",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkDeviceSku { get; set; }
        /// <summary>Reference to network rack resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Reference to network rack resource id.",
        SerializedName = @"networkRackId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkRackId { get;  }
        /// <summary>Provisioning state of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning state of the resource.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Updating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get;  }
        /// <summary>Current version of the device as defined in SKU.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Current version of the device as defined in SKU.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get;  }

    }
    /// Network Device Properties defines the properties of the resource.
    internal partial interface INetworkDevicePropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.IAnnotationResourceInternal,
        Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.Models.INetworkDevicePatchablePropertiesInternal
    {
        /// <summary>Administrative state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Enabled", "Disabled", "MAT", "RMA")]
        string AdministrativeState { get; set; }
        /// <summary>Configuration state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Succeeded", "Failed", "Rejected", "Accepted", "Provisioned", "ErrorProvisioning", "Deprovisioning", "Deprovisioned", "ErrorDeprovisioning", "DeferredControl")]
        string ConfigurationState { get; set; }
        /// <summary>Management IPv4 Address.</summary>
        string ManagementIpv4Address { get; set; }
        /// <summary>Management IPv6 Address.</summary>
        string ManagementIpv6Address { get; set; }
        /// <summary>NetworkDeviceRole is the device role: Example: CE | ToR.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("CE", "ToR", "NPB", "TS", "Management")]
        string NetworkDeviceRole { get; set; }
        /// <summary>Network Device SKU name.</summary>
        string NetworkDeviceSku { get; set; }
        /// <summary>Reference to network rack resource id.</summary>
        string NetworkRackId { get; set; }
        /// <summary>Provisioning state of the resource.</summary>
        [global::Microsoft.Azure.PowerShell.Cmdlets.ManagedNetworkFabric.PSArgumentCompleterAttribute("Accepted", "Succeeded", "Updating", "Deleting", "Failed", "Canceled")]
        string ProvisioningState { get; set; }
        /// <summary>Current version of the device as defined in SKU.</summary>
        string Version { get; set; }

    }
}