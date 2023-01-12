using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
    internal class Pizza {

        private string _name;
        private Dough _dough;
        private List<Topping> _toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings) {
            Name = name;
            _dough = dough;
            Toppings = toppings;
        }

        private string Name {
            get { return _name; }
            set {
                if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine("Name ca not be null or empty");
                } else {
                    _name = value;
                }
            }
        }

        private List<Topping> Toppings {
            get { return _toppings; }
            set {
                if (value.Count() >= 10) {
                    Console.WriteLine("Number of toppings should be in range [0..10].");
                } else {
                    _toppings = value;
                }
                
            }

        }

        public double Calories {
            get {
                double sum = 0;
                if (Toppings != null) {

                    foreach (var toping in _toppings) {
                        sum += toping.Calories;
                    }
                    sum += _dough.Calories;
                }

                return sum;
            }
        }

        public static string CreatePizza() {

            string[] pizzaToAdd = Console.ReadLine().Split();


            string pizzaName = pizzaToAdd[1];


            string[] doughData = Console.ReadLine().Split();
            Dough dough = Dough.CreateDought(doughData);


            List<Topping> topings = new List<Topping>();
            do { 

                string[] toppingData = Console.ReadLine().Split();

                if (toppingData[0] == "END") { break; }

                Topping topping = Topping.CreateTopping(toppingData);
                topings.Add(topping);
            }while(true);


            Pizza pizza = new Pizza(pizzaName, dough, topings);

            if (pizza.Calories == 0) {
                return "";
            }
            return $"{pizza.Name} - {pizza.Calories}";
        }

    }
}




