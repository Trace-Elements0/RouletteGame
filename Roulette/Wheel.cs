using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Roulette
{
    class Wheel
    {
        public string Spin()
        {
            Random r = new Random();

            string y1 = "";


            int y = r.Next(0, 3);
            switch (y)
            {
                case 0:
                    y1 += "R ";
                    break;
                case 1:
                    y1 += "B ";
                    break;
                case 2:
                    y1 += "G ";
                    break;
                default:
                    Console.WriteLine("Def");
                    break;
            }

            switch (y1)
            {
                case "R ":
                {
                    int min = 0;
                    int max = 37;
                    double rand;
                    rand = (2 * r.Next(min / 2, max / 2));
                    y1 += rand.ToString();
                    break;
                }
                case "B ":
                {
                    int min = 0;
                    int max = 37;
                    int rand;
                    rand = (2 * r.Next(min / 2, max / 2)) + 1;
                    y1 += rand.ToString();
                    break;
                }
                case "G ":
                {
                    int s = r.Next(0, 2);
                    if (s == 0)
                    {
                        y1 += "0";
                    }
                    else
                        y1 += "00";
                    break;
                }
            }

            return y1;
        }
    }
}

//if (Bins[i][j] != null)
//{
//Console.WriteLine($"Bin: " + Bins[i][j]);
//}