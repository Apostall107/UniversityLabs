using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Problem6 {
    internal class PersonAgeComparator : IComparer<Person> {
        public int Compare(Person x, Person y) {
            return x.Age - y.Age;
        }
    }
}
