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
            kleurLabel.Foreground = new SolidColorBrush(Colors.LightGray);
            infoLabel.Foreground = new SolidColorBrush(Colors.LightGray);
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            Main.Background = new SolidColorBrush(Colors.LightGray);
            kleurLabel.Foreground = new SolidColorBrush(Colors.Black);
            infoLabel.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void rood_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#FF0000";
            infoTextBox.Text = "Rood is de kleur van warmte";
        }

        private void Geel_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#FFFF00";
            infoTextBox.Text = "Geel is de kleur van levenslust";
        }

        private void blauw_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#0000FF";
            infoTextBox.Text = "Blauw is de kleur van intelligentie";
        }

        private void groen_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            hexTextBox.Text = "#008000";
            infoTextBox.Text = "Groen is de kleur van genezing";
        }

    }
}