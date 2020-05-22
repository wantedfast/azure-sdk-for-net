// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections;
using System.Collections.Generic;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> The UserBase. </summary>
    public partial class UserBase : IDictionary<string, object>
    {
        /// <summary> Initializes a new instance of UserBase. </summary>
        public UserBase()
        {
            AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of UserBase. </summary>
        /// <param name="immutableId"> This must be specified if you are using a federated domain for the user&apos;s userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object. </param>
        /// <param name="usageLocation"> A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. Examples include: &quot;US&quot;, &quot;JP&quot;, and &quot;GB&quot;. </param>
        /// <param name="givenName"> The given name for the user. </param>
        /// <param name="surname"> The user&apos;s surname (family name or last name). </param>
        /// <param name="userType"> A string value that can be used to classify user types in your directory, such as &apos;Member&apos; and &apos;Guest&apos;. </param>
        /// <param name="additionalProperties"> . </param>
        internal UserBase(string immutableId, string usageLocation, string givenName, string surname, UserType? userType, IDictionary<string, object> additionalProperties)
        {
            ImmutableId = immutableId;
            UsageLocation = usageLocation;
            GivenName = givenName;
            Surname = surname;
            UserType = userType;
            AdditionalProperties = additionalProperties ?? new Dictionary<string, object>();
        }

        /// <summary> This must be specified if you are using a federated domain for the user&apos;s userPrincipalName (UPN) property when creating a new user account. It is used to associate an on-premises Active Directory user account with their Azure AD user object. </summary>
        public string ImmutableId { get; set; }
        /// <summary> A two letter country code (ISO standard 3166). Required for users that will be assigned licenses due to legal requirement to check for availability of services in countries. Examples include: &quot;US&quot;, &quot;JP&quot;, and &quot;GB&quot;. </summary>
        public string UsageLocation { get; set; }
        /// <summary> The given name for the user. </summary>
        public string GivenName { get; set; }
        /// <summary> The user&apos;s surname (family name or last name). </summary>
        public string Surname { get; set; }
        /// <summary> A string value that can be used to classify user types in your directory, such as &apos;Member&apos; and &apos;Guest&apos;. </summary>
        public UserType? UserType { get; set; }
        internal IDictionary<string, object> AdditionalProperties { get; }
        /// <inheritdoc />
        public IEnumerator<KeyValuePair<string, object>> GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => AdditionalProperties.GetEnumerator();
        /// <inheritdoc />
        public bool TryGetValue(string key, out object value) => AdditionalProperties.TryGetValue(key, out value);
        /// <inheritdoc />
        public bool ContainsKey(string key) => AdditionalProperties.ContainsKey(key);
        /// <inheritdoc />
        public ICollection<string> Keys => AdditionalProperties.Keys;
        /// <inheritdoc />
        public ICollection<object> Values => AdditionalProperties.Values;
        /// <inheritdoc />
        int ICollection<KeyValuePair<string, object>>.Count => AdditionalProperties.Count;
        /// <inheritdoc />
        public void Add(string key, object value) => AdditionalProperties.Add(key, value);
        /// <inheritdoc />
        public bool Remove(string key) => AdditionalProperties.Remove(key);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.IsReadOnly => AdditionalProperties.IsReadOnly;
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> value) => AdditionalProperties.Add(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> value) => AdditionalProperties.Remove(value);
        /// <inheritdoc />
        bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> value) => AdditionalProperties.Contains(value);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] destination, int offset) => AdditionalProperties.CopyTo(destination, offset);
        /// <inheritdoc />
        void ICollection<KeyValuePair<string, object>>.Clear() => AdditionalProperties.Clear();
        /// <inheritdoc />
        public object this[string key]
        {
            get => AdditionalProperties[key];
            set => AdditionalProperties[key] = value;
        }
    }
}
