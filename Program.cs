using System;
using System.Threading;


namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            pozycjonowanie p = new pozycjonowanie();
            pozycjonowanie jablko = new pozycjonowanie();
            int ostatniIndeks = 15;
            punkt[] pozycjaKlocka = new punkt[ostatniIndeks];

            Random jablkoX = new Random();
            Random jablkoY = new Random();
            int zmiennaX = jablkoX.Next(120);
            int zmiennaY = jablkoY.Next(30);


            while (true)
            {
                char znak = 'r', s = 's', w = 'w', a = 'a', d = 'd', r = 'r';
                int i = 0, j = 0, b = 0;

                for (int k=0; 1 < 2;)
                    {
                    if (Console.KeyAvailable)
                    {
                        if(znak == s)
                        {
                            znak = Console.ReadKey(true).KeyChar;
                            if (znak == w)
                            {
                                znak = s;
                            }
                        }
                        else
                        if (znak == w)
                        {
                            znak = Console.ReadKey(true).KeyChar;
                            if (znak == s)
                            {
                                znak = w;
                            }
                        }
                        else
                        if (znak == a)
                        {
                            znak = Console.ReadKey(true).KeyChar;
                            if (znak == d)
                            {
                                znak = a;
                            }
                        }
                        else
                        if (znak == d)
                        {
                            znak = Console.ReadKey(true).KeyChar;
                            if (znak == a)
                            {
                                znak = d;
                            }
                        }
                        else
                        znak = Console.ReadKey(true).KeyChar;


                    }
                    if (znak == r)
                    {
                        for(int q=0; q<ostatniIndeks; q++)
                        {
                            pozycjaKlocka[b] = new punkt(i, j);
                            j++;
                            b++;
                            
                        }
                        j = 0;
                        b = 0;
                    }
                    if (znak == d)
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
                    if (znak == s)
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
                    if (znak == w)
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
                    if (znak == a)
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

                    for (int ii = 0; ii <= ostatniIndeks-1; ii++)
                    {
                        if (pozycjaKlocka[ostatniIndeks-1].x == -1 && znak == a )
                        {
                            pozycjaKlocka[ostatniIndeks-1].x = 119;
                        }
                        if (pozycjaKlocka[ostatniIndeks - 1].x == 120 && znak == d)
                        {
                            pozycjaKlocka[ostatniIndeks - 1].x = 0;
                        }
                        if (pozycjaKlocka[ostatniIndeks - 1].y == 0 && znak == w)
                        {
                            pozycjaKlocka[ostatniIndeks - 1].y = 30;
                        }
                        if (pozycjaKlocka[ostatniIndeks - 1].y == 30 && znak == s)
                        {
                            pozycjaKlocka[ostatniIndeks - 1].y = 0;
                        }

                        p.WriteAt("@", pozycjaKlocka[ii].x, pozycjaKlocka[ii].y);
                        
                    }

                    int wartoscPionowa = pozycjaKlocka[14].y;
                    int wartoscPozioma = pozycjaKlocka[14].x;
                    int wartoscDecyzyjna = 0;

                    for (int iii = 0; iii < ostatniIndeks-1; iii++)
                    {
                        if(pozycjaKlocka[iii].x == wartoscPozioma && pozycjaKlocka[iii].y == wartoscPionowa)
                        {
                            wartoscDecyzyjna = 1;
                        }

                    }
                    if(wartoscDecyzyjna == 1)
                    {
                        Console.Write("PRZEGRALES");
                        Console.ReadKey();
                    }

                    jablko.WriteAt("O", zmiennaX, zmiennaY);
                    Cursor.Hide();

                    Thread.Sleep(50);
                    Console.Clear();
                }
            }
        }
    }
}
