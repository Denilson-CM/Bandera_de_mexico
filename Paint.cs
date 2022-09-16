using System;
using System.Collections.Generic;
using System.Text;

namespace Bandera_de_mexico
{
    class Paint : Body
    {
        protected override int WidthSectors
        {
            get { return 3; }
        }

        protected override void SetupSquare(int x, int y)
        {
            if (IsWidthSector(1, x))
                Console.BackgroundColor = ConsoleColor.Green;
            else if (IsWidthSector(2, x))
                Console.BackgroundColor = ConsoleColor.White;
            else if (IsWidthSector(3, x))
                Console.BackgroundColor = ConsoleColor.Red;
        }
    }
}
