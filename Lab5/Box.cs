using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5 {
    internal class Box {
        double l, w, h;
        public Box(double l, double w, double h) {
            this.l = l;
            this.w = w;
            this.h = h;
        }

        public Box() { }

        private double L {
            set {
                if (value < 0) {
                    Console.WriteLine("L cannot be zero or negative. ");
                } else {
                    l = value;
                }
            }
        }
        private double W {
            set {
                if (value < 0) {
                    Console.WriteLine("W cannot be zero or negative. ");
                } else {
                    l = value;
                }
            }
        }
        private double H {
            set {
                if (value < 0) {
                    Console.WriteLine("H cannot be zero or negative. ");
                } else {
                    l = value;
                }
            }
        }

        public double CalculateSurfaceArea() {
            return (2 * l * w) + (2 * l * h) + (2 * w * h);
        }
        public double CalculateLateralSurface() {
            return (2 * l * h) + (2 * w * h);
        }
        public double CalculateVolume() {
            return l * w * h;
        }

    }
}
