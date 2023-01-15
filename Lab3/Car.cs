using System.Globalization;

namespace Lab3 {
    public class Car {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1Km { get; set; }
        public int DistanceTraveled { get; set; }
        public int ToTravel { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumtionFor1Km) {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1Km = fuelConsumtionFor1Km;
            this.DistanceTraveled = 0;
        }

        public void Drive(int amountOfKm, int carsToTrack) {
            int counter = 0;

            double fuelNeeded = amountOfKm * this.FuelConsumptionFor1Km;
            if (fuelNeeded > this.FuelAmount) {
                Console.WriteLine("Insufficient fuel for the drive");
            } else if (counter < carsToTrack) {
                counter++;
                this.DistanceTraveled += amountOfKm;
                this.FuelAmount -= fuelNeeded;

                Console.WriteLine($"{Model} {FuelAmount} {DistanceTraveled}");
            }
        }

        public static void CheckCarDriveDistanceAvaliable() {
            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            double fuelConsumtionFor1Km;
            int toTravel;
            double fuelAmount;
            string model;


            do {
                string[] tokens = Console.ReadLine().Split();
                if (tokens[0] == "End") {
                    break;
                } else if (tokens[0] == "Drive") {
                    model = tokens[1];
                    toTravel = int.Parse(tokens[2]);
                    var car = cars.Where(x => x.Model == model).First();
                    car.ToTravel += toTravel;

                } else {
                    model = tokens[0];
                    fuelAmount = double.Parse(tokens[1], provider);
                    fuelConsumtionFor1Km = double.Parse(tokens[2], provider);

                    Car car = new Car(model, fuelAmount, fuelConsumtionFor1Km);
                    cars.Add(car);
                }
            } while (true);


            foreach (var item in cars) {
                item.Drive(item.ToTravel, n);
            }

        }



        public override string ToString() {
            return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
        }
    }
}