using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a separate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Standard initialization
           CarLot lot = new CarLot();

            Car toyota = new Car();
            lot.CarList.Add(toyota);
            toyota.Year = 2010;
            toyota.Make = "Prius";
            toyota.Model = "Hybrid";
            toyota.EngineNoise = "Barely";
            toyota.HonkNoise = "weak beep beep";
            toyota.IsDriveable = true;

            toyota.MakeEngineNoise();
            toyota.MakeHonkNoise();
                

            //Object initializer syntax
            Car celica = new Car() { Year = 2010, Make = "Toyota", Model = "Celica", EngineNoise = "None", HonkNoise = "Sad" };
            lot.CarList.Add(celica);

            celica.MakeEngineNoise();
            celica.MakeHonkNoise();

            //Constructor initialization
            Car someOtherCar = new Car(9999, "Venus Inc.", "Omega ++", "Mouth breathing", "What does a space alien eat?");
            lot.CarList.Add(someOtherCar);

            someOtherCar.MakeEngineNoise();
            someOtherCar.MakeHonkNoise();

           
            //*************BONUS X 2*************//

            foreach(var car in lot.CarList)
            { 
                Console.WriteLine();
                Console.WriteLine($"Year:{car.Year} Make:{car.Make} Model:{car.Model}");
            }

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
