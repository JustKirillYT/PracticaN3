using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN3
{
    public class Chetchik
    {
        public static int SchitatSlova(string stroka)
        {
            if (string.IsNullOrWhiteSpace(stroka))
                return 0;

            var slova = stroka.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return slova.Length;
        }
    }

}
