// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Synapse.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Managed integration runtime status.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Managed")]
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedIntegrationRuntimeStatus : IntegrationRuntimeStatus
    {
        /// <summary>
        /// Initializes a new instance of the ManagedIntegrationRuntimeStatus
        /// class.
        /// </summary>
        public ManagedIntegrationRuntimeStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedIntegrationRuntimeStatus
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="dataFactoryName">The workspace name which the
        /// integration runtime belong to.</param>
        /// <param name="state">The state of integration runtime. Possible
        /// values include: 'Initial', 'Stopped', 'Started', 'Starting',
        /// 'Stopping', 'NeedRegistration', 'Online', 'Limited', 'Offline',
        /// 'AccessDenied'</param>
        /// <param name="createTime">The time at which the integration runtime
        /// was created, in ISO8601 format.</param>
        /// <param name="nodes">The list of nodes for managed integration
        /// runtime.</param>
        /// <param name="otherErrors">The errors that occurred on this
        /// integration runtime.</param>
        /// <param name="lastOperation">The last operation result that occurred
        /// on this integration runtime.</param>
        public ManagedIntegrationRuntimeStatus(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string dataFactoryName = default(string), string state = default(string), System.DateTime? createTime = default(System.DateTime?), IList<ManagedIntegrationRuntimeNode> nodes = default(IList<ManagedIntegrationRuntimeNode>), IList<ManagedIntegrationRuntimeError> otherErrors = default(IList<ManagedIntegrationRuntimeError>), ManagedIntegrationRuntimeOperationResult lastOperation = default(ManagedIntegrationRuntimeOperationResult))
            : base(additionalProperties, dataFactoryName, state)
        {
            CreateTime = createTime;
            Nodes = nodes;
            OtherErrors = otherErrors;
            LastOperation = lastOperation;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the time at which the integration runtime was created, in
        /// ISO8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.createTime")]
        public System.DateTime? CreateTime { get; private set; }

        /// <summary>
        /// Gets the list of nodes for managed integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.nodes")]
        public IList<ManagedIntegrationRuntimeNode> Nodes { get; private set; }

        /// <summary>
        /// Gets the errors that occurred on this integration runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.otherErrors")]
        public IList<ManagedIntegrationRuntimeError> OtherErrors { get; private set; }

        /// <summary>
        /// Gets the last operation result that occurred on this integration
        /// runtime.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.lastOperation")]
        public ManagedIntegrationRuntimeOperationResult LastOperation { get; private set; }

    }
}
