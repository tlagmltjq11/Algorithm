using System;
using System.Linq;
using System.Text;

namespace CodingTestPractice
{
    class _18870
    {
        // lower_bound 알고리즘
        public static int lower_bound(int target, int[] vdata, int length)
        {
            int left = 0;
            int right = length;

            while (left < right)
            {
                int mid = (left + right) / 2;
                if (vdata[mid] >= target)
                    right = mid;
                else
                    left = mid + 1;
            }
            return right;
        }

        public static void Main(string[] args)
        {
            // 첫번째 값 입력 후 int 로 변환
            string temp = Console.ReadLine();

            // 두번째 줄 값 입력 
            temp = Console.ReadLine();

            string[] arr = temp.Split(' ');

            // 정답 생성을 위한 배열
            int[] arr_int = Array.ConvertAll(arr, Int32.Parse);

            // 정렬 및 중복 제거를 위한 배열
            // 중복 제거
            // 정렬 위해 int 로 변환
            int[] data = Array.ConvertAll(arr.Distinct().ToArray(), Int32.Parse);

            // 정렬
            Array.Sort(data);

            StringBuilder sb = new StringBuilder();

            foreach (int dat in arr_int)
                sb.Append(lower_bound(dat, data, data.Length - 1) + " ");

            Console.WriteLine(sb.ToString());
        }
    }
}
