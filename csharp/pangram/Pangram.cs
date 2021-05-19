using System;

public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        if (input.Length > 25)
        {
            foreach (char c in alphabet)
            {
                bool IsLetterPresent = false;

                foreach(char c1 in input.ToLower())
                {
                    if (c == c1)
                    {
                        IsLetterPresent = true;
                    } 
                    Console.WriteLine($"{c} == {c1}");
                }

                if (IsLetterPresent == false) return false;
            }


            return true;
        }
        return false;        
    }

}
