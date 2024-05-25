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
    public partial class Trigonometry : Form
    {
        public Trigonometry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double angleInDegrees = double.Parse(textBoxAngle.Text);
                double angleInRadians = (angleInDegrees * Math.PI) / 180;

                double sineValue = Math.Sin(angleInRadians);
                sinResult.Text = $"Sin({angleInDegrees}°) = {sineValue:F1}";

                double cosValue = Math.Cos(angleInRadians);
                cosResult.Text = $"Cos({angleInDegrees}°) = {cosValue:F1}";

                double tagValue = Math.Tan(angleInRadians);
                tanResult.Text = $"Tan({angleInDegrees}°) = {tagValue:F1}";

                double cotValue = 1.0 / tagValue;
                ctanResult.Text = $"Ctan({angleInDegrees}°) = {cotValue:F1}";
            }
            catch (FormatException)
            {
                MessageBox.Show("введите правильное числовое значение угла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
