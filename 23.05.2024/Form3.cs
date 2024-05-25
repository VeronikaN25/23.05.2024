using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23._05._2024
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double angle = double.Parse(textBox1.Text);
                double sinValue = Math.Sin(angle * Math.PI / 180); ;

                label2.Text = $"Синус угла {angle} градусов: {sinValue:F4}";
            }
            catch (FormatException){
                MessageBox.Show("Ошибка: Некорректный ввод угла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
