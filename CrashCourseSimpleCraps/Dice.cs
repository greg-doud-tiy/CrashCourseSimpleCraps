using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseSimpleCraps {
    public class Dice {
        public int Dice1 { get; private set; } = 0;
        public int Dice2 { get; private set; } = 0;
        public int Total { get; private set; } = 0;

        public static Dice Roll() {
            Console.WriteLine("Press any key to roll the dice...");
            Console.ReadKey();
            Random rnd = new Random(DateTime.Now.Millisecond);
            Dice dice = new Dice();
            dice.Dice1 = rnd.Next(1, 6);
            dice.Dice2 = rnd.Next(1, 6);
            dice.Total = dice.Dice1 + dice.Dice2;
            Console.WriteLine($"Roll is {dice.Total}");
            return dice;
       }
    }
}
