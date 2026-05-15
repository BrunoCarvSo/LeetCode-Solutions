public class Solution 
{
    public IList<string> FizzBuzz(int n)
    {
        List <string> result = new List<string>();
        for(int resultIndex = 1; resultIndex < n+1; resultIndex++)
        {
            string answerWord = "";
            if((resultIndex % 3) != 0 && (resultIndex % 5) != 0)
            {
                answerWord = resultIndex.ToString();
            }
            else
            {
                if((resultIndex % 3) == 0)
                {
                    answerWord += "Fizz";
                }
                if((resultIndex % 5) == 0)
                {
                    answerWord += "Buzz";
                }
            }

            result.Add(answerWord);

        }
        
        return result.ToArray();
    }
}