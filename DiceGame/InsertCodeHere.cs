using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // Step 1 - testing the Die class
            Die aDie = new Die();
            aDie.RollDie();
            Console.WriteLine("Die value is: {0}", aDie.GetValue());
            Console.WriteLine();

            // Step 3 - testing the DiceCup class
            DiceCup aCup = new DiceCup();
            aCup.RollDice();
            Console.WriteLine("Total value in dice cup is: {0}", aCup.GetTotalValue());
            Console.WriteLine();
            Console.WriteLine("Total value is larger than 7: {0}", aCup.IsTotalValueLargerThan(7));
            Console.WriteLine();


            // The LAST line of code should be ABOVE this line
        }
    }
}
