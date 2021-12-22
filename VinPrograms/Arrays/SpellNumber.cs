using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Arrays
{
    public class SpellNumber
    {
        public void SpellANumberUsingRecursion()
        {
            int n = 435;
            //expected: Four Three Five

            SpellRec(n);
        }

        private void SpellRec(int n)
        {
            if (n == 0)
                return;
            int rem = n % 10;
            n = n / 10;

            SpellRec(n);
            Console.Write(Spell(rem) + " ");
        }

        private string Spell(int n)
        {
            string result;
            switch (n)
            {
                case 0:
                    result = "Zero";
                    break;
                case 1:
                    result = "One";
                    break;
                case 2:
                    result = "Two";
                    break;
                case 3:
                    result = "Three";
                    break;
                case 4:
                    result = "Four";
                    break;
                case 5:
                    result = "Five";
                    break;
                case 6:
                    result = "Six";
                    break;
                case 7:
                    result = "Seven";
                    break;
                case 8:
                    result = "Eight";
                    break;
                case 9:
                    result = "Nine";
                    break;
                default:
                    result = string.Empty;
                    break;
            }
            return result;
        }
    }
}
