// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Security.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.PowerShell;

    /// <summary>The Defender for Databases GCP offering configurations</summary>
    [System.ComponentModel.TypeConverter(typeof(DefenderForDatabasesGcpOfferingTypeConverter))]
    public partial class DefenderForDatabasesGcpOffering
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOffering"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal DefenderForDatabasesGcpOffering(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ArcAutoProvisioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioning = (Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingArcAutoProvisioning) content.GetValueForProperty("ArcAutoProvisioning",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioning, Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOfferingArcAutoProvisioningTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefenderForDatabasesArcAutoProvisioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabasesArcAutoProvisioning = (Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingDefenderForDatabasesArcAutoProvisioning) content.GetValueForProperty("DefenderForDatabasesArcAutoProvisioning",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabasesArcAutoProvisioning, Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOfferingDefenderForDatabasesArcAutoProvisioningTypeConverter.ConvertFrom);
            }
            if (content.Contains("OfferingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).OfferingType = (string) content.GetValueForProperty("OfferingType",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).OfferingType, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAutoProvisioningConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingArcAutoProvisioningConfiguration) content.GetValueForProperty("ArcAutoProvisioningConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOfferingArcAutoProvisioningConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ArcAutoProvisioningEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningEnabled = (bool?) content.GetValueForProperty("ArcAutoProvisioningEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress = (string) content.GetValueForProperty("DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId = (string) content.GetValueForProperty("DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationProxy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationProxy = (string) content.GetValueForProperty("ConfigurationProxy",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationProxy, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationPrivateLinkScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationPrivateLinkScope = (string) content.GetValueForProperty("ConfigurationPrivateLinkScope",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationPrivateLinkScope, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOffering"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal DefenderForDatabasesGcpOffering(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("ArcAutoProvisioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioning = (Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingArcAutoProvisioning) content.GetValueForProperty("ArcAutoProvisioning",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioning, Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOfferingArcAutoProvisioningTypeConverter.ConvertFrom);
            }
            if (content.Contains("DefenderForDatabasesArcAutoProvisioning"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabasesArcAutoProvisioning = (Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingDefenderForDatabasesArcAutoProvisioning) content.GetValueForProperty("DefenderForDatabasesArcAutoProvisioning",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabasesArcAutoProvisioning, Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOfferingDefenderForDatabasesArcAutoProvisioningTypeConverter.ConvertFrom);
            }
            if (content.Contains("OfferingType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).OfferingType = (string) content.GetValueForProperty("OfferingType",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).OfferingType, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.ICloudOfferingInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("ArcAutoProvisioningConfiguration"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningConfiguration = (Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingArcAutoProvisioningConfiguration) content.GetValueForProperty("ArcAutoProvisioningConfiguration",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningConfiguration, Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOfferingArcAutoProvisioningConfigurationTypeConverter.ConvertFrom);
            }
            if (content.Contains("ArcAutoProvisioningEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningEnabled = (bool?) content.GetValueForProperty("ArcAutoProvisioningEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ArcAutoProvisioningEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress = (string) content.GetValueForProperty("DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningServiceAccountEmailAddress, global::System.Convert.ToString);
            }
            if (content.Contains("DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId = (string) content.GetValueForProperty("DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).DefenderForDatabaseArcAutoProvisioningWorkloadIdentityProviderId, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationProxy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationProxy = (string) content.GetValueForProperty("ConfigurationProxy",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationProxy, global::System.Convert.ToString);
            }
            if (content.Contains("ConfigurationPrivateLinkScope"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationPrivateLinkScope = (string) content.GetValueForProperty("ConfigurationPrivateLinkScope",((Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOfferingInternal)this).ConfigurationPrivateLinkScope, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOffering"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOffering" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOffering DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new DefenderForDatabasesGcpOffering(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Models.DefenderForDatabasesGcpOffering"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOffering" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOffering DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new DefenderForDatabasesGcpOffering(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="DefenderForDatabasesGcpOffering" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="DefenderForDatabasesGcpOffering" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Security.Models.IDefenderForDatabasesGcpOffering FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Security.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// The Defender for Databases GCP offering configurations
    [System.ComponentModel.TypeConverter(typeof(DefenderForDatabasesGcpOfferingTypeConverter))]
    public partial interface IDefenderForDatabasesGcpOffering

    {

    }
}