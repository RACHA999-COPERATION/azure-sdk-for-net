// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The swagger custom dynamic schema.
    /// </summary>
    public partial class SwaggerCustomDynamicSchema
    {
        /// <summary>
        /// Initializes a new instance of the SwaggerCustomDynamicSchema class.
        /// </summary>
        public SwaggerCustomDynamicSchema()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SwaggerCustomDynamicSchema class.
        /// </summary>
        /// <param name="operationId">The operation id to fetch dynamic
        /// schema.</param>
        /// <param name="valuePath">Json pointer to the dynamic schema on the
        /// response body.</param>
        /// <param name="parameters">The operation parameters.</param>
        public SwaggerCustomDynamicSchema(string operationId = default(string), string valuePath = default(string), IDictionary<string, object> parameters = default(IDictionary<string, object>))
        {
            OperationId = operationId;
            ValuePath = valuePath;
            Parameters = parameters;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the operation id to fetch dynamic schema.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Gets or sets json pointer to the dynamic schema on the response
        /// body.
        /// </summary>
        [JsonProperty(PropertyName = "valuePath")]
        public string ValuePath { get; set; }

        /// <summary>
        /// Gets or sets the operation parameters.
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, object> Parameters { get; set; }

    }
}