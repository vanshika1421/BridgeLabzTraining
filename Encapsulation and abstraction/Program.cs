namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Employee> employees = new List<Employee>();
            //FulltimeEmployee emp1 = new FulltimeEmployee(101,
            //    "Rahul",
            //    30000,
            //    10000);

            //PartTimeEmployee emp2 = new PartTimeEmployee(
            //    102,
            //    "Priya",
            //    5000,
            //    80,
            //    250);


            //emp1.AssignDepartment("HR");
            //emp2.AssignDepartment("IT");

            //employees.Add(emp1);
            //employees.Add(emp2);

            //Console.WriteLine("Employee Details\n");

            //foreach (Employee employee in employees)
            //{
            //    employee.DisplayDetails();

            //    IDepartment department = (IDepartment)employee;
            //    Console.WriteLine("Department : " + department.GetDepartmentDetails());

            //    Console.WriteLine("-----------------------------------");
            //}

            //List<Product> products = new List<Product>();
            //Electronics e = new Electronics(201, "Smartphone", 50000);
            //Groceries g = new Groceries(202, "Rice", 1000);
            //Clothing c = new Clothing(203, "T-Shirt", 500);
            //e.CalculateDiscount();
            //e.CalculateTax();
            //e.displayProductDetails();
            //g.CalculateDiscount(); g.CalculateTax();
            //g.displayProductDetails();
            //List<foodItems> list = new List<foodItems>();
            //foodItems veg = new VegItems("Panner" , 250.78 , 20);
            //foodItems nonVeg = new NonVegItems("chicken" , 350 , 40);
            //veg.CalculateTotalPrice();
            //if(veg is IDiscountable discount)
            //{
            //    discount.ApplyDiscount();
            //    discount.GetDiscountDetails();
            //}
            //veg.getItemDetails();

            //nonVeg.CalculateTotalPrice();
            //if (nonVeg is IDiscountable dis)
            //{
            //    dis.ApplyDiscount();
            //    dis.GetDiscountDetails();
            //}
            //nonVeg.getItemDetails();
            //List<Library> libraryItems = new List<Library>();
            //Library lb = new Book(101 , "The Great Gatsby" , "F. Scott Fitzgerald");
            //Library lb2 = new Magazine(102, "Time", "Henry Luce");
            //Library lb3 = new Book(103, "To Kill a Mockingbird", "Harper Lee");

            //libraryItems.Add(lb);
            //libraryItems.Add(lb2);
            //libraryItems.Add(lb3);
            //foreach (Library l in libraryItems)
            //{
            //    l.DisplayDetails();
            //    Console.WriteLine("Loan Duration: " + l.GetLoanDuration() + " days");
            //    if (l is IReservable reservable)
            //    {
            //        reservable.ReserveItem();
            //        Console.WriteLine("Availability: " + (reservable.CheckAvailability() ? "Available" : "Not Available"));
            //    }
            //    Console.WriteLine("-----------------------------------");
            //}
            //List<Vehicle> vehicles = new List<Vehicle>()
            //{
            //    new Car(1, "John Doe", 10.0),
            //    new Bike(2, "Jane Smith", 5.0),
            //    new Auto(3, "Mike Johnson", 7.0),

            //};
            //foreach (Vehicle v in vehicles)
            //{

            //    v.GetVehicleDetails();


            //}
            //static void PatientCheck(Patient v)
            //{
            //   v.getPateientsDetails();

            //    if (v is IMedicalRecord record)
            //    {

            //        record.ViewRecords();
            //    }



            //    Console.WriteLine();
            //}

            //Patient p1 = new InPatient(1, "John Doe", 30);
            //Patient p2 = new OutPatient(2, "Jane Smith", 25);
            //Patient p3 = new InPatient(3, "Mike Johnson", 40);
            //Patient p4 = new OutPatient(4, "Emily Davis", 35);

            //((IMedicalRecord)p1).AddRecord("Fever" , "No prior medical history");
            //((IMedicalRecord)p2).AddRecord("Headache", "No prior medical history");
            //((IMedicalRecord)p3).AddRecord("Diabetes", "Family history of diabetes");
            //((IMedicalRecord)p4).AddRecord("Allergy", "Allergic to pollen");
            //PatientCheck(p1);
            //PatientCheck(p2);
            //PatientCheck(p3);
            //PatientCheck(p4);
            BankAccont sv = new SavingAccount(101, "John Doe", 5000);
            BankAccont ca = new CurrentAccount(102, "Jane Smith", 000);
            BankAccont sv2 = new SavingAccount(103, "Mike Johnson", 8000);
            BankAccont ca2 = new CurrentAccount(104, "Emily Davis", 20000);

            sv.Deposit(85230);
            Console.Write(sv.balance);
            accountDetails(sv);
            accountDetails(ca);
            accountDetails(sv2);
            accountDetails(ca2);

        }

            public static void accountDetails(BankAccont account)
        {
            Console.WriteLine("Account Number: " + account.accountNumber);
            Console.WriteLine("Holder Name: " + account.holderName);
            Console.WriteLine("Balance: " + account.balance);
            Console.WriteLine("Interest: " + account.CalculateInterest());
            if (account is ILoanable loanable)
            {
                loanable.ApplyForLoan(10000);
                loanable.CalculateLoanEligibility(10000);
            }
        }

    }
    }
