// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Models
{

    /// <summary>
    /// Defines values for RecurrenceFrequency.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum RecurrenceFrequency
    {
        [System.Runtime.Serialization.EnumMember(Value = "None")]
        None,
        [System.Runtime.Serialization.EnumMember(Value = "Second")]
        Second,
        [System.Runtime.Serialization.EnumMember(Value = "Minute")]
        Minute,
        [System.Runtime.Serialization.EnumMember(Value = "Hour")]
        Hour,
        [System.Runtime.Serialization.EnumMember(Value = "Day")]
        Day,
        [System.Runtime.Serialization.EnumMember(Value = "Week")]
        Week,
        [System.Runtime.Serialization.EnumMember(Value = "Month")]
        Month,
        [System.Runtime.Serialization.EnumMember(Value = "Year")]
        Year
    }
}
