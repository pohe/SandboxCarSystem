using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Calculator c = new Calculator();
            //int res= c.Multiply(2, 3);

            //int res = Calculator.Multiply(2, 3);

            //Console.WriteLine(res);


            Car theCar = new Car("Skoda", "Octavia", "232323", 2015, 5, 5, 200000);
            //int theCarId = theCar.Id;

            Car theCar2 = new Car("Audi", "V6", "34536", 2018, 5, 5, 30000);
            //int theCar2Id = theCar2.Id;


            //string brandName = theCar.Brand;
            //theCar.RegNo = "23234445";
            //int antalCylinder = theCar.Engine.Cylinders;
            //Console.WriteLine($"Antal cylinders {antalCylinder}");
            //theCar.ChangeWheel(new Wheel("Winter", 16, 2 ));
            //Console.WriteLine(theCar.ToString());

            User aUser = new User("Peter", "pele@easj.dk", 12121212, "Gade 123");
            ////aUser.Address = "Street 123";

            //aUser.Reputation = 4;
            //Console.WriteLine(aUser.ToString());


            theCar.SetUser(aUser);

            Wheel aNewWheel = new Wheel("Winter", 2.3, 16);
            theCar2.ChangeWheel(aNewWheel);

            string infoCar2 = theCar2.Wheel.ToString();
            Console.WriteLine(infoCar2);

            //Wheel aWheel = new Wheel("Winter", 2.0, 16);

            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}