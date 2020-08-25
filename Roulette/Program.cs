using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Roulette
{

    class Program
    {
        static void Main(string[] args)
        {
            //Using jagged array with 3 single-dimensional arrays and sizing them
            Bin[][] Bins = new Bin[3][];
            /*redBins*/
            Bin[] redBins = new Bin[38];
            /*blackBins*/
            Bin[] blackBins = new Bin[38];
            /*greenBins*/
            Bin[] greenBins = new Bin[2];

            Bins[0] = redBins;
            Bins[1] = blackBins;
            Bins[2] = greenBins;

            //assigning values to those three arrays
            for (int i = 2; i < Bins[0].Length - 1; i += 2)
            {
                Bins[0][i] = new Bin("R ", i.ToString());
                redBins[i] = Bins[0][i];
            }

            for (int i = 1; i < Bins[1].Length - 1; i += 2)
            {
                Bins[1][i] = new Bin("B ", i.ToString());
                blackBins[i] = Bins[1][i];
            }

            Bins[2][0] = new Bin("G ", "0");
            greenBins[0] = Bins[2][0];
            Bins[2][1] = new Bin("G ", "00");
            greenBins[1] = Bins[2][1];

            Wheel w = new Wheel();
            string winner = w.Spin();

            if (winner.StartsWith("R"))
            {
                for (int i = 0; i < redBins.Length; i++)
                {
                    if (redBins[i] != null)
                    {
                        if (redBins[i].ToString() == winner)
                        {
                            Console.WriteLine(winner);
                            Bets b = new Bets();
                            b.Betting(winner);
                            break;
                        }
                    }
                }
            }
           else if (winner.StartsWith("G"))
            {
                for (int i = 0; i < greenBins.Length; i++)
                {
                    if (greenBins[i].ToString() == winner)
                    {
                        Console.WriteLine(winner);
                        Bets b = new Bets();
                        b.Betting(winner);
                        break;
                    }
                }
            }
            else if (winner.StartsWith("B"))
            {
                for (int i = 0; i < blackBins.Length; i++)
                {
                    if (blackBins[i] != null)
                    {
                        if (blackBins[i].ToString() == winner)
                        {
                            Console.WriteLine(winner);
                            Bets b = new Bets();
                            b.Betting(winner);
                            break;
                        }
                    }
                }

            }
        }
    }
}
        //for (int i = 0; i < Bins.Length; i++)
            //{
            //    for (int j = 0; j < Bins[i].Length; j++)
            //    {

            //        if (Bins[i][j] != null)
            //        {
            //            if (firstPart == i.ToString())
            //            {
            //                Console.WriteLine(firstPart);
            //                /*Console.WriteLine($"Bin: " + Bins[i][j])*/;
            //            }
            //        }
            //    }
            //}



            //if (Bins[i][j] != null)
            //{
            //    if (Bins[i][j].ToString() == winner)
            //    {
            //        Console.WriteLine("Winner winner: " + Bins[i][j]);
            //    }
            //}

            //Test purposes making sure I can iterate through every element in my jagged array with one nested for loop
            //display all elements of the array
            //for (int i = 0; i < Bins.Length; i++)
            //{
            //    for (int j = 0; j < Bins[i].Length; j++)
            //    {
            //        if (Bins[i][j] != null)
            //        {
            //            Console.WriteLine($"Bin: " + Bins[i][j]);
            //        }
            //    }
            //}

            //for test purposes outputting the values of the arrays
            //for (int j = 0; j < redBins.Length; j++)
            //    {
            //        if (redBins[j] != null)
            //        {
            //            Console.WriteLine("Red Bin: " + redBins[j]);
            //        }
            //    }
            //for (int j = 0; j < blackBins.Length - 1; j++)
            //{
            //    if (blackBins[j] != null)
            //    {
            //        Console.WriteLine("Black Bin: " + blackBins[j]);
            //    }

//https://stackoverflow.com/questions/1235477/how-to-create-multiple-objects-and-enumerate-them-in-c-sharp