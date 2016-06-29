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
    public partial class French_Help : Form
    {
        public French_Help()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private French_Main _FM;
        public French_Help(French_Main FM)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _FM = FM;

            CloseFlag = 1;

            toolTip1.SetToolTip(button1, "Назад");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            _FM.Show();
            this.Hide();
        }

        private void French_Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
