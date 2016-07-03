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
    public partial class English_EX_EnRus : Form
    {
        public English_EX_EnRus()
        {
            InitializeComponent();
        }

        int i, j = 0;
        int CloseFlag;
        private English_Exercises _EE;
        public English_EX_EnRus(English_Exercises EE, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            this.label5.Visible = false;

            _EE = EE;

            CloseFlag = 1;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button1, "Назад");
            toolTip2.SetToolTip(button2, "Показать перевод");
            toolTip3.SetToolTip(button3, "Следующее слово");

            this.tableTableAdapter.Fill(this.english_DataBaseDataSet.Table);

            i = this.english_DataBaseDataSet.Table.Rows.Count;

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
                label4.Text = this.english_DataBaseDataSet.Table.Rows[j][1].ToString();
                label5.Text = this.english_DataBaseDataSet.Table.Rows[j][2].ToString();
            }
        }
        
        private void English_EX_EnRus_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDDaughter.callbackEventHandler(this.Top, this.Left);
            _EE.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.label5.Visible = false;

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
                label4.Text = this.english_DataBaseDataSet.Table.Rows[j][1].ToString();
                label5.Text = this.english_DataBaseDataSet.Table.Rows[j][2].ToString();
            }            
        }

    }
}
