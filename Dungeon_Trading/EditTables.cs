using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Trading
{
    public partial class EditTables : Form
    {
        public EditTables()
        {
            InitializeComponent();
            ToArrays();
            LoadData();

        }
        string[,] towns;
        string[,] goods;
        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // 1st page save
        {
            
            SaveFile(1);
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            ToArrays();
            LoadData();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e) // 2st page save
        {
            
            SaveFile(2);
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            ToArrays();
            LoadData();
        }
        string[,] buf;
        private void SaveFile(int index)
        {
            
            DataGridView dataGridView = new DataGridView();
            string filePath = "" ;
            int columnCoun = 0;
            int rowCount = 0;
            if (index == 1) // for Towns
            {
                dataGridView = dataGridView1;
                filePath = Settings.Default.TownPath;
                columnCoun = dataGridView1.ColumnCount;
                rowCount = dataGridView1.RowCount;
            }
            if (index == 2) // for Goods
            {
                dataGridView = dataGridView2;
                filePath = Settings.Default.GoodsPath;
                columnCoun =dataGridView2.ColumnCount;
                rowCount = dataGridView2.RowCount;
            }
            string bu = "";
            File.Delete(filePath);
            using (FileStream fstream = new FileStream(filePath, FileMode.CreateNew))
            {
                for (int i = 0; i < rowCount-1; i++)
                {
                    for (int j = 0; j < columnCoun; j++)
                    {
                        if (dataGridView == dataGridView2 && (j == 1 || j == 3))
                        {
                            if (j == 1)
                            {
                                bu = B1.Items.IndexOf(dataGridView.Rows[i].Cells[j].Value).ToString();
                            }
                            if (j == 3)
                            {
                                bu = D3.Items.IndexOf(dataGridView.Rows[i].Cells[j].Value).ToString();
                            }
                        }
                        else
                        {
                            bu = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                        
                        if (j == columnCoun - 1)
                        {
                            bu += '\n';
                        }
                        else
                        {
                            bu += ';';
                        }
                        byte[] buffer1 = Encoding.Default.GetBytes(bu);
                        fstream.Write(buffer1, 0, buffer1.Length);
                    }
                    
                    
                }
            }
               
        }
        private void ToArrays()
        {
            Functions f = new Functions();

            towns = f.GetAllGoods(1);
            goods = f.GetAllGoods(2);
        }
        private void LoadData()
        {

            Functions f = new Functions();
            if (dataGridView2.Rows.Count != Settings.Default.GoodsR)
            {
                dataGridView2.Rows.Add(Settings.Default.GoodsR);
            }
            if (dataGridView1.Rows.Count != Settings.Default.TownR)
            {
                dataGridView1.Rows.Add(Settings.Default.TownR);
            }
            int g = Settings.Default.TownC;
            for (int i = 0; i < Settings.Default.GoodsR; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = goods[i, 0].ToString().ToString();  // Name
                dataGridView2.Rows[i].Cells[1].Value = B1.Items[Convert.ToInt32(goods[i, 3])];  // massa
                dataGridView2.Rows[i].Cells[2].Value = (goods[i, 2]).ToString();
                dataGridView2.Rows[i].Cells[3].Value = D3.Items[Convert.ToInt32(goods[i, 3])];
                    Convert.ToInt32(goods[i, 3]);
                dataGridView2.Rows[i].Cells[4].Value = (goods[i, 4]).ToString();
            }
            for (int i = 0; i < Settings.Default.TownR; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = (towns[i, 0]).ToString();
                dataGridView1.Rows[i].Cells[1].Value = (towns[i, 1]).ToString();
                dataGridView1.Rows[i].Cells[2].Value = (towns[i, 2]).ToString();
                dataGridView1.Rows[i].Cells[3].Value = towns[i, 3].ToString();
            }
        }
    }
}