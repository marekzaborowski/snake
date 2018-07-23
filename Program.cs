using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            sort s = new sort();
            waz w = new waz();


            int ostatniIndeks = 4;
            punkt[] pozycjaKlocka = new punkt[ostatniIndeks];
            punkt[] pozycjaKlocka2 = new punkt[ostatniIndeks];


            while (true)
            {
                char znak='x';
                char f='f';
                char r = 'r';
                char d = 'd';
                char g = 'g';
                char x = 'x';
                int i = 0;
                int j = 0;



                for (int k=0; 1 < 2;)
                    {
                    if (Console.KeyAvailable)
                    {
                        znak = Console.ReadKey(true).KeyChar;
                    }
                    if (znak == x)
                    {
                        punkt punkt11 = new punkt(i, j);
                        punkt punkt22 = new punkt(i + 1, j);
                        punkt punkt33 = new punkt(i + 2, j);
                        punkt punkt44 = new punkt(i + 3, j);

                        pozycjaKlocka[0] = punkt11;
                        pozycjaKlocka[1] = punkt22;
                        pozycjaKlocka[2] = punkt33;
                        pozycjaKlocka[3] = punkt44;
                    }
                    if (znak == g)
                    {
                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i + 1, j);
                        punkt punkt3 = new punkt(i + 2, j);
                        punkt punkt4 = new punkt(pozycjaKlocka[3].x+1, pozycjaKlocka[3].y);
                       // i++;
                        pozycjaKlocka[0] = pozycjaKlocka[1];
                        pozycjaKlocka[1] = pozycjaKlocka[2];
                        pozycjaKlocka[2] = pozycjaKlocka[3];
                        pozycjaKlocka[3] = punkt4;
                    }
                    if (znak == f)
                    {                     
                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i, j+1);
                        punkt punkt3 = new punkt(i, j+2);
                        punkt punkt4 = new punkt(pozycjaKlocka[3].x, pozycjaKlocka[3].y+1);
                        // j++;
                        pozycjaKlocka[0] = pozycjaKlocka[1];
                        pozycjaKlocka[1] = pozycjaKlocka[2];
                        pozycjaKlocka[2] = pozycjaKlocka[3];
                        pozycjaKlocka[3] = punkt4;
                    }
                    if (znak == r)
                    {

                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i, j + 1);
                        punkt punkt3 = new punkt(i, j+2);
                        punkt punkt4 = new punkt(pozycjaKlocka[3].x, pozycjaKlocka[3].y - 1);
                        //j--;
                        pozycjaKlocka[0] = pozycjaKlocka[1];
                        pozycjaKlocka[1] = pozycjaKlocka[2];
                        pozycjaKlocka[2] = pozycjaKlocka[3];
                        pozycjaKlocka[3] = punkt4;
                    }
                    if (znak == d)
                    {

                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i + 1, j);
                        punkt punkt3 = new punkt(i + 2, j);
                        punkt punkt4 = new punkt(pozycjaKlocka[3].x-1, pozycjaKlocka[3].y);
                        //  i--;
                        pozycjaKlocka[0] = pozycjaKlocka[1];
                        pozycjaKlocka[1] = pozycjaKlocka[2];
                        pozycjaKlocka[2] = pozycjaKlocka[3];
                        pozycjaKlocka[3] = punkt4;
                    }
                    Array.Copy(pozycjaKlocka, pozycjaKlocka2, ostatniIndeks);

                    s.Metodasortujacatablice(pozycjaKlocka2, ostatniIndeks - 1);
                    w.MetodaNowegoSpojrzeniaNaKonsole(pozycjaKlocka2, ostatniIndeks - 1);

                    Thread.Sleep(100);
                    Console.Clear();
                    }
            }
        }
    }
}
