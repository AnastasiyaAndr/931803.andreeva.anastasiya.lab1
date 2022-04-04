using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.Models
{
    public class RNG
    {
        Random rnd = new Random();
        public int value1;
        public int value2;
        public int plus;
        public int minus;
        public int divide;
        public int multiply;
        public RNG()
        {
            value1 = rnd.Next(0, 10);
            value2 = rnd.Next(0, 10);



            plus = value1 + value2;

            minus = value1 - value2;


            if (value2 != 0) divide = value1 / value2;

            else divide = -1; //деление на 0

            multiply = value1 * value2;
        }
    }
}
