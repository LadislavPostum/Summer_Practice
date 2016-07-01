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
    public partial class English_Main : Form
    {
        public English_Main()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Form1 _f1;
        public English_Main(Form1 F1, int a, int b)
        {
            //Обработка события
            CallBackMyDaughter.callbackEventHandler = new CallBackMyDaughter.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            _f1 = F1;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button5, "Назад");
            toolTip2.SetToolTip(button1, "Добавить новые слова в базу данных");
            toolTip3.SetToolTip(button2, "Упражнения");
            toolTip4.SetToolTip(button3, "Помощь");
            toolTip5.SetToolTip(button4, "О программе");
        }

        //Задание новых координат формы
        private void Coord(int a, int b)
        {
            this.Top = a;
            this.Left = b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMy.callbackEventHandler(this.Top, this.Left);
            _f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            English_Exercises EE = new English_Exercises(this, this.Top, this.Left);
            this.Hide();
            EE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            English_Help EH = new English_Help(this, this.Top, this.Left);
            this.Hide();
            EH.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            English_About EA = new English_About(this, this.Top, this.Left);
            this.Hide();
            EA.Show();
        }

        private void English_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            English_DataBase EDTB = new English_DataBase(this, this.Top, this.Left);
            this.Hide();
            EDTB.Show();
        }        
    }
}
