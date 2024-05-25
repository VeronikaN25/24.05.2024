using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24._05._2024
{
    public partial class Calculatorcs : Form
    {
        public string D;
        public string N1;
        public bool N2;
        public Calculatorcs()
        {
            N2 = false;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();

        }
        private void n3_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            if (N2)
            {
                textBox1.Text = textBox1.Text + B.Text;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = B.Text;
                }
                else
                {
                    textBox1.Text = textBox1.Text + B.Text;
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            N1 = string.Empty;
            D = string.Empty;
            N2 = false;
        }

        private void mult_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            textBoxResult.Text = string.Empty;
            D = B.Text;
            N1 = textBox1.Text;
            N2 = true;
            textBox1.Text = textBox1.Text + " " + D + " ";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            try
            {
                string[] parts = textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length < 3)
                {
                    MessageBox.Show("Некорректное выражение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double dn1 = Convert.ToDouble(parts[0]);
                double dn2 = Convert.ToDouble(parts[2]);
                double res = 0;

                switch (D)
                {
                    case "+":
                        res = dn1 + dn2;
                        break;
                    case "-":
                        res = dn1 - dn2;
                        break;
                    case "x":
                        res = dn1 * dn2;
                        break;
                    case "/":
                        if (dn2 == 0)
                        {
                            textBoxResult.Text = "error";
                            return;
                        }
                        res = dn1 / dn2;
                        break;
                }

                textBoxResult.Text = res.ToString();
                D = string.Empty;
                N1 = string.Empty;
                N2 = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text + ",";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "0";
            }
        }
    }
}
