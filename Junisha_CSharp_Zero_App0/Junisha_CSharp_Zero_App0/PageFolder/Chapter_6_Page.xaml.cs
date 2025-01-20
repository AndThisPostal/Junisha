using Junisha_CSharp_Zero_App0.ClassFolder;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Chapter_6_Page.xaml
    /// </summary>
    public partial class Chapter_6_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_6_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            //Загрузка текста из БД
            var CourseChapters = App.context.CourseChapters
                      .Where(p => p.chapter_id == 6)
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

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AppState.Btn6 = 3;
            new PageFolder.MenuPage().SaveProc(sender, e);
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_7_Page(_chaptersPage));
        }

        private void Btn_Link1(object sender, RoutedEventArgs e)
        {
            Process.Start("https://obsidian.md/");
        }

        private void Btn_Link2(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.ixbt.com/live/sw/obzor-obsidian-soft-dlya-zametok-kotoryy-sozdaet-vtoroy-mozg.html");
        }

        private void Btn_Link3(object sender, RoutedEventArgs e)
        {
            Process.Start("https://youtu.be/PiS3pRRj994");
        }
    }
}