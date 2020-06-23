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
            //合計
            int total = 0;
            
            //各店舗
            int total_sinzyuku = 0;
            int total_asakusa = 0;
            int total_marunouti = 0;
            int total_yokohama = 0;

            //カテゴリー別
            int kasutera = 0;
            int kasi = 0;
            int manzyu = 0;
            int youkan = 0;

            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));

            //各店舗と合計金額の表示
            foreach (var item in sales._sales)
            {
                #region 店舗合計
                if (item.ShopName.Equals("新宿店"))
                {
                    total_sinzyuku += item.Amount;
                }

                if (item.ShopName.Equals("浅草店"))
                {
                    total_asakusa += item.Amount;
                }

                if (item.ShopName.Equals("丸の内店"))
                {
                    total_marunouti += item.Amount;
                }

                if (item.ShopName.Equals("横浜店"))
                {
                    total_yokohama += item.Amount;
                }
                #endregion

                #region カテゴリー
                if (item.ProductCategory.Equals("カステラ"))
                {
                    kasutera += item.Amount; 
                }

                if (item.ProductCategory.Equals("餅菓子"))
                {
                    kasi += item.Amount;
                }

                if (item.ProductCategory.Equals("まんじゅう"))
                {
                    manzyu += item.Amount;
                }

                if (item.ProductCategory.Equals("羊羹"))
                {
                    youkan += item.Amount;
                }

                #endregion
                //全体の合計金額
                total += item.Amount;
            }

            #region 店舗合計(表示)
            //新宿店の合計金額
            Console.WriteLine("新宿店:{0}円", total_sinzyuku);

            //浅草の合計金額
            Console.WriteLine("浅草店:{0}円", total_asakusa);

            //丸の内の合計金額
            Console.WriteLine("丸の内店:{0}", total_marunouti);

            //横浜の合計金額
            Console.WriteLine("横浜店:{0}円", total_yokohama);

            #endregion

            Console.WriteLine("");
            
            #region カテゴリー(表示)
            //カステラ
            Console.WriteLine("カステラ:{0}円", kasutera);

            //餅菓子
            Console.WriteLine("餅菓子:{0}円", kasi);

            //まんじゅう
            Console.WriteLine("まんじゅう:{0}円", manzyu);

            //羊羹
            Console.WriteLine("羊羹:{0}円", youkan);

            #endregion

            Console.WriteLine("");

            //↓ショートカットキー：cw
            //全体
            Console.WriteLine("全体の売り上げ:{0}円", total);
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