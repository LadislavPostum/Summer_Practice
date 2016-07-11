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
    public partial class English_DataBase : Form
    {
        public English_DataBase()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        int CloseFlag;
        private English_Main _EM;
        public English_DataBase(English_Main EM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CloseFlag = 1;

            _EM = EM;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button5, "Назад");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.english_DataBaseDataSet);

        }

        private void English_DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "english_DataBaseDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.english_DataBaseDataSet.Table);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _EM.Show();
            this.Close();
        }

        private void English_DataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void tableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Необходимо ввести ID, слово на английском и перевод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}
