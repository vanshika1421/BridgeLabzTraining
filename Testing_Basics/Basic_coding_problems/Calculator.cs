namespace Unit_testing_examples
{
    public class Calculator
    {
        public static void Main(String[] args)
        {
           // Console.WriteLine("Enter 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division");
           int choice = 1;
          //  Console.WriteLine("Enter two numbers");
            int a = 2;
            int b = 3;
            switch (choice)
            {
                case 1: Console.WriteLine(Add(a, b));
                        break;
                case 2:
                    Console.WriteLine(Subtract(a, b));
                    break;
                case 3:
                    Console.WriteLine(Multiply(a, b));
                    break;
                case 4: 
                    Console.WriteLine(Divide(a, b)); 
                    break;
                
            }
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return a / b;
        }
    }
      
     

    
}
