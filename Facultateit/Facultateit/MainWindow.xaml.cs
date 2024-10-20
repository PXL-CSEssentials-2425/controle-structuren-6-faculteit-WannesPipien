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

namespace Facultateit
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

        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            int number;
            bool isValid = int.TryParse(numberTextBox.Text, out number);
            int result = 1;
            if (isValid)
            {
                do
                {
                    result *= number;
                    number -= 1;
                } while (number > 0);
                resultTextBox.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Geen geldig getal");
            }
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            numberTextBox.Text="1";
            resultTextBox.Clear();
            numberTextBox.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}