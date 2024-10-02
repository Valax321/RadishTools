using System.IO;
using JetBrains.Annotations;

namespace Radish.Text
{
    [PublicAPI]
    public static class TextWriterExtensions
    {
        public static TextScope CreateScope(this TextWriter writer, string openToken, string closeToken,
            bool writeNewLines = true, int indentLevel = 0)
        {
            return new TextScope(openToken, closeToken, writeNewLines, writer, indentLevel);
        }
    }
}