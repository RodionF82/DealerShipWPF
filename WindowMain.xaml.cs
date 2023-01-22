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
using System.Windows.Shapes;

namespace DealerShipWPF
{
    /// <summary>
    /// Логика взаимодействия для WindowMain.xaml
    /// </summary>
    public partial class WindowMain : Window
    {
        public WindowMain()
        {
            InitializeComponent();
        }

        private void stats_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Эта функция будет доступна в будущем");
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void btnCars_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CarsPage());
            Manager.FrameCars = MainFrame;
        }

        private void btnClients_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ClientsPage());
            Manager.FrameClients = MainFrame;
        }
    }
}
