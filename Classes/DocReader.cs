using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeDocs.Classes
{
    class DocReader
    {
        public string PdfReader(string Path)
        {
            StringBuilder text = new StringBuilder();

            PdfReader reader = new PdfReader(Path);

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
            }

            return text.ToString();

        }
    }
}
