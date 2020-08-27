using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Action;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Hyphenation;
using iText.Layout.Properties;

namespace ModifyPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            PdfReader reader = new PdfReader("C:\\Users\\Developer\\Desktop\\demo.pdf");
            PdfWriter writer = new PdfWriter("C:\\Users\\Developer\\Desktop\\demo2.pdf");
            PdfDocument pdfDocument = new PdfDocument(reader, writer);

            for (int x = 1; x <= pdfDocument.GetNumberOfPages(); x++)
            {
                PdfPage page = pdfDocument.GetPage(x);
                PdfArray associatedFiles = page.GetAssociatedFiles(false);

                for (int i = 0; i < associatedFiles.Size(); i++)
                {
                    PdfDictionary attachment = associatedFiles.GetAsDictionary(i);
                    String fileName = attachment.GetAsString(PdfName.F).GetValue();
                    byte[] fileBytes = attachment.GetAsDictionary(PdfName.EF).GetAsStream(PdfName.F).GetBytes();
                }
            }
        }
    }
}
