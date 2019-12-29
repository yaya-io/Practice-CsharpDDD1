using CsharpDDD1.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.Helpers
{
    /// <summary>
    /// チェック関連をまとめた静的クラス
    /// </summary>
    public class Guard
    {
        public static void IsNullOrEmptyMessage(string value, string message)
        {
            IsNullOrEmptyMessage(value, message, ExceptionType.Information);
        }

        public static void IsNullOrEmptyMessage(string value, string message, ExceptionType exceptionType)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new MessageException(exceptionType, message);
            }
        }
    }
}
