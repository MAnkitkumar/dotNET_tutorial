using System;
using ComputerSystem;

public class Desktop : Computer
{
    public int MonitorSize { get; set; }
    public int PowerSupplyVolt { get; set; }

    public int DesktopPriceCalculation()
    {
        int processorCost = 0;
        if (Processor == "i3") processorCost = 1500;
        else if (Processor == "i5") processorCost = 3000;
        else if (Processor == "i7") processorCost = 4500;

        int ramPrice = 200;
        int hdPrice = 1500;
        int gcPrice = 2500;
        int psPrice = 20;
        int monPrice = 250;

        return processorCost + (RamSize * ramPrice) + (HardDiskSize * hdPrice) + (GraphicCard * gcPrice) + (MonitorSize * monPrice) + (PowerSupplyVolt * psPrice);
    }
}    