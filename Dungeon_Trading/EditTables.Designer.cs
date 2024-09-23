namespace Dungeon_Trading
{
    partial class EditTables
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTables));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.A1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.С3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.В3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.saveTownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.A0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.C2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.D3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.E4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.saveGoodsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(245, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(719, 394);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(711, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Towns";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A1,
            this.B2,
            this.С3,
            this.В3});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(705, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // A1
            // 
            this.A1.HeaderText = "Имя поселения";
            this.A1.Name = "A1";
            // 
            // B2
            // 
            dataGridViewCellStyle7.Format = "N2";
            dataGridViewCellStyle7.NullValue = "1";
            this.B2.DefaultCellStyle = dataGridViewCellStyle7;
            this.B2.HeaderText = "Тип поселения";
            this.B2.Name = "B2";
            this.B2.ToolTipText = "См. подсказку слева";
            // 
            // С3
            // 
            this.С3.HeaderText = "Макс. Покуп. Способн.";
            this.С3.Name = "С3";
            // 
            // В3
            // 
            dataGridViewCellStyle8.Format = "N2";
            dataGridViewCellStyle8.NullValue = "1";
            this.В3.DefaultCellStyle = dataGridViewCellStyle8;
            this.В3.HeaderText = "Богатство";
            this.В3.Name = "В3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveTownToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saveTownToolStripMenuItem
            // 
            this.saveTownToolStripMenuItem.Name = "saveTownToolStripMenuItem";
            this.saveTownToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.saveTownToolStripMenuItem.Text = "Save";
            this.saveTownToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(711, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Goods";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.A0,
            this.B1,
            this.C2,
            this.D3,
            this.E4});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 27);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(705, 336);
            this.dataGridView2.TabIndex = 1;
            // 
            // A0
            // 
            this.A0.HeaderText = "Название";
            this.A0.Name = "A0";
            // 
            // B1
            // 
            dataGridViewCellStyle9.NullValue = "0";
            this.B1.DefaultCellStyle = dataGridViewCellStyle9;
            this.B1.HeaderText = "Тип товара";
            this.B1.Items.AddRange(new object[] {
            "Еда",
            "Животные",
            "Приправы и консерванты",
            "Ткани",
            "Металлы"});
            this.B1.Name = "B1";
            // 
            // C2
            // 
            dataGridViewCellStyle10.Format = "N0";
            dataGridViewCellStyle10.NullValue = "1";
            this.C2.DefaultCellStyle = dataGridViewCellStyle10;
            this.C2.HeaderText = "Цена мм";
            this.C2.Name = "C2";
            // 
            // D3
            // 
            dataGridViewCellStyle11.NullValue = "0";
            this.D3.DefaultCellStyle = dataGridViewCellStyle11;
            this.D3.HeaderText = "Скорость порчи";
            this.D3.Items.AddRange(new object[] {
            "До недели",
            "До месяца",
            "От месяца до года",
            "В течение нескольких лет",
            "Не теряют свои свойства со вменем"});
            this.D3.Name = "D3";
            this.D3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.D3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // E4
            // 
            dataGridViewCellStyle12.Format = "N1";
            dataGridViewCellStyle12.NullValue = "1";
            this.E4.DefaultCellStyle = dataGridViewCellStyle12;
            this.E4.HeaderText = "Ценность";
            this.E4.Name = "E4";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveGoodsToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(705, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // saveGoodsToolStripMenuItem1
            // 
            this.saveGoodsToolStripMenuItem1.Name = "saveGoodsToolStripMenuItem1";
            this.saveGoodsToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.saveGoodsToolStripMenuItem1.Text = "Save";
            this.saveGoodsToolStripMenuItem1.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(245, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 100);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.richTextBox4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 494);
            this.panel2.TabIndex = 4;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox4.Location = new System.Drawing.Point(0, 0);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(245, 494);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = resources.GetString("richTextBox4.Text");
            // 
            // EditTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 494);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditTables";
            this.Text = "Редактирование данных";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem saveTownToolStripMenuItem;
        private TabPage tabPage2;
        private DataGridView dataGridView2;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem saveGoodsToolStripMenuItem1;
        private Panel panel1;
        private Panel panel2;
        private RichTextBox richTextBox4;
        private DataGridViewTextBoxColumn A1;
        private DataGridViewTextBoxColumn B2;
        private DataGridViewTextBoxColumn С3;
        private DataGridViewTextBoxColumn В3;
        private DataGridViewTextBoxColumn A0;
        private DataGridViewComboBoxColumn B1;
        private DataGridViewTextBoxColumn C2;
        private DataGridViewComboBoxColumn D3;
        private DataGridViewTextBoxColumn E4;
    }
}