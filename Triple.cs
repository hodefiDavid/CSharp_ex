using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ex
{
    internal class Triple
{
        public int X { get; }
        public int Y { get; }
        public int Z { get; }

        public Triple(int x, int y, int z)
        {
            if (x == y || x == z || y == z)
            {
                throw new ArgumentException("Values must be different");
            }

            X = x;
            Y = y;
            Z = z;
        }

        public bool SameVals(Triple t)
        {
            return (X == t.X || X == t.Y || X == t.Z) &&
                    (Y == t.X || Y == t.Y || Y == t.Z) &&
                    (Z == t.X || Z == t.Y || Z == t.Z);
        }
        public override string ToString()
        {
            String res = "[" + X + ", " + Y + ", " + Z + "]";
            return res;
        }
    }
}

