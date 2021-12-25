using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Strings
{
    public class StringAnagramsCheck
    {
        /// <summary>
        /// Sort both strings, Compare the sorted strings
        /// Time Complexity: O(nlogn)
        /// </summary>
        public void CheckStringAnagrams_WithSorting()
        {
            //string str1 = "listen";
            //string str2 = "silent";

            string str1 = "triangle";
            string str2 = "integral";

            int n1 = str1.Length;
            int n2 = str2.Length;

            if (n1 != n2)
            {
                Console.WriteLine(false);
                return;
            }

            List<char> list1 = new List<char>(str1);
            List<char> list2 = new List<char>(str2);

            list1.Sort();
            list2.Sort();

            int i = 0;
            while (i < n1)
            {
                if (list1[i] != list2[i])
                {
                    Console.WriteLine(false);
                    return;
                }
                i++;
            }
            Console.WriteLine(true);
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        public void CheckStringAnagrams_UsingTwoArrayCountCharacters()
        {
            //string str1 = "listen";
            //string str2 = "silent";

            string str1 = "triangle";
            string str2 = "integral";

            int n1 = str1.Length;
            int n2 = str2.Length;

            if (n1 != n2)
            {
                Console.WriteLine(false);
                return;
            }

            int[] arr1 = new int[256];
            int[] arr2 = new int[256];
            //here these arrays will be intialized with all 0s and 
            // index of these arrays are ASCII codes of characters.

            int i = 0;
            while (i < str1.Length)
            {
                arr1[str1[i]]++;
                arr2[str2[i]]++;

                i++;
            }

            int j = 0;
            while (j < 256)
            {
                if (arr1[j] != arr2[j])
                {
                    Console.WriteLine(false);
                    return;
                }
                j++;
            }
            Console.WriteLine(true);
        }

        /// <summary>
        /// Time Complexity: O(n)
        /// </summary>
        public void CheckStringAnagrams_UsingOneArrayCountCharacters()
        {
            string str1 = "listen";
            string str2 = "silent";

            //string str1 = "triangle";
            //string str2 = "integral";

            int n1 = str1.Length;
            int n2 = str2.Length;

            if (n1 != n2)
            {
                Console.WriteLine(false);
                return;
            }

            int[] arr = new int[256];
            //here these arrays will be intialized with all 0s and 
            // index of these arrays are ASCII codes of characters.

            int i = 0;
            while (i < str1.Length)
            {
                arr[str1[i]]++;
                arr[str2[i]]--;

                //arr[str1[i]-'a']++; 
                // It will make values from 0 to 255. e.g: character 'a' value it will set to 0 instead of 97
                //arr[str2[i]-'a']--;

                i++;
            }

            int j = 0;
            while (j < 256)
            {
                if (arr[j] != 0)
                {
                    Console.WriteLine(false);
                    return;
                }
                j++;
            }
            Console.WriteLine(true);
        }

        public void CheckStringAnagrams_WithSorting_WithDictionary_Method1()
        {
            //string str1 = "listen";
            //string str2 = "silent";

            string str1 = "triangle";
            string str2 = "integral";

            Dictionary<char, int> dic = new Dictionary<char, int>();
            int i = 0;
            while (i < str1.Length)
            {
                if (dic.ContainsKey(str1[i]))
                    dic[str1[i]]++;
                else
                    dic.Add(str1[i], 1);

                i++;
            }

            int j = 0;
            while (j < str2.Length)
            {
                if (dic.ContainsKey(str2[j]))
                {
                    dic[str2[j]]--;
                    if (dic[str2[j]] == 0)
                        dic.Remove(str2[j]);
                }
                else
                {
                    Console.WriteLine(false);
                    return;
                }
                j++;
            }

            if (dic.Count == 0)
            {
                Console.WriteLine(true);
                return;
            }
        }
    }
}
