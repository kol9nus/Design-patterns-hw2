using System;

namespace Homework2
{
    class Program
    {
        private static void Main(string[] args)
        {
            // Комплектация ауди
            ICarFactory audiFactory = new AudiFactory();
            PrintResultingCar(audiFactory);

            Console.WriteLine();

            // Комплектация bmw
            ICarFactory bmwFactory = new BMWFactory();
            PrintResultingCar(bmwFactory);

            Console.ReadLine();
        }

        private static void PrintResultingCar(ICarFactory factory)
        {
            Console.WriteLine("Машина имеет: ");
            var carcass = factory.CreateCarcass();
            Console.WriteLine(carcass.Name);
            var cabin = factory.CreateCabin();
            Console.WriteLine(cabin.Name);
            var engine = factory.CreateEngine();
            Console.WriteLine(engine.Name);
        }
    }
}
