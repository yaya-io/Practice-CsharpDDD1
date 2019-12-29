using CsharpDDD1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.WinForm.ViewModels
{
    /// <summary>
    /// Book一覧の1レコードのViewModel
    /// Datagridviewの列名も属性で定義(DisplayName)
    /// </summary>
    public class BookListViewModelBook
    {
        private BookEntity _entity;

        public BookListViewModelBook(BookEntity entity)
        {
            _entity = entity;
        }

        [DisplayName("書籍名")]
        public string BookName => _entity.Name;

        [DisplayName("購入日")]
        public string PurchasedDate => _entity.PurchasedDate.DisplayValue;


    }
}
