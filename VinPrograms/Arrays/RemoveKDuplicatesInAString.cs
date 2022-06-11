using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinPrograms.Arrays
{
    public class RemoveKDuplicatesInAString
    {
		public void RemoveDuplicates()
        {
			//string s = "abcd"; int k = 2; //expected output: "abcd"
			//string s = "deeedbbcccbdaa"; int k = 3; //expected output: "aa"
			string s = "ddaabbaaabcccaee"; int k = 3; //expected output: "ddee"

			Console.WriteLine(RemoveDuplicatesWay1(s, k));
			//Console.WriteLine(RemoveDuplicatesWay2(s,k));
		}

		public string RemoveDuplicatesWay1(string s, int k)
		{
			var stack = new Stack<(char ch, int cnt)>();

			int i = 0;
			while (i < s.Length)
            {
				if (stack.Count == 0 || s[i] != stack.Peek().ch)
				{
					// push pair or tuple
					stack.Push((s[i], 1));
				}
				else
				{
					//stack.Peek().cnt++;// it appears we cannot update stack count here
					// so we will remove and re-add with new count(+1).
					int currentCountOfTheCharacter = stack.Pop().cnt;
					stack.Push((s[i], currentCountOfTheCharacter+1));

					if (stack.Peek().cnt == 3)
						stack.Pop();
				}
				i++;
            }

			StringBuilder sb = new StringBuilder();
			while (stack.Count != 0) ////iterate through each character
			{
				int charCnt = stack.Peek().cnt;
				while (charCnt > 0)//iterate through number of charCnt times for a character
					// this is basically to handle characters that are available with <k times
				{
					sb.Append(stack.Peek().ch);
					charCnt--;
				}
				stack.Pop();
			}

			return new string(sb.ToString().Reverse().ToArray());//reverse, can use better way here
		}

		public string RemoveDuplicatesWay2(string s, int k)
		{
			var stack = new Stack<(char ch, int cnt)>();

			foreach (var c in s.ToCharArray())
			{
				if (stack.Count == 0)
				{
					stack.Push((c, 1));
					continue;
				}

				var peek = stack.Peek();
				if (peek.ch != c)
				{
					stack.Push((c, 1));
					continue;
				}
				stack.Pop();
				if (peek.cnt < k - 1)
				{
					stack.Push((peek.ch, peek.cnt + 1));
				}
			}

			var str = new StringBuilder();
			while (stack.Count > 0)
			{
				var (c, f) = stack.Pop();
				for (var i = 0; i < f; i++)
				{
					str.Append(c);
				}
			}

			return new string(str.ToString().Reverse().ToArray());
		}
	}
}
