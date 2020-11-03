using System;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        { 
            Cards bronzeCard = new BronzeCard(0, 150);
            bronzeCard.PrintData();

            Cards silverCard = new SilverCard(600, 850);
            silverCard.PrintData();

            Cards goldCard = new GoldCard(1500, 1300);
            goldCard.PrintData();
            Console.Read();
        }
    }
}
