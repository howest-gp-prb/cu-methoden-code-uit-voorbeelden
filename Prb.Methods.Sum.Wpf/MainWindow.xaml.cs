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

namespace BerekenSom.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int som;

        public MainWindow()
        {
            InitializeComponent();
        }
        int BerekenSommen(int getalLinks, int getalRechts)
        {
            return getalLinks + getalRechts;
        }
        int BerekenSommen(string getalLinks, string getalRechts)
        {
            int links = int.Parse(getalLinks);
            int rechts = int.Parse(getalRechts);
            return BerekenSommen(links, rechts);
        }

        private void btnBerekenSom_Click(object sender, RoutedEventArgs e)
        {
            int links = int.Parse(txtGetalLinks.Text);
            int rechts = int.Parse(txtGetalRechts.Text);
            som = BerekenSommen(links, rechts);
            MessageBox.Show("De som van " + links + " en " + rechts + " is " + som, "Som berekenen");

        }
        void ScopeText()
        {
            MessageBox.Show("De som was: " + som);
        }

    }
}
