using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3
{
    internal class Calculator
    {

        public int Adder(float _a, float _b)
        {
            return (int)(_a + _b);
        }

        public int Minus(float _a, float _b)
        {
            return (int)(_a - _b);
        }

        public int Delenie(float _a, float _b)
        {
            return (int)(float)(_a / _b);
        }

        public int Multiplie(float _a, float _b)
        {
            return (int)(_a * _b);
        }

    }
}
