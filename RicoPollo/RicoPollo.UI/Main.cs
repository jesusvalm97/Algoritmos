using System;
using System.Collections.Generic;
using System.Text;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Layout;
using OKHOSTING.Core;
using OKHOSTING.UI;
using System.Drawing;

namespace RicoPollo.UI
{
    public class Main : OKHOSTING.UI.Controller
    {
        public Main()
        {

        }

        public Main(IPage page) : base(page)
        {

        }

        IListPicker listConvertionOne = BaitAndSwitch.Create<IListPicker>();
        IListPicker listConvertionTwo = BaitAndSwitch.Create<IListPicker>();
        ITextBox txtValue = BaitAndSwitch.Create<ITextBox>();
        ITextBox txtResult = BaitAndSwitch.Create<ITextBox>();

        protected override void OnStart()
        {
            IImage backgroundMain = BaitAndSwitch.Create<IImage>();
            backgroundMain.LoadFromBytes(Resources.Images.backgroundMain);

            IStack stackMain = BaitAndSwitch.Create<IStack>();
            stackMain.BackgroundImage = backgroundMain;

            IStack stackContainer = BaitAndSwitch.Create<IStack>();
            stackContainer.Padding = new Thickness(30);
            stackMain.Children.Add(stackContainer);

            ILabel lblTitle = BaitAndSwitch.Create<ILabel>();
            lblTitle.Text = "Conversión de Cubitos de Riko Pollo";
            lblTitle.Bold = true;
            lblTitle.FontSize = 30;
            lblTitle.FontColor = Color.White;
            stackContainer.Children.Add(lblTitle);

            ILabel lblText = BaitAndSwitch.Create<ILabel>();
            lblText.Text = "Selecciona el tipo de conversión, escribe la cantidad que deseas convertir y presiona el botón que dice ''Convertir''";
            lblText.FontSize = 20;
            lblText.FontColor = Color.White;
            lblText.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(lblText);

            ILabel lblFrom = BaitAndSwitch.Create<ILabel>();
            lblFrom.Text = "De: ";
            lblFrom.FontSize = 20;
            lblFrom.FontColor = Color.White;
            lblFrom.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(lblFrom);

            listConvertionOne.Items = new string[] { "Cubitos de Riko Pollo", "Peso Mexicano" };
            listConvertionOne.FontSize = 20;
            listConvertionOne.FontColor = Color.White;
            stackContainer.Children.Add(listConvertionOne);

            ILabel lblTo = BaitAndSwitch.Create<ILabel>();
            lblTo.Text = "A: ";
            lblTo.FontSize = 20;
            lblTo.FontColor = Color.White;
            lblTo.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(lblTo);

            listConvertionTwo.Items = new string[] { "Peso Mexicano", "Cubitos de Riko Pollo" };
            listConvertionTwo.FontSize = 20;
            listConvertionTwo.FontColor = Color.White;
            stackContainer.Children.Add(listConvertionTwo);

            txtValue.Placeholder = "Valor a  Convertir";
            txtValue.Tag = txtValue;
            txtValue.ValueChanged += TextBoxNumber_ValueChanged;
            txtValue.FontSize = 20;
            txtValue.FontColor = Color.White;
            txtValue.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(txtValue);

            txtResult.Placeholder = "Resultado";
            txtResult.Enabled = false;
            txtResult.FontSize = 20;
            txtResult.FontColor = Color.White;
            txtResult.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(txtResult);

            IButton cmdConvert = BaitAndSwitch.Create<IButton>();
            cmdConvert.Text = "Convertir";
            cmdConvert.Click += CmdConvert_Click;
            cmdConvert.FontColor = Color.White;
            cmdConvert.BackgroundColor = Color.FromArgb(255, 47, 131, 45);
            cmdConvert.BorderWidth = new Thickness(0);
            cmdConvert.FontSize = 20;
            cmdConvert.FontColor = Color.White;
            cmdConvert.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(cmdConvert);

            IImage imgRikoPollo = BaitAndSwitch.Create<IImage>();
            imgRikoPollo.LoadFromBytes(Resources.Images.rp);
            imgRikoPollo.Margin = new Thickness(0, 15, 0, 0);
            stackContainer.Children.Add(imgRikoPollo);

            Page.Content = stackMain;
        }

        private void CmdConvert_Click(object sender, EventArgs e)
        {
            if(listConvertionOne.Value == listConvertionTwo.Value)
            {
                txtResult.Value = txtValue.Value;
            }

            else if (listConvertionOne.Value == "Cubitos de Riko Pollo" && listConvertionTwo.Value == "Peso Mexicano")
            {
                txtResult.Value = Conversion.CubitosRicoPolloADinero(double.Parse(txtValue.Value)).ToString();
            }

            else if (listConvertionOne.Value == "Peso Mexicano" && listConvertionTwo.Value == "Cubitos de Riko Pollo")
            {
                txtResult.Value =  Conversion.DineroACubitosRicoPollo(double.Parse(txtValue.Value)).ToString();
            }
        }

        public void TextBoxNumber_ValueChanged(object sender, string e)
        {
            var txtBox = (ITextBox)sender;
            var textBox = (ITextBox)txtBox.Tag;

            if (System.Text.RegularExpressions.Regex.IsMatch(textBox.Value, "[^0-9]"))
            {
                textBox.Value = textBox.Value.Remove(textBox.Value.Length - 1);
            }
        }
    }
}
