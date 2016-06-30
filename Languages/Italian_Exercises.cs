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
    public partial class Italian_Exercises : Form
    {
        public Italian_Exercises()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Italian_Main _IM;
        public Italian_Exercises(Italian_Main IM, int a, int b)
        {
            //Обработка события
            CallBackMyDDaughter.callbackEventHandler = new CallBackMyDDaughter.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            _IM = IM;

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
            _IM.Show();
            this.Close();
        }

        private void Italian_Exercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Italian_EX_RusIt EXRI = new Italian_EX_RusIt(this, this.Top, this.Left);
            this.Hide();
            EXRI.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Italian_EX_ItRus EXIR = new Italian_EX_ItRus(this, this.Top, this.Left);
            this.Hide();
            EXIR.Show();
        }
    }
}
