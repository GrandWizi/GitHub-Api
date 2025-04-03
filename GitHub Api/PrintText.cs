using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Api;

public static class PrintText
{
    public static void Simple(string text)
    {
        Console.WriteLine($"{text}");
    }

    public static void Green(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{text}");
        Console.ResetColor();
    }

    public static void Yellow(string text)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{text}");
        Console.ResetColor();
    }

    public static void Blue(string text)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{text}");
        Console.ResetColor();
    }

    public static void DarkBlue(string text)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{text}");
        Console.ResetColor();
    }

    public static void Red(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{text}");
        Console.ResetColor();
    }
}
