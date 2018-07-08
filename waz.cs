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

      
    }
}
