using System;

namespace CarInsuranceAndFiveDices
{
    class FiveDiceProblem
    {
        internal void RollTheFiveDices()
        {
            Console.WriteLine("Welcome to the Five Dices Problem");
            Console.WriteLine("Roll the Dice (Press a Key):");
            Console.ReadKey();

            Random _random = new Random();

            int diceOne = _random.Next(1, 6);
            Console.WriteLine("Dice 1 - {0}", diceOne);

            int diceTwo = _random.Next(1, 6);
            Console.WriteLine("Dice 2 - {0}", diceTwo);

            int diceThree = _random.Next(1, 6);
            Console.WriteLine("Dice 3 - {0}", diceThree);

            int diceFour = _random.Next(1, 6);
            Console.WriteLine("Dice 4 - {0}", diceFour);

            int diceFive = _random.Next(1, 6);
            Console.WriteLine("Dice 5 - {0}", diceFive);

            int SumOfRolls = diceOne + diceTwo + diceThree + diceFour + diceFive;
            Console.WriteLine("Sum of the Rolls - {0}", SumOfRolls);
        }
    }
}
