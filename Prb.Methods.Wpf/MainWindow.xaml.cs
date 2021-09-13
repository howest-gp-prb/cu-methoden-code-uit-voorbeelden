using System.Windows;

namespace Methoden.WPF
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

        private void BtnShowCountry_Click(object sender, RoutedEventArgs e)
        {
            string country = "Frankrijk";
            ShowCountry(country);
        }

        void ShowCountry(string land)
        {
            MessageBox.Show("Het land is " + land);
        }
    }
}
