﻿namespace Dungeon_Trading
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьДанныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxTown = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountTake = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelTown = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCharm = new System.Windows.Forms.ComboBox();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.buttonGetSum = new System.Windows.Forms.Button();
            this.labelSell = new System.Windows.Forms.Label();
            this.labelBuy = new System.Windows.Forms.Label();
            this.textBoxSell = new System.Windows.Forms.TextBox();
            this.textBoxBuy = new System.Windows.Forms.TextBox();
            this.labelOpponent = new System.Windows.Forms.Label();
            this.comboBoxOpponent = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьДанныеToolStripMenuItem,
            this.инструкцияToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1400, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьДанныеToolStripMenuItem
            // 
            this.добавитьДанныеToolStripMenuItem.Name = "добавитьДанныеToolStripMenuItem";
            this.добавитьДанныеToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.добавитьДанныеToolStripMenuItem.Text = "Добавить данные";
            this.добавитьДанныеToolStripMenuItem.Click += new System.EventHandler(this.добавитьДанныеToolStripMenuItem_Click);
            // 
            // инструкцияToolStripMenuItem
            // 
            this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
            this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.инструкцияToolStripMenuItem.Text = "Инструкция";
            this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // comboBoxTown
            // 
            this.comboBoxTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTown.FormattingEnabled = true;
            this.comboBoxTown.Location = new System.Drawing.Point(12, 136);
            this.comboBoxTown.Name = "comboBoxTown";
            this.comboBoxTown.Size = new System.Drawing.Size(172, 28);
            this.comboBoxTown.TabIndex = 3;
            this.comboBoxTown.SelectedIndexChanged += new System.EventHandler(this.buttonReload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodName,
            this.Qprice,
            this.Column1,
            this.Price,
            this.Price2,
            this.BayColumn,
            this.CountTake,
            this.SellSum});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(198, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1202, 546);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // GoodName
            // 
            this.GoodName.HeaderText = "Name";
            this.GoodName.MinimumWidth = 6;
            this.GoodName.Name = "GoodName";
            this.GoodName.ReadOnly = true;
            this.GoodName.Width = 270;
            // 
            // Qprice
            // 
            this.Qprice.HeaderText = "Вес";
            this.Qprice.MinimumWidth = 6;
            this.Qprice.Name = "Qprice";
            this.Qprice.ReadOnly = true;
            this.Qprice.Width = 75;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "%";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Price
            // 
            this.Price.HeaderText = "Себестоимость";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 155;
            // 
            // Price2
            // 
            this.Price2.HeaderText = "Продажа";
            this.Price2.MinimumWidth = 6;
            this.Price2.Name = "Price2";
            this.Price2.ReadOnly = true;
            this.Price2.Width = 155;
            // 
            // BayColumn
            // 
            this.BayColumn.HeaderText = "Покупка";
            this.BayColumn.MinimumWidth = 6;
            this.BayColumn.Name = "BayColumn";
            this.BayColumn.ReadOnly = true;
            this.BayColumn.Width = 155;
            // 
            // CountTake
            // 
            this.CountTake.HeaderText = "Количество";
            this.CountTake.MinimumWidth = 6;
            this.CountTake.Name = "CountTake";
            this.CountTake.Width = 125;
            // 
            // SellSum
            // 
            this.SellSum.HeaderText = "Сумма";
            this.SellSum.MinimumWidth = 6;
            this.SellSum.Name = "SellSum";
            this.SellSum.ReadOnly = true;
            this.SellSum.Width = 125;
            // 
            // labelTown
            // 
            this.labelTown.AutoSize = true;
            this.labelTown.Location = new System.Drawing.Point(12, 113);
            this.labelTown.Name = "labelTown";
            this.labelTown.Size = new System.Drawing.Size(89, 20);
            this.labelTown.TabIndex = 5;
            this.labelTown.Text = "Поселение:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Мод. харизмы:";
            // 
            // comboBoxCharm
            // 
            this.comboBoxCharm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCharm.FormattingEnabled = true;
            this.comboBoxCharm.Items.AddRange(new object[] {
            "-5",
            "-4",
            "-3",
            "-2",
            "-1",
            "0",
            "+1",
            "+2",
            "+3",
            "+4",
            "+5",
            "+6",
            "+7",
            "+8",
            "+9",
            "+10"});
            this.comboBoxCharm.Location = new System.Drawing.Point(129, 170);
            this.comboBoxCharm.Name = "comboBoxCharm";
            this.comboBoxCharm.Size = new System.Drawing.Size(55, 28);
            this.comboBoxCharm.TabIndex = 7;
            this.comboBoxCharm.SelectedIndexChanged += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(12, 66);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(167, 29);
            this.buttonReload.TabIndex = 8;
            this.buttonReload.Text = "Перезагрузить";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 31);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(167, 29);
            this.buttonShow.TabIndex = 9;
            this.buttonShow.Text = "Отобразить";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // buttonGetSum
            // 
            this.buttonGetSum.Location = new System.Drawing.Point(7, 374);
            this.buttonGetSum.Name = "buttonGetSum";
            this.buttonGetSum.Size = new System.Drawing.Size(172, 29);
            this.buttonGetSum.TabIndex = 10;
            this.buttonGetSum.Text = "Рассчитать сумму";
            this.buttonGetSum.UseVisualStyleBackColor = true;
            this.buttonGetSum.Click += new System.EventHandler(this.buttonGetSum_Click);
            // 
            // labelSell
            // 
            this.labelSell.AutoSize = true;
            this.labelSell.Location = new System.Drawing.Point(7, 406);
            this.labelSell.Name = "labelSell";
            this.labelSell.Size = new System.Drawing.Size(76, 20);
            this.labelSell.TabIndex = 11;
            this.labelSell.Text = "Продажа:";
            // 
            // labelBuy
            // 
            this.labelBuy.AutoSize = true;
            this.labelBuy.Location = new System.Drawing.Point(7, 459);
            this.labelBuy.Name = "labelBuy";
            this.labelBuy.Size = new System.Drawing.Size(76, 20);
            this.labelBuy.TabIndex = 12;
            this.labelBuy.Text = "Продажа:";
            // 
            // textBoxSell
            // 
            this.textBoxSell.Location = new System.Drawing.Point(7, 429);
            this.textBoxSell.Name = "textBoxSell";
            this.textBoxSell.ReadOnly = true;
            this.textBoxSell.Size = new System.Drawing.Size(172, 27);
            this.textBoxSell.TabIndex = 13;
            // 
            // textBoxBuy
            // 
            this.textBoxBuy.Location = new System.Drawing.Point(7, 482);
            this.textBoxBuy.Name = "textBoxBuy";
            this.textBoxBuy.ReadOnly = true;
            this.textBoxBuy.Size = new System.Drawing.Size(172, 27);
            this.textBoxBuy.TabIndex = 14;
            // 
            // labelOpponent
            // 
            this.labelOpponent.AutoSize = true;
            this.labelOpponent.Location = new System.Drawing.Point(12, 207);
            this.labelOpponent.Name = "labelOpponent";
            this.labelOpponent.Size = new System.Drawing.Size(82, 20);
            this.labelOpponent.TabIndex = 15;
            this.labelOpponent.Text = "Оппонент:";
            // 
            // comboBoxOpponent
            // 
            this.comboBoxOpponent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOpponent.FormattingEnabled = true;
            this.comboBoxOpponent.Location = new System.Drawing.Point(12, 230);
            this.comboBoxOpponent.Name = "comboBoxOpponent";
            this.comboBoxOpponent.Size = new System.Drawing.Size(172, 28);
            this.comboBoxOpponent.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 574);
            this.Controls.Add(this.comboBoxOpponent);
            this.Controls.Add(this.labelOpponent);
            this.Controls.Add(this.textBoxBuy);
            this.Controls.Add(this.textBoxSell);
            this.Controls.Add(this.labelBuy);
            this.Controls.Add(this.labelSell);
            this.Controls.Add(this.buttonGetSum);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.comboBoxCharm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTown);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxTown);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1418, 1900);
            this.MinimumSize = new System.Drawing.Size(1418, 0);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog openFileDialog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem добавитьДанныеToolStripMenuItem;
        private ComboBox comboBoxTown;
        private DataGridView dataGridView1;
        private Label labelTown;
        private Label label1;
        private ComboBox comboBoxCharm;
        private ToolStripMenuItem инструкцияToolStripMenuItem;
        private Button buttonReload;
        private Button buttonShow;
        private Button buttonGetSum;
        private Label labelSell;
        private Label labelBuy;
        private TextBox textBoxSell;
        private TextBox textBoxBuy;
        private ToolStripMenuItem оПрограммеToolStripMenuItem;
        private DataGridViewTextBoxColumn GoodName;
        private DataGridViewTextBoxColumn Qprice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Price2;
        private DataGridViewTextBoxColumn BayColumn;
        private DataGridViewTextBoxColumn CountTake;
        private DataGridViewTextBoxColumn SellSum;
        private Label labelOpponent;
        private ComboBox comboBoxOpponent;
    }
}