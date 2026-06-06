public class Solution 
{
    public int[] LeftRightDifference(int[] nums) 
    {
        int tam = nums.Length;
        if(tam == 1)
        {
            return [0];
        }
        else if(tam == 2)
        {
            return [nums[1],nums[0]];
        }
        int[] leftSum = new int[tam];
        int[] rightSum = new int[tam];

        leftSum[0] = 0;
        rightSum[tam-1] = 0;

        for(int counter = tam-2; counter >= 0 ; counter--) 
        {  
            int rightTempSum = 0; 
            for(int i = tam-1; i > counter; i--) 
            {
                rightTempSum += nums[i];
            }
            rightSum[counter] = rightTempSum;
        }

        for(int counter = 1; counter < tam ; counter++)
        {  
            int leftTempSum = 0; 
            for(int i = 0; i < counter; i++) 
            {
                leftTempSum += nums[i];
            }
            leftSum[counter] = leftTempSum;
        }

        int[] arrayResult = new int[tam];
        for(int counter = 0; counter < tam; counter++)
        {
            arrayResult[counter] = Math.Abs(leftSum[counter] - rightSum[counter]);
        }
        return arrayResult;
    }
}




