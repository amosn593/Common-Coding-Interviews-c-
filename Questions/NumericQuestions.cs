namespace InterviewQuestions.Questions;
public class NumericQuestions
{
    public static void OldOrEvenNumber(int testNumber)
    {
        if(testNumber % 2 == 0){
            Console.WriteLine($"{testNumber} is EvenNumber");
        }
        else{
            Console.WriteLine($"{testNumber} is OldNumber");
        }
    }

    public static void TestPrimeNumber(int testNumber)
    {
        bool isPrime = IsPrime(testNumber);
        if(isPrime)
        {
            Console.WriteLine($"{testNumber} is PrimeNumber");
        }
        else
        {
            Console.WriteLine($"{testNumber} is Not PrimeNumber");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        int boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
        {
            if (number % i == 0) return false;
        }

        return true;
    }


}

