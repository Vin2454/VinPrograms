using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    class Basics
    {
        public void StringBasics()
        {
            string input = "abcde";

            // string to char array
            char[] cArr = input.ToCharArray();

            // char array to string
            string inputRefined = new string(cArr);
            
            // iterate in string
            foreach (char item in inputRefined)
            {

            }

            // error for below: this cant be assigned, it's readonly
            //inputRefined[0] = '3';

            // so we need to convert it to char array first, then update character value
            Console.WriteLine(inputRefined);

            // IndexOf(..) different overload methods

            // Substring(int startIndex) ==> start to end
            // Substring(int startIndex,int length) ==> startIndex to specified length 
            // If you want to remove a character or some characters from a string, you can use Substring function

            // Contains
            // ToCharArray()
            // Trim() has multiple overload methods like char, charArray..
            // TrimStart(), TrimEnd() has multiple overload methods like char, charArray..
            // Split(' ')
            // ToUpper(), ToLower()
            // Length
            // StartsWith, EndsWith
            // LastIndexOf
            // ....etc...

            char a = 'a';
            string st = "bc";
            Console.WriteLine(a + st);// output: 

            Console.WriteLine('a' + 'b'); //output:97+98=195
            Console.WriteLine('a' + "b"); //output: ab

            string s1 = "";
            s1 += 'a';
            s1 += 'b';
            Console.WriteLine(s1); // output: ab

            string s = "Stuart";
            string news = PrintstringRef(ref s);
            Console.WriteLine("s:" + s + ";news: " + news);
            // output:s:Little;news: Little
            // if string is not passed by reference, output will be s:Stuart;news: Little
        }
        private static string PrintstringRef(ref string s)
        {
            s = "Little";
            return s;
        }
    }
}
