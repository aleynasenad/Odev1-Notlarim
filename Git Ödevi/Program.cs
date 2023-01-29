using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int numRolls;
            int roll;

            Console.WriteLine("Kaç kez zar atmak istersiniz?");
            numRolls = int.Parse(Console.ReadLine());

            for (int i = 0; i < numRolls; i++)
            {
                roll = rand.Next(1, 7);
                Console.WriteLine("Zar: " + roll);
            }

            Console.WriteLine("Oyun bitti!");
            Console.ReadLine();
        }
    }
}
