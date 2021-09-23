using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public static class Calculator
    {
        //Alle klasser har en default constructor

        //public Calculator()
        //{
            
        //}


        //Der skal ikke gemmes nogle værdier/tilstande

        public static int Multiply(int t1, int t2)
        {
            return t1 * t2;
        }

        public static int Add(int t1, int t2)
        {
            return t1 + t2;
        }

        public static int Subtract(int t1, int t2)
        {
            return t1 - t2;
        }

        public static double Divide(int t1, int t2)
        {
            return t1 / (t2*1.0);
        }

    }
}
