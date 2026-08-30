using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Entities.Entity.Abstract;

/// <summary>
/// Defines the identity and audit timestamps shared by domain entities.
/// </summary>
public interface IEntity
{
    /// <summary>
    /// Gets or sets the stable identifier assigned by the application.
    /// </summary>
    /// <remarks>The contract does not enforce an identifier format. Applications may use a simple identifier or a composite convention such as <c>partitionKey:documentId</c>.</remarks>
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    string Id { get; set; }

    /// <summary>
    /// Gets or sets when the entity was created. The application is responsible for assigning and preserving this value.
    /// </summary>
    [JsonPropertyName("createdAt")]
    [JsonProperty("createdAt")]
    DateTimeOffset CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets when the entity was last changed, or <see langword="null"/> when it has not been modified.
    /// </summary>
    /// <remarks>The contract does not update this value automatically. Null serialization follows the configured serializer options.</remarks>
    [JsonPropertyName("modifiedAt")]
    [JsonProperty("modifiedAt")]
    DateTimeOffset? ModifiedAt { get; set; }
}
