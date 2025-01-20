using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Junisha_CSharp_Zero_App0
{
    internal class AppState
    {
        //Загрузка прогресса
        public static int UserID { get; set; } = 0;
        public static int Btn0 { get; set; } = 0;
        public static int Btn1 { get; set; } = 0;
        public static int Btn2 { get; set; } = 0;
        public static int Btn3 { get; set; } = 0;
        public static int Btn4 { get; set; } = 0;
        public static int Btn5 { get; set; } = 0;
        public static int Btn6 { get; set; } = 0;
        public static int Btn7 { get; set; } = 0;
        public static int Btn8 { get; set; } = 0;
        public static int Btn9 { get; set; } = 0;
        public static int Btn10 { get; set; } = 0;
        public static int Btn11 { get; set; } = 0;
        public static int Btn12 { get; set; } = 0;
        public static int Btn13 { get; set; } = 0;
        public static int Btn14 { get; set; } = 0;
        public static int Btn15 { get; set; } = 0;
        public static int BtnTask { get; set; } = 0;

        //Основные цвета
        public static Brush Btn_Red { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff6e42"));
        public static Brush Btn_Orange { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ff9d52"));
        public static Brush Btn_Gray { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a1a1a1"));
        public static Brush Btn_Green { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3CB365"));
        public static Brush Btn_Blue { get; set; } = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#76ABAE"));

    }
}
