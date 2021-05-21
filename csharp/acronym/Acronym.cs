using System;
using System.Text.RegularExpressions;

public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        Regex rgx = new Regex("[^a-zA-Z -]");
        string abbreviation = rgx.Replace(phrase, "");

        rgx = new Regex("(\\B[a-zA-Z])|( )|(-)");
        return rgx.Replace(abbreviation, "").ToUpper();
    }
}