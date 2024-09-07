using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using UnityEditor.AssetImporters;
using UnityEngine;
using YamlDotNet.RepresentationModel;

namespace Radish.Localization
{
    [ScriptedImporter(1, new string[0], new[] { "yaml", "csv" })]
    internal class LocalizedStringTableImporter : ScriptedImporter
    {
        [SerializeField] private SerializedCultureInfo m_NativeCulture = new(CultureInfo.GetCultureInfo("en"));

        private class StringInstance
        {
            public string key;
            public readonly Dictionary<CultureInfo, string> strings = new();
        }

        public override void OnImportAsset(AssetImportContext ctx)
        {
            var table = Path.GetExtension(ctx.assetPath) switch
            {
                ".yaml" or ".yml" => ImportFromYAML(ctx),
                ".csv" => ImportFromCSV(ctx),
                _ => ImportAsError(ctx)
            };

            if (table is null)
                return;

            table.name = Path.GetFileNameWithoutExtension(ctx.assetPath);
            ctx.AddObjectToAsset(table.name, table);
            ctx.SetMainObject(table);
            
            GenerateRefsFromTable(table, ctx);
        }

        private LocalizedStringTable ImportAsError(AssetImportContext ctx)
        {
            ctx.LogImportError("Unknown extension");
            return null;
        }

        private LocalizedStringTable ImportFromYAML(AssetImportContext context)
        {
            using var sr = File.OpenText(context.assetPath);
            var yaml = new YamlStream();
            yaml.Load(sr);

            var stringSet = new List<StringInstance>();

            foreach (var doc in yaml.Documents)
            {
                if (doc.RootNode is not YamlSequenceNode o)
                {
                    context.LogImportWarning(
                        $"Document (of type {doc.RootNode.NodeType}) was not a {nameof(YamlSequenceNode)}");
                    continue;
                }

                foreach (var s in o.Children)
                {
                    if (s is not YamlMappingNode stringEntry)
                    {
                        context.LogImportWarning(
                            $"String entry (of type {s.NodeType}) was not a {nameof(YamlMappingNode)}");
                        continue;
                    }

                    var stringInstance = new StringInstance();

                    foreach (var (key, value) in stringEntry.Children)
                    {
                        var keyText = (key as YamlScalarNode)?.Value;
                        var valueText = (value as YamlScalarNode)?.Value;
                        if (keyText is null || valueText is null)
                            continue;

                        if (string.Equals(keyText, "name"))
                            stringInstance.key = valueText;
                        else
                        {
                            try
                            {
                                var culture = CultureInfo.GetCultureInfo(keyText);
                                stringInstance.strings.Add(culture, valueText);
                            }
                            catch (CultureNotFoundException)
                            {
                                context.LogImportError($"Unknown culture '{keyText}'");
                            }
                        }
                    }

                    stringSet.Add(stringInstance);
                }
            }

            return ConstructTable(stringSet);
        }

        private LocalizedStringTable ImportFromCSV(AssetImportContext context)
        {
            using var sr = File.OpenText(context.assetPath);
            using var csv = new CsvReader(sr, new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            });

            csv.Read();
            csv.ReadHeader();

            var header = csv.HeaderRecord![1..];
            if (header.Length == 0)
            {
                context.LogImportError("No languages in header");
                return null;
            }

            var cultures = header.Select(CultureInfo.GetCultureInfo).ToList();
            
            var stringSet = new List<StringInstance>();
            while (csv.Read())
            {
                var s = new StringInstance
                {
                    key = csv.GetField<string>(0)
                };
                for (var i = 1; i < csv.ColumnCount; ++i)
                {
                    var text = csv.GetField<string>(i);
                    s.strings.Add(cultures[i - 1], text);
                }
                stringSet.Add(s);
            }

            return ConstructTable(stringSet);
        }

        private LocalizedStringTable ConstructTable(IReadOnlyList<StringInstance> strings)
        {
            return LocalizedStringTable.Build(
                () => m_NativeCulture.value,
                () => strings.SelectMany(x => x.strings.Select(y => (y.Key, x.key, ProcessText(y.Value)).ToTuple())).ToList());
        }

        private static string ProcessText(string s)
        {
            return s.Replace("\\n", "\n");
        }

        private void GenerateRefsFromTable(LocalizedStringTable table, AssetImportContext ctx)
        {
            foreach (var key in table.keys)
            {
                var r = LocalizedStringReference.Create(table, key);
                r.name = $"{table.name}/{key}";
                ctx.AddObjectToAsset(r.name, r);
            }
        }
    }
}