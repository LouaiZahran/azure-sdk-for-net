// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Azure Networking ACL Action. </summary>
    public readonly partial struct ACLAction : IEquatable<ACLAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ACLAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ACLAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AllowValue = "Allow";
        private const string DenyValue = "Deny";

        /// <summary> Allow. </summary>
        public static ACLAction Allow { get; } = new ACLAction(AllowValue);
        /// <summary> Deny. </summary>
        public static ACLAction Deny { get; } = new ACLAction(DenyValue);
        /// <summary> Determines if two <see cref="ACLAction"/> values are the same. </summary>
        public static bool operator ==(ACLAction left, ACLAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ACLAction"/> values are not the same. </summary>
        public static bool operator !=(ACLAction left, ACLAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ACLAction"/>. </summary>
        public static implicit operator ACLAction(string value) => new ACLAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ACLAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ACLAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
