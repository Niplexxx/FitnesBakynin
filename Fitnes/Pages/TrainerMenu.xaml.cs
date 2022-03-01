using Fitnes.AppData;
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

namespace Fitnes.Pages
{
    /// <summary>
    /// Логика взаимодействия для TrainerMenu.xaml
    /// </summary>
    public partial class TrainerMenu : Page
    {
        public TrainerMenu()
        {
            InitializeComponent();
        }

        private void ButtonСhoiceclient_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.TrainerClientChoice());
        }

        private void ButtonClientActivities_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.TrainerClientActivities());
        }

        private void ButtonMoreAboutClients_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.TrainerMoreAboutClients());
        }
    }
}
