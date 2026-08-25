# E-Commerce Cart & Recently Viewed System

## Project Overview

This project is a console-based E-Commerce System developed in C# to demonstrate the practical application of Data Structures and Algorithms.

The system integrates multiple data structures to implement common e-commerce operations such as:

- Shopping cart management
- Recently viewed products
- Promotional carousel
- Product lookup
- Product sorting
- Binary search
- Checkout and payment processing

The main objective of the project is to select an appropriate data structure for each requirement and integrate the different structures into a single e-commerce application.

---

# Problem Statement

Build an e-commerce system supporting:

1. Shopping cart management using a doubly linked list.
2. Recently viewed products using a stack.
3. Promotional carousel using a circular linked list.
4. Checkout using a queue.
5. Product lookup using a hash-based dictionary.
6. Sorting products by price and rating.
7. Binary search of products using SKU.
8. Integration of all data structures.
9. Handling of required edge cases.
10. Automated testing using NUnit.

---

# Objectives

The main objectives of this project are:

1. Implement a shopping cart using a doubly linked list.
2. Implement recently viewed products using a stack.
3. Implement a promotional carousel using a circular linked list.
4. Implement checkout using a queue.
5. Implement product lookup using a dictionary.
6. Implement sorting based on product price and rating.
7. Implement binary search on products sorted by SKU.
8. Integrate the data structures into complete workflows.
9. Handle empty and invalid cases.
10. Validate the implementation using NUnit tests.

---

# Features

The system provides the following features:

- Add products to the shopping cart
- Remove products from the shopping cart
- Increase product quantity
- Decrease product quantity
- Move products within the cart
- Display cart contents
- Calculate total cart value
- Maintain recently viewed products
- Limit recently viewed history
- Cycle through promotional offers
- Add customers to checkout
- Process customers using FIFO order
- Add products to the product catalog
- Search products using SKU
- Remove products from the catalog
- Sort products by price
- Sort products by rating
- Search products using binary search
- Handle invalid product searches
- Handle empty checkout queues
- Handle empty promotion carousels
- Perform automated NUnit testing

---

# Data Structures Used

| Requirement | Data Structure |
|---|---|
| Shopping Cart | Doubly Linked List |
| Recently Viewed Products | Stack |
| Promotional Carousel | Circular Linked List |
| Checkout | Queue |
| Product Lookup | Dictionary |
| Product Sorting | Sorting Algorithm |
| SKU Search | Binary Search |

---

# System Design

The application is divided into modules. Each module uses a data structure suitable for the operation it performs.

