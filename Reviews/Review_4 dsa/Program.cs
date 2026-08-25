using System;
using System.Collections.Generic;

namespace DSA_Test
{
    public class Program
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("E-Commerce System");
            Console.WriteLine("------------------");


            LinkedList<Node> cart = new LinkedList<Node>();
            ShoppingCart product = new ShoppingCart(1, "Laptop", 1, 50000);

            Console.Write("\nEnter number of products to add to cart: ");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nEnter SKU: ");
                string sku = Console.ReadLine();

                Console.Write("Enter product name: ");
                string name = Console.ReadLine();

                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter rating: ");
                double rating = Convert.ToDouble(Console.ReadLine());

                Node node = new Node(sku, name, price, rating);
                product.Additems(cart, node);
            }

            Console.WriteLine("Cart:");
            product.Display(cart);


            if (cart.Count > 0)
            {
                Console.Write("\nEnter SKU to increase quantity: ");
                string increaseSKU = Console.ReadLine();

                Console.Write("Enter quantity to increase: ");
                int increaseQuantity = Convert.ToInt32(Console.ReadLine());

                product.IncreaseItemQuantity(cart, 1, increaseQuantity);

                Console.Write("\nEnter SKU to decrease quantity: ");
                string decreaseSKU = Console.ReadLine();

                Console.Write("Enter quantity to decrease: ");
                int decreaseQuantity = Convert.ToInt32(Console.ReadLine());

                product.DecreaseItemQuantity(cart, 2, decreaseQuantity);
            }


            if (cart.Count > 1)
            {
                Console.Write("\nEnter product ID to move down: ");
                int moveId = Convert.ToInt32(Console.ReadLine());

                product.MoveDown(cart, moveId);
            }

            Console.WriteLine("\nUpdated Cart:");
            product.Display(cart);

            Console.WriteLine("\nTotal = " + product.CalculateTotal(cart));


            Stack<Node> stack = new Stack<Node>();

            Console.Write("\nEnter maximum recently viewed history size: ");
            int historySize = Convert.ToInt32(Console.ReadLine());

            MostRecentsProducts recent = new MostRecentsProducts(historySize);

            Console.Write("Enter number of recently viewed products: ");
            int viewedCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < viewedCount; i++)
            {
                Console.Write("Enter recently viewed product name: ");
                string viewedProduct = Console.ReadLine();

                recent.AddViewdProducts(stack, new Node(viewedProduct));
            }

            Console.WriteLine("\nLatest Viewed: " + recent.getLatestViewedProduct(stack));


            PromoCarousel carousel = new PromoCarousel();

            Console.Write("\nEnter number of promotions: ");
            int promotionCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < promotionCount; i++)
            {
                Console.Write("Enter promotion " + (i + 1) + ": ");
                string promotion = Console.ReadLine();

                carousel.AddPromotion(promotion);
            }

            if (!carousel.IsEmpty())
            {
                Console.WriteLine("\nPromotions:");

                for (int i = 0; i < promotionCount + 1; i++)
                {
                    Console.WriteLine("Promotion " + (i + 1) + ": " + carousel.NextPromotion());
                }
            }
            else
            {
                Console.WriteLine("\nNo promotions available.");
            }


            Dictionary<string, Ecommerce> catalog = new Dictionary<string, Ecommerce>();
            SearchProduct search = new SearchProduct();

            Console.Write("\nEnter number of products in catalog: ");
            int catalogCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < catalogCount; i++)
            {
                Console.Write("\nEnter SKU: ");
                string sku = Console.ReadLine();

                Console.Write("Enter product name: ");
                string name = Console.ReadLine();

                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter rating: ");
                double rating = Convert.ToDouble(Console.ReadLine());

                Ecommerce p = new Ecommerce(sku, name, price, rating);

                if (!catalog.ContainsKey(sku))
                {
                    catalog.Add(sku, p);
                }
                else
                {
                    Console.WriteLine("SKU already exists.");
                }
            }


            Console.Write("\nEnter SKU to search: ");
            string searchSKU = Console.ReadLine();

            Ecommerce result = search.SearchProductBySKU(catalog, searchSKU);

            Console.WriteLine("\nProduct Lookup:");

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid SKU");
            }



            List<Ecommerce> products = new List<Ecommerce>(catalog.Values);
            SortProductByID sort = new SortProductByID();

            sort.SortByPrice(products);

            Console.WriteLine("\nProducts Sorted By Price:");

            foreach (Ecommerce p in products)
            {
                Console.WriteLine(p);
            }

            sort.SortByRating(products);

            Console.WriteLine("\nProducts Sorted By Rating:");

            foreach (Ecommerce p in products)
            {
                Console.WriteLine(p);
            }


            products.Sort((a, b) => String.Compare(a.SKU, b.SKU, StringComparison.Ordinal));

            Console.Write("\nEnter SKU for Binary Search: ");
            string binarySKU = Console.ReadLine();

            Ecommerce found = sort.BinarySearchBySKU(products, binarySKU);

            Console.WriteLine("\nBinary Search:");

            if (found != null)
            {
                Console.WriteLine(found);
            }
            else
            {
                Console.WriteLine("SKU not found");
            }



            Payment payment = new Payment();
            Queue<PaymentNode> q = new Queue<PaymentNode>();

            Console.Write("Enter number of customers for checkout: ");
            int customerCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < customerCount; i++)
            {
                Console.Write("Enter customer name: ");
                string customerName = Console.ReadLine();

                Console.Write("Enter customer ID: ");
                int customerId = Convert.ToInt32(Console.ReadLine());

                payment.AddCustomer(q, new PaymentNode(customerName, customerId));
            }

            Console.WriteLine("\nCheckout:");

            while (q.Count > 0)
            {
                payment.FirstCustomer(q);
            }

    
            payment.FirstCustomer(q);

            Console.WriteLine("Program completed.");
        }
    }
}
