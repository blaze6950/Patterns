namespace AbstractFactoryVanilla.NormalView.Interfaces
{
    /// <summary>
    /// The 'AbstractFactory' abstract class. This factory implements using FactoryMethod pattern,
    /// so each method of this class is implementation of the FactoryMethod.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}