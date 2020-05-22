// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Network rule collection resource. </summary>
    public partial class AzureFirewallNetworkRuleCollection : SubResource
    {
        /// <summary> Initializes a new instance of AzureFirewallNetworkRuleCollection. </summary>
        public AzureFirewallNetworkRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of AzureFirewallNetworkRuleCollection. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within the Azure firewall. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the network rule collection resource. </param>
        /// <param name="action"> The action type of a rule collection. </param>
        /// <param name="rules"> Collection of rules used by a network rule collection. </param>
        /// <param name="provisioningState"> The provisioning state of the network rule collection resource. </param>
        internal AzureFirewallNetworkRuleCollection(string id, string name, string etag, int? priority, AzureFirewallRCAction action, IList<AzureFirewallNetworkRule> rules, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Priority = priority;
            Action = action;
            Rules = rules;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within the Azure firewall. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Priority of the network rule collection resource. </summary>
        public int? Priority { get; set; }
        /// <summary> The action type of a rule collection. </summary>
        public AzureFirewallRCAction Action { get; set; }
        /// <summary> Collection of rules used by a network rule collection. </summary>
        public IList<AzureFirewallNetworkRule> Rules { get; set; }
        /// <summary> The provisioning state of the network rule collection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
