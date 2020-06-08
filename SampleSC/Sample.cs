using System.Windows.Forms;

//Formクラスを継承したSampleクラス
class Sample:Form 
{
    static void Main()
    {
        Application.Run(new Sample());
    }

    //デフォルトコンストラクタ(引数のないコンストラクタ)
    public Sample()
    {
        
    }
}