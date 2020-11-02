using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureGame
{
    class Dice
    {
        Random r;
        public Dice()
        {
            r = new Random();
        }

        public int d4()
        {
            return r.Next(1, 4);
        }

        public int d6()
        {
            return r.Next(1, 6);
        }

        public int d8()
        {
            return r.Next(1, 8);
        }

        public int d10()
        {
            return r.Next(1, 10);
        }

        public int d12()
        {
            return r.Next(1, 12);
        }

        public int d20()
        {
            return r.Next(1, 20);
        }
    }
}
