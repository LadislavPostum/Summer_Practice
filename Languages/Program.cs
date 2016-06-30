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

    //Возврат в вызывающую главную форму координат вызываемой
    public static class CallBackMy
    {
        public delegate void callbackEvent(int a, int b);
        public static callbackEvent callbackEventHandler;
    }

    //Возврат в вызывающую форму координат вызываемой
    public static class CallBackMyDaughter
    {
        public delegate void callbackEvent(int a, int b);
        public static callbackEvent callbackEventHandler;
    }
}
