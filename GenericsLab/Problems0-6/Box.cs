using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsLab.Problems0_6
{
    internal class Box<T> : IComparable<Box<T>> where T : IComparable
    {
        public T Value { get; set; }
        public Box()
        {
            Value = default(T);
        }

        public Box(T value)
        {
            Value = value;
        }

        public int CompareTo(Box<T> other)
        {
            return Value.CompareTo(other.Value);
        }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {Value}";
        }
    }
}
