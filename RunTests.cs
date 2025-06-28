using InterviewQuestions.Andela;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions;

public static class RunTests
{
    public static async Task Andela()
    {
        // Example usage of the SubstringWithYield class
        Console.WriteLine("Substring with Yield:");
        var result1 = SubstringWithYield.Chunk("abcdefg", 3);
        Console.WriteLine(string.Join(", ", result1)); // Output: abc, de, fg
        var result2 = SubstringWithYield.Chunk("abcdefgh", 3);
        Console.WriteLine(string.Join(", ", result2)); // Output: abc, def, gh

        // Example usage of the PairsOfTwoCharacters class
        Console.WriteLine("Pairs of Two Characters:");
        var result3 = PairsOfTwoCharacters.Method("abcdefg");
        Console.WriteLine(string.Join(", ", result3)); // Output: ab, cd, ef, g_

        //make http request to https://jsonplaceholder.typicode.com/posts/1
        Console.WriteLine("HTTP Request :");
        var results = await WordCompletionServer.Complete("a");
        Console.WriteLine(string.Join(", ", results)); // Output: test1, test2, test3
    }
}
