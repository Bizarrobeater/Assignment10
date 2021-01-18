using System;
using System.Collections.Generic;

namespace Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution10o3();
        }

        static void Solution10o0()
        {
            var student1 = new Student("Ben Solo");
            var student2 = new Student("Han Solo");

            Console.WriteLine($"{student1.Name} {student2.Name}");
        }

        static void Solution10o1()
        {
            var student1 = new Student("Ben Solo");
            var student2 = new Student("Han Solo");

            Console.WriteLine($"{student1.Name} {student2.Name}");

            student1.SetValue("Jacen Solo");
            student2.SetValue("Jaiden Solo");

            Console.WriteLine($"{student1.Name} {student2.Name}");
        }

        // Testing the Counter class
        static void Solution10o2()
        {
            var testCounter = new Counter();


            Console.WriteLine($"Test Initial Conditions\nResult: {testCounter.Get() == 0}\n");
            testCounter.Incr();
            Console.WriteLine($"Test Incr Method\nResult: {testCounter.Get() == 1}\n");          
        }

        // Testing the Car Class
        static void Solution10o3()
        {
            Console.WriteLine("Testing Car construction:");
            double[] fuelEcons = new double[]{ 10, 1, 1.5, 0, 22, -1.67 };
            List<Car> createdCars = new List<Car>();
            bool[] expected = new bool[] { true, true, true, false, true, false };

            for (int i = 0; i < 6; i++)
            {
                Car tempCar;
                Console.WriteLine($"\nTesting Fuel Economy of {fuelEcons[i]}");
                string expectedResult = expected[i] ? "Success" : "Error";
                Console.WriteLine($"Expected result = {expectedResult}");
                Console.Write($"Result = ");
                try
                {
                    tempCar = new Car(fuelEcons[i]);
                    createdCars.Add(tempCar);
                    Console.Write("Success\n");
                }
                catch (FuelEconomyExpection ex)
                {
                    Console.Write(ex.Message + "\n");
                    continue;
                }
            }

            Console.WriteLine("\nTesting Adding Fuel to a car");
            Car fuelAddCar = new Car(10);
            double[] fuelToAdd = new double[] { 0.2, 10, 12, 1.456 };
            double sum = 0;

            foreach (double fuel in fuelToAdd)
            {
                sum += fuel;
                fuelAddCar.AddGas(fuel);
            }

            Console.WriteLine($"Added {sum} fuel to the car over 4 runs\nResult = {fuelAddCar.GasLeft}\n");

            Console.WriteLine("Testing Driving");

            double fuelEcon = 20;
            double gasAdded = 35;
            double drivenKm = 5.5;

            Car drivenCar = new Car(fuelEcon);
            drivenCar.AddGas(gasAdded);

            int runs = 0;
            int expectedRuns = (int)(gasAdded / (drivenKm/fuelEcon)); // Expected to drive 12.72 times

            while (true)
            {
                try
                {
                    drivenCar.Drive(drivenKm);
                    runs++;
                }
                catch (NoFuelException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine($"Expected runs = {expectedRuns}");
                    Console.WriteLine($"Realised runs = {runs}");
                    break;
                }
            }
        }
    }
}
