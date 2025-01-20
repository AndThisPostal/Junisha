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
    /// Логика взаимодействия для Chapter_2_Page.xaml
    /// </summary>
    public partial class Chapter_2_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_2_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            StackBlock2.Visibility = Visibility;
            StackBlock2.Height = Double.NaN;

            if (4 <= AppState.Btn2)
            {
                StackBlock3.Visibility = Visibility;
                StackBlock3.Height = Double.NaN;

                StackBlock4.Visibility = Visibility;
                StackBlock4.Height = Double.NaN;

                Quest2.Visibility = Visibility;
                Quest2.Height = Double.NaN;

                Quest3.Visibility = Visibility;
                Quest3.Height = Double.NaN;
            }

            //Загрузка текста из БД
            var CourseChapters = App.context.CourseChapters
                      .Where(p => p.chapter_id == 2)
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

            // Разделение текста на абзацы
            //paragraphs = text3.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            //foreach (string paragraph in paragraphs)
            //{
            //    Text3.Inlines.Add(new Run(paragraph));
            //    Text3.Inlines.Add(new LineBreak());
            //    Text3.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            //}
        }


        private void Question_1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Question1_True")
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
                if (AppState.Btn2 == 0)
                {
                    AppState.Btn2 = 1;
                }
                Quest2.Visibility = Visibility;
                Quest2.Height = Double.NaN;

                Question1_False_1.Foreground = AppState.Btn_Red;
                Question1_False_1.BorderBrush = AppState.Btn_Red;
                Question1_False_2.Foreground = AppState.Btn_Red;
                Question1_False_2.BorderBrush = AppState.Btn_Red;
                Question1_False_3.Foreground = AppState.Btn_Red;
                Question1_False_3.BorderBrush = AppState.Btn_Red;
            }
            else
            {
                button.Foreground = AppState.Btn_Red;
                button.BorderBrush = AppState.Btn_Red;
            }
        }

        private void Question_2_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Question2_False_1")
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
                if (AppState.Btn2 == 1)
                {
                    AppState.Btn2 = 2;
                }
                Quest3.Visibility = Visibility;
                Quest3.Height = Double.NaN;

                Question2_True.Foreground = AppState.Btn_Red;
                Question2_True.BorderBrush = AppState.Btn_Red;
                Question2_False_2.Foreground = AppState.Btn_Red;
                Question2_False_2.BorderBrush = AppState.Btn_Red;
                Question2_False_3.Foreground = AppState.Btn_Red;
                Question2_False_3.BorderBrush = AppState.Btn_Red;
            }
            else
            {
                button.Foreground = AppState.Btn_Red;
                button.BorderBrush = AppState.Btn_Red;
            }
        }


        private void Question_3_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Question3_False_2")
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
                if (AppState.Btn2 == 2)
                {
                    AppState.Btn2 = 3;
                }
                if (AppState.Btn2 == 3)
                {
                    StackBlock3.Visibility = Visibility;
                    StackBlock3.Height = Double.NaN;
                }
                new PageFolder.MenuPage().SaveProc(sender, e);

                Question3_True.Foreground = AppState.Btn_Red;
                Question3_True.BorderBrush = AppState.Btn_Red;
                Question3_False_1.Foreground = AppState.Btn_Red;
                Question3_False_1.BorderBrush = AppState.Btn_Red;
                Question3_False_3.Foreground = AppState.Btn_Red;
                Question3_False_3.BorderBrush = AppState.Btn_Red;
            }
            else
            {
                button.Foreground = AppState.Btn_Red;
                button.BorderBrush = AppState.Btn_Red;
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_3_Page(_chaptersPage));
        }

        private void Question2_Check_Click(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text == "int" &&
                Textbox2.Text == "string" &&
                Textbox3.Text == "bool")
            {
                Question2_Check.Foreground = AppState.Btn_Orange;
                Question2_Check.BorderBrush = AppState.Btn_Orange;

                StackBlock4.Visibility = Visibility;
                StackBlock4.Height = Double.NaN;

                if (3 == AppState.Btn2)
                {
                    AppState.Btn2 = 4;
                }
                new PageFolder.MenuPage().SaveProc(sender, e);
            }

            if (Textbox1.Text == "int")
            {
                Textbox1.Foreground = AppState.Btn_Green;
                Textbox1.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox1.Foreground = AppState.Btn_Red;
                Textbox1.BorderBrush = AppState.Btn_Red;
            }

            if (Textbox2.Text == "string")
            {
                Textbox2.Foreground = AppState.Btn_Green;
                Textbox2.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox2.Foreground = AppState.Btn_Red;
                Textbox2.BorderBrush = AppState.Btn_Red;
            }

            if (Textbox3.Text == "bool")
            {
                Textbox3.Foreground = AppState.Btn_Green;
                Textbox3.BorderBrush = AppState.Btn_Green;
            }
            else
            {
                Textbox3.Foreground = AppState.Btn_Red;
                Textbox3.BorderBrush = AppState.Btn_Red;
            }
        }
    }
}