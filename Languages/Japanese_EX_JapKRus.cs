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
    public partial class Japanese_EX_JapKRus : Form
    {
        public Japanese_EX_JapKRus()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        int i, j = 0;
        private Japanese_Exercises _JE;
        public Japanese_EX_JapKRus(Japanese_Exercises JE, int a, int b)
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
            toolTip2.SetToolTip(button2, "Проверить кандзи");
            toolTip3.SetToolTip(button3, "Проверить перевод");
            toolTip4.SetToolTip(button4, "Следующее слово");

            this.tableTableAdapter.Fill(japanese_DataBaseDataSet.Table);

            i = this.japanese_DataBaseDataSet.Table.Rows.Count;

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
                this.label6.Text = "";
            }

            if (i != 0)
            {
                label4.Text = this.japanese_DataBaseDataSet.Table.Rows[j][2].ToString();
                label5.Text = this.japanese_DataBaseDataSet.Table.Rows[j][1].ToString();
                label6.Text = this.japanese_DataBaseDataSet.Table.Rows[j][3].ToString();
            }
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
            if (textBox1.Text != "")
            {
                String s = label5.Text.Replace(" ", "");
                String st = textBox1.Text.Replace(" ", "");
                if (st == s)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                String s = label6.Text.Replace(" ", "");
                String st = textBox2.Text.Replace(" ", "");
                if (st == s)
                {
                    textBox2.BackColor = Color.LightGreen;
                }
                else
                {
                    textBox2.BackColor = Color.LightCoral;
                    label6.Visible = true;
                }
                textBox2.ReadOnly = true;
            }       
        }

        private void Japanese_EX_JapKRus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label5.Visible = false;
            this.label6.Visible = false;
            this.textBox1.Text = "";
            this.textBox1.BackColor = Color.White;
            textBox1.ReadOnly = false;
            this.textBox2.Text = "";
            this.textBox2.BackColor = Color.White;
            textBox2.ReadOnly = false;

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
                this.label6.Text = "";
            }

            if (i != 0)
            {
                label4.Text = this.japanese_DataBaseDataSet.Table.Rows[j][2].ToString();
                label5.Text = this.japanese_DataBaseDataSet.Table.Rows[j][1].ToString();
                label6.Text = this.japanese_DataBaseDataSet.Table.Rows[j][3].ToString();
            }            
        }
    }
}
