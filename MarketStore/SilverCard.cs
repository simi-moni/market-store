using System;

namespace MarketStore
{
    public class SilverCard : Cards
    {
        public SilverCard(double turnover, double purchaseValue) : base(turnover, purchaseValue)
        {
            Turnover = turnover;
            DiscountRate = CalculateDiscountRate(turnover);
        }
        public override double CalculateDiscountRate(double turnover)
        {
            if (turnover > 300)
            {
                return DiscountRate = 0.035;
            }
            else
            {
                return DiscountRate = 0.02;
            }
        }
    }
}
