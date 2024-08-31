using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//
// Сводка:
//     Represents text as a sequence of UTF-16 code units.
namespace Dungeon_Trading
{
    internal class Functions
    {
        public bool checkExistanceByDefault(string Path)
        {
            if (File.Exists(Path))
            {
                return true;
            }
            return false;
        }
        //
        // Сводка:
        //     Represents text as a sequence of UTF-16 code units.
        public string[] ReturnStringColumn(int column, int index)
        {
            //index: номертипа
            //
            //
            string filename = GetFilename(index);
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);
            string line;
            string[] buf;
            //int C = GetC(index);
            int R = GetR(index);
            string[] buffArr = new string[R];
            for (int j = 0; j < R; j++)
            {
                line = sr.ReadLine();
                buf = line.Split(';');
                buffArr[j] = buf[column];

            }
            sr.Close();
            return buffArr;
        }
        public string[,] GetAllGoods(int index)
        {
            string filename = "";
            filename = GetFilename(index);
            if (!checkExistanceByDefault(filename))
            {
                DialogResult dialog = MessageBox.Show("По пути \"" + filename +
                    "\" отсутсвует файл или отсутствуют права для чтения.", "Ошибка", MessageBoxButtons.OK);
            }
            StreamReader sr = new StreamReader(filename, Encoding.UTF8);
            string line;
            int C = GetC(index);
            int R = GetR(index);
            string[] buf;
            string[,] buffArr = new string[R, C];

            for (int j = 0; j < R; j++)
            {
                line = sr.ReadLine();
                buf = line.Split(';');
                for (int l = 0; l < C; l++)
                {
                    buffArr[j, l] = buf[l];
                }
            }
            Settings.Default.Save();
            sr.Close();
            return buffArr;
        }
        public static int GetNewPriceSell(string[] town, string[] good, int charmbonus, bool isSell = true)
        {
            double newPrice = 0;
            double price, mass, reaching;
            double money, townsize;
            if (charmbonus==-6)
            {
                charmbonus = 0;
            }
            
            double charm = Convert.ToDouble(charmbonus);
            price = Convert.ToDouble(good[2]);
            mass = Convert.ToDouble(good[3]);
            reaching = Convert.ToDouble(good[4]);
            money = Convert.ToDouble(town[2]);
            townsize = Convert.ToDouble(town[1]);
            if (isSell)
            {
                newPrice = price
                + (reaching * 0.1f * price)
                - (townsize / money * 0.02f * price)
                - (price * ((mass / 5.0f) * 0.05f))
                + (charm * 0.02f * price)
                ;
            }
            else
            {
                newPrice = price
                + (reaching * 0.1f * price)
                - (townsize / money * 0.02f * price)
                - ((price * ((mass / 5.0f) * 0.05f))
                + (charm * 0.02f * price))
                ;
            }
            int rt = Convert.ToInt32(newPrice);
            return rt;
        }
        public string FromPriceToCoin(string str)
        {
            if (str == "")
            {
                return "";
            }
            int mm = 0, am = 0, gm = 0;
            string copper = "", aurum = "", gold = "", sum = "";
            string stri = str.Split(',')[0];
            int price = Convert.ToInt32(stri);
            while (price - 100 >= 0)
            {
                price -= 100;
                gm++;
            }
            if (gm > 0)
            {
                gold = $"{gm} зм ";
            }

            while (price - 10 >= 0)
            {
                price -= 10;
                am++;
            }
            if (am > 0)
            {
                aurum = $"{am} см ";
            }
            if (price > 0)
            {
                mm = price;
            }
            if (mm > 0)
            {
                copper = $"{mm} мм ";
            }
            if (gm > 0)
            {
                sum += gold;
            }
            if (am > 0)
            {
                sum += aurum;
            }
            if (mm > 0)
            {
                sum += copper;
            }


            return sum;
        }
        public int GetC(int index)
        {
            switch (index)
            {

                case 1:
                    return Settings.Default.TownC;
                case 2:
                    return Settings.Default.GoodsC;
                default:
                    return Settings.Default.TownC;
            }
        }
        public int GetR(int index)
        {
            switch (index)
            {
                case 1:
                    return Settings.Default.TownR;
                case 2:
                    return Settings.Default.GoodsR;
                default:
                    return Settings.Default.TownR;
            }
        }
        public string GetFilename(int index)
        {
            switch (index)
            {
                case 1:
                    return Settings.Default.TownPath;
                case 2:
                    return Settings.Default.GoodsPath;
                default:
                    return Settings.Default.TownPath;
            }
        }
        public void DrowData(int index)
        {
            string filename = "";
            filename = GetFilename(index);

            Functions f = new Functions();
            if (!f.checkExistanceByDefault(filename))
            {
                DialogResult dialog = MessageBox.Show("По пути \"" + filename +
                    "\" отсутсвует файл или отсутствуют права для чтения.", "Ошибка", MessageBoxButtons.OK);
                return;

            }
            StreamReader sr = new StreamReader(filename);
            string line;
            line = sr.ReadLine();
            MatchCollection matches = Regex.Matches(line, "\\;\\b");
            int C = Convert.ToInt32(matches.Count() + 1); //take columns
            switch (index)
            {
                case 1:
                    Settings.Default.TownC = C;
                    break;
                case 2:
                    Settings.Default.GoodsC = C;
                    break;
                default:
                    break;
            }
            int R = 0;
            string[] buf;
            while (line != null)
            {

                line = sr.ReadLine();
                R++;
            }
            switch (index)
            {
                case 1:
                    Settings.Default.TownR = R;
                    break;
                case 2:
                    Settings.Default.GoodsR = R;
                    break;
                default:
                    break;
            }
            sr.Close();
            sr = new StreamReader(filename, Encoding.UTF8);
            string[,] buffArr = new string[R, C];

            for (int j = 0; j < R; j++)
            {
                line = sr.ReadLine();
                buf = line.Split(';');
                for (int l = 0; l < C; l++)
                {
                    buffArr[j, l] = buf[l];
                }
            }
            Settings.Default.Save();
            sr.Close();
        }
        public int[] ZeroArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = 0;
            }
            return arr;
        }
        public int GetCharm(int index)
        {
            if (index - 5 == -6)
            {
                return 0;
            }
            return index - 5;
        }
        public string GetSum(int[] arr)
        {
            if (arr == null)
            {
                return "";
            }
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum.ToString();
        }
    }
}
