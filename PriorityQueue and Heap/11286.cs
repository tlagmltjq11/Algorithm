using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class maxHeap
    {
        int[] heap;
        int heap_size;

        public maxHeap(int size)
        {
            heap = new int[size];
            heap_size = 0;
        }

        public void Insert(int data)
        {
            int index = ++(heap_size); //배열의 마지막 인덱스를 기본 위치로 설정

            while (true)
            {
                if (index == 1) //루트라면 중단
                {
                    break;
                }

                if ((Math.Abs(data) < Math.Abs(heap[index / 2]))) //부모노드보다 현재 노드의 절대값이 더 작다면 현재 노드는 상위로 올라가야함.
                {
                    heap[index] = heap[index / 2];
                    index /= 2;
                }
                else if (Math.Abs(data) == Math.Abs(heap[index / 2])) //만약 절대값이 같다면 실제값으로 비교해야한다.
                {
                    if (data < heap[index / 2])
                    {
                        heap[index] = heap[index / 2];
                        index /= 2;
                    }
                    else //실제값이 현재노드가 더 크다면 더이상 올라갈 수 없다.
                    {
                        break;
                    }
                } 
                else //절대값이 현재노드가 더 크다면 더이상 올라갈 수 없다.
                {
                    break;
                }
            }

            heap[index] = data;
        }

        public int Delete()
        {
            if(isEmpty())
            {
                return 0;
            }

            int parent = 1; //말단노드가 루트에서부터 내려오는 과정 중 위치를 기억할 변수
            int child = 2; //비교할 자식은 2번 인덱스 부터 시작이므로 초기화.

            int data, temp;

            data = heap[1]; //루트 노드
            temp = heap[heap_size--]; //말단 노드

            while(child <= heap_size)
            {
                if ((child < heap_size)) //child + 1이 있는 경우만 해야하기 때문에 해당 판단
                {
                    if(Math.Abs(heap[child]) > Math.Abs(heap[child + 1])) //오른쪽 자식의 절대값이 더 작은 경우
                    {
                        child++;
                    }
                    else if(Math.Abs(heap[child]) == Math.Abs(heap[child + 1])) //만약 절대값이 작다면 실제값을 비교
                    {
                        if(heap[child] > heap[child + 1])
                        {
                            child++;
                        }
                    }
                }

                if (Math.Abs(heap[child]) < Math.Abs(temp)) //child의 절대값이 더 작은 경우 temp를 아래로 내려줘야함.
                {
                    //내려와야 할 경우
                    heap[parent] = heap[child]; //자식노드와 위치를 변경
                    parent = child; //현재 내려온 위치로 인덱스를 초기화
                    child *= 2; //내려온 위치에서의 왼쪽 자식노드 인덱스로 초기화
                }
                else if (Math.Abs(heap[child]) == Math.Abs(temp)) //만약 절대값이 같은 경우는 실제 값을 비교해서 실제 값이 더 작은것을 상위에 둬야함.
                {
                    if (temp > heap[child])
                    {
                        //내려와야 할 경우
                        heap[parent] = heap[child]; //자식노드와 위치를 변경
                        parent = child; //현재 내려온 위치로 인덱스를 초기화
                        child *= 2; //내려온 위치에서의 왼쪽 자식노드 인덱스로 초기화
                    }
                    else
                    {
                        break;
                    }
                }
                else //child의 절대값이 더 크다면 temp는 더이상 내려갈 필요가 없기에 break
                {
                    break;
                }
            }

            heap[parent] = temp; //최종적으로 결정된 위치에 temp를 저장해준다.
            return data; //data 반환
        }
 
        public bool isEmpty()
        {
            if (heap_size == 0)
            {
                return true;
            }
            else;
            {
                return false;
            }
        }
    }

    class _11286
    {
        static void Main()
        {
            maxHeap heap = new maxHeap(200000);
            StringBuilder sb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int i=0; i<n; i++)
            {
                int read = int.Parse(Console.ReadLine());

                if(read == 0)
                {
                    sb.AppendLine(heap.Delete().ToString());
                }
                else
                {
                    heap.Insert(read);
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
