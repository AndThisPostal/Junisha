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
    /// Логика взаимодействия для Chapter_5_Page.xaml
    /// </summary>
    public partial class Chapter_5_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_5_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            if (AppState.Btn5 == 0)
            {
                AppState.Btn5 = 1;
            }

            if (AppState.Btn5 == 1)
            {
                StackBlock1.Visibility = Visibility;

            }

            //if (1 <= AppState.Btn5)
            //{
            //    StackBlock2.Visibility = Visibility;
            //    StackBlock2.Height = Double.NaN;
            //}
            //if (2 <= AppState.Btn5)
            //{
            //    StackBlock3.Visibility = Visibility;
            //    StackBlock3.Height = Double.NaN;
            //}
            //if (3 <= AppState.Btn5)
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
            //          .Where(p => p.chapter_id == 5)
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
            AppState.BtnTask = 0;
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AppState.BtnTask = 0;
            AppState.Btn5 = 3;
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_6_Page(_chaptersPage));
        }


        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (AppState.Btn5 >= 1) //Ерись ей богу, придёться с этой задачей чуть мудрить!!
            {
                if (Slider1 != null && AppState.Btn5 != 3)
                {
                    SliderQuest1.Text = "if (" + Math.Round(Slider1.Value) + " = 5)";
                    SliderQuest2.Text = "if (" + Math.Round(Slider2.Value) + " < 2)";
                    SliderQuest3.Text = "if (" + Math.Round(Slider3.Value) + " > 8)";
                }

                if (Slider1 != null && Math.Round(Slider1.Value) == 5)
                {
                    Slider1.Foreground = AppState.Btn_Green;
                }
                else if (Slider1 != null)
                {
                    Slider1.Foreground = AppState.Btn_Gray;
                }

                if (Slider2 != null && Math.Round(Slider2.Value) < 2)
                {
                    Slider2.Foreground = AppState.Btn_Green;
                }
                else if (Slider2 != null)
                {
                    Slider2.Foreground = AppState.Btn_Gray;
                }

                if (Slider3 != null && Math.Round(Slider3.Value) > 8)
                {
                    Slider3.Foreground = AppState.Btn_Green;
                }
                else if (Slider3 != null)
                {
                    Slider3.Foreground = AppState.Btn_Gray;
                }

                if (Slider1 != null && Math.Round(Slider1.Value) == 5 && Math.Round(Slider3.Value) > 8 && Math.Round(Slider2.Value) < 2)
                {
                    Text_2_Block.Visibility = Visibility;
                    Text_3_Block.Visibility = Visibility;
                    Text_2_Block.Height = Double.NaN;
                    Text_3_Block.Height = Double.NaN;
                }

            }


            
        }

        private void Btn_questz_Click(object sender, RoutedEventArgs e)
        {
            AppState.BtnTask = 1;
            StackBlock1.Visibility = Visibility;
            StackBlock1.Height = Double.NaN;
        }
    }
}