# DiceGame
<H1>Exercise 10</H1>

Download or clone the C# project DiceGame.

This exercise is about using an existing class, and completing an unfinished class. The solution contains two new classes called Die and DiceCup, in the files Die.cs and DiceCup.cs, respectively.


1.Investigate the Die class. It is complete, and fairly simple.Note that we use another class in the Die class, calledRandom. This class is from the .NET class library, so it is notas such part of the project – it is “given”. Try out the class;create a Die object (in the usual place for inserting code), callthe methods RollDie and GetValue, and print the value youget back. Notice that when you run the program again, youmay get different values, just like for a real die.


2.Investigate the DiceCup class. This class is supposed torepresent a cup with two dice in it. Therefore, the class hastwo instance fields, both of the type Die. The constructor ofthe class has also been completed. However, we would liketo have three public methods in the DiceCup class as well:

  a.RollDice: Should roll both dices in the cup. No value isreturned.
    
  b.GetTotalValue: Should return the total value of the twodice in the cup.
  
  c.IsTotalValueLargerThan: This method should take oneinteger value as input, and return either true or false.The return value should      be true if the total value of thetwo dice is larger than the input value; otherwise, itshould return false.


3.Your job is now to add these three methods to the DiceCupclass. As a help, the “headers” for each method is alreadyincluded as a comment in the class. Once you have comple-ted the methods, you should of course add some code overin InsertCodeHere to test that the completed class works asexpected


4.[Extra – only if you have time] How can you change the gamesuch that it uses 10-sided dice instead? Can you even make itso that the user decides how many sides the dice have?
