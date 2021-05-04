using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppImageWithText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCreateImage_Click(object sender, EventArgs e)
        {
            string text = txtBoxText.Text;

            //first, create a dummy bitmap just to get a graphics object
            Image img = new Bitmap(1, 1);
            Graphics drawing = Graphics.FromImage(img);

            //measure the string to see how big the image needs to be
            SizeF textSize = drawing.MeasureString(text, new Font("Brush Script MT", 30));

            //free up the dummy image and old graphics object
            img.Dispose();
            drawing.Dispose();

            //create a new image of the right size
            img = new Bitmap(400, 300);
            drawing = Graphics.FromImage(img);

            //paint the background
            drawing.Clear(Color.White);

            //create a brush for the text
            Brush textBrush = new SolidBrush(Color.Black);

            //create a string format for the text
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            //drawing.DrawString(NameCompanyContact, new Font("Brush Script MT", 30), textBrush, 0, 0);

            Rectangle rect1 = new Rectangle(10, 10, 400, 300);

            drawing.DrawString(text, new Font("Brush Script MT", 30), textBrush, rect1, stringFormat);

            drawing.Save();

            textBrush.Dispose();
            drawing.Dispose();

            img.Save("C:\\Users\\Developer\\Desktop\\imgWithText.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}
