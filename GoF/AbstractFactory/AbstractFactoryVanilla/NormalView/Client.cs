using AbstractFactoryVanilla.NormalView.Interfaces;

namespace AbstractFactoryVanilla.NormalView
{
    /// <summary>
    /// The 'Client' class. Interaction environment for the products.
    /// This class uses an abstract factory for getting concrete products.
    /// </summary>
    public class Client
    {
        private readonly AbstractProductA _abstractProductA;
        private readonly AbstractProductB _abstractProductB;

        // Constructor
        public Client(AbstractFactory factory)
        {
            _abstractProductB = factory.CreateProductB();
            _abstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }
}