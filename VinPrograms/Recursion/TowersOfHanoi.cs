using System;
using System.Collections.Generic;
using System.Text;

namespace VinPrograms.Recursion
{
    public class TowersOfHanoi
    {
        /// <summary>
        /// https://www.youtube.com/watch?v=u-HgzgYe8KA
        /// Time complexity: O(2^n - 1) ==> O(2^n)
        /// </summary>
        public void TowerOfHanoi()
        {
            while (true)
            {
                Console.WriteLine("Enter number of disks");
                int numberOfDisks = Convert.ToInt32(Console.ReadLine());
                TowerOfHanoRec(numberOfDisks, "Source", "Helper", "Destination");
            }
        }

        private void TowerOfHanoRec(int numberOfDisks, string source, string helper, string destination)
        {
            if(numberOfDisks==1)
            {
                Console.WriteLine($"transfer disk {numberOfDisks} from {source} to {destination}");
                return;
            }
            TowerOfHanoRec(numberOfDisks - 1, source, destination, helper);
            Console.WriteLine($"transfer disk {numberOfDisks} from {source} to {destination}");
            TowerOfHanoRec(numberOfDisks - 1, helper, source, destination);
        }
    }
}
