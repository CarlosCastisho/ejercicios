using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejer1
{
    internal class num_arr
    {
        public static int num_falta(int[] num)
        {
            if (num.Length < 2)
            {
                return num[0];
            }

            int num_ini = num[0];

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != num_ini)
                {
                    return num_ini;
                }

                num_ini ++;
            }

            return num_ini;

        }
    }
}
