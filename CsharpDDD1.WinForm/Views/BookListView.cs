using CsharpDDD1.WinForm.ViewModels;
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

namespace CsharpDDD1.WinForm.Views
{
    /// <summary>
    /// Book一覧画面
    /// </summary>
    public partial class BookListView : BaseForm
    {
        private readonly BookApplicationService _bookService;
        private BookListViewModel _viewModel;

        public BookListView(BookApplicationService bookService)
        {
            InitializeComponent();

            _bookService = bookService;
            _viewModel = new BookListViewModel(bookService.GetData());
            DgvBookList.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.Books));

            //Click event[一覧データ表示]
            ButtonShowData.Click += (sender, e) =>
            {                
                _viewModel.Books.Clear();
                foreach (var entity in _bookService.GetData())
                {
                    _viewModel.Books.Add(new BookListViewModelBook(entity));
                }
            };

            //Click event[登録画面表示]
            ButtonShowSaveForm.Click += (save, e) =>
            {
                using (var frm = new BookSaveView(_bookService))
                {
                    var ret = frm.ShowDialog();
                }
            };
        }

        

    }
}
