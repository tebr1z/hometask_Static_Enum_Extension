using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_Static_Enum_Extension
{

    public static class Factoriall
    {
        public static int? Factorial(this int number)
        {
            if (number < 0)
                return null;

            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }
    }


}