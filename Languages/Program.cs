using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Languages
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    //Уровень - глубина переходов в формах относительно первой формы
    //Например, первый уровень - окно English_Main
    //Второй уровень - окно English_Exercises
    //Третий уровень - окно English_EX_RusEn

    //Возврат в вызывающую главную форму координат вызываемой (уровень 1)
    public static class CallBackMy
    {
        public delegate void callbackEvent(int a, int b);
        public static callbackEvent callbackEventHandler;
    }

    //Возврат в вызывающую форму координат вызываемой (уровень 2)
    public static class CallBackMyDaughter
    {
        public delegate void callbackEvent(int a, int b);
        public static callbackEvent callbackEventHandler;
    }

    //Возврат в вызывающую форму коорднат вызываемой (уровень 3)
    public static class CallBackMyDDaughter
    {
        public delegate void callbackEvent(int a, int b);
        public static callbackEvent callbackEventHandler;
    }
}
