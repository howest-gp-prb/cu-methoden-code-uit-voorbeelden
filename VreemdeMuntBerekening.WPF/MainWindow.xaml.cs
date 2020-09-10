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

namespace VreemdeMuntBerekening.WPF
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

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            tblEuro.Text = GenerateReport(txtNetEuro.Text, txtVAT.Text);
            tblDollar.Text = GenerateReport(txtNetEuro.Text, txtVAT.Text, txtExchange.Text, "Dollar");
        }

        string GenerateReport(string netInText, string vatInText, string exchangeRateInText = "1", string currency = "Euro")
        {
            double net = double.Parse(netInText);
            double vat = double.Parse(vatInText);
            double exchangeRate = double.Parse(exchangeRateInText);
            net = net * exchangeRate;

            double vatTotal = net * (vat / 100);
            double totalAmount = net + vatTotal;
            string report = $"Netto bedrag = {net.ToString("#,##0.00")} {currency}\n" +
                $"BTW {vat.ToString("#,##0.00")} = {vatTotal.ToString("#,##0.00")} {currency}\n" +
                $"Totaal bedrag = {totalAmount.ToString("#,##0.00")} {currency}";

            return report;
        }
    }
}
