// See https://aka.ms/new-console-template for more information
using System;
using ComputerSystem;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.Desktop");
        Console.WriteLine("2.Laptop");
        Console.WriteLine("Choose the option");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Desktop desktop = new Desktop();
            Console.WriteLine("Enter the processor Example i3, i5, i7");
            desktop.Processor = Console.ReadLine();
            Console.WriteLine("Enter the ram size eg: 8, 16 (Gb)");
            desktop.RamSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size ex Int type : ");
            desktop.HardDiskSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the graphic card size in gb :");
            desktop.GraphicCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monitor size in inch :");
            desktop.MonitorSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power supply volt");
            desktop.PowerSupplyVolt = int.Parse(Console.ReadLine());

            int price = desktop.DesktopPriceCalculation();
            Console.WriteLine("Desktop price is " + price);
        }
        else if (choice == 2)
        {
            Laptop laptop = new Laptop();
            Console.WriteLine("Enter the processor");
            laptop.Processor = Console.ReadLine();
            Console.WriteLine("Enter the ram size");
            laptop.RamSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size");
            laptop.HardDiskSize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the graphic card size");
            laptop.GraphicCard = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the display size");
            laptop.DisplaySize = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the battery volt");
            laptop.BatteryVolt = int.Parse(Console.ReadLine());

            int price = laptop.LaptopPriceCalculation();
            Console.WriteLine("Laptop price is " + price);
        }
    }
}
