
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.букваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.цифраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.словоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microsoft_Access_База_данныхDataSet = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.вСЕToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтр1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтр2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтр3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фильтр4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уБРАТЬФИЛЬРЫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.таблица1TableAdapter = new WindowsFormsApp1.Microsoft_Access_База_данныхDataSetTableAdapters.Таблица1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.букваDataGridViewTextBoxColumn,
            this.цифраDataGridViewTextBoxColumn,
            this.словоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.таблица1BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(506, 285);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // букваDataGridViewTextBoxColumn
            // 
            this.букваDataGridViewTextBoxColumn.DataPropertyName = "Буква";
            this.букваDataGridViewTextBoxColumn.HeaderText = "Буква";
            this.букваDataGridViewTextBoxColumn.Name = "букваDataGridViewTextBoxColumn";
            // 
            // цифраDataGridViewTextBoxColumn
            // 
            this.цифраDataGridViewTextBoxColumn.DataPropertyName = "Цифра";
            this.цифраDataGridViewTextBoxColumn.HeaderText = "Цифра";
            this.цифраDataGridViewTextBoxColumn.Name = "цифраDataGridViewTextBoxColumn";
            // 
            // словоDataGridViewTextBoxColumn
            // 
            this.словоDataGridViewTextBoxColumn.DataPropertyName = "Слово";
            this.словоDataGridViewTextBoxColumn.HeaderText = "Слово";
            this.словоDataGridViewTextBoxColumn.Name = "словоDataGridViewTextBoxColumn";
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.microsoft_Access_База_данныхDataSet;
            // 
            // microsoft_Access_База_данныхDataSet
            // 
            this.microsoft_Access_База_данныхDataSet.DataSetName = "Microsoft_Access_База_данныхDataSet";
            this.microsoft_Access_База_данныхDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.toolStripDropDownButton1});
            this.bindingNavigator1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(506, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.AutoToolTip = false;
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вСЕToolStripMenuItem,
            this.фильтр1ToolStripMenuItem,
            this.фильтр2ToolStripMenuItem,
            this.фильтр3ToolStripMenuItem,
            this.фильтр4ToolStripMenuItem,
            this.уБРАТЬФИЛЬРЫToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 22);
            this.toolStripDropDownButton1.Text = "Фильтры";
            // 
            // вСЕToolStripMenuItem
            // 
            this.вСЕToolStripMenuItem.CheckOnClick = true;
            this.вСЕToolStripMenuItem.Name = "вСЕToolStripMenuItem";
            this.вСЕToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вСЕToolStripMenuItem.Text = "ВСЕ";
            this.вСЕToolStripMenuItem.CheckedChanged += new System.EventHandler(this.фильтр1ToolStripMenuItem_CheckedChanged);
            // 
            // фильтр1ToolStripMenuItem
            // 
            this.фильтр1ToolStripMenuItem.CheckOnClick = true;
            this.фильтр1ToolStripMenuItem.Name = "фильтр1ToolStripMenuItem";
            this.фильтр1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фильтр1ToolStripMenuItem.Text = "Фильтр 1";
            this.фильтр1ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.фильтр1ToolStripMenuItem_CheckedChanged);
            // 
            // фильтр2ToolStripMenuItem
            // 
            this.фильтр2ToolStripMenuItem.CheckOnClick = true;
            this.фильтр2ToolStripMenuItem.Name = "фильтр2ToolStripMenuItem";
            this.фильтр2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фильтр2ToolStripMenuItem.Text = "Фильтр 2";
            this.фильтр2ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.фильтр1ToolStripMenuItem_CheckedChanged);
            // 
            // фильтр3ToolStripMenuItem
            // 
            this.фильтр3ToolStripMenuItem.CheckOnClick = true;
            this.фильтр3ToolStripMenuItem.Name = "фильтр3ToolStripMenuItem";
            this.фильтр3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фильтр3ToolStripMenuItem.Text = "Фильтр 3";
            this.фильтр3ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.фильтр1ToolStripMenuItem_CheckedChanged);
            // 
            // фильтр4ToolStripMenuItem
            // 
            this.фильтр4ToolStripMenuItem.CheckOnClick = true;
            this.фильтр4ToolStripMenuItem.Name = "фильтр4ToolStripMenuItem";
            this.фильтр4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.фильтр4ToolStripMenuItem.Text = "Фильтр 4";
            this.фильтр4ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.фильтр1ToolStripMenuItem_CheckedChanged);
            // 
            // уБРАТЬФИЛЬРЫToolStripMenuItem
            // 
            this.уБРАТЬФИЛЬРЫToolStripMenuItem.CheckOnClick = true;
            this.уБРАТЬФИЛЬРЫToolStripMenuItem.Name = "уБРАТЬФИЛЬРЫToolStripMenuItem";
            this.уБРАТЬФИЛЬРЫToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.уБРАТЬФИЛЬРЫToolStripMenuItem.Text = "УБРАТЬ ФИЛЬРЫ";
            this.уБРАТЬФИЛЬРЫToolStripMenuItem.CheckedChanged += new System.EventHandler(this.фильтр1ToolStripMenuItem_CheckedChanged);
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 313);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microsoft_Access_База_данныхDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem фильтр1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтр2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фильтр3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вСЕToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уБРАТЬФИЛЬРЫToolStripMenuItem;
        private Microsoft_Access_База_данныхDataSet microsoft_Access_База_данныхDataSet;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private Microsoft_Access_База_данныхDataSetTableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn букваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn цифраDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn словоDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem фильтр4ToolStripMenuItem;
    }
}

