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
    public partial class French_About : Form
    {
        public French_About()
        {
            InitializeComponent();
        }

        int CloseFlag;
        private French_Main _FM;
        public French_About(French_Main FM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _FM = FM;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");

            this.linkLabel1 = new LinkLabel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            this.linkLabel1.LinkVisited = false;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _FM.Show();
            this.Close();
        }

        private void French_About_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/LadislavPostum");
            this.linkLabel1.LinkVisited = true;
        }
    }
}
