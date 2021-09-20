using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            Car theCar = new Car("Skoda", "Octavia", "232323", 2015, 5, 5, 200000);

            int antalCylinder = theCar.Engine.Cylinders;
            Console.WriteLine($"Antal cylinders {antalCylinder}");
            theCar.ChangeWheel(new Wheel("Winter", 16, 2 ));
            Console.WriteLine(theCar.ToString());

            User aUser = new User("Peter", "pele@easj.dk", 12121212, "Gade 123");
            //aUser.Address = "Street 123";

            aUser.Reputation = 4;
            Console.WriteLine(aUser.ToString());


            theCar.SetUser(aUser);


            Wheel aWheel = new Wheel("Winter", 2.0, 16);

            //Console.WriteLine("Hello world!");

            // The LAST line of code should be ABOVE this line
        }
    }
}