using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem3 {
    internal class Ferrari : IFerrari {
        public string Model { get; set; } = "488-Spider";

        public void Brake() {
            Console.Write("Brakes!");
        }

        public void Accelerate() {
            Console.Write("Zadu6avam sA!");
        }

    }
}
