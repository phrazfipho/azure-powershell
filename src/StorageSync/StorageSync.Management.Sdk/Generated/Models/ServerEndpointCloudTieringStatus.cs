// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.StorageSync.Models
{
    using System.Linq;

    /// <summary>
    /// Server endpoint cloud tiering status object.
    /// </summary>
    public partial class ServerEndpointCloudTieringStatus
    {
        /// <summary>
        /// Initializes a new instance of the ServerEndpointCloudTieringStatus class.
        /// </summary>
        public ServerEndpointCloudTieringStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerEndpointCloudTieringStatus class.
        /// </summary>

        /// <param name="lastUpdatedTimestamp">Last updated timestamp
        /// </param>

        /// <param name="health">Cloud tiering health state.
        /// Possible values include: &#39;Unavailable&#39;, &#39;Healthy&#39;, &#39;Error&#39;</param>

        /// <param name="healthLastUpdatedTimestamp">The last updated timestamp of health state
        /// </param>

        /// <param name="lastCloudTieringResult">Last cloud tiering result (HResult)
        /// </param>

        /// <param name="lastSuccessTimestamp">Last cloud tiering success timestamp
        /// </param>

        /// <param name="spaceSavings">Information regarding how much local space cloud tiering is saving.
        /// </param>

        /// <param name="cachePerformance">Information regarding how well the local cache on the server is performing.
        /// </param>

        /// <param name="filesNotTiering">Information regarding files that failed to be tiered
        /// </param>

        /// <param name="volumeFreeSpacePolicyStatus">Status of the volume free space policy
        /// </param>

        /// <param name="datePolicyStatus">Status of the date policy
        /// </param>

        /// <param name="lowDiskMode">Information regarding the low disk mode state
        /// </param>
        public ServerEndpointCloudTieringStatus(System.DateTime? lastUpdatedTimestamp = default(System.DateTime?), string health = default(string), System.DateTime? healthLastUpdatedTimestamp = default(System.DateTime?), int? lastCloudTieringResult = default(int?), System.DateTime? lastSuccessTimestamp = default(System.DateTime?), CloudTieringSpaceSavings spaceSavings = default(CloudTieringSpaceSavings), CloudTieringCachePerformance cachePerformance = default(CloudTieringCachePerformance), CloudTieringFilesNotTiering filesNotTiering = default(CloudTieringFilesNotTiering), CloudTieringVolumeFreeSpacePolicyStatus volumeFreeSpacePolicyStatus = default(CloudTieringVolumeFreeSpacePolicyStatus), CloudTieringDatePolicyStatus datePolicyStatus = default(CloudTieringDatePolicyStatus), CloudTieringLowDiskMode lowDiskMode = default(CloudTieringLowDiskMode))

        {
            this.LastUpdatedTimestamp = lastUpdatedTimestamp;
            this.Health = health;
            this.HealthLastUpdatedTimestamp = healthLastUpdatedTimestamp;
            this.LastCloudTieringResult = lastCloudTieringResult;
            this.LastSuccessTimestamp = lastSuccessTimestamp;
            this.SpaceSavings = spaceSavings;
            this.CachePerformance = cachePerformance;
            this.FilesNotTiering = filesNotTiering;
            this.VolumeFreeSpacePolicyStatus = volumeFreeSpacePolicyStatus;
            this.DatePolicyStatus = datePolicyStatus;
            this.LowDiskMode = lowDiskMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets last updated timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastUpdatedTimestamp")]
        public System.DateTime? LastUpdatedTimestamp {get; private set; }

        /// <summary>
        /// Gets cloud tiering health state. Possible values include: &#39;Unavailable&#39;, &#39;Healthy&#39;, &#39;Error&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "health")]
        public string Health {get; private set; }

        /// <summary>
        /// Gets the last updated timestamp of health state
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "healthLastUpdatedTimestamp")]
        public System.DateTime? HealthLastUpdatedTimestamp {get; private set; }

        /// <summary>
        /// Gets last cloud tiering result (HResult)
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastCloudTieringResult")]
        public int? LastCloudTieringResult {get; private set; }

        /// <summary>
        /// Gets last cloud tiering success timestamp
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastSuccessTimestamp")]
        public System.DateTime? LastSuccessTimestamp {get; private set; }

        /// <summary>
        /// Gets information regarding how much local space cloud tiering is saving.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "spaceSavings")]
        public CloudTieringSpaceSavings SpaceSavings {get; private set; }

        /// <summary>
        /// Gets information regarding how well the local cache on the server is
        /// performing.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "cachePerformance")]
        public CloudTieringCachePerformance CachePerformance {get; private set; }

        /// <summary>
        /// Gets information regarding files that failed to be tiered
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "filesNotTiering")]
        public CloudTieringFilesNotTiering FilesNotTiering {get; private set; }

        /// <summary>
        /// Gets status of the volume free space policy
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "volumeFreeSpacePolicyStatus")]
        public CloudTieringVolumeFreeSpacePolicyStatus VolumeFreeSpacePolicyStatus {get; private set; }

        /// <summary>
        /// Gets status of the date policy
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "datePolicyStatus")]
        public CloudTieringDatePolicyStatus DatePolicyStatus {get; private set; }

        /// <summary>
        /// Gets information regarding the low disk mode state
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lowDiskMode")]
        public CloudTieringLowDiskMode LowDiskMode {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {

            if (this.SpaceSavings != null)
            {
                this.SpaceSavings.Validate();
            }
            if (this.CachePerformance != null)
            {
                this.CachePerformance.Validate();
            }
            if (this.FilesNotTiering != null)
            {
                this.FilesNotTiering.Validate();
            }
            if (this.VolumeFreeSpacePolicyStatus != null)
            {
                this.VolumeFreeSpacePolicyStatus.Validate();
            }


        }
    }
}