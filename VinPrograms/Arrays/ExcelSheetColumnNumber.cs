using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    public class ExcelSheetColumnNumber
    {
        public void ExcelSheetColumnTitleNumber()
        {
            //string columnTitle = "A"; //expected output: 1
            //string columnTitle = "AB"; //expected output: 28
            string columnTitle = "ZY"; //expected output: 701

            int ans = 0;
            int pow = 1;
            int n = columnTitle.Length;

            int i = n - 1;
            while (i >= 0)
            {
                if (i < n - 1)
                    pow = pow * 26;
                ans = ans + GetCharValue(columnTitle[i]) * pow;
                i--;
            }
            Console.WriteLine(ans);
        }

        private int GetCharValue(char c)
        {
            return (int)(c - 'A') + 1;
        }
    }
}
