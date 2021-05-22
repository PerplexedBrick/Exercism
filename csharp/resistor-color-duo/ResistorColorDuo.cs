using System;
using System.Collections.Generic;

public static class ResistorColorDuo
{
    
    public static int Value(string[] colors)
    {
        if (string.IsNullOrEmpty(colors[0]) || string.IsNullOrEmpty(colors[1])) throw new ArgumentNullException("Color codes are not specified");

        Dictionary<string, int> ColorCodes = new Dictionary<string, int>(10);
        ColorCodes.Add("black",     0);
        ColorCodes.Add("brown",     1);
        ColorCodes.Add("red",       2);
        ColorCodes.Add("orange",    3);
        ColorCodes.Add("yellow",    4);
        ColorCodes.Add("green",     5);
        ColorCodes.Add("blue",      6);
        ColorCodes.Add("violet",    7);
        ColorCodes.Add("grey",      8);
        ColorCodes.Add("white",     9);

        if (string.IsNullOrEmpty(colors[0]) || string.IsNullOrEmpty(colors[1])) throw new ArgumentNullException("Color codes are not specified");

        return int.Parse(ColorCodes[colors[0]].ToString() + ColorCodes[colors[1]].ToString());
    }
}
