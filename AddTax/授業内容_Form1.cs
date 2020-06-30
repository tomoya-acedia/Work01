using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddTax
{
    public partial class FormAddTax : Form
    {
        public FormAddTax()
        {
            InitializeComponent();
        }

        private void buttonAddTax_Click(object sender, EventArgs e)
        {
            //変数の宣言
            int money;        //お金作業用変数
            double addTax;    //税込金額格納用
            //double tax = 0.1; //消費税率10％

            //「金額」テキストボックスの値を整数型変数に取得
            money = int.Parse(textBoxMoney.Text);
            addTax = money;
            addTax *= (double)(1 + UpDownTax.Value / 100);

            /******************************/
            money = (int)addTax;



            //税込金額をラベルに表示
            labelAddTax.Text = money + "円";

        }
    }
}
