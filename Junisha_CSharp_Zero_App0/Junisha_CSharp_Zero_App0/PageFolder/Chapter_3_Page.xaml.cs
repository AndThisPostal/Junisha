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
    /// Логика взаимодействия для Chapter_3_Page.xaml
    /// </summary>
    public partial class Chapter_3_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_3_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;

            if (1 <= AppState.Btn3)
            {
                StackBlock4.Visibility = Visibility;
                StackBlock4.Height = Double.NaN;
            }
            if (2 <= AppState.Btn3)
            {
                Text_2_Block.Visibility = Visibility;
                Text_2_Block.Height = Double.NaN;
            }
            if (3 <= AppState.Btn3)
            {
                Btn_Next.Visibility = Visibility;
            }
        }


        private void Question_1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (button.Name == "Question1_True")
            {
                button.Foreground = AppState.Btn_Green;
                button.BorderBrush = AppState.Btn_Green;
                StackBlock4.Visibility = Visibility;
                StackBlock4.Height = Double.NaN;

                if (0 == AppState.Btn3)
                {
                    AppState.Btn3 = 1;
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

        

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_4_Page(_chaptersPage));
        }

        private void Question4_Check_Click(object sender, RoutedEventArgs e)
        {
                // Получаем строку из выбранного элемента ComboBox
                string selectedItem1 = ComboBox1.SelectedItem.ToString();
                string selectedItem2 = ComboBox2.SelectedItem.ToString();
                string selectedItem3 = ComboBox3.SelectedItem.ToString();

                // Разделяем строку по символу ':' и пробелу, чтобы получить последнюю часть
                string[] parts1 = selectedItem1.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string[] parts2 = selectedItem2.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                string[] parts3 = selectedItem3.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);

                // Получаем последнее слово после ':'
                string lastPart1 = parts1[parts1.Length - 1].Trim();
                string lastPart2 = parts2[parts2.Length - 1].Trim();
                string lastPart3 = parts3[parts3.Length - 1].Trim();

                // lastPart будет содержать "Public" или другое последнее слово
                FunctionExemple.Text = lastPart1+" "+lastPart2 + " " + FunctionText.Text + " (" + lastPart3 +" NameVar)   { NameVar }";

            Text_2_Block.Visibility = Visibility;
            Text_2_Block.Height = Double.NaN;

            if (1 == AppState.Btn3)
            {
                AppState.Btn3 = 3;
            }
            new PageFolder.MenuPage().SaveProc(sender, e);
        }

    }
}