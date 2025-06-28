using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.Andela;

/*
 Given the string s = "abcdefg" and chunks = 3, return ["abc", "de", "fg"]. 
Note that the remainder of 1 was distributed to the first element in the list.

Given the string s = "abcdefgh" and chunks = 3, return ["abc", "def", "gh"]. 
Again, note that the remainder of 2 was distributed to the first element in the list followed by the second element in the list.
 
 */

public static class SubstringWithYield
{
    public static IEnumerable<string> ChunkIter(string s, int chunks)
    {
        int baseSize = s.Length / chunks;
        int remainder = s.Length % chunks;

        int index = 0;
        for (int i = 0; i < chunks; i++)
        {
            int currentSize = baseSize + (i < remainder ? 1 : 0);
            yield return s.Substring(index, currentSize);
            index += currentSize;
        }
    }

    public static string[] Chunk(string s, int chunks)
    {
        return ChunkIter(s, chunks).ToArray();
    }
}

/*
 complete C# solution that splits a string into pairs of two characters, and if the string has an odd length,
it appends an underscore _ to the final pair
 */

public static class PairsOfTwoCharacters
{
    public static string[] Method(string str)
    {
        if (str.Length % 2 == 1)
            str += "_";

        List<string> list = new List<string>();
        for (int i = 0; i < str.Length; i += 2)
        {
            list.Add(str[i].ToString() + str[i + 1]);
        }

        return list.ToArray();
    }
}

/*
  implementing a simple server application that offers basic word completion.
 */

public static class WordCompletionServer
{
    private static string[] wordList;
    public async static Task<string[]> Complete(string prefix)
    {
        using (var client = new HttpClient())
        {
            var response = await client.GetAsync("https://raw.githubusercontent.com/qualified/challenge-data/master/words_alpha.txt");
            response.EnsureSuccessStatusCode();
            var text = await response.Content.ReadAsStringAsync();
            wordList = text.Split('\n', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        }

        // Ensure the word list is sorted (it is by default)
        Array.Sort(wordList);

        // Match all that start with the stem
        var matches = wordList.Where(word => word.StartsWith(prefix)).ToArray();

        if (matches.Length == 0)
            return new List<string>().ToArray();

        return matches;

    }
}
