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
    public partial class Japanese_Exercises : Form
    {
        public Japanese_Exercises()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Japanese_Main _JM;
        public Japanese_Exercises(Japanese_Main JM, int a, int b)
        {
            //Обработка события
            CallBackMyDDaughter.callbackEventHandler = new CallBackMyDDaughter.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            _JM = JM;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Начать упражнение");
            toolTip3.SetToolTip(button3, "Начать упражнение");
            toolTip4.SetToolTip(button4, "Начать упражнение");
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
            _JM.Show();
            this.Close();
        }

        private void Japanese_Exercises_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Japanese_EX_RusJap EXRJ = new Japanese_EX_RusJap(this, this.Top, this.Left);
            this.Hide();
            EXRJ.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Japanese_EX_JapJRus EXJR = new Japanese_EX_JapJRus(this, this.Top, this.Left);
            this.Hide();
            EXJR.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Japanese_EX_JapKRus EXKR = new Japanese_EX_JapKRus(this, this.Top, this.Left);
            this.Hide();
            EXKR.Show();
        }
    }
}
