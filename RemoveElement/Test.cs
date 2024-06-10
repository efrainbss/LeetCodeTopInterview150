namespace RemoveElement;


public static class TestSolution
{
    
    public static void DoTest(int[] nums, int val) {
        
        Console.WriteLine($"nums: {ArrayToPrint(nums)}");
        Console.WriteLine($"val: {val}");
        
        var k = Solution.RemoveElement(ref nums, val);
        
        Console.WriteLine($"k: {k}");
        AssertNotValInExpectedArray(nums, val, k);
        Console.ReadLine();
    }

    static void AssertNotValInExpectedArray(int[] nums, int val, int k)
    {
        bool ValueInArray = false;

        for(int i = 0; i < k ; i++)
        {
           if(val == nums[i])
           {
               ValueInArray = true;
           }
        }

        if (ValueInArray)
        {
            Console.WriteLine($"TEST FAILED: value {val} is present in expected array");
        }
        else
        {
            Console.WriteLine($"TEST PASSED: value {val} is NOT present in expected array");
        }
        Console.WriteLine($"Result array: {ArrayToPrint(nums)}");
        Console.WriteLine($"Result array shorted to k: {ArrayToPrint(nums, k)}");
    }
    
    public static string ArrayToPrint(int[] arr, int limit = 0)
    {
        string strToPrint = "[";
        
        for (int i = 0; i < arr.Length; i++)
        {
            strToPrint += $"{arr[i]},";
            
            if (limit > 0 && i == limit - 1) 
                break;
        }

        strToPrint = strToPrint.Trim(',');
        strToPrint += "]";

        return strToPrint;
    }
}

