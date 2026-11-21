# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## What this is

`MahApps.Extra` — a WPF accordion control and `AccordionMenu` for MahApps.Metro, ported from Elysium and themed from the selected MahApps theme. The library is `MahApps.Extra/MahApps.Extra.csproj` (NuGet package and assembly `MahApps.Extra`, depends on `MahApps.Metro`); `MahApps.Extra.Sample/` is the manual verification app. There is no test project.

## Branching

- `development` is the working branch: branch from it and open pull requests into it. Never commit or open a pull request directly against `main`.
- `main` is the release branch. Every push to `main` runs `release.yml`, which publishes the package to nuget.org and creates a GitHub release, so only merge `development` into `main` when a release is intended, and only when asked to release.

## Build

The solution is `MahApps.Extra.sln`. The library multi-targets `net452;net6.0-windows7.0;net8.0-windows7.0;net9.0-windows7.0;net10.0-windows7.0;net11.0-windows7.0`; the sample targets `net10.0-windows;net11.0-windows`. Build with the .NET 10 and .NET 11 SDKs (`global.json` rolls forward to the latest major SDK); on Linux or macOS add `-p:EnableWindowsTargeting=true` (it compiles there but WPF cannot run).

```bash
dotnet build MahApps.Extra.sln -c Release
dotnet run --project MahApps.Extra.Sample/MahApps.Extra.Sample.csproj -f net10.0-windows
```

`GeneratePackageOnBuild` is on, so a build emits the `.nupkg`. The assembly is strong-name signed with `MahApps.Extra/DSoft.snk`; do not remove it. `SuppressTfmSupportBuildWarnings` is set because SourceLink (build time only) pulls in a package that warns on the older target frameworks.

## CI

GitHub Actions (`.github/workflows/`) on `windows-latest`: `ci.yml` builds Release for pull requests into `main` and `development` and publishes nothing. `release.yml` runs on every push to `main` (changes only to Markdown or workflow files are skipped; run it by hand to test a workflow change), builds Release as `3.0.<yyMM>.<run number>` plus `RELEASE_SUFFIX` (empty for a stable version), pushes the package to nuget.org with Trusted Publishing (OIDC, `NUGET_USER` secret, `nuget` environment), then tags the commit `v<version>` and creates a GitHub release with the package attached.
