using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpDDD1.WinForm.Views
{
    /// <summary>
    /// BaseFormクラス
    /// 共通のForm設定などを記述しています
    /// </summary>
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();

            //画面中央表示
            this.StartPosition = FormStartPosition.CenterScreen;

            //その他共通設定があれば記載
        }
    }
}
