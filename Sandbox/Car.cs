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
        private int _id;
        private static int _lastId = 1;
        private string _brand;
        private string _model;
        private string _regNo;
        private int _prodYear;
        private int _noOfDoors;
        private int _noOfPassengers;
        private int _km;

        private User _user;  //Association
        private Engine _engine; //Composition
        private NavigationSystem _navigationSystem; //Composition

        private Wheel _wheel; //Aggregation

        //Properties

        public int Id
        {
            get { return _id; }
        }
        
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

        public Engine Engine
        {
            get { return _engine; }
        }
        //Constructors

        public Car(string brand, string model, string regNum, int prodYear, int numOfDoors, int numOfPassengers, int km)
        {
            _lastId =_lastId + 1;
            _id = _lastId;
            _brand = brand;
            _model = model;
            _regNo = regNum;
            _prodYear = prodYear;
            _noOfDoors = numOfDoors;
            _noOfPassengers = numOfPassengers;
            _km = km;
            _engine = new Engine(4, false, true, false, true); //Composition - fødses og dør med objetet
            _navigationSystem = new NavigationSystem();
            _wheel = new Wheel("Summer", 2, 16);
        }

    //Methods

        public void SetUser(User user)
        {
            _user = user; 
        }

        public void ChangeWheel(Wheel aWheel)  //Aggregation - Wheel er mere uafhængigt af Car. Kan skiftet
        {
            _wheel = aWheel;
        }


        public override string ToString()
        {
            return $"Car info brand:{_brand}, model:{_model}, regno:{_regNo}, {_wheel.ToString()} ";
        }
    }
}
