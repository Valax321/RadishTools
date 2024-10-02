using System;
using System.IO;

namespace Radish.Text
{
    public class TextScope : IDisposable
    {
        private readonly string m_CloseToken;
        private readonly TextWriter m_Writer;
        private readonly bool m_WriteNewLine;
        private readonly int m_IndentLevel;
        
        internal TextScope(string openToken, string closeToken, bool writeNewLine, TextWriter writer, int indentLevel)
        {
            m_CloseToken = closeToken;
            m_Writer = writer ?? throw new ArgumentNullException(nameof(writer));
            m_WriteNewLine = writeNewLine;
            m_IndentLevel = indentLevel;
            
            for (var i = 0; i < indentLevel; ++i)
                m_Writer.Write("    ");
            if (m_WriteNewLine)
                m_Writer.WriteLine(openToken);
            else
                m_Writer.Write(openToken);
        }

        public void Dispose()
        {
            for (var i = 0; i < m_IndentLevel; ++i)
                m_Writer.Write("    ");
            if (m_WriteNewLine)
                m_Writer.WriteLine(m_CloseToken);
            else
                m_Writer.Write(m_CloseToken);
        }
    }
}