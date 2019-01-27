// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Definition of the activity parameter validation set.
    /// </summary>
    public partial class ActivityParameterValidationSet
    {
        /// <summary>
        /// Initializes a new instance of the ActivityParameterValidationSet
        /// class.
        /// </summary>
        public ActivityParameterValidationSet()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActivityParameterValidationSet
        /// class.
        /// </summary>
        /// <param name="memberValue">Gets or sets the name of the activity
        /// parameter validation set member.</param>
        public ActivityParameterValidationSet(string memberValue = default(string))
        {
            MemberValue = memberValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the activity parameter validation set
        /// member.
        /// </summary>
        [JsonProperty(PropertyName = "memberValue")]
        public string MemberValue { get; set; }

    }
}
