﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class 야근_지수
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

                //만약 부모노드의 값보다 삽입될 값이 크고, 위치가 최상위가 아니라면 계속해서 트리를 타고 올라간다.
                while ((index != 1) && (data > heap[index / 2]))
                {
                    heap[index] = heap[index / 2];
                    index /= 2;
                }

                heap[index] = data;
            }

            public int Delete()
            {
                if (isEmpty())
                {
                    return 0;
                }

                int parent = 1; //말단노드가 루트에서부터 내려오는 과정 중 위치를 기억할 변수
                int child = 2; //비교할 자식은 2번 인덱스 부터 시작이므로 초기화.

                int data, temp;

                data = heap[1]; //루트 노드
                temp = heap[heap_size--]; //말단 노드

                while (child <= heap_size)
                {
                    //두 자식 중 더 큰 key를 가진 자식의 인덱스를 구한다. -> child에 해당 인덱스가 저장됨.
                    if ((child < heap_size) && (heap[child] < heap[child + 1]))
                    {
                        child++;
                    }

                    //만약 자식보다 temp의 값이 크다면 더이상 내려오지 않아도 되므로 break;
                    if (heap[child] <= temp)
                    {
                        break;
                    }

                    //내려와야 할 경우
                    heap[parent] = heap[child]; //자식노드와 위치를 변경
                    parent = child; //현재 내려온 위치로 인덱스를 초기화
                    child *= 2; //내려온 위치에서의 왼쪽 자식노드 인덱스로 초기화
                }

                heap[parent] = temp; //최종적으로 결정된 위치에 temp를 저장해준다.
                return data; //data 반환
            }

            public int Peek()
            {
                return heap[1];
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

        static long solution(int n, int[] works)
        {
            long answer = 0;
            int size = works.Length;
            maxHeap heap = new maxHeap(size + 1);

            for(int i=0; i< size; i++)
            {
                heap.Insert(works[i]);
            }

            while(n != 0 && heap.Peek() != 0)
            {
                int max = heap.Delete();
                max--;
                n--;
                heap.Insert(max);
            }

            while(!heap.isEmpty())
            {
                int cur = heap.Delete();
                answer += (cur * cur);
            }

            return answer;
        }

        static void Main()
        {
            Console.Write(solution(4, new int[] { 4, 3, 3 }));
        }
    }
}
