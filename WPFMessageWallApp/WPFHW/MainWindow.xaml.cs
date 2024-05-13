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

namespace WPFHW
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

        private void AddMessage_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hi {firstNameText.Text} {lastNameText.Text}");
            firstNameText.Text = string.Empty;
            lastNameText.Text = string.Empty;
            firstNameText.Focus();
        }
    }
}