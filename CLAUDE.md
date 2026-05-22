# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

All `dotnet` commands must be run from the `./src` directory.

```bash
dotnet restore
dotnet build --no-restore -warnaserror
dotnet format --verify-no-changes             # check code style (CI enforces this)
dotnet format                                 # auto-fix code style
dotnet test --no-build --verbosity normal     # run xUnit tests
dotnet pack --configuration Release -p:PackageVersion=<version> --output .
```

## Architecture

This is a **value converter library** for Entity Framework Core — no domain logic, no abstractions, just converters. Each file defines exactly one `sealed` converter class inheriting from `ValueConverter<TModel, TProvider>`.

**Converter pattern:** Each converter takes a Pure.Primitives interface as the model type and maps it to the corresponding .NET primitive. The constructor delegates construction of the model type to the concrete implementation in `Pure.Primitives` (e.g. `new Primitives.Number.Int(x)`).

**Multi-targeting:** net7.0, net8.0, net9.0, net10.0. The `Microsoft.EntityFrameworkCore` version is framework-conditional (7.0.20 / 8.0.24 / 9.0.13 / 10.0.3). All converters must remain AOT-compatible (`IsAotCompatible = true`).

**Package validation:** `EnablePackageValidation = true` with `PackageValidationBaselineVersion = 0.1.0-preview.0.1.2`. Breaking API changes fail the build.

**Tests:** xUnit test project under `./src/Tests/`, targeting net10.0 only.

**Publishing:** triggered by pushing a semver tag (e.g. `1.0.0`). The tag becomes the `PackageVersion`.

## Code Style

Enforced via `.editorconfig` and `dotnet format --verify-no-changes` in CI:

- No `var` — always use explicit types
- No expression-bodied methods, constructors, or operators; expression-bodied properties and accessors are required
- Always declare explicit accessibility modifiers
- `readonly` required on fields that are never reassigned
- Parentheses required in all binary operator expressions for clarity
- No `this.` qualification

## Commit Messages

Do not mention Claude or AI assistance in commit messages.
