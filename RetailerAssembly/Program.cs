using System;

/// <summary>
/// Lab08
/// @author Jared Daniel
/// @author Stuart Walters
/// </summary>
namespace RetailerAssembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Retailer retailer = new Retailer();
            int budget; 

            Console.WriteLine("Enter budget for TV:");
            budget = Convert.ToInt32(Console.ReadLine());
            
            retailer.OrderTV(budget);
        }
    }
}