```text
                         E-COMMERCE SYSTEM
                                |
             +------------------+------------------+
             |                  |                  |
             v                  v                  v
       Shopping Cart     Recently Viewed    Promotional
       Doubly Linked          Stack           Carousel
           List                              Circular List
             |                  |                  |
             +------------------+------------------+
                                |
                                v
                         Product Catalog
                                |
                    +-----------+-----------+
                    |                       |
                    v                       v
                Dictionary             Sorting/Search
                    |                       |
                    +-----------+-----------+
                                |
                                v
                         Checkout Queue
                                |
                                v
                        Payment Processing
1. Shopping Cart
Data Structure
The shopping cart is implemented using a doubly linked list.
Each product is represented using a Node.
HEAD
 |
 v
[Tablet] <-> [Phone] <-> [Laptop]
                              |
                             NULL
Each node stores product information such as:
- SKU
- Product name
- Quantity
- Price
- Rating
- Previous node
- Next node
Operations
The shopping cart supports:
- Adding products
- Removing products
- Increasing quantity
- Decreasing quantity
- Moving products
- Displaying cart contents
- Calculating total price
Why Doubly Linked List?
A doubly linked list is suitable because cart items can be traversed in both directions using the prev and next references.
The structure also supports movement of products up and down the cart.
The ShoppingCart class manages cart-related operations.
2. Recently Viewed Products
Data Structure
Recently viewed products are implemented using a Stack.
TOP
 |
 v
[iPad]
[iPhone]
[Victus Laptop]
[MacBook]
The latest viewed product is placed on top of the stack.
Why Stack?
A stack follows the LIFO principle:
Last In -> First Out
This matches the requirement because the most recently viewed product should be retrieved first.
Operations
The recently viewed module supports:
- Adding viewed products
- Retrieving the latest viewed product
- Maintaining a maximum history size
- Evicting older products when the maximum size is reached
The MostRecentsProducts class manages recently viewed products.
3. Promotional Carousel
Data Structure
The promotional carousel uses a Circular Linked List.
       +-----------------------+
       |                       |
       v                       |
[50% OFF] -> [Buy 1 Get 1] -> [20% OFF]
       ^                       |
       |_______________________|
The last promotion points back to the first promotion.
Why Circular Linked List?
A promotional carousel should continuously cycle through promotions.
For example:
50% OFF
   |
   v
Buy 1 Get 1
   |
   v
20% OFF
   |
   v
50% OFF
   |
   v
Buy 1 Get 1
The circular structure allows the promotions to repeat without reaching a normal end node.
The PromoCarousel class manages promotional operations.
4. Checkout
Data Structure
Checkout is implemented using a Queue.
FRONT                              REAR
  |                                  |
  v                                  v
[Vanshika] -> [Anshika] -> [Vishakha]
Customers are added to the rear and processed from the front.
Why Queue?
A queue follows the FIFO principle:
First In -> First Out
Therefore, the customer who enters checkout first is processed first.
Operations
The checkout module supports:
- Adding customers
- Processing the first customer
- Handling an empty checkout queue
The Payment class manages checkout operations, while PaymentNode represents a customer.
5. Product Lookup
Data Structure
Product lookup uses a C# Dictionary.
SKU001 -> Laptop
SKU002 -> Phone
SKU003 -> Tablet
The SKU acts as the unique key and the corresponding product is stored as the value.
Why Dictionary?
A dictionary provides average-case O(1) lookup for key-based operations.
The SearchProduct class manages product lookup operations.
Operations
- Add product
- Search product by SKU
- Remove product
- Handle invalid SKU
Example:
SearchProductBySKU(catalog, "SKU001")
returns the product associated with SKU001.
6. Sorting
The product catalog contains Ecommerce objects.
Products can be sorted according to:
- Price
- Rating
Example:
Before Sorting:

Laptop   50000
Phone    30000
Tablet   20000
After sorting by price:
Tablet   20000
Phone    30000
Laptop   50000
The sorting functionality is provided by the SortProductByID class.
7. Binary Search
Binary search is used to search for a product using its SKU.
Before binary search is performed, the product collection is sorted according to SKU.
Example:
SKU001
SKU002
SKU003
SKU004
SKU005
Binary search repeatedly divides the search range into two parts.
             SKU003
            /     \
       Smaller    Larger
Important Requirement
Binary search requires the collection to be sorted according to the same value being searched.
In this project, products are sorted by SKU before BinarySearchBySKU() is called.
Complexity
Time Complexity: O(log n)
Space Complexity: O(1)
8. Integration
The different data structures are integrated into the same e-commerce application rather than being implemented as completely independent examples.
Integrated Workflow 1: Product Lookup -> Recently Viewed
User searches SKU
       |
       v
Dictionary Lookup
       |
       v
Product Found
       |
       v
Product Viewed
       |
       v
Recently Viewed Stack
Example:
SKU001
  |
  v
Laptop found
  |
  v
Laptop viewed
  |
  v
Laptop added to recently viewed stack
This workflow demonstrates interaction between:
- Dictionary
- Product lookup
- Stack
- Recently viewed products
Integrated Workflow 2: Shopping Cart -> Checkout
User selects products
       |
       v
Shopping Cart
       |
       v
Calculate Total
       |
       v
Checkout Queue
       |
       v
FIFO Payment Processing
Example:
Laptop + Phone
      |
      v
Shopping Cart
      |
      v
Calculate Total
      |
      v
Customer enters checkout
      |
      v
Queue
      |
      v
Payment processed
This workflow demonstrates interaction between:
- Doubly linked list
- Cart operations
- Total calculation
- Queue
- Payment processing
9. Edge Cases
The project handles the required edge cases.
Empty Cart
The system can handle a cart containing no products without attempting to process nonexistent cart items.
Quantity Handling
The system supports increasing and decreasing product quantity through the shopping cart operations.
Recently Viewed History Limit
The recently viewed module supports a maximum history size. When the limit is reached, older entries can be evicted according to the implemented logic.
Empty Checkout Queue
The system handles an empty checkout queue without attempting to process a nonexistent customer.
Example:
Checkout queue is empty
Invalid SKU
If a SKU does not exist in the product dictionary, the search returns a not-found result instead of processing an invalid product.
Example:
SKU not found
Empty Promotions
The promotional carousel checks whether it is empty before retrieving the next promotion.
10. Classes and Responsibilities
Class	Responsibility
Program	Main application flow and user interaction
Node	Represents cart/product node
ShoppingCart	Shopping cart operations and total calculation
MostRecentsProducts	Recently viewed product management
PromoCarousel	Promotional carousel operations
Ecommerce	Product information
SearchProduct	Product lookup operations
SortProductByID	Sorting and binary search
PaymentNode	Represents checkout customer
Payment	Checkout/payment processing


11. NUnit Testing
The project uses NUnit for automated testing.
The provided test suite contains more than the required minimum of 10 tests and includes normal, invalid, empty, and integrated test cases.
Test Coverage
Shopping Cart
- Add item
- Remove item
- Increase quantity
- Decrease quantity
Recently Viewed Products
- Verify latest viewed product
Sorting
- Verify sorting functionality
Product Lookup
- Search product
- Invalid product search
- Add product
- Remove product
Checkout
- Verify FIFO payment processing
- Empty payment queue
Promotional Carousel
- Empty promotion carousel
Integrated Workflows
- Cart and checkout workflow
- Product lookup and recently viewed workflow
12. Testing Summary
The NUnit tests cover:
- Normal cases
- Invalid cases
- Empty cases
- Shopping cart operations
- Stack operations
- Queue operations
- Dictionary operations
- Sorting
- Integrated workflows
The test suite satisfies the requirement of having at least 10 NUnit tests.
13. Complexity Analysis
Shopping Cart
Operation	Time Complexity
Add at beginning/end	O(1)
Search product	O(n)
Remove by product ID	O(n)
Increase quantity	O(n)
Decrease quantity	O(n)
Display cart	O(n)
Calculate total	O(n)


Searching for a specific item requires traversal of the linked list, resulting in O(n) time.
Recently Viewed Stack
Operation	Time Complexity
Push	O(1)
Pop	O(1)
Peek	O(1)
Traverse	O(n)


Promotional Carousel
Operation	Time Complexity
Check empty	O(1)
Get next promotion	O(1)
Display promotions	O(n)


The exact insertion complexity depends on how the circular list maintains its last/current node.
Checkout Queue
Operation	Time Complexity
Enqueue	O(1)
Dequeue	O(1)
Check empty	O(1)


Dictionary
Average-case complexity:
Operation	Time Complexity
Add	O(1)
Search	O(1)
Remove	O(1)


Dictionary operations can have O(n) worst-case behavior, but average-case performance is O(1).
Sorting
The sorting complexity depends on the sorting algorithm implemented in SortProductByID.
For a nested comparison-based sorting implementation:
Time Complexity: O(n²)
Space Complexity: O(1)
Binary Search
Operation	Time Complexity
Binary Search	O(log n)


Space complexity for the iterative implementation:
O(1)
14. Overall Space Complexity
Component	Space Complexity
Shopping Cart	O(n)
Recently Viewed Stack	O(n)
Promotional Carousel	O(n)
Checkout Queue	O(n)
Product Dictionary	O(n)
Binary Search Extra Space	O(1)


Here, n represents the number of elements stored in the corresponding data structure.
15. Complexity Summary
Feature	Operation	Complexity
Cart	Add	O(1)
Cart	Search	O(n)
Cart	Remove	O(n)
Cart	Increase Quantity	O(n)
Cart	Decrease Quantity	O(n)
Cart	Display	O(n)
Stack	Push	O(1)
Stack	Pop	O(1)
Stack	Peek	O(1)
Carousel	Next Promotion	O(1)
Carousel	Display	O(n)
Queue	Enqueue	O(1)
Queue	Dequeue	O(1)
Dictionary	Add	O(1) average
Dictionary	Search	O(1) average
Dictionary	Remove	O(1) average
Sorting	Comparison-based sort	O(n²)
Binary Search	Search	O(log n)


16. Project Structure
DSA Test
│
├── Program.cs
├── Ecommerce.cs
├── Node.cs
├── ShoppingCart.cs
├── MostRecentsProducts.cs
├── PromoCarousel.cs
├── Payment.cs
├── PaymentNode.cs
├── SearchProduct.cs
├── SortProductByID.cs
│
└── Testing
    ├── Tests.cs
    └── Testing.csproj
The exact filenames may vary depending on the Visual Studio project organization.
17. Technologies Used
- C#
- .NET
- Visual Studio
- NUnit
- Data Structures and Algorithms
- Object-Oriented Programming
18. How to Run
Prerequisites
Install:
- Visual Studio
- .NET SDK
- NUnit test support
Run the Application
1. Open the project in Visual Studio.
2. Build the solution.
3. Run the application.
4. Enter the requested information through the console.
5. Follow the displayed options and operations.
The application uses console input for the relevant user-driven operations.
19. Running NUnit Tests
Open the project in Visual Studio.
Navigate to:
Test
   |
   v
Test Explorer
Then select:
Run All Tests
The NUnit tests verify cart operations, product lookup, sorting, checkout, promotions, edge cases, and integrated workflows.
20. Example User Input
The application can accept product information such as:
Enter number of products to add to cart: 3

Enter SKU: SKU001
Enter product name: Laptop
Enter price: 50000
Enter rating: 4.5

Enter SKU: SKU002
Enter product name: Phone
Enter price: 30000
Enter rating: 4.2

Enter SKU: SKU003
Enter product name: Tablet
Enter price: 20000
Enter rating: 4.0
The Node implementation also extracts the numeric portion of an SKU beginning with SKU, such as SKU001.
21. Example Output
E-Commerce System
------------------

Cart:
1 Laptop Quantity: 1
2 Phone Quantity: 1
3 Tablet Quantity: 1

Updated Cart:
...

Total = ...

Latest Viewed: iPad

Promotion 1: 50% OFF
Promotion 2: Buy 1 Get 1
Promotion 3: 20% OFF
Promotion 4: 50% OFF

Product Lookup:
...

Products Sorted By Price:
...

Products Sorted By Rating:
...

Binary Search:
...

Checkout:
...

Program completed.
The exact output depends on the values entered during execution.
22. Design Principles
The project follows a modular design in which each class has a specific responsibility.
ShoppingCart
      |
      +--> Cart operations


MostRecentsProducts
      |
      +--> Recently viewed operations


PromoCarousel
      |
      +--> Promotion operations


SearchProduct
      |
      +--> Product lookup


SortProductByID
      |
      +--> Sorting
      +--> Binary Search


Payment
      |
      +--> Checkout operations
This separation makes the system easier to understand, test, and maintain.
23. Limitations
This project is primarily designed as a Data Structures and Algorithms demonstration.
It is a console-based application and does not currently provide:
- Database persistence
- User authentication
- Real payment gateway integration
- Web-based frontend
- External product APIs
- Real-time inventory management
- Order tracking
These features are outside the scope of the current DSA implementation.
24. Future Enhancements
The project can be extended with:
- Database integration
- User authentication
- Product categories
- Inventory management
- Order history
- Coupon management
- Web or desktop user interface
- Real payment gateway integration
- Advanced product filtering
- More efficient sorting algorithms
- Persistent recently viewed history
25. Learning Outcomes
This project demonstrates practical understanding of:
- Doubly linked lists
- Stack
- Circular linked lists
- Queue
- Dictionary/hash-based lookup
- Sorting algorithms
- Binary search
- Time complexity
- Space complexity
- Edge-case handling
- Unit testing
- Object-oriented programming
- Modular system design
- Data structure integration
26. Conclusion
The E-Commerce Cart & Recently Viewed System demonstrates how different data structures and algorithms can be applied to practical e-commerce operations.
A doubly linked list is used for shopping cart management, a stack manages recently viewed products, a circular linked list implements the promotional carousel, a queue handles checkout, and a dictionary provides product lookup.
The system also provides sorting and binary search functionality and integrates multiple components through complete workflows.
NUnit testing is used to validate the implemented functionality, including normal operations, invalid inputs, empty structures, and integrated workflows.
Overall, the project demonstrates how selecting an appropriate data structure for a specific requirement can result in a modular, understandable, and efficient e-commerce system.
