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
    public partial class Italian_EX_RusIt : Form
    {
        public Italian_EX_RusIt()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        int i, j = 0;
        private Italian_Exercises _IE;
        public Italian_EX_RusIt(Italian_Exercises IE, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CloseFlag = 1;

            _IE = IE;

            this.Top = a;
            this.Left = b;

            this.label5.Visible = false;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Проверить");
            toolTip3.SetToolTip(button3, "Следующее слово");

            this.tableTableAdapter.Fill(italian_DataBaseDataSet.Table);

            i = this.italian_DataBaseDataSet.Table.Rows.Count;

            String s1 = i.ToString();
            label2.Text = s1;

            Random rand = new Random();
            int k = 0;
            if (i != 0)
            {
                j = rand.Next(i);
                k = j + 1;
            }

            String s2 = k.ToString();
            label1.Text = s2;

            if (i == 0)
            {
                this.label4.Text = "";
                this.label5.Text = "";
            }

            if (i != 0)
            {
                label4.Text = this.italian_DataBaseDataSet.Table.Rows[j][2].ToString();
                label5.Text = this.italian_DataBaseDataSet.Table.Rows[j][1].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDDaughter.callbackEventHandler(this.Top, this.Left);
            _IE.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                String s = label5.Text.Replace(" ", "");
                if (textBox1.Text == s)
                {
                    textBox1.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox1.BackColor = Color.LightCoral;
                    label5.Visible = true;
                }
                textBox1.ReadOnly = true;
            }       
        }

        private void Italian_EX_RusIt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.textBox1.Text = "";
            this.textBox1.BackColor = Color.White;
            textBox1.ReadOnly = false;

            int l = j;
            Random rand = new Random();
            int k = 0;
            if (i != 0)
            {
                if (i != 1)
                {
                    while (l == j)
                    {
                        j = rand.Next(i);
                        k = j + 1;
                    }
                }
                else k = 1;
            }

            String s2 = k.ToString();
            label1.Text = s2;

            if (i == 0)
            {
                this.label4.Text = "";
                this.label5.Text = "";
            }

            if (i != 0)
            {
                label4.Text = this.italian_DataBaseDataSet.Table.Rows[j][2].ToString();
                label5.Text = this.italian_DataBaseDataSet.Table.Rows[j][1].ToString();
            }            
        }
    }
}
