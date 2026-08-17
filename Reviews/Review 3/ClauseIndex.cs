using System.Collections.Generic;

public class ClauseIndex<T>
{
    private Dictionary<string, List<T>> owedBy;
    private Dictionary<string, List<T>> owedTo;

    public ClauseIndex()
    {
        owedBy = new Dictionary<string, List<T>>();
        owedTo = new Dictionary<string, List<T>>();
    }

    public void Add(string debtor, string creditor, T obligation)
    {
        if (!owedBy.ContainsKey(debtor))
        {
            owedBy[debtor] = new List<T>();
        }

        owedBy[debtor].Add(obligation);

        if (!owedTo.ContainsKey(creditor))
        {
            owedTo[creditor] = new List<T>();
        }

        owedTo[creditor].Add(obligation);
    }

    public List<T> GetOwedBy(string party)
    {
        if (owedBy.ContainsKey(party))
        {
            return owedBy[party];
        }

        return new List<T>();
    }

    public List<T> GetOwedTo(string party)
    {
        if (owedTo.ContainsKey(party))
        {
            return owedTo[party];
        }

        return new List<T>();
    }
}