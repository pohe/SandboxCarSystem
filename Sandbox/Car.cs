using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Car
    {
        //Instance fields - saves state

        private string _brand;
        private string _model;
        private string _regNo;
        private int _prodYear;
        private int _noOfDoors;
        private int _noOfPassengers;
        private int _km;

        private User _user;
        private Engine _engine;
        private NavigationSystem _navigationSystem;

        private Wheel _wheel;

        //Properties

        public string Brand
        {
            get { return _brand; }
        }

        public string Model
        {
            get { return _model; }
        }

        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value;  }
        }

        //Constructors

        public Car(string brand, string model, string regNum, int prodYear, int numOfDoors, int numOfPassengers, int km)
        {
            _brand = brand;
            _model = model;
            _regNo = regNum;
            _prodYear = prodYear;
            _noOfDoors = numOfDoors;
            _noOfPassengers = numOfPassengers;
            _km = km;
            _engine = new Engine(4, false, true, false, true);
            _navigationSystem = new NavigationSystem();
            _wheel = new Wheel("Summer", 2, 16);
        }

    //Methods

        public void SetUser(User user)
        {
            _user = user; 
        }

        public void ChangeWheel(Wheel aWheel)
        {
            _wheel = aWheel;
        }

    }
}
