﻿using Fitnes.AppData;
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
    /// Логика взаимодействия для AdministratorMenu.xaml
    /// </summary>
    public partial class AdministratorMenu : Page
    {
        public AdministratorMenu()
        {
            InitializeComponent();
        }

        private void ButtonCoachRegistration_Click(object sender, RoutedEventArgs e)
        {
            FrameMain.MainFrame.Navigate(new Pages.AdministrationRegistrationTrainer());
        }
    }
}
