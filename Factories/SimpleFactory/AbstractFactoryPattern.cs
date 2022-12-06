using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    //abstract obkect group A
    public interface IDog
    {
        void Move();
        void PrefersToDo();
    }
    //abstract obkect group B
    public interface ICat
    {
        void Move();
        void SawAMan();
    }
    //Object A1
    public class PetDog:IDog
    {
        public void Move()
        {
            Console.WriteLine("Moved");
        }

        public void PrefersToDo()
        {
            Console.WriteLine("prefer to play");
        }
    }
    //object B1
    public class PetCat:ICat
    {
        public void Move()
        {
            Console.WriteLine("Moved");
        }

        public void SawAMan()
        {
            Console.WriteLine("come to him");
        }
    }
    //object B2
    public class WildCat:ICat
    {
        public void Move()
        {
            Console.WriteLine("Moved");
        }

        public void SawAMan()
        {
            Console.WriteLine("running");
        }
    }
    //object A2
    public class WildDog:IDog
    {
        public void Move()
        {
            Console.WriteLine("Moved");
        }

        public void PrefersToDo()
        {
            Console.WriteLine("starts braking");
        }
    }
    //abstract factory
    public interface IAnimalFactory
    {
        public ICat CreateCat();
        public IDog CreaDog();
    }

    public class WildAnimalFactory:IAnimalFactory
    {
        public ICat CreateCat()
        { 
            return new WildCat();
        }

        public IDog CreaDog()
        {
            return new WildDog();
        }
    }

    public class PetAnimalFactory:IAnimalFactory
    {
        public ICat CreateCat()
        {
            return new PetCat();
        }

        public IDog CreaDog()
        {
            return new PetDog();
        }
    }
}
