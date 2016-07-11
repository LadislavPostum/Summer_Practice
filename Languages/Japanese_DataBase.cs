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
    public partial class Japanese_DataBase : Form
    {
        public Japanese_DataBase()
        {
            InitializeComponent();
        }

        int CloseFlag;
        private Japanese_Main _JM;
        public Japanese_DataBase(Japanese_Main JM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CloseFlag = 1;

            _JM = JM;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button5, "Назад");
            toolTip2.SetToolTip(button1, "Помощь");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.japanese_DataBaseDataSet);

        }

        private void Japanese_DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "japanese_DataBaseDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.japanese_DataBaseDataSet.Table);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CloseFlag = 0;
            CallBackMyDaughter.callbackEventHandler(this.Top, this.Left);
            _JM.Show();
            this.Close();
        }

        private void Japanese_DataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для добавления слова в базу данных нужно ввести:\n1) Порядковый номер\n2) Слово, записанное кандзи\n3) Слово, записанное каной\n4) Перевод на русский язык", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void tableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Необходимо ввести ID, слово, записанное кандзи, это же слово, записанное каной, и перевод!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
