
using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace HotChocolate.Language
{
    public class DocumentWriter
        : StringWriter
    {
        public DocumentWriter(StringBuilder stringBuilder)
            : base(stringBuilder)
        {
        }

        public int Indentation { get; private set; }

        public void Indent()
        {
            Indentation++;
        }

        public void Unindent()
        {
            Indentation--;
        }

        public void WriteSpace()
        {
            Write(' ');
        }


        public void WriteIndentation()
        {
            if (Indentation > 0)
            {
                Write(new string(' ', Indentation * 2));
            }
        }

        public Task WriteSpaceAsync()
        {
            return WriteAsync(' ');
        }

        public Task WriteIndentationAsync()
        {
            if (Indentation > 0)
            {
                return WriteAsync(new string(' ', Indentation * 2));
            }
            return Task.CompletedTask;
        }
    }
}
