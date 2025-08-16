using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Soenneker.Entities.Entity.Abstract;

namespace Soenneker.Entities.Entity;

/// <inheritdoc cref="IEntity"/>
public class Entity : IEntity
{
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    public virtual string Id { get; set; } = null!;

    [JsonPropertyName("createdAt")]
    [JsonProperty("createdAt")]
    public virtual DateTime CreatedAt { get; set; }

    [JsonPropertyName("modifiedAt")]
    [JsonProperty("modifiedAt")]
    public virtual DateTime? ModifiedAt { get; set; }
}