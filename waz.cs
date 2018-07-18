using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class waz
    {
        public void MetodaPozycyjna(int wysokosc, int szerokosc, int kierunek)
        {
            if(kierunek == 4)
            {
                for (int i = 0; i < wysokosc - 3; i++)
                {
                    Console.WriteLine();
                }
                //Console.WriteLine("^");
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < szerokosc; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("^");
                }
            }
            else
            for (int i = 0; i < wysokosc; i++)
            {
                Console.WriteLine();
            }
            if (kierunek == 3)
            {
                for (int j = 0; j < szerokosc - 3; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("<");
                Console.Write("<");
                Console.Write("<");
            }
            else
            for (int j = 0; j < szerokosc; j++)
            {   
                Console.Write(" ");
            }
            if (kierunek == 1)
            {
                for (int q = 0; q < 3; q++)
                {
                    Console.WriteLine("v");
                    for (int j = 0; j < szerokosc; j++)
                    {
                        Console.Write(" ");
                    }
                }

            }
            if(kierunek == 2)
            {
                Console.Write(">");
                Console.Write(">");
                Console.Write(">");
            }
             
        }
        public void MetodaWypisujacaSkosnegoWeza(int szerokosc)
        {
            Console.WriteLine("@");
            
            //etap pierwszy
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("@@");

                szerokosc++;

                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("@@");

                for (int j = 0; j < szerokosc+1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("@");

            

            }

            //etap druga
            for (int i = 0; i < 1; i++)
            {
                szerokosc--;
                for (int j = 0; j < szerokosc + 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("@@");

                szerokosc--;

                for (int j = 0; j < szerokosc + 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("@@");

                szerokosc++;

                for (int j = 0; j < szerokosc; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("@");
            }

        }
        // rozwiazanie z tablica jednowymiarowa
        public void MetodaNowegoSpojrzeniaNaKonsole(punkt[] pozycjaKlocka, int ostatniIndeks)
        {
            for (int j = 0, k =0, l=0, i = 0; j <= pozycjaKlocka[ostatniIndeks].y;)
            {
                if (k == pozycjaKlocka[i].x)
                {
                    if(i == -1)
                    {
                        Console.Write(">");
                    }
                    else
                    {
                        Console.Write("@");
                    }                   
                    if (i != ostatniIndeks+1)
                    {
                        i++;
                    }
                    if (l != ostatniIndeks)
                    {
                        l++;
                    }
                    k++;                    
                }
                else
                {
                    Console.Write(" ");
                    k++;
                }
                if (j != pozycjaKlocka[l].y)
                {
                    Console.WriteLine();
                    j++;
                    k = 0;
                }
                if (pozycjaKlocka[ostatniIndeks].y == j && i == ostatniIndeks+1)
                {
                    j++;
                }
            }
        }
    }
}
