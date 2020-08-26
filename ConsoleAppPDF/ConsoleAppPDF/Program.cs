using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace ConsoleAppPDF
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a pdf file
            PdfWriter writer = new PdfWriter("C:\\Users\\Developer\\Desktop\\demo.pdf");

            //Assign a file to pdf
            PdfDocument pdf = new PdfDocument(writer);

            //Assign a pdf to document
            Document document = new Document(pdf);

            //Create a header and set some properties
            Paragraph header = new Paragraph("HEADER")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            //Add the header in the document
            document.Add(header);

            //Create a subHeader and set some properties
            Paragraph subHeader = new Paragraph("SUB HEADER")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15);

            //Add the subHeader in the document
            document.Add(subHeader);

            //Create a line separator
            LineSeparator ls = new LineSeparator(new SolidLine());

            //Add rhe line separator in the document
            document.Add(ls);

            //Create a image


            //Close the document
            document.Close();
        }
    }
}
