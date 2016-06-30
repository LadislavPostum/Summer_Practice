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

        int a, b;
        public Form1()
        {
            //Обработка события
            CallBackMy.callbackEventHandler = new CallBackMy.callbackEvent(this.Coord);

            InitializeComponent();

            this.MaximizeBox = false;

            toolTip1.SetToolTip(button1, "English");
            toolTip2.SetToolTip(button2, "Deutsch");
            toolTip3.SetToolTip(button3, "Français");
            toolTip4.SetToolTip(button4, "Italiano");
            toolTip5.SetToolTip(button5, "日本語"); 
        }

        //Задание новых координат формы
        private void Coord(int a, int b)
        {
            this.Top = a;
            this.Left = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = this.Top;
            b = this.Left;
            English_Main EM = new English_Main(this, a, b);
            this.Hide();
            EM.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = this.Top;
            b = this.Left;
            Germany_Main GM = new Germany_Main(this, a, b);
            this.Hide();
            GM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = this.Top;
            b = this.Left;
            French_Main FM = new French_Main(this, a, b);
            this.Hide();
            FM.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = this.Top;
            b = this.Left;
            Italian_Main IM = new Italian_Main(this, a, b);
            this.Hide();
            IM.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = this.Top;
            b = this.Left;
            Japanese_Main JM = new Japanese_Main(this, a, b);
            this.Hide();
            JM.Show();
        }       
    }
}
