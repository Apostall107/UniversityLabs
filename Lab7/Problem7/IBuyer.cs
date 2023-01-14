using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7.Problem7 {
    internal interface IBuyer {
        public void BuyFood();

        public static int Food { get; set; }
    }
}
