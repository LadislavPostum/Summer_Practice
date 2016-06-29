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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.MaximizeBox = false;

            toolTip1.SetToolTip(button1, "English");
            toolTip2.SetToolTip(button2, "Deutsch");
            toolTip3.SetToolTip(button3, "Français");
            toolTip4.SetToolTip(button4, "Italiano");
            toolTip5.SetToolTip(button5, "日本語");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            English_Main EM = new English_Main(this);
            this.Hide();
            EM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Germany_Main GM = new Germany_Main(this);
            this.Hide();
            GM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            French_Main FM = new French_Main(this);
            this.Hide();
            FM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Italian_Main IM = new Italian_Main(this);
            this.Hide();
            IM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           Japanese_Main JM = new Japanese_Main(this);
            this.Hide();
            JM.Show();
        }

        

    }
}
