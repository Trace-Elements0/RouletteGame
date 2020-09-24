using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Roulette
{
    class Wheel
    {
        internal int Spin()
        {
            Random r = new Random();
            return r.Next(0, 39);
        }
    }
}