// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.InfrastructureInsights.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Holds information about the health of a service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServiceHealth : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ServiceHealth class.
        /// </summary>
        public ServiceHealth()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServiceHealth class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the
        /// resource</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="location">The Azure Region where the resource
        /// lives</param>
        /// <param name="alertSummary">Alert summary.</param>
        /// <param name="healthState">Health state.</param>
        /// <param name="namespaceProperty">Namespace of the health
        /// resource.</param>
        /// <param name="registrationId">Registration ID.</param>
        /// <param name="routePrefix">Route prefix.</param>
        /// <param name="displayName">Name of the service.</param>
        /// <param name="serviceLocation">Location of the service.</param>
        /// <param name="infraURI">The route prefix to the service.</param>
        public ServiceHealth(string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), AlertSummary alertSummary = default(AlertSummary), string healthState = default(string), string namespaceProperty = default(string), string registrationId = default(string), string routePrefix = default(string), string displayName = default(string), string serviceLocation = default(string), string infraURI = default(string))
            : base(id, name, type, tags, location)
        {
            AlertSummary = alertSummary;
            HealthState = healthState;
            NamespaceProperty = namespaceProperty;
            RegistrationId = registrationId;
            RoutePrefix = routePrefix;
            DisplayName = displayName;
            ServiceLocation = serviceLocation;
            InfraURI = infraURI;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets alert summary.
        /// </summary>
        [JsonProperty(PropertyName = "properties.alertSummary")]
        public AlertSummary AlertSummary { get; set; }

        /// <summary>
        /// Gets or sets health state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.healthState")]
        public string HealthState { get; set; }

        /// <summary>
        /// Gets or sets namespace of the health resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets or sets registration ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.registrationId")]
        public string RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets route prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.routePrefix")]
        public string RoutePrefix { get; set; }

        /// <summary>
        /// Gets or sets name of the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets location of the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serviceLocation")]
        public string ServiceLocation { get; set; }

        /// <summary>
        /// Gets or sets the route prefix to the service.
        /// </summary>
        [JsonProperty(PropertyName = "properties.infraURI")]
        public string InfraURI { get; set; }

    }
}
