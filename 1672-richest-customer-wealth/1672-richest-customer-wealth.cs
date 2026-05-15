public class Solution 
{
    public int MaximumWealth(int[][] accounts) 
    {
        List<int> Sums = new List<int>(); 

        for(int count = 0; count < accounts.Length; count++)
        {
            int resultSum = 0;
            for(int count2 = 0; count2 < accounts[count].Length; count2++)
            {
                resultSum += accounts[count][count2];
            }
            Sums.Add(resultSum);
        }
        
        return Sums.Max();
    }
}