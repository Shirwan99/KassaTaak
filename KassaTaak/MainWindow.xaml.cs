using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KassaTaak
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
        private void CheckNumberButton_Click(object sender, RoutedEventArgs e)
        {
            const int CheckNumber = 97;
            int vatNumber = int.Parse(vatNumberTextBox.Text);
            int result= CheckNumber - (vatNumber % CheckNumber);
            checkNumberTextBox.Text= Convert.ToString(result);
        }
        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void checkNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            prijsTextBox.Text = string.Empty;
            aantalTextBox.Text = "";
            vatNumberTextBox.Clear();
            checkNumberTextBox.Clear();
            tbetalenTextBox.Text = string.Empty;

            prijsTextBox.Focus();
        }

        private void brButton_Click(object sender, RoutedEventArgs e)
        {
            float price;
            float amountTopay;
            int amount;

            price = float.Parse(prijsTextBox.Text);
            amount = int.Parse(aantalTextBox.Text);
            amountTopay = price * amount;
            tbetalenTextBox.Text= amountTopay.ToString();

        clearButton.Focus();
        }
        private void prijsTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}