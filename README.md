[![](https://img.shields.io/nuget/v/Soenneker.Entities.Entity.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Entities.Entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.entities.entity/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.entities.entity/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/Soenneker.Entities.Entity.svg?style=for-the-badge)](https://www.nuget.org/packages/Soenneker.Entities.Entity/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.entities.entity/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.entities.entity/actions/workflows/codeql.yml)

# Soenneker.Entities.Entity

A small domain-entity contract and base class containing a string identifier plus creation and modification timestamps. It has no persistence-framework dependency.

## Install

```bash
dotnet add package Soenneker.Entities.Entity
```

## Derive an entity

```csharp
using Soenneker.Entities.Entity;

public sealed class Order : Entity
{
    public required string CustomerId { get; set; }
    public decimal Total { get; set; }
}

var now = DateTimeOffset.UtcNow;

var order = new Order
{
    Id = Guid.NewGuid().ToString("N"),
    CustomerId = "customer-42",
    Total = 125.00m,
    CreatedAt = now
};

order.Total = 140.00m;
order.ModifiedAt = DateTimeOffset.UtcNow;
```

Use `IEntity` when a domain type already has another base class; derive from `Entity` when the supplied virtual properties are convenient.

## Behavior

- `Id` has no enforced format. A GUID, database identifier, or composite `partitionKey:documentId` string is an application convention.
- `CreatedAt` defaults to `DateTimeOffset.MinValue` unless assigned.
- `ModifiedAt` defaults to null.
- The package does not generate identifiers, update timestamps, track changes, enforce optimistic concurrency, or map entities to database documents.

The JSON property names are `id`, `createdAt`, and `modifiedAt` with both `System.Text.Json` and Newtonsoft.Json. Null omission is controlled by the serializer settings; `ModifiedAt = null` is not automatically omitted by this package.
