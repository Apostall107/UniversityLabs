using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem7 {
    internal class Rebel : IBuyer {

        public Rebel(string name, string age, string group) {
            Name = name;
            Age = age;
            Group = group;
        }

        public string Name { get; }
        public string Age { get; }
        public string Group { get; }
        public static int Food { get; set; }

        public void BuyFood() {
            Food += 5;
        }
    }
}
