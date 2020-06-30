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


        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = _Cars;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "")
            {


                MessageBox.Show("車名の入力をしてください。");
                return;

            }

            //Carオブジェクトの作成
            Car car = new Car();

            car.Name = tbName.Text;
            car.Maker = cbMaker.Text;
            car.Category = tbCategory.Text;
            car.carPic = pbImage.Image;

            setConboBoxMaker(cbMaker.Text);

            //BindingListへ登録
            _Cars.Insert(0, car);

            //tbName.Clear();
            //tbMaker.Clear();
            //tbCategory.Clear();

            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            jnputItemAllClear();

            initButton();

            #region//先生の
            //Car obj = new Car
            //{
            //    Name = tbName.Text,
            //    Maker = tbMaker.Text,
            //    Category = tbCategory.Text
            //};
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画面をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);

                //ピクチャーボックスのサイズに画面を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;

                btClear.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pbImage.Image = null;
            btClear.Enabled = false;
        }

        private void jnputItemAllClear()
        {
            tbName.Text = "";
            cbMaker.Text = "";
            tbCategory.Text = "";
            pbImage.Image = null;
            //dgvCarData_C

        }

        //メーカーコンビボックスの入力候補登録
        private void setConboBoxMaker(string maker)
        {
            if (!cbMaker.Items.Contains(maker))
            {
                //コンボボックスの候補に追加
                cbMaker.Items.Add(maker);
            }
        }


        private void dgvCarData_Click(object sender, EventArgs e)
        {

            if (dgvCarData.CurrentRow == null)
                return;

            //選択したレコードを取り出す
            //データグリッドビューの選択した行のインデックス
            //BindingListのデータ取得する
            Car selectedCar = _Cars[dgvCarData.CurrentRow.Index];

            tbName.Text = selectedCar.Name;
            cbMaker.Text = selectedCar.Maker;
            tbCategory.Text = selectedCar.Category;
            pbImage.Image = selectedCar.carPic;

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

        private void Form1_Load(object sender, EventArgs e)
        {
            btModify.Enabled = false;
            btdelete.Enabled = false;
            btClear.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            _Cars.RemoveAt(dgvCarData.CurrentRow.Index);
            jnputItemAllClear();
            initButton();
            dgvCarData.ClearSelection();
        }

        void initButton()
        {
            if (_Cars.Count == 0)
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


        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            jnputItemAllClear();
        }
    }
}
