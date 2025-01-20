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
    /// Логика взаимодействия для Chapter_9_Page.xaml
    /// </summary>
    public partial class Chapter_9_Page : Page
    {
        private readonly ChaptersPage _chaptersPage;
        public Chapter_9_Page(ChaptersPage chaptersPage)
        {
            InitializeComponent();
            _chaptersPage = chaptersPage;
            AppState.BtnTask = 0;
            Slider1.Value = 0;
            Slider2.Value = 0;
            CyclesTxt.Text = "";
        }


        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AppState.BtnTask = 0;
            ClassFrame.FrameBody.Navigate(new PageFolder.ChaptersPage());
        }

        private void Question5_Check_Click(object sender, RoutedEventArgs e)
        {
            AppState.BtnTask = 1;
            StackBlock5.Visibility = Visibility;
            StackBlock5.Height = Double.NaN;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Slider1 != null && AppState.BtnTask == 1)
            {

                if (Slider1 != null && Slider2 != null)
                {
                    double M = Math.Round(Slider1.Value);
                    double N = Math.Round(Slider2.Value);

                    SliderNumbers.Text = "N = " + N + "       M = " + M;

                    if (CyclesTxt != null)
                    {
                        CyclesTxt.Text = "";
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        M += N; // Вычисление M = M + N
                        CyclesTxt.Text += "M"+i+" = " + M.ToString() + " ";
                    }
                    AppState.Btn9 = 2;
                    Text_2_Block.Visibility = Visibility;
                    Text_2_Block.Height = Double.NaN;
                }
                
            }
        }
        private void Btn_Next_Click(object sender, RoutedEventArgs e)
        {
            AppState.BtnTask = 0;
            AppState.Btn9 = 3;
            ClassFrame.FrameBody.Navigate(new PageFolder.Chapter_10_Page(_chaptersPage));
        }


    }
}
