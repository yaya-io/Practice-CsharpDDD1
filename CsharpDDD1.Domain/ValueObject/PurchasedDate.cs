using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDDD1.Domain.ValueObject
{
    /// <summary>
    /// 書籍購入日(ValueObject)
    /// </summary>
    public sealed class PurchasedDate : ValueObject<PurchasedDate>
    {
        public PurchasedDate(DateTime value)
        {
            this.Value = value;
        }

        public static implicit operator PurchasedDate(DateTime value)
        {
            return new PurchasedDate(value);
        }


        public DateTime Value { get; }
        public string DisplayValue => Value.ToString("yyyy年MM月dd日");

        protected override bool EqualsCore(PurchasedDate other)
        {
            return this.Value == other.Value;
        }

    }
}
