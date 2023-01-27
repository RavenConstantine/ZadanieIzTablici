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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "microsoft_Access_База_данныхDataSet.Таблица1". При необходимости она может быть перемещена или удалена.
            this.таблица1TableAdapter.Fill(this.microsoft_Access_База_данныхDataSet.Таблица1);

        }

        private void фильтр1ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            string FilterString = "";
            string [] FilterStrings = new string [4];
            int count = 0;
            if (фильтр1ToolStripMenuItem.Checked)
            {
                FilterStrings[count] = dataGridView1.Columns[1].DataPropertyName + " LIKE'А%'";
                count++;
            }
            if (фильтр2ToolStripMenuItem.Checked)
            {
                FilterStrings[count] = dataGridView1.Columns[3].DataPropertyName + " LIKE'Слово%'";
                count++;
            }
            if (фильтр3ToolStripMenuItem.Checked || фильтр4ToolStripMenuItem.Checked)
            {
                string[] MiniFilterStrings = new string[2];
                int MiniCount = 0;
                FilterStrings[count] += "(";
                if (фильтр3ToolStripMenuItem.Checked)
                {
                    MiniFilterStrings[MiniCount] = dataGridView1.Columns[2].DataPropertyName + " >= 200";
                    MiniCount++;
                }
                if (фильтр4ToolStripMenuItem.Checked)
                {
                    MiniFilterStrings[MiniCount] = dataGridView1.Columns[2].DataPropertyName + " < 200";
                    MiniCount++;
                }
                FilterStrings[count] += String.Join(" OR ", MiniFilterStrings.Where(x => !string.IsNullOrWhiteSpace(x)));
                FilterStrings[count] += ")";
                count++;
            }
            FilterString = String.Join(" AND ", FilterStrings.Where(x => !string.IsNullOrWhiteSpace(x)));
            if (FilterString != "")
                таблица1BindingSource.Filter = FilterString;
            else
                таблица1BindingSource.RemoveFilter();
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
