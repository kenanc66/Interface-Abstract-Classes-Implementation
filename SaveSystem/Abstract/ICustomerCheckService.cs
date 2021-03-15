using SaveSystem.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveSystem.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
