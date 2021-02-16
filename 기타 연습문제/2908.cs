using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2908
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            //스트링을 reverse하는 방식 중 하나
            char[] max = input[0].ToCharArray();
            Array.Reverse(max);

            for(int i=1; i<input.Length; i++)
            {
                char[] temp = input[i].ToCharArray();
                Array.Reverse(temp);
                
                //char array를 string화 시키는 방법 중 하나
                if(int.Parse(new string(max)) < int.Parse(new string(temp)))
                {
                    max = temp;
                }
            }

            Console.WriteLine(int.Parse(new string(max)));
        }
    }
}
