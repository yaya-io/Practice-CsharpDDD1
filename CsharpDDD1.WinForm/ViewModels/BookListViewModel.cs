using CsharpDDD1.Domain.Entities;
using CsharpDDD1.Domain.Repositories;
using CsharpDDD1.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.WinForm.ViewModels
{
    /// <summary>
    /// Book一覧用のViewModel
    /// BindingListをフィールドに持つ(これをUIに紐付け)
    /// </summary>
    public class BookListViewModel:ViewModelBase
    {
        

        public BookListViewModel(IReadOnlyList<BookEntity> bookList)
        {
            //ViewModelに変換
            foreach(var entity in bookList)
            {
                this.Books.Add(new BookListViewModelBook(entity));
            }            
        }
        

        public BindingList<BookListViewModelBook> Books { get; set; } = new BindingList<BookListViewModelBook>();
    }
}
