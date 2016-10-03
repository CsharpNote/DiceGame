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

        // Step 2a: RollDice: Should roll both dices in the cup. No value is returned.
        public void RollDice()
        {
            die1.RollDie();
            die2.RollDie();
        }

        // Step 2b: GetTotalValue: Should return the total value of the two dice in the cup.
        public int GetTotalValue()
        {
            return (die1.GetValue() + die2.GetValue());
        }

        // Step 2c: IsTotalValueLargerThan: This method should take one integer value as input, 
        // and return either true or false. The return value should be true if the total value 
        // of the two dice is larger than the input value; otherwise, it should return false.
        public bool IsTotalValueLargerThan(int value)
        {
            return (GetTotalValue() > value);
        }
    }
}
