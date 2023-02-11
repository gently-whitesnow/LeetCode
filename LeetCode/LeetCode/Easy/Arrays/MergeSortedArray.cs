using System;

namespace LeetCode.Easy.Arrays;

public class MergeSortedArray
{
    public void Solve(int[] A, int m, int[] B, int n)
    {
        var lastAIndex = m - 1;
        var lastBIndex = n - 1;
        var endOfResultArrayIndex = m + n - 1;

        while (lastAIndex >= 0 && lastBIndex >= 0)
        {
            if (A[lastAIndex] > B[lastBIndex])
                A[endOfResultArrayIndex--] = A[lastAIndex--];
            else
                A[endOfResultArrayIndex--] = B[lastBIndex--];
        }

        while (lastBIndex>=0)
        {
            A[endOfResultArrayIndex--] = B[lastBIndex--];
        }
    }

    public void DummySolve(int[] nums1, int m, int[] nums2, int n)
    {
        if (nums1.Length == 0)
        {
            nums1 = nums2;
            return;
        }

        if (nums2.Length == 0)
        {
            return;
        }

        var nums2Counter = 0;

        for (int i = m; i < nums1.Length; i++)
        {
            nums1[i] = nums2[nums2Counter++];
        }

        Array.Sort(nums1);
    }

    public void Test()
    {
        var nums1 = new int[] {1, 2, 3, 0, 0, 0};
        var nums2 = new int[] {2, 5, 6};
        Solve(nums1, 3, nums2, 3);
        foreach (var n in nums1)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
        nums1 = new int[] {0};
        nums2 = new int[] {1};
        Solve(nums1, 0, nums2, 1);
        foreach (var n in nums1)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
        nums1 = new int[] {1};
        nums2 = new int[] { };
        Solve(nums1, 1, nums2, 0);
        foreach (var n in nums1)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
        nums1 = new int[] {2, 0};
        nums2 = new int[] {1};
        Solve(nums1, 1, nums2, 1);
        foreach (var n in nums1)
        {
            Console.Write(n + " ");
        }

        Console.WriteLine();
        nums1 = new int[] {4, 0, 0, 0, 0, 0};
        nums2 = new int[] {1, 2, 3, 5, 6};
        Solve(nums1, 1, nums2, 5);
        foreach (var n in nums1)
        {
            Console.Write(n + " ");
        }
    }
}