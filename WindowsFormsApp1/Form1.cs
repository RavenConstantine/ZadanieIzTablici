using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "geografiaDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.geografiaDataSet.View_1);

        }

        private void фильтр1ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            view1BindingSource.RemoveFilter();
            string FilterString = "";
            if (фильтр1ToolStripMenuItem.Checked)
            {
                FilterString += " AND " + dataGridView1.Columns[0].DataPropertyName + " LIKE'Буквы%'";
            }
            if (фильтр2ToolStripMenuItem.Checked)
            {
                FilterString += " AND " + dataGridView1.Columns[1].DataPropertyName + " LIKE'Слово%'";
            }
            if (фильтр3ToolStripMenuItem.Checked)
            {
                FilterString += " AND " + dataGridView1.Columns[2].DataPropertyName + " >= 200";
            }
            if (FilterString != "")
                view1BindingSource.Filter = FilterString.Remove(0, 5);
            if (вСЕToolStripMenuItem.Checked)
                foreach (ToolStripMenuItem item in toolStripDropDownButton1.DropDownItems)
                {
                    if (item != уБРАТЬФИЛЬРЫToolStripMenuItem)
                        item.Checked = true;
                    if (item == вСЕToolStripMenuItem)
                        item.Checked = false;
                }
            if (уБРАТЬФИЛЬРЫToolStripMenuItem.Checked)
                foreach (ToolStripMenuItem item in toolStripDropDownButton1.DropDownItems)
                {
                    item.Checked = false;
                }
        }
    }
}
