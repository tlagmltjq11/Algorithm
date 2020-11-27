using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1316
    {
        static void Main(string[] args)
        {
            int[] alphabet = new int[26];

            int row = int.Parse(Console.ReadLine());
            string[] words = new string[row];
            int cnt = 0;

            for(int i=0; i<row; i++)
            {
                words[i] = Console.ReadLine();
                char temp = words[i][0];
                bool check = true;

                for(int j=1; j<words[i].Length; j++)
                {
                    if(temp != words[i][j])
                    {
                        alphabet[Convert.ToInt32(temp) - 97] = 1;

                        if (alphabet[Convert.ToInt32(words[i][j] - 97)] == 1)
                        {
                            check = false;
                            break;
                        }
                        else
                        {
                            temp = words[i][j];
                        }
                    }
                }

                if(check)
                {
                    cnt++;
                }

                check = true;
                //배열을 디폴트값으로 초기화하는 방법!
                Array.Clear(alphabet, 0, alphabet.Length);
            }

            Console.WriteLine(cnt);
        }
    }
}
