using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _11866
    {
        static void Main()
        {
            string[] read = Console.ReadLine().Split(" ");
            int n = int.Parse(read[0]);
            int k = int.Parse(read[1]);

            StringBuilder sb = new StringBuilder();
            Queue<int> q = new Queue<int>();

            for(int i=1; i<=n; i++)
            {
                q.Enqueue(i);
            }

            sb.Append("<");

            while(q.Count > 1)
            {
                for(int i=0; i<k-1; i++)
                {
                    q.Enqueue(q.Dequeue());
                }

                sb.Append(q.Dequeue().ToString() + ", ");
            }

            sb.Append(q.Dequeue().ToString() + ">");

            Console.WriteLine(sb.ToString());
        }
    }
    */
}
