using System;

namespace MarketStore
{
    public class BronzeCard : Cards
    {
       public BronzeCard(double turnover, double purchaseValue):base( turnover,  purchaseValue)
       {
            Turnover = turnover;
            DiscountRate = CalculateDiscountRate(turnover);
       }
        public override double CalculateDiscountRate(double turnover)
        {
            if (turnover > 100 && turnover < 300)
            {
                return DiscountRate = 0.01;
            }
            else if (turnover > 300)
            {
                return DiscountRate = 0.025;
            }
            else
            {
                return DiscountRate = 0; 
            }
        }
    }
}
