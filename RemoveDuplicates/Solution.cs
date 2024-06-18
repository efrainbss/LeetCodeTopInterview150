using System.Runtime.CompilerServices;

namespace RemoveDuplicates;

public static class Solution
{
    public  static int RemoveDuplicates(ref int[] nums)
    {
        int result = 0;
        var dic = new Dictionary<int, int>();
        Array.Sort(nums);
        //find ocurrences of each value
        foreach (int val in nums)
        {
            var occurrence = FindValueOccurrence(nums, val);
            // if (occurrence <= 1) continue;
            dic.TryAdd(val, occurrence);
        }
        result = dic.Count;
        //first positions with no repeated values
        int i = 0;
        foreach (var (key,value) in dic)
        {
            nums[i] = key;
            i++;
        }
        //fill the next positions with the rest values
        foreach (var (key,value) in dic)
        {
            for(int index = 0; index < value -1; index++)
            {
                nums[i] = key;
                i++;
            }
        }
        
        Console.WriteLine($"Ordered Array: {TestSolution.ArrayToPrint(nums)}");
        return result;
    }
    
    private static int FindValueOccurrence(int[] array, int val)
    {
        int occurrences = 0; 
        
        bool IsVal(int element)
        {
            return element == val;
        }
        var findValue = Array.FindAll(array, IsVal).ToArray();
        
        occurrences = findValue.Length;

        return occurrences;
    }
    
}