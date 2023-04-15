using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Soenneker.Entities.Entity.Abstract;

/// <summary>
/// The domain driven object at the heart of all operations. This derives from nothing. <para/>
/// It mostly exists within the managers, and gets converted to/from a response in the coordinator. <para/>
/// It CAN be converted into a document within the managers, but it's existence doesn't require it. <para/>
/// It should be attempted to be the object where business logic is operated on, unless it's not pragmatic to adapt. <para/>
/// Documentation should be on the Entity's interface properties, referencing them from the document object. <para/>
/// Essentially provides only <see cref="Id"/>, <see cref="CreatedAt"/>, <see cref="ModifiedAt"/>
/// </summary>
public interface IEntity
{
    /// <summary>
    /// PartitionKey:DocumentId construction... <para/>
    /// Can be overriden.
    /// </summary>
    /// <remarks>unless Partition Key and Document Id are the same, then this should only be one GUID</remarks>
    [JsonPropertyName("id")]
    [JsonProperty("id")]
    string Id { get; set; }

    /// <summary>
    /// This should only be set when creating the entity; it's never updated
    /// </summary>
    [JsonPropertyName("createdAt")]
    [JsonProperty("createdAt")]
    DateTime CreatedAt { get; set; }

    /// <summary>
    /// This field is meant to be changed to DateTime.UtcNow whenever the entity has changed. <para/>
    /// If the child document has changed the parent's ModifiedAt should also be changed. <para/>
    /// If this entity has never been modified, this will be null (and not serialized)
    /// </summary>
    [JsonPropertyName("modifiedAt")]
    [JsonProperty("modifiedAt")]
    DateTime? ModifiedAt { get; set; }
}