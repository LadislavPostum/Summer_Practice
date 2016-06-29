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
        public Japanese_Exercises(Japanese_Main JM)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _JM = JM;

            CloseFlag = 1;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Начать упражнение");
            toolTip3.SetToolTip(button3, "Начать упражнение");
            toolTip4.SetToolTip(button4, "Начать упражнение");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
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
    }
}
