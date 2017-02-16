// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Monitor.Models
{
    using System.Linq;

    /// <summary>
    /// Specifies the action to send email when the rule condition is
    /// evaluated. The discriminator is always RuleEmailAction in this case.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Microsoft.Azure.Management.Monitor.Models.RuleEmailAction")]
    public partial class RuleEmailAction : RuleAction
    {
        /// <summary>
        /// Initializes a new instance of the RuleEmailAction class.
        /// </summary>
        public RuleEmailAction() { }

        /// <summary>
        /// Initializes a new instance of the RuleEmailAction class.
        /// </summary>
        /// <param name="sendToServiceOwners">Whether the administrators
        /// (service and co-adiminstrators) of the service should be notified
        /// when the alert is activated.</param>
        /// <param name="customEmails">the list of administrator's custom email
        /// addresses notifiy of the activation of the alert.</param>
        public RuleEmailAction(bool? sendToServiceOwners = default(bool?), System.Collections.Generic.IList<string> customEmails = default(System.Collections.Generic.IList<string>))
        {
            SendToServiceOwners = sendToServiceOwners;
            CustomEmails = customEmails;
        }

        /// <summary>
        /// Gets or sets whether the administrators (service and
        /// co-adiminstrators) of the service should be notified when the alert
        /// is activated.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "sendToServiceOwners")]
        public bool? SendToServiceOwners { get; set; }

        /// <summary>
        /// Gets or sets the list of administrator's custom email addresses
        /// notifiy of the activation of the alert.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "customEmails")]
        public System.Collections.Generic.IList<string> CustomEmails { get; set; }

    }
}
