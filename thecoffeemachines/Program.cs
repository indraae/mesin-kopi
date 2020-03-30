using System;

namespace thecoffeemachines
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeePowder coffe = new CoffeePowder(100);
            WaterGalon water = new WaterGalon(1000);
            Milk milk = new Milk(300);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe, water, milk);

            //1st cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            //2nd cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            //3rd cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            //4th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            //5th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            //6th cup coffe
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
        }
    }
}
