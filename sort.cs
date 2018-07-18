using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class sort
    {
        public void Metodasortujacatablice(punkt[] pozycjaKlocka, int ostatniIndeks)
        {
            punkt a;
            punkt b;
            int c = 0;

            for (int i = 0; ostatniIndeks > c; i++)
            {
                if(ostatniIndeks == i)
                {
                    i = 0;
                }
                if (CzyPierwszyKlocekWiekszyOdDrugiego(pozycjaKlocka[i], pozycjaKlocka[i + 1]))
                {
                    a = pozycjaKlocka[i];
                    b = pozycjaKlocka[i + 1];
                    pozycjaKlocka[i] = b;
                    pozycjaKlocka[i + 1] = a;
                    c = 0;
                }
                else
                {
                    c++;
                }
            }
        }
        public bool CzyPierwszyKlocekWiekszyOdDrugiego(punkt pierwszy, punkt drugi)
        {
            if (pierwszy.y > drugi.y)
            {               
                return true;
            }
            if (pierwszy.y == drugi.y && pierwszy.x > drugi.x)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
