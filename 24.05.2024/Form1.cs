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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Products newForm = new Products();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculatorcs newForm = new Calculatorcs();
            newForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trigonometry newForm = new Trigonometry();
            newForm.Show();
        }
    }
}
