using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        // creates three dice objects from the Die class
        public Die die1;
        public Die die2;
        public Die die3;

       public int Play()
        {
            int diceTotal = 0;

            die1 = new Die(); die2 = new Die(); die3 = new Die();

            die1.Roll(); die2.Roll(); die3.Roll(); //rolls three dice using the roll method

            Console.WriteLine("Die 1 = " + die1.diceValue);
            Console.WriteLine("Die 2 = " + die2.diceValue);
            Console.WriteLine("Die 3 = " + die3.diceValue); //outputs the individual dice rolls

            diceTotal += die1.diceValue + die2.diceValue + die3.diceValue;
            Console.WriteLine("Dice total = " +  diceTotal);

            return diceTotal; //returns total
        }
    }
}
