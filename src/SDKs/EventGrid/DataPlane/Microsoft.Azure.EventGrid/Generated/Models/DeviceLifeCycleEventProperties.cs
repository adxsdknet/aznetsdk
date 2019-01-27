// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a device life
    /// cycle event (DeviceCreated, DeviceDeleted).
    /// </summary>
    public partial class DeviceLifeCycleEventProperties
    {
        /// <summary>
        /// Initializes a new instance of the DeviceLifeCycleEventProperties
        /// class.
        /// </summary>
        public DeviceLifeCycleEventProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeviceLifeCycleEventProperties
        /// class.
        /// </summary>
        /// <param name="deviceId">The unique identifier of the device. This
        /// case-sensitive string can be up to 128 characters long, and
        /// supports ASCII 7-bit alphanumeric characters plus the following
        /// special characters: - : . + % _ &amp;#35; * ? ! ( ) , = @ ; $
        /// '.</param>
        /// <param name="hubName">Name of the IoT Hub where the device was
        /// created or deleted.</param>
        /// <param name="twin">Information about the device twin, which is the
        /// cloud representation of application device metadata.</param>
        public DeviceLifeCycleEventProperties(string deviceId = default(string), string hubName = default(string), DeviceTwinInfo twin = default(DeviceTwinInfo))
        {
            DeviceId = deviceId;
            HubName = hubName;
            Twin = twin;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the unique identifier of the device. This
        /// case-sensitive string can be up to 128 characters long, and
        /// supports ASCII 7-bit alphanumeric characters plus the following
        /// special characters: - : . + % _ &amp;amp;#35; * ? ! ( ) , = @ ; $
        /// '.
        /// </summary>
        [JsonProperty(PropertyName = "deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets name of the IoT Hub where the device was created or
        /// deleted.
        /// </summary>
        [JsonProperty(PropertyName = "hubName")]
        public string HubName { get; set; }

        /// <summary>
        /// Gets or sets information about the device twin, which is the cloud
        /// representation of application device metadata.
        /// </summary>
        [JsonProperty(PropertyName = "twin")]
        public DeviceTwinInfo Twin { get; set; }

    }
}
