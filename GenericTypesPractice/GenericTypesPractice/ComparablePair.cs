using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesPractice
{
    public class ComparablePair<T, U> : Pair<T, U>, IComparable
        where T : IComparable
        where U : IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj is ComparablePair<T, U> otherPair)
            {
                int firstCheck = FirstValue.CompareTo(otherPair.FirstValue);
                return firstCheck == 0 ? SecondValue.CompareTo(otherPair.SecondValue) : firstCheck;
            }
            else
            {
                throw new ArgumentException("Argument must be of ComparablePair type");
            }
        }

        public ComparablePair(T t, U u) : base(t, u)
        {

        }
    }
}
