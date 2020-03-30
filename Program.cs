using System;

namespace TheCoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            milk milk = new milk(300);
            CoffeMachine yummyCoffe = new CoffeMachine(coffe, water,milk);
            //1st
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //2nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
             result = yummyCoffe.MakeCappucino();
            Console.WriteLine("result" + result);
            //3nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //4nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.MakeCappucino();
            Console.WriteLine("result" + result);
            //5nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);
            //6nd
            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.MakeCappucino();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
        }
    }
}

