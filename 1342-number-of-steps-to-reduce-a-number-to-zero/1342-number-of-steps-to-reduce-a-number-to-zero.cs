public class Solution {
    public int NumberOfSteps(int num) 
    {
        int numberOfSteps = 0;
        while(num != 0)
        {
            if(num % 2 == 0)
            {
                num = num/2;
                numberOfSteps += 1;
            }
            if(num % 2 == 1)
            {
                num -= 1;
                numberOfSteps += 1;
            }   
        }
        return numberOfSteps;
    }
}