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
    public partial class Germany_EX_RusGe : Form
    {
        public Germany_EX_RusGe()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private Germany_Exercises _GE;
        public Germany_EX_RusGe(Germany_Exercises GE, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            _GE = GE;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            this.label5.Visible = false;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Показать перевод");
            toolTip3.SetToolTip(button3, "Следующее слово");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDDaughter.callbackEventHandler(this.Top, this.Left);
            _GE.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label5.Visible = true;
        }

        private void Germany_EX_RusGe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
