// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object describing a face identified in the image.
    /// </summary>
    public partial class FaceDescription
    {
        /// <summary>
        /// Initializes a new instance of the FaceDescription class.
        /// </summary>
        public FaceDescription()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceDescription class.
        /// </summary>
        /// <param name="age">Possible age of the face.</param>
        /// <param name="gender">Possible gender of the face. Possible values
        /// include: 'Male', 'Female'</param>
        /// <param name="faceRectangle">Rectangle in the image containing the
        /// identified face.</param>
        public FaceDescription(int age = default(int), Gender? gender = default(Gender?), FaceRectangle faceRectangle = default(FaceRectangle))
        {
            Age = age;
            Gender = gender;
            FaceRectangle = faceRectangle;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible age of the face.
        /// </summary>
        [JsonProperty(PropertyName = "age")]
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets possible gender of the face. Possible values include:
        /// 'Male', 'Female'
        /// </summary>
        [JsonProperty(PropertyName = "gender")]
        public Gender? Gender { get; set; }

        /// <summary>
        /// Gets or sets rectangle in the image containing the identified face.
        /// </summary>
        [JsonProperty(PropertyName = "faceRectangle")]
        public FaceRectangle FaceRectangle { get; set; }

    }
}
