using System;
using System.Collections.Generic;

public static class ResistorColorTrio
{
    public static string Label(string[] colors)
    {
        if (string.IsNullOrEmpty(colors[0]) || string.IsNullOrEmpty(colors[1]) || string.IsNullOrEmpty(colors[2])) throw new ArgumentNullException("Color codes are not specified");

        Dictionary<string, int> ColorCodes = new Dictionary<string, int>(10);
        ColorCodes.Add("black",  0);
        ColorCodes.Add("brown",  1);
        ColorCodes.Add("red",    2);
        ColorCodes.Add("orange", 3);
        ColorCodes.Add("yellow", 4);
        ColorCodes.Add("green",  5);
        ColorCodes.Add("blue",   6);
        ColorCodes.Add("violet", 7);
        ColorCodes.Add("grey",   8);
        ColorCodes.Add("white",  9);

        int ohms = int.Parse(ColorCodes[colors[0]].ToString() + ColorCodes[colors[1]].ToString());

        ohms *= (int)Math.Pow(10, ColorCodes[colors[2]]);

        bool IsKilo = ohms > 1000;

        return IsKilo switch
        {
            true => $"{ohms/1000} kiloohms",
            false => $"{ohms} ohms"
        };
    }
}
