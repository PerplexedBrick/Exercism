using System;
using System.Text;

public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {        
        string a = startBottles switch
        {
            0 => $"No more bottles of beer on the wall, no more bottles of beer.\nGo to the store and buy some more, 99 bottles of beer on the wall.",
            1 => $"1 bottle of beer on the wall, 1 bottle of beer.\nTake it down and pass it around, no more bottles of beer on the wall.",
            2 => $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottle of beer on the wall.",
            _ => $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\nTake one down and pass it around, {startBottles - 1} bottles of beer on the wall."
        };

        if (takeDown - 1 == 0) return a;

        return a + "\n\n" + Recite(startBottles - 1, takeDown - 1);
    }
}