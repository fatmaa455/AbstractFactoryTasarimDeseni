using System;

namespace AbstractFactory1
{
    class Program
    {
        static void Main(string[] args)
        {
            // abstract factory örnek 1
            Client c = new Client(new Factory1());
            c.calistir();

            Client c2 = new Client(new Factory2());
            c2.calistir();
        }
    }
}
