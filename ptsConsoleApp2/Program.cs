using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ptsConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Ivan = 2800, Dimitriy = 999, Danya = 3600;
            int Ilia = 4000;

            Console.Write("Ilia want to play with you. Say your pts:");
            int playerPts = Convert.ToInt32(Console.ReadLine());
            if (playerPts >= Ilia)
            {
                Console.WriteLine("Ilia start game with you");
                ++Ilia;
                ++playerPts;
            }
            else
            {
                Console.WriteLine("Ilia say that your skill is so bad");
                ++Dimitriy;
                ++Danya;
                ++Ivan;
            }
            Console.WriteLine($"Your pts: {playerPts}");

            bool king = (playerPts > Ivan || playerPts > Danya);

            int whoAreYou = Convert.ToInt32(king);
            ++whoAreYou;
            while(whoAreYou >= 1)
            {
                Console.WriteLine("You are the king!");
                whoAreYou--;
            }



            

        }
    }
}
