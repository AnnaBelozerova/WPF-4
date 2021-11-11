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

namespace WPF_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_Click_Dollar(object sender, RoutedEventArgs e)
        {
            resSumDollar.Text = (Convert.ToDouble(rateDollar.Text) * Convert.ToDouble(sumDollar.Text)).ToString();
        }

        private void Button_Click_Euro(object sender, RoutedEventArgs e)
        {
            resSumEuro.Text = (Convert.ToDouble(rateEuro.Text) * Convert.ToDouble(sumEuro.Text)).ToString();
        }

        private void Button_Click_Grivna(object sender, RoutedEventArgs e)
        {
            resSumGrivna.Text = (Convert.ToDouble(rateGrivna.Text) * Convert.ToDouble(sumGrivna.Text)).ToString();
        }

        private void Button_Click_Dram(object sender, RoutedEventArgs e)
        {
            resSumDram.Text = (Convert.ToDouble(rateDram.Text) * Convert.ToDouble(sumDram.Text)).ToString();
        }

        private void Button_Click_Inch(object sender, RoutedEventArgs e)
        {
            resSumInch.Text = Math.Round((Convert.ToDouble(rateInch.Text)/39.37),2).ToString();
        }

        private void Button_Click_Ft(object sender, RoutedEventArgs e)
        {
            resSumFt.Text = Math.Round((Convert.ToDouble(rateFt.Text) / 3.281), 2).ToString();
        }

        private void Button_Click_Mille(object sender, RoutedEventArgs e)
        {
            resSumMille.Text = Math.Round((Convert.ToDouble(rateMille.Text) / 1609), 2).ToString();
        }

        private void Button_Click_Verst(object sender, RoutedEventArgs e)
        {
            resSumVerst.Text = Math.Round((Convert.ToDouble(rateVerst.Text) * 1067), 2).ToString();
        }
    }
}
