using System;
using System.Linq;

namespace LeetCode.Hard;

public class MedianOfTwoSortedArrays
{
    public double Solve(int[] nums1, int[] nums2)
    {
        if (nums1.Length == 0)
            return SimpleSolve(nums2);
        
        if (nums2.Length == 0)
            return SimpleSolve(nums1);
        
        var isOdd = (nums1.Length + nums2.Length) % 2 == 0;
        int middle;
        // в четном сценарии мы ищем 2 индекса, в нечетном один [1,2] [1,2,3]
        if(isOdd)
            middle = (nums1.Length-1 + nums2.Length-1) / 2;
        else
            middle = (nums1.Length-1 + nums2.Length-1) / 2+1;

        double? middleVal = null;
        double? middlePlusVal = null;
        
        // бинарным поиском пытаемся найти медианное(ые) число(а) в первом массиве
        var fStart = 0;
        var fEnd = nums1.Length-1;
        FindMiddleIndex(nums1, nums2);
        
        // во втором массиве
        fStart = 0;
        fEnd = nums2.Length-1;
        FindMiddleIndex(nums2, nums1);

        // в нечетном случае, нам нужно конкретное значение из массива
        if (!isOdd || !middlePlusVal.HasValue)
            return middleVal ?? 0;
        
        // Случай, когда оба массива равны
        if (!middleVal.HasValue && middlePlusVal.HasValue)
            return SimpleSolve(nums2);

        // Случай, когда не смогли ничего найти
        if (!middleVal.HasValue)
            return 0;
        
        // Нечетный случай
        return (middleVal.Value+middlePlusVal.Value)/2;
        
        // Случай, когда достаточно рассмотреть один массив
        double SimpleSolve(int[] nums)
        {
            var odd = nums.Length % 2 == 0;
            if (odd)
                return (double)(nums[(nums.Length - 1) / 2] + nums[(nums.Length - 1) / 2 + 1]) / 2;
            return nums[nums.Length / 2];
        }
        
        // Нахождение позиций элементов первого массива fromArray
        // относительно элементов второго массива inArray
        void FindMiddleIndex(int[] fromArray, int[] inArray)
        {
            var i = (fStart+fEnd) / 2;
            var ftemp = IndexInAllArray(fromArray, inArray, i);
            
            if (ftemp.index == middle)
                middleVal = ftemp.value;
            else if (ftemp.index == middle+1)
                middlePlusVal = ftemp.value;
            if(middleVal.HasValue&& !isOdd ||middleVal.HasValue &&middlePlusVal.HasValue)
                return;
            
            if(fStart==fEnd)
                return;
            
            if (ftemp.index > middle)
                fEnd = i-1;
            else if(ftemp.index <= middle)
                fStart = i+1;

            if(fStart>fEnd)
                return;
            
            FindMiddleIndex(fromArray, inArray);
        }

        (int index,int value) IndexInAllArray(int[] fromArray, int[] inArray, int index)
        {
            return (BsPositionInAnotherArray(fromArray[index], inArray, 0, inArray.Length - 1) + index,fromArray[index]);
        }
        
        // Бинарное нахождение позиции элемента в массиве
        int BsPositionInAnotherArray(int value, int[] array, int startIndex, int endIndex)
        {
            if (endIndex-startIndex==1 || endIndex == startIndex)
            {
                if (array[startIndex]>=value)
                    return startIndex;
                if (array[endIndex]>=value)
                    return endIndex;
                return endIndex+1;
            }

            var median = (startIndex + endIndex) / 2;

            if (array[median] == value)
                return median;

            if (array[median] > value)
                return BsPositionInAnotherArray(value, array, startIndex, median - 1);

            return BsPositionInAnotherArray(value, array, median + 1, endIndex);
        }
    }


    public void Test()
    {
        // // 1 2 3 4 5 6 7 8 9 10
        int[] firstArray = new[] {1, 3, 5, 7 ,9};
        int[] secondArray = new[] {2, 4, 6, 8 ,10};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 5,5");
        
        // // 1 2 3 8 9 10 11 100 101 102
        firstArray = new[] {1, 3, 8, 100 ,102};
        secondArray = new[] {2, 9, 10, 11 ,101};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 9,5");
        
        // 1 2 3
        firstArray = new[] {1, 3};
        secondArray = new[] {2};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 2");
        
        // 1 2 3 4
        firstArray = new[] {1, 2};
        secondArray = new[] {3,4};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 2,5");
        
        // 0 0 0 0 
        firstArray = new[] {0 , 0};
        secondArray = new[] {0 ,0};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 0");
        
        // 1 2
        firstArray = new int[0];
        secondArray = new[] {1,2};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 1,5");
        
        firstArray = new [] {0,0,0,0,0};
        secondArray = new[] {-1,0,0,0,0,0,1};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 0");
        
        firstArray = new [] {2,2,4,4};
        secondArray = new[] {2,2,4,4};
        Console.WriteLine(Solve(firstArray, secondArray)+" == 3");
    }
}