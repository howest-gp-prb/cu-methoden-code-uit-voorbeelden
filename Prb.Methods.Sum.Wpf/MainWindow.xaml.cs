using System.Windows;

namespace BerekenSom.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int sum;

        public MainWindow()
        {
            InitializeComponent();
        }

        int CalculateSum(int numberOne, int numberTwo)
        {
            return numberOne + numberTwo;
        }

        int CalculateSum(string numberOneText, string numberTwoText)
        {
            int numberOne = int.Parse(numberOneText);
            int numberTwo = int.Parse(numberTwoText);
            return CalculateSum(numberOne, numberTwo);
        }

        void ScopeTest()
        {
            MessageBox.Show("De som was: " + sum);
        }

        private void BtnCalculateSum_Click(object sender, RoutedEventArgs e)
        {
            int leftNumber = int.Parse(txtLeftNumber.Text);
            int rightNumber = int.Parse(txtRightNumber.Text);
            sum = CalculateSum(leftNumber, rightNumber);
            MessageBox.Show("De som van " + leftNumber + " en " + rightNumber + " is " + sum, "Som berekenen");

        }

    }
}
