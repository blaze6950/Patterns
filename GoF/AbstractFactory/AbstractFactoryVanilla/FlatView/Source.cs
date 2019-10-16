using System;

namespace AbstractFactoryVanilla.FlatView
{
    #region AbstractFactory interface definition
    /// <summary>
    /// The 'AbstractFactory' abstract class. This factory implements using FactoryMethod pattern,
    /// so each method of this class is implementation of the FactoryMethod.
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
    #endregion

    #region Concrete classes of abstract factories
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

    /// <summary>
    /// The 'ConcreteFactory2' class
    /// </summary>
    public class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
    #endregion

    #region Products interface definitions
    /// <summary>
    /// The 'AbstractProductA' abstract class
    /// </summary>
    public abstract class AbstractProductA
    {
    }

    /// <summary>
    /// The 'AbstractProductB' abstract class
    /// </summary>
    public abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
    #endregion

    #region The first set of concrete products
    /// <summary>
    /// The 'ProductA1' class
    /// </summary>
    public class ProductA1 : AbstractProductA
    {
    }

    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
    #endregion

    #region The second set of concrete products
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    public class ProductA2 : AbstractProductA
    {
    }

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
    #endregion

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