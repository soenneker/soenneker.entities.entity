using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Entities.Entity.Abstract;

namespace Soenneker.Entities.Entity;

/// <inheritdoc cref="IEntity"/>
public abstract class Entity : IEntity
{
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public virtual string Id { get; set; } = default!;

    [JsonPropertyName("createdAt")]
    [JsonProperty("createdAt")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    [JsonProperty("modifiedAt")]
    public DateTime? ModifiedAt { get; set; }
}