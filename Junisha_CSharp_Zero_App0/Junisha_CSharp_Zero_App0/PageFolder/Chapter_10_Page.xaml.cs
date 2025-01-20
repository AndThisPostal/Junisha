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
    /// Логика взаимодействия для Chapter_10_Page.xaml
    /// </summary>
    public partial class Chapter_10_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_10_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            if (1 > AppState.Btn10)
            {
                AppState.Btn10 = 1;
            }
            if (3 == AppState.Btn10)
            {
                StackBlock2.Visibility = Visibility;
                StackBlock2.Height = Double.NaN;
                Btn_Next.Visibility = Visibility;
            }

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            //Загрузка текста из БД
            var CourseChapters = App.context.CourseChapters
                      .Where(p => p.chapter_id == 10)
                      .FirstOrDefault();

            //Для деления на абзацы: \n\n
            ChapterName.Text = CourseChapters.chapter_title;
            string text1 = CourseChapters.chapter_content1;
            string text2 = CourseChapters.chapter_content2;
            string text3 = CourseChapters.chapter_content3;

            // Разделение текста на абзацы
            string[] paragraphs = text1.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            foreach (string paragraph in paragraphs)
            {
                Text1.Inlines.Add(new Run(paragraph));
                Text1.Inlines.Add(new LineBreak());
                Text1.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            }

            // Разделение текста на абзацы
            paragraphs = text2.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            foreach (string paragraph in paragraphs)
            {
                Text2.Inlines.Add(new Run(paragraph));
                Text2.Inlines.Add(new LineBreak());
                Text2.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            }
        }


        private void Question_1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            button.Foreground = AppState.Btn_Green;
            button.BorderBrush = AppState.Btn_Green;
            StackBlock2.Visibility = Visibility;
            StackBlock2.Height = Double.NaN;

            if (1 == AppState.Btn10)
            {
                AppState.Btn10 = 3;
            }
            new PageFolder.MenuPage().SaveProc(sender, e);
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AppState.Btn10 = 3;
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_11_Page(_chaptersPage));
        }

        private void Question2_Check_Click(object sender, RoutedEventArgs e)
        {
            if(Textbox1.Text == "3 == 0" &&
               Textbox2.Text == "5 == 0" &&
               Textbox3.Text == "3 == 0" &&
               Textbox4.Text == "5 == 0")
            {
                Btn_Next.Visibility = Visibility;
                StackBlock2.Visibility = Visibility;
                StackBlock2.Height = Double.NaN;
            }
            
            if(Textbox1.Text == "3 == 0")
            {
                Textbox1.Foreground = AppState.Btn_Green;
                Textbox1.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox1.Foreground = AppState.Btn_Red;
                Textbox1.BorderBrush = AppState.Btn_Red;
            }

            if (Textbox2.Text == "5 == 0")
            {
                Textbox2.Foreground = AppState.Btn_Green;
                Textbox2.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox2.Foreground = AppState.Btn_Red;
                Textbox2.BorderBrush = AppState.Btn_Red;
            }

            if (Textbox3.Text == "3 == 0")
            {
                Textbox3.Foreground = AppState.Btn_Green;
                Textbox3.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox3.Foreground = AppState.Btn_Red;
                Textbox3.BorderBrush = AppState.Btn_Red;
            }

            if (Textbox4.Text == "5 == 0")
            {
                Textbox4.Foreground = AppState.Btn_Green;
                Textbox4.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox4.Foreground = AppState.Btn_Red;
                Textbox4.BorderBrush = AppState.Btn_Red;
            }

        }
    }
}