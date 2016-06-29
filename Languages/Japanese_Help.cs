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
    public partial class Japanese_Help : Form
    {
        public Japanese_Help()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Japanese_Main _JM;
        public Japanese_Help(Japanese_Main JM)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _JM = JM;

            CloseFlag = 1;

            toolTip1.SetToolTip(button1, "Назад");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            _JM.Show();
            this.Close();
        }

        private void Japanese_Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
