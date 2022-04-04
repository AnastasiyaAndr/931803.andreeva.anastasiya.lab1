using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.Services
{
    public class rngcalc : Irngcalc
    {
       static Random rnd = new Random();

        public int GetRand()
        {
            return rnd.Next(0, 10);
        }

        public int plus(int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
        public int divide(int a, int b)
        {
            if (b != 0)  return a / b;
            
            else  return -1; 
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        
    }
}
