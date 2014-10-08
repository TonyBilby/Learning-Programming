using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature_Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tempConvertButton_Click(object sender, EventArgs e)
        {
            double f, c;
            if (cTextBox.Text == "" && fTextBox.Text != "")
            {
                if (double.TryParse(fTextBox.Text, out f))
                {
                    cTextBox.Text = Math.Round(((f - 32) * 5 / 9), 1).ToString();
                }
                else
                {
                    MessageBox.Show("That isn't a number..", "Error");
                    fTextBox.Text = Regex.Replace(fTextBox.Text, "[^0-9]", "");
                }
            }
            else if (cTextBox.Text != "" && fTextBox.Text == "")
            {
                if (double.TryParse(cTextBox.Text, out c))
                {
                    fTextBox.Text = Math.Round((c * 9 / 5 + 32), 1).ToString();
                }
                else
                {
                    MessageBox.Show("That isn't a number..", "Error");
                    cTextBox.Text = Regex.Replace(cTextBox.Text, "[^0-9]", "");
                }
            }
            else
            {
                MessageBox.Show("Please make sure to leave one field empty", "Error");
            }
        }

        private void Ctype(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                tempConvertButton_Click(null, null);
                e.Handled = true;
            }
            else
            {
                fTextBox.Text = "";
            }
        }

        private void Ftype(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                tempConvertButton_Click(null, null);
                e.Handled = true;
            }
            else
            {
                cTextBox.Text = "";
            }
        }
    }
}
