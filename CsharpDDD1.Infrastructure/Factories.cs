using CsharpDDD1.Domain.Repositories;
using CsharpDDD1.Infrastructure.Fake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Infrastructure
{
    /// <summary>
    /// Factoryクラス
    /// </summary>
    public static class Factories
    {
        //どのインスタンス（本番用/テスト用)を生成するかの分岐はこのFactory内に書く
        //View側（WinForm側から直接呼び出されないようにFakeのアクセス修飾子はinternalとする

        public static IBookRepository CreateBookRepository()
        {
            return new BookFake();
        }
    }
}
