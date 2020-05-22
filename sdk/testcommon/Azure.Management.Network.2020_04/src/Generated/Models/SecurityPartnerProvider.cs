// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Security Partner Provider resource. </summary>
    public partial class SecurityPartnerProvider : Resource
    {
        /// <summary> Initializes a new instance of SecurityPartnerProvider. </summary>
        public SecurityPartnerProvider()
        {
        }

        /// <summary> Initializes a new instance of SecurityPartnerProvider. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="provisioningState"> The provisioning state of the Security Partner Provider resource. </param>
        /// <param name="securityProviderName"> The security provider name. </param>
        /// <param name="connectionStatus"> The connection status with the Security Partner Provider. </param>
        /// <param name="virtualHub"> The virtualHub to which the Security Partner Provider belongs. </param>
        internal SecurityPartnerProvider(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, ProvisioningState? provisioningState, SecurityProviderName? securityProviderName, SecurityPartnerProviderConnectionStatus? connectionStatus, SubResource virtualHub) : base(id, name, type, location, tags)
        {
            Etag = etag;
            ProvisioningState = provisioningState;
            SecurityProviderName = securityProviderName;
            ConnectionStatus = connectionStatus;
            VirtualHub = virtualHub;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The provisioning state of the Security Partner Provider resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The security provider name. </summary>
        public SecurityProviderName? SecurityProviderName { get; set; }
        /// <summary> The connection status with the Security Partner Provider. </summary>
        public SecurityPartnerProviderConnectionStatus? ConnectionStatus { get; }
        /// <summary> The virtualHub to which the Security Partner Provider belongs. </summary>
        public SubResource VirtualHub { get; set; }
    }
}
