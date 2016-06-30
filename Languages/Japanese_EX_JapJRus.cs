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
    public partial class Japanese_EX_JapJRus : Form
    {
        public Japanese_EX_JapJRus()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Japanese_Exercises _JE;
        public Japanese_EX_JapJRus(Japanese_Exercises JE, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _JE = JE;

            CloseFlag = 1;

            this.label5.Visible = false;
            this.label6.Visible = false;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Показать кану");
            toolTip3.SetToolTip(button3, "Показать перевод");
            toolTip4.SetToolTip(button4, "Следующее слово");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDDaughter.callbackEventHandler(this.Top, this.Left);
            _JE.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label5.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label6.Visible = true;
        }

        private void Japanese_EX_JapJRus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
