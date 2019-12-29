using CsharpDDD1.Domain.Entities;
using CsharpDDD1.Domain.Helpers;
using CsharpDDD1.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Infrastructure.Fake
{
    /// <summary>
    /// テスト用のBookFakeクラス
    /// internalのため、他プロジェクトからは参照されない
    /// </summary>
    internal sealed  class BookFake:IBookRepository
    {
        private static List<BookEntity> _entities;
        
        static BookFake()
        {
            _entities = new List<BookEntity>
            {                
                new BookEntity(Guid.NewGuid().ToString(),"リーダブルコード","2017/01/01".ToDate()),
                new BookEntity(Guid.NewGuid().ToString(),"Code Complete","2018/01/01".ToDate()),
                new BookEntity(Guid.NewGuid().ToString(),"カイゼンジャーニー","2019/01/01".ToDate())
            };   
        }

        public IReadOnlyList<BookEntity> GetData()
        {
            return _entities;
        }

        public void SaveData(BookEntity bookEntity)
        {
            _entities.Add(bookEntity);
        }
               

    }
}
