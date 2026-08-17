namespace LegalObligations
{
    public class ContractClause
    {
        public int Id { get; set; }
        public string Text { get; set; } = String.Empty;

        public ContractClause(int id, string text)
        {
            Id = id;
            Text = text;
        }
    }
}