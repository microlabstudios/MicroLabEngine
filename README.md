# MicroLabEngine

Dotnet 8 solution for reusable game-engine extensions. This workspace contains two initial projects:

- `MicroLabEngine.Core` - Common classes and utilities used by engine integrations.
- `MicroLabEngine.Godot` - Godot-specific helper library which references `MicroLabEngine.Core`.

Getting started
1. Ensure you have .NET 8 SDK installed (dotnet --version should print a 8.x version).
2. Open `MicroLabEngine.sln` in Visual Studio, Rider, or VS Code.
3. Build the solution with `dotnet build MicroLabEngine.sln`.

Godot references
The `MicroLabEngine.Godot` project attempts to reference Godot assemblies from the default install directory on Windows:

  C:\\Program Files\\Godot\\GodotSharp\\Release\\GodotSharp.dll

If your Godot installation is located elsewhere, override the MSBuild property `GODOT_INSTALL_DIR` when building. Example:

Windows PowerShell:

```powershell
dotnet build MicroLabEngine.sln /p:GODOT_INSTALL_DIR="C:\\path\\to\\Godot"
```

If the specified assemblies are not present, the project will still compile if your code doesn't use Godot-specific APIs (references are marked non-copying). You can also manage the references via `Directory.Build.props` or by editing the project file.

Next steps
- Add Godot-specific helpers and wrappers to `MicroLabEngine.Godot`.
- Add unit tests and CI.
# MicroLabEngine