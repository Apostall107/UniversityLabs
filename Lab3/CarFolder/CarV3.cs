using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.CarFolder.CarV3 {
    internal class CarV3 {
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public int Weight { get; set; } 
        public string Color { get; set; } 

        public CarV3(string model, Engine engine, int weight = 0 , string color = "n/a") {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public static void Problem10Task() {

            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();

            for (int i = 0; i < n; i++) {

                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                int power = int.Parse(tokens[1]);
                int displacement = tokens.Length > 2 ? int.Parse(tokens[2]) : 0;
                string efficiency = tokens.Length > 3 ? tokens[3] : "n/a";

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }
            int m = int.Parse(Console.ReadLine());

            List<CarV3> cars = new List<CarV3>();
            for (int i = 0; i < m; i++) {

                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                string engine = tokens[1];
                int weight = 0;
                string color = "n/a";
                if (tokens.Length > 2) {
                    if (tokens[2].GetType() == typeof(int)) {
                        weight = tokens.Length > 2 ? int.Parse(tokens[2]) : 0;
                        color = tokens.Length > 3 ? tokens[3] : "n/a";
                    } else {
                        weight = 0;
                        color = tokens.Length > 2 ? tokens[2] : "n/a";
                    }
                }

                Engine carEngine = engines.Where(x => x.Model == engine).First();

                CarV3 car = new CarV3(model, carEngine, weight, color);
                cars.Add(car);
            }

            foreach (var car in cars) {
                Console.WriteLine(car);
            }

        }
        public override string ToString() {
            return 
                $"{this.Model}:" +
                $"\n\t {this.Engine.Model}" +
                $"\n\t\tPower: {this.Engine.Power}" +
                $"\n\t\tDisplacement: {this.Engine.Displacement}" +
                $"\n\t\tEfficiency: {this.Engine.Efficiency}" +
                $"\n\tWeight: {this.Weight}" +
                $"\n\tColor: {this.Color}";

        }

    }

    internal class Engine {
        public string Model { get; set; }
        public int Power { get; set; }
        public int Displacement { get; set; } 
        public string Efficiency { get; set; }

        public Engine() {

        }
        public Engine(string model, int power, int displacement = 0, string efficiency = "n/a")  {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }


    }
}

