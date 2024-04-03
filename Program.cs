namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[2];
            vehicles[0] = new Car("Mersedes", "BMV", 2017);
            vehicles[0].Color = "black";
            ((Car)vehicles[0]).MaxSpeed = 250;
            vehicles[1] = new Bus(50, 2018);
            vehicles[1].Color = "greey";
            foreach (var vehicle in vehicles)
            {
                vehicle.Showinfo();
            }
        }
    }
}

