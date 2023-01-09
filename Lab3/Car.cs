using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3 {
    public class Car {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionFor1Km { get; set; }
        public int DistanceTraveled { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumtionFor1Km) {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionFor1Km = fuelConsumtionFor1Km;
            this.DistanceTraveled = 0;
        }

        public void Drive(int amountOfKm) {
            double fuelNeeded = amountOfKm * this.FuelConsumptionFor1Km;
            if (fuelNeeded > this.FuelAmount) {
                Console.WriteLine("Insufficient fuel for the drive");
            } else {
                this.DistanceTraveled += amountOfKm;
                this.FuelAmount -= fuelNeeded;
            }
        }

        public override string ToString() {
            return $"{this.Model} {this.FuelAmount:f2} {this.DistanceTraveled}";
        }
    }
}
