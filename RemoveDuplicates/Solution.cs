namespace RemoveDuplicates;

public static class Solution
{
    public  static int RemoveDuplicates(ref int[] nums)
    {
        int result = 0;
        var dic = new Dictionary<int, int>();
        
        Array.Sort(nums);
        
        foreach (int val in nums)
        {
            var occurrence = FindValueOccurrence(nums, val);
            if (occurrence <= 1) continue;
            dic.TryAdd(val, occurrence);
            
        }
        
        // Console.WriteLine($"Ordered Array: {TestSolution.ArrayToPrint(nums)}");
        // int aPointer = nums.Length - 1;
        // int temp = 0;
        //
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     if (nums[i] == val && nums[aPointer] != val && i < result /*&& !ValueIsInArray(nums, val, result)*/)
        //     {
        //         temp = nums[i];
        //         if (nums[aPointer] == val)
        //             aPointer--;
        //         
        //         nums[i] = nums[aPointer];
        //         nums[aPointer] = temp;
        //         aPointer--;
        //     }
        // }
        
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