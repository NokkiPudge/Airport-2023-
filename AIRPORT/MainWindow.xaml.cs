using AIRPORT.Views;
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

namespace AIRPORT
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Views.FlightUC flight;
        Views.RegUC reg;
        Views.ReportUC report;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FlightButton_Click(object sender, RoutedEventArgs e)
        {
            flight= new Views.FlightUC();
            UserControls.Content = null;
            UserControls.Content = flight ;
        }

        private void RegButton_Click(object sender, RoutedEventArgs e)
        {
            reg = new Views.RegUC();
            UserControls.Content = null;
            UserControls.Content = reg;
        }

        private void RepButton_Click(object sender, RoutedEventArgs e)
        {
            report = new Views.ReportUC();
            UserControls.Content = null;
            UserControls.Content = report;
        }
    }
}
