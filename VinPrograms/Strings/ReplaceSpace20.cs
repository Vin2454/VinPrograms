using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class ReplaceSpace20
    {
        /// <summary>
        /// Replace all the spaces in a given string with '%20'
        /// </summary>
        public void Space20_WithExistingFunction()
        {
            string input = "Hellow world, how are you?";
            input = input.Trim().Replace(" ", "%20"); // here ' ', '%20' will not work
            Console.WriteLine(input);
        }

        public void Space20_Notworking()
        {
            string input = "Hellow world, how are you?";

            //// try 1
            //char[] cArr = new char[input.Length];
            //int i = 0;
            //while (true)
            //{
            //    i=input.IndexOf(" ", i);
            //    cArr[i] = "%20";// THIS WILL GIVE COMPILE ERROR, as string cannot be casted to char
            //    i = i + "%20".Length;
            //}

            //// try 2
            //int i = 0;
            //while (true)
            //{
            //    i = input.IndexOf(" ", i);
            //    if (i == -1)
            //        break;
            //    input=input.Insert(i, "%20"); 
            //    //1) HERE, WE MUST USE input=input.Insert(..) as Insert method returns string
            //    //2) IT WILL INSERT %20 AT THE SPACE POSITION, BUT SPACE WILL ALSO BE MOVED TO RIGHT AND THIS LOOP WILL NOT HAVE EXIT
            //    i = i + "%20".Length;
            //}

            //Console.WriteLine(input);
        }

        /// <summary>
        /// Replace all the spaces in a given string with '%20'
        /// </summary>
        public void Space20_Working()
        {
            string input = "Hellow world, how are you?";

            int spacesCount = 0;
            int i = 0;
            while (i < input.Length)
            {
                if (input[i] == ' ')
                    spacesCount++;
                i++;
            }
            // Find new length.
            int newlength = input.Length + spacesCount * 2; //space(1 char) needs to be replaced with %20(3 chars), hence multiplying with 2 (3-1)

            // Start filling character from end
            char[] cArrNew = new char[newlength];
            int index = newlength - 1;

            char[] cArrOld = input.ToCharArray();
            int j = input.Length - 1;
            while (j >= 0)
            {
                // inserts %20 in place of space
                if (cArrOld[j] == ' ')
                {
                    cArrNew[index] = '0';
                    cArrNew[index - 1] = '2';
                    cArrNew[index - 2] = '%';
                    index = index - 3;
                }
                else
                {
                    cArrNew[index] = input[j];
                    index--;
                }

                j--;
            }
            Console.WriteLine(new String(cArrNew));
        }
    }
}
