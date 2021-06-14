using System;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        if (subjects.Length == 0) return Array.Empty<string>();
        if (subjects.Length == 1) return new string[] { $"And all for the want of a {subjects[0]}." };


        var recitation = new string[subjects.Length];
        for (int i = 1; i < subjects.Length; i++)
        {
            recitation[i-1] = $"For want of a {subjects[i-1]} the {subjects[i]} was lost.";
        }

        recitation[subjects.Length - 1] = $"And all for the want of a {subjects[0]}.";
        return recitation;
    }
}