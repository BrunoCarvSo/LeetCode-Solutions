public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        if(nums.Length == 0) return nums;

        int[] arrayResult = new int[2];


        for(int count = 0; count < nums.Length; count++)
        {
            for(int count2 = count+1; count2 < nums.Length; count2++)
            {
                if(nums[count]+nums[count2] == target)
                {
                    arrayResult[0] = count;
                    arrayResult[1] = count2;
                    return arrayResult;
                }
            }
        } 
        
        return [4,0,4];
    }
}