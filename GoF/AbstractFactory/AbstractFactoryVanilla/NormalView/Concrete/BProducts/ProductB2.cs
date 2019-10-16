using System;
using AbstractFactoryVanilla.NormalView.Interfaces;

namespace AbstractFactoryVanilla.NormalView.Concrete.BProducts
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
}