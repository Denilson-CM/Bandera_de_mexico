using System;
using System.Collections.Generic;
using System.Text;

namespace Bandera_de_mexico
{
    abstract class Body
    {
        public virtual int Width
        {
            get { return 79; }
        }
        public virtual int Height
        {
            get { return 24; }
        }
        protected virtual int WidthSectors
        {
            get { return 1; }
        }
        protected virtual int HeightSectors
        {
            get { return 1; }
        }
        protected bool IsWidthSector(int sector, int value)
        {
            int sectorWidth = Width / WidthSectors;
            return value >= sectorWidth * Math.Max(sector - 1, 0)
              && value < sectorWidth * sector;
        }
        protected bool IsHeightSector(int sector, int value)
        {
            int sectorHeight = Height / HeightSectors;
            return value >= sectorHeight * Math.Max(sector - 1, 0)
              && value < sectorHeight * sector;
        }
        protected void SetupEdgeSquare()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
        }
        protected abstract void SetupSquare(int x, int y);
        public void Draw()
        {
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Console.ResetColor();
                    if (x == 0 || x == Width - 1 || y == 0 || y == Height - 1)
                        SetupEdgeSquare();
                    else
                        SetupSquare(x, y);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
    
}
