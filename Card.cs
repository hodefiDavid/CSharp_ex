using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_ex
{
    public class Card
    {
        public int Digit;
        public string Color;

        public Card(int digit, string color)
        {
            if (digit < 1 || digit > 9)
            {
                throw new ArgumentException("Digit must be between 1 and 9");
            }

            if (color != "R" && color != "G" && color != "B" && color != "Y")
            {
                throw new ArgumentException("Color must be R, G, B, or Y");
            }

            Digit = digit;
            Color = color;
        }

        public int GetDigit()
        {
            return Digit;
        }

        public string GetColor()
        {
            return Color;
        }
        public override string ToString()
        {
            String res = "[" + Digit + ", " + Color +  "]";
            return res;
        }
    }
}
