using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1541
    {
        static void Main()
        {
            string read = Console.ReadLine();
            string[] minus = read.Split('-'); //마이너스 기준으로 스플릿
            int[] results = new int[minus.Length]; //스플릿된 수 만큼 배열 생성

            for(int i=0; i<minus.Length; i++)
            {
                string[] plus = minus[i].Split('+');
                int result = 0;

                if (plus.Length > 1)
                {
                    for(int j=0; j<plus.Length; j++)
                    {
                        result += int.Parse(plus[j]);
                    }
                }
                else
                {
                    result = int.Parse(plus[0]);
                }

                results[i] = result;
            }

            int min = results[0];
            for(int i=1; i<results.Length; i++)
            {
                min -= results[i];
            }

            Console.WriteLine(min);
        }
    }
}
