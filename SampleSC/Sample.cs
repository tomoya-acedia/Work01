using System;
using System.Windows.Forms;

//Formクラスを継承したSampleクラス
class Sample:Form 
{
    public static void Main()
    {
        Application.Run(new Sample());
    }

    //デフォルトコンストラクタ(引数のないコンストラクタ)
    public Sample()
    {
        var scores = new int[5];

        for (int i = 0; i < scores.Length; i++)
        {
            //整数値の取り込み
            Console.Write("scores[" + i + "]＝");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            scores[i] = num;
            
            Sum(scores[i], i);
        }
    }

    int SumMax = 0;
    public void Sum(int a,int b)
    {
        SumMax += a;
        //5回入力したら表示
        if (b > 3)
        {
            Console.WriteLine("入力された合計は" + SumMax + "です。");
        }

        //for (int i = 0; i < a; i++)
        //{
        //    Console.Write("*");
        //}
        //Console.WriteLine("");
    }
}