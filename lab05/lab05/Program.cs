using System;
using ClassLibrary1;
class Program
{
    static void Main()
    {
        Town[] arrTowns;

        Console.Write("Введiть кiлькiсть мiст: ");
        int cntTowns = int.Parse(Console.ReadLine());

        arrTowns = new Town[cntTowns];

        for (int i = 0; i < cntTowns; i++)
        {
            Console.Write("Введiть назву мiста: ");
            string sName = Console.ReadLine();

            Console.Write("Введiть назву краiни: ");
            string sCountry = Console.ReadLine();

            Console.Write("Введiть назву регiону: ");
            string sRegion = Console.ReadLine();

            Console.Write("Введiть кiлькiсть населення: ");
            int sPopulation = int.Parse(Console.ReadLine());

            Console.Write("Введiть рiчний дохiд: ");
            double sYearIncome = double.Parse(Console.ReadLine());

            Console.Write("Введiть площу, кв. км: ");
            double sSquare = double.Parse(Console.ReadLine());

            Console.Write("Чи є у мiстi порт? (y-так, n-нi): ");
            bool hasPort = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            Console.Write("Чи є у мiстi аеропорт? (y-так, n-нi): ");
            bool hasAirport = Console.ReadKey().Key == ConsoleKey.Y;
            Console.WriteLine();

            arrTowns[i] = new Town
            {
                Name = sName,
                Country = sCountry,
                Region = sRegion,
                Population = sPopulation,
                YearIncome = sYearIncome,
                Square = sSquare,
                HasPort = hasPort,
                HasAirport = hasAirport
            };
        }

        foreach (Town t in arrTowns)
        {
            Console.WriteLine();
            Console.WriteLine($"Данi про мiсто {t.Name}");
            Console.WriteLine();
            Console.WriteLine("Країна: " + t.Country);
            Console.WriteLine("Регiон: " + t.Region);
            Console.WriteLine("Кiлькiсть населення: " + t.Population);
            Console.WriteLine("Рiчний дохiд: " + t.YearIncome.ToString("0.00"));
            Console.WriteLine("Площа: " + t.Square.ToString("0.000"));
            Console.WriteLine(t.HasPort ? "У мiстi є порт" : "У мiстi нема порту");
            Console.WriteLine(t.HasAirport ? "У мiстi є аеропорт" : "У мiстi нема аеропорту");
            Console.WriteLine();
            Console.WriteLine("Середнiй рiчний дохiд на одного громадянина: " + t.yearIncomePerInhabitant.ToString("0.00"));
        }

        Console.ReadKey();
    }
}