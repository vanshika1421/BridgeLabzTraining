
using System;
namespace Level2;

class Program
{
    static void Main()
    {

      using System;

namespace Level2
{
    class FilterStudents
    {
        public void Filter()
        {
            Console.WriteLine("FilterStudents.Filter called.");
        }
    }
}

        Console.WriteLine();

        
        SearchEmployee search = new SearchEmployee();
        search.Search();

        Console.WriteLine();

       
        UpdateEmployeeSalary update = new UpdateEmployeeSalary();
        update.UpdateSalary();

        Console.WriteLine();

        
        SortEmployees sort = new SortEmployees();
        sort.Sort();
    }
}