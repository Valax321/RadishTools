using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using Radish.Logging;
using UnityEngine;
using ILogger = Radish.Logging.ILogger;

namespace Radish
{
    [PublicAPI]
    public static class ShaderUtility
    {
        private static readonly ILogger Logger = LogManager.GetLoggerForType(typeof(ShaderUtility));
        private static readonly Dictionary<string, Material> s_Materials = new();
        
        public static Material CreateSharedMaterialFromShader(string shaderPath, [CanBeNull] Action<Material> setupCallback = null)
        {
            if (shaderPath == null)
                throw new ArgumentNullException(nameof(shaderPath));
            
            if (s_Materials.TryGetValue(shaderPath, out var mat))
                return mat;
            
            var shader = Shader.Find(shaderPath);
            if (!shader)
            {
                Logger.Warn("Could not find shader named '{0}'", shaderPath);
                return null;
            }

            mat = new Material(shader);
            setupCallback?.Invoke(mat);
            s_Materials.Add(shaderPath, mat);
            return mat;
        }

        public static Mesh GetBuiltinMesh(PrimitiveType type)
        {
            return Resources.GetBuiltinResource<Mesh>(type switch
            {
                PrimitiveType.Sphere => "Sphere.fbx",
                PrimitiveType.Capsule => "Capsule.fbx",
                PrimitiveType.Cylinder => "Cylinder.fbx",
                PrimitiveType.Cube => "Cube.fbx",
                PrimitiveType.Plane => "Plane.fbx",
                PrimitiveType.Quad => "Quad.fbx",
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            });
        }
    }
}