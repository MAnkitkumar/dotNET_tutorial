using System;
using System.Diagnostics;

namespace CakeWorld
    {
        public class Cake
    {
        public string? Flavour {get;set;}
        public int QuantityInKg {get;set;}  

        public  double PricePerKg {get;set;}

        public bool CakeOrder()
        {
            if(Flavour!="Vanilla" && Flavour!="Chocolate" && Flavour != "DarkForest")
            {
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour");

            }

            if (QuantityInKg <= 0)
            {
                throw new InvalidFlavourException("Quantity must be greater than zero");
            }

            return true;
        }


        public double CalculatePrice()
        {
            double Discount = 0;

            if (Flavour == "Vanilla")
            {
                Discount = 3;
            }
            else if (Flavour == "Chocolate")
            {
                Discount = 5;
            }
            else if(Flavour== "DarkForest")
            {
                Discount = 7;
            }

            
            double Total = QuantityInKg * PricePerKg;

            return Total - (Total * (Discount/100));

            // aur ab acting krlo 

            int abc
        }


    }


    }
