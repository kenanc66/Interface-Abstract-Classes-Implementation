using SaveSystem.Concrete;
using SaveSystem.Entities;
using System;

namespace SaveSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer() {
                CustomerId = 1,
                DateOfBirth = new DateTime(1996, 07, 18),
                FirstName = "Kenan",
                LastName = "ÇİÇEK",
                NationalityId="11010078750"
            };

            Game game1 = new Game() { GameId = 1, GameName = "Cs", GamePrice = 50 };

            Offer offer1 = new Offer() { OfferId=1, 
                OfferCount=10,OfferName="Discount for the first 10 people",OfferDiscount="50%"};

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(customer1, game1);

        }
    }
}
