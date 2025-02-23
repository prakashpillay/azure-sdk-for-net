// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    /// <summary> Indicates when new cluster runtime version upgrades will be applied after they are released. By default is Wave0. </summary>
    public readonly partial struct ClusterUpgradeCadence : IEquatable<ClusterUpgradeCadence>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClusterUpgradeCadence"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClusterUpgradeCadence(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Wave0Value = "Wave0";
        private const string Wave1Value = "Wave1";
        private const string Wave2Value = "Wave2";

        /// <summary> Cluster upgrade starts immediately after a new version is rolled out. Recommended for Test/Dev clusters. </summary>
        public static ClusterUpgradeCadence Wave0 { get; } = new ClusterUpgradeCadence(Wave0Value);
        /// <summary> Cluster upgrade starts 7 days after a new version is rolled out. Recommended for Pre-prod clusters. </summary>
        public static ClusterUpgradeCadence Wave1 { get; } = new ClusterUpgradeCadence(Wave1Value);
        /// <summary> Cluster upgrade starts 14 days after a new version is rolled out. Recommended for Production clusters. </summary>
        public static ClusterUpgradeCadence Wave2 { get; } = new ClusterUpgradeCadence(Wave2Value);
        /// <summary> Determines if two <see cref="ClusterUpgradeCadence"/> values are the same. </summary>
        public static bool operator ==(ClusterUpgradeCadence left, ClusterUpgradeCadence right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClusterUpgradeCadence"/> values are not the same. </summary>
        public static bool operator !=(ClusterUpgradeCadence left, ClusterUpgradeCadence right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClusterUpgradeCadence"/>. </summary>
        public static implicit operator ClusterUpgradeCadence(string value) => new ClusterUpgradeCadence(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClusterUpgradeCadence other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClusterUpgradeCadence other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
