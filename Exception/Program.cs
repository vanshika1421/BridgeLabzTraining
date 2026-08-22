using System;
using Exception;

namespace Exceptions
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //HandlingFileNotFound hf = new HandlingFileNotFound();

            //hf.Read("ABC.txt");

            //HandlingDivisionAndInputErrors h = new HandlingDivisionAndInputErrors();
            //h.check(4, 2);
            //CreatingAndHandlingCustomException c = new CreatingAndHandlingCustomException();
            //c.ValidateAge(15);
            int[] arr = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            //HandlingMultipleExceptions handlingMultipleExceptions = new HandlingMultipleExceptions();
            //handlingMultipleExceptions.printArray(arr, 6);
            //usingUsingKeyword us = new usingUsingKeyword();
            //us.usingKey("ABCc.txt");
            //InvalidInput i = new InvalidInput();
            //try
            //{
            //    i.InputCheck(-500);
            //}
            //catch(InvalidInputException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //FinallyBlockExecution f     = new FinallyBlockExecution();
            //f.Divide(5, 0);
            //PropagatingExceptionAcrossMethod p = new PropagatingExceptionAcrossMethod();
            //try
            //{
            //    p.Method2(3, 0);
            //}
            //catch(DivideByZeroException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //NestedTryCatch n = new NestedTryCatch();
            //n.DivideArray(arr, 0);
            BankTransaction b  = new BankTransaction();

            try
            {
                b.Withdraw(-820, 100);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InsufficientFundsException e) { 
            Console.WriteLine(e.Message);
            }

        }

    }
}