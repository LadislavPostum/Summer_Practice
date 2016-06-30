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
    public partial class Germany_Help : Form
    {
        public Germany_Help()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Germany_Main _GM;
        public Germany_Help(Germany_Main GM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _GM = GM;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _GM.Show();
            this.Close();
        }

        private void Germany_Help_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
