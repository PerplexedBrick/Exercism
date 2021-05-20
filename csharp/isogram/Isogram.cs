using System;

public static class Isogram
{
    public static bool IsIsogram(string input)
    {
        string word = input.ToLower();
        if (word.Length < 2) return true;
        if (word.Length > 1)
        {
            for (int i=0; i < word.Length-1; i++)
            {
                if (IsLetter(word[i]))
                {
                    for(int j = i+1; j < word.Length; j++)
                    {
                        if (word[i] == word[j]) return false;
                    }
                }
            }
            return true;
        }
        return false;
    }

    public static bool IsLetter(char Letter)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        foreach (char c in alphabet)
        {
            if (Letter == c) return true;
        }
        return false;
    }
}
