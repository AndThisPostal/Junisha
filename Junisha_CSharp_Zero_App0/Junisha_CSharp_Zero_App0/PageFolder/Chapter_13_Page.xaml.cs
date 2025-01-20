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
    /// Логика взаимодействия для Chapter_13_Page.xaml
    /// </summary>
    public partial class Chapter_13_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_13_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            if (1 <= AppState.Btn13)
            {
                StackBlock2.Visibility = Visibility;
                StackBlock2.Height = Double.NaN;
            }
            if (2 <= AppState.Btn13)
            {
                StackBlock3.Visibility = Visibility;
                StackBlock3.Height = Double.NaN;
            }
            if (3 <= AppState.Btn13)
            {
                Btn_Next.Visibility = Visibility;
            }

            //Загрузка текста из БД
            var CourseChapters = App.context.CourseChapters
                      .Where(p => p.chapter_id == 13)
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
            paragraphs = text3.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            foreach (string paragraph in paragraphs)
            {
                Text3.Inlines.Add(new Run(paragraph));
                Text3.Inlines.Add(new LineBreak());
                Text3.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            }
        }


        private void Question_1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Question1_True")
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
                StackBlock2.Visibility = Visibility;
                StackBlock2.Height = Double.NaN;

                if (0 == AppState.Btn13)
                {
                    AppState.Btn13 = 1;
                }
                new PageFolder.MenuPage().SaveProc(sender, e);

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

            if (button.Foreground == AppState.Btn_Gray)
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
            }
            else if (button.Foreground == AppState.Btn_Green)
            {
                button.Foreground = AppState.Btn_Gray;
                button.BorderBrush = AppState.Btn_Gray;
            }
        }



        private void Question_3_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Question3_True")
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
                Btn_Next.Visibility = Visibility;

                if (2 == AppState.Btn13)
                {
                    AppState.Btn13 = 3;
                }
                new PageFolder.MenuPage().SaveProc(sender, e);
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
            AppState.Btn13 = 3;
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_14_Page(_chaptersPage));
        }
    }
}