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
    public partial class English_About : Form
    {
        public English_About()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private English_Main _EM;
        public English_About(English_Main EM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _EM = EM;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _EM.Show();
            this.Close();
        }

        private void English_About_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
