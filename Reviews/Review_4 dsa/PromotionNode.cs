namespace DSA_Test;
public class PromotionNode
{
    public string Promotion;
    public PromotionNode Next;

    public PromotionNode(string promotion)
    {
        Promotion = promotion;
        Next = null;
    }
}