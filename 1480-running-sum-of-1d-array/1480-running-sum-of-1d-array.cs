public class Solution {
    public int[] RunningSum(int[] nums) {

        if(nums.Length == 0) return nums;


        int[] arrayResult = new int[nums.Length];
        arrayResult[0] = nums[0];


        for(int count = 1; count < nums.Length; count++)
        {
            arrayResult[count] = arrayResult[count-1] + nums[count];
        }

        return arrayResult;
    }
}