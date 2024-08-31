
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Dungeon_Trading
{
    public partial class FormMain : Form
    {
        string filename = string.Empty;
        string defaultPath = "./";
        string line;
        string[] townsList;
        string[,] towns;
        string[,] goods;
        int[] finalSellPrice;
        int[] finalBuyPrice;
        int[] GoodsCount;

        int selectedTown;

        public bool reload = false;
        MatchCollection matches; // Количество столбцов
        public FormMain()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            comboBoxCharm.SelectedIndex = 5;
            reload = true;
            OterLoad();

            reload = false;
            Functions f = new Functions();
            f.GetCharm(comboBoxCharm.SelectedIndex);
            finalBuyPrice = new int[Settings.Default.GoodsR];
            finalSellPrice = new int[Settings.Default.GoodsR];
            GoodsCount = new int[Settings.Default.GoodsR];


            finalBuyPrice = f.ZeroArray(Settings.Default.GoodsR);
            finalSellPrice = f.ZeroArray(Settings.Default.GoodsR);
            GoodsCount = f.ZeroArray(Settings.Default.GoodsR);
            this.Text = Settings.Default._ProgrammName + " "+ Settings.Default.Version;

        }

        private void WriteToDGW()       // Это пищет в Датагрид 
        {
            Functions f = new Functions();
            if (dataGridView1.Rows.Count != Settings.Default.GoodsR)
            {
                dataGridView1.Rows.Add(Settings.Default.GoodsR);
            }
            string[] bufGood = new string[Settings.Default.GoodsC];
            string[] bufTown = new string[Settings.Default.TownC];
            int g = Settings.Default.TownC;
            for (int i = 0; i < Settings.Default.TownC; i++)
            {
                bufTown[i] = towns[selectedTown, i];
            }
            for (int i = 0; i < Settings.Default.GoodsR; i++)
            {

                for (int j = 0; j < Settings.Default.GoodsC; j++)
                {
                    bufGood[j] = goods[i, j].ToString();
                }
                double priceSell;
                double priceBuy;
                priceSell = Functions.GetNewPriceSell(bufTown, bufGood, f.GetCharm(comboBoxCharm.SelectedIndex));
                priceBuy = Functions.GetNewPriceSell(bufTown, bufGood, f.GetCharm(comboBoxCharm.SelectedIndex), false);
                dataGridView1.Rows[i].Cells[0].Value = goods[i, 0].ToString();  // Name
                dataGridView1.Rows[i].Cells[1].Value = goods[i, 2].ToString();  // massa
                dataGridView1.Rows[i].Cells[2].Value = (Convert.ToDouble(priceSell) / (Convert.ToDouble(goods[i, 2])) * 100).ToString("F0") + "%";
                dataGridView1.Rows[i].Cells[3].Value = f.FromPriceToCoin(goods[i, 2]).ToString();
                dataGridView1.Rows[i].Cells[4].Value = f.FromPriceToCoin(priceSell.ToString()).ToString();
                dataGridView1.Rows[i].Cells[5].Value = f.FromPriceToCoin(priceBuy.ToString()).ToString();
            }

        }

        private void добавитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.Show();
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Вы хотете перезаписать все данные в программу?", 
                "Предпреждение", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                comboBoxTown.Items.Clear();
                dataGridView1.Rows.Clear();
                reload = true;
                OterLoad();
                reload = false;
                if (comboBoxTown.Items.Count>0)
                {
                    comboBoxTown.SelectedIndex = 0;
                }
            }
            else
            {
                return;
            }

        }
        public void OterLoad()
        {
            Functions f = new Functions();
            if (!f.checkExistanceByDefault(Settings.Default.TownPath) ||
                !f.checkExistanceByDefault(Settings.Default.GoodsPath))
            {
                return;
            }
            Settings.Default.TownR = f.GetR(1);
            Settings.Default.TownC = f.GetC(1);
            Settings.Default.GoodsR = f.GetR(2);
            Settings.Default.GoodsC = f.GetR(2);
            f.DrowData(1);
            f.DrowData(2);
            if (reload)
            {

            }

            if (comboBoxTown.Items.Count <= 0)
            {
                townsList = f.ReturnStringColumn(0, 1);
                foreach (var item in townsList)
                {
                    comboBoxTown.Items.Add(item);
                }
                comboBoxTown.SelectedIndex = 0;
            }
            if (comboBoxTown.SelectedIndex < 0)
            {
                selectedTown = 0;
            }
            else
            {
                selectedTown = comboBoxTown.SelectedIndex;
            }


            towns = f.GetAllGoods(1);
            goods = f.GetAllGoods(2);
            WriteToDGW();
        }
        
        private void buttonReload_Click(object sender, EventArgs e)
        {
            OterLoad();
        }

        private void Rererere()
        {
            Point idx = dataGridView1.CurrentCellAddress;
            dataGridView1.CurrentCell = dataGridView1.Rows[idx.Y].Cells[idx.X];
            int count;
            if (idx.X != 6)
            {
                return;
            }
            if (dataGridView1.Rows[idx.Y].Cells[idx.X].Value != null
                && double.TryParse(dataGridView1.Rows[idx.Y].Cells[idx.X].Value.ToString(), out double t))
            {
                count = Convert.ToInt32(dataGridView1.Rows[idx.Y].Cells[idx.X].Value.ToString());
                dataGridView1.Rows[idx.Y].Cells[idx.X + 1].Value = "correct!";
            }
            else
            {
                count = 0; 
                dataGridView1.Rows[idx.Y].Cells[idx.X + 1].Value = "incorrect!" ;
            }
            Functions f = new Functions();
            string[] bufGood = new string[Settings.Default.GoodsC];
            string[] bufTown = new string[Settings.Default.TownC];
            for (int i = 0; i < Settings.Default.TownC; i++)
            {
                bufTown[i] = towns[selectedTown, i];
            }

                for (int j = 0; j < Settings.Default.GoodsC; j++)
                {
                    bufGood[j] = goods[idx.Y, j].ToString();
                }
            int priceSell;
            int priceBuy;
            priceSell = Functions.GetNewPriceSell(bufTown, bufGood, f.GetCharm(comboBoxCharm.SelectedIndex)) * count ;
            priceBuy = Functions.GetNewPriceSell(bufTown, bufGood, f.GetCharm(comboBoxCharm.SelectedIndex), false) * count;
            finalBuyPrice[idx.Y] = priceBuy;
            finalSellPrice[idx.Y] = priceSell;
            dataGridView1.Rows[idx.Y].Cells[4].ReadOnly = false;
        }

        private void buttonGetSum_Click(object sender, EventArgs e)
        {
            Functions f = new Functions();
            OterLoad();
            Rererere();
            textBoxBuy.Text = "";
            textBoxSell.Text = f.FromPriceToCoin(f.GetSum(finalSellPrice));
            textBoxBuy.Text = f.FromPriceToCoin(f.GetSum(finalBuyPrice));
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Rererere();
        }
    }
}