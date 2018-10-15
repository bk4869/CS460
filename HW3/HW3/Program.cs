using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///CS460 HW#3
///YUMIN CHEN

/// <summary>
/// Original by Sumit Ghosh "An Interesting Method to Generate Binary Numbers from 1 to n"
/// </summary>

///Print the binary representation of all numbers from 1 up to n.
///This is accomplished by using a FIFO queue to perform a level
///order(i.e.BFS) traversal of a virtual binary tree that
///looks like this:
///                 1
///             /       \
///            10       11
///           /  \     /  \
///         100  101  110  111
///          etc.
/// and then storing each "value" in a list as it is "visited".

namespace HW3
{
    class Program
    {
        static LinkedList<string> generateBinaryRepresentationList(int n)
        {
            LinkedQueue<StringBuilder> q = new LinkedQueue<StringBuilder>();

            LinkedList<String> output = new LinkedList<String>();

            if (n < 1)
            {
                return output;
            }

            q.Push(new StringBuilder("1"));

            while (n --> 0)
            {
                StringBuilder sb = q.Pop();
                output.AddLast(sb.ToString());

                StringBuilder sbc = new StringBuilder(sb.ToString());

                sb.Append('0');
                q.Push(sb);

                sbc.Append('1');
                q.Push(sbc);

            }
            return output;
        }


        static void Main(string[] args)
        {
            int n = 10;
            if(args.Length < 1)
            {
                Console.WriteLine("Please invoke with the max value to print binary up to, like this:");
                Console.WriteLine("\tHW3 12");  //Modified as C# style
                return;
            }
            try
            {
                n = int.Parse(args[0]);
            }
            catch
            {
                Console.WriteLine("I'm sorry, I can't understand the number: " + args[0]);
                return;
            }

            LinkedList<string> output = generateBinaryRepresentationList(n);

            int maxLength = output.Last().Length;

            foreach (string s in output)
            {
                for (int i = 0; i < maxLength - s.Length; ++i)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(s);
            }

        }
    }
}
