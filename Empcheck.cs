using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empwage257
{
    public class Empcheck
    {
        public static void CheckEmployee()
        {
            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int emprateperhr = 20;

            int emphrs = 0;
            int empwage = 0;
            Random random = new Random() ;
            int empcheck = random.Next (3);
            if(empcheck ==IS_FULL_TIME )
            {
                emphrs =8;
            }
            else if(empcheck==IS_PART_TIME )
            {
               emphrs=4;
            }
            else
            {
                emphrs = 0;
            }
            empwage = emphrs * emprateperhr;
            Console.WriteLine("Empwage : " + empwage);

        }

    }
}
