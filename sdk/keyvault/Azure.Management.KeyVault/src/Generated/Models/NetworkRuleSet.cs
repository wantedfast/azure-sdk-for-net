// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.KeyVault.Models
{
    /// <summary> A set of rules governing the network accessibility of a vault. </summary>
    public partial class NetworkRuleSet
    {
        /// <summary> Initializes a new instance of NetworkRuleSet. </summary>
        public NetworkRuleSet()
        {
        }

        /// <summary> Initializes a new instance of NetworkRuleSet. </summary>
        /// <param name="bypass"> Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the default is &apos;AzureServices&apos;. </param>
        /// <param name="defaultAction"> The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after the bypass property has been evaluated. </param>
        /// <param name="ipRules"> The list of IP address rules. </param>
        /// <param name="virtualNetworkRules"> The list of virtual network rules. </param>
        internal NetworkRuleSet(NetworkRuleBypassOptions? bypass, NetworkRuleAction? defaultAction, IList<IPRule> ipRules, IList<VirtualNetworkRule> virtualNetworkRules)
        {
            Bypass = bypass;
            DefaultAction = defaultAction;
            IpRules = ipRules;
            VirtualNetworkRules = virtualNetworkRules;
        }

        /// <summary> Tells what traffic can bypass network rules. This can be &apos;AzureServices&apos; or &apos;None&apos;.  If not specified the default is &apos;AzureServices&apos;. </summary>
        public NetworkRuleBypassOptions? Bypass { get; set; }
        /// <summary> The default action when no rule from ipRules and from virtualNetworkRules match. This is only used after the bypass property has been evaluated. </summary>
        public NetworkRuleAction? DefaultAction { get; set; }
        /// <summary> The list of IP address rules. </summary>
        public IList<IPRule> IpRules { get; set; }
        /// <summary> The list of virtual network rules. </summary>
        public IList<VirtualNetworkRule> VirtualNetworkRules { get; set; }
    }
}
