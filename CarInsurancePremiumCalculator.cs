using System;

namespace CarInsuranceAndFiveDices
{
    class CarInsurancePremiumCalculator
    {
        internal void CalculatePremium()
        {
            Console.WriteLine("Welcome to Car Insurance Premium Calculator");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

            DateTime _datetime = DateTime.Now;
            Console.WriteLine("Enter Values:");

            Console.WriteLine("Model and Make : ");
            string modelAndMake = Console.ReadLine();

            Console.WriteLine("Ex Showroom Price : ");
            int exShowroomPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Year of Manufacture : ");
            int yearOfManufacture = Convert.ToInt32(Console.ReadLine());

            int currentYear = _datetime.Year;
            int numberOfYears = 0;

            if (yearOfManufacture == currentYear)
                numberOfYears = 1;
            else
                numberOfYears = currentYear - yearOfManufacture;

            int depreciationPercentageValue = exShowroomPrice * 10 / 100 * numberOfYears;

            int insuredDeclaredValue = exShowroomPrice - depreciationPercentageValue;

            int ownDamagePremium = 6500;

            int noClaimBonus = ownDamagePremium * 20 / 100;

            int totalODPremium = ownDamagePremium - noClaimBonus;

            int personalAccidentCover = 100;

            int legalLiabilityPaidToDriver = 50;

            int compulsoryThirdPartyCover = 1100;

            int netPremium = totalODPremium + personalAccidentCover + legalLiabilityPaidToDriver + compulsoryThirdPartyCover;

            int gstAt18Percent = netPremium * 18 / 100;

            int totalPremium = netPremium + gstAt18Percent;

            Console.WriteLine("Premium for the year {0} is Rs. {1}", currentYear, totalPremium);

            Console.ReadKey();
        }
    }
}
