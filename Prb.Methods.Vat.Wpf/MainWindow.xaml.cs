using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BerekenTotaal.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        decimal CalculateVat(float vatRate, decimal priceExcl)
        {
            decimal vat = priceExcl * (decimal)vatRate / 100;
            return vat;
        }
        string ShowVatCalculation(float vatRate, decimal priceExcl)
        {
            decimal vat = CalculateVat(vatRate, priceExcl);
            decimal priceIncl = priceExcl + vat;
            string summary = "Berekening BTW\n\n" +
                $"BTW excl.\t€ {priceExcl.ToString("0.00")}\n" +
                $"BTW tarief\t{vatRate} %\n" +
                $"BTW bedrag\t€ {vat.ToString("0.00")}\n" +
                $"BTW incl\t\t€ {priceIncl.ToString("0.00")}\n";
            return summary;
        }

        private void BtnCalculate_Click(object sender, RoutedEventArgs e)
        {
            float vatRate = float.Parse(txtVatRate.Text);
            decimal priceExcl = decimal.Parse(txtPriceExcl.Text);
            tbkCalculation.Text = ShowVatCalculation(vatRate, priceExcl);
        }
        
    }
}
