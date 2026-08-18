public class Obligation
{
    public string Debtor { get; set; }
    public string Creditor { get; set; }
    public double Amount { get; set; }

    public DateTime? Deadline { get; set; }

    public string OriginalClause { get; set; }

    public Obligation(string debtor,string creditor,double amount,DateTime? deadline,string originalClause)
    {
        Debtor = debtor;
        Creditor = creditor;
        Amount = amount;
        Deadline = deadline;
        OriginalClause = originalClause;
    }

    
}