﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Event type: Music event.
    /// </summary>
    public partial interface IMusicEvent : IEvent
    {
    }

    /// <summary>
    /// Event type: Music event.
    /// </summary>
    [DataContract]
    public partial class MusicEvent : Event, IMusicEvent, IEquatable<MusicEvent>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "MusicEvent";

        /// <inheritdoc/>
        public bool Equals(MusicEvent other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return this.Type == other.Type &&
                base.Equals(other);
        }

        /// <inheritdoc/>
        public override bool Equals(object obj) => this.Equals(obj as MusicEvent);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
