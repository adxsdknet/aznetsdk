// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Properties for plan on a custom image.
    /// </summary>
    public partial class CustomImagePropertiesFromPlan
    {
        /// <summary>
        /// Initializes a new instance of the CustomImagePropertiesFromPlan
        /// class.
        /// </summary>
        public CustomImagePropertiesFromPlan()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomImagePropertiesFromPlan
        /// class.
        /// </summary>
        /// <param name="id">The id of the plan, equivalent to name of the
        /// plan</param>
        /// <param name="publisher">The publisher for the plan from the
        /// marketplace image the custom image is derived from</param>
        /// <param name="offer">The offer for the plan from the marketplace
        /// image the custom image is derived from</param>
        public CustomImagePropertiesFromPlan(string id = default(string), string publisher = default(string), string offer = default(string))
        {
            Id = id;
            Publisher = publisher;
            Offer = offer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the plan, equivalent to name of the plan
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the publisher for the plan from the marketplace image
        /// the custom image is derived from
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        public string Publisher { get; set; }

        /// <summary>
        /// Gets or sets the offer for the plan from the marketplace image the
        /// custom image is derived from
        /// </summary>
        [JsonProperty(PropertyName = "offer")]
        public string Offer { get; set; }

    }
}
