using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.VIN = "123456";
            car.Manufacturer = "Toyota";
            car.Model = "Camry";
            car.YearManufactured = 2023;
            car.IsWorking = true;

            // Store car using IVehicle interface type
            IVehicle vehicle = car;

            // Access properties and methods using the interface
            Console.WriteLine($"VIN: {(vehicle as Car).VIN}");

            Console.ReadLine();
        }
    }

    public interface IVehicle
    {
        bool IsWorking { get; set; }
        void Start();
        void Stop();
    }

    public abstract class Vehicle : IVehicle
    {
        public string VIN { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int YearManufactured { get; set; }
        public bool IsWorking { get; set; }

        public void Start()
        {

        }

        public void Stop()
        {

        }
    }

    public class Car : Vehicle
    {
        public int NumberOfWheels { get; set; } = 4;
    }
}
