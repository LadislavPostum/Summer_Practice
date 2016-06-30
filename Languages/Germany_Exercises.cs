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
    public partial class Germany_Exercises : Form
    {
        public Germany_Exercises()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Germany_Main _GM;
        public Germany_Exercises(Germany_Main GM, int a, int b)
        {
            //Обработка события
            CallBackMyDDaughter.callbackEventHandler = new CallBackMyDDaughter.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            _GM = GM;

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
            _GM.Show();
            this.Close();
        }

        private void Germany_Exercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Germany_EX_RusGe EXRG = new Germany_EX_RusGe(this, this.Top, this.Left);
            this.Hide();
            EXRG.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Germany_EX_GeRus EXGR = new Germany_EX_GeRus(this, this.Top, this.Left);
            this.Hide();
            EXGR.Show();
        }
    }
}
