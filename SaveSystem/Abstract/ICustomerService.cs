using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Abstract
{
   public interface ICustomerService
{
        void AddCustomer(Customer customer);

        void DeleteCustomer(Customer customer);
    }
}
