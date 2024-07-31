using AIRPORT.Models;
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

namespace AIRPORT.Views
{
    /// <summary>
    /// Логика взаимодействия для ReportUC.xaml
    /// </summary>
    public partial class ReportUC : UserControl
    {
        public ReportUC()
        {
            InitializeComponent();
        }
        public string Report {get;set;}
        public ReportUC(string report)
        {
            report = Report;
        }

        private void SubmitButtonRep_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errorsRep = new StringBuilder();
            if (string.IsNullOrWhiteSpace(ReportText.Text)) 
            errorsRep.AppendLine("Нет текста в меню репорта");

            if (errorsRep.Length > 0)
            {
                MessageBox.Show(errorsRep.ToString());
                return;
            }
            MessageBox.Show("Репорт был отправлен");
            return;
        }
    }
}
