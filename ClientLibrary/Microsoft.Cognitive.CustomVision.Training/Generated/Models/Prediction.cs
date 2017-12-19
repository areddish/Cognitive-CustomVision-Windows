// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Cognitive.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// result of an image classification request
    /// </summary>
    public partial class Prediction
    {
        /// <summary>
        /// Initializes a new instance of the Prediction class.
        /// </summary>
        public Prediction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Prediction class.
        /// </summary>
        public Prediction(System.Guid id = default(System.Guid), System.Guid project = default(System.Guid), System.Guid iteration = default(System.Guid), System.DateTime created = default(System.DateTime), IList<PredictionTag> predictions = default(IList<PredictionTag>), string imageUri = default(string), string thumbnailUri = default(string))
        {
            Id = id;
            Project = project;
            Iteration = iteration;
            Created = created;
            Predictions = predictions;
            ImageUri = imageUri;
            ThumbnailUri = thumbnailUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Project")]
        public System.Guid Project { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Iteration")]
        public System.Guid Iteration { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Predictions")]
        public IList<PredictionTag> Predictions { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ImageUri")]
        public string ImageUri { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ThumbnailUri")]
        public string ThumbnailUri { get; private set; }

    }
}
