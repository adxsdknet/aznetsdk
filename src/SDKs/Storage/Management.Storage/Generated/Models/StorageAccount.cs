// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The storage account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class StorageAccount : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        public StorageAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccount class.
        /// </summary>
        /// <param name="location">The geo-location where the resource
        /// lives</param>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">Gets the SKU.</param>
        /// <param name="kind">Gets the Kind. Possible values include:
        /// 'Storage', 'StorageV2', 'BlobStorage', 'FileStorage',
        /// 'BlockBlobStorage'</param>
        /// <param name="identity">The identity of the resource.</param>
        /// <param name="provisioningState">Gets the status of the storage
        /// account at the time the operation was called. Possible values
        /// include: 'Creating', 'ResolvingDNS', 'Succeeded'</param>
        /// <param name="primaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue, or table object. Note
        /// that Standard_ZRS and Premium_LRS accounts only return the blob
        /// endpoint.</param>
        /// <param name="primaryLocation">Gets the location of the primary data
        /// center for the storage account.</param>
        /// <param name="statusOfPrimary">Gets the status indicating whether
        /// the primary location of the storage account is available or
        /// unavailable. Possible values include: 'available',
        /// 'unavailable'</param>
        /// <param name="lastGeoFailoverTime">Gets the timestamp of the most
        /// recent instance of a failover to the secondary location. Only the
        /// most recent timestamp is retained. This element is not returned if
        /// there has never been a failover instance. Only available if the
        /// accountType is Standard_GRS or Standard_RAGRS.</param>
        /// <param name="secondaryLocation">Gets the location of the
        /// geo-replicated secondary for the storage account. Only available if
        /// the accountType is Standard_GRS or Standard_RAGRS.</param>
        /// <param name="statusOfSecondary">Gets the status indicating whether
        /// the secondary location of the storage account is available or
        /// unavailable. Only available if the SKU name is Standard_GRS or
        /// Standard_RAGRS. Possible values include: 'available',
        /// 'unavailable'</param>
        /// <param name="creationTime">Gets the creation date and time of the
        /// storage account in UTC.</param>
        /// <param name="customDomain">Gets the custom domain the user assigned
        /// to this storage account.</param>
        /// <param name="secondaryEndpoints">Gets the URLs that are used to
        /// perform a retrieval of a public blob, queue, or table object from
        /// the secondary location of the storage account. Only available if
        /// the SKU name is Standard_RAGRS.</param>
        /// <param name="encryption">Gets the encryption settings on the
        /// account. If unspecified, the account is unencrypted.</param>
        /// <param name="accessTier">Required for storage accounts where kind =
        /// BlobStorage. The access tier used for billing. Possible values
        /// include: 'Hot', 'Cool'</param>
        /// <param name="enableAzureFilesAadIntegration">Enables Azure Files
        /// AAD Integration for SMB if sets to true.</param>
        /// <param name="enableHttpsTrafficOnly">Allows https traffic only to
        /// storage service if sets to true.</param>
        /// <param name="networkRuleSet">Network rule set</param>
        /// <param name="isHnsEnabled">Account HierarchicalNamespace enabled if
        /// sets to true.</param>
        /// <param name="geoReplicationStats">Geo Replication Stats</param>
        /// <param name="failoverInProgress">If the failover is in progress,
        /// the value will be true, otherwise, it will be null.</param>
        public StorageAccount(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku), Kind? kind = default(Kind?), Identity identity = default(Identity), ProvisioningState? provisioningState = default(ProvisioningState?), Endpoints primaryEndpoints = default(Endpoints), string primaryLocation = default(string), AccountStatus? statusOfPrimary = default(AccountStatus?), System.DateTime? lastGeoFailoverTime = default(System.DateTime?), string secondaryLocation = default(string), AccountStatus? statusOfSecondary = default(AccountStatus?), System.DateTime? creationTime = default(System.DateTime?), CustomDomain customDomain = default(CustomDomain), Endpoints secondaryEndpoints = default(Endpoints), Encryption encryption = default(Encryption), AccessTier? accessTier = default(AccessTier?), bool? enableAzureFilesAadIntegration = default(bool?), bool? enableHttpsTrafficOnly = default(bool?), NetworkRuleSet networkRuleSet = default(NetworkRuleSet), bool? isHnsEnabled = default(bool?), GeoReplicationStats geoReplicationStats = default(GeoReplicationStats), bool? failoverInProgress = default(bool?))
            : base(location, id, name, type, tags)
        {
            Sku = sku;
            Kind = kind;
            Identity = identity;
            ProvisioningState = provisioningState;
            PrimaryEndpoints = primaryEndpoints;
            PrimaryLocation = primaryLocation;
            StatusOfPrimary = statusOfPrimary;
            LastGeoFailoverTime = lastGeoFailoverTime;
            SecondaryLocation = secondaryLocation;
            StatusOfSecondary = statusOfSecondary;
            CreationTime = creationTime;
            CustomDomain = customDomain;
            SecondaryEndpoints = secondaryEndpoints;
            Encryption = encryption;
            AccessTier = accessTier;
            EnableAzureFilesAadIntegration = enableAzureFilesAadIntegration;
            EnableHttpsTrafficOnly = enableHttpsTrafficOnly;
            NetworkRuleSet = networkRuleSet;
            IsHnsEnabled = isHnsEnabled;
            GeoReplicationStats = geoReplicationStats;
            FailoverInProgress = failoverInProgress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; private set; }

        /// <summary>
        /// Gets the Kind. Possible values include: 'Storage', 'StorageV2',
        /// 'BlobStorage', 'FileStorage', 'BlockBlobStorage'
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public Kind? Kind { get; private set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Gets the status of the storage account at the time the operation
        /// was called. Possible values include: 'Creating', 'ResolvingDNS',
        /// 'Succeeded'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue, or table object. Note that Standard_ZRS and
        /// Premium_LRS accounts only return the blob endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryEndpoints")]
        public Endpoints PrimaryEndpoints { get; private set; }

        /// <summary>
        /// Gets the location of the primary data center for the storage
        /// account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryLocation")]
        public string PrimaryLocation { get; private set; }

        /// <summary>
        /// Gets the status indicating whether the primary location of the
        /// storage account is available or unavailable. Possible values
        /// include: 'available', 'unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusOfPrimary")]
        public AccountStatus? StatusOfPrimary { get; private set; }

        /// <summary>
        /// Gets the timestamp of the most recent instance of a failover to the
        /// secondary location. Only the most recent timestamp is retained.
        /// This element is not returned if there has never been a failover
        /// instance. Only available if the accountType is Standard_GRS or
        /// Standard_RAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastGeoFailoverTime")]
        public System.DateTime? LastGeoFailoverTime { get; private set; }

        /// <summary>
        /// Gets the location of the geo-replicated secondary for the storage
        /// account. Only available if the accountType is Standard_GRS or
        /// Standard_RAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryLocation")]
        public string SecondaryLocation { get; private set; }

        /// <summary>
        /// Gets the status indicating whether the secondary location of the
        /// storage account is available or unavailable. Only available if the
        /// SKU name is Standard_GRS or Standard_RAGRS. Possible values
        /// include: 'available', 'unavailable'
        /// </summary>
        [JsonProperty(PropertyName = "properties.statusOfSecondary")]
        public AccountStatus? StatusOfSecondary { get; private set; }

        /// <summary>
        /// Gets the creation date and time of the storage account in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the custom domain the user assigned to this storage account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customDomain")]
        public CustomDomain CustomDomain { get; private set; }

        /// <summary>
        /// Gets the URLs that are used to perform a retrieval of a public
        /// blob, queue, or table object from the secondary location of the
        /// storage account. Only available if the SKU name is Standard_RAGRS.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryEndpoints")]
        public Endpoints SecondaryEndpoints { get; private set; }

        /// <summary>
        /// Gets the encryption settings on the account. If unspecified, the
        /// account is unencrypted.
        /// </summary>
        [JsonProperty(PropertyName = "properties.encryption")]
        public Encryption Encryption { get; private set; }

        /// <summary>
        /// Gets required for storage accounts where kind = BlobStorage. The
        /// access tier used for billing. Possible values include: 'Hot',
        /// 'Cool'
        /// </summary>
        [JsonProperty(PropertyName = "properties.accessTier")]
        public AccessTier? AccessTier { get; private set; }

        /// <summary>
        /// Gets or sets enables Azure Files AAD Integration for SMB if sets to
        /// true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.azureFilesAadIntegration")]
        public bool? EnableAzureFilesAadIntegration { get; set; }

        /// <summary>
        /// Gets or sets allows https traffic only to storage service if sets
        /// to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.supportsHttpsTrafficOnly")]
        public bool? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// Gets network rule set
        /// </summary>
        [JsonProperty(PropertyName = "properties.networkAcls")]
        public NetworkRuleSet NetworkRuleSet { get; private set; }

        /// <summary>
        /// Gets or sets account HierarchicalNamespace enabled if sets to true.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isHnsEnabled")]
        public bool? IsHnsEnabled { get; set; }

        /// <summary>
        /// Gets geo Replication Stats
        /// </summary>
        [JsonProperty(PropertyName = "properties.geoReplicationStats")]
        public GeoReplicationStats GeoReplicationStats { get; private set; }

        /// <summary>
        /// Gets if the failover is in progress, the value will be true,
        /// otherwise, it will be null.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverInProgress")]
        public bool? FailoverInProgress { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
            if (CustomDomain != null)
            {
                CustomDomain.Validate();
            }
            if (Encryption != null)
            {
                Encryption.Validate();
            }
            if (NetworkRuleSet != null)
            {
                NetworkRuleSet.Validate();
            }
        }
    }
}
