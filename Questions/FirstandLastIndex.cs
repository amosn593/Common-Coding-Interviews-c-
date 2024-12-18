namespace InterviewQuestions.Questions;

public static class FirstandLastIndex
{
    //For unordered array
    public static int[] TestCaseUnorderedArray(int[] array, int findNumber)
    {
        //Declare array to hold the results
        var resultsArray = new List<int>();
        for(int x = 0; x < array.Length; x++)
        {
            if(array[x] == findNumber)
            {
                resultsArray.Add(x);
            }
        }

        //Check if number found
        if(resultsArray.Count <= 0)
        {
            return [-1,-1];
        }

        //Convert back to 

        int FirstIndex = resultsArray[0];

        int LastIndex = resultsArray[^1];




        return [FirstIndex,LastIndex];
    }

    public static int[] TestCaseOrderedArray(int[] array, int findNumber)
    {
        for(int x = 0; x < array.Length; x++)
        {
            if(array[x] == findNumber)
            {
                int FirstPosition = x;
                while(x+1 < array.Length && x+1 == array[x+1])
                {
                    x++;
                }

                return [FirstPosition, x];
            }
        }

        return [-1,-1];

        
    }
}