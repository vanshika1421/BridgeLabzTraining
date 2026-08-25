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


            LinkedList<Node> cart =  new LinkedList<Node>();

            ShoppingCart product =   new ShoppingCart(1,"Laptop", 1,50000);

            Node laptop = new Node("SKU001","Laptop", 50000,   4.5);

            Node phone = new Node("SKU002","Phone",30000,4.2);

            Node tablet = new Node("SKU003", "Tablet", 20000,   4.0);

            product.Additems(cart, laptop);
            product.Additems(cart, phone);
            product.Additems(cart, tablet);

            Console.WriteLine("\nCart:");
            product.Display(cart);

            // Increase quantity
            product.IncreaseItemQuantity(  cart,  1, 2);

            // Decrease quantity
            product.DecreaseItemQuantity(  cart,   2,  1);

            // Move product down
            product.MoveDown(cart, 3);

            Console.WriteLine("\nUpdated Cart:");
            product.Display(cart);

            Console.WriteLine(   "\nTotal = " +  product.CalculateTotal(cart));



            Stack<Node> stack =   new Stack<Node>();

            MostRecentsProducts recent =
                new MostRecentsProducts(3);

            recent.AddViewdProducts( stack,new Node("MacBook"));

            recent.AddViewdProducts(  stack,new Node("Victus Laptop"));

            recent.AddViewdProducts( stack,new Node("iPhone"));

            recent.AddViewdProducts( stack,  new Node("iPad"));

            Console.WriteLine( "\nLatest Viewed: " + recent.getLatestViewedProduct(stack));


            // ---------------- PROMOTIONS ----------------

            PromoCarousel carousel =
                new PromoCarousel();

            carousel.AddPromotion("50% OFF");
            carousel.AddPromotion("Buy 1 Get 1");
            carousel.AddPromotion("20% OFF");

            Console.WriteLine(
                "\nPromotion 1: " +
                carousel.NextPromotion());

            Console.WriteLine(
                "Promotion 2: " +
                carousel.NextPromotion());

            Console.WriteLine(
                "Promotion 3: " +
                carousel.NextPromotion());

            Console.WriteLine(
                "Promotion 4: " +
                carousel.NextPromotion());


            // ---------------- PRODUCT LOOKUP ----------------

            Dictionary<string, Ecommerce> catalog =
                new Dictionary<string, Ecommerce>();

            SearchProduct search =
                new SearchProduct();

            Ecommerce p1 =
                new Ecommerce(
                    "SKU001",
                    "Laptop",
                    50000,
                    4.5);

            Ecommerce p2 =
                new Ecommerce(
                    "SKU002",
                    "Phone",
                    30000,
                    4.2);

            Ecommerce p3 =
                new Ecommerce(
                    "SKU003",
                    "Tablet",
                    20000,
                    4.0);

            catalog.Add(p1.SKU, p1);
            catalog.Add(p2.SKU, p2);
            catalog.Add(p3.SKU, p3);

            Ecommerce result =
                search.SearchProductBySKU(
                    catalog,
                    "SKU001");

            Console.WriteLine(
                "\nProduct Lookup:");

            if (result != null)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid SKU");
            }


            // ---------------- SORTING ----------------

            List<Ecommerce> products =
                new List<Ecommerce>();

            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            SortProductByID sort =
                new SortProductByID();

            sort.SortByPrice(products);

            Console.WriteLine(
                "\nProducts Sorted By Price:");

            foreach (Ecommerce p in products)
            {
                Console.WriteLine(p);
            }

            sort.SortByRating(products);

            Console.WriteLine(
                "\nProducts Sorted By Rating:");

            foreach (Ecommerce p in products)
            {
                Console.WriteLine(p);
            }


            // ---------------- BINARY SEARCH ----------------

            products.Sort(
                (a, b) => String.Compare(
                    a.SKU,
                    b.SKU,
                    StringComparison.Ordinal));

            Ecommerce found =
                sort.BinarySearchBySKU(
                    products,
                    "SKU002");

            Console.WriteLine(
                "\nBinary Search:");

            if (found != null)
            {
                Console.WriteLine(found);
            }
            else
            {
                Console.WriteLine("SKU not found");
            }


            // ---------------- CHECKOUT ----------------

            Payment payment =
                new Payment();

            Queue<PaymentNode> q =
                new Queue<PaymentNode>();

            payment.AddCustomer(
                q,
                new PaymentNode(
                    "Vanshika",
                    1));

            payment.AddCustomer(
                q,
                new PaymentNode(
                    "Anshika",
                    2));

            payment.AddCustomer(
                q,
                new PaymentNode(
                    "Vishakha",
                    3));

            Console.WriteLine(
                "\nCheckout:");

            payment.FirstCustomer(q);
            payment.FirstCustomer(q);
            payment.FirstCustomer(q);

            // Empty queue edge case
            payment.FirstCustomer(q);

            Console.WriteLine(
                "\nProgram completed.");
        }
    }
}