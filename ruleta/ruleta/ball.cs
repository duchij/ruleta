using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    class ball
    {

        public ball()
        {
            
        }

        public static int runBall()
        {
            Random rnd = new Random();

            return rnd.Next(0, 36);
            //return 15;
        }

        



    }
}
