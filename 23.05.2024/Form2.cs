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

    public partial class Form2 : Form
    {
        const double RUB_TO_KZT = 5.75;
        const double KZT_TO_RUB = 1 / RUB_TO_KZT;
        const double USD_TO_KZT = 445.0;
        const double KZT_TO_USD = 1 / USD_TO_KZT;
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = double.Parse(textBoxAmount.Text);
                string fromCurrency = comboBoxFrom.SelectedItem.ToString();
                string toCurrency = comboBoxTo.SelectedItem.ToString();

                double result = ConvertCurrency(amount, fromCurrency, toCurrency);

                labelResult.Text = $"Результат: {result} {toCurrency}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите числовое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private double ConvertCurrency(double amount, string fromCurrency, string toCurrency)
        {
            if (fromCurrency == "RUB" && toCurrency == "KZT")
                return amount * RUB_TO_KZT;
            else if (fromCurrency == "KZT" && toCurrency == "RUB")
                return amount * KZT_TO_RUB;
            else if (fromCurrency == "USD" && toCurrency == "KZT")
                return amount * USD_TO_KZT;
            else if (fromCurrency == "KZT" && toCurrency == "USD")
                return amount * KZT_TO_USD;
            else
                return amount; // Если валюты одинаковы, возвращаем ту же сумму
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
