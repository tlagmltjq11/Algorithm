using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1157
    {
        static void Main(string[] args)
        {
            int[] alphabet = new int[26];
            string s = Console.ReadLine().ToUpper();

            for(int i=0; i<s.Length; i++)
            {
                alphabet[Convert.ToInt32(s[i]) - 65]++;
            }

            bool temp = false;
            int index = 0;
            int max = alphabet[0];

            for(int i=1; i<alphabet.Length; i++)
            {
                if(max == alphabet[i])
                {
                    temp = true;
                }
                else if(max < alphabet[i])
                {
                    max = alphabet[i];
                    index = i;
                    temp = false;
                }
            }

            if(temp)
            {
                Console.WriteLine("?");
            }
            else
            {
                Console.WriteLine(Convert.ToChar('A' + index));
            }
        }
    }
}
