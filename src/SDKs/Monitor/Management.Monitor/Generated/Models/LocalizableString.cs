// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The localizable string class.
    /// </summary>
    public partial class LocalizableString
    {
        /// <summary>
        /// Initializes a new instance of the LocalizableString class.
        /// </summary>
        public LocalizableString()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocalizableString class.
        /// </summary>
        /// <param name="value">the invariant value.</param>
        /// <param name="localizedValue">the locale specific value.</param>
        public LocalizableString(string value, string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the invariant value.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the locale specific value.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
