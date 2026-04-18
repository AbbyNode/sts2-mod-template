# sts2-mod-template

A base template for creating new [Slay the Spire 2](https://store.steampowered.com/app/2868840/Slay_the_Spire_2/) mods.

## Based on

- Mod template structure: [Alchyr/ModTemplate-StS2](https://github.com/Alchyr/ModTemplate-StS2)
- Build pipelines: [AbbyNode/sts2-endless](https://github.com/AbbyNode/sts2-endless)

## Requirements

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- Slay the Spire 2 (Early Access) installed via Steam
- [MegaDot / Godot 4.5.1 mono](https://github.com/godotengine/godot/releases/tag/4.5.1-stable) for exporting `.pck` files
- [BaseLib](https://github.com/Alchyr/STS2-BaseLib) mod loader

## Getting Started

1. Use this repository as a template (click **Use this template** on GitHub) or fork/clone it.
2. Rename all occurrences of `MyMod` to your mod's name:
   - `MyMod.csproj` → `YourModName.csproj`
   - `MyMod.json` → `YourModName.json`
   - `MyMod/` folder → `YourModName/`
   - `MyModCode/` folder → `YourModNameCode/`
   - Update `id`, `name`, `author`, and `description` fields in the JSON manifest.
   - Update `project.godot` (`config/name`, `config/icon`, `project/assembly_name`).
   - Update namespace and `ModId` in `MyModCode/MainFile.cs`.
   - Update workflow files in `.github/workflows/` to reference your new mod name.
3. Copy your local `Directory.Build.props` settings (the file is git-ignored so it stays machine-specific):
   - Set `GodotPath` to your local MegaDot executable.
   - Optionally set `Sts2Path` if auto-detection fails.
4. Open the `.csproj` in your IDE or run `dotnet build` to build locally.

## Project Structure

```
├── .github/workflows/
│   ├── build.yml       # Bumps version, builds, and publishes a GitHub Release on push to master
│   └── ci.yml          # Builds on pull requests to master
├── MyMod/              # Godot assets (images, scenes, localization, etc.)
│   └── mod_image.png
├── MyModCode/          # C# source code
│   └── MainFile.cs
├── packages/           # NuGet package cache (excluded from Godot)
├── Directory.Build.props   # Local machine config (git-ignored)
├── Sts2PathDiscovery.props # Auto-detects STS2 install path
├── MyMod.csproj        # .NET / Godot project file
├── MyMod.json          # Mod manifest (id, version, dependencies, etc.)
├── export_presets.cfg  # Godot export preset for .pck generation
└── project.godot       # Godot project configuration
```

## Building

```bash
dotnet restore
dotnet build
```

## Publishing (with .pck export)

Make sure `GodotPath` is set in `Directory.Build.props`, then:

```bash
dotnet publish -c Release
```

## CI/CD

- **CI** (`ci.yml`): Triggered on pull requests to `master`. Builds the mod to verify it compiles.
- **Build** (`build.yml`): Triggered on pushes to `main`. Bumps the minor version in `MyMod.json`, builds and publishes the mod, then creates a GitHub Release with a zipped artifact.
