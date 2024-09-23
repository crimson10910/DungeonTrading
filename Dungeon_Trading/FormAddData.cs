using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Trading
{
    public partial class FormAddData : Form
    {
        public FormAddData()
        {
            InitializeComponent();
        }
        string filename;
        private void FormAddData_Load(object sender, EventArgs e)
        {
            UpdateForm();
        }
        void UpdateForm()
        {
            textBox1.Text = Settings.Default.TownPath;
            textBox2.Text = Settings.Default.GoodsPath;
            TC1.Text = Settings.Default.TownC.ToString();
            TR1.Text = Settings.Default.TownR.ToString();
            GC1.Text = Settings.Default.GoodsC.ToString();
            GR1.Text = Settings.Default.GoodsR.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (sender == null)
            {
                return;
            }
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Filter = "Файл с разделителями \";\" (*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {

                return;
            }
            Functions f = new Functions();

            filename = openFileDialog.FileName;

            Button b = (Button)sender;
            int tag = Convert.ToInt32(b.Tag);
            switch (tag)
            {
                case 1:
                    Settings.Default.TownPath = filename;
                    break;
                case 2:
                    Settings.Default.GoodsPath = filename;
                    break;
                default:
                    break;
            }
            f.DrowData(tag);
            UpdateForm();
        }

        private void FormAddData_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormMain form1 = new FormMain();
            form1.OterLoad();
        }
    }
}
