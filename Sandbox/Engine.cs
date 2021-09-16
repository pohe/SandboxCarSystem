using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Engine
    {
        //Instancefields
        private int _cylinders;

        private bool _turbo;

        private bool _fuel;

        private bool _electric;

        private bool _hybrid;

        //Properties


        public int Cylinders
        {
            get
            {
                return _cylinders;
            }

            set
            {
                _cylinders = value;
            }
        }

        private bool Turbo
        {
            get
            {
                return _turbo;
            }
            set
            {
                _turbo = value;
            }
        }
        private bool Fuel
        {
            get
            {
                return _fuel;
            }

            set
            {
                _fuel = value;
            }
        }

        private bool Electric
        {
            get
            {
                return _electric;

            }

            set
            { 
                _electric = value;

            }

        }



        private bool Hybrid

        {

            get

            {

                return _hybrid;

            }



            set

            {

                _hybrid = value;

            }

        }



        //Constructors

        public Engine(int cylinders, bool turbo, bool fuel, bool electric, bool hybrid)
        {
            _cylinders = cylinders;
            _turbo = turbo;
            _fuel = fuel;
            _electric = electric;
            _hybrid = hybrid;
        }
        //Methods
    }
}
