using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.Exceptions
{
    /// <summary>
    /// 例外種類を扱えるようにしたMessageExceptionクラス
    /// </summary>
    public sealed class MessageException:ExceptionBase
    {
        public MessageException(ExceptionType exceptionType, string message):base(exceptionType,message)
        {

        }
    }
}
