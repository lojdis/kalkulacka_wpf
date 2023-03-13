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

namespace calculator
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void spocitej_Click(object sender, RoutedEventArgs e)
        {
            string operace = operace_Combobox.Text;
            double cislo1 = double.Parse(cislo1Text.Text);
            double cislo2 = double.Parse(cislo2Text.Text);
            double vysledek = 0;

            if (operace == "+")
                vysledek = cislo1 + cislo2;
            else if (operace == "-")
                vysledek = cislo1 - cislo2;
            else if (operace == "*")
                vysledek = cislo1 * cislo2;
            else if (operace == "/")
            {
                if (cislo2 != 0)
                    vysledek = cislo1 / cislo2;
                else MessageBox.Show("Pozor: nesmime dělitnulou!");
            }
            vysledek_Textblock.Text = vysledek.ToString();
        }
    }
}
