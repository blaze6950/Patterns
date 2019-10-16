using AbstractFactoryVanilla.NormalView.Concrete.AProducts;
using AbstractFactoryVanilla.NormalView.Concrete.BProducts;
using AbstractFactoryVanilla.NormalView.Interfaces;

namespace AbstractFactoryVanilla.NormalView.Concrete.Factories
{
    /// <summary>
    /// The 'ConcreteFactory1' class
    /// </summary>
    public class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}