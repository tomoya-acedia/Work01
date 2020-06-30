using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCollectionSample
{
    public partial class Form1 : Form
    {
        //車データを入れるバインディングリスト
        BindingList<Car> _Cars = new BindingList<Car>();

        static int count = 0;

        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = _Cars;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            count++;
            btdelete.Enabled = true ;

            //Carオブジェクトの作成
            Car car = new Car();

            car.Name = tbName.Text;
            car.Maker = cbMaker.Text;
            car.Category = tbCategory.Text;
            car.carPic = pbImage.Image;

            //メーカーをコンボボックスの入力候補に登録
            setComboBoxMaker(cbMaker.Text);

            //BindingListへ登録
            _Cars.Insert(0, car);

            //tbName.Clear();
            //cbMaker.Clear();
            //tbCategory.Clear();

            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            btModify.Enabled = true;

            jnputItemAllClear();
            initButton();
            #region//先生の
            //Car obj = new Car
            //{
            //    Name = tbName.Text,
            //    Maker = cbMaker.Text,
            //    Category = tbCategory.Text
            //};
            #endregion
        }

        //クリア
        private void button1_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pbImage.Image = null;
        }

        private void jnputItemAllClear()
        {
            tbName.Text = "";
            cbMaker.Text = "";
            tbCategory.Text = "";
            pbImage.Image = null;
        }

        //メーカーコンボボックスの入力候補登録
        private void setComboBoxMaker(string maker)
        {
            if(cbMaker.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbMaker.Items.Add(maker);
            }
        }

        private void dgvCarData_Click(object sender, EventArgs e)
        {
            //選択したレコードを取り出す
            //データグリッドビューの選択した行のインデックス
            //BindingListのデータ取得する
            Car selectedCar = _Cars[dgvCarData.CurrentRow.Index];

            tbName.Text = selectedCar.Name;
            cbMaker.Text = selectedCar.Maker;
            tbCategory.Text = selectedCar.Category;
            pbImage.Image = selectedCar.carPic;
        }
 
        private void btOpenImage_Click(object sender, EventArgs e)
        { if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            
            //変更対象のレコード(オブジェクト)
            Car selectedCar = _Cars[dgvCarData.CurrentRow.Index];

            selectedCar.Name = tbName.Text;
            selectedCar.Maker = cbMaker.Text;
            selectedCar.Category = tbCategory.Text;
            selectedCar.carPic = pbImage.Image;

            dgvCarData.Refresh();  //データグリッドビューの再描画

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            btModify.Enabled = false;
            btdelete.Enabled = false;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            count = 0;
            _Cars.Clear();
            initButton();
        }

        void initButton()
        {
            if (count == 0)
            {
                btModify.Enabled = false;
                btdelete.Enabled = false;
            }
            else
            {
                btModify.Enabled = true;
                btdelete.Enabled = true;
            }
        }

        private void dgvCarData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
