using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.Helpers
{
    /// <summary>
    /// 拡張メソッドをまとめたクラス
    /// </summary>
    public static class Extensions
    {        

        public static DateTime ToDate(this string value)
        {
            return Convert.ToDateTime(value);
        }

    }
}
