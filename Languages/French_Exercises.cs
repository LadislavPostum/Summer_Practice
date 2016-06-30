using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Languages
{
    public partial class French_Exercises : Form
    {
        public French_Exercises()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private French_Main _FM;
        public French_Exercises(French_Main FM, int a, int b)
        {
            //Обработка события
            CallBackMyDDaughter.callbackEventHandler = new CallBackMyDDaughter.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            _FM = FM;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Начать упражнение");
            toolTip3.SetToolTip(button3, "Начать упражнение");
        }

        //Задание новых координат формы
        public void Coord(int a, int b)
        {
            this.Top = a;
            this.Left = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _FM.Show();
            this.Close();
        }

        private void French_Exercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            French_EX_RusFr EXRF = new French_EX_RusFr(this, this.Top, this.Left);
            this.Hide();
            EXRF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            French_EX_FrRus EXFR = new French_EX_FrRus(this, this.Top, this.Left);
            this.Hide();
            EXFR.Show();
        }
    }
}
