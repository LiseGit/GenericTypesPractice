using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypesPractice
{
    public class Pair<S, T>
    {
        public S FirstValue { get; init; }
        public T SecondValue { get; init; }

        public Pair(S s, T t)
        {
            FirstValue = s;
            SecondValue = t;
        }
    }
}