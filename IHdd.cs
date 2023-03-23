using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    // abstract product
    interface IHdd
    {
        void HddIslem();
    }

    // concrete product
    class HddTur1 : IHdd
    {
        public void HddIslem()
        {
            Console.WriteLine("Tür Hdd 1");
        }
    }
    // concrete product
    class HddTur2 : IHdd
    {
        public void HddIslem()
        {
            Console.WriteLine("Tür Hdd 2");
        }
    }
}
