﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9.Problem5 {
    internal class Person : IComparable<Person> {
        private string name;
        private int age;
        private string town;

        public Person(string name, int age, string town) {
            this.name = name;
            this.age = age;
            this.town = town;
        }

        public int CompareTo(Person other) {
            var comparison = this.name.CompareTo(other.name);
            if (comparison != 0) {
                return comparison;
            }

            comparison = this.age.CompareTo(other.age);
            if (comparison != 0) {
                return comparison;
            }

            return this.town.CompareTo(other.town);
        }
    }
}
