using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//リストの書き方
namespace ListSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<int> number = new List<int>()←var型を使わない場合
            //var numbers = new List<int>();
            //numbers.Add(3);
            //numbers.Add(2);
            //numbers.Add(4);
            //numbers.Add(5);
            //numbers.Add(7);

            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i] + "");
            //}

            //foreach(var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}

            var word = new List<string>();

            for(int i=0;i<5;i++)
            {
                word.Add(Console.ReadLine());
            }

            foreach (var item in word)
            {
                Console.WriteLine("文字列：" + item + " ");
            }
        }
    }
}
