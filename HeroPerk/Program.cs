using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        static void Main(string[] args)
        {
            string perk = args[0];

            Perks playerPerks = 0;

            int countW = 0; 
            int countA = 0; 
            int countS = 0; 
            int countD = 0;

            foreach (char c in perk)
            {
                switch (c)
                {
                    case 'w': countW++; break;
                    case 'a': countA++; break;
                    case 's': countS++; break;
                    case 'd': countD++; break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        return;
                }
            }

            if (countW % 2 != 0) playerPerks |= Perks.WarpShift;
            if (countA % 2 != 0) playerPerks |= Perks.Stealth;
            if (countS % 2 != 0) playerPerks |= Perks.AutoHeal;
            if (countD % 2 != 0) playerPerks |= Perks.DoubleJump;

            Console.Write(playerPerks);
        }
    }
}
