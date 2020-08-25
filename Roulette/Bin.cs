using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    public class Bin
    {
        
            public string Color { get; set; }
            public string Number { get; set; }
        
            public Bin(string color, string number)
            {
                this.Color = color;
                this.Number = number;
            }

            public override string ToString()
            {
                return Color + Number;
            }

            //https://www.tutorialsteacher.com/csharp/csharp-jagged-array
    }
}
