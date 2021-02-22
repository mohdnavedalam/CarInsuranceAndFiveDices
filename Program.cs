using System;

namespace CarInsuranceAndFiveDices
{
    class Program
    {
        static void Main(string[] args)
        {
            FiveDiceProblem _diceProblem = new FiveDiceProblem();
            CarInsurancePremiumCalculator _premium = new CarInsurancePremiumCalculator();

            Console.WriteLine("Welcome to the Program");
            Console.WriteLine("Press 1 for Five Dices Problem.");
            Console.WriteLine("Press 2 for Car insurance Premium Calculator.");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    _diceProblem.RollTheFiveDices();
                    break;

                case 2:
                    _premium.CalculatePremium();
                    break;

                default:
                    Console.WriteLine("Wrong Choice. Please choose 1 or 2...");
                    break;
            }
        }
    }
}
