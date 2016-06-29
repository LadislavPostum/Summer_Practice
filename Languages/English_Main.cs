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
        public English_Main(Form1 F1)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _f1 = F1;

            CloseFlag = 1;

            toolTip1.SetToolTip(button5, "Назад");
            toolTip2.SetToolTip(button1, "Добавить новые слова в базу данных");
            toolTip3.SetToolTip(button2, "Упражнения");
            toolTip4.SetToolTip(button3, "Помощь");
            toolTip5.SetToolTip(button4, "О программе");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            _f1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            English_Exercises EE = new English_Exercises(this);
            this.Hide();
            EE.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            English_Help EH = new English_Help(this);
            this.Hide();
            EH.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            English_About EA = new English_About(this);
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
    }
}
