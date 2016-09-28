using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class DiceCup
    {
        private Die die1;
        private Die die2;

        public DiceCup()
        {
            // VERY IMPORTANT! When we have instance fields of a class type,
            // we MUST remember to create actual objects in the constructor,
            // that the instance fields can then point to.
            die1 = new Die();
            die2 = new Die();
        }

        // You must create a method with the below header:
        // public void RollDice()

        // You must create a method with the below header:
        // public int GetTotalValue()

        // You must create a method with the below header:
        // public bool IsTotalValueLargerThan(int value)
    }
}
