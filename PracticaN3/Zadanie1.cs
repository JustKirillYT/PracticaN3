using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3
{
    internal class Zadanie1
    {

        public bool Chetnost(double chislo)
        {
            var res = chislo % 2;
            if (res == 0)
            {
                return true;

            }
            else { return false; }
        }

    }
}
