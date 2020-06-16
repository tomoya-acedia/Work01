using System.Drawing;
using System;

//ボールクラス
class Ball
{
    //静的プロパティ
    public static int Count;//オブジェクトの個数をカウント(初期化しなくても0が格納されている)


    //プロパティ
    public double XPos { get; set; }    //X座標
    public double YPos { get; set; }    //Y座標
    public Image Img { get; set; }      //画像データ
    public Image Img2 { get; set; }

    private double moveX;   //加速度（x）
    private double moveY;   //加速度（y）

    Random rnd = new System.Random();

    //コンストラクタ
    public Ball() 
    {
        XPos = 0;
        YPos = 0;
        Img = Image.FromFile(@"images\soccer_ball.png");
        Img2 = Image.FromFile(@"images\tennis_ball.png");
        //ランダムにする
        moveX = 5; 
        moveY = 5;
    }

    //引数付きコンストラクタ
    public Ball(double xo,double yo,string path)
    {
        XPos = xo;//初期座標を引数から設定
        YPos = yo;//初期座標を引数から設定
        Img = Image.FromFile(path);
        
        moveX = rnd.Next(0, 20) - 10; 
        moveY = rnd.Next(0, 20) - 10;
    }

    //移動
    public void Move() 
    {
        XPos += moveX;
        YPos += moveY;

        //幅の制限
        if (XPos > 1200 - this.Img.Height || XPos < 0)
        {
            moveX *= -1;
        }

        //高さの制限　
        if (YPos > 800 - this.Img.Width || YPos < 0)
        {
            moveY *= -1;
        }

        Console.WriteLine("XPos = {0},YPos = {1}", (int)XPos, (int)YPos);
    }
}