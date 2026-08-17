using System;
using System.Text.RegularExpressions;

public class ClauseParser
{
    public Obligation ExtractObligation(string clause)
    {
        string debtor = "";
        string creditor = "";
        double amount = 0;
        DateTime? deadline = null;

        // Debtor
        Match debtorMatch = Regex.Match(
            clause,
            @"(Party\s+[A-Za-z]+)\s+shall"
        );

        if (debtorMatch.Success)
        {
            debtor = debtorMatch.Groups[1].Value;
        }

        // Creditor
        Match creditorMatch = Regex.Match(
            clause,
            @"shall\s+pay\s+(Party\s+[A-Za-z]+)"
        );

        if (creditorMatch.Success)
        {
            creditor = creditorMatch.Groups[1].Value;
        }

        // Amount
        Match amountMatch = Regex.Match(
      clause,
      @"\$(\d+(?:,\d{3})*(?:\.\d{2})?)"
  );

        if (amountMatch.Success)
        {
            string amountText = amountMatch.Groups[1].Value;

            amountText = amountText.Replace(",", "");

            amount = double.Parse(amountText);
        }

        // Date
        Match dateMatch = Regex.Match(
            clause,
            @"(January|February|March|April|May|June|July|August|September|October|November|December)\s+\d{1,2},\s+\d{4}"
        );

        // Number of days
        Match daysMatch = Regex.Match(
            clause,
            @"(\d+)\s+days\s+following"
        );

        if (dateMatch.Success)
        {
            DateTime referenceDate;

            if (DateTime.TryParse(
                dateMatch.Value,
                out referenceDate))
            {
                if (daysMatch.Success)
                {
                    int days = int.Parse(
                        daysMatch.Groups[1].Value
                    );

                    deadline = referenceDate.AddDays(days);
                }
                else
                {
                    deadline = referenceDate;
                }
            }
        }

        return new Obligation(
            debtor,
            creditor,
            amount,
            deadline,
            clause
        );
    }
}