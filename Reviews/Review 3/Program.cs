using System;

class Program
{
    static void Main(string[] args)
    {
        ClauseParser parser = new ClauseParser();

        Console.WriteLine("Legal Contract Clause Extractor");
        Console.WriteLine("--------------------------------");

        Console.Write("Enter contract clause: ");
        string clauseText = Console.ReadLine();

        Obligation obligation = parser.ExtractObligation(clauseText);

        Console.WriteLine();
        Console.WriteLine("Extracted Obligation");
        Console.WriteLine("--------------------");

        Console.WriteLine("Owed By: " + obligation.Debtor);
        Console.WriteLine("Owed To: " + obligation.Creditor);
        Console.WriteLine("Amount: $" + obligation.Amount);

        if (obligation.Deadline.HasValue)
        {
            Console.WriteLine("Deadline: " + obligation.Deadline.Value.ToShortDateString());
        }
        else
        {
            Console.WriteLine("Deadline: Not available");
        }

        Console.WriteLine("Original Clause: " + obligation.OriginalClause);

        Console.ReadLine();
    }
}

// My implementation includes:
// - User input
// - Contract clause parsing
// - Regex extraction
// - Party identification
// - Amount extraction
// - Date extraction
// - Relative deadline calculation
// - Obligation creation
// - Basic obligation display

//Polished Version add on features
// Grouping obligations by the party who owes the money
// and calculating the total monetary obligation
// for each party.
//LINQ + Lambda for filtering, sorting, grouping, and totals