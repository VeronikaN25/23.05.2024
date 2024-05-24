﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                
                double sum = num1 + num2;

               
                labelResult.Text = "Результат: " + sum.ToString();
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Пожалуйста, введите числовые значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
