using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class FlightUC : UserControl
    {
        private Passenger _currentpassenger = new Passenger();
        public List<Passenger> PassengerList { get; set; }

        public FlightUC()
        {
            InitializeComponent();
            PassengerReg();
            DataFlighList.ItemsSource = AirportDBEntities1.GetContext().Ticket.ToList();
        }

        private void PassengerReg()
        {
            AirportDBEntities1 pasentities = new AirportDBEntities1();
            var item = pasentities.Passenger.ToList();
            PassengerList = item;
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            var TicketsForRemoving = DataFlighList.SelectedItems.Cast<Ticket>().ToList();
            if(MessageBox.Show($"Вы точно хотите удалить следующие {TicketsForRemoving.Count()} элементов?","Внимание"
            ,MessageBoxButton.YesNo,MessageBoxImage.Question)== MessageBoxResult.Yes)
            {
                try
                {
                    AirportDBEntities1.GetContext().Ticket.RemoveRange(TicketsForRemoving);
                    AirportDBEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены!");
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                    return;
                }
            }
        }

        
    }
}

