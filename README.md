# Pure.Primitives.Abstractions.EFCore.Converters

EFCore `ValueConverter` implementations for **Pure.Primitives** types — map Pure primitive abstractions to their underlying .NET types for database storage.

[![.NET build & test](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.Converters/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.Converters/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.Converters/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Primitives.Abstractions.EFCore.Converters/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Primitives.Abstractions.EFCore.Converters)](https://www.nuget.org/packages/Pure.Primitives.Abstractions.EFCore.Converters)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE.txt)

## Overview

`Pure.Primitives.Abstractions.EFCore.Converters` provides `ValueConverter<TModel, TProvider>` implementations for every type in the [`Pure.Primitives`](https://github.com/kudima03/Pure.Primitives) ecosystem. Each converter maps a Pure interface (e.g. `INumber<int>`, `IString`, `IDate`) to its corresponding .NET primitive (e.g. `int`, `string`, `DateOnly`) so that Entity Framework Core can persist Pure-typed domain properties without manual conversion.

## Converters

### Numeric

| Converter | Model type | Provider type |
|-----------|------------|---------------|
| `IntTypeConverter` | `INumber<int>` | `int` |
| `LongTypeConverter` | `INumber<long>` | `long` |
| `ShortTypeConverter` | `INumber<short>` | `short` |
| `UIntTypeConverter` | `INumber<uint>` | `uint` |
| `ULongTypeConverter` | `INumber<ulong>` | `ulong` |
| `UShortTypeConverter` | `INumber<ushort>` | `ushort` |
| `FloatTypeConverter` | `INumber<float>` | `float` |
| `DoubleTypeConverter` | `INumber<double>` | `double` |
| `DecimalTypeConverter` | `INumber<decimal>` | `decimal` |

### Other primitives

| Converter | Model type | Provider type |
|-----------|------------|---------------|
| `StringTypeConverter` | `IString` | `string` |
| `BoolTypeConverter` | `IBool` | `bool` |
| `CharTypeConverter` | `IChar` | `char` |
| `GuidTypeConverter` | `IGuid` | `Guid` |

### Date and time

| Converter | Model type | Provider type |
|-----------|------------|---------------|
| `DateTypeConverter` | `IDate` | `DateOnly` |
| `TimeTypeConverter` | `ITime` | `TimeOnly` |
| `DateTimeTypeConverter` | `IDateTime` | `DateTime` |
| `DayOfWeekTypeConverter` | `IDayOfWeek` | `DayOfWeek` |

All converters are in the `Pure.Primitives.Abstractions.EFCore.Converters` namespace.

## Dependencies

- [`Pure.Primitives`](https://github.com/kudima03/Pure.Primitives/tree/3.6.4) — concrete implementations of `INumber<T>`, `IString`, `IBool`, `IChar`, `IDate`, `ITime`, `IDateTime`, `IGuid`, and `IDayOfWeek`

## Target Frameworks

- .NET 7
- .NET 8
- .NET 9
- .NET 10

## Installation

```shell
dotnet add package Pure.Primitives.Abstractions.EFCore.Converters
```

## Usage

Register converters in your `DbContext.OnModelCreating`:

```csharp
using Pure.Primitives.Abstractions.EFCore.Converters;

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Order>()
        .Property(o => o.Quantity)
        .HasConversion(new IntTypeConverter());

    modelBuilder.Entity<Product>()
        .Property(p => p.Name)
        .HasConversion(new StringTypeConverter());

    modelBuilder.Entity<Event>()
        .Property(e => e.OccurredAt)
        .HasConversion(new DateTimeTypeConverter());
}
```
