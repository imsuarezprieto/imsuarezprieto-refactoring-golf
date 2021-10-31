using System;

namespace Hole2
{
    public class Money<A, B>
    {
        public readonly int first;
        public readonly String second;

        public Money(int first, String second)
        {
            this.first = first;
            this.second = second;
        }
    }
}
