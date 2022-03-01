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
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Page
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void ButtonСhoiceСoach_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.Trainer());
        }

        private void ButtonPersonalArea_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.PersonalArea());
        }

        private void ButtonTrainingPlan_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.TrainingPlan());
        }

        private void ButtonWorkoutToday_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.WorkoutToday());
        }
    }
}
