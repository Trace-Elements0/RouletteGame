using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Roulette
{
    class Bin
    {
        private string color { get; set; }
        private string number { get; set; }

        public Bin()
        {

        }
        public Bin(string v, string i)
        {
            this.color = v;
            this.number = i;
        }

        public override string ToString()
        {
            return "Bin: " + color + " " + number;
        }

        List<Bin> bins = new List<Bin>();                                                               //create a collection for bins aka bin objects

        private List<Bin> WheelBins()
        {
            for (int i = 1; i < 37; i++)                                                                //loop 36 times
            {
                bool[] conditions =
                {
                    (i > 0) && (i < 11) && Even(i),
                    (i > 10) && (i < 19) && !Even(i),
                    (i > 18) && (i < 29) && Even(i),
                    (i > 28) && (i < 37) && !Even(i),
                };

                if (conditions[0] || conditions[1] || conditions[2] || conditions[3])                  //Filter and find the black bins
                {
                    Bin bin = new Bin("Black ", i.ToString());
                    bins.Add(bin);
                }
                else                                                                                  //If they aren't black they're red
                {
                    Bin bin = new Bin("Red ", i.ToString());
                    bins.Add(bin);
                }
            }
            bins.Add(new Bin("Green: ", "0"));                                                 //Two green bins
            bins.Add(new Bin("Green: ", "00"));

            bool Even(int num)                                                                         //helper method checking for even numbers
            {
                int i = num %= 2;
                if (i % 2 == 0)
                {
                    return true;
                }
                return false;
            }
            return bins;
        }
    }
}
