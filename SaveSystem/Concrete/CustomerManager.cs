using SaveSystem.Abstract;
using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Concrete
{
    public class CustomerManager : BaseCustomerManager
    {
        

        public override void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer "+customer.FirstName+" added.");
        }

       

        public override void DeleteCustomer(Customer customer) {
            Console.WriteLine("Customer " + customer.FirstName + " deleted.");
        }

    }
}
