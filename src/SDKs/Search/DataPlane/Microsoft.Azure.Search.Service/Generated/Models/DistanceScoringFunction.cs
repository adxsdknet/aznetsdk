// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a function that boosts scores based on distance from a
    /// geographic location.
    /// <see
    /// href="https://docs.microsoft.com/rest/api/searchservice/Add-scoring-profiles-to-a-search-index"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("distance")]
    public partial class DistanceScoringFunction : ScoringFunction
    {
        /// <summary>
        /// Initializes a new instance of the DistanceScoringFunction class.
        /// </summary>
        public DistanceScoringFunction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DistanceScoringFunction class.
        /// </summary>
        /// <param name="fieldName">The name of the field used as input to the
        /// scoring function.</param>
        /// <param name="boost">A multiplier for the raw score. Must be a
        /// positive number not equal to 1.0.</param>
        /// <param name="parameters">Parameter values for the distance scoring
        /// function.</param>
        /// <param name="interpolation">A value indicating how boosting will be
        /// interpolated across document scores; defaults to "Linear". Possible
        /// values include: 'linear', 'constant', 'quadratic',
        /// 'logarithmic'</param>
        public DistanceScoringFunction(string fieldName, double boost, DistanceScoringParameters parameters, ScoringFunctionInterpolation? interpolation = default(ScoringFunctionInterpolation?))
            : base(fieldName, boost, interpolation)
        {
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter values for the distance scoring function.
        /// </summary>
        [JsonProperty(PropertyName = "distance")]
        public DistanceScoringParameters Parameters { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Parameters == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Parameters");
            }
            if (Parameters != null)
            {
                Parameters.Validate();
            }
        }
    }
}
