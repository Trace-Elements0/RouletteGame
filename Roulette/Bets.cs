using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;

namespace Roulette
{
    class Bets
    {
        public void Betting(string x)
        {
            string[] y = x.Split(' ');
            int num = int.Parse(y[1]);

            //Red or Black bet
            switch (y[0])
            {
                case "R":
                    Console.Write("Winning bets: Red, ");
                    break;
                case "B":
                    Console.Write("Winning bets: Black, ");
                    break;
                case "G":
                    Console.Write("Winning bets: ");
                    break;
            }

            //Evens or Odds bet
            switch (num % 2)
            {
                case 0:
                    Console.Write("Evens, ");
                    break;
                case 1:
                    Console.Write("Odds, ");
                    break;
            }

            //Lows or Highs
            if (num >= 1 && num <= 18)
            {
                Console.Write("Lows, ");

            }
            else if (num >= 19 && num <= 38)
            {
                Console.Write("Highs, ");
            }

            //Dozens
            //https://stackoverflow.com/questions/3188672/how-to-elegantly-check-if-a-number-is-within-a-range
            bool TestRange(int numberToCheck, int bottom, int top)
            {
                return (numberToCheck >= bottom && numberToCheck <= top);
            }

            if (TestRange(num, 1, 12))
            {
                Console.Write("First thirds, ");
            }
            else if (TestRange(num, 13, 24))
            {
                Console.Write("Second thirds, ");
            }
            else if (TestRange(num, 25, 36))
            {
                Console.Write("Third thirds, ");
            }

            //Columns
            var fC = new List<int>() {3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36};
            var sC = new List<int>() {2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35};
            var tC = new List<int>() {1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34};

            if (fC.Contains(num))
            {
                Console.Write("First column, ");
            }
            else if (sC.Contains(num))
            {
                Console.Write("Second column, ");
            }
            else if (tC.Contains(num))
            {
                Console.Write("Third column, ");
            }

            //streets
            var one = new List<int>() {1, 2, 3};
            var two = new List<int>() {4, 5, 6};
            var thr = new List<int>() {7, 8, 9};
            var fou = new List<int>() {10, 11, 12};
            var fiv = new List<int>() {13, 14, 15};
            var six = new List<int>() {16, 17, 18};
            var sev = new List<int>() {19, 20, 21};
            var eig = new List<int>() {22, 23, 24};
            var nin = new List<int>() {25, 26, 27};
            var ten = new List<int>() {28, 29, 30};
            var ele = new List<int>() {31, 32, 33};
            var twe = new List<int>() {34, 35, 36};

            if (one.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("First street bet, " + one[index] + " ");
                }
            }
            else if (two.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Second street bet " + two[index] + " ");
                }
            }
            else if (thr.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Third street bet " + thr[index] + " ");
                }
            }
            else if (fou.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Fourth street bet" + fou[index] + " ");
                }
            }
            else if (fiv.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Fifth street bet " + fiv[index] + " ");
                }
            }
            else if (six.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Sixth street bet " + six[index] + " ");
                }
            }
            else if (sev.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Seventh street bet " + sev[index] + " ");
                }
            }
            else if (eig.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Eighth street bet " + eig[index] + " ");
                }
            }
            else if (nin.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Ninth street bet " + nin[index] + " ");
                }
            }
            else if (ten.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Tenth street bet " + ten[index] + " ");
                }
            }
            else if (ele.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Eleventh street bet " + ele[index] + " ");
                }
            }
            else if (twe.Contains(num))
            {
                for (var index = 0; index < twe.Count; index++)
                {
                    Console.Write("Twelvth street bet " + twe[index] + " ");
                }
            }

            //Split
            string spl = "";
            switch (num)
            {
                case 1:
                    spl += "2,4";
                    break;
                case 2:
                    spl += "1,3,5";
                    break;
                case 3:
                    spl += "2,6";
                    break;
                case 4:
                    spl += "5,1,7";
                    break;
                case 5:
                    spl += " 4,2,6,8";
                    break;
                case 6:
                    spl += "3,5,9";
                    break;
                case 7:
                    spl += "4,8,10";
                    break;
                case 8:
                    spl += "5,7,9,11";
                    break;
                case 9:
                    spl += "6,8,12";
                    break;
                case 10:
                    spl += "7,11,13";
                    break;
                case 11:
                    spl += "8,10,14,12";
                    break;
                case 12:
                    spl += "9,11,15";
                    break;
                case 13:
                    spl += "10,14,15";
                    break;
                case 14:
                    spl += "11,13,15,17 ";
                    break;
                case 15:
                    spl += "12,14,18";
                    break;
                case 16:
                    spl += "13,17,19";
                    break;
                case 17:
                    spl += "14,16,18,20";
                    break;
                case 18:
                    spl += "15,17,21";
                    break;
                case 19:
                    spl += "16,20,22";
                    break;
                case 20:
                    spl += "17,19,21,23";
                    break;
                case 21:
                    spl += "18,20,24";
                    break;
                case 22:
                    spl += "19,23,25";
                    break;
                case 23:
                    spl += "20,22,24,26";
                    break;
                case 24:
                    spl += "21,23,27";
                    break;
                case 25:
                    spl += "22,26,28";
                    break;
                case 26:
                    spl += "2325,27,29";
                    break;
                case 27:
                    spl += "24,26,30";
                    break;
                case 28:
                    spl += "25,29,31";
                    break;
                case 29:
                    spl += "26,28,30,32";
                    break;
                case 30:
                    spl += "27,29,33";
                    break;
                case 31:
                    spl += "28,32,34";
                    break;
                case 32:
                    spl += "29,31,33,35";
                    break;
                case 33:
                    spl += "30,32,36";
                    break;
                case 34:
                    spl += "31,35";
                    break;
                case 35:
                    spl += "32,34,36";
                    break;
                case 36:
                    spl += "33,36";
                    break;
            }

            string[] ruSplit = spl.Split(",");
            Console.Write("Split Bets:");
            foreach (string i in ruSplit)
                Console.Write("{0}/{1} ", num, i);

            //corner
            string crn = "";
            switch (num)
            {
                case 1:
                    crn += "2/3/4";
                    break;
                case 2:
                    crn += "1/4/5, 3/5/6";
                    break;
                case 3:
                    crn += "2/5/6";
                    break;
                case 4:
                    crn += "1/2/5, 5/7/8";
                    break;
                case 5:
                    crn += "1/2/4, 2/3/6, 6/8/9, 4/7/8";
                    break;
                case 6:
                    crn += "5/8/12, 2/3/5";
                    break;
                case 7:
                    crn += "4/5/8, 8/10/11";
                    break;
                case 8:
                    crn += "4/5/7, 5/6/9, 9/11/12, 7/10/11";
                    break;
                case 9:
                    crn += "5/6/8, 8/11/12";
                    break;
                case 10:
                    crn += "7/8/11, 11/13/14";
                    break;
                case 11:
                    crn += "7/8/10, 8/9/12, 12/14/15, 10/13/14";
                    break;
                case 12:
                    crn += "8/9/11, 11/14/15";
                    break;
                case 13:
                    crn += "10/11/14, 14/16/17";
                    break;
                case 14:
                    crn += "10/11/13, 11/12/15, 13/16/17, 15/17/18";
                    break;
                case 15:
                    crn += "11/12/14, 14/17/18";
                    break;
                case 16:
                    crn += "13/14/17, 17/19/20";
                    break;
                case 17:
                    crn += "13/14/16, 1415/18, 16/19/20, 18/20/21";
                    break;
                case 18:
                    crn += "14/15/17, 17/20/21";
                    break;
                case 19:
                    crn += "16/17/20, 20/22/23";
                    break;
                case 20:
                    crn += "16/17/19, 19/22/23, 21/23/24";
                    break;
                case 21:
                    crn += "17/18/20, 20/23/24";
                    break;
                case 22:
                    crn += "19/20/23, 23/25/26";
                    break;
                case 23:
                    crn += "19/20/22, 20/21/24, 22/25/26, 24/26/27";
                    break;
                case 24:
                    crn += "20/21/23, 23/26/27";
                    break;
                case 25:
                    crn += "22/23/26, 26/28/29";
                    break;
                case 26:
                    crn += "22/23/25, 23/24/27, 25/28/29, 27/29/30";
                    break;
                case 27:
                    crn += "23/24/26/27, 26/29/30";
                    break;
                case 28:
                    crn += "25/26/29, 29/31/32";
                    break;
                case 29:
                    crn += "25/26/28, 26/27/30, 28/31/32, 30/32/33";
                    break;
                case 30:
                    crn += "26/27/29, 29/32/33";
                    break;
                case 31:
                    crn += "28/29/32, 32/34/35";
                    break;
                case 32:
                    crn += "28/29/31, 29/30/33, 33/35/36, 31/34/35";
                    break;
                case 33:
                    crn += "29/30/32, 32/35/36";
                    break;
                case 34:
                    crn += "31/32/35";
                    break;
                case 35:
                    crn += "31/32/34, 32/33/36";
                    break;
                case 36:
                    crn += "32/33/35";
                    break;
            }

            Console.Write("Corner bets could be: {0}/{1}.", num, crn);


        }
    }
}
