using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _1107
    {
        static bool[] buttons;

        static int Check(int n)
        {
            if(n == 0)
            {
                //0번 버튼이 고장난 경우
                if(buttons[0])
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }

            int len = 0;
            //현재 수를 버튼들로 만들 수 있는지 판별.
            while(n > 0)
            {
                //해당 수에 고장난 버튼이 하나라도 존재하는 경우
                if(buttons[n % 10])
                {
                    return 0;
                }

                n /= 10;
                len++; //숫자버튼 누른 횟수 증가
            }

            return len;
        }
        static void Main()
        {
            int target = int.Parse(Console.ReadLine());
            int notWorkingCnt = int.Parse(Console.ReadLine());
            buttons = new bool[10];

            if(notWorkingCnt != 0)
            {
                string[] notWorkingBtns = Console.ReadLine().Split(" ");

                for (int i = 0; i < notWorkingCnt; i++)
                {
                    buttons[int.Parse(notWorkingBtns[i])] = true;
                }
            }

            int min = Math.Abs(target - 100);
            for(int i=0; i<1000000; i++)
            {
                int len = Check(i);
                //현재 i를 숫자버튼으로 만들 수 있는 경우
                if(len > 0)
                {
                    min = Math.Min(min, len + Math.Abs(target - i));
                }
            }

            Console.WriteLine(min);
        }
    }
}
