using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTestPractice
{
    class _2263
    {
        static int[] index;
        static int[] inorder;
        static int[] postorder;

        static void Solve(int inStart, int inEnd, int postStart, int postEnd)
        {
            if(inStart > inEnd || postStart > postEnd)
            {
                return;
            }

            int rootIndex = index[postorder[postEnd]];
            int leftSize = rootIndex - inStart;
            int rightSize = inEnd - rootIndex;
            Console.Write(inorder[rootIndex] + " ");

            Solve(inStart, rootIndex - 1, postStart, postStart + leftSize - 1);
            Solve(rootIndex + 1, inEnd, postStart + leftSize, postEnd - 1);
        }

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            index = new int[n + 1];
            inorder = new int[n + 1];
            postorder = new int[n + 1];

            string[] read = Console.ReadLine().Split(" ");
            for(int i = 1; i <= n; i++)
            {
                inorder[i] = int.Parse(read[i-1]);
            }

            read = Console.ReadLine().Split(" ");
            for (int i = 1; i <= n; i++)
            {
                postorder[i] = int.Parse(read[i-1]);
            }

            for (int i=1; i<=n; i++)
            {
                index[inorder[i]] = i; //어떤 숫자가 몇번째 인덱스에 있는지 저장
            }

            Solve(1, n, 1, n);
        }
    }
}
