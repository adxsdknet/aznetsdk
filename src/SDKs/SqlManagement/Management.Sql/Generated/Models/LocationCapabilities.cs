// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The location capability.
    /// </summary>
    public partial class LocationCapabilities
    {
        /// <summary>
        /// Initializes a new instance of the LocationCapabilities class.
        /// </summary>
        public LocationCapabilities()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationCapabilities class.
        /// </summary>
        /// <param name="name">The location name.</param>
        /// <param name="supportedServerVersions">The list of supported server
        /// versions.</param>
        /// <param name="supportedManagedInstanceVersions">The list of
        /// supported managed instance versions.</param>
        /// <param name="status">The status of the capability. Possible values
        /// include: 'Visible', 'Available', 'Default', 'Disabled'</param>
        /// <param name="reason">The reason for the capability not being
        /// available.</param>
        public LocationCapabilities(string name = default(string), IList<ServerVersionCapability> supportedServerVersions = default(IList<ServerVersionCapability>), IList<ManagedInstanceVersionCapability> supportedManagedInstanceVersions = default(IList<ManagedInstanceVersionCapability>), CapabilityStatus? status = default(CapabilityStatus?), string reason = default(string))
        {
            Name = name;
            SupportedServerVersions = supportedServerVersions;
            SupportedManagedInstanceVersions = supportedManagedInstanceVersions;
            Status = status;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the location name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the list of supported server versions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedServerVersions")]
        public IList<ServerVersionCapability> SupportedServerVersions { get; private set; }

        /// <summary>
        /// Gets the list of supported managed instance versions.
        /// </summary>
        [JsonProperty(PropertyName = "supportedManagedInstanceVersions")]
        public IList<ManagedInstanceVersionCapability> SupportedManagedInstanceVersions { get; private set; }

        /// <summary>
        /// Gets the status of the capability. Possible values include:
        /// 'Visible', 'Available', 'Default', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public CapabilityStatus? Status { get; private set; }

        /// <summary>
        /// Gets or sets the reason for the capability not being available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
