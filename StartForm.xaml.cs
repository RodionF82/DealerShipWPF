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
using System.Data.SQLite;
using System.Data.Common;

namespace DealerShipWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartForm : Window
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, RoutedEventArgs e)
        {/*
            string idus = "";
            string databaseName = @"Client.db";
            SQLiteConnection connection =
            new SQLiteConnection(string.Format("Data Source={0};", databaseName));
            connection.Open();
            SQLiteCommand command = new SQLiteCommand("SELECT * FROM 'Clients' WHERE Login = '" + LoginTB.Text + "';", connection);
            SQLiteDataReader reader = command.ExecuteReader();
            string pass = "";
            foreach (DbDataRecord record in reader)
            {
                pass = record["Password"].ToString();
                idus = record["id"].ToString();

            }
            connection.Close();
            if (pass == PassTB.Text)
            {
                WindowMain wn = new WindowMain(idus);
                wn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы попытались устроить несанкционированное проникновение к чужим данным");
            }
           */
            this.Hide();
            WindowMain wn = new WindowMain();
            wn.ShowDialog();
        }

        private void Label_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
        }
    }
}
