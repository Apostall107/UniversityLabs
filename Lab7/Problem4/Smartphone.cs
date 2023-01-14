using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem4 {
    internal class Smartphone : ICallable, IBrowseable {
        public List<string> Numbers { get; set; } = new List<string>(); 
        public List<string> Sites { get; set; } = new List<string>();

        public Smartphone() {

        }

        public void Call(string number) {
            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url) {
            if (url.Any(char.IsDigit)) {
                Console.WriteLine("Invalid URL!");
            } else {
                Console.WriteLine($"Browsing: {url}!");
            }
        }
    }
}
