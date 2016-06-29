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
    public partial class Germany_Main : Form
    {
        public Germany_Main()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Form1 _f1;
        public Germany_Main(Form1 F1)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _f1 = F1;

            CloseFlag = 1;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Добавить новые слова в базу данных");
            toolTip3.SetToolTip(button3, "Упражнения");
            toolTip4.SetToolTip(button4, "Помощь");
            toolTip5.SetToolTip(button5, "О программе");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            _f1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Germany_Exercises GE = new Germany_Exercises(this);
            this.Hide();
            GE.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Germany_Help GH = new Germany_Help(this);
            this.Hide();
            GH.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Germany_About GA = new Germany_About(this);
            this.Hide();
            GA.Show();
        }

        private void Germany_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }


    }
}
