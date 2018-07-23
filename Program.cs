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
            int ostatniIndeks = 5;
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
                        for(int q=0; q<ostatniIndeks; q++)
                        {
                            pozycjaKlocka[i] = new punkt(i, j);
                            i++;
                        }
                        i = 0;
                    }
                    if (znak == g)
                    {                      
                        punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks-1].x+1, pozycjaKlocka[ostatniIndeks-1].y);
                        for(int q=0; q<ostatniIndeks; q++)
                        {
                            if(q==ostatniIndeks-1)
                            {
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                            pozycjaKlocka[q] = pozycjaKlocka[q+1];
                        }
                    }
                    if (znak == f)
                    {                     
                        punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks-1].x, pozycjaKlocka[ostatniIndeks-1].y+1);
                        for (int q = 0; q < ostatniIndeks; q++)
                        {
                            if (q == ostatniIndeks - 1)
                            {
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
                    }
                    if (znak == r)
                    {
                        punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks-1].x, pozycjaKlocka[ostatniIndeks-1].y - 1);
                        for (int q = 0; q < ostatniIndeks; q++)
                        {
                            if (q == ostatniIndeks - 1)
                            {
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
                    }
                    if (znak == d)
                    {
                        punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks-1].x-1, pozycjaKlocka[ostatniIndeks-1].y);
                        for (int q = 0; q < ostatniIndeks; q++)
                        {
                            if (q == ostatniIndeks - 1)
                            {
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
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
