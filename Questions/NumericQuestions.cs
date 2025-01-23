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
        if(IsPrimeNumber(testNumber)){
            Console.WriteLine($"{testNumber} is PrimeNumber");
        }
        else{
            Console.WriteLine($"{testNumber} is Not PrimeNumber");
        }
    }

    private static bool IsPrimeNumber(int testNumber){
        for(int i = 2; i <= testNumber/2; i++){
            if(testNumber%i==0){
                return false;
            }
            else{
                return true;
            }
        }
        return false;
    }


}

