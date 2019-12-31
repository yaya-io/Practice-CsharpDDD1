using CsharpDDD1.Domain.Exceptions;
using CsharpDDD1.Domain.Helpers;
using CsharpDDD1.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.Entities
{
    /// <summary>
    /// Bookエンティティ
    /// </summary>
    public class BookEntity
    {
        public BookEntity(string id,string name,DateTime purchaedDate) {

            Guard.IsNullOrEmptyMessage(name, "IDが空欄です。", ExceptionType.Information);
            Guard.IsNullOrEmptyMessage(name, "書籍名が空欄です。", ExceptionType.Information);


            this.Id = id;
            this.Name = name;
            this.PurchasedDate = new PurchasedDate(purchaedDate);
        }

        public string Id { get; }
        public string Name { get; }
        public PurchasedDate PurchasedDate { get; }

    }
}
