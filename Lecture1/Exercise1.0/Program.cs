namespace Exercise1._0
{
    abstract class Vehicle
    {
        private string make;
        private string model;
        private int year;

        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }

        public virtual void vehicle_info()
        {
            Console.WriteLine("#########################");
            Console.WriteLine($"Make:  {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year:  {year}");
        }
    }

    class Car : Vehicle
    {
        private int num_doors;

        public Car(string make, string model, int year, int num_doors) : base(make, model, year)
        {
            this.num_doors = num_doors;
        }

        public override void vehicle_info()
        {
            base.vehicle_info();
            Console.WriteLine($"Number of doors: {num_doors}");
        }
    }

    class Bike : Vehicle
    {
        private string bike_type;

        public Bike(string make, string model, int year, string bike_type) : base(make, model, year)
        {
            this.bike_type = bike_type;
        }

        public override void vehicle_info()
        {
            base.vehicle_info();
            Console.WriteLine($"Bike type: {bike_type}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "GR Corolla", 2025, 5);
            Bike bike = new Bike("Canyon", "Aeroad CFR Di2", 2024, "Road Bike");

            car.vehicle_info();
            bike.vehicle_info();
        }
    }
}