using MicroLabEngine.Core;

namespace MicroLabEngine.Godot
{
    /// <summary>
    /// Helper utilities for Godot integration. This class is intentionally minimal so the project
    /// compiles even if Godot assemblies are not available at compile time (the references are optional).
    /// </summary>
    public static class GodotHelpers
    {
        public static string GetCombinedName()
        {
            return $"{CoreService.GetLibraryName()} + MicroLabEngine.Godot";
        }
    }
}
