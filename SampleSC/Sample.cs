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
        var socres = new int[] { 65, 54, 78, 96, 81 };
        //int[] scores = new int[5];
        //int [] scores = { 65, 54, 78, 96, 81 };
        for (int i = 0; i < socres.Length; i++)
        {
            Console.WriteLine(socres[i]);
        }
    }
}