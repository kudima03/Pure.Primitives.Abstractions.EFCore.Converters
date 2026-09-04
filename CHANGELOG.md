# Changelog

All notable changes to Pure.Primitives.Abstractions.EFCore.Converters are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.0.1.2] — 2026-05-20

### Changed

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.1.1] — 2026-05-16

### Changed

- Maintenance release: dependency and build updates.

## [0.1.0-preview.0.1.0] — 2026-02-12

### Added

- EF Core `ValueConverter` implementations mapping `Pure.Primitives.Abstractions`
  interfaces to their underlying .NET primitive types, for use with
  `Microsoft.EntityFrameworkCore`:
  - **`BoolTypeConverter`** — `IBool` ↔ `bool`.
  - **`CharTypeConverter`** — `IChar` ↔ `char`.
  - **`DateTypeConverter`** — `IDate` ↔ `DateOnly`.
  - **`DateTimeTypeConverter`** — `IDateTime` ↔ `System.DateTime`.
  - **`DayOfWeekTypeConverter`** — `IDayOfWeek` ↔ `System.DayOfWeek`.
  - **`DecimalTypeConverter`** — `INumber<decimal>` ↔ `decimal`.
  - **`DoubleTypeConverter`** — `INumber<double>` ↔ `double`.
  - **`FloatTypeConverter`** — `INumber<float>` ↔ `float`.
  - **`GuidTypeConverter`** — `IGuid` ↔ `System.Guid`.
  - **`IntTypeConverter`** — `INumber<int>` ↔ `int`.
  - **`LongTypeConverter`** — `INumber<long>` ↔ `long`.
  - **`ShortTypeConverter`** — `INumber<short>` ↔ `short`.
  - **`StringTypeConverter`** — `IString` ↔ `string`.
  - **`TimeTypeConverter`** — `ITime` ↔ `TimeOnly`.
  - **`UIntTypeConverter`** — `INumber<uint>` ↔ `uint`.
  - **`ULongTypeConverter`** — `INumber<ulong>` ↔ `ulong`.
  - **`UShortTypeConverter`** — `INumber<ushort>` ↔ `ushort`.
- Package targets `net7.0`, `net8.0`, `net9.0`, and `net10.0`, depending on
  `Pure.Primitives` and `Microsoft.EntityFrameworkCore`.
