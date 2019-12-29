using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsharpDDD1.ApplicationService.Services;
using CsharpDDD1.WinForm.ViewModels;
using CsharpDDD1.Domain.Exceptions;

namespace CsharpDDD1.WinForm.Views
{
    /// <summary>
    /// Book登録画面
    /// </summary>
    public partial class BookSaveView : BaseForm
    {
        private readonly BookApplicationService _bookService;
        private BookSaveViewModel _viewModel;

        public BookSaveView(BookApplicationService bookService)
        {
            InitializeComponent();

            _bookService = bookService;

            //Binding
            _viewModel = new BookSaveViewModel();
            PurchasedDatePicker.DataBindings.Add("Value", _viewModel, nameof(_viewModel.PurchasedDate));
            BookNameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.BookName));

            //Click event[登録]            
            ButtonSave.Click += ButtonSave_Click;
        }
                
        private  void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                _bookService.SaveData(_viewModel.BookName, _viewModel.PurchasedDate);
            }
            catch(MessageException mEx)
            {
                //定義済み例外の場合のメッセージ表示
                MessageBox.Show(mEx.Message, "error", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
        }
    }
}
