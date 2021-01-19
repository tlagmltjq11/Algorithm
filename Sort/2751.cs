using System;
using System.Text;

namespace CodingTestPractice
{
    class _2751
    {

		static void quicksort(int[] arr, int low, int high)
		{
			int s;

			if (low < high) //정렬할 범위의 데이터 갯수가 1개 이하 일 경우는 제외.
			{
				s = partition(arr, low, high); //피벗을 기준으로 좌우 분할

				//재귀
				quicksort(arr, low, s - 1); //좌측 퀵소트
				quicksort(arr, s + 1, high); //우측 퀵소트
			}
		}

		static int partition(int[] arr, int low, int high)
		{
			int mid = (low + high) / 2; //중간요소를 피벗으로삼아 최악의 경우를 면하고자함.
			int temp;

			temp = arr[low];
			arr[low] = arr[mid];
			arr[mid] = temp;


			int i = low + 1; //low는 피벗이니까 + 1
			int j = high;

			while (i <= j) //i와 j가 교차하지 않은동안 반복
			{
				if (arr[low] >= arr[i]) //피벗보다 작은동안 i++하면서 진행 -> 만약 피벗보다 큰 값이 나오면 멈춤
				{
					i++;
				}
				else if (arr[low] < arr[j]) //피벗보다 큰동안 j--하면서 진행 -> 만약 피벗보다 작은 값이 나오면 멈춤
				{
					j--;
				}
				else //i,j가 모두 멈춘상태이므로 둘의 값을 스왑해준다.
				{
					temp = arr[i];
					arr[i] = arr[j];
					arr[j] = temp;

					i++; //스왑했으니 다음값부터 비교를위해 한칸씩 전진
					j--;
				}
			}

			//i와 j가 교차했다면 피벗기준 좌우분할이 끝난것이므로 j와 피벗을 스왑해서 자리를 맞춰준다.
			temp = arr[low];
			arr[low] = arr[j];
			arr[j] = temp;


			return j; //피벗위치 리턴
		}

		static void Main()
        {
			StringBuilder sb = new StringBuilder();
			int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            int temp;

            for (int i = 0; i < N; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

			quicksort(nums, 0, N - 1);

			for (int i = 0; i < N; i++)
			{
				sb.AppendLine(Convert.ToString(nums[i]));
			}

			Console.WriteLine(sb);

			/*---------------카운팅소트-----------------
			int[] count = new int[1000001];
			int N = int.Parse(Console.ReadLine());

			for (int i = 0; i < N; i++)
			{
				count[int.Parse(Console.ReadLine())] = 1;
			}

			for(int i=1; i<= 1000000; i++)
            {
				if(count[i] == 1)
                {
					Console.WriteLine(count[i]);
                }
            }
			----------------------------------------------*/
		}
    }
}
