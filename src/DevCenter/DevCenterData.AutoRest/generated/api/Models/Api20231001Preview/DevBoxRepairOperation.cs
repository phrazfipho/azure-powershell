// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Extensions;

    /// <summary>Information about a repair operation on a Dev Box.</summary>
    public partial class DevBoxRepairOperation :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperation,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationInternal,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperation"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperation __devBoxOperation = new Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.DevBoxOperation();

        /// <summary>
        /// An identifier for the error. Codes are invariant and are intended to be consumed programmatically.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Code = value ?? null; }

        /// <summary>The object ID of the actor which initiated the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public string CreatedByObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).CreatedByObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).CreatedByObjectId = value ?? null; }

        /// <summary>A list of additional details about the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.ICloudErrorBody[] Detail { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Detail; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Detail = value ?? null /* arrayOf */; }

        /// <summary>The time the operation finished.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? EndTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).EndTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).EndTime = value ?? default(global::System.DateTime); }

        /// <summary>Provisioning or operation error details. Populated only for error states.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.ICloudErrorBody Error { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Error; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Error = value ?? null /* model class */; }

        /// <summary>The kind of operation that occurred.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxOperationKind Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Kind = value ; }

        /// <summary>
        /// A message describing the error, intended to be suitable for display in a user interface.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Message = value ?? null; }

        /// <summary>Internal Acessors for Result</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResult Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationInternal.Result { get => (this._result = this._result ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.DevBoxRepairOperationResult()); set { {_result = value;} } }

        /// <summary>Unique identifier for the Dev Box operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public string OperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).OperationId = value ; }

        /// <summary>Backing field for <see cref="Result" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResult _result;

        /// <summary>The result of the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResult Result { get => (this._result = this._result ?? new Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.DevBoxRepairOperationResult()); set => this._result = value; }

        /// <summary>The result code associated with the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inlined)]
        public string ResultCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResultInternal)Result).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResultInternal)Result).Code = value ?? null; }

        /// <summary>The result message associated with the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inlined)]
        public string ResultMessage { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResultInternal)Result).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResultInternal)Result).Message = value ?? null; }

        /// <summary>The outcome of the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxRepairOutcome? ResultRepairOutcome { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResultInternal)Result).RepairOutcome; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResultInternal)Result).RepairOutcome = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxRepairOutcome)""); }

        /// <summary>The time the operation started.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public global::System.DateTime? StartTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).StartTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).StartTime = value ?? default(global::System.DateTime); }

        /// <summary>The operation status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxOperationStatus Status { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Status; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Status = value ; }

        /// <summary>
        /// The target of the particular error. For example, the name of the property in error.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Target = value ?? null; }

        /// <summary>The unique URI for the Dev Box operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Origin(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.PropertyOrigin.Inherited)]
        public string Uri { get => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Uri; set => ((Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal)__devBoxOperation).Uri = value ; }

        /// <summary>Creates an new <see cref="DevBoxRepairOperation" /> instance.</summary>
        public DevBoxRepairOperation()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__devBoxOperation), __devBoxOperation);
            await eventListener.AssertObjectIsValid(nameof(__devBoxOperation), __devBoxOperation);
        }
    }
    /// Information about a repair operation on a Dev Box.
    public partial interface IDevBoxRepairOperation :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperation
    {
        /// <summary>The result code associated with the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The result code associated with the repair operation.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string ResultCode { get; set; }
        /// <summary>The result message associated with the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The result message associated with the repair operation.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string ResultMessage { get; set; }
        /// <summary>The outcome of the repair operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The outcome of the repair operation.",
        SerializedName = @"repairOutcome",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxRepairOutcome) })]
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxRepairOutcome? ResultRepairOutcome { get; set; }

    }
    /// Information about a repair operation on a Dev Box.
    internal partial interface IDevBoxRepairOperationInternal :
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxOperationInternal
    {
        /// <summary>The result of the repair operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Models.Api20231001Preview.IDevBoxRepairOperationResult Result { get; set; }
        /// <summary>The result code associated with the repair operation.</summary>
        string ResultCode { get; set; }
        /// <summary>The result message associated with the repair operation.</summary>
        string ResultMessage { get; set; }
        /// <summary>The outcome of the repair operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DevCenterdata.Support.DevBoxRepairOutcome? ResultRepairOutcome { get; set; }

    }
}