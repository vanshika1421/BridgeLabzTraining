using System.Collections.Generic;

public class ClauseIndex<T>
{
    private readonly Dictionary<string, List<T>> owedBy = new();
    private readonly Dictionary<string, List<T>> owedTo = new();

    public void Add(string debtor, string creditor, T obligation)
    {
        if (!owedBy.TryGetValue(debtor, out List<T>? debtorObligations))
        {
            debtorObligations = new List<T>();
            owedBy[debtor] = debtorObligations;
        }

        debtorObligations.Add(obligation);

        if (!owedTo.TryGetValue(creditor, out List<T>? creditorObligations))
        {
            creditorObligations = new List<T>();
            owedTo[creditor] = creditorObligations;
        }

        creditorObligations.Add(obligation);
    }

    public List<T> GetOwedBy(string party)
    {
        if (owedBy.TryGetValue(party, out List<T>? obligations))
        {
            return obligations;
        }

        return new List<T>();
    }

    public List<T> GetOwedTo(string party)
    {
        return owedTo.TryGetValue(party, out List<T>? obligations)
            ? obligations
            : new List<T>();
    }
}