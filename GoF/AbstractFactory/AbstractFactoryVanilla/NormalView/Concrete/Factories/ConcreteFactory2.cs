﻿using AbstractFactoryVanilla.NormalView.Concrete.AProducts;
using AbstractFactoryVanilla.NormalView.Concrete.BProducts;
using AbstractFactoryVanilla.NormalView.Interfaces;

namespace AbstractFactoryVanilla.NormalView.Concrete.Factories
{
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
}