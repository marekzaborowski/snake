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


            punkt[] pozycjaKlocka;
            int ostatniIndeks = 4;
            pozycjaKlocka = new punkt[ostatniIndeks];

            while (true)
            {
                char znak='g';
                char f='f';
                char r = 'r';
                char d = 'd';
                char g = 'g';

                for (int i = 0, j = 0; 1 < 2;)
                    {
                    if (Console.KeyAvailable)
                    {
                        znak = Console.ReadKey(true).KeyChar;
                    }
                    if (znak == g)
                    {
                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i + 1, j);
                        punkt punkt3 = new punkt(i + 2, j);
                        punkt punkt4 = new punkt(i + 3, j);
                        i++;
                        pozycjaKlocka[0] = punkt1;
                        pozycjaKlocka[1] = punkt2;
                        pozycjaKlocka[2] = punkt3;
                        pozycjaKlocka[3] = punkt4;
                    }
                    if (znak == f)
                    {
                        
                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i, j+1);
                        punkt punkt3 = new punkt(i, j+2);
                        punkt punkt4 = new punkt(i, j+3);
                        j++;
                        pozycjaKlocka[0] = punkt1;
                        pozycjaKlocka[1] = punkt2;
                        pozycjaKlocka[2] = punkt3;
                        pozycjaKlocka[3] = punkt4;
                    }
                    if (znak == r)
                    {

                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i, j + 1);
                        punkt punkt3 = new punkt(i, j+2);
                        punkt punkt4 = new punkt(i, j+3);
                        j--;
                        pozycjaKlocka[0] = punkt1;
                        pozycjaKlocka[1] = punkt2;
                        pozycjaKlocka[2] = punkt3;
                        pozycjaKlocka[3] = punkt4;
                    }
                    if (znak == d)
                    {

                        punkt punkt1 = new punkt(i, j);
                        punkt punkt2 = new punkt(i + 1, j);
                        punkt punkt3 = new punkt(i + 2, j);
                        punkt punkt4 = new punkt(i + 3, j);
                        i--;
                        pozycjaKlocka[0] = punkt1;
                        pozycjaKlocka[1] = punkt2;
                        pozycjaKlocka[2] = punkt3;
                        pozycjaKlocka[3] = punkt4;
                    }
                    


                    


                    s.Metodasortujacatablice(pozycjaKlocka, ostatniIndeks - 1);
                    w.MetodaNowegoSpojrzeniaNaKonsole(pozycjaKlocka, ostatniIndeks - 1);


                    Thread.Sleep(100);
                    Console.Clear();
                    }
            }
            /*punkt punkt1 = new punkt(1, 1);
            punkt punkt2 = new punkt(2, 1);
            punkt punkt3 = new punkt(2, 1);
            punkt punkt4 = new punkt(3, 1);

            punkt[] pozycjaKlocka;
            int ostatniIndeks = 2;
            pozycjaKlocka = new punkt[ostatniIndeks];

            pozycjaKlocka[0] = punkt1;
            pozycjaKlocka[1] = punkt2;

            punkt[] pozycjaKlocka2;
            int ostatniIndeks2 = 2;
            pozycjaKlocka2 = new punkt[ostatniIndeks2];

            pozycjaKlocka2[0] = punkt3;
            pozycjaKlocka2[1] = punkt4;

            sort s = new sort();
            sort s2 = new sort();
            waz w = new waz();
            waz w2 = new waz();

            s.Metodasortujacatablice(pozycjaKlocka, ostatniIndeks - 1);
            w.MetodaNowegoSpojrzeniaNaKonsole(pozycjaKlocka, ostatniIndeks-1);
         
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(3000);
            s2.Metodasortujacatablice(pozycjaKlocka2, ostatniIndeks2 - 1);
            w2.MetodaNowegoSpojrzeniaNaKonsole(pozycjaKlocka2, ostatniIndeks2 - 1);
            Console.ReadLine(); */
        }
    }
}
