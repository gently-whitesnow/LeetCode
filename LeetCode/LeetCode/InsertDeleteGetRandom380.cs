using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode;

// https://leetcode.com/problems/insert-delete-getrandom-o1/
public class InsertDeleteGetRandom380
{
    public class RandomizedSet
    {
        private HashSet<int> set = new();
        private Random rand = new();

        public RandomizedSet()
        {
        }

        public bool Insert(int val)
        {
            if (set.Contains(val))
                return false;
            set.Add(val);
            return true;
        }

        public bool Remove(int val)
        {
            if (!set.Contains(val))
                return false;
            set.Remove(val);
            return true;
        }

        public int GetRandom()
        {
            return set.ElementAt(rand.Next(0, set.Count));
        }
    }

    public void Test()
    {
        RandomizedSet randomizedSet = new RandomizedSet();
        Console.WriteLine();
        Console.WriteLine(randomizedSet
            .Insert(1)); // Inserts 1 to the set. Returns true as 1 was inserted successfully.
        Console.WriteLine(randomizedSet.Remove(2)); // Returns false as 2 does not exist in the set.
        Console.WriteLine(randomizedSet.Insert(2)); // Inserts 2 to the set, returns true. Set now contains [1,2].
        Console.WriteLine(randomizedSet.GetRandom()); // getRandom() should return either 1 or 2 randomly.
        Console.WriteLine(randomizedSet.Remove(1)); // Removes 1 from the set, returns true. Set now contains [2].
        Console.WriteLine(randomizedSet.Insert(2)); // 2 was already in the set, so return false.
        Console.WriteLine(randomizedSet.Insert(1)); // 2 was already in the set, so return false.
        Console.WriteLine(randomizedSet.Insert(3)); // 2 was already in the set, so return false.
        Console.WriteLine(randomizedSet
            .GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
        Console.WriteLine(randomizedSet
            .GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
        Console.WriteLine(randomizedSet
            .GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
        Console.WriteLine(randomizedSet
            .GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
        Console.WriteLine(randomizedSet
            .GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
        Console.WriteLine(randomizedSet
            .GetRandom()); // Since 2 is the only number in the set, getRandom() will always return 2.
    }
}