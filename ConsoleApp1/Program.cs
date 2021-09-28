namespace ConsoleApp1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var bike = new Bike();
            var printBike = new PrintWheels<Bike>();
            var bikeWheels = printBike.GetWheels(bike);

            Console.WriteLine($"Bike wheels: {bikeWheels}");

            var car = new Car();
            var printCar = new PrintWheels<Car>();
            var carWheels = printCar.GetWheels(car);

            Console.WriteLine($"Car wheels: {carWheels}");

            var dog = new Dog();
            var printDog = new PrintNoise<Dog>();
            var dogNoise = printDog.GetNoise(dog);

            Console.WriteLine($"Dog noise: {dogNoise}");

            var duck = new Duck();
            var printDuck = new PrintNoise<Duck>();
            var duckNoise = printDuck.GetNoise(duck);

            Console.WriteLine($"Dog noise: {duckNoise}");

            Console.ReadKey();
        }
    }
}
