using System;
using System.Collections.Generic;
using System.Text;
using OKHOSTING.UI.Controls;
using OKHOSTING.UI.Controls.Layout;
using OKHOSTING.Core;

namespace RicoPollo.UI
{
    public class Main : OKHOSTING.UI.Controller
    {
        IListPicker listConvertionOne = BaitAndSwitch.Create<IListPicker>();
        IListPicker listConvertionTwo = BaitAndSwitch.Create<IListPicker>();
        ITextBox txtValue = BaitAndSwitch.Create<ITextBox>();
        ITextBox txtResult = BaitAndSwitch.Create<ITextBox>();

        protected override void OnStart()
        {
            IStack stackMain = BaitAndSwitch.Create<IStack>();

            ILabel lblTitle = BaitAndSwitch.Create<ILabel>();
            lblTitle.Text = "Conversion de Cubitos de Rico Pollo";
            lblTitle.Bold = true;
            stackMain.Children.Add(lblTitle);

            ILabel lblText = BaitAndSwitch.Create<ILabel>();
            lblText.Text = "Selecciona el tipo de conversion, escribe la cantidad que deseas convertir y presiona el botón";
            stackMain.Children.Add(lblText);

            ILabel lblFrom = BaitAndSwitch.Create<ILabel>();
            lblFrom.Text = "De: ";
            stackMain.Children.Add(lblFrom);

            listConvertionOne.Items = new string[] { "Cubitos de Rico Pollo", "Peso Mexicano" };
            stackMain.Children.Add(listConvertionOne);

            ILabel lblTo = BaitAndSwitch.Create<ILabel>();
            lblTo.Text = "A: ";
            stackMain.Children.Add(lblTo);

            listConvertionTwo.Items = new string[] { "Peso Mexicano", "Cubitos de Rico Pollo" };
            stackMain.Children.Add(listConvertionTwo);

            txtValue.Placeholder = "Valor a  Convertir";
            txtValue.Tag = txtValue;
            txtValue.ValueChanged += TextBoxNumber_ValueChanged;
            stackMain.Children.Add(txtValue);

            txtResult.Placeholder = "Resultado";
            txtResult.Enabled = false;
            stackMain.Children.Add(txtResult);

            IButton cmdConvert = BaitAndSwitch.Create<IButton>();
            cmdConvert.Text = "Convertir";
            cmdConvert.Click += CmdConvert_Click;
            stackMain.Children.Add(cmdConvert);

            Page.Content = stackMain;
        }

        private void CmdConvert_Click(object sender, EventArgs e)
        {
            if(listConvertionOne.Value == listConvertionTwo.Value)
            {
                txtResult.Value = txtValue.Value;
            }

            else if (listConvertionOne.Value == "Cubitos de Rico Pollo" && listConvertionTwo.Value == "Peso Mexicano")
            {
                txtResult.Value = Conversion.CubitosRicoPolloADinero(double.Parse(txtValue.Value)).ToString();
            }

            else if (listConvertionOne.Value == "Peso Mexicano" && listConvertionTwo.Value == "Cubitos de Rico Pollo")
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
