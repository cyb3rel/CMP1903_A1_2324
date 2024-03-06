using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */
        public void testGame()
        {
            Game game = new Game(); //creates a new game object
            int test = game.Play(); //calls the play method from the game class

            Debug.Assert(test == (game.die1.diceValue + game.die2.diceValue + game.die3.diceValue),
                 "dice total is incorrect");

            Die dice = new Die();
            int testDie = dice.Roll(); //creates a die object to be tested
            Debug.Assert(testDie >= 1 && testDie <= 6, "die is incorrect"); //checks whether an individual dice roll is within range
        }
    }
}
