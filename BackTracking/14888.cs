using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _14888
    {
        static int N, max = -1000000000, min = 1000000000;
        static int[] nums;
        static int[] opers;

        static void BackTrack(int cnt, int result)
        {
            //모든 연산자를 골랐다면, max, min과 비교
            if(cnt == N-1)
            {
                if(result > max)
                {
                    max = result;
                }

                if(result < min)
                {
                    min = result;
                }

                return;
            }
            else
            {
                for(int i=0; i<opers.Length; i++)
                {
                    //연산자를 고를 수 있는 경우
                    if(opers[i] > 0)
                    {
                        //해당 연산자를 고른다.
                        opers[i]--;

                        //이전 값을 저장해둠.
                        int prev = result;

                        //i값 -> + - x %
                        switch (i)
                        {
                            //+
                            case 0:
                                //선택한 연산대로 다음 수와 연산한다.
                                result = result + nums[cnt + 1];
                                break;

                            //-
                            case 1:
                                //선택한 연산대로 다음 수와 연산한다.
                                result = result - nums[cnt + 1];
                                break;

                            //x
                            case 2:
                                //선택한 연산대로 다음 수와 연산한다.
                                result = result * nums[cnt + 1];
                                break;

                            //%
                            case 3:
                                //선택한 연산대로 다음 수와 연산한다.
                                result = result / nums[cnt + 1];
                                break;
                        }

                        //다음 depth로 넘어가며 연산한값을 넘겨준다.
                        BackTrack(cnt + 1, result);
                        //되돌아올때 초기화
                        result = prev;
                        //되돌아올때 초기화
                        opers[i]++;
                    }
                }
            }
        }

        static void Main()
        {
            //숫자갯수
            N = int.Parse(Console.ReadLine());

            //숫자입력
            string[] read = Console.ReadLine().Split(" ");
            nums = Array.ConvertAll(read, s => int.Parse(s));

            //연산자입력 + - x %
            read = Console.ReadLine().Split(" ");
            opers = Array.ConvertAll(read, s => int.Parse(s));

            
            //백트래킹
            BackTrack(0, nums[0]);


            //정답 출력
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
