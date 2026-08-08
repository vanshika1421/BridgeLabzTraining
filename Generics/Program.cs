class Program
{
    static void Main()
    {
        Storage<Electronics> electronics =
            new Storage<Electronics>();

        electronics.AddItem(
            new Electronics(1, "Laptop"));

        electronics.AddItem(
            new Electronics(2, "Mobile"));

        electronics.DisplayItems();


        Storage<Groceries> groceries =
            new Storage<Groceries>();

        groceries.AddItem(
            new Groceries(3, "Rice"));

        groceries.DisplayItems();
    }
}