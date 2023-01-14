using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem5 {
    internal class Robot {
        public Robot() {

        }
        public Robot(string model,string id) {
            Model = model;
            Id = id;
        }

        public string Model { get; }
        public string Id { get; }
    }
}
