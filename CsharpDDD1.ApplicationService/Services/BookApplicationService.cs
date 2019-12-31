using CsharpDDD1.Domain.Entities;
using CsharpDDD1.Domain.Repositories;
using CsharpDDD1.Domain.ValueObject;
using CsharpDDD1.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsharpDDD1.Domain.Helpers;
using CsharpDDD1.Domain.Exceptions;

namespace CsharpDDD1.ApplicationService.Services
{
    /// <summary>
    /// Bookアプリケーションサービス
    /// </summary>
    public class BookApplicationService
    {
        private readonly IBookRepository bookRepository;

        public BookApplicationService(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public BookApplicationService() : this(Factories.CreateBookRepository())
        {

        }
        public IReadOnlyList<BookEntity> GetData()
        {
            var bookList = bookRepository.GetData();

            return bookList;
        }

        public void SaveData(string bookName,DateTime purchasedDate)
        {
            var book = new BookEntity(Guid.NewGuid().ToString(), bookName, purchasedDate);
            bookRepository.SaveData(book);
        }
    }
}
