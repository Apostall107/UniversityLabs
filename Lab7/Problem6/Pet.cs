using Lab7.Problem2;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem6  {
    internal class Pet  {
        public Pet() {

        }
        public Pet(string name, string birthDate) {
            Name = name;
            Birthdate = DateTime.ParseExact(birthDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public string Name { get; }
        public DateTime Birthdate { get; }
    }
}
