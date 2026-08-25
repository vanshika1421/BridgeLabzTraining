using DSA_Test;
namespace Testing
{
    public class Tests
    {

        private ShoppingCart cart;
        private MostRecentsProducts most;
        private SortProductByID sort;

        private SearchProduct search;
        private Payment pay;


        [SetUp]
        public void Setup()
        {
            cart = new ShoppingCart(1, "Laptop", 10, 50000);
            most = new MostRecentsProducts(1, "Laptop", 10, 50000);
            sort = new SortProductByID();
            pay = new Payment();
            search = new SearchProduct();
        }

        [Test]
        public void testing_AddItem_Method()
        {
            LinkedList<Node> l = new LinkedList<Node>();

            LinkedList<Node> list = cart.Additems(l, 6);

            Assert.That(list.Count, Is.EqualTo(1));


        }
        [Test]
        public void test_to_remove_item_from_cart()
        {
            LinkedList<Node> list =
                new LinkedList<Node>();

            list.AddLast(new Node(1));
            list.AddLast(new Node(2));
            list.AddLast(new Node(3));

            // Set Head because RemoveItem uses Head
            cart.Head = list.First.Value;

            cart.RemoveItem(list, 2);

            Assert.That(list.Count, Is.EqualTo(2));
        }

        [Test]
        public void test_to_verify_quantity_increase()
        {
            int quantity = 10;
           int k = cart.increaseQuantity(quantity , 2);
            Assert.That(k, Is.EqualTo(12));
        }
        [Test]
        public void test_to_verify_quantity_decrease()
        {
            int quantity = 10;
            int k = cart.decreaseQuantity(quantity, 2);
            Assert.That(k, Is.EqualTo(8));
        }
        [Test]
        public void test_to_check_most_Recent_Products()
        {
            Stack<Node> stack = new Stack<Node>();
            stack.Push(new Node("Asus Laptop"));
            stack.Push(new Node("Victus Laptop"));
            stack.Push(new Node("Dell Laptop"));
            String ans = most.getLatestViewedProduct(stack);
            Assert.That(ans, Is.EqualTo("Dell Laptop"));

        }

        [Test]
        public void test_to_check_LinkedList_sorting()
        {
            LinkedList<Node> l = new LinkedList<Node>();

            l.AddLast(new Node(4));
            l.AddLast(new Node(2));
            l.AddLast(new Node(1));
            l.AddLast(new Node(3));

            LinkedList<Node> ans = sort.SortById(l);

            Assert.That(ans.First.Value.data, Is.EqualTo(1));
            Assert.That(ans.First.Next.Value.data, Is.EqualTo(2));
            Assert.That(ans.First.Next.Next.Value.data, Is.EqualTo(3));
            Assert.That(ans.Last.Value.data, Is.EqualTo(4));
        }
        [Test]

        public void test_to_check_search_product_method()
        {
            Dictionary<int, String> map = new Dictionary<int, String>();
            map.Add(1, "A");
            map.Add(2, "B");
            map.Add(3, "c");
            map.Add(4, "d");
            String ans = search.SearchProductById(map , 4);
            Assert.That( ans ,Is.EqualTo("d"));


}
        [Test]
        public void test_invalid_product_search()
        {
            Dictionary<int, String> map =
                new Dictionary<int, String>();

            map.Add(1, "A");
            map.Add(2, "B");

            String ans = search.SearchProductById(  map,  99);

            Assert.That( ans,Is.EqualTo(""));
        }
        [Test]
public void test_to_remove_products_from_map()
        {
            Dictionary<int, String> map =
                new Dictionary<int, String>();

            map.Add(1, "A");
            map.Add(2, "B");
            map.Add(3, "c");
            map.Add(4, "d");

            search.RemoveProduct(map, 2);

            Assert.That(map.ContainsKey(2), Is.False);

            Assert.That( map.Count, Is.EqualTo(3));
        }
        [Test]
     
        public void test_to_addProduct_in_dict()
        {
            Dictionary<int, String> map =
                new Dictionary<int, String>();

            search.AddProduct(map,5,"E");

            Assert.That(
                map.ContainsKey(5),
                Is.True);

            Assert.That( map[5], Is.EqualTo("E"));

            Assert.That(map.Count, Is.EqualTo(1));
        }
        [Test]
        public void test_to_check_payment_queue()
        {
            Queue<PaymentNode> queue =   new Queue<PaymentNode>();

            queue.Enqueue( new PaymentNode("Vanshika", 1));

            queue.Enqueue( new PaymentNode("anshika", 2));

            queue.Enqueue(
                new PaymentNode("Vishakha", 3));

            queue.Enqueue(
                new PaymentNode("Kashvi", 4));

            PaymentNode first =   pay.FirstCustomer(queue);

            Assert.That( first.CustomerName,     Is.EqualTo("Vanshika"));

            Assert.That( first.customerId,Is.EqualTo(1));

            Assert.That(queue.Count,  Is.EqualTo(3));
        }
        [Test]
        public void test_empty_payment_queue()
        {
            Queue<PaymentNode> queue = new Queue<PaymentNode>();

            PaymentNode result =  pay.FirstCustomer(queue);

            Assert.That(  result, Is.Null);
        }
        [Test]
        public void test_empty_promotion_carousel()
        {
            PromoCarousel carousel =
                new PromoCarousel();

            Assert.That( carousel.IsEmpty(),   Is.True);

            Assert.That(  carousel.NextPromotion(),
                Is.Null);
        }

        [Test]
        public void integrated_cart_and_checkout_workflow()
        {
            LinkedList<Node> cart =  new LinkedList<Node>();

            Node laptop = new Node( "SKU001","Laptop", 50000,  4.5);

            Node phone =  new Node("SKU002", "Phone",  30000, 4.2);

            cart.AddLast(laptop);
            cart.AddLast(phone);

            cart.First.Value.quantity = 2;

            double total =
                cart.First.Value.quantity *   cart.First.Value.price;

            total +=
                cart.Last.Value.quantity *  cart.Last.Value.price;

            Queue<PaymentNode> queue =
                new Queue<PaymentNode>();

            queue.Enqueue(
                new PaymentNode("Vanshika",  1));

            PaymentNode payment =   pay.FirstCustomer(queue);

            Assert.That(  cart.Count,  Is.EqualTo(2));

            Assert.That( total,  Is.EqualTo(130000));

            Assert.That(   payment.CustomerName,  Is.EqualTo("Vanshika"));

            Assert.That(  queue.Count, Is.EqualTo(0));
        }
        [Test]
        public void test_integrated_product_lookup_to_recently_viewed()
        {
            Dictionary<int, String> map = new Dictionary<int, String>();

            search.AddProduct(map, 5, "iPad");

            String product = search.SearchProductById(map, 5);

            Stack<Node> stack = new Stack<Node>();
            stack.Push(new Node(product));

            String latest = most.getLatestViewedProduct(stack);

            Assert.That(product, Is.EqualTo("iPad"));
            Assert.That(latest, Is.EqualTo("iPad"));
        }


    }
}
    

