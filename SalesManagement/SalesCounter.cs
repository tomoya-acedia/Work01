using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    //売上集計クラス
    class SalesCounter
    {
        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string path)
        {
            _sales = ReadSales(path);
        }

        //店舗売上を求める
        public Dictionary<string,int>GetPerStoreSales()
        {

            Dictionary<string, int> stores = new Dictionary<string, int>();

            foreach (var item in _sales)
            {
                if (stores.ContainsKey(item.ShopName))
                {
                    //キー(店舗名)が存在する場合
                    stores[item.ShopName] += item.Amount;
                }
                else
                {
                    //キー(店舗名)が存在しない(連想配列追加)
                    stores[item.ShopName] = item.Amount;
                }
            }
            return stores;
        }



        //売上データを読み込み、Saleオブジェクトのリストを返す
        private static List<Sale> ReadSales(string filePath)
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
