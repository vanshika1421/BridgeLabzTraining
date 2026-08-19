//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        ClauseParser parser = new ClauseParser();

//        Console.WriteLine("Legal Contract Clause Extractor");
//        Console.WriteLine("--------------------------------");

//        Console.Write("Enter contract clause: ");
//        string clauseText = Console.ReadLine();

//        Obligation obligation = parser.ExtractObligation(clauseText);

//        Console.WriteLine();
//        Console.WriteLine("Extracted Obligation");
//        Console.WriteLine("--------------------");

//        Console.WriteLine("Owed By: " + obligation.Debtor);
//        Console.WriteLine("Owed To: " + obligation.Creditor);
//        Console.WriteLine("Amount: $" + obligation.Amount);

//        if (obligation.Deadline.HasValue)
//        {
//            Console.WriteLine("Deadline: " + obligation.Deadline.Value);
//        }
//        else
//        {
//            Console.WriteLine("Deadline: Not available");
//        }

//        Console.WriteLine("Original Clause: " + obligation.OriginalClause);


//        Console.ReadLine();
//    }
//}

using System;
using System.Collections.Generic;

class Program
{
    public static void Main(String[] args)
    {
        ClauseParser parser = new ClauseParser();
        ClauseIndex<Obligation> index = new ClauseIndex<Obligation>();

        Console.WriteLine("Legal Contract Clause Extractor");
        Console.WriteLine("--------------------------------");

        while (true)
        {
            Console.Write("\nEnter a contract clause or type exit: ");
            string clauseText = Console.ReadLine() ?? "";

            if (clauseText.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            Obligation obligation = parser.ExtractObligation(clauseText);

            index.Add(
                obligation.Debtor,
                obligation.Creditor,
                obligation
            );

            Console.WriteLine("\nExtracted Obligation");
            Console.WriteLine("--------------------");
            Console.WriteLine("Owed By: " + obligation.Debtor);
            Console.WriteLine("Owed To: " + obligation.Creditor);
            Console.WriteLine("Amount: $" + obligation.Amount);

            if (obligation.Deadline.HasValue)
            {
                Console.WriteLine(
                    "Deadline: " + obligation.Deadline.Value
                );
            }
            else
            {
                Console.WriteLine("Deadline: Not available");
            }
        }

        Console.Write("\nEnter party name to search: ");
        string party = Console.ReadLine() ?? "";

        List<Obligation> owedByParty = index.GetOwedBy(party);
        List<Obligation> owedToParty = index.GetOwedTo(party);

        Console.WriteLine("\nResults for " + party);
        Console.WriteLine("--------------------");

        Console.WriteLine(
            "Number of obligations owed by " + party + ": "
            + owedByParty.Count
        );

        foreach (Obligation obligation in owedByParty)
        {
            Console.WriteLine(
                party + " owes " + obligation.Creditor
                + " $" + obligation.Amount
            );
        }

        Console.WriteLine(
            "\nNumber of obligations owed to " + party + ": "
            + owedToParty.Count
        );

        foreach (Obligation obligation in owedToParty)
        {
            Console.WriteLine(
                obligation.Debtor + " owes " + party
                + " $" + obligation.Amount
            );
        }

        Console.ReadLine();
    }
}
// My implementation includes:
// - User input for a contract clause
// - Contract clause parsing
// - Regex-based extraction of parties, amounts, and dates
// - Identification of the debtor and creditor
// - Monetary amount extraction
// - Absolute date extraction
// - Relative deadline calculation
// - Creation of an Obligation object
// - Storage of extracted obligations using List<Obligation>
// - Basic display of extracted obligation details

// Polished version - additional features:
// - Grouping obligations by the party who owes the money
// - Calculating the total monetary obligation for each party
// - Dictionary-based indexing for efficient retrieval of obligations owed BY a party
// - Dictionary-based indexing for efficient retrieval of obligations owed TO a party