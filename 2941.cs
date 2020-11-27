using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2941
    {
        static void Main(string[] args)
        {
            string[] croatia = { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
            string input = Console.ReadLine();

            for(int i=0; i<croatia.Length; i++)
            {
                //Replace를 쓰면 쉽다는걸 알았지만, 어떤식으로 응용해야할지 고민했는데
                //생각해보니 결국 한글자로 치환해주면 카운팅이 손쉽게 해결되는 문제.
                input = input.Replace(croatia[i], "C");
            }

            Console.WriteLine(input.Length);
        }
    }
}
