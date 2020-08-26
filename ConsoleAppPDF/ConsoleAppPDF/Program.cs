using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace ConsoleAppPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfWriter writer = new PdfWriter("C:\\Users\\Developer\\Desktop\\demo.pdf");
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            Paragraph header = new Paragraph("HEADER")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(header);

            Paragraph subHeader = new Paragraph("SUB HEADER")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15);
            document.Add(subHeader);

            document.Close();
        }
    }
}
