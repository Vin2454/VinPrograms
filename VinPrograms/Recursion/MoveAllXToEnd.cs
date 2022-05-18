using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class MoveAllXToEnd
    {
        public void MoveAllXToTheEndRec()
        {
            string input = "axbcxxd";
            Console.WriteLine(MoveAllXToEndRec(input,0,string.Empty));
            Console.ReadLine();
        }

        private string MoveAllXToEndRec(string input,int i,string ans)
        {

            return ans;
        }
    }
}
