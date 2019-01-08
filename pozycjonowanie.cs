using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class pozycjonowanie
    {
        public static int origRow;
        public static int origCol;

        public void WriteAt(string symbol, int x, int y)
        {
            Console.SetCursorPosition(origCol + x, origRow + y);
            Console.Write(symbol);
        }
    }
}
