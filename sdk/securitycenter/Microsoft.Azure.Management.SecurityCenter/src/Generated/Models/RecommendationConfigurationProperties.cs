// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The type of IoT Security recommendation.
    /// </summary>
    public partial class RecommendationConfigurationProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RecommendationConfigurationProperties class.
        /// </summary>
        public RecommendationConfigurationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RecommendationConfigurationProperties class.
        /// </summary>
        /// <param name="recommendationType">The type of IoT Security
        /// recommendation. Possible values include: 'IoT_ACRAuthentication',
        /// 'IoT_AgentSendsUnutilizedMessages', 'IoT_Baseline',
        /// 'IoT_EdgeHubMemOptimize', 'IoT_EdgeLoggingOptions',
        /// 'IoT_InconsistentModuleSettings', 'IoT_InstallAgent',
        /// 'IoT_IPFilter_DenyAll', 'IoT_IPFilter_PermissiveRule',
        /// 'IoT_OpenPorts', 'IoT_PermissiveFirewallPolicy',
        /// 'IoT_PermissiveInputFirewallRules',
        /// 'IoT_PermissiveOutputFirewallRules', 'IoT_PrivilegedDockerOptions',
        /// 'IoT_SharedCredentials', 'IoT_VulnerableTLSCipherSuite'</param>
        /// <param name="status">Recommendation status. When the recommendation
        /// status is disabled recommendations are not generated. Possible
        /// values include: 'Disabled', 'Enabled'</param>
        public RecommendationConfigurationProperties(string recommendationType, string status, string name = default(string))
        {
            RecommendationType = recommendationType;
            Name = name;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of IoT Security recommendation. Possible
        /// values include: 'IoT_ACRAuthentication',
        /// 'IoT_AgentSendsUnutilizedMessages', 'IoT_Baseline',
        /// 'IoT_EdgeHubMemOptimize', 'IoT_EdgeLoggingOptions',
        /// 'IoT_InconsistentModuleSettings', 'IoT_InstallAgent',
        /// 'IoT_IPFilter_DenyAll', 'IoT_IPFilter_PermissiveRule',
        /// 'IoT_OpenPorts', 'IoT_PermissiveFirewallPolicy',
        /// 'IoT_PermissiveInputFirewallRules',
        /// 'IoT_PermissiveOutputFirewallRules', 'IoT_PrivilegedDockerOptions',
        /// 'IoT_SharedCredentials', 'IoT_VulnerableTLSCipherSuite'
        /// </summary>
        [JsonProperty(PropertyName = "recommendationType")]
        public string RecommendationType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets recommendation status. When the recommendation status
        /// is disabled recommendations are not generated. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecommendationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecommendationType");
            }
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
        }
    }
}
