using Services;
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

namespace Podgotovka
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            var auth = Authorization.Login(LoginTextBox.Text, PasswordBox.Password);
            if (auth == Common.AuthVariants.LoginAndPassworcorrect)
            {
                NavigationService.Navigate(new Uri("podgotovka.xaml", UriKind.Relative));
                /*var mainWindow = MainWindow.GetWindow(new MainWindow());
                var mainFrame = mainWindow.FindName("MainFrame") as Frame;
                mainFrame.Navigate(podgotovka);*/
            };
            if (auth == Common.AuthVariants.LoginIncorrect) MessageBox.Show("Неверный логин");
            if (auth == Common.AuthVariants.PasswordIncorrect) MessageBox.Show("Неверный пароль");
            if (auth == Common.AuthVariants.PasswordAndLoginIncorrect) MessageBox.Show("Неверный логин и пароль");
        }
    }
}
