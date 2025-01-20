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
    /// Логика взаимодействия для ChaptersPage.xaml
    /// </summary>
    public partial class ChaptersPage : Page
    {
        public ChaptersPage()
        {
            InitializeComponent();



            // Ссылки на кнопки
            var buttons = new[]
            {
                Btn_Chapter1, Btn_Chapter2, Btn_Chapter3, Btn_Chapter4, Btn_Chapter5,
                Btn_Chapter6, Btn_Chapter7, Btn_Chapter8, Btn_Chapter9, Btn_Chapter10,
                Btn_Chapter11, Btn_Chapter12, Btn_Chapter13, Btn_Chapter14, Btn_Chapter15
            };

            // Ссылки на переменные AppState
            var saves = new[]
            {
                AppState.Btn1, AppState.Btn2, AppState.Btn3, AppState.Btn4, AppState.Btn5,
                AppState.Btn6, AppState.Btn7, AppState.Btn8, AppState.Btn9, AppState.Btn10,
                AppState.Btn11, AppState.Btn12, AppState.Btn13, AppState.Btn14, AppState.Btn15
            };

            // Применение свойств к кнопкам
            for (int i = 0; i < buttons.Length; i++)
            {
                if(saves[i] == 0)
                {
                    buttons[i].Foreground = AppState.Btn_Gray;
                    buttons[i].BorderBrush = AppState.Btn_Gray;
                }
                if (saves[i] == 1)
                {
                    buttons[i].Foreground = AppState.Btn_Blue;
                    buttons[i].BorderBrush = AppState.Btn_Blue;
                }
                if (saves[i] >= 3)
                {
                    buttons[i].Foreground = AppState.Btn_Orange;
                    buttons[i].BorderBrush = AppState.Btn_Orange;
                }


                //Загрузка текста из БД
                var CourseChapters = App.context.CourseChapters
                          .Where(p => p.chapter_id == (i+1))
                          .FirstOrDefault();
                buttons[i].Content = CourseChapters.chapter_title;

                //new PageFolder.MenuPage().SaveProc(sender, e);


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


            }
        }


        private void Btn_Chapter_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            switch (button.Name)
            {
                case "Btn_Chapter1":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_1_Page(this));
                    break;
                case "Btn_Chapter2":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_2_Page(this));
                    break;
                case "Btn_Chapter3":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_3_Page(this));
                    break;
                case "Btn_Chapter4":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_4_Page(this));
                    break;
                case "Btn_Chapter5":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_5_Page(this));
                    break;
                case "Btn_Chapter6":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_6_Page(this));
                    break;
                case "Btn_Chapter7":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_7_Page(this));
                    break;
                case "Btn_Chapter8":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_8_Page(this));
                    break;
                case "Btn_Chapter9":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_9_Page(this));
                    break;
                case "Btn_Chapter10":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_10_Page(this));
                    break;
                case "Btn_Chapter11":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_11_Page(this));
                    break;
                case "Btn_Chapter12":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_12_Page(this));
                    break;
                case "Btn_Chapter13":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_13_Page(this));
                    break;
                case "Btn_Chapter14":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_14_Page(this));
                    break;
                case "Btn_Chapter15":
                    ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_15_Page(this));
                    break;
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.MenuPage());
            ClickSound1.Position = new TimeSpan(0); // Переместить в начало звука
            ClickSound1.Play();
        }

        private void Btn_TaskTest_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.TestTaskPage(this));
        }
    }
}
