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
            this.Id = id;
            this.Name = name;
            this.PurchasedDate = new PurchasedDate(purchaedDate);
        }

        public string Id { get; }
        public string Name { get; }
        public PurchasedDate PurchasedDate { get; }

    }
}
