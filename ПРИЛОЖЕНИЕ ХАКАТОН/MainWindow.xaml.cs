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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ПРИЛОЖЕНИЕ_ХАКАТОН
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(psbPassword.Password))
            {
                hintText.Visibility = Visibility.Visible;
            }
            else
            {
                hintText.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation showAn1 = new DoubleAnimation();
            showAn1.From = 1;
            showAn1.To = 0;
            showAn1.Duration = new Duration(TimeSpan.FromSeconds(0.8));

            autorizVIS.Visibility = Visibility.Visible;
            autorizVIS.BeginAnimation(TextBlock.OpacityProperty, showAn1);


            DoubleAnimation showAn2 = new DoubleAnimation();
            showAn2.From = 0;
            showAn2.To = 1;
            showAn2.Duration = new Duration(TimeSpan.FromSeconds(0.8));

            regvis.Visibility = Visibility.Visible;
            regvis.BeginAnimation(TextBlock.OpacityProperty, showAn2);
            



        }

        private void btn_ext(object sender, RoutedEventArgs e)
        {
            DoubleAnimation showAn3 = new DoubleAnimation();
            showAn3.From = 0;
            showAn3.To = 1;
            showAn3.Duration = new Duration(TimeSpan.FromSeconds(0.8));

            autorizVIS.Visibility = Visibility.Visible;
            autorizVIS.BeginAnimation(TextBlock.OpacityProperty, showAn3);


            DoubleAnimation showAn4 = new DoubleAnimation();
            showAn4.From = 1;
            showAn4.To = 0;
            showAn4.Duration = new Duration(TimeSpan.FromSeconds(0.8));

            regvis.Visibility = Visibility.Collapsed;
            regvis.BeginAnimation(TextBlock.OpacityProperty, showAn4);
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            MainMenuWindow mainMenuWindow = new MainMenuWindow();
            Close();
            mainMenuWindow.Show();
        }

        private void psbPassword2_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(psbPassword2.Password))
            {
                hintText2.Visibility = Visibility.Visible;
            }
            else
            {
                hintText2.Visibility = Visibility.Collapsed;
            }
        }

        private void psbPassword3_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(psbPassword3.Password))
            {
                hintText3.Visibility = Visibility.Visible;
            }
            else
            {
                hintText3.Visibility = Visibility.Collapsed;
            }
        }
    }
}
