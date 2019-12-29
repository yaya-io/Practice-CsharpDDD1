using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.Exceptions
{
    /// <summary>
    /// Exceptionの種類を定義
    /// </summary>
    public enum ExceptionType
    {
        Information,
        Warning,
        Error
    }

    /// <summary>
    /// Exceptionの抽象クラスを定義
    /// </summary>
    public abstract class ExceptionBase:Exception
    {
        public ExceptionBase(ExceptionType exceptionType, string message):base(message)
        {
            ExceptionType = exceptionType;
        }
        public ExceptionType ExceptionType { get; }
    }
}
