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
    /// Book登録用のViewModel
    /// </summary>
    public class BookSaveViewModel:ViewModelBase
    {
        private string _bookName = "";
        private DateTime _purchasedDate ;
        public BookSaveViewModel()
        {
            _purchasedDate = GetDatetime();
        }

        public string BookName
        {
            get { return _bookName; }
            set { SetProperty(ref _bookName, value); }
        }
        public DateTime PurchasedDate
        {
            get { return _purchasedDate; }
            set { SetProperty(ref _purchasedDate, value); }
        }
        
        public virtual DateTime GetDatetime()
        {
            return DateTime.Now;
        }


    }
}
