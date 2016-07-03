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
    public partial class Germany_DataBase : Form
    {
        public Germany_DataBase()
        {
            InitializeComponent();
        }

        int CloseFlag;
        private Germany_Main _GM;
        public Germany_DataBase(Germany_Main GM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CloseFlag = 1;

            _GM = GM;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button5, "Назад");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.germany_DataBaseDataSet);

        }

        private void Germany_DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "germany_DataBaseDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.germany_DataBaseDataSet.Table);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _GM.Show();
            this.Close();
        }

        private void Germany_DataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
