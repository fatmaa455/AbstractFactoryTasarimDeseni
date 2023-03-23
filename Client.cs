using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory1
{
    class Client // dependecy gibi
    {
        // istemci somut sınıfları bilmez
        // soyut sınıflar üzerinden tür dönüşümleri ile nesneleri oluşturur
        // istemci soyut fabrika arayüzüne bağlanır
        IHdd hdd;
        IRam ram;

        // oluşturucu üzerinde hangi ürün oluşturulacağına karar verir
        public Client(IFactory factory) // parametre soyut fabrika nesnesi
        {
            // soyut fabrikanın üretimden sorumlu metotları
            hdd = factory.createHdd();
            ram = factory.createRam();
        }
        public void calistir()
        {
            hdd.HddIslem();
            ram.ramIslem();
        }
    }
}
