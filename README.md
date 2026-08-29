[![](https://img.shields.io/nuget/v/Soenneker.Entities.Entity.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Entities.Entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.entities.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.entities.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Entities.Entity.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Entities.Entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.entities.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.entities.entity/actions/workflows/codeql.yml)

# Soenneker.Entities.Entity

The domain driven object at the heart of all operations. This derives from nothing. It mostly exists within the managers, and gets converted to/from a response in the coordinator. It CAN be converted into a document within the managers, but it's existence doesn't require it. It should be attempted to be the object where business logic is operated on, unless it's not pragmatic to adapt. Documentation should be on the Entity's interface properties, referencing them from the document object. Essentially provides only `Id`, `CreatedAt`, `ModifiedAt`.

## Install

```bash
dotnet add package Soenneker.Entities.Entity
```

## What you get

- `IEntity` — The domain driven object at the heart of all operations. This derives from nothing. It mostly exists within the managers, and gets converted to/from a response in the coordinator. It CAN be converted into a document within the managers, but it's existence doesn't require it. It should be attempted to be the object where business logic is operated on, unless it's not pragmatic to adapt. Documentation should be on the Entity's interface properties, referencing them from the document object. Essentially provides only `Id`, `CreatedAt`, `ModifiedAt`.

## API at a glance

| API | What it does | Result / important behavior |
| --- | --- | --- |
| `IEntity.Id` | PartitionKey:DocumentId construction... Can be overriden. | unless Partition Key and Document Id are the same, then this should only be one GUID. |
| `IEntity.CreatedAt` | This should only be set when creating the entity; it's never updated. | This should only be set when creating the entity; it's never updated. |
| `IEntity.ModifiedAt` | This field is meant to be changed to DateTimeOffset.UtcNow whenever the entity has changed. If the child document has changed the parent's ModifiedAt should also be changed. If this entity has never been modified, this will be null (and not serialized). | This field is meant to be changed to DateTimeOffset.UtcNow whenever the entity has changed. If the child document has changed the parent's ModifiedAt should also be changed. If this entity has never been modified, this will be null (and not serialized). |

## Important behavior

- `IEntity.Id`: unless Partition Key and Document Id are the same, then this should only be one GUID.
