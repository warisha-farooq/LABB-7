using System;

namespace VehicleHierarchy
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }
    }

    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int year, int numberOfDoors)
            : base(brand, model, year)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    public class Motorbike : Vehicle
    {
        public bool HasSidecar { get; set; }

        public Motorbike(string brand, string model, int year, bool hasSidecar)
            : base(brand, model, year)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {(HasSidecar ? "Yes" : "No")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Corolla", 2023, 4);
            Motorbike myBike = new Motorbike("Honda", "CBR", 2022, false);

            Console.WriteLine("--- Car Info ---");
            myCar.DisplayInfo();

            Console.WriteLine("\n--- Motorbike Info ---");
            myBike.DisplayInfo();

            Console.ReadLine();
        }
    }
}
