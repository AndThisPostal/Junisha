using Junisha_CSharp_Zero_App0.ClassFolder;
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

namespace Junisha_CSharp_Zero_App0.PageFolder
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();

            if (AppState.Btn0 == 0)
            {
                // Код для извлечения сохранения из БД
                var progressRecord = App.context.Progress
                      .Where(p => p.user_id == AppState.UserID)
                      .FirstOrDefault();

                //На случай поломки:
                //progressRecord.progress_data = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";
                //LogoText.Text = progressRecord.progress_data.ToString();
                //App.context.SaveChanges();

                //// Код для преобразования его в массив
                string[] stringArray = progressRecord.progress_data.Split(',');
                int[] newArray = Array.ConvertAll(stringArray, int.Parse);

                //Код для присвоения значений класса
                AppState.Btn1 = newArray[0];
                AppState.Btn2 = newArray[1];
                AppState.Btn3 = newArray[2];
                AppState.Btn4 = newArray[3];
                AppState.Btn5 = newArray[4];

                AppState.Btn6 = newArray[5];
                AppState.Btn7 = newArray[6];
                AppState.Btn8 = newArray[7];
                AppState.Btn9 = newArray[8];
                AppState.Btn10 = newArray[9];

                AppState.Btn11 = newArray[10];
                AppState.Btn12 = newArray[11];
                AppState.Btn13 = newArray[12];
                AppState.Btn14 = newArray[13];
                AppState.Btn15 = newArray[14];

                AppState.Btn0 = 1;
            }
        }

        private void Btn_Start_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_1_Page(new PageFolder.ChaptersPage()));
        }

        private void Btn_Chapter_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_About_Click(object sender, RoutedEventArgs e)
        {
            new PageFolder.AboutPage().ProgressProc();
            ClassFrame.FrameBody.Navigate(new PageFolder.AboutPage());
        }


        public void SaveProc(object sender, RoutedEventArgs e)
        {
            var progressRecord = App.context.Progress
                      .Where(p => p.user_id == AppState.UserID)
                      .FirstOrDefault();

            // Создание нового массива
            int[] valuesArray = new int[15]
            {
                AppState.Btn1, AppState.Btn2, AppState.Btn3, AppState.Btn4, AppState.Btn5,
                AppState.Btn6, AppState.Btn7, AppState.Btn8, AppState.Btn9, AppState.Btn10,
                AppState.Btn11, AppState.Btn12, AppState.Btn13, AppState.Btn14, AppState.Btn15
            };

            // Преобразование его в сохранение
            string arrayAsString = string.Join(",", valuesArray);
            Console.WriteLine("Массив как строка: " + arrayAsString);

            // Перезаписать сохраниение в БД
            progressRecord.progress_data = arrayAsString;
            App.context.SaveChanges();

            LogoText.Text = arrayAsString; //Для проверки сохранений
        }

        private void Btn_Exit_Click(object sender, RoutedEventArgs e)
        {
            SaveProc(sender, e);
            System.Windows.Application.Current.Shutdown();
        }
    }
}
