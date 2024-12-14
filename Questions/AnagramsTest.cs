namespace InterviewQuestion.Question;

public static class AnagramsTest
{
    /*
    Two strings are anagrams if they have same length, and same characters with same frequend

    First check if the two strings have same length

    Create two dictionary ,key to be the characters and value frequency

    compare the two dictionaries
    
    */

    public static bool CheckIfTwoStringsAreAnagrams(string String1, string String2)
    {
        //Check if have same length
        if(String1.Length != String2.Length)
        {
            return false;
        }

        //Create two dictionaries
        Dictionary<char, int> dict1 = [];
        Dictionary<char, int> dict2 = [];

        //Loop through each string
        foreach(var Item in String1)
        {
            if(dict1.ContainsKey(Item))
            {
                dict1[Item] += 1;
            }
            else
            {
                dict1[Item] = 1;
            }
        }

        foreach(var Item in String2)
        {
            if(dict2.ContainsKey(Item))
            {
                dict2[Item] += 1;
            }
            else
            {
                dict2[Item] = 1;
            }
        }

        foreach (char key in dict1.Keys)
        {
            if(!dict2.ContainsKey(key) || dict1[key] != dict2[key])
            {
                return false;
            }
        }


        return true;
    }

}