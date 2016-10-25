using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashCourseSimpleCraps {
    class Program {
        static void Main(string[] args) {
            Program pgm = new Program();
            pgm.Run();
        }

        private void Run() {
            Console.WriteLine("Simple Craps - A Crash Course from The Iron Yard");
            bool playAgain = true;
            while(playAgain) {

                PlaySimpleCraps();

                playAgain = AskPlayAgain();
            }
        }

        private void PlaySimpleCraps() {
            var thePoint = 0;
            Dice dice = Dice.Roll();
            while(!IsWinnerOrLoser(dice, thePoint)) {
                if(thePoint == 0) {
                    thePoint = dice.Total;
                    Console.WriteLine($"The point is {dice.Total}");
                }
                dice = Dice.Roll();
            }
            if(IsWinner(dice, thePoint)) {
                Console.WriteLine("You Win!!!");
            } if(IsLoser(dice, thePoint)) {
                Console.WriteLine("You Lose ..."); 
            }
        }

        private bool IsWinnerOrLoser(Dice dice, int thePoint) {
            return IsWinner(dice, thePoint) || IsLoser(dice, thePoint);
        }

        private bool IsLoser(Dice dice, int thePoint) {
            return (thePoint == 0) ? dice.Total == 2 || dice.Total == 3 || dice.Total == 12 : dice.Total == 7;
        }

        private bool IsWinner(Dice dice, int thePoint) {
            return (thePoint == 0) ? dice.Total == 7 : dice.Total == thePoint;
        }

        private bool AskPlayAgain() {
            Console.WriteLine("Do you want to play again? (N to quit) ");
            var answer = Console.ReadKey(true);
            return answer.KeyChar.ToString().ToUpper() != "N";
        }
    }
}
