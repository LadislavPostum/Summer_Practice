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
    public partial class Italian_DataBase : Form
    {
        public Italian_DataBase()
        {
            InitializeComponent();
        }

        int CloseFlag;
        private Italian_Main _IM;
        public Italian_DataBase(Italian_Main IM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CloseFlag = 1;

            _IM = IM;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button5, "Назад");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.italian_DataBaseDataSet);

        }

        private void Italian_DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "italian_DataBaseDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.italian_DataBaseDataSet.Table);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _IM.Show();
            this.Close();
        }

        private void Italian_DataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void tableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Необходимо ввести ID, слово на итальянском и перевод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
