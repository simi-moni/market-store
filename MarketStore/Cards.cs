using System;

namespace MarketStore
{
    public abstract class Cards
    {
        public string OwnerName { get; set; }
        public double Turnover { get; set; }
        public double DiscountRate { get; set; }
        public double PurchaseValue { get; set; }

        public Cards(double turnover, double purchaseValue)
        {
            if(turnover < 0 || purchaseValue < 0)
            {
                throw new ArgumentException("Turnover or purchase value is out of range");
            }
            OwnerName = "";
            Turnover = turnover;
            DiscountRate = 0;
            PurchaseValue = purchaseValue;
        }

        public abstract double CalculateDiscountRate(double turnover);

        public double CalculateDiscount(double rateDiscount, double valueOfPurchase)
        {
            return rateDiscount * valueOfPurchase;
        }

        public void PrintData()
        {
            double discount = CalculateDiscount(DiscountRate, PurchaseValue); 
            Console.WriteLine("Purchase value: $" + PurchaseValue.ToString("0.00"));
            Console.WriteLine($"Discount rate: {DiscountRate*100}%");
            Console.WriteLine("Discount: $" + discount.ToString("0.00"));
            Console.WriteLine("Total: $" + (PurchaseValue-discount).ToString("0.00"));
        }
    }
}
