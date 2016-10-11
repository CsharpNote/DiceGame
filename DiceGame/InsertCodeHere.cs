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
            Die die1 = new Die();
            Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            die1.RollDie();
            Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            die1.RollDie();
            Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            die1.RollDie();
            Console.WriteLine($"the value of the dice is {die1.GetValue()}");
            die1.RollDie();
            Console.WriteLine($"the value of the dice is {die1.GetValue()}");


            Console.ReadLine();

            // The LAST line of code should be ABOVE this line
        }
    }
}
