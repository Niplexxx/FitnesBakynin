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
using Fitnes.AppData;

namespace Fitnes.pages
{
    /// <summary>
    /// Логика взаимодействия для PageInput.xaml
    /// </summary>
    public partial class PageInput : Page
    {
        public PageInput()
        {
            InitializeComponent();
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.PageRegistration());
        }

        private void ButtonInput_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrameMenu.Navigate(new Pages.Menu());
        }

        private void ButtonAdministration_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrameMenu.Navigate(new Pages.AdministratorMenu());
        }

        private void ButtonTrainer_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrameMenu.Navigate(new Pages.TrainerMenu());
        }
    }
}
