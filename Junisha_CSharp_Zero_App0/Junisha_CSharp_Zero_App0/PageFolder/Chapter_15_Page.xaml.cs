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
    /// Логика взаимодействия для Chapter_15_Page.xaml
    /// </summary>
    public partial class Chapter_15_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_15_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            //if (1 <= AppState.Btn15)
            //{
            //    StackBlock2.Visibility = Visibility;
            //    StackBlock2.Height = Double.NaN;
            //}
            //if (2 <= AppState.Btn15)
            //{
            //    StackBlock3.Visibility = Visibility;
            //    StackBlock3.Height = Double.NaN;
            //}
            //if (3 <= AppState.Btn15)
            //{
            //    Btn_Next.Visibility = Visibility;
            //}

            //Question2_1.Foreground = AppState.Btn_Gray;
            //Question2_2.Foreground = AppState.Btn_Gray;
            //Question2_3.Foreground = AppState.Btn_Gray;
            //Question2_4.Foreground = AppState.Btn_Gray;

            //Question2_1.BorderBrush = AppState.Btn_Gray;
            //Question2_2.BorderBrush = AppState.Btn_Gray;
            //Question2_3.BorderBrush = AppState.Btn_Gray;
            //Question2_4.BorderBrush = AppState.Btn_Gray;

            //Загрузка текста из БД
            var CourseChapters = App.context.CourseChapters
                      .Where(p => p.chapter_id == 15)
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

            //// Разделение текста на абзацы
            //paragraphs = text2.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            //foreach (string paragraph in paragraphs)
            //{
            //    Text2.Inlines.Add(new Run(paragraph));
            //    Text2.Inlines.Add(new LineBreak());
            //    Text2.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            //}

            //// Разделение текста на абзацы
            //paragraphs = text3.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            //foreach (string paragraph in paragraphs)
            //{
            //    Text3.Inlines.Add(new Run(paragraph));
            //    Text3.Inlines.Add(new LineBreak());
            //    Text3.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            //}
        }


        //private void Question_1_Click(object sender, RoutedEventArgs e)
        //{
        //    Button button = (Button)sender;

        //    if (button.Name == "Question1_True")
        //    {
        //        button.Foreground = AppState.Btn_Green;
        //        button.BorderBrush = AppState.Btn_Green;
        //        StackBlock2.Visibility = Visibility;
        //        StackBlock2.Height = Double.NaN;

        //        if (0 == AppState.Btn15)
        //        {
        //            AppState.Btn15 = 1;
        //        }
        //        new PageFolder.MenuPage().SaveProc(sender, e);

        //        Question1_False_1.Foreground = AppState.Btn_Red;
        //        Question1_False_1.BorderBrush = AppState.Btn_Red;
        //        Question1_False_2.Foreground = AppState.Btn_Red;
        //        Question1_False_2.BorderBrush = AppState.Btn_Red;
        //        Question1_False_3.Foreground = AppState.Btn_Red;
        //        Question1_False_3.BorderBrush = AppState.Btn_Red;
        //    }
        //    else
        //    {
        //        button.Foreground = AppState.Btn_Red;
        //        button.BorderBrush = AppState.Btn_Red;
        //    }
        //}

        //private void Question_2_Click(object sender, RoutedEventArgs e)
        //{
        //    Button button = (Button)sender;

        //    if (button.Foreground == AppState.Btn_Gray)
        //    {
        //        button.Foreground = AppState.Btn_Green;
        //        button.BorderBrush = AppState.Btn_Green;
        //    }
        //    else if (button.Foreground == AppState.Btn_Green)
        //    {
        //        button.Foreground = AppState.Btn_Gray;
        //        button.BorderBrush = AppState.Btn_Gray;
        //    }
        //}

        //private void Question2_Check_Click(object sender, RoutedEventArgs e)
        //{
        //    if (Question2_1.Foreground == AppState.Btn_Gray &&
        //        Question2_2.Foreground == AppState.Btn_Gray &&
        //        Question2_3.Foreground == AppState.Btn_Gray &&
        //        Question2_4.Foreground == AppState.Btn_Gray)
        //    {
        //        Question2_1.Foreground = AppState.Btn_Orange;
        //        Question2_2.Foreground = AppState.Btn_Orange;
        //        Question2_3.Foreground = AppState.Btn_Orange;
        //        Question2_4.Foreground = AppState.Btn_Orange;

        //        Question2_1.BorderBrush = AppState.Btn_Orange;
        //        Question2_2.BorderBrush = AppState.Btn_Orange;
        //        Question2_3.BorderBrush = AppState.Btn_Orange;
        //        Question2_4.BorderBrush = AppState.Btn_Orange;

        //        Question2_Check.Foreground = AppState.Btn_Red;
        //        Question2_Check.BorderBrush = AppState.Btn_Red;

        //        StackBlock3.Visibility = Visibility;
        //        StackBlock3.Height = Double.NaN;

        //        if (1 == AppState.Btn15)
        //        {
        //            AppState.Btn15 = 2;
        //        }
        //        new PageFolder.MenuPage().SaveProc(sender, e);
        //    }
        //}


        //private void Question_3_Click(object sender, RoutedEventArgs e)
        //{
        //    Button button = (Button)sender;

        //    if (button.Name == "Question3_True")
        //    {
        //        button.Foreground = AppState.Btn_Green;
        //        button.BorderBrush = AppState.Btn_Green;
        //        AppState.Btn15_Background = AppState.Btn_Orange;
        //        Btn_Next.Visibility = Visibility;

        //        if (2 == AppState.Btn15)
        //        {
        //            AppState.Btn15 = 3;
        //        }
        //        if (3 == AppState.Btn15)
        //        {
        //            AppState.Btn15 = 3+21;
        //        }
        //        new PageFolder.MenuPage().SaveProc(sender, e);
        //    }
        //    else
        //    {
        //        button.Foreground = AppState.Btn_Red;
        //        button.BorderBrush = AppState.Btn_Red;
        //    }
        //}

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AppState.Btn15 = 3;
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }
    }
}