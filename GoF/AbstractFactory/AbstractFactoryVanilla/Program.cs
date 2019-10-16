using System;
using AbstractFactoryVanilla.NormalView;
using AbstractFactoryVanilla.NormalView.Concrete.Factories;

namespace AbstractFactoryVanilla
{
    internal class Program
    {
        private static void Main()
        {
            // Abstract factory #1
            NormalView.Interfaces.AbstractFactory factory1 = new ConcreteFactory1();
            var client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2
            NormalView.Interfaces.AbstractFactory factory2 = new ConcreteFactory2();
            var client2 = new Client(factory2);
            client2.Run();

            // Wait for user input
            Console.ReadKey();
        }
    }
}
