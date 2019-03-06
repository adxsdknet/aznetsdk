// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.TextAnalytics.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SentimentBatchResultItem
    {
        /// <summary>
        /// Initializes a new instance of the SentimentBatchResultItem class.
        /// </summary>
        public SentimentBatchResultItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SentimentBatchResultItem class.
        /// </summary>
        /// <param name="id">Unique, non-empty document identifier.</param>
        /// <param name="score">A decimal number between 0 and 1 denoting the
        /// sentiment of the document. A score above 0.7 usually refers to a
        /// positive document while a score below 0.3 normally has a negative
        /// connotation. Mid values refer to neutral text.</param>
        /// <param name="statistics">(Optional) if showStats=true was specified
        /// in the request this field will contain information about the
        /// document payload.</param>
        public SentimentBatchResultItem(string id = default(string), double? score = default(double?), DocumentStatistics statistics = default(DocumentStatistics))
        {
            Id = id;
            Score = score;
            Statistics = statistics;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique, non-empty document identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a decimal number between 0 and 1 denoting the
        /// sentiment of the document. A score above 0.7 usually refers to a
        /// positive document while a score below 0.3 normally has a negative
        /// connotation. Mid values refer to neutral text.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

        /// <summary>
        /// Gets or sets (Optional) if showStats=true was specified in the
        /// request this field will contain information about the document
        /// payload.
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public DocumentStatistics Statistics { get; set; }

    }
}
