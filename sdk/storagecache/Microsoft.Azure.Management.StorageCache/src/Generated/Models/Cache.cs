// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageCache.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Cache instance. Follows Azure Resource Manager standards:
    /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Cache
    {
        /// <summary>
        /// Initializes a new instance of the Cache class.
        /// </summary>
        public Cache()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Cache class.
        /// </summary>
        /// <param name="tags">ARM tags as name/value pairs.</param>
        /// <param name="id">Resource ID of the Cache.</param>
        /// <param name="location">Region name string.</param>
        /// <param name="name">Name of Cache.</param>
        /// <param name="type">Type of the Cache;
        /// Microsoft.StorageCache/Cache</param>
        /// <param name="cacheSizeGB">The size of this Cache, in GB.</param>
        /// <param name="health">Health of the Cache.</param>
        /// <param name="mountAddresses">Array of IP addresses that can be used
        /// by clients mounting this Cache.</param>
        /// <param name="provisioningState">ARM provisioning state, see
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property.
        /// Possible values include: 'Succeeded', 'Failed', 'Cancelled',
        /// 'Creating', 'Deleting', 'Updating'</param>
        /// <param name="subnet">Subnet used for the Cache.</param>
        /// <param name="upgradeStatus">Upgrade status of the Cache.</param>
        /// <param name="sku">SKU for the Cache.</param>
        public Cache(object tags = default(object), string id = default(string), string location = default(string), string name = default(string), string type = default(string), int? cacheSizeGB = default(int?), CacheHealth health = default(CacheHealth), IList<string> mountAddresses = default(IList<string>), string provisioningState = default(string), string subnet = default(string), CacheUpgradeStatus upgradeStatus = default(CacheUpgradeStatus), CacheSku sku = default(CacheSku))
        {
            Tags = tags;
            Id = id;
            Location = location;
            Name = name;
            Type = type;
            CacheSizeGB = cacheSizeGB;
            Health = health;
            MountAddresses = mountAddresses;
            ProvisioningState = provisioningState;
            Subnet = subnet;
            UpgradeStatus = upgradeStatus;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ARM tags as name/value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public object Tags { get; set; }

        /// <summary>
        /// Gets resource ID of the Cache.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets region name string.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets name of Cache.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of the Cache; Microsoft.StorageCache/Cache
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the size of this Cache, in GB.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cacheSizeGB")]
        public int? CacheSizeGB { get; set; }

        /// <summary>
        /// Gets health of the Cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.health")]
        public CacheHealth Health { get; private set; }

        /// <summary>
        /// Gets array of IP addresses that can be used by clients mounting
        /// this Cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.mountAddresses")]
        public IList<string> MountAddresses { get; private set; }

        /// <summary>
        /// Gets or sets ARM provisioning state, see
        /// https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property.
        /// Possible values include: 'Succeeded', 'Failed', 'Cancelled',
        /// 'Creating', 'Deleting', 'Updating'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets subnet used for the Cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnet")]
        public string Subnet { get; set; }

        /// <summary>
        /// Gets or sets upgrade status of the Cache.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgradeStatus")]
        public CacheUpgradeStatus UpgradeStatus { get; set; }

        /// <summary>
        /// Gets or sets SKU for the Cache.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public CacheSku Sku { get; set; }

    }
}