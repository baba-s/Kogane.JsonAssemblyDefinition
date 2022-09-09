using System;
using JetBrains.Annotations;

// ReSharper disable InconsistentNaming
// ReSharper disable NotAccessedField.Global

namespace Kogane
{
    [Serializable]
    public sealed class JsonAssemblyDefinition
    {
        [UsedImplicitly] public string   name             = string.Empty;
        [UsedImplicitly] public string   rootNamespace    = string.Empty;
        [UsedImplicitly] public string[] references       = Array.Empty<string>();
        [UsedImplicitly] public string[] includePlatforms = Array.Empty<string>();
        [UsedImplicitly] public string[] excludePlatforms = Array.Empty<string>();
        [UsedImplicitly] public bool     allowUnsafeCode;
        [UsedImplicitly] public bool     overrideReferences;
        [UsedImplicitly] public string[] precompiledReferences = Array.Empty<string>();
        [UsedImplicitly] public bool     autoReferenced;
        [UsedImplicitly] public string[] defineConstraints = Array.Empty<string>();
        [UsedImplicitly] public string[] versionDefines    = Array.Empty<string>();
        [UsedImplicitly] public bool     noEngineReferences;
    }
}