using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    // abstract product
    interface IRam
    {
        void ramIslem();
    }

    //concrete product
    class RamTur1 : IRam
    {
        public void ramIslem()
        {
            Console.WriteLine("Tür 1 Ram");
        }
    }
    // concrete product
    class RamTur2 : IRam
    {
        public void ramIslem()
        {
            Console.WriteLine("Tür 2 Ram");
        }
    }
}
