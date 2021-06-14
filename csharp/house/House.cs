using System;
using System.Text;

public static class House
{
    public static string Recite(int verseNumber)
    {
        if (verseNumber == 1)
        {
            return "This is the house that Jack built.";
        } 
        else
        {
            return $"This is {_verses[verseNumber-1, 1]} that {_verses[verseNumber-1, 0]} {Recite(verseNumber-1).Substring(8)}";
        }
        
    }

    public static string Recite(int startVerse, int endVerse)
    {
        StringBuilder combined = new StringBuilder();

        for (int i = startVerse; i < endVerse; i++)
        {
            combined.Append($"{Recite(i)}\n");
        }

        return combined.Append($"{Recite(endVerse)}").ToString();
    }

    private static string[,] _verses =
    {
       {"","the house that Jack built."},       
       {"lay in","the malt"},
       {"ate","the rat"},
       {"killed","the cat"},
       {"worried","the dog"},
       {"tossed","the cow with the crumpled horn"},
       {"milked","the maiden all forlorn"},
       {"kissed","the man all tattered and torn"},
       {"married","the priest all shaven and shorn"},
       {"woke","the rooster that crowed in the morn"},
       {"kept","the farmer sowing his corn"},
       {"belonged to","the horse and the hound and the horn"}
    };
}