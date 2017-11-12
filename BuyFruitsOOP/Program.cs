using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuyFruitsOOP.Classes;

namespace BuyFruitsOOP {
    class Program {
        static void Main(string[] args) {
            string conn = "2";
            int qty=0;
            bool t,b;
            int order;
            do {


                do {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1.Apple (RM1)");
                    Console.WriteLine("2.Grape (RM2)");
                    Console.WriteLine("3.Banana (RM3)");
                    Console.WriteLine("***Buy 10 - 10% discount.***");
                    Console.WriteLine("***Buy 20 - 30% discount.***");
                    order = Convert.ToInt32(Console.ReadLine());
                    b = Fruits.validateOrder(order);
                } while (b);

                fruitName fn = (fruitName)Enum.Parse(typeof(fruitName), Convert.ToString(order));
                do {
                    Console.WriteLine("How many would you like to buy?");
                    qty = Convert.ToInt32(Console.ReadLine());
                    t = Fruits.validateQty(qty);
                } while (t);

                Fruits f = new Fruits();
                double Total = f.getSubTotal(fn, qty);

                Console.WriteLine("Total:{0}", Total);
                Console.WriteLine("Continue shop?");
                Console.WriteLine("1.Yes");
                Console.WriteLine("2.No");
                conn = Console.ReadLine();

            } while (conn == "1");
        }
    }
}
