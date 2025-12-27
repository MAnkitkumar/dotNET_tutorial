// See https://aka.ms/new-console-template for more information

using Mart;

class Program
{
    static void Main()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("\n================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            switch (Console.ReadLine())
            {
                case "1": ShoppingMart.Add(); break;
                case "2": ShoppingMart.View(); break;
                case "3": ShoppingMart.Calc(); break;
                case "4": 
                    Console.WriteLine("Thank you. Application closed normally.");
                    run = false; 
                    break;
                default: Console.WriteLine("Invalid option. Try again."); break;
            }
        }
    }

}