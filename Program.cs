// See https://aka.ms/new-console-template for more information

namespace Medical;
class Program
{
    static PatientBill lb = null;
    static bool hasLb = false;

    static void Main()
    {
        bool run = true;
        while (run)
        {
            Console.WriteLine("\n================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");

            switch (Console.ReadLine())
            {
                case "1": Add(); break;
                case "2": View(); break;
                case "3": Clr(); break;
                case "4": 
                    Console.WriteLine("Thank you. Application closed normally.");
                    run = false; 
                    break;
                default: Console.WriteLine("Invalid option."); break;
            }
        }
    }


    static void Add()
    {
        PatientBill bill = new PatientBill();
        
        Console.Write("Enter Bill Id: ");
        bill.Id = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(bill.Id)) { Console.WriteLine("Error: Bill Id required."); return; }

        Console.Write("Enter Patient Name: ");
        bill.Nm = Console.ReadLine();

        Console.Write("Is the patient insured? (Y/N):");
        bill.Ins = Console.ReadLine().ToUpper() == "Y";

        Console.Write("Enter Consultation Fee: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.CFee) || bill.CFee <= 0) 
        { Console.WriteLine("Error: Invalid Fee."); return; }

        Console.Write("Enter Lab Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.LChg) || bill.LChg < 0) 
        { Console.WriteLine("Error: Invalid Lab Charge."); return; }

        Console.Write("Enter Medicine Charges: ");
        if (!decimal.TryParse(Console.ReadLine(), out bill.MChg) || bill.MChg < 0) 
        { Console.WriteLine("Error: Invalid Med Charge."); return; }

        bill.Grs = bill.CFee + bill.LChg + bill.MChg;
        bill.Dsc = bill.Ins ? bill.Grs * 0.10m : 0;
        bill.Net = bill.Grs - bill.Dsc;

        lb = bill;
        hasLb = true;

        Console.WriteLine($"\nBill created successfully.\nGross: {bill.Grs:F2}\nDiscount: {bill.Dsc:F2}\nPayable: {bill.Net:F2}");
    }

static void View()
    {
        if (!hasLb) { Console.WriteLine("No bill available. Please create a new bill first."); return; }

        Console.WriteLine("\n----------- Last Bill -----------");
        Console.WriteLine($"BillId: {lb.Id}");
        Console.WriteLine($"Patient: {lb.Nm}");
        Console.WriteLine($"Insured: {(lb.Ins ? "Yes" : "No")}");
        Console.WriteLine($"Consultation Fee: {lb.CFee:F2}");
        Console.WriteLine($"Lab Charges: {lb.LChg:F2}");
        Console.WriteLine($"Medicine Charges: {lb.MChg:F2}");
        Console.WriteLine($"Gross Amount: {lb.Grs:F2}");
        Console.WriteLine($"Discount Amount: {lb.Dsc:F2}");
        Console.WriteLine($"Final Payable: {lb.Net:F2}");
    }

    static void Clr()
    {
        lb = null;
        hasLb = false;
        Console.WriteLine("Last bill cleared.");
    }


}