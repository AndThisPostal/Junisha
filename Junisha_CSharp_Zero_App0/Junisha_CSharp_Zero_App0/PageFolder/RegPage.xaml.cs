using Junisha_CSharp_Zero_App0.ClassFolder;
using Junisha_CSharp_Zero_App0.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }

        private void Btn_Reg_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(LoginTB.Text))
                mes += "Введите логин\n";
            if (string.IsNullOrWhiteSpace(Pass1PB.Password))
                mes += "Введите пароль\n";
            if (string.IsNullOrWhiteSpace(Pass2PB.Password))
                mes += "Введите повтор пароля\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }

            int genderNumber;

            if (MaleRB.IsChecked == true)
                genderNumber = 1;
            else
                genderNumber = 2;

            //Код для добавления нового пользователя в БД

            Users user = App.context.Users.FirstOrDefault(u => u.user_name == LoginTB.Text);

            if (user != null)
            {
                MessageBox.Show("Не успел, придумай новый логин =3");
            }
            else if (Pass1PB.Password != Pass2PB.Password)
            {

                MessageBox.Show("Пароли не сходятся!!");
            }
            else
            {
                Users users = new Users
                {
                    user_name = LoginTB.Text,
                    user_pass = Pass1PB.Password,

                    gender_id = genderNumber
                };

                Progress progress = new Progress
                {
                    user_id = users.user_id,
                    chapter_id = 1,
                    progress_data = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"

                };

                App.context.Users.Add(users);
                App.context.Progress.Add(progress);
                App.context.SaveChanges();
                MessageBox.Show("Запись добавлена");
                ClassFrame.FrameBody.Navigate(new PageFolder.AuthPage());
            }
        }

        private void Btn_Auto_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.AuthPage());
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
