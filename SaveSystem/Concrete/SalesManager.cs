using SaveSystem.Abstract;
using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Concrete
{
    public class SalesManager:ISalesService
    {
        

        public void Sale(Customer customer, Game game)
        {
            Console.WriteLine("Customer: " + customer.FirstName + " Game: " + game.GameName);
        }

    }
}
