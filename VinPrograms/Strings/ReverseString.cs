using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class ReverseString
    {
        public void ReverseAString()
        {
            String str = "Geeks for Geeks";
            reverse(str);
        }

        static void reverse(String str)
        {
            if ((str == null) || (str.Length <= 1))
                Console.Write(str);

            else
            {
                Console.Write(str[str.Length - 1]);
                reverse(str.Substring(0, (str.Length - 1)));
            }
        }
    }
}
