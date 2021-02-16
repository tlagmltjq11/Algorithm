using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1712
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ");
            int[] ABC = Array.ConvertAll<string, int>(input, s => int.Parse(s));

            if(ABC[1] >= ABC[2])
            {
                Console.WriteLine(-1);
            }
            else
            {
                //손익분기점이 발생하는 경우는 A + BX < CX인 순간임.
                //고로 A/(B-C) < X가 성립되기때문에 판매량은 A/(B-C) + 1이 된다.
                Console.WriteLine(ABC[0] / (ABC[2] - ABC[1]) + 1);
            }
            
        }
    }
}
