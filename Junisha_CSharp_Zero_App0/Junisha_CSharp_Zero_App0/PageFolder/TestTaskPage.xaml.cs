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
    /// Логика взаимодействия для TestTaskPage.xaml
    /// </summary>
    public partial class TestTaskPage : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public TestTaskPage(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            if (1 <= AppState.BtnTask)
            {
                StackBlock2.Visibility = Visibility;
                StackBlock2.Height = Double.NaN;
            }
            if (2 <= AppState.BtnTask)
            {
                StackBlock3.Visibility = Visibility;
                StackBlock3.Height = Double.NaN;
            }
            if (3 <= AppState.BtnTask)
            {
                Btn_Next.Visibility = Visibility;
            }

            //Загрузка текста из БД
            var CourseChapters = App.context.CourseChapters
                      .Where(p => p.chapter_id == 14)
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

                if (0 == AppState.BtnTask)
                {
                    AppState.BtnTask = 1;
                }
                new PageFolder.MenuPage().SaveProc(sender, e);

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

        private void Question2_Check_Click(object sender, RoutedEventArgs e)
        {
            if (Textbox1.Text == "int" &&
                Textbox2.Text == "string" &&
                Textbox3.Text == "bool")
            {
                Question2_Check.Foreground = AppState.Btn_Orange;
                Question2_Check.BorderBrush = AppState.Btn_Orange;

                StackBlock3.Visibility = Visibility;
                StackBlock3.Height = Double.NaN;

                if (1 == AppState.BtnTask)
                {
                    AppState.BtnTask = 2;
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


        private void Question3_Check_Click(object sender, RoutedEventArgs e)
        {

            if (ListBox1.SelectedItem == null)
            {
                Question3_Check.Foreground = AppState.Btn_Gray;
                Question3_Check.BorderBrush = AppState.Btn_Gray;
            }

            if (ListBox1.SelectedItem != null)
            {
                Question3_Check.Foreground = AppState.Btn_Green;
                Question3_Check.BorderBrush = AppState.Btn_Green;

                Tested.Text = ListBox1.SelectedItem.ToString();


                if (ListBox1.SelectedItem.ToString() == "System.Windows.Controls.ListBoxItem: int")
                {
                    Question3_Check.Foreground = AppState.Btn_Orange;
                    Question3_Check.BorderBrush = AppState.Btn_Orange;

                    StackBlock4.Visibility = Visibility;
                    StackBlock4.Height = Double.NaN;

                    if (2 == AppState.BtnTask)
                    {
                        AppState.BtnTask = 3;
                    }
                    new PageFolder.MenuPage().SaveProc(sender, e);
                }
            }
        }

        private void Question4_Check_Click(object sender, RoutedEventArgs e)
        {
            if (ComboBox1.SelectedItem == null)
            {
                Question4_Check.Foreground = AppState.Btn_Gray;
                Question4_Check.BorderBrush = AppState.Btn_Gray;
            }

            if (ComboBox1.SelectedItem != null)
            {
                Question4_Check.Foreground = AppState.Btn_Green;
                Question4_Check.BorderBrush = AppState.Btn_Green;

                Tested.Text = ComboBox1.SelectedItem.ToString();


                if (ComboBox1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: int")
                {
                    Question4_Check.Foreground = AppState.Btn_Orange;
                    Question4_Check.BorderBrush = AppState.Btn_Orange;

                    StackBlock5.Visibility = Visibility;
                    StackBlock5.Height = Double.NaN;

                    if (3 == AppState.BtnTask)
                    {
                        AppState.BtnTask = 4;
                    }
                    new PageFolder.MenuPage().SaveProc(sender, e);

                }
            }

        }

        private void Question5_Check_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (AppState.BtnTask >= 3) //Ерись ей богу, придёться с этой задачей чуть мудрить!!
            {
                if (Slider != null && Math.Round(Slider.Value) == 30)
                {
                    Question5_Check.Foreground = AppState.Btn_Orange;
                    Question5_Check.BorderBrush = AppState.Btn_Orange;
                    Slider.Foreground = AppState.Btn_Orange;
                }
                else if (Slider != null && Slider.Value >= 20 && Slider.Value <= 40)
                {
                    Question5_Check.Foreground = AppState.Btn_Green;
                    Question5_Check.BorderBrush = AppState.Btn_Green;
                    Slider.Foreground = AppState.Btn_Green;
                }
                else
                {
                    Question5_Check.Foreground = AppState.Btn_Gray;
                    Question5_Check.BorderBrush = AppState.Btn_Gray;
                    Slider.Foreground = AppState.Btn_Gray;
                }
                Question5_Check.Content = Math.Round(Slider.Value).ToString();
            }
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AppState.BtnTask = 3;
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_15_Page(_chaptersPage));
        }

        
    }
}