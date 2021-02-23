using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    /*
    class _2609
    {
        // 최대공약수 (Greatest Common Divisor)
        static int gcd(int x, int y) 
        { 
            // 유클리드 (x를 y로 나눈 나머지가 0보다 클때까지 반복) 
            while(y > 0) 
            { 
                int temp = y;
                y = x % y;
                x = temp; 
            } 

            return x;
        } 
        
        // 최소공배수 (Least Common Multiple) 
        static int lcm(int x, int y) 
        { 
            // 0이 아닌 두 수의 곱 / 두 수의 최대공약수 
            return (x * y) / gcd(x, y); 
        }


        static void Main()
        {
            int x, y;
            string[] read = Console.ReadLine().Split(" ");

            x = int.Parse(read[0]);
            y = int.Parse(read[1]);

            Console.WriteLine(gcd(x, y));
            Console.WriteLine(lcm(x, y));
        }
    }
    */
}
