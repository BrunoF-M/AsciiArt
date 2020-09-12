using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Aperte enter para fazer ver a dona aranha: ");
            Console.ReadLine();
            
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(" ||  || ");
            Console.WriteLine(" \\\\()// ");
            Console.WriteLine("//(__)\\\\");
            Console.WriteLine("||    ||");
            Console.ResetColor();
        }
    }
}
