using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictoinarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> color = new Dictionary<string, string>
            {
                //Key,Value
                {"黒","Black" },
                {"白","White" },
                {"黄","Yellow" },
            };

            //配列のように値を追加
            color["赤"] = "Red";

            //Addメソッドでの値を追加
            color.Add("青", "Blue");

            foreach (var Key in color.Keys)
            {
                Console.WriteLine($"{Key}は{color[Key]}です。");
            }
            
            //キーの存在チェック
            if(color.ContainsKey("緑"))
            {
                Console.WriteLine("緑は存在しています。");
            }

            else
            {
                Console.WriteLine("緑は存在しません。");
            }

            //値の存在チェック
            if (color.ContainsKey("Red"))
            {
                Console.WriteLine("赤は存在しています。");
            }

            else
            {
                Console.WriteLine("赤は存在しません。");
            }
        }
    }
}