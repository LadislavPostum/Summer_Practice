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
    public partial class English_Exercises : Form
    {
        public English_Exercises()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private English_Main _EM;
        public English_Exercises(English_Main EM, int a, int b)
        {
            //Обработка события
            CallBackMyDDaughter.callbackEventHandler = new CallBackMyDDaughter.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            _EM = EM;

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
            _EM.Show();
            this.Close();
        }

        private void English_Exercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            English_EX_RusEn EXRE = new English_EX_RusEn(this, this.Top, this.Left);
            this.Hide();
            EXRE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            English_EX_EnRus EXER = new English_EX_EnRus(this, this.Top, this.Left);
            this.Hide();
            EXER.Show();
        }
    }
}
