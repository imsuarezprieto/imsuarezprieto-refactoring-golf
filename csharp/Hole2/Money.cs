using System;

namespace Hole2
{
    public class Money<A, B>
    {
        public readonly int value;
        public readonly String second;

        public Money(int value, String second)
        {
            this.value = value;
            this.second = second;
        }
    }
}
