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
    public partial class Japanese_About : Form
    {
        public Japanese_About()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Japanese_Main _JM;
        public Japanese_About(Japanese_Main JM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _JM = JM;

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
            _JM.Show();
            this.Close();
        }

        private void Japanese_About_FormClosing(object sender, FormClosingEventArgs e)
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
