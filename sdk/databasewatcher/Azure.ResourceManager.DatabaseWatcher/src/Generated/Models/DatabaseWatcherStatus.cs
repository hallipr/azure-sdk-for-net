// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DatabaseWatcher.Models
{
    /// <summary> The monitoring collection status of a watcher. </summary>
    public readonly partial struct DatabaseWatcherStatus : IEquatable<DatabaseWatcherStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatabaseWatcherStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatabaseWatcherStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StartingValue = "Starting";
        private const string RunningValue = "Running";
        private const string StoppingValue = "Stopping";
        private const string StoppedValue = "Stopped";
        private const string DeletingValue = "Deleting";

        /// <summary> Denotes the watcher is in a starting state. </summary>
        public static DatabaseWatcherStatus Starting { get; } = new DatabaseWatcherStatus(StartingValue);
        /// <summary> Denotes the watcher is in a running state. </summary>
        public static DatabaseWatcherStatus Running { get; } = new DatabaseWatcherStatus(RunningValue);
        /// <summary> Denotes the watcher is in a stopping state. </summary>
        public static DatabaseWatcherStatus Stopping { get; } = new DatabaseWatcherStatus(StoppingValue);
        /// <summary> Denotes the watcher is in a stopped state. </summary>
        public static DatabaseWatcherStatus Stopped { get; } = new DatabaseWatcherStatus(StoppedValue);
        /// <summary> Denotes the watcher is in a deleting state. </summary>
        public static DatabaseWatcherStatus Deleting { get; } = new DatabaseWatcherStatus(DeletingValue);
        /// <summary> Determines if two <see cref="DatabaseWatcherStatus"/> values are the same. </summary>
        public static bool operator ==(DatabaseWatcherStatus left, DatabaseWatcherStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatabaseWatcherStatus"/> values are not the same. </summary>
        public static bool operator !=(DatabaseWatcherStatus left, DatabaseWatcherStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DatabaseWatcherStatus"/>. </summary>
        public static implicit operator DatabaseWatcherStatus(string value) => new DatabaseWatcherStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatabaseWatcherStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatabaseWatcherStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
