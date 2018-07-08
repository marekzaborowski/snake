using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 10;
            int x = 10;
            int k = 4;

            waz w = new waz();
            w.MetodaPozycyjna(y, x, k);
            
            

            Console.ReadLine();
        }
    }
}
