using System;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            pozycjonowanie p = new pozycjonowanie();
            pozycjonowanie jablko = new pozycjonowanie();
            int ostatniIndeks = 3;
            int maksWielkoscWeza = 1000;
            punkt[] pozycjaKlocka = new punkt[maksWielkoscWeza];
            
            Random jablkoX = new Random();
            Random jablkoY = new Random();
            int zmiennaX = jablkoX.Next(120);
            int zmiennaY = jablkoY.Next(30);
            int zmiennaPomocnicza = 0;
            int zmiennaPomocnicza2 = 0;

            pozycjaKlocka[999].x = zmiennaX;
            pozycjaKlocka[999].y = zmiennaY;
            
            Queue<punkt> QueueOfAples = new Queue<punkt>();
            QueueOfAples.Enqueue(pozycjaKlocka[999]);
            char znak = 'r', s = 's', w = 'w', a = 'a', d = 'd', r = 'r';
            while (true)
            {
                
                int i = 0, j = 0, b = 0;

                if (Console.KeyAvailable)
                {
                    if (znak == s)
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
                    for (int q = 0; q < ostatniIndeks; q++)
                    {
                        pozycjaKlocka[b] = new punkt(i, j);
                        j++;
                        b++;
                    }
                    j = 0;
                    b = 0;
                }

                if (pozycjaKlocka[ostatniIndeks - 1].x == zmiennaX && pozycjaKlocka[ostatniIndeks - 1].y == zmiennaY)
                {
                    if (zmiennaPomocnicza2 == 1)
                    {
                        QueueOfAples.Enqueue(pozycjaKlocka[ostatniIndeks - 1]);
                    }
                    zmiennaX = jablkoX.Next(120);
                    zmiennaY = jablkoY.Next(30);
                    zmiennaPomocnicza2 = 1;
                }

                if (znak == d)
                {
                    for (int q = 0; q < ostatniIndeks; q++)
                    {
                        if (q == ostatniIndeks - 1)
                        {
                            if (zmiennaPomocnicza == 1)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q - 1];
                                punkt zmienny = new punkt(pozycjaKlocka[q].x + 1, pozycjaKlocka[q].y);
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                            {
                                punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks - 1].x + 1, pozycjaKlocka[ostatniIndeks - 1].y);
                                pozycjaKlocka[q] = zmienny;
                            }
                        }
                        else
                        if (QueueOfAples.Count == 0)
                        {
                            if (zmiennaPomocnicza == 0)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                            }
                        }
                        else
                        if ((pozycjaKlocka[0].x != QueueOfAples.Peek().x || pozycjaKlocka[0].y != QueueOfAples.Peek().y || q != 0) && zmiennaPomocnicza == 0)
                        {
                            pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
                        else
                        if (QueueOfAples.Count != 0)
                        {
                            if (pozycjaKlocka[0].x == QueueOfAples.Peek().x && pozycjaKlocka[0].y == QueueOfAples.Peek().y)
                            {
                                QueueOfAples.Dequeue();
                                ostatniIndeks++;
                                zmiennaPomocnicza = 1;
                            }
                        }
                    }
                    zmiennaPomocnicza = 0;
                }
                if (znak == s)
                {
                    for (int q = 0; q < ostatniIndeks; q++)
                    {
                        if (q == ostatniIndeks - 1)
                        {
                            if (zmiennaPomocnicza == 1)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q - 1];
                                punkt zmienny = new punkt(pozycjaKlocka[q].x, pozycjaKlocka[q].y + 1);
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                            {
                                punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks - 1].x, pozycjaKlocka[ostatniIndeks - 1].y + 1);
                                pozycjaKlocka[q] = zmienny;
                            }
                        }
                        else
                        if (QueueOfAples.Count == 0)
                        {
                            if (zmiennaPomocnicza == 0)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                            }
                        }
                        else
                        if ((pozycjaKlocka[0].x != QueueOfAples.Peek().x || pozycjaKlocka[0].y != QueueOfAples.Peek().y || q != 0) && zmiennaPomocnicza == 0)
                        {
                            pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
                        else
                        if (QueueOfAples.Count != 0)
                        {
                            if (pozycjaKlocka[0].x == QueueOfAples.Peek().x && pozycjaKlocka[0].y == QueueOfAples.Peek().y)
                            {
                                QueueOfAples.Dequeue();
                                ostatniIndeks++;
                                zmiennaPomocnicza = 1;
                            }
                        }
                    }
                    zmiennaPomocnicza = 0;
                }
                if (znak == w)
                {
                    for (int q = 0; q < ostatniIndeks; q++)
                    {

                        if (q == ostatniIndeks - 1)
                        {
                            if (zmiennaPomocnicza == 1)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q - 1];
                                punkt zmienny = new punkt(pozycjaKlocka[q].x, pozycjaKlocka[q].y - 1);
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                            {
                                punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks - 1].x, pozycjaKlocka[ostatniIndeks - 1].y - 1);
                                pozycjaKlocka[q] = zmienny;
                            }
                        }
                        else
                        if (QueueOfAples.Count == 0)
                        {
                            if (zmiennaPomocnicza == 0)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                            }
                        }
                        else
                        if ((pozycjaKlocka[0].x != QueueOfAples.Peek().x || pozycjaKlocka[0].y != QueueOfAples.Peek().y || q != 0) && zmiennaPomocnicza == 0)
                        {
                            pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
                        else
                        if (QueueOfAples.Count != 0)
                        {
                            if (pozycjaKlocka[0].x == QueueOfAples.Peek().x && pozycjaKlocka[0].y == QueueOfAples.Peek().y)
                            {
                                QueueOfAples.Dequeue();
                                ostatniIndeks++;
                                zmiennaPomocnicza = 1;
                            }
                        }
                    }
                    zmiennaPomocnicza = 0;
                }
                if (znak == a)
                {
                    for (int q = 0; q < ostatniIndeks; q++)
                    {
                        if (q == ostatniIndeks - 1)
                        {
                            if (zmiennaPomocnicza == 1)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q - 1];
                                punkt zmienny = new punkt(pozycjaKlocka[q].x - 1, pozycjaKlocka[q].y);
                                pozycjaKlocka[q] = zmienny;
                            }
                            else
                            {
                                punkt zmienny = new punkt(pozycjaKlocka[ostatniIndeks - 1].x - 1, pozycjaKlocka[ostatniIndeks - 1].y);
                                pozycjaKlocka[q] = zmienny;
                            }
                        }
                        else
                        if (QueueOfAples.Count == 0)
                        {
                            if (zmiennaPomocnicza == 0)
                            {
                                pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                            }
                        }
                        else
                        if ((pozycjaKlocka[0].x != QueueOfAples.Peek().x || pozycjaKlocka[0].y != QueueOfAples.Peek().y || q != 0) && zmiennaPomocnicza == 0)
                        {
                            pozycjaKlocka[q] = pozycjaKlocka[q + 1];
                        }
                        else
                        if (QueueOfAples.Count != 0)
                        {
                            if (pozycjaKlocka[0].x == QueueOfAples.Peek().x && pozycjaKlocka[0].y == QueueOfAples.Peek().y)
                            {
                                QueueOfAples.Dequeue();
                                ostatniIndeks++;
                                zmiennaPomocnicza = 1;
                            }
                        }
                    }
                    zmiennaPomocnicza = 0;
                }

                for (int ii = 0; ii <= ostatniIndeks - 1; ii++)
                {
                    if (pozycjaKlocka[ostatniIndeks - 1].x == -1 && znak == a)
                    {
                        pozycjaKlocka[ostatniIndeks - 1].x = 119;
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

                int wartoscPionowa = pozycjaKlocka[ostatniIndeks - 1].y;
                int wartoscPozioma = pozycjaKlocka[ostatniIndeks - 1].x;
                int wartoscDecyzyjna = 0;

                for (int iii = 0; iii < ostatniIndeks - 1; iii++)
                {
                    if (pozycjaKlocka[iii].x == wartoscPozioma && pozycjaKlocka[iii].y == wartoscPionowa)
                    {
                        wartoscDecyzyjna = 1;
                    }
                }
                if (wartoscDecyzyjna == 1)
                {
                    Console.Write("PRZEGRALES");
                    Console.ReadKey();
                }

                jablko.WriteAt("@", zmiennaX, zmiennaY);
                Thread.Sleep(50);
                Console.Clear();
            }
        }
    }
}
