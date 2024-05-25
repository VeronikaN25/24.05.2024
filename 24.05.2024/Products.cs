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
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = textBoxNameProducts.Text;
                double price = double.Parse(textBoxPrice.Text);
                int quantity = int.Parse(textBoxQuantity.Text);

                double totalCost = price * quantity;
                labelTotalCost.Text = $"Общая стоимость\n{productName}: {totalCost:C2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите правильные числовые значения для цены и количества.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();

        }
    }
}
