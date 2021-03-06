﻿namespace Schema.NET
{
    using System;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// A blog post.
    /// </summary>
    public partial interface IBlogPosting : ISocialMediaPosting
    {
    }

    /// <summary>
    /// A blog post.
    /// </summary>
    [DataContract]
    public partial class BlogPosting : SocialMediaPosting, IBlogPosting, IEquatable<BlogPosting>
    {
        /// <summary>
        /// Gets the name of the type as specified by schema.org.
        /// </summary>
        [DataMember(Name = "@type", Order = 1)]
        public override string Type => "BlogPosting";

        /// <inheritdoc/>
        public bool Equals(BlogPosting other)
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
        public override bool Equals(object obj) => this.Equals(obj as BlogPosting);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Of(this.Type)
            .And(base.GetHashCode());
    }
}
