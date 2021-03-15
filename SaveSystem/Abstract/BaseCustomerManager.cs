using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public virtual void DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
