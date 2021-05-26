using System;
using System.Collections.Generic;

public static class ResistorColor
{
    enum ColorCodes
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }

    public static int ColorCode(string color) => (int)Enum.Parse(typeof(ColorCodes), color);
     
    public static string[] Colors() => Enum.GetNames(typeof(ColorCodes));
}