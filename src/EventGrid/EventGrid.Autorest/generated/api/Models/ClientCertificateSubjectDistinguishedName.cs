// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Extensions;

    /// <summary>
    /// CA certificate subject distinguished name information used by service to authenticate clients.
    /// For more information, see https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x500distinguishedname?view=net-6.0#remarks
    /// </summary>
    public partial class ClientCertificateSubjectDistinguishedName :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateSubjectDistinguishedName,
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Models.IClientCertificateSubjectDistinguishedNameInternal
    {

        /// <summary>Backing field for <see cref="CommonName" /> property.</summary>
        private string _commonName;

        /// <summary>
        /// The common name field in the subject name. The allowed limit is 64 characters and it should be specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string CommonName { get => this._commonName; set => this._commonName = value; }

        /// <summary>Backing field for <see cref="CountryCode" /> property.</summary>
        private string _countryCode;

        /// <summary>
        /// The country code field in the subject name. If present, the country code should be represented by two-letter code defined
        /// in ISO 2166-1 (alpha-2). For example: 'US'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string CountryCode { get => this._countryCode; set => this._countryCode = value; }

        /// <summary>Backing field for <see cref="Organization" /> property.</summary>
        private string _organization;

        /// <summary>
        /// The organization field in the subject name. If present, the allowed limit is 64 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string Organization { get => this._organization; set => this._organization = value; }

        /// <summary>Backing field for <see cref="OrganizationUnit" /> property.</summary>
        private string _organizationUnit;

        /// <summary>
        /// The organization unit field in the subject name. If present, the allowed limit is 32 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Origin(Microsoft.Azure.PowerShell.Cmdlets.EventGrid.PropertyOrigin.Owned)]
        public string OrganizationUnit { get => this._organizationUnit; set => this._organizationUnit = value; }

        /// <summary>
        /// Creates an new <see cref="ClientCertificateSubjectDistinguishedName" /> instance.
        /// </summary>
        public ClientCertificateSubjectDistinguishedName()
        {

        }
    }
    /// CA certificate subject distinguished name information used by service to authenticate clients.
    /// For more information, see https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x500distinguishedname?view=net-6.0#remarks
    public partial interface IClientCertificateSubjectDistinguishedName :
        Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The common name field in the subject name. The allowed limit is 64 characters and it should be specified.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The common name field in the subject name. The allowed limit is 64 characters and it should be specified.",
        SerializedName = @"commonName",
        PossibleTypes = new [] { typeof(string) })]
        string CommonName { get; set; }
        /// <summary>
        /// The country code field in the subject name. If present, the country code should be represented by two-letter code defined
        /// in ISO 2166-1 (alpha-2). For example: 'US'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The country code field in the subject name. If present, the country code should be represented by two-letter code defined in ISO 2166-1 (alpha-2). For example: 'US'.",
        SerializedName = @"countryCode",
        PossibleTypes = new [] { typeof(string) })]
        string CountryCode { get; set; }
        /// <summary>
        /// The organization field in the subject name. If present, the allowed limit is 64 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The organization field in the subject name. If present, the allowed limit is 64 characters.",
        SerializedName = @"organization",
        PossibleTypes = new [] { typeof(string) })]
        string Organization { get; set; }
        /// <summary>
        /// The organization unit field in the subject name. If present, the allowed limit is 32 characters.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.EventGrid.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"The organization unit field in the subject name. If present, the allowed limit is 32 characters.",
        SerializedName = @"organizationUnit",
        PossibleTypes = new [] { typeof(string) })]
        string OrganizationUnit { get; set; }

    }
    /// CA certificate subject distinguished name information used by service to authenticate clients.
    /// For more information, see https://docs.microsoft.com/en-us/dotnet/api/system.security.cryptography.x509certificates.x500distinguishedname?view=net-6.0#remarks
    internal partial interface IClientCertificateSubjectDistinguishedNameInternal

    {
        /// <summary>
        /// The common name field in the subject name. The allowed limit is 64 characters and it should be specified.
        /// </summary>
        string CommonName { get; set; }
        /// <summary>
        /// The country code field in the subject name. If present, the country code should be represented by two-letter code defined
        /// in ISO 2166-1 (alpha-2). For example: 'US'.
        /// </summary>
        string CountryCode { get; set; }
        /// <summary>
        /// The organization field in the subject name. If present, the allowed limit is 64 characters.
        /// </summary>
        string Organization { get; set; }
        /// <summary>
        /// The organization unit field in the subject name. If present, the allowed limit is 32 characters.
        /// </summary>
        string OrganizationUnit { get; set; }

    }
}