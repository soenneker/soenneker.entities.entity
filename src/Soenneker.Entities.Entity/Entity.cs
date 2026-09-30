using System;
using System.Text.Json.Serialization;
using Soenneker.Entities.Entity.Abstract;

namespace Soenneker.Entities.Entity;

/// <inheritdoc cref="IEntity" />
public class Entity : IEntity
{
    [JsonPropertyName("id")]
    public virtual string Id { get; set; } = null!;

    [JsonPropertyName("createdAt")]
    public virtual DateTimeOffset CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    public virtual DateTimeOffset? ModifiedAt { get; set; }
}
