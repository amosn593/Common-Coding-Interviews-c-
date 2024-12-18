namespace InterviewQuestions.Questions;
public class FindKthLargestElementInAnArray
{
    public static int TestCase(int[] array, int KthLargest)
    {
        var ArrayList = array.ToList();

        for(int i=1; i  < KthLargest; i++)
        {
            ArrayList.Remove(ArrayList.Max());
        }
        return ArrayList.Max();
    }

    public static int TestCaseSorting(int[] array, int KthLargest)
    {
        Array.Sort(array);

        return array[^KthLargest];
    }
}