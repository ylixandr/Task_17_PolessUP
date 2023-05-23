using System;
using System.Collections.Generic;

public class Solution
{
    public IList<string> LetterCasePermutation(string s)
    {
        IList<string> result = new List<string>();
        Backtrack(result, s.ToCharArray(), 0);
        return result;
    }

    private void Backtrack(IList<string> result, char[] s, int index)
    {
        if (index == s.Length)
        {
            result.Add(new string(s));
            return;
        }

        if (char.IsLetter(s[index]))
        {
            s[index] = char.ToLower(s[index]);
            Backtrack(result, s, index + 1);
            s[index] = char.ToUpper(s[index]);
            Backtrack(result, s, index + 1);
        }
        else
        {
            Backtrack(result, s, index + 1);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string s = "a1b2";
        Solution solution = new Solution();
        IList<string> result = solution.LetterCasePermutation(s);
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
}
