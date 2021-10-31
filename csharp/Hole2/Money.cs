using System;

namespace Hole2
{
    public class Money<A, B>
    {
        public readonly int value;
        public readonly String currency;

        public Money(int value, String currency)
        {
            this.value = value;
            this.currency = currency;
        }
    }
}
