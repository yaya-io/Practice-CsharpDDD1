using CsharpDDD1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.Repositories
{
    /// <summary>
    /// BookRepositoryのインターフェース
    /// </summary>
    public interface IBookRepository
    {
        IReadOnlyList<BookEntity> GetData();
        void SaveData(BookEntity bookEntity);
    }
}
