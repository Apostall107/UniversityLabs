using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab.Problem1
{
    internal class Child : Person
    {
        public Child(string name, int age)
            : base(name, age) { }

        public override int Age 
        { 
            get => base.Age; 
            set
            {
                if (value > 15)
                    throw new ArgumentException("Child`s age must be less than 15!");

                base.Age = value;
            }
        }
    }
}
