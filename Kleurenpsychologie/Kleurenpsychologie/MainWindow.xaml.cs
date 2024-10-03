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

namespace Kleurenpsychologie
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

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            Main.Background = new SolidColorBrush(Colors.Black);
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            Main.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Main.Background = new SolidColorBrush(Colors.Black);
            hexTextBox.Background = new SolidColorBrush(Colors.Black);
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Main.Background = new SolidColorBrush(Colors.LightGray);
            hexTextBox.Background = new SolidColorBrush(Colors.LightGray);
        }

        private void rood_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#FF0000";
        }

        private void Geel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#FFFF00";
        }

        private void blauw_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#0000FF";
        }

        private void groen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#008000";
        }

    }
}