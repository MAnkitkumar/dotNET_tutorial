using System;
using ComputerSystem;

public class Laptop : Computer
{
    public int DisplaySize { get; set; }
    public int BatteryVolt { get; set; }

    public int LaptopPriceCalculation()
    {
        int processorCost = 0;
        if (Processor == "i3") processorCost = 2500;
        else if (Processor == "i5") processorCost = 5000;
        else if (Processor == "i7") processorCost = 6500;

        int ramPrice = 200;
        int hdPrice = 1500;
        int gcPrice = 2500;
        int batteryPrice = 20;
        int displayPrice = 250;

        return processorCost + (RamSize * ramPrice) + (HardDiskSize * hdPrice) + (GraphicCard * gcPrice) + (DisplaySize * displayPrice) + (BatteryVolt * batteryPrice);
    }
}