using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewQuestions.Questions
{
    public class SmallestIntergerNotPresent
    {
        /*
     This is a demo task.

            Write a function:

            class Solution { public int solution(int[] A); }

            that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

            For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

            Given A = [1, 2, 3], the function should return 4.

            Given A = [−1, −3], the function should return 1.

            Write an efficient algorithm for the following assumptions:

            N is an integer within the range [1..100,000];
            each element of array A is an integer within the range [−1,000,000..1,000,000].
     */

     public static int Solution(int[] A)
     {
        HashSet<int> set = [];

        // Add all positive integers in the array to a HashSet
        foreach (int num in A)
        {
            if (num > 0)
                set.Add(num);
        }

        // Find the smallest positive integer not in the HashSet
        for (int i = 1; i <= 100001; i++)
        {
            if (!set.Contains(i))
                return i;
        }

        return 0; // Should never reach here
     }
        
    }
}