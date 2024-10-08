// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Extensions;

    /// <summary>Properties under the logical network resource</summary>
    public partial class LogicalNetworkProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ILogicalNetworkProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ILogicalNetworkProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ILogicalNetworkProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject json ? new LogicalNetworkProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject into a new instance of <see cref="LogicalNetworkProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal LogicalNetworkProperties(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_dhcpOption = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject>("dhcpOptions"), out var __jsonDhcpOptions) ? Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.LogicalNetworkPropertiesDhcpOptions.FromJson(__jsonDhcpOptions) : _dhcpOption;}
            {_status = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject>("status"), out var __jsonStatus) ? Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.LogicalNetworkStatus.FromJson(__jsonStatus) : _status;}
            {_subnet = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonArray>("subnets"), out var __jsonSubnets) ? If( __jsonSubnets as Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnet>>(()=> global::System.Linq.Enumerable.ToList(global::System.Linq.Enumerable.Select(__v, (__u)=>(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.ISubnet) (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Models.Subnet.FromJson(__u) )) ))() : null : _subnet;}
            {_provisioningState = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonString>("provisioningState"), out var __jsonProvisioningState) ? (string)__jsonProvisioningState : (string)_provisioningState;}
            {_vMSwitchName = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonString>("vmSwitchName"), out var __jsonVMSwitchName) ? (string)__jsonVMSwitchName : (string)_vMSwitchName;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="LogicalNetworkProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="LogicalNetworkProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._dhcpOption ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode) this._dhcpOption.ToJson(null,serializationMode) : null, "dhcpOptions" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._status ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode) this._status.ToJson(null,serializationMode) : null, "status" ,container.Add );
            }
            if (null != this._subnet)
            {
                var __w = new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.XNodeArray();
                foreach( var __x in this._subnet )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("subnets",__w);
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != (((object)this._provisioningState)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonString(this._provisioningState.ToString()) : null, "provisioningState" ,container.Add );
            }
            AddIf( null != (((object)this._vMSwitchName)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.StackHCIVM.Runtime.Json.JsonString(this._vMSwitchName.ToString()) : null, "vmSwitchName" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}