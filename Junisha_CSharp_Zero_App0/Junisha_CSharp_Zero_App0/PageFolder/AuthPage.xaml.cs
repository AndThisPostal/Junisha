using Junisha_CSharp_Zero_App0.ClassFolder;
using Junisha_CSharp_Zero_App0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Junisha_CSharp_Zero_App0.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Btn_Intro_Click(object sender, RoutedEventArgs e)
        {
            Users users = App.context.Users.FirstOrDefault(u => u.user_name == LoginTB.Text && u.user_pass == PassPB.Password);

            if (users != null)
            {
                MessageBox.Show("Авторизация успешна!");
                AppState.UserID = users.user_id;
                ClassFrame.FrameBody.Navigate(new PageFolder.MenuPage());
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль!!");
            }
        }

        private void Btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.RegPage());
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
