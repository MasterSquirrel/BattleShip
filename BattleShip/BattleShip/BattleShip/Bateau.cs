using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Bateau
    {
        public int PosX = 0;
        public int PosY = 0;
        public bool Vertical = false;
        public int Longeur = 3;

        public Bateau(int X, int Y, bool Orientation, int Long)
        {
            PosX = X;
            PosY = Y;
            Vertical = Orientation;
            Longeur = Long;
        }
    }
}
