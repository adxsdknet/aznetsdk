// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Phraselist Feature.
    /// </summary>
    public partial class PhraseListFeatureInfo : FeatureInfoObject
    {
        /// <summary>
        /// Initializes a new instance of the PhraseListFeatureInfo class.
        /// </summary>
        public PhraseListFeatureInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PhraseListFeatureInfo class.
        /// </summary>
        /// <param name="id">A six-digit ID used for Features.</param>
        /// <param name="name">The name of the Feature.</param>
        /// <param name="isActive">Indicates if the feature is enabled.</param>
        /// <param name="phrases">A list of comma-separated values.</param>
        /// <param name="isExchangeable">An exchangeable phrase list feature
        /// are serves as single feature to the LUIS underlying training
        /// algorithm. It is used as a lexicon lookup feature where its value
        /// is 1 if the lexicon contains a given word or 0 if it doesn’t. Think
        /// of an exchangeable as a synonyms list. A non-exchangeable phrase
        /// list feature has all the phrases in the list serve as separate
        /// features to the underlying training algorithm. So, if you your
        /// phrase list feature contains 5 phrases, they will be mapped to 5
        /// separate features. You can think of the non-exchangeable phrase
        /// list feature as an additional bag of words that you are willing to
        /// add to LUIS existing vocabulary features. Think of a
        /// non-exchangeable as set of different words. Default value is
        /// true.</param>
        public PhraseListFeatureInfo(int? id = default(int?), string name = default(string), bool? isActive = default(bool?), string phrases = default(string), bool? isExchangeable = default(bool?))
            : base(id, name, isActive)
        {
            Phrases = phrases;
            IsExchangeable = isExchangeable;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a list of comma-separated values.
        /// </summary>
        [JsonProperty(PropertyName = "phrases")]
        public string Phrases { get; set; }

        /// <summary>
        /// Gets or sets an exchangeable phrase list feature are serves as
        /// single feature to the LUIS underlying training algorithm. It is
        /// used as a lexicon lookup feature where its value is 1 if the
        /// lexicon contains a given word or 0 if it doesn’t. Think of an
        /// exchangeable as a synonyms list. A non-exchangeable phrase list
        /// feature has all the phrases in the list serve as separate features
        /// to the underlying training algorithm. So, if you your phrase list
        /// feature contains 5 phrases, they will be mapped to 5 separate
        /// features. You can think of the non-exchangeable phrase list feature
        /// as an additional bag of words that you are willing to add to LUIS
        /// existing vocabulary features. Think of a non-exchangeable as set of
        /// different words. Default value is true.
        /// </summary>
        [JsonProperty(PropertyName = "isExchangeable")]
        public bool? IsExchangeable { get; set; }

    }
}
