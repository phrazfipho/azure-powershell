// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Extensions;

    /// <summary>Model that represents a query selector.</summary>
    public partial class QuerySelector :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IQuerySelector,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IQuerySelectorInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelector" />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelector __selector = new Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.Selector();

        /// <summary>
        /// Model that represents available filter types that can be applied to a targets list.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IFilter Filter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Filter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Filter = value ?? null /* model class */; }

        /// <summary>
        /// Enum that discriminates between filter types. Currently only `Simple` type is supported.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string FilterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).FilterType; }

        /// <summary>String of the selector ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Id = value ; }

        /// <summary>Internal Acessors for Filter</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.IFilter Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal.Filter { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Filter; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Filter = value; }

        /// <summary>Internal Acessors for FilterType</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal.FilterType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).FilterType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).FilterType = value; }

        /// <summary>Backing field for <see cref="QueryString" /> property.</summary>
        private string _queryString;

        /// <summary>Azure Resource Graph (ARG) Query Language query for target resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public string QueryString { get => this._queryString; set => this._queryString = value; }

        /// <summary>Backing field for <see cref="SubscriptionId" /> property.</summary>
        private System.Collections.Generic.List<string> _subscriptionId;

        /// <summary>Subscription id list to scope resource query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Owned)]
        public System.Collections.Generic.List<string> SubscriptionId { get => this._subscriptionId; set => this._subscriptionId = value; }

        /// <summary>Enum of the selector type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Constant]
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Origin(Microsoft.Azure.PowerShell.Cmdlets.Chaos.PropertyOrigin.Inherited)]
        public string Type { get => "Query"; set => ((Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal)__selector).Type = "Query"; }

        /// <summary>Creates an new <see cref="QuerySelector" /> instance.</summary>
        public QuerySelector()
        {
            this.__selector.Type = "Query";
        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__selector), __selector);
            await eventListener.AssertObjectIsValid(nameof(__selector), __selector);
        }
    }
    /// Model that represents a query selector.
    public partial interface IQuerySelector :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelector
    {
        /// <summary>Azure Resource Graph (ARG) Query Language query for target resources.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Azure Resource Graph (ARG) Query Language query for target resources.",
        SerializedName = @"queryString",
        PossibleTypes = new [] { typeof(string) })]
        string QueryString { get; set; }
        /// <summary>Subscription id list to scope resource query.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Chaos.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Subscription id list to scope resource query.",
        SerializedName = @"subscriptionIds",
        PossibleTypes = new [] { typeof(string) })]
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
    /// Model that represents a query selector.
    internal partial interface IQuerySelectorInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Chaos.Models.ISelectorInternal
    {
        /// <summary>Azure Resource Graph (ARG) Query Language query for target resources.</summary>
        string QueryString { get; set; }
        /// <summary>Subscription id list to scope resource query.</summary>
        System.Collections.Generic.List<string> SubscriptionId { get; set; }

    }
}