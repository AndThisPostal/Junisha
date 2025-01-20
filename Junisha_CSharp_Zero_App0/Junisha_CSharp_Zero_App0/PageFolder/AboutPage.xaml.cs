using Junisha_CSharp_Zero_App0.ClassFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
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
    /// Логика взаимодействия для AboutPage.xaml
    /// </summary>
    public partial class AboutPage : Page
    {
        public AboutPage()
        {
            InitializeComponent();
            ProgressProc();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageFolder.MenuPage());
        }
        public void ProgressProc()
        {
            var saves = new[]
            {
                AppState.Btn1, AppState.Btn2, AppState.Btn3, AppState.Btn4, AppState.Btn5,
                AppState.Btn6, AppState.Btn7, AppState.Btn8, AppState.Btn9, AppState.Btn10,
                AppState.Btn11, AppState.Btn12, AppState.Btn13, AppState.Btn14, AppState.Btn15
            };

            double progressUser = 0;
            double progressAll = 0;

            for (int i = 0; i < saves.Length; i++)
            {
                progressUser += saves[i];
                progressAll += 3;
            }

            double progressTxt = Math.Round(((progressUser / (progressAll+1)) * 100), 0);


            ProgresTextblock.Text = "Курс пройден на " + progressTxt + "%";
            ProgressPB.Value = progressTxt;

            
            //if (AppState.Btn15 == 3 + 21)
            //{
            //    ProgresTextblock.Foreground = AppState.Btn_Green;
            //    Border.BorderBrush = AppState.Btn_Green;
            //    ProgressPB.Foreground = AppState.Btn_Green;
            //}

        }

        private void Btn_reset_Click(object sender, RoutedEventArgs e)
        {
            // Код для извлечения сохранения из БД
            var progressRecord = App.context.Progress
                      .Where(p => p.user_id == AppState.UserID)
                      .FirstOrDefault();
            
            //На случай поломки:
            progressRecord.progress_data = "0,0,0,0,0,0,0,0,0,0,0,0,0,0,0";

            Btn_reset.Foreground = AppState.Btn_Gray;
            Btn_reset.BorderBrush = AppState.Btn_Gray;

            AppState.Btn1 = 0;
            AppState.Btn2 = 0;
            AppState.Btn3 = 0;
            AppState.Btn4 = 0;
            AppState.Btn5 = 0;

            AppState.Btn6 = 0;
            AppState.Btn7 = 0;
            AppState.Btn8 = 0;
            AppState.Btn9 = 0;
            AppState.Btn10 = 0;

            AppState.Btn11 = 0;
            AppState.Btn12 = 0;
            AppState.Btn13 = 0;
            AppState.Btn14 = 0;
            AppState.Btn15 = 0;

            ProgressProc();
        }
    }
}
