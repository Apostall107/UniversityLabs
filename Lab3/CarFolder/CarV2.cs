using System.Globalization;

namespace Lab3.CarFolder {
    public class CarV2 {

        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire Tires { get; set; }
        public CarV2(string model, Engine engine, Cargo cargo, Tire tires) {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Tires = tires;
        }

        public static void Problem8Task() {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";



            int n = int.Parse(Console.ReadLine());
            List<CarV2> cars = new List<CarV2>();
            // salary needs to be entered with , insted of .  
            for (int i = 0; i < n; i++) {
                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                Tire tires = new Tire();

                string[] tokens = Console.ReadLine().Split();
                string model = tokens[0];
                engine.EngineSpeed = int.Parse(tokens[1]);
                engine.EnginePower = int.Parse(tokens[2]);
                cargo.CargoWeight = int.Parse(tokens[3]);
                cargo.CargoType = tokens[4];

                tires.Tire1Pressure = double.Parse(tokens[5], provider);
                tires.Tire1Age = int.Parse(tokens[6]);
                tires.Tire2Pressure = double.Parse(tokens[7], provider);
                tires.Tire2Age = int.Parse(tokens[8]);
                tires.Tire3Pressure = double.Parse(tokens[9], provider);
                tires.Tire3Age = int.Parse(tokens[10]);
                tires.Tire4Pressure = double.Parse(tokens[11], provider);
                tires.Tire4Age = int.Parse(tokens[12]);


                CarV2 car = new CarV2(model, engine, cargo, tires);
                cars.Add(car);
            }
            string type;
            do {
                Console.WriteLine("Enter the Cargo type to show (fragile / flamable)");
                type = Console.ReadLine();
            } while (type != "fragile" && type != "flamable");

            List<CarV2> carsToShow;
            if (type == "fragile") {
                carsToShow = cars.Where(x => x.Tires.Tire1Pressure < 1 || x.Tires.Tire2Pressure < 1 || x.Tires.Tire3Pressure < 1 || x.Tires.Tire4Pressure < 1).ToList();
            } else {
                carsToShow = cars.Where(x => x.Engine.EnginePower > 250).ToList();
            }

            foreach (var item in carsToShow) {
                Console.WriteLine(item.Model);
            }
        }





    }


}

public class Engine {
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }
}

public class Cargo {
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
}

public class Tire {
    public int Tire1Age { get; set; }
    public int Tire2Age { get; set; }
    public int Tire3Age { get; set; }
    public int Tire4Age { get; set; }
    public double Tire1Pressure { get; set; }
    public double Tire2Pressure { get; set; }
    public double Tire3Pressure { get; set; }
    public double Tire4Pressure { get; set; }

}


