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
    public partial class French_DataBase : Form
    {
        public French_DataBase()
        {
            InitializeComponent();
        }

        int CloseFlag;
        private French_Main _FM;
        public French_DataBase(French_Main FM, int a, int b)
        {
            InitializeComponent();

            this.MaximizeBox = false;

            CloseFlag = 1;

            _FM = FM;

            this.Top = a;
            this.Left = b;

            toolTip1.SetToolTip(button5, "Назад");
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.french_DataBaseDataSet);

        }

        private void French_DataBase_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "french_DataBaseDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.french_DataBaseDataSet.Table);

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void French_DataBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CloseFlag != 0)
            {
                Application.Exit();
            }
        }
    }
}
