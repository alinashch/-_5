// See https://aka.ms/new-console-template for more information
namespace task5
{
    internal class Program
    {
        static void Main()
        {

            var car1 = new Truck()
            {
                maxspeed = 100,
                color = "red",
                name = "transit",
                number = "1AAA12 23",
                date = "12.12.2000"

            };

            var car2 = new Truck()
            {
                maxspeed = 200,
                color = "black",
                name = "tourneo",
                number = "2AAA33 55",
                date = "12.12.1999"

            };
            var cars = new List<Vehicle>();

            cars.Add(car1);
            cars.Add(car2);

            foreach (var c in cars)
            {
                Console.WriteLine(c.Start());

                Console.WriteLine(c.Stop());
                if (c is Car car)
                {
                    Console.WriteLine(car.freight())

                }
            }


        }

    }
  }