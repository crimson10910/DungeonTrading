namespace Dungeon_Trading
{
    partial class FormAddData
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
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            openFileDialog = new OpenFileDialog();
            TC = new Label();
            TRow = new Label();
            TR1 = new Label();
            TC1 = new Label();
            GC1 = new Label();
            GR1 = new Label();
            GRow = new Label();
            GC = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 28);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Города";
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(67, 26);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 22);
            button1.TabIndex = 1;
            button1.Tag = "1";
            button1.Text = "Добрать файл";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 52);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(523, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 129);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(523, 23);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(67, 103);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(116, 22);
            button2.TabIndex = 4;
            button2.Tag = "2";
            button2.Text = "Добрать файл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 106);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Товары";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // TC
            // 
            TC.AutoSize = true;
            TC.Location = new Point(100, 74);
            TC.Name = "TC";
            TC.Size = new Size(67, 15);
            TC.TabIndex = 6;
            TC.Text = "Столбцов: ";
            // 
            // TRow
            // 
            TRow.AutoSize = true;
            TRow.Location = new Point(10, 74);
            TRow.Name = "TRow";
            TRow.Size = new Size(46, 15);
            TRow.TabIndex = 7;
            TRow.Text = "Строк: ";
            // 
            // TR1
            // 
            TR1.AutoSize = true;
            TR1.Location = new Point(51, 74);
            TR1.Name = "TR1";
            TR1.Size = new Size(38, 15);
            TR1.TabIndex = 8;
            TR1.Text = "label3";
            // 
            // TC1
            // 
            TC1.AutoSize = true;
            TC1.Location = new Point(178, 74);
            TC1.Name = "TC1";
            TC1.Size = new Size(38, 15);
            TC1.TabIndex = 9;
            TC1.Text = "label3";
            // 
            // GC1
            // 
            GC1.AutoSize = true;
            GC1.Location = new Point(178, 152);
            GC1.Name = "GC1";
            GC1.Size = new Size(38, 15);
            GC1.TabIndex = 13;
            GC1.Text = "label3";
            // 
            // GR1
            // 
            GR1.AutoSize = true;
            GR1.Location = new Point(51, 152);
            GR1.Name = "GR1";
            GR1.Size = new Size(38, 15);
            GR1.TabIndex = 12;
            GR1.Text = "label3";
            // 
            // GRow
            // 
            GRow.AutoSize = true;
            GRow.Location = new Point(10, 152);
            GRow.Name = "GRow";
            GRow.Size = new Size(46, 15);
            GRow.TabIndex = 11;
            GRow.Text = "Строк: ";
            // 
            // GC
            // 
            GC.AutoSize = true;
            GC.Location = new Point(100, 152);
            GC.Name = "GC";
            GC.Size = new Size(67, 15);
            GC.TabIndex = 10;
            GC.Text = "Столбцов: ";
            // 
            // FormAddData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 188);
            Controls.Add(GC1);
            Controls.Add(GR1);
            Controls.Add(GRow);
            Controls.Add(GC);
            Controls.Add(TC1);
            Controls.Add(TR1);
            Controls.Add(TRow);
            Controls.Add(TC);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddData";
            Text = "Добавить данные";
            FormClosed += FormAddData_FormClosed;
            Load += FormAddData_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label2;
        private OpenFileDialog openFileDialog;
        private Label TC;
        private Label TRow;
        private Label TR1;
        private Label TC1;
        private Label GC1;
        private Label GR1;
        private Label GRow;
        private Label GC;
    }
}