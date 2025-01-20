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
    /// Логика взаимодействия для Chapter_8_Page.xaml
    /// </summary>
    public partial class Chapter_8_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        private string[] myArray;
        public Chapter_8_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;
            myArray = new string[20];

            //if (1 <= AppState.Btn8)
            //{
            //    StackBlock2.Visibility = Visibility;
            //    StackBlock2.Height = Double.NaN;
            //}
            //if (2 <= AppState.Btn8)
            //{
            //    StackBlock3.Visibility = Visibility;
            //    StackBlock3.Height = Double.NaN;
            //}
            //if (3 <= AppState.Btn8)
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

            ////Загрузка текста из БД
            //var CourseChapters = App.context.CourseChapters
            //          .Where(p => p.chapter_id == 8)
            //          .FirstOrDefault();

            ////Для деления на абзацы: \n\n
            //ChapterName.Text = CourseChapters.chapter_title;
            //string text1 = CourseChapters.chapter_content1;
            //string text2 = CourseChapters.chapter_content2;
            //string text3 = CourseChapters.chapter_content3;

            //// Разделение текста на абзацы
            //string[] paragraphs = text1.Split(new string[] { "\n\n" }, StringSplitOptions.None);

            //foreach (string paragraph in paragraphs)
            //{
            //    Text1.Inlines.Add(new Run(paragraph));
            //    Text1.Inlines.Add(new LineBreak());
            //    Text1.Inlines.Add(new LineBreak()); // Дополнительный LineBreak для разделения абзацев
            //}

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

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_9_Page(_chaptersPage));
        }

        private void Question2_Check_Click_1(object sender, RoutedEventArgs e)
        {
            // Добавляем текст из текстбокса в массив
            if (!string.IsNullOrEmpty(TextBlock1.Text))
            {
                TextBlock1.Text = "";
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] == null)
                    {
                        myArray[i] = Textbox1.Text;
                        break;
                    }
                    else
                    {
                        TextBlock1.Text += " " + myArray[i] + ",";
                    }
                }
                TextBlock1.Text = "string[] words = { " + TextBlock1.Text + " };";

                last_text.Visibility = Visibility;
                last_text.Height = Double.NaN;
                Btn_Next.Visibility = Visibility;
                Btn_Next.Height = Double.NaN;
                
                AppState.Btn8 = 3;
                new PageFolder.MenuPage().SaveProc(sender, e);
            }
        }
    }
}