using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface IAnimal
    {
        public void Move();

        public void Eat();
    }
    //obect A
    public class Dog : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("moved");
        }

        public void Eat()
        {
            Console.WriteLine("ate");
        }
    }
    //object B
    public class Cat : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("moved");
        }

        public void Eat()
        {
            Console.WriteLine("ate");
        }
    }
    //FactoryAbstraction
    public interface ISimpleFactory
    {
        public IAnimal CreateAnimal(int choiseNumber);
    }
    //Simple Factory
    public class SimpleFactory : ISimpleFactory
    {
        public IAnimal CreateAnimal(int choiseNumber)
        {

            switch (choiseNumber)
            {
                case 1:
                    return new Cat();break;
                case 2:
                    return new Dog();break;
                default:
                    throw new Exception("incorrect number");break;
                    
            }
        }
    }
}
