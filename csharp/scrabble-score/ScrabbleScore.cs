using System;
using System.Text.RegularExpressions;

public static class ScrabbleScore
{
    public static int Score(string input)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        int score = 0;

        foreach(char c in input.ToUpper())
        {
            bool eval = default;

            score = eval switch
            {
                false when Regex.IsMatch(c.ToString(), "[AEIOULNRST]") => score + 1,
                false when Regex.IsMatch(c.ToString(), "[DG]") => score + 2,
                false when Regex.IsMatch(c.ToString(), "[BCMP]") => score + 3,
                false when Regex.IsMatch(c.ToString(), "[FHVWY]") => score + 4,
                false when Regex.IsMatch(c.ToString(), "[K]") => score + 5,
                false when Regex.IsMatch(c.ToString(), "[JX]") => score + 8,
                false when Regex.IsMatch(c.ToString(), "[QZ]") => score + 10,
                false => throw new ArgumentException($"That's a wrong character: {c}")
            };
        }

        return score;
    }
}