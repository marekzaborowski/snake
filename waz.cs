using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snake
{
    class waz
    {
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
                       // Thread.Sleep(1000);
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
