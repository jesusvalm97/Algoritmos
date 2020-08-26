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
            Image image = new Image(ImageDataFactory
                .Create(@"C:\Users\Developer\Pictures\BH2.png"))
                .SetTextAlignment(TextAlignment.CENTER)
                //.SetMarginTop(25)
                //.SetMarginBottom(25)
                //.SetMarginLeft(25)
                //.SetMarginRight(25)
                .SetHeight(100)
                .SetWidth(100);
                //.SetRelativePosition( / 2, 250, 100, 100);

            //Add the image in the document
            document.Add(image);

            //Create a table
            Table table = new Table(2, false);

            //Start fisrt row
            //Create a cell
            Cell cell11 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("State"));

            //Add the cell in the table
            table.AddCell(cell11);

            //Create a cell
            Cell cell12 = new Cell(1, 1)
                .SetBackgroundColor(ColorConstants.GRAY)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Capital"));

            //Add the cell in the table
            table.AddCell(cell12);
            //End first row

            //Start second row
            //Create a cell
            Cell cell21 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("New York"));

            //Add the cell in the table
            table.AddCell(cell21);

            //Create a cell
            Cell cell22 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Albany"));

            //Add the cell in the table
            table.AddCell(cell22);
            //End second row

            //Start third row
            //Create a cell
            Cell cell31 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("New Jersey"));

            //Add the cell in the table
            table.AddCell(cell31);

            //Create a cell
            Cell cell32 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Trenton"));

            //Add the cell in the table
            table.AddCell(cell32);
            //End third row

            //Start four row
            //Create a cell
            Cell cell41 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("California"));

            //Add the cell in the table
            table.AddCell(cell41);

            //Create a cell
            Cell cell42 = new Cell(1, 1)
                .SetTextAlignment(TextAlignment.CENTER)
                .Add(new Paragraph("Sacramento"));

            //Add the cell in the table
            table.AddCell(cell42);
            //End four row

            //Add the table in the document
            document.Add(table);

            //Create a Hyperlink
            Link link = new Link("Click Here", PdfAction.CreateURI("https://github.com/jesusvalm97"));
            Paragraph hiperLink = new Paragraph("Please")
                .Add(link.SetBold().SetUnderline()
                .SetItalic().SetFontColor(ColorConstants.BLUE))
                .Add("to go my github profile.");

            //Add the hiperlink in the document
            document.Add(hiperLink);

            //Add a number of page in the corner of the page
            int n = pdf.GetNumberOfPages();

            for (int i = 1; i <= n; i++)
            {
                document.ShowTextAligned(new Paragraph(String
                    .Format("page" + i + " of " + n)),
                    559, 806, i, TextAlignment.RIGHT,
                    VerticalAlignment.TOP, 0);
            }

            //Close the document
            document.Close();
        }
    }
}
