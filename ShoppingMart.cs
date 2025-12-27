using System;

namespace Mart
{
    public class SaleTransaction
    {
        public string? Inv;
        public string? Cust;
        public string? Itm;
        public int Qty;
        public decimal PAmt;
        public decimal SAmt;
        public string? Stat;
        public decimal PLAmt;
        public decimal Marg;
    }

    public class ShoppingMart
    {
        public static SaleTransaction? lt = null;
        public static bool hasLt = false;

        public static void Add()
        {
            SaleTransaction t = new SaleTransaction();
            
            Console.Write("Enter Invoice No: ");
            t.Inv = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(t.Inv)) { Console.WriteLine("Error: Invoice No required."); return; }

            Console.Write("Enter Customer Name: ");
            t.Cust = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            t.Itm = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            if (!int.TryParse(Console.ReadLine(), out t.Qty) || t.Qty <= 0) 
            { Console.WriteLine("Error: Qty must be > 0."); return; }


            Console.Write("Enter Purchase Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out t.PAmt) || t.PAmt <= 0) 
            { Console.WriteLine("Error: Purchase Amount must be > 0."); return; }

            Console.Write("Enter Selling Amount (total): ");
            if (!decimal.TryParse(Console.ReadLine(), out t.SAmt) || t.SAmt < 0) 
            { Console.WriteLine("Error: Selling Amount must be >= 0."); return; }

            if (t.SAmt > t.PAmt)
            {
                t.Stat = "PROFIT";
                t.PLAmt = t.SAmt - t.PAmt;
            }

            else if (t.SAmt < t.PAmt)
            {
                t.Stat = "LOSS";
                t.PLAmt = t.PAmt - t.SAmt;
            }
            else
            {
                t.Stat = "BREAK-EVEN";
                t.PLAmt = 0;
            }

            t.Marg = (t.PLAmt / t.PAmt) * 100;

            lt = t;
            hasLt = true;

            Console.WriteLine("\nTransaction saved successfully.");
            Console.WriteLine($"Status: {t.Stat}");
            Console.WriteLine($"Profit/Loss Amount: {t.PLAmt:F2}");
            Console.WriteLine($"Profit Margin (%): {t.Marg:F2}");
        }

        public static void View()
        {
            if (!hasLt) { Console.WriteLine("No transaction available. Please create a new transaction first."); return; }

            Console.WriteLine("\n-------------- Last Transaction --------------");
            Console.WriteLine($"InvoiceNo: {lt!.Inv}");
            Console.WriteLine($"Customer: {lt!.Cust}");
            Console.WriteLine($"Item: {lt!.Itm}");
            Console.WriteLine($"Quantity: {lt!.Qty}");
            Console.WriteLine($"Purchase Amount: {lt!.PAmt:F2}");
            Console.WriteLine($"Selling Amount: {lt!.SAmt:F2}");
            Console.WriteLine($"Status: {lt!.Stat}");
            Console.WriteLine($"Profit/Loss Amount: {lt!.PLAmt:F2}");
            Console.WriteLine($"Profit Margin (%): {lt!.Marg:F2}");
        }


        public static void Calc()
        {
            if (!hasLt) { Console.WriteLine("No transaction available. Please create a new transaction first."); return; }
            
            Console.WriteLine("\n--- Recomputed Profit/Loss ---");
            Console.WriteLine($"Status: {lt!.Stat}");
            Console.WriteLine($"Profit/Loss Amount: {lt!.PLAmt:F2}");
            Console.WriteLine($"Profit Margin (%): {lt!.Marg:F2}");
        }
    }
}