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

namespace ПРИЛОЖЕНИЕ_ХАКАТОН
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();

            frame.Navigate(new Pages.SandboxPage());
        }

        private void mainMenu_btn_homepage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new Pages.SandboxPage());
        }

        private void mainMenu_btn_webinar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new Pages.Probka());
        }

        private void mainMenu_btn_activitybook_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new Pages.Probka());
        }

        private void mainMenu_btn_options_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new Pages.Probka());
        }

        private void mainMenu_btn_account_MouseDown(object sender, MouseButtonEventArgs e)
        {
            frame.Navigate(new Pages.Account());
        }
    }
}
