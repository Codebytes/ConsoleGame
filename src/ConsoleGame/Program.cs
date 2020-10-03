using System;
using ConsoleHelper;

namespace ConsoleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Console.WindowHeight}x{Console.WindowWidth}");
            Console.WriteLine($"{Console.WindowLeft}x{Console.WindowTop}");
            Console.WriteLine($"{Console.LargestWindowHeight}x{Console.LargestWindowWidth}");
            Console.Clear();
            Console.CursorVisible = true;
            Console.CursorTop = 0;
            Console.CursorLeft = 20;
        }
    }
}
