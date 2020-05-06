using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class ShippingService
    {
        private double JedincaMase;

        public ShippingService(double JedincaMase) { this.JedincaMase = JedincaMase; }

        public double Price(double weight)
        {
            return JedincaMase * weight;
        }

        public override string ToString()
        {
            return "Ukupna cijena dostave je:";
        }
    }
}
