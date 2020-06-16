using System.IO;
using System.Windows.Forms;

class Stage : Form
{
    
    //ボールオブジェクト表示用
    private PictureBox pictureBoxBall = new PictureBox();
    private Ball ball;

    //タイマー
    private Timer timer = new Timer();

    public static void Main() 
    {
        Application.Run(new Stage());
    }

    //コンストラクタ
    public Stage() 
    {
        //フォームの設定
        Width = 1200;//フォームの幅
        Height = 800;//フォームの幅

        Text = "ボールシミュレーション";

        //ball = new Ball(); //ボールオブジェクトの生成
        pictureBoxBall.Parent = this;
        
        timer.Interval = 10;       //ms
        timer.Tick += Timer_Tick;  //時間経過で呼ぶメソッドを登録
        

        this.MouseClick += Stage_MouseClick;
    }


    //マウスクリック時のイベントハンドラ
    private void Stage_MouseClick(object sender,MouseEventArgs e)
    {
        string path = "";
        if (e.Button == MouseButtons.Left)
        {
            path = @"images\soccer_ball.png";
        }

        else if(e.Button == MouseButtons.Right)
        {
            path=@"images\tennis_ball.png";
        }
        else
        {
            return;
        }
        ball = new Ball(e.X - 50, e.Y - 50,path);

        pictureBoxBall.Width = 100;//画像の幅
        pictureBoxBall.Height = 100;//画像の高さ
        pictureBoxBall.Left = (int)ball.XPos;
        pictureBoxBall.Top = (int)ball.YPos;
        pictureBoxBall.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxBall.Image = ball.Img;//画像

        timer.Start();             //タイマースタート 
    }

    //指定した時間が経過すると呼ばれるメソッド
    private void Timer_Tick(object sender, System.EventArgs e) 
    {
        ball.Move();

        pictureBoxBall.Left = (int)ball.XPos;
        pictureBoxBall.Top = (int)ball.YPos;
    }
}