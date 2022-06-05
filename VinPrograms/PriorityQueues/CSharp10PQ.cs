using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.PriorityQueues
{
    public class CSharp10PQ
    {
        public void UnderstandPriorityQueue()
        {
            int a = 4, b = 5, c = 1;

            //PriorityQueue<char, int> pq = new PriorityQueue<char, int>();//default is like: Comparer<int>.Create((a, b) => a.CompareTo(b))
            // the above stores priority in ascending order

            //PriorityQueue<char, int> pq = new PriorityQueue<char, int>(Comparer<int>.Create((a, b) => b.CompareTo(a)));
            // the above stores priority in descending order
            
            PriorityQueue<char, int> pq = new PriorityQueue<char, int>(new MyComparer());
            pq.Enqueue('a', a);
            pq.Enqueue('b', b);
            pq.Enqueue('c', c);

            while (pq.Count != 0)
            {
                pq.TryDequeue(out char element, out int priority);
                Console.WriteLine($"element:{element}; priority:{priority}");
            }
        }
    }

    public class MyComparer : IComparer<int>
    {
        ///// below for priority ascending order
        //public int Compare(int x, int y)
        //{
        //    if (x == y) return 0;
        //    else if (x > y) return 1;
        //    else return -1;
        //}

        /// below for priority descending order
        public int Compare(int x, int y)
        {
            if (x == y) return 0;
            else if (x > y) return -1;
            else return 1;
        }
    }
}
