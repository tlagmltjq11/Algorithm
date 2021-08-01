using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 이중우선순위큐
    {
        class DoublyPriorityQueue
        {
            int[] minHeap;
            int[] maxHeap;

            public int minSize, maxSize;

            public DoublyPriorityQueue(int size)
            {
                minHeap = new int[size];
                maxHeap = new int[size];
                minSize = 0;
                maxSize = 0;
            }

            public void InsertMin(int data)
            {
                int index = ++(minSize); //배열의 마지막 인덱스를 기본 위치로 설정

                //만약 부모노드의 값보다 삽입될 값이 크고, 위치가 최상위가 아니라면 계속해서 트리를 타고 올라간다.
                while ((index != 1) && (data < minHeap[index / 2]))
                {
                    minHeap[index] = minHeap[index / 2];
                    index /= 2;
                }

                minHeap[index] = data;
            }

            public void InsertMax(int data)
            {
                int index = ++(maxSize); //배열의 마지막 인덱스를 기본 위치로 설정

                //만약 부모노드의 값보다 삽입될 값이 크고, 위치가 최상위가 아니라면 계속해서 트리를 타고 올라간다.
                while ((index != 1) && (data > maxHeap[index / 2]))
                {
                    maxHeap[index] = maxHeap[index / 2];
                    index /= 2;
                }

                maxHeap[index] = data;
            }

            public int DeleteMin()
            {
                if (isEmptyMin())
                {
                    return 0;
                }

                int parent = 1; //말단노드가 루트에서부터 내려오는 과정 중 위치를 기억할 변수
                int child = 2; //비교할 자식은 2번 인덱스 부터 시작이므로 초기화.

                int data, temp;

                data = minHeap[1]; //루트 노드
                temp = minHeap[minSize--]; //말단 노드

                while (child <= minSize)
                {
                    //두 자식 중 더 큰 key를 가진 자식의 인덱스를 구한다. -> child에 해당 인덱스가 저장됨.
                    if ((child < minSize) && (minHeap[child] > minHeap[child + 1]))
                    {
                        child++;
                    }

                    //만약 자식보다 temp의 값이 크다면 더이상 내려오지 않아도 되므로 break;
                    if (minHeap[child] >= temp)
                    {
                        break;
                    }

                    //내려와야 할 경우
                    minHeap[parent] = minHeap[child]; //자식노드와 위치를 변경
                    parent = child; //현재 내려온 위치로 인덱스를 초기화
                    child *= 2; //내려온 위치에서의 왼쪽 자식노드 인덱스로 초기화
                }

                minHeap[parent] = temp; //최종적으로 결정된 위치에 temp를 저장해준다.
                return data; //data 반환
            }

            public int DeleteMax()
            {
                if (isEmptyMax())
                {
                    return 0;
                }

                int parent = 1; //말단노드가 루트에서부터 내려오는 과정 중 위치를 기억할 변수
                int child = 2; //비교할 자식은 2번 인덱스 부터 시작이므로 초기화.

                int data, temp;

                data = maxHeap[1]; //루트 노드
                temp = maxHeap[maxSize--]; //말단 노드

                while (child <= maxSize)
                {
                    //두 자식 중 더 큰 key를 가진 자식의 인덱스를 구한다. -> child에 해당 인덱스가 저장됨.
                    if ((child < maxSize) && (maxHeap[child] < maxHeap[child + 1]))
                    {
                        child++;
                    }

                    //만약 자식보다 temp의 값이 크다면 더이상 내려오지 않아도 되므로 break;
                    if (maxHeap[child] <= temp)
                    {
                        break;
                    }

                    //내려와야 할 경우
                    maxHeap[parent] = maxHeap[child]; //자식노드와 위치를 변경
                    parent = child; //현재 내려온 위치로 인덱스를 초기화
                    child *= 2; //내려온 위치에서의 왼쪽 자식노드 인덱스로 초기화
                }

                maxHeap[parent] = temp; //최종적으로 결정된 위치에 temp를 저장해준다.
                return data; //data 반환
            }

            public int peekMin()
            {
                return minHeap[1];
            }

            public int peekMax()
            {
                return maxHeap[1];
            }

            public void MaxClear()
            { 
                while(!isEmptyMax())
                {
                    DeleteMax();
                }
            }

            public void MinClear()
            {
                while (!isEmptyMin())
                {
                    DeleteMin();
                }
            }

            public bool isEmptyMax()
            {
                if (maxSize == 0)
                {
                    return true;
                }
                else;
                {
                    return false;
                }
            }

            public bool isEmptyMin()
            {
                if (minSize == 0)
                {
                    return true;
                }
                else;
                {
                    return false;
                }
            }
        }

        static int[] solution(string[] operations)
        {
            int[] answer = new int[2];

            DoublyPriorityQueue q = new DoublyPriorityQueue(operations.Length);

            for(int i=0; i<operations.Length; i++)
            {
                string oper;
                int num;

                string[] temp = operations[i].Split(" ");
                oper = temp[0];
                num = int.Parse(temp[1]);

                if(!q.isEmptyMax() && !q.isEmptyMin() && q.peekMin() > q.peekMax())
                {
                    q.MaxClear();
                    q.MinClear();
                }

                switch (oper)
                {
                    case "I":
                        q.InsertMin(num);
                        q.InsertMax(num);
                        break;

                    case "D":

                        if(num == 1)
                        {
                            if(!q.isEmptyMax())
                            {
                                q.DeleteMax();
                            }
                        }
                        else
                        {
                            if(!q.isEmptyMin())
                            {
                                q.DeleteMin();
                            }
                        }

                        break;
                }
            }

            if(q.isEmptyMin() || q.isEmptyMax())
            {
                answer[0] = 0;
                answer[1] = 0;
            }
            else
            {
                answer[0] = q.DeleteMax();
                answer[1] = q.DeleteMin();
            }

            return answer;
        }

        static void Main()
        {
            int[] result = solution(new string[] {"I 7", "I 5", "I -5", "D -1" });
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
