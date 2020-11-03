using System;

namespace MarketStore
{
    class GoldCard: Cards
    {
        public GoldCard(double turnover, double purchaseValue) : base(turnover, purchaseValue)
        {
            Turnover = turnover;
            DiscountRate = CalculateDiscountRate(turnover);
        }
        public override double CalculateDiscountRate(double turnover)
        {
            if (turnover < 100 )
            {
                return DiscountRate = 0.02;
            }
            else if (turnover > 1000)
            {
                return DiscountRate = 0.10;
            }
            else
            {
                return DiscountRate = 0.02 + 0.01 * (turnover / 100);
            }
        }
    }
}

