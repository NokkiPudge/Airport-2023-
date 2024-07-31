using AIRPORT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для RegUC.xaml
    /// </summary>
    public partial class RegUC : UserControl
    {
        public string RegUserName { get; set; }
        public string RegPassportNumber { get; set; }
        public string RegPhone { get; set; }
        public Passenger RegPassenger { get; set; }
       
        
        private Passenger _currentreg = new Passenger();
        private Ticket _currentticket = new Ticket();
        public List<Passenger> PassengerList { get; set; }
        public List<Flight> FlightList { get; set; }
        public List<Ticket> TicketList { get; set; }
        public bool RegFailure { get; set; } = false;

        public RegUC()
        {
            InitializeComponent();
            PassengerReg();
            FlightReg();
            TicketReg();
            RegComboBox.ItemsSource = AirportDBEntities1.GetContext().Flight.ToList();
            DataContext = _currentreg;
            RegComboBox.IsEnabled = false;
            RegPasComboBox.IsEnabled = false;
            datePicker.IsEnabled = false;
            ButtonSub.IsEnabled = false;
            ButtonContinue.IsEnabled = false;
        }
        
        private void PassengerReg()
        {
            AirportDBEntities1 pasentities = new AirportDBEntities1();
            var item = pasentities.Passenger.ToList();
            PassengerList = item;
        }
        private void FlightReg()
        {
            AirportDBEntities1 Flightentities = new AirportDBEntities1();
            var item = Flightentities.Flight.ToList();
            FlightList = item;
        }

        private void TicketReg()
        {
            AirportDBEntities1 Ticketentities = new AirportDBEntities1();
            var item = Ticketentities.Ticket.ToList();
            TicketList = item;
        }

        public void RegComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = RegComboBox.SelectedItem as Route;
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errorsSub = new StringBuilder();
            if (RegComboBox.SelectedItem == null)
                errorsSub.AppendLine("Не выбран пассажир");
            if (RegComboBox.SelectedItem == null)
                errorsSub.AppendLine("Не выбран Рейс");
            if (errorsSub.Length > 0)
            {
                MessageBox.Show(errorsSub.ToString());
                return;
            }
            _currentreg.Fullname= RegPasComboBox.Text;
            //_currentreg.phone= RegComboBox.Text;
            var phonenumb= RegComboBox.Text;
            foreach (Passenger i in PassengerList)
            {
                if (i.Fullname == _currentreg.Fullname)
                {
                    if (i.PassportNumber == _currentreg.PassportNumber)
                    {
                        _currentticket.IDPassenger = i.PassengerID;
                    } 
                }
            }
            foreach(Flight f in FlightList) 
            {
                if ((string)f.NameFlight == phonenumb)
                {
                    _currentticket.IDFlight = f.FlightID;
                }
            }
            Random rnd = new Random();
            var rndnum= rnd.Next(99999, 1000000);
            _currentticket.TicketNumber = Convert.ToString(rndnum);

            if (_currentreg.PassengerID >= 0 || _currentticket.IDPassenger >0)
            {
                AirportDBEntities1.GetContext().Ticket.Add(_currentticket);
                foreach (Ticket i in TicketList)
                {
                    if (i.IDPassenger == _currentticket.IDPassenger && i.IDFlight == _currentticket.IDFlight)
                    {
                        MessageBox.Show("Пассажир уже зарегистрирован на рейс");
                        return;
                    }
                }
                try
                {
                    AirportDBEntities1.GetContext().SaveChanges();
                    ButtonContinue.IsEnabled = true;
                    MessageBox.Show("Пассажир заргистрирорван на рейс");  
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong");
                    return;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            TBname.Clear();
            TBphone.Clear();
            TBpassport.Clear();
            RegComboBox.SelectedIndex = -1;
            RegPasComboBox.SelectedIndex = -1;
            datePicker.SelectedDate = DateTime.Now;
        }

        private void Button_Click_ConfirmPerson(object sender, RoutedEventArgs e)
        {
           StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(_currentreg.Fullname))
                errors.AppendLine("Напишите ФИО");
            if (_currentreg.phone.Length != 11)
                errors.AppendLine("Напишите номер правильно!");
            if (_currentreg.PassportNumber.Length != 10)
                errors.AppendLine("Напшите серию/номер правильно");
            


            foreach (Passenger i in PassengerList)
            {
                if (i.PassportNumber == _currentreg.PassportNumber)

                {
                    MessageBox.Show("Данная запись существует");
                    ButtonContinue.IsEnabled = true;
                    RegPasComboBox.ItemsSource = AirportDBEntities1.GetContext().Passenger.ToList();
                    return;
                }
                
            }


            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentreg.PassengerID == 0)
            {
                AirportDBEntities1.GetContext().Passenger.Add(_currentreg);
                try
                {
                    AirportDBEntities1.GetContext().SaveChanges();
                    ButtonContinue.IsEnabled = true;
                    MessageBox.Show("Пассажир создан");
                    PassengerReg();
                    RegPasComboBox.ItemsSource = AirportDBEntities1.GetContext().Passenger.ToList();
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Something wrong");
                    return;
                }
            }

        }

        private void Button_Click_Continue(object sender, RoutedEventArgs e)
        {
            TBname.IsEnabled = false;
            TBpassport.IsEnabled = false;
            TBphone.IsEnabled = false;
            RegComboBox.IsEnabled = true;
            RegPasComboBox.IsEnabled = true;
            datePicker.IsEnabled = true;
            ButtonSub.IsEnabled = true;
            ButtonConfirm.IsEnabled = false;
        }
    }
}
