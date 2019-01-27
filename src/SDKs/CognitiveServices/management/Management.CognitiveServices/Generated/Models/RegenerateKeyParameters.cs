// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CognitiveServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Regenerate key parameters.
    /// </summary>
    public partial class RegenerateKeyParameters
    {
        /// <summary>
        /// Initializes a new instance of the RegenerateKeyParameters class.
        /// </summary>
        public RegenerateKeyParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegenerateKeyParameters class.
        /// </summary>
        /// <param name="keyName">key name to generate (Key1|Key2). Possible
        /// values include: 'Key1', 'Key2'</param>
        public RegenerateKeyParameters(KeyName keyName)
        {
            KeyName = keyName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets key name to generate (Key1|Key2). Possible values
        /// include: 'Key1', 'Key2'
        /// </summary>
        [JsonProperty(PropertyName = "keyName")]
        public KeyName KeyName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
