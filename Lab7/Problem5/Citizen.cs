using Lab7.Problem7;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem5 {
    internal class Citizen : IBuyer {
        public Citizen() {

        }
        public Citizen(string name, string age, string id) {
            Name = name;
            Age = age;
            Id = id;
        }
        public Citizen(string name, string age, string id, string birthDate) {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public DateTime Birthdate { get; }
        public string Name { get; }
        public string Age { get; }
        public string Id { get; }
        public static int Food { get; set; } = 0;

        public void BuyFood() {
            Food += 10;
        }
    }
}
