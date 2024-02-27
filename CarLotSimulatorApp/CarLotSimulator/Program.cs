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


            //Create a CarLot class
            //It should have at least one property: a List of cars

            CarLot lot = new CarLot();
            

            var myAudi = new Car();

            //Set the properties for each of the cars
            //Dot Notation
            myAudi.Year = 2021;
            myAudi.Make = "Audi";
            myAudi.Model = $"\t A4";
            myAudi.EngineNoise = "vroom vroom";
            myAudi.HonkNoise = "Honk";
            myAudi.IsDriveable = true;

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            lot.CarList.Add(myAudi);


            //Object Iniitializer Syntax
            var myMustang = new Car()
            { 
            Year = 1967,
            Make = "Mustang",
            Model = "Shelby GT 500",
            EngineNoise = "VROOM!",
            HonkNoise = "Honk Honk",
            IsDriveable = true,
            };

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            lot.CarList.Add(myMustang);


            //Constructor with parameter values
            var myFirstCar = new Car(1987,"Plymouth","Sundance","Sputter","Quack", false);

            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            lot.CarList.Add(myFirstCar);

            //Call each of the methods for each car
            myAudi.MakeEngineNoise();
            myMustang.MakeEngineNoise();
            myFirstCar.MakeEngineNoise();

            myAudi.MakeHonkNoise();
            myMustang.MakeHonkNoise();
            myFirstCar.MakeHonkNoise();




            //*************BONUS*************//

            //DONE Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            Console.WriteLine("-----------Cars in Lot-------------");
            foreach (var car in lot.CarList)
            {
                
                Console.WriteLine($"{car.Year}\t {car.Make}\t {car.Model}\t");
            }
        }
    }
}
