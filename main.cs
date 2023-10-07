using System;

class Program
{
    static void Main()
    {
        decimal salesD = 0, salesE = 0, salesF = 0;

        while (true)
        {
            Console.WriteLine("Enter salesperson initial (D, E, F) or Z to exit:");
            char initial = Char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (initial == 'Z')
            {
                break;
            }

            Console.WriteLine("Enter sale amount:");
            decimal sale = decimal.Parse(Console.ReadLine());

            switch (initial)
            {
                case 'D':
                    salesD += sale;
                    break;
                case 'E':
                    salesE += sale;
                    break;
                case 'F':
                    salesF += sale;
                    break;
                default:
                    Console.WriteLine("Error, invalid salesperson selected, please try again");
                    break;
            }
        }

        decimal grandTotal = salesD + salesE + salesF;
        Console.WriteLine($"Grand Total: ${grandTotal:0,0.00}");

        char highestSalesperson = GetHighestSalesperson(salesD, salesE, salesF);
        Console.WriteLine($"Highest Sale: {highestSalesperson}");
    }

    static char GetHighestSalesperson(decimal salesD, decimal salesE, decimal salesF)
    {
        if (salesD >= salesE && salesD >= salesF)
        {
            return 'D';
        }
        else if (salesE >= salesD && salesE >= salesF)
        {
            return 'E';
        }
        else
        {
            return 'F';
        }
    }
}
