using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    // ürünlerin üretiminden sorumlu
    // soyut fabrika parametre olarak somut nesne oluşturucu alır
    // abstract factory
    interface IFactory
    {
        IHdd createHdd();
        IRam createRam();
    }

    // concrete factory
    class Factory1 : IFactory
    {
        // üretim sonucunda ürünün classı geri döner
        public IHdd createHdd()
        {
            return new HddTur1();
        }

        public IRam createRam()
        {
            return new RamTur1();
        }
    }
    class Factory2 : IFactory
    {
        public IHdd createHdd()
        {
            return new HddTur2();
        }

        public IRam createRam()
        {
            return new RamTur2();
        }
    }
}
