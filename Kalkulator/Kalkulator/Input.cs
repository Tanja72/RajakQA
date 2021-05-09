using System;


namespace Kalkulator
{
    public class Input
    {
        public static string GetStringInput(string poruka)
        {
            Console.Write($"{poruka}");

            return Console.ReadLine();
        }
    }
}
