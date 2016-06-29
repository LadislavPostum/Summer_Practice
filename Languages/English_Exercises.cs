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
        public English_Exercises(English_Main EM)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _EM = EM;

            CloseFlag = 1;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Начать упражнение");
            toolTip3.SetToolTip(button3, "Начать упражнение");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
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
    }
}
