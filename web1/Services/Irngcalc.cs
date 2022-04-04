using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web1.Services
{
    public interface Irngcalc
    {
        int GetRand();
        int plus(int a, int b);
        int minus(int a, int b);
        int divide(int a, int b);
        int multiply(int a, int b);
        
    }
}
