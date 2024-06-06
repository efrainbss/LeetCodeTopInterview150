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
        int aPointer = nums.Length - 1;
        int temp = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val && i != aPointer)
            {
                if (nums[aPointer] != val  && temp != val)
                {
                    temp = nums[i];
                    nums[i] = nums[aPointer];
                    nums[aPointer] = temp;
                    aPointer--;
                }
            }
        }
        
        return result;
    } 
    
    
    
}