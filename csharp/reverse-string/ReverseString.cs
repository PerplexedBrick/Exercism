using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input == "") return "";
        char[] reversedInput = input.ToCharArray();
        Array.Reverse(reversedInput);
        return new string(reversedInput);
    }
}