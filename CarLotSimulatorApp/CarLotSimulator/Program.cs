using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var myCar = new Car();

            myCar.Make = "honda";
            myCar.Model = "civic";
            myCar.Year = 2020;
            myCar.HonkNoise = "loud";
            myCar.EngineNoise = "noisy";
            myCar.IsDriveable = true;
            Console.WriteLine($"I own a {myCar.Year} {myCar.Make} {myCar.Model}");
            Console.WriteLine($"Its Horn is very {myCar.HonkNoise}, the engine is slightly {myCar.EngineNoise}");
            Console.WriteLine($"Its { myCar.IsDriveable} this car can be driven");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();

            var alsoMyCar = new Car();

            alsoMyCar.Make = "Chevrolet";
            alsoMyCar.Model = "1500";
            alsoMyCar.Year = 2013;
            alsoMyCar.HonkNoise = "insert honk noise here";
            alsoMyCar.EngineNoise = "Vroom Vroom";
            alsoMyCar.IsDriveable = true;
            Console.WriteLine($"I own a {alsoMyCar.Year} {alsoMyCar.Make} {alsoMyCar.Model}.");
            Console.WriteLine($"Its { alsoMyCar.IsDriveable} that is can be driven although, the horn is very {alsoMyCar.HonkNoise}.");
            Console.WriteLine($"Side Note I love to hear the engine go {alsoMyCar.EngineNoise}");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();


            var oldCar = new Car(2000, "Toyota", "Celica", "noisy", "honking", true);
            Console.WriteLine($"I own a {oldCar.Year} {oldCar.Make} {oldCar.Model}");
            Console.WriteLine($"It is {oldCar.IsDriveable}, this car is driveable.");
            Console.WriteLine($"The engine is slightly {oldCar.EngineNoise}, but the {oldCar.HonkNoise} Function");
            Console.WriteLine("works correctly.");
            Console.WriteLine("Press enter to view amount of cars stored in the car lot currently.");
            Console.ReadLine();
            Console.WriteLine($"Number of cars currently in the car lot : {CarLot.numberOfCars}");


        }
    }       
}
