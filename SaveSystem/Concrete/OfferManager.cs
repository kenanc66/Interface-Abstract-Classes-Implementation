using SaveSystem.Abstract;
using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Concrete
{
    public class OfferManager:IOfferService
    {
        public void AddOffer(Offer offer)
        {
            
            Console.WriteLine("Offer " + offer.OfferName+ " added "+"Last :"+offer.OfferCount+" chance to use this offer");
        }
    }
}
