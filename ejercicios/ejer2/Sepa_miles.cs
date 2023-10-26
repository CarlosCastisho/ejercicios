using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer2
{
    internal class Sepa_miles
    {
        public static string SeparaMiles(int num)
        {
            string conv_num = num.ToString();
            string cadena_coma = "";

            if (num < 0)
            {
                return num.ToString();
            }
            else
            {

                for (int i = 0; i < conv_num.Length - 1; i++)
                {
                    if (conv_num[i]>= '0' && conv_num[i] <= '9')
                    {
                        cadena_coma += conv_num[i];
                    }
                    else if (i % 3 == 2)
                    {
                        cadena_coma += ".";
                    }
                }
            }

            return cadena_coma;
        }
    }
}
