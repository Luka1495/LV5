using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box("boxing day");
            Product product = new Product("Luka", 69, 4);
            Product pro = new Product("Vukadin", 33, 3);
            box.Add(product);
            box.Add(pro);


            ShippingService price = new ShippingService(4);
            double w = 0;

            w += box.Weight;
            Console.WriteLine(box.Description());


            Console.WriteLine(price.ToString() + price.Price(w) + " kuna");

        }
    }
}
