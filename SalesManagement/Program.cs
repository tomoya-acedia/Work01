using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class Program
    {
        //svmで↓が出る(ショートカットキー)
        static void Main(string[] args)
        {
            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));
        }

        //ctorで↓が出る(ショートカットキー)
        public Program()
        {

        }

        //売上データを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath)
        {
            //売上データを入れるリストオブジェクトを生成
            var sales = new List<Sale>();

            //ファイルから読み込み
            string[] lines = File.ReadAllLines(filePath);
            
            //読み込んだ行だけ繰り返す
            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);//saleオブジェクトをリストに追加
            }
            return sales;
        }

    }

}