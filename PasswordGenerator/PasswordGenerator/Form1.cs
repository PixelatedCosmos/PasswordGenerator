using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Password pass = new Password();
        public Form1()
        {
            InitializeComponent();
        }

        private void passLength_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pass.includeLower == false && pass.includeUpper == false &&
                pass.includeSpecial == false && pass.includeNum == false || pass.passLen == 0
               ) { textBox1.Text = ""; }
            else
            {
                textBox1.Text = pass.generatePass();
            }
        }

        private void passLength_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passLength.Text)){}
            else
            {
                try
                {
                    pass.passLen = Int16.Parse(passLength.Text);
                }
                catch
                {
                    MessageBox.Show("Invalid input.");
                    passLength.Clear();
                }
            }
        }

        private void upperCase_CheckedChanged(object sender, EventArgs e)
        {
            pass.includeUpper = upperCase.Checked;
        }

        private void lowerCase_CheckedChanged(object sender, EventArgs e)
        {
            pass.includeLower = lowerCase.Checked;
        }

        private void specialCharacters_CheckedChanged(object sender, EventArgs e)
        {
            pass.includeSpecial = specialCharacters.Checked;
        }

        private void numbers_CheckedChanged(object sender, EventArgs e)
        {
            pass.includeNum = numbers.Checked;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(textBox1.Text);
                label2.Visible = true;
                timer1.Start();
            }
            catch { }   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Visible = false;
            timer1.Stop();
        }
    }
}