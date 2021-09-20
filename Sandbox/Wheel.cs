using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Wheel
    {
        //Instance fields
        private string _season;
        private double _pressure;
        private double _size;



        //Properties 

        public string Season
        {
            get { return _season; }
        }



        public double Pressure
        {
            get { return _pressure; }
        }



        public double Size
        {
            get { return _size; }
        }


        //Constructors

        public Wheel(string season, double pressure, double size)
        {
            _season = season;
            _pressure = pressure;
            _size = size;
        }
        //Methods

        public override string ToString()
        {
            return $"Wheel info season {_season} pressure {_pressure} size {_size} ";
        }
    }
}
