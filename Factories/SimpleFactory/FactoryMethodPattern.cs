using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public interface ICar
    {
        public void Start();
        public void Stop();
        public string DriverLicensieLevel { get;}
    }

    public class PassangerCar:ICar
    {
        public PassangerCar()
        {
        }

        public PassangerCar(string driverLicensieLevel)
        {
            this.driverLicensieLevel = driverLicensieLevel;
        }
        public void Start()
        {
            Console.WriteLine("wait!");
            Thread.Sleep(500);
            Console.WriteLine("wait!");
            Thread.Sleep(500);
            Console.WriteLine("started");
        }

        public void Stop()
        {
            Console.WriteLine("stoped");
        }

        public string DriverLicensieLevel
        {
            get
            {
                return this.driverLicensieLevel;
            }
        }
        private string driverLicensieLevel="A";
    }

    public class Truck:ICar
    {
        public Truck(string driverLicensieLevel)
        {
            this.driverLicensieLevel=driverLicensieLevel;
        }

        public Truck()
        {
        }
        public void Start()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("wait");
                Thread.Sleep(500);
            }
            Console.WriteLine("started");
        }
        public void Stop()
        {
            Console.WriteLine("stoped");
        }

        public string DriverLicensieLevel
        {
            get
            {
                return this.driverLicensieLevel;
            }
        }

        private string driverLicensieLevel="B";
    }

    public interface ICarFactory
    {
        public ICar CreateCar();
        public ICar CreateCar(string driverlicensieLevel);
    }

    public class PassengerCarFactory : ICarFactory
    {
        public ICar CreateCar()
        {
            return new PassangerCar();
        }

        public ICar CreateCar(string driverlicensieLevel)
        {
            return new PassangerCar(driverlicensieLevel);
        }
    }

    public class TruckFactory:ICarFactory
    {
        public ICar CreateCar()
        {
            return new PassangerCar();
        }

        public ICar CreateCar(string driverlicensieLevel)
        {
            return new PassangerCar(driverlicensieLevel);
        }
    }


}
