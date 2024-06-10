namespace RemoveElement;

public static class Solution
{
    
    public static int RemoveElement(ref int[] nums, int val)
    {
        // bool IsVal(int element)
        // {
        //     return element != val;
        // }
        //
        // var expected = Array.FindAll(nums, IsVal).ToArray();
        // result = expected.Length;
        
        int result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                result++;
        }
        
        Array.Sort(nums);
        Console.WriteLine($"Ordered Array: {TestSolution.ArrayToPrint(nums)}");
        
        int aPointer = nums.Length - 1;
        int temp = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val && nums[aPointer] != val && i < result /*&& !ValueIsInArray(nums, val, result)*/)
            {
                temp = nums[i];
                if (nums[aPointer] == val)
                    aPointer--;
                
                nums[i] = nums[aPointer];
                nums[aPointer] = temp;
                aPointer--;
            }
        }
        
        return result;
    }

    private static bool ValueIsInArray(int[] arr, int val, int limit = 0)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (limit > 0 && i == limit - 1) 
                break;
            if (arr[i] == val)
                return true;

        }
        return false;
    }
    
    
    
}